using Projeto.Classes;
using Projeto.Classes.DbClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto.Forms
{
    public partial class FormDoadores : Form
    {
        DbConnection conexao = new DbConnection();

        BindingList<Dador> listaDadores;
        List<CategoriaDador> listaCategoriaD;
        List<Local> listaLocal;

        bool inserir = false;
        bool flag;
        public FormDoadores()
        {
            InitializeComponent();
        }

        private void PreencheComboCategoriaD()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                listaCategoriaD = new List<CategoriaDador>();
                string sql = "select * from categoriadadores";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CategoriaDador tipo = new CategoriaDador(reader.GetInt32("id_categoria_d"), reader.GetString("designacao"));
                            listaCategoriaD.Add(tipo);
                        }
                    }
                }
                cmbTipo.DisplayMember = "Descrição";
                cmbTipo.DataSource = listaCategoriaD;
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
           
        }

        private void PreencheComboLocal()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                listaLocal = new List<Local>();
                string sql = "select * from locais";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Local local = new Local(reader.GetString("cod_postal"), reader.GetString("localidade"));
                            listaLocal.Add(local);
                        }
                    }
                }

                cbLocal.DisplayMember = "Descrição";
                cbLocal.DataSource = listaLocal;

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private CategoriaDador RetornaCategoriaD(int idCategoria)
        {
            foreach (CategoriaDador categoria in listaCategoriaD)
                if (categoria.CodCategoriaDador == idCategoria)
                    return categoria;
            return null;
        }

        private Local RetornaLocal(string idLocal)
        {
            foreach (Local local in listaLocal)
                if (local.CodLocal == idLocal)
                    return local;
            return null;
        }


        private void ListaDadoresG()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select * from dadores";
                listaDadores = new BindingList<Dador>();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaDadores.Add(new Dador(reader.GetInt32("id_dador"),
                                                  reader.GetString("nome"),
                                                  RetornaCategoriaD(reader.GetInt32("id_categoria_d")),
                                                  reader.GetString("morada"),
                                                  RetornaLocal(reader.GetString("cod_postal")),
                                                  reader.GetString("NIF")));
                        }
                    }
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            

            gridDadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDadores.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridDadores.MultiSelect = false;
            gridDadores.DataSource = listaDadores;

            DataGridViewButtonColumn editar = new DataGridViewButtonColumn();
            editar.HeaderText = "";
            editar.Text = "Editar";
            editar.DefaultCellStyle.SelectionBackColor = Color.Green;
            editar.DefaultCellStyle.ForeColor = Color.White;
            editar.DefaultCellStyle.SelectionForeColor = Color.White;
            editar.DefaultCellStyle.SelectionBackColor = Color.Green;
            editar.DefaultCellStyle.BackColor = Color.Green;
            editar.FlatStyle = FlatStyle.Flat;
            editar.UseColumnTextForButtonValue = true;
            gridDadores.Columns.Add(editar);

            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();
            eliminar.HeaderText = "";
            eliminar.Text = "Eliminar";
            eliminar.DefaultCellStyle.SelectionBackColor = Color.Red;
            eliminar.DefaultCellStyle.ForeColor = Color.White;
            eliminar.DefaultCellStyle.SelectionForeColor = Color.White;
            eliminar.DefaultCellStyle.BackColor = Color.Red;
            eliminar.FlatStyle = FlatStyle.Flat;
            eliminar.UseColumnTextForButtonValue = true;
            gridDadores.Columns.Add(eliminar);


            gridDadores.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridDadores.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridDadores.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridDadores.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridDadores.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridDadores.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;

            gridDadores.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            gridDadores.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            foreach (DataGridViewColumn c in gridDadores.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 12.5F, GraphicsUnit.Pixel);
            }

            gridDadores.RowHeadersVisible = false;
            gridDadores.Columns[0].Visible = false;
            gridDadores.Columns[1].Width = 200;
            gridDadores.Columns[2].Width = 120;
            gridDadores.Columns[3].Width = 185;
            gridDadores.Columns[4].Width = 120;
            gridDadores.Columns[5].Width = 78;
            gridDadores.Columns[6].Width = 50;
            gridDadores.Columns[7].Width = 65;
        }
        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag)
            {
                PreencheComboCategoriaD();
                cmbTipo.SelectedIndex = cmbTipo.Items.Count - 1;

            }
            else
            {
                PreencheComboLocal();
                cbLocal.SelectedIndex = cbLocal.Items.Count - 1;
            }
            
            
        }

        public void ListaDadoresPesquisados(string query)
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();

                listaDadores = new BindingList<Dador>();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaDadores.Add(new Dador(reader.GetInt32("id_dador"),
                                                   reader.GetString("nome"),
                                                   RetornaCategoriaD(reader.GetInt32("id_categoria_d")),
                                                   reader.GetString("morada"),
                                                   RetornaLocal(reader.GetString("cod_postal")),
                                                   reader.GetString("NIF")));
                        }
                    }
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            

            gridDadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDadores.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridDadores.MultiSelect = false;
            gridDadores.DataSource = listaDadores;

        }

       
        private void FormDoadores_Load(object sender, EventArgs e)
        {
           gridDadores.BackgroundColor = Color.White;

            PreencheComboLocal();
            PreencheComboCategoriaD();
            ListaDadoresG();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            PreencheComboLocal();
            PreencheComboCategoriaD();

            txtNome.Enabled = true;
            cbLocal.Enabled = true;
            cmbTipo.Enabled = true;
            txtNif.Enabled = true;
            txtMorada.Enabled = true;

            txtPesquisa.Enabled = false;
            txtNome.Text = "";
            cbLocal.SelectedIndex = -1;
            txtNif.Text = "";
            cmbTipo.SelectedIndex = -1;
            txtMorada.Text = "";

            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;

            btnInsCat.Enabled = true;
            btnInsLocal.Enabled = true;

            inserir = true;
        }

        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            string sql = "SELECT id_dador, nome,  id_categoria_d, morada, cod_postal, nif FROM dadores WHERE nome LIKE '%" + txtPesquisa.Text + "%'";
            ListaDadoresPesquisados(sql);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            txtNome.Text = gridDadores.SelectedRows[0].Cells[3].Value.ToString();
            cmbTipo.Text = gridDadores.SelectedRows[0].Cells[4].Value.ToString();
            txtMorada.Text = gridDadores.SelectedRows[0].Cells[5].Value.ToString();
            cbLocal.Text = gridDadores.SelectedRows[0].Cells[6].Value.ToString();
            txtNif.Text = gridDadores.SelectedRows[0].Cells[7].Value.ToString();
       
            
            txtNome.Enabled = false;
            cbLocal.Enabled = false;
            cmbTipo.Enabled = false;
            txtNif.Enabled = false;
            txtMorada.Enabled = false;
            txtPesquisa.Enabled = true;
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;

            btnInsCat.Enabled = false;
            btnInsLocal.Enabled = false;
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                try
                {
                    if (inserir)
                    {
                        if ((txtNome.Text == "") || (cmbTipo.SelectedIndex == -1) || (cbLocal.SelectedIndex == -1) || (txtMorada.Text == "") || (txtNif.Text == ""))
                        {
                            MessageBox.Show("Por favor, preencha todos os campos.");
                        }
                        else
                        {
                            string sql = "insert into dadores values(0,@nome, @idcategoriad, @morada, @codpostal, @nif)";

                            using (MySqlCommand cmd = new MySqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                                cmd.Parameters.AddWithValue("@idcategoriad", ((CategoriaDador)cmbTipo.SelectedItem).CodCategoriaDador);
                                cmd.Parameters.AddWithValue("@morada", txtMorada.Text);
                                cmd.Parameters.AddWithValue("@codpostal", ((Local)cbLocal.SelectedItem).CodLocal);
                                cmd.Parameters.AddWithValue("@nif", txtNif.Text);

                                int nRegistos = cmd.ExecuteNonQuery();

                                MessageBox.Show("Registo inserido com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (nRegistos > 0)

                                {
                                    listaDadores.Add(new Dador((int)cmd.LastInsertedId, txtNome.Text, (CategoriaDador)cmbTipo.SelectedItem, txtMorada.Text, (Local)cbLocal.SelectedItem, txtNif.Text));
                                    gridDadores.Refresh();
                                    gridDadores.Rows[gridDadores.Rows.Count - 1].Selected = true;

                                }
                            }
                            txtNome.Enabled = false;
                            cbLocal.Enabled = false;
                            cmbTipo.Enabled = false;
                            txtNif.Enabled = false;
                            txtMorada.Enabled = false;
                            txtPesquisa.Enabled = true;

                            btnGravar.Enabled = false;
                            btnCancelar.Enabled = false;
                            btnNovo.Enabled = true;

                            btnInsCat.Enabled = false;
                            btnInsLocal.Enabled = false;
                        }

                    }
                    else
                    {

                        if (gridDadores.SelectedRows.Count > 0)
                        {
                            Dador Dador = (Dador)gridDadores.SelectedRows[0].DataBoundItem;

                            string sql = "update dadores set nome=@nome, id_categoria_d=@idcategoriad, morada=@morada, cod_postal=@local," +
                                    "nif=@nif where id_dador=@iddador";

                            using (MySqlCommand cmd = new MySqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                                cmd.Parameters.AddWithValue("@idcategoriad", ((CategoriaDador)cmbTipo.SelectedItem).CodCategoriaDador);
                                cmd.Parameters.AddWithValue("@morada", txtMorada.Text);
                                cmd.Parameters.AddWithValue("@local", ((Local)cbLocal.SelectedItem).CodLocal);
                                cmd.Parameters.AddWithValue("@nif", txtNif.Text);
                                cmd.Parameters.AddWithValue("@iddador", Dador.IdDador);

                                int nRegistos = cmd.ExecuteNonQuery();

                                MessageBox.Show("Registo atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (nRegistos > 0)
                                {
                                    Dador.Nome = txtNome.Text;
                                    Dador.CodPostal = (Local)cbLocal.SelectedItem;
                                    Dador.IdCategoriaD = (CategoriaDador)cmbTipo.SelectedItem;
                                    Dador.Morada = txtMorada.Text;
                                    Dador.Nif = txtNif.Text;
                                    gridDadores.Refresh();
                                }
                            }
                        }
                        txtNome.Enabled = false;
                        cbLocal.Enabled = false;
                        cmbTipo.Enabled = false;
                        txtNif.Enabled = false;
                        txtMorada.Enabled = false;
                        txtPesquisa.Enabled = true;

                        btnGravar.Enabled = false;
                        btnNovo.Enabled = true;
                        btnCancelar.Enabled = false;

                        btnInsCat.Enabled = false;
                        btnInsLocal.Enabled = false;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void gridDadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();

                if (e.ColumnIndex == 0)
                {
                    txtNome.Enabled = true;
                    cbLocal.Enabled = true;
                    cmbTipo.Enabled = true;
                    txtNif.Enabled = true;
                    txtMorada.Enabled = true;
                    txtPesquisa.Enabled = false;

                    btnNovo.Enabled = false;
                    btnGravar.Enabled = true;
                    btnCancelar.Enabled = true;

                    btnInsCat.Enabled = true;
                    btnInsLocal.Enabled = true;


                }

                if (e.ColumnIndex == 1)
                {

                    if (MessageBox.Show("Tem a certeza que quer eliminar o Dador?", "Informação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {

                            if (gridDadores.SelectedRows.Count > 0)
                            {
                                int nRow = gridDadores.SelectedRows[0].Index;
                                Dador dador = (Dador)gridDadores.SelectedRows[0].DataBoundItem;

                                string sql = "delete from dadores where id_dador=@iddador";

                                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                                {

                                    cmd.Parameters.AddWithValue("@iddador", dador.IdDador);
                                    int nRegistos = cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registo eliminado com suceso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (nRegistos == 1)
                                    {

                                        listaDadores.Remove(dador);

                                        gridDadores.Refresh();

                                        if (nRow > 0)
                                        {
                                            gridDadores.Rows[nRow - 1].Selected = true;
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERRO");
                        }
                    }
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }

        }

        private void gridDadores_SelectionChanged(object sender, EventArgs e)
        {
            if (gridDadores.SelectedRows.Count > 0)
            {

                Dador Dador = (Dador)gridDadores.SelectedRows[0].DataBoundItem;

                txtNome.Text = Dador.Nome;
                cmbTipo.Text = Dador.IdCategoriaD.ToString();
                txtMorada.Text = Dador.Morada;
                cbLocal.Text = Dador.CodPostal.ToString();
                txtNif.Text = Dador.Nif;

            }

            inserir = false;
        }

        private void btnInsCat_Click_1(object sender, EventArgs e)
        {
            FormCatDadores child = new FormCatDadores();
            child.FormClosed += new FormClosedEventHandler(child_FormClosed);
            flag = true;
            child.ShowDialog(this);
        }

        private void btnInsLocal_Click(object sender, EventArgs e)
        {
            FormLocalidades child = new FormLocalidades();
            child.FormClosed += new FormClosedEventHandler(child_FormClosed);
            flag = false;
            child.ShowDialog(this);
        }
    }
}

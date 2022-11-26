using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto.Forms
{
    public partial class FormReceptores : Form
    {
        DbConnection conexao = new DbConnection();
        BindingList<Recetor> listaRecetores;
        List<Turma> listaTurma;

        bool inserir = false;
        public FormReceptores()
        {
            InitializeComponent();

        }

        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreencheComboTurma();
            cmbTurma.SelectedIndex = cmbTurma.Items.Count - 1;
        }
        private void PreencheComboTurma()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                listaTurma = new List<Turma>();
                string sql = "select * from turmas";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Turma tipo = new Turma(reader.GetString("turma"), reader.GetString("descricao"));
                            listaTurma.Add(tipo);
                        }
                    }
                }
                cmbTurma.DisplayMember = "Descrição";
                cmbTurma.DataSource = listaTurma;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           
        }
        private void ListaTurmas()
        {

            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select * from recetores";
                listaRecetores = new BindingList<Recetor>();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaRecetores.Add(new Recetor(reader.GetInt32("id_recetor"),
                                                    reader.GetString("nome"),
                                                    reader.GetString("turma"),
                                                    reader.GetString("enc_educacao")));
                        }
                    }
                }

                gridRecetor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridRecetor.EditMode = DataGridViewEditMode.EditProgrammatically;
                gridRecetor.MultiSelect = false;
                gridRecetor.DataSource = listaRecetores;

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
                gridRecetor.Columns.Add(editar);

                DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();
                eliminar.HeaderText = "";
                eliminar.Text = "Eliminar";
                eliminar.DefaultCellStyle.SelectionBackColor = Color.Red;
                eliminar.DefaultCellStyle.ForeColor = Color.White;
                eliminar.DefaultCellStyle.SelectionForeColor = Color.White;
                eliminar.DefaultCellStyle.BackColor = Color.Red;
                eliminar.FlatStyle = FlatStyle.Flat;
                eliminar.UseColumnTextForButtonValue = true;
                gridRecetor.Columns.Add(eliminar);


                gridRecetor.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridRecetor.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridRecetor.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridRecetor.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridRecetor.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;


                gridRecetor.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                gridRecetor.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;


                foreach (DataGridViewColumn c in gridRecetor.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 12.5F, GraphicsUnit.Pixel);
                }


                gridRecetor.RowHeadersVisible = false;
                gridRecetor.Columns[0].Visible = false;
                gridRecetor.Columns[1].Width = 260;
                gridRecetor.Columns[2].Width = 160;
                gridRecetor.Columns[3].Width = 240;
                gridRecetor.Columns[4].Width = 78;
                gridRecetor.Columns[5].Width = 78;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
          


        }
        private void FormReceptores_Load(object sender, EventArgs e)
        {
            gridRecetor.BackgroundColor = Color.White;

            PreencheComboTurma();
            ListaTurmas();
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            PreencheComboTurma();

            txtNome.Enabled = true;
            cmbTurma.Enabled = true;
            txtEE.Enabled = true;
            txtPesquisa.Enabled = false;
            txtNome.Text = "";
            txtEE.Text = "";
            cmbTurma.SelectedIndex = -1;

            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;

            btnInsTurma.Enabled = true;

            inserir = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = gridRecetor.SelectedRows[0].Cells[3].Value.ToString();
            cmbTurma.Text = gridRecetor.SelectedRows[0].Cells[4].Value.ToString();
            txtEE.Text = gridRecetor.SelectedRows[0].Cells[5].Value.ToString();

            txtNome.Enabled = false;
            cmbTurma.Enabled = false;
            txtEE.Enabled = false;
            txtPesquisa.Enabled = true;

            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conexao.FazerConexao();
            try
            {
                if (inserir)
                {
                    if ((txtNome.Text == "") || (cmbTurma.SelectedIndex == -1) || (txtEE.Text == ""))
                    {
                        MessageBox.Show("Por favor, preencha todos os campos.");
                    }
                    else
                    {
                        string sql = "insert into recetores values(0,@nome, @turma, @ee)";

                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                            cmd.Parameters.AddWithValue("@turma", cmbTurma.SelectedItem);
                            cmd.Parameters.AddWithValue("@ee", txtEE.Text);

                            int nRegistos = cmd.ExecuteNonQuery();

                            MessageBox.Show("Registo inserido com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (nRegistos > 0)

                            {
                                listaRecetores.Add(new Recetor((int)cmd.LastInsertedId, txtNome.Text, cmbTurma.SelectedItem.ToString(), txtEE.Text));
                                gridRecetor.Refresh();
                                gridRecetor.Rows[gridRecetor.Rows.Count - 1].Selected = true;

                            }
                        }
                        txtNome.Enabled = false;
                        cmbTurma.Enabled = false;
                        txtEE.Enabled = false;
                        txtPesquisa.Enabled = true;

                        btnGravar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnNovo.Enabled = true;

                        btnInsTurma.Enabled = false;
                    }

                }

                else
                {

                    if (gridRecetor.SelectedRows.Count > 0)
                    {

                        Recetor rec = (Recetor)gridRecetor.SelectedRows[0].DataBoundItem;

                        string sql = "update recetores set nome=@nome, turma=@turma, enc_educacao=@ee where id_recetor=@idrecetor";

                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                            cmd.Parameters.AddWithValue("@turma", cmbTurma.SelectedItem);
                            cmd.Parameters.AddWithValue("@ee", txtEE.Text);
                            cmd.Parameters.AddWithValue("@idrecetor", rec.IdRecetor);

                            int nRegistos = cmd.ExecuteNonQuery();

                            MessageBox.Show("Registo atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (nRegistos > 0)
                            {
                                rec.Nome = txtNome.Text;
                                rec.Turma = cmbTurma.SelectedItem.ToString(); ;
                                rec.EncEducacao = txtEE.Text;
                                gridRecetor.Refresh();
                            }
                        }
                    }
                    txtNome.Enabled = false;
                    cmbTurma.Enabled = false;
                    txtEE.Enabled = false;
                    txtPesquisa.Enabled = true;

                    btnGravar.Enabled = false;
                    btnNovo.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnInsTurma.Enabled = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListaTurmasPesquisadas(string query)
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();

                listaRecetores = new BindingList<Recetor>();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaRecetores.Add(new Recetor(reader.GetInt32("id_recetor"),
                                                  reader.GetString("nome"),
                                                  reader.GetString("turma"),
                                                  reader.GetString("enc_educacao")));
                        }
                    }
                }

                gridRecetor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridRecetor.EditMode = DataGridViewEditMode.EditProgrammatically;
                gridRecetor.MultiSelect = false;
                gridRecetor.DataSource = listaRecetores;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT id_recetor, nome,  turma, enc_educacao FROM recetores WHERE nome LIKE '%" + txtPesquisa.Text + "%'";
            ListaTurmasPesquisadas(sql);
        }

        private void gridRecetor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();

                if (e.ColumnIndex == 0)
                {
                    txtNome.Enabled = true;
                    cmbTurma.Enabled = true;
                    txtEE.Enabled = true;
                    txtPesquisa.Enabled = false;

                    btnNovo.Enabled = false;
                    btnGravar.Enabled = true;
                    btnCancelar.Enabled = true;

                    btnInsTurma.Enabled = true;


                }

                if (e.ColumnIndex == 1)
                {

                    if (MessageBox.Show("Tem a certeza que quer eliminar o recetor?", "Informação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {

                            if (gridRecetor.SelectedRows.Count > 0)
                            {
                                int nRow = gridRecetor.SelectedRows[0].Index;
                                Recetor rec = (Recetor)gridRecetor.SelectedRows[0].DataBoundItem;

                                string sql = "delete from recetores where id_recetor=@idrecetor";

                                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                                {

                                    cmd.Parameters.AddWithValue("@idrecetor", rec.IdRecetor);
                                    int nRegistos = cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registo eliminado com suceso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (nRegistos == 1)
                                    {

                                        listaRecetores.Remove(rec);

                                        gridRecetor.Refresh();

                                        if (nRow > 0)
                                        {
                                            gridRecetor.Rows[nRow - 1].Selected = true;
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

        private void gridRecetor_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                if (gridRecetor.SelectedRows.Count > 0)
                {

                    Recetor rec = (Recetor)gridRecetor.SelectedRows[0].DataBoundItem;

                    txtNome.Text = rec.Nome;
                    cmbTurma.Text = rec.Turma.ToString();
                    txtEE.Text = rec.EncEducacao;

                }

                inserir = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            
        }

        private void btnInsTurma_Click(object sender, EventArgs e)
        {
            FormTurma child = new FormTurma();
            child.FormClosed += new FormClosedEventHandler(child_FormClosed);
            child.ShowDialog(this);
        }
    }
}

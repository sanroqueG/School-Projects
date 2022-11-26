using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto.Forms
{
    public partial class FormLocalidades : Form
    {
        DbConnection conexao = new DbConnection();
        BindingList<Local> listaLocal;
        bool inserir = false;
        public FormLocalidades()
        {
            InitializeComponent();
        }
        public void ListaLocalidades()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select * from locais";
                listaLocal = new BindingList<Local>();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaLocal.Add(new Local(reader.GetString("cod_postal"),
                                                  reader.GetString("localidade")));
                        }
                    }
                }

                gridLocais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridLocais.EditMode = DataGridViewEditMode.EditProgrammatically;
                gridLocais.MultiSelect = false;
                gridLocais.DataSource = listaLocal;
                gridLocais.Columns[1].Width = 80;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }

        private void FormLocalidades_Load(object sender, EventArgs e)
        {
            gridLocais.BackgroundColor = Color.White;
            this.BackColor = Color.White;

            ListaLocalidades();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodPostal.Enabled = true;
            txtCodPostal.Text = "";

            txtLocalidade.Enabled = true;
            txtLocalidade.Text = "";

            btnAtualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;

            inserir = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtLocalidade.Enabled = true;
            txtCodPostal.Enabled= true;

            btnAtualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection con = conexao.FazerConexao();
                try
                {
                    if (inserir)
                    {
                        if ((txtCodPostal.Text == "") || (txtLocalidade.Text == ""))
                        {
                            MessageBox.Show("Por favor, preencha todos os campos.");
                        }
                        else
                        {
                            string sql = "insert into locais values(@codpostal,@localidade)";

                            using (MySqlCommand cmd = new MySqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@codpostal", txtCodPostal.Text);
                                cmd.Parameters.AddWithValue("@localidade", txtLocalidade.Text);


                                int nRegistos = cmd.ExecuteNonQuery();

                                MessageBox.Show("Registo inserido com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (nRegistos > 0)

                                {
                                    listaLocal.Add(new Local(txtCodPostal.Text, txtLocalidade.Text));
                                    gridLocais.Refresh();
                                    gridLocais.Rows[gridLocais.Rows.Count - 1].Selected = true;

                                }
                            }

                            txtLocalidade.Enabled = false;
                            txtCodPostal.Enabled = false;

                            btnAtualizar.Enabled = true;
                            btnEliminar.Enabled = true;
                            btnGravar.Enabled = false;
                            btnNovo.Enabled = true;
                        }

                    }
                    else
                    {
                        if (gridLocais.SelectedRows.Count > 0)
                        {

                            Local lo = (Local)gridLocais.SelectedRows[0].DataBoundItem;



                            string sql = "update locais set cod_postal=@codpostal, localidade=@localidade where cod_postal=@codpostal";



                            using (MySqlCommand cmd = new MySqlCommand(sql, con))
                            {

                                cmd.Parameters.AddWithValue("@codpostal", txtCodPostal.Text);
                                cmd.Parameters.AddWithValue("@localidade", txtLocalidade.Text);


                                int nRegistos = cmd.ExecuteNonQuery();



                                MessageBox.Show("Registo atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (nRegistos > 0)
                                {
                                    lo.CodLocal = txtCodPostal.Text;
                                    lo.Localidade = txtLocalidade.Text;

                                    gridLocais.Refresh();
                                }
                            }
                        }
                        txtLocalidade.Enabled = false;
                        txtCodPostal.Enabled = false;

                        btnAtualizar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGravar.Enabled = false;
                        btnNovo.Enabled = true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();

                if (gridLocais.SelectedRows.Count > 0)
                {
                    int nRow = gridLocais.SelectedRows[0].Index;

                    Local lo = (Local)gridLocais.SelectedRows[0].DataBoundItem;

                    string sql = "delete from locais where cod_postal=@codpostal";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {

                        cmd.Parameters.AddWithValue("@codpostal", lo.CodLocal);

                        int nRegistos = cmd.ExecuteNonQuery();

                        MessageBox.Show("Registo eliminado com suceso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (nRegistos == 1)
                        {

                            listaLocal.Remove(lo);

                            gridLocais.Refresh();

                            if (nRow > 0)
                            {
                                gridLocais.Rows[nRow - 1].Selected = true;

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não pode eliminar esse registo porque está relacionado com outra tabela!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridLocais_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridLocais.SelectedRows.Count > 0)
                {

                    Local lo = (Local)gridLocais.SelectedRows[0].DataBoundItem;

                    txtCodPostal.Text = lo.CodLocal;
                    txtLocalidade.Text = lo.Localidade;

                }

                inserir = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }
    }
}

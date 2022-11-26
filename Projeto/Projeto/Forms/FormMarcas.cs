using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;

namespace Projeto.Forms
{
    public partial class FormMarcas : Form
    {
        DbConnection conexao = new DbConnection();

        BindingList<Marca> listaMarca;

        bool inserir = false;

        public FormMarcas()
        {
            InitializeComponent();
        }

        private void ListaMarcas()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select * from marcas";
                listaMarca = new BindingList<Marca>();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaMarca.Add(new Marca(reader.GetInt32("id_marca"),
                                                  reader.GetString("designacao")));
                        }
                    }
                }

                gridMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridMarcas.EditMode = DataGridViewEditMode.EditProgrammatically;
                gridMarcas.MultiSelect = false;
                gridMarcas.DataSource = listaMarca;
                gridMarcas.Columns[1].Width = 100;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


        }




        private void FormMarcas_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            gridMarcas.BackgroundColor = Color.White;
            gridMarcas.RowHeadersVisible = false;
            gridMarcas.Columns[0].Width = 40;
            gridMarcas.Width = 160;
            ListaMarcas();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            txtMarca.Enabled = true;
            txtMarca.Text = "";

            btnAtualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;

            inserir = true;
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            txtMarca.Enabled = true;

            btnAtualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection con = conexao.FazerConexao();
                if (gridMarcas.SelectedRows.Count > 0)
                {
                    int nRow = gridMarcas.SelectedRows[0].Index;
                    Marca marca = (Marca)gridMarcas.SelectedRows[0].DataBoundItem;

                    string sql = "delete from marcas where id_marca=@idmarca";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {

                        cmd.Parameters.AddWithValue("@idmarca", marca.CodMarca);
                        int nRegistos = cmd.ExecuteNonQuery();

                        MessageBox.Show("Registo eliminado com suceso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (nRegistos == 1)
                        {

                            listaMarca.Remove(marca);

                            gridMarcas.Refresh();

                            if (nRow > 0)
                            {
                                gridMarcas.Rows[nRow - 1].Selected = true;
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

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                try
                {
                    if (inserir)
                    {
                        if ((txtMarca.Text == ""))
                        {
                            MessageBox.Show("Por favor, preencha todos os campos.");
                        }
                        else
                        {
                            string sql = "insert into marcas values(0,@designacao)";

                            using (MySqlCommand cmd = new MySqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@designacao", txtMarca.Text);


                                int nRegistos = cmd.ExecuteNonQuery();

                                MessageBox.Show("Registo inserido com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (nRegistos > 0)

                                {
                                    listaMarca.Add(new Marca((int)cmd.LastInsertedId, txtMarca.Text));
                                    gridMarcas.Refresh();
                                    gridMarcas.Rows[gridMarcas.Rows.Count - 1].Selected = true;

                                }
                            }

                            txtMarca.Enabled = false;

                            btnAtualizar.Enabled = true;
                            btnEliminar.Enabled = true;
                            btnGravar.Enabled = false;
                            btnNovo.Enabled = true;
                        }

                    }
                    else
                    {
                        if (gridMarcas.SelectedRows.Count > 0)
                        {

                            Marca marca = (Marca)gridMarcas.SelectedRows[0].DataBoundItem;



                            string sql = "update marcas set designacao=@designacao where id_marca=@idmarca";



                            using (MySqlCommand cmd = new MySqlCommand(sql, con))
                            {

                                cmd.Parameters.AddWithValue("@designacao", txtMarca.Text);
                                cmd.Parameters.AddWithValue("@idmarca", marca.CodMarca);


                                int nRegistos = cmd.ExecuteNonQuery();



                                MessageBox.Show("Registo atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (nRegistos > 0)
                                {
                                    marca.Descricao = txtMarca.Text;

                                    gridMarcas.Refresh();
                                }
                            }
                        }
                        txtMarca.Enabled = false;

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

        private void gridMarcas_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (gridMarcas.SelectedRows.Count > 0)
                {

                    Marca marca = (Marca)gridMarcas.SelectedRows[0].DataBoundItem;

                    txtMarca.Text = marca.Descricao;


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

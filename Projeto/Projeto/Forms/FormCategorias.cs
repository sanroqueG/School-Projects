using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormCategorias : Form
    {

        DbConnection conexao = new DbConnection();

        BindingList<Categoria> listaCategoria;

        bool inserir = false;
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void ListaCategorias()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select * from categorias";
                listaCategoria = new BindingList<Categoria>();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaCategoria.Add(new Categoria(reader.GetInt32("id_categoria"),
                                                  reader.GetString("designacao")));
                        }
                    }
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
           

            gridCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCategorias.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridCategorias.MultiSelect = false;
            gridCategorias.DataSource = listaCategoria;
            gridCategorias.Columns[0].Width = 40;
            gridCategorias.Columns[1].Width = 100;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCategoria.Enabled = true;
            txtCategoria.Text = "";

            btnAtualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;

            inserir = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtCategoria.Enabled = true;

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
                        if ((txtCategoria.Text == ""))
                        {
                            MessageBox.Show("Por favor, preencha todos os campos.");
                        }
                        else
                        {
                            string sql = "insert into categorias values(0,@designacao)";

                            using (MySqlCommand cmd = new MySqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@designacao", txtCategoria.Text);


                                int nRegistos = cmd.ExecuteNonQuery();

                                MessageBox.Show("Registo inserido com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (nRegistos > 0)

                                {
                                    listaCategoria.Add(new Categoria((int)cmd.LastInsertedId, txtCategoria.Text));
                                    gridCategorias.Refresh();
                                    gridCategorias.Rows[gridCategorias.Rows.Count - 1].Selected = true;

                                }
                            }

                            txtCategoria.Enabled = false;

                            btnAtualizar.Enabled = true;
                            btnEliminar.Enabled = true;
                            btnGravar.Enabled = false;
                            btnNovo.Enabled = true;
                        }

                    }
                    else
                    {
                        if (gridCategorias.SelectedRows.Count > 0)
                        {

                            Categoria cat = (Categoria)gridCategorias.SelectedRows[0].DataBoundItem;



                            string sql = "update categorias set designacao=@designacao where id_categoria=@idcategoria";



                            using (MySqlCommand cmd = new MySqlCommand(sql, con))
                            {

                                cmd.Parameters.AddWithValue("@designacao", txtCategoria.Text);
                                cmd.Parameters.AddWithValue("@idcategoria", cat.IdCategoria);


                                int nRegistos = cmd.ExecuteNonQuery();



                                MessageBox.Show("Registo atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (nRegistos > 0)
                                {
                                    cat.Descricao = txtCategoria.Text;

                                    gridCategorias.Refresh();
                                }
                            }
                        }
                        txtCategoria.Enabled = false;

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
                try
                {
                    MySqlConnection con = conexao.FazerConexao();
                    if (gridCategorias.SelectedRows.Count > 0)
                    {
                        int nRow = gridCategorias.SelectedRows[0].Index;
                        Categoria cat = (Categoria)gridCategorias.SelectedRows[0].DataBoundItem;

                        string sql = "delete from categorias where id_categoria=@idcategoria";

                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {

                            cmd.Parameters.AddWithValue("@idcategoria", cat.IdCategoria);
                            int nRegistos = cmd.ExecuteNonQuery();

                            MessageBox.Show("Registo eliminado com suceso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (nRegistos == 1)
                            {

                                listaCategoria.Remove(cat);

                                gridCategorias.Refresh();

                                if (nRow > 0)
                                {
                                    gridCategorias.Rows[nRow - 1].Selected = true;
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
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            gridCategorias.BackgroundColor = Color.White;
            this.BackColor = Color.White;

            ListaCategorias();
        }

        private void gridCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (gridCategorias.SelectedRows.Count > 0)
            {

                Categoria cat = (Categoria)gridCategorias.SelectedRows[0].DataBoundItem;

                txtCategoria.Text = cat.Descricao;


            }

            inserir = false;
        }
    }
}

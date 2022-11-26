using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormCatDadores : Form
    {
        DbConnection conexao = new DbConnection();
        BindingList<CategoriaDador> listaCat;
        bool inserir = false;

        public FormCatDadores()
        {
            InitializeComponent();
        }

        private void ListaCatD()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select * from categoriadadores";
                listaCat = new BindingList<CategoriaDador>();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaCat.Add(new CategoriaDador(reader.GetInt32("id_categoria_d"),
                                                  reader.GetString("designacao")));
                        }
                    }
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }


            gridCat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCat.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridCat.MultiSelect = false;
            gridCat.DataSource = listaCat;
            gridCat.Columns[1].Width = 80;
        }

        private void FormCatDadores_Load(object sender, EventArgs e)
        {
            gridCat.BackgroundColor = Color.White;
            ListaCatD();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCat.Enabled = true;
            txtCat.Text = "";

            btnAtualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;

            inserir = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtCat.Enabled = true;

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
                if (inserir)
                {
                    if ((txtCat.Text == ""))
                    {
                        MessageBox.Show("Por favor, preencha todos os campos.");
                    }
                    else
                    {
                        string sql = "insert into categoriadadores values(0,@designacao)";

                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@designacao", txtCat.Text);


                            int nRegistos = cmd.ExecuteNonQuery();

                            MessageBox.Show("Registo inserido com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (nRegistos > 0)

                            {
                                listaCat.Add(new CategoriaDador((int)cmd.LastInsertedId, txtCat.Text));
                                gridCat.Refresh();
                                gridCat.Rows[gridCat.Rows.Count - 1].Selected = true;

                            }
                        }

                        txtCat.Enabled = false;

                        btnAtualizar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGravar.Enabled = false;
                        btnNovo.Enabled = true;
                    }

                }
                else
                {
                    if (gridCat.SelectedRows.Count > 0)
                    {

                        CategoriaDador cd = (CategoriaDador)gridCat.SelectedRows[0].DataBoundItem;



                        string sql = "update categoriadadores set designacao=@designacao where id_categoria_d=@idcategoriad";



                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {

                            cmd.Parameters.AddWithValue("@designacao", txtCat.Text);
                            cmd.Parameters.AddWithValue("@idcategoriad", cd.CodCategoriaDador);

                            int nRegistos = cmd.ExecuteNonQuery();

                            MessageBox.Show("Registo atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (nRegistos > 0)
                            {
                                cd.Descricao = txtCat.Text;

                                ListaCatD();
                                //gridCat.Refresh();
                            }
                        }
                    }
                    txtCat.Enabled = false;

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                if (gridCat.SelectedRows.Count > 0)
                {
                    int nRow = gridCat.SelectedRows[0].Index;
                    CategoriaDador cda = (CategoriaDador)gridCat.SelectedRows[0].DataBoundItem;

                    string sql = "delete from categoriadadores where id_categoria_d=@idcategoriad";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {

                        cmd.Parameters.AddWithValue("@idcategoriad", cda.CodCategoriaDador);
                        int nRegistos = cmd.ExecuteNonQuery();

                        MessageBox.Show("Registo eliminado com suceso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (nRegistos == 1)
                        {

                            listaCat.Remove(cda);

                            gridCat.Refresh();

                            if (nRow > 0)
                            {
                                gridCat.Rows[nRow - 1].Selected = true;
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

        private void gridCat_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridCat.SelectedRows.Count > 0)
                {

                    CategoriaDador cd = (CategoriaDador)gridCat.SelectedRows[0].DataBoundItem;

                    txtCat.Text = cd.Descricao;


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

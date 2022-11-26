using MySql.Data.MySqlClient;
using Projeto.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Projeto.Classes.DbClasses;

namespace Projeto.Forms
{
    public partial class FormFuncoes : Form
    {
        public FormFuncoes()
        {
            InitializeComponent();
        }

        DbConnection conexao = new DbConnection();
        BindingList<Funcao> listaFuncoes;


        bool inserir = false;
        private void ListaFuncoes()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select * from funcoes";
                listaFuncoes = new BindingList<Funcao>();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaFuncoes.Add(new Funcao(reader.GetInt32("id_funcao"),
                                                  reader.GetString("designacao"),
                                                  reader.GetString("permissao")));
                        }
                    }
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
           

            gridFuncao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridFuncao.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridFuncao.MultiSelect = false;
            gridFuncao.DataSource = listaFuncoes;
            gridFuncao.Columns[1].Width = 100;

        }
        private void FormFuncoes_Load(object sender, EventArgs e)
        {
            cbPerms.Items.Clear();
            cbPerms.Items.Add("Administrador");
            cbPerms.Items.Add("Coordenador");
            cbPerms.Items.Add("Delegado");
            cbPerms.Items.Add("Voluntário");

            this.BackColor = Color.White;
            gridFuncao.BackgroundColor = Color.White;
            gridFuncao.RowHeadersVisible = false;
            gridFuncao.Columns[0].Width = 40;
            gridFuncao.Width = 150;
            ListaFuncoes();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtFuncao.Enabled = true;
            txtFuncao.Text = "";

            btnAtualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;

            inserir = true;
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
                        if ((txtFuncao.Text == "") || (cbPerms.TabIndex == -1))
                        {
                            MessageBox.Show("Por favor, preencha todos os campos.");
                        }
                        else
                        {
                            string sql = "insert into funcoes values(0,@designacao, @permissao)";

                            using (MySqlCommand cmd = new MySqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@designacao", txtFuncao.Text);
                                cmd.Parameters.AddWithValue("@permissao", cbPerms.SelectedItem);


                                int nRegistos = cmd.ExecuteNonQuery();

                                MessageBox.Show("Registo inserido com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (nRegistos > 0)

                                {
                                    listaFuncoes.Add(new Funcao((int)cmd.LastInsertedId, txtFuncao.Text, cbPerms.SelectedItem.ToString()));
                                    gridFuncao.Refresh();
                                    gridFuncao.Rows[gridFuncao.Rows.Count - 1].Selected = true;

                                }
                            }

                            txtFuncao.Enabled = false;

                            btnAtualizar.Enabled = true;
                            btnEliminar.Enabled = true;
                            btnGravar.Enabled = false;
                            btnNovo.Enabled = true;
                        }

                    }
                    else
                    {
                        if (gridFuncao.SelectedRows.Count > 0)
                        {

                            Funcao funcao = (Funcao)gridFuncao.SelectedRows[0].DataBoundItem;



                            string sql = "update funcoes set designacao=@designacao where id_funcao=@idfuncao";



                            using (MySqlCommand cmd = new MySqlCommand(sql, con))
                            {

                                cmd.Parameters.AddWithValue("@designacao", txtFuncao.Text);
                                cmd.Parameters.AddWithValue("@idfuncao", funcao.CodFuncao);


                                int nRegistos = cmd.ExecuteNonQuery();



                                MessageBox.Show("Registo atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (nRegistos > 0)
                                {
                                    funcao.Descricao = txtFuncao.Text;

                                    gridFuncao.Refresh();
                                }
                            }
                        }
                        txtFuncao.Enabled = false;

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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtFuncao.Enabled = true;

            btnAtualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                if (gridFuncao.SelectedRows.Count > 0)
                {
                    int nRow = gridFuncao.SelectedRows[0].Index;
                    Funcao funcao = (Funcao)gridFuncao.SelectedRows[0].DataBoundItem;

                    string sql = "delete from funcoes where id_funcao=@idfuncao";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {

                        cmd.Parameters.AddWithValue("@idfuncao", funcao.CodFuncao);
                        int nRegistos = cmd.ExecuteNonQuery();

                        MessageBox.Show("Registo eliminado com suceso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (nRegistos == 1)
                        {

                            listaFuncoes.Remove(funcao);

                            gridFuncao.Refresh();

                            if (nRow > 0)
                            {
                                gridFuncao.Rows[nRow - 1].Selected = true;
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

        private void gridFuncao_SelectionChanged(object sender, EventArgs e)
        {
            if (gridFuncao.SelectedRows.Count > 0)
            {

                Funcao funcao = (Funcao)gridFuncao.SelectedRows[0].DataBoundItem;

                txtFuncao.Text = funcao.Descricao;


            }

            inserir = false;
        }
    }
}

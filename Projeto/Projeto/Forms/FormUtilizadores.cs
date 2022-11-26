using MySql.Data.MySqlClient;
using Projeto.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Projeto.Classes.DbClasses;

namespace Projeto.Forms
{
    public partial class FormUtilizadores : Form
    {
        public FormUtilizadores()
        {
            InitializeComponent();
        }

        BindingList<Utilizador> listaUtilizadores;
        DbConnection conexao = new DbConnection();
        UserHandling userH = new UserHandling();
        List<Funcao> listaFuncoes;

        bool flag;
        bool interr;

        bool edit;
        private void listarUtilizadores(string query)
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select * from users";
                listaUtilizadores = new BindingList<Utilizador>();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaUtilizadores.Add(new Utilizador(
                                   reader.GetInt32("id_user"),
                                   reader.GetString("nome"),
                                   reader.GetString("email"),
                                   reader.GetString("telemovel"),
                                  userH.RetornaFuncao(reader.GetInt32("id_funcao")),
                                   reader.GetString("password_user")));
                        }
                    }
                }

                gridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
                gridUsers.MultiSelect = false;
                gridUsers.DataSource = listaUtilizadores;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            

        }
        private void PreencheComboFuncao()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                listaFuncoes = new List<Funcao>();
                string sql = "select * from funcoes";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Funcao funcao = new Funcao(reader.GetInt32("id_funcao"), reader.GetString("designacao"), reader.GetString("Permissao"));
                            listaFuncoes.Add(funcao);
                        }
                    }
                }

                cbFuncao.DisplayMember = "Descrição";
                cbFuncao.DataSource = listaFuncoes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag)
            {
                PreencheComboFuncao();
                cbFuncao.SelectedIndex = cbFuncao.Items.Count - 1;
                flag = false;
            }
            else
            {
                PreencheComboFuncao();
                cbFuncao.SelectedIndex = cbFuncao.Items.Count - 1;
            }
        }
        private Funcao RetornaFuncao(int idFuncao)
        {
            foreach (Funcao funcao in listaFuncoes)
                if (funcao.CodFuncao == idFuncao)
                    return funcao;
            return null;
        }
        private void FormUtilizadores_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM users";

            bool interr = false;
            campos(interr);


            btnInsFuncao.Enabled = false;
            PreencheComboFuncao();

            userH.PreencheListaFuncoes();
            listarUtilizadores(sql);
        }


        private bool campos(bool interruptor)
        {
            txtNome.Enabled = interruptor;
            txtEmail.Enabled = interruptor;
            txtTelemovel.Enabled = interruptor;
            txtPassword.Enabled = interruptor;
            cbFuncao.Enabled = interruptor;
            btnInsFuncao.Enabled = interruptor;
            return interruptor;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            interr = true;
            campos(interr);

            btnCancelar.Enabled = true;
            btnGravar.Enabled = true;

        }

        private void btnInsFuncao_Click(object sender, EventArgs e)
        {
            FormFuncoes child = new FormFuncoes();
            child.FormClosed += new FormClosedEventHandler(child_FormClosed);
            flag = true;
            child.Show();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string password = "Cidenai123";
            try
            {
                if (!edit)
                {
                    MySqlConnection con = conexao.FazerConexao();
                    try
                    {
                        if (interr)
                        {
                            if ((txtNome.Text == "") || txtEmail.Text == "" || txtTelemovel.Text == "" || cbFuncao.SelectedIndex == -1)
                            {
                                MessageBox.Show("Por favor, preencha todos os campos.");
                            }
                            else
                            {
                                string sql = "insert into users values(0,@nome, @email, @telemovel, @id_funcao, @password)";

                                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                                {
                                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                    cmd.Parameters.AddWithValue("@telemovel", txtTelemovel.Text);
                                    cmd.Parameters.AddWithValue("@id_funcao", ((Funcao)cbFuncao.SelectedItem).CodFuncao);
                                    cmd.Parameters.AddWithValue("@password", password);

                                    int nRegistos = cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registo inserido com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (nRegistos > 0)

                                    {
                                        listaUtilizadores.Add(new Utilizador((int)cmd.LastInsertedId, txtNome.Text, txtEmail.Text, txtTelemovel.Text, (Funcao)cbFuncao.SelectedItem, password));
                                        gridUsers.Refresh();
                                        gridUsers.Rows[gridUsers.Rows.Count - 1].Selected = true;

                                    }
                                }

                                interr = false;
                                campos(interr);

                                btnGravar.Enabled = false;
                                btnCancelar.Enabled = false;
                                btnNovo.Enabled = true;
                            }
                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {


                    if (txtNome.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtTelemovel.Text == "")
                    {
                        MessageBox.Show("Introduza os dados em todos os campos!");
                        return;
                    }

                    MessageBox.Show("editar");

                    Utilizador user = (Utilizador)gridUsers.SelectedRows[0].DataBoundItem;

                    string sql = "update users set nome=@nome, email=@email," +
                            "telemovel=@telemovel, id_funcao=@idfuncao, password_user=@password where id_user=@iduser";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao.FazerConexao()))
                    {
                        cmd.Parameters.AddWithValue("@iduser", user.IdUser);
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@telemovel", txtTelemovel.Text);
                        cmd.Parameters.AddWithValue("@idfuncao", ((Funcao)cbFuncao.SelectedItem).CodFuncao);
                        cmd.Parameters.AddWithValue("@password", password);

                        int nRegistos = cmd.ExecuteNonQuery();

                        MessageBox.Show("Registo atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (nRegistos > 0)
                        {
                            user.Nome = txtNome.Text;
                            user.Email = txtEmail.Text;
                            user.Telefone = txtTelemovel.Text;
                            user.IdFuncao = (Funcao)cbFuncao.SelectedItem;
                            user.PasswordUser = password;
                            gridUsers.Refresh();
                        }

                        interr = false;
                        campos(interr);

                        btnGravar.Enabled = false;
                        btnNovo.Enabled = true;
                        btnCancelar.Enabled = false;
                        edit = false;
                        limparCampos(true);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           

            

        }

        private void limparCampos(bool i)
        {
            if (i)
            {
                txtNome.Text = "";
                txtEmail.Text = "";
                txtTelemovel.Text = "";
                txtPassword.Text = "";
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            interr = false;
            campos(interr);
            limparCampos(true);
        }

        private void gridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                MySqlConnection con = conexao.FazerConexao();

                if (e.ColumnIndex == 1)
                {

                    if (MessageBox.Show("Tem a certeza que quer eliminar o utilizador?", "Informação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {

                            if (gridUsers.SelectedRows.Count > 0)
                            {
                                int nRow = gridUsers.SelectedRows[0].Index;
                                Utilizador user = (Utilizador)gridUsers.SelectedRows[0].DataBoundItem;

                                string sql = "delete from users where id_user=@iduser";

                                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                                {

                                    cmd.Parameters.AddWithValue("@iduser", user.IdUser);
                                    int nRegistos = cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registo eliminado com suceso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (nRegistos == 1)
                                    {

                                        listaUtilizadores.Remove(user);

                                        gridUsers.Refresh();

                                        if (nRow > 0)
                                        {
                                            gridUsers.Rows[nRow - 1].Selected = true;
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Não pode eliminar este utilizador!", "ERRO");
                        }
                    }
                }


                if (e.ColumnIndex == 0)
                {
                    limparCampos(false);
                    edit = true;

                    try
                    {


                        if (gridUsers.SelectedRows.Count > 0)
                        {
                            int nRow = gridUsers.SelectedRows[0].Index;
                            Utilizador user = (Utilizador)gridUsers.SelectedRows[0].DataBoundItem;

                            campos(true);

                            txtNome.Text = user.Nome;
                            txtEmail.Text = user.Email;
                            txtTelemovel.Text = user.Telefone;
                            txtPassword.Text = user.PasswordUser;


                            btnCancelar.Enabled = true;
                            btnGravar.Enabled = true;

                            MessageBox.Show(edit.ToString());
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERRO!");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            


        }
        private void listarUtilizadoresPesquisa(string query)
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();

                listaUtilizadores = new BindingList<Utilizador>();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaUtilizadores.Add(new Utilizador(
                                   reader.GetInt32("id_user"),
                                   reader.GetString("nome"),
                                   reader.GetString("email"),
                                   reader.GetString("telemovel"),
                                  userH.RetornaFuncao(reader.GetInt32("id_funcao")),
                                   reader.GetString("password_user")));
                        }
                    }
                }

                gridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
                gridUsers.MultiSelect = false;
                gridUsers.DataSource = listaUtilizadores;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
          

        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM users WHERE email LIKE '%" + txtPesquisa.Text + "%'";
            listarUtilizadoresPesquisa(sql);
        }

       
    }
}

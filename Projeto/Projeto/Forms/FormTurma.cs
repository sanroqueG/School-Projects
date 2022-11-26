using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto.Forms
{
    public partial class FormTurma : Form
    {
        DbConnection conexao = new DbConnection();
        BindingList<Turma> listaTurma;
        bool inserir = false;
        public FormTurma()
        {
            InitializeComponent();
        }

        public void ListaTurmas()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select * from turmas";
                listaTurma = new BindingList<Turma>();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaTurma.Add(new Turma(reader.GetString("turma"),
                                                  reader.GetString("descricao")));
                        }
                    }
                }

                gridTurmas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridTurmas.EditMode = DataGridViewEditMode.EditProgrammatically;
                gridTurmas.MultiSelect = false;
                gridTurmas.DataSource = listaTurma;
                gridTurmas.Columns[0].Width = 100;
                gridTurmas.Columns[1].Width = 120;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtTurma.Enabled = true;
            txtTurma.Text = "";

            txtDesc.Enabled = true;
            txtDesc.Text = "";

            btnAtualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;

            inserir = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtTurma.Enabled = true;
            txtDesc.Enabled = true;

            btnAtualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conexao.FazerConexao();
            try
            {
                if (inserir)
                {
                    if ((txtTurma.Text == "") || (txtDesc.Text == ""))
                    {
                        MessageBox.Show("Por favor, preencha todos os campos.");
                    }
                    else
                    {
                        string sql = "insert into turmas values(@turma,@desc)";

                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@turma", txtTurma.Text);
                            cmd.Parameters.AddWithValue("@desc", txtDesc.Text);


                            int nRegistos = cmd.ExecuteNonQuery();

                            MessageBox.Show("Registo inserido com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (nRegistos > 0)

                            {
                                listaTurma.Add(new Turma(txtTurma.Text, txtDesc.Text));
                                gridTurmas.Refresh();
                                gridTurmas.Rows[gridTurmas.Rows.Count - 1].Selected = true;

                            }
                        }

                        txtTurma.Enabled = false;
                        txtDesc.Enabled = false;

                        btnAtualizar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGravar.Enabled = false;
                        btnNovo.Enabled = true;
                    }

                }
                else
                {
                    if (gridTurmas.SelectedRows.Count > 0)
                    {

                        Turma lo = (Turma)gridTurmas.SelectedRows[0].DataBoundItem;



                        string sql = "update turmas set turma=@turma, descricao=@desc where turma=@turma";



                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {

                            cmd.Parameters.AddWithValue("@turma", txtTurma.Text);
                            cmd.Parameters.AddWithValue("@desc", txtDesc.Text);


                            int nRegistos = cmd.ExecuteNonQuery();



                            MessageBox.Show("Registo atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (nRegistos > 0)
                            {
                                lo.IdTurma = txtTurma.Text;
                                lo.Descricao = txtDesc.Text;

                                gridTurmas.Refresh();
                            }
                        }
                    }
                    txtTurma.Enabled = false;
                    txtDesc.Enabled = false;

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

                if (gridTurmas.SelectedRows.Count > 0)
                {
                    int nRow = gridTurmas.SelectedRows[0].Index;

                    Turma lo = (Turma)gridTurmas.SelectedRows[0].DataBoundItem;

                    string sql = "delete from turmas where turma=@turma";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {

                        cmd.Parameters.AddWithValue("@turma", lo.IdTurma);

                        int nRegistos = cmd.ExecuteNonQuery();

                        MessageBox.Show("Registo eliminado com suceso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (nRegistos == 1)
                        {

                            listaTurma.Remove(lo);

                            gridTurmas.Refresh();

                            if (nRow > 0)
                            {
                                gridTurmas.Rows[nRow - 1].Selected = true;

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

       

        private void FormTurma_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            gridTurmas.BackgroundColor = Color.White;

            ListaTurmas();
        }

        private void gridTurmas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridTurmas.SelectedRows.Count > 0)
                {

                    Turma lo = (Turma)gridTurmas.SelectedRows[0].DataBoundItem;

                    txtTurma.Text = lo.IdTurma;
                    txtDesc.Text = lo.Descricao;

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

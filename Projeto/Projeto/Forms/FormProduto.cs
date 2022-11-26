using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;


namespace Projeto.Forms
{
    public partial class FormProduto : Form
    {

        DbConnection conexao = new DbConnection();

        BindingList<Produto> listaProdutos;
        List<Categoria> listaCategoria;
        List<Marca> listaMarca;

        bool inserir = false;
        bool flag;
        public FormProduto()
        {
            InitializeComponent();
        }

        private void PreencheComboCategoria()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                listaCategoria = new List<Categoria>();
                string sql = "select * from categorias";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categoria tipo = new Categoria(reader.GetInt32("id_categoria"), reader.GetString("designacao"));
                            listaCategoria.Add(tipo);
                        }
                    }
                }
                cmbTipo.DisplayMember = "Descrição";
                cmbTipo.DataSource = listaCategoria;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }
        private void PreencheComboMarca()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                listaMarca = new List<Marca>();
                string sql = "select * from marcas";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Marca marca = new Marca(reader.GetInt32("id_marca"), reader.GetString("designacao"));
                            listaMarca.Add(marca);
                        }
                    }
                }

                cbMarca.DisplayMember = "Descrição";
                cbMarca.DataSource = listaMarca;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            


        }
        private Categoria RetornaCategoria(int idCategoria)
        {
            foreach (Categoria categoria in listaCategoria)
                if (categoria.IdCategoria == idCategoria)
                    return categoria;
            return null;
        }
        private Marca RetornaMarca(int idMarca)
        {
            foreach (Marca marca in listaMarca)
                if (marca.CodMarca == idMarca)
                    return marca;
            return null;
        }
        private void ListaProdutos()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select * from produto";
                listaProdutos = new BindingList<Produto>();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaProdutos.Add(new Produto(reader.GetInt32("id_produto"),
                                                  reader.GetString("designacao"),
                                                  RetornaMarca(reader.GetInt32("id_marca")),
                                                  RetornaCategoria(reader.GetInt32("id_categoria")),
                                                  reader.GetInt16("stock")));
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            

            gridProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridProdutos.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridProdutos.MultiSelect = false;
            gridProdutos.DataSource = listaProdutos;

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
            gridProdutos.Columns.Add(editar);

            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();
            eliminar.HeaderText = "";
            eliminar.Text = "Eliminar";
            eliminar.DefaultCellStyle.SelectionBackColor = Color.Red;
            eliminar.DefaultCellStyle.ForeColor = Color.White;
            eliminar.DefaultCellStyle.SelectionForeColor = Color.White;
            eliminar.DefaultCellStyle.BackColor = Color.Red;
            eliminar.FlatStyle = FlatStyle.Flat;
            eliminar.UseColumnTextForButtonValue = true;
            gridProdutos.Columns.Add(eliminar);


            gridProdutos.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridProdutos.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridProdutos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridProdutos.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridProdutos.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridProdutos.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;

            gridProdutos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            gridProdutos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            gridProdutos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            foreach (DataGridViewColumn c in gridProdutos.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 12.5F, GraphicsUnit.Pixel);
            }


            gridProdutos.RowHeadersVisible = false;
            gridProdutos.Columns[0].Visible = false;
            gridProdutos.Columns[1].Width = 260;
            gridProdutos.Columns[2].Width = 160;
            gridProdutos.Columns[3].Width = 160;
            gridProdutos.Columns[4].Width = 78;
            gridProdutos.Columns[5].Width = 78;
            gridProdutos.Columns[6].Width = 78;


        }
        private void btnGravar_Click(object sender, EventArgs e)
        {

            MySqlConnection con = conexao.FazerConexao();
            try
            {
                if (inserir)
                {
                    if ((txtNome.Text == "") || (cmbTipo.SelectedIndex == -1) || (cbMarca.SelectedIndex == -1))
                    {
                        MessageBox.Show("Por favor, preencha todos os campos.");
                    }
                    else
                    {
                        string sql = "insert into produto values(0,@designacao, @marca, @categoria, @stock)";

                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@designacao", txtNome.Text);
                            cmd.Parameters.AddWithValue("@categoria", ((Categoria)cmbTipo.SelectedItem).IdCategoria);
                            cmd.Parameters.AddWithValue("@marca", ((Marca)cbMarca.SelectedItem).CodMarca);
                            cmd.Parameters.AddWithValue("@stock", txtStock.Text);

                            int nRegistos = cmd.ExecuteNonQuery();

                            MessageBox.Show("Registo inserido com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (nRegistos > 0)

                            {
                                listaProdutos.Add(new Produto((int)cmd.LastInsertedId, txtNome.Text, (Marca)cbMarca.SelectedItem, (Categoria)cmbTipo.SelectedItem, int.Parse(txtStock.Text)));
                                gridProdutos.Refresh();
                                gridProdutos.Rows[gridProdutos.Rows.Count - 1].Selected = true;

                            }
                        }
                        txtNome.Enabled = false;
                        cbMarca.Enabled = false;
                        cmbTipo.Enabled = false;
                        txtStock.Enabled = false;
                        txtPesquisa.Enabled = true;

                        btnGravar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnNovo.Enabled = true;

                        btnInsCat.Enabled = false;
                        btnInsMarca.Enabled = false;
                    }

                }

                else
                {

                    if (gridProdutos.SelectedRows.Count > 0)
                    {

                        Produto produto = (Produto)gridProdutos.SelectedRows[0].DataBoundItem;

                        string sql = "update produto set designacao=@designacao, id_marca=@marca," +
                                "id_categoria=@categoria, stock=@stock where id_produto=@idproduto";

                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@designacao", txtNome.Text);
                            cmd.Parameters.AddWithValue("@marca", ((Marca)cbMarca.SelectedItem).CodMarca);
                            cmd.Parameters.AddWithValue("@categoria", ((Categoria)cmbTipo.SelectedItem).IdCategoria);
                            cmd.Parameters.AddWithValue("@stock", txtStock.Text);
                            cmd.Parameters.AddWithValue("@idproduto", produto.IdProduto);

                            int nRegistos = cmd.ExecuteNonQuery();

                            MessageBox.Show("Registo atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (nRegistos > 0)
                            {
                                produto.Designacao = txtNome.Text;
                                produto.Marca = (Marca)cbMarca.SelectedItem;
                                produto.Categoria = (Categoria)cmbTipo.SelectedItem;
                                produto.Stock = int.Parse(txtStock.Text);
                                gridProdutos.Refresh();
                            }
                        }
                    }
                    txtNome.Enabled = false;
                    cbMarca.Enabled = false;
                    cmbTipo.Enabled = false;
                    txtStock.Enabled = false;
                    txtPesquisa.Enabled = true;

                    btnGravar.Enabled = false;
                    btnNovo.Enabled = true;
                    btnCancelar.Enabled = false;

                    btnInsCat.Enabled = false;
                    btnInsMarca.Enabled = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            PreencheComboMarca();
            PreencheComboCategoria();

            txtNome.Enabled = true;
            cbMarca.Enabled = true;
            cmbTipo.Enabled = true;
            txtStock.Enabled = false;
            txtPesquisa.Enabled = false;
            txtNome.Text = "";
            cbMarca.SelectedIndex = -1;
            txtStock.Text = "0";
            cmbTipo.SelectedIndex = -1;

            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            btnInsCat.Enabled = true;
            btnInsMarca.Enabled = true;

            inserir = true;

        }
        private void FormProduto_Load(object sender, EventArgs e)
        {
            gridProdutos.BackgroundColor = Color.White;
            PreencheComboMarca();
            PreencheComboCategoria();
            ListaProdutos();

        }
        private void gridProdutos_SelectionChanged(object sender, EventArgs e)
        {

            if (gridProdutos.SelectedRows.Count > 0)
            {

                Produto produto = (Produto)gridProdutos.SelectedRows[0].DataBoundItem;

                txtNome.Text = produto.Designacao;
                cmbTipo.Text = produto.Categoria.ToString();
                cbMarca.Text = produto.Marca.ToString();
                txtStock.Text = produto.Stock.ToString();

            }

            inserir = false;
        }
        private void btnInsMarca_Click(object sender, EventArgs e)
        {
            FormMarcas child = new FormMarcas(); 
            child.FormClosed += new FormClosedEventHandler(child_FormClosed);
            flag = true;
            child.Show();
        }

        private void btnInsCat_Click(object sender, EventArgs e)
        {
            FormCategorias child = new FormCategorias();
            child.FormClosed += new FormClosedEventHandler(child_FormClosed);
            flag = false;
            child.Show();
        }

        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag)
            {
                PreencheComboMarca();
                cbMarca.SelectedIndex = cbMarca.Items.Count - 1;
            }
            else
            {
                PreencheComboCategoria();
                cmbTipo.SelectedIndex = cmbTipo.Items.Count - 1;
            }
            
            

        }
        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                MySqlConnection con = conexao.FazerConexao();

                if (e.ColumnIndex == 0)
                {
                    txtNome.Enabled = true;
                    cbMarca.Enabled = true;
                    cmbTipo.Enabled = true;
                    txtStock.Enabled = false;
                    txtPesquisa.Enabled = false;

                    btnNovo.Enabled = false;
                    btnGravar.Enabled = true;
                    btnCancelar.Enabled = true;

                    btnInsCat.Enabled = true;
                    btnInsMarca.Enabled = true;


                }

                if (e.ColumnIndex == 1)
                {

                    if (MessageBox.Show("Tem a certeza que quer eliminar o produto?", "Informação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {

                            if (gridProdutos.SelectedRows.Count > 0)
                            {
                                int nRow = gridProdutos.SelectedRows[0].Index;
                                Produto prod = (Produto)gridProdutos.SelectedRows[0].DataBoundItem;

                                string sql = "delete from produto where id_produto=@idproduto";

                                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                                {

                                    cmd.Parameters.AddWithValue("@idproduto", prod.IdProduto);
                                    int nRegistos = cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registo eliminado com suceso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (nRegistos == 1)
                                    {

                                        listaProdutos.Remove(prod);

                                        gridProdutos.Refresh();

                                        if (nRow > 0)
                                        {
                                            gridProdutos.Rows[nRow - 1].Selected = true;
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Não pode eliminar um produto que tem entradas registadas!", "ERRO");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT id_produto, designacao,  id_marca, id_categoria, stock FROM produto WHERE designacao LIKE '%" + txtPesquisa.Text + "%'";
            ListaProdutosPesquisados(sql);
        }

        public void ListaProdutosPesquisados(string query)
        {

            try
            {
                MySqlConnection con = conexao.FazerConexao();

                listaProdutos = new BindingList<Produto>();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaProdutos.Add(new Produto(reader.GetInt32("id_produto"),
                                                  reader.GetString("designacao"),
                                                  RetornaMarca(reader.GetInt32("id_marca")),
                                                  RetornaCategoria(reader.GetInt32("id_categoria")),
                                                  reader.GetInt16("stock")));
                        }
                    }
                }

                gridProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridProdutos.EditMode = DataGridViewEditMode.EditProgrammatically;
                gridProdutos.MultiSelect = false;
                gridProdutos.DataSource = listaProdutos;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
           

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            txtNome.Text = gridProdutos.SelectedRows[0].Cells[3].Value.ToString();
            cbMarca.Text = gridProdutos.SelectedRows[0].Cells[4].Value.ToString();
            cmbTipo.Text = gridProdutos.SelectedRows[0].Cells[5].Value.ToString();

            txtNome.Enabled = false;
            cbMarca.Enabled = false;
            cmbTipo.Enabled = false;
            txtStock.Enabled = false;
            txtPesquisa.Enabled = true;
       

            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;

            btnInsCat.Enabled = false;
            btnInsMarca.Enabled = false;
        }
    }
}

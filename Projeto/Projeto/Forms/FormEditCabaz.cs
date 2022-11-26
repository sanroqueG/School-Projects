using System;
using System.ComponentModel;
using System.Windows.Forms;
using Projeto.Classes;
using Projeto.Classes.DbClasses;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Crmf;

namespace Projeto.Forms
{
    public partial class FormEditCabaz : Form
    {
        string idCabaz = "";
        string designacao = "";
        public FormEditCabaz(string idCabaz)
        {
            InitializeComponent();
            this.idCabaz = idCabaz;
        }

        DbConnection conexao;
        BindingList<CabazProduto> ListCabazProduto;
        BindingList<Produto> listaProduto;

        bool inserir = true;
        private void getAllProductsSelectedCabaz()
        {

            conexao = new DbConnection();
            string query = "SELECT * FROM cabazproduto where id_cabaz=@idcabaz";
            ListCabazProduto = new BindingList<CabazProduto>();
            using (MySqlCommand cmd = new MySqlCommand(query, conexao.FazerConexao()))
            {
                cmd.Parameters.AddWithValue("@idcabaz", idCabaz);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CabazProduto cabazProduto = new CabazProduto(RetornaProduto(reader.GetInt32("id_produto")),
                                                         reader.GetInt32("quantidade"));
                        ListCabazProduto.Add(cabazProduto);
                    }
                }

            }
        }

        private Produto RetornaProduto(int idProduto)
        {
            foreach (Produto produto in listaProduto)
                if (produto.IdProduto == idProduto)
                    return produto;
            return null;
        }

        private void PreencheListaProduto()
        {
            conexao = new DbConnection();
            listaProduto = new BindingList<Produto>();
            string sql = "select id_produto, designacao from produto";
            using (MySqlCommand cmd = new MySqlCommand(sql, conexao.FazerConexao()))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produto tipo = new Produto(reader.GetInt32("id_produto"), reader.GetString("designacao"));
                        listaProduto.Add(tipo);
                    }
                }
            }
        }

        private void selectCabaz()
        {
            string query = "SELECT * from cabaz where id_cabaz=@idcabaz";

            using (MySqlCommand cmd = new MySqlCommand(query, conexao.FazerConexao()))
            {
                cmd.Parameters.AddWithValue("@idcabaz", idCabaz);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        designacao = reader.GetString("designacao").ToString();

                    }
                }
            }
        }


        private void FormEditCabaz_Load(object sender, EventArgs e)
        {
            PreencheListaProduto();
            getAllProductsSelectedCabaz();
            DesativarCampos(false);
            preparaInserir();
            gridCabaz.DataSource = ListCabazProduto;

            gridCabaz.RowHeadersVisible = false;

            gridCabaz.Columns[2].Visible = false;
        }


        private int RetornaIdProduto(string nomeProduto)
        {
            foreach (Produto p in listaProduto)
                if (p.Designacao == nomeProduto)
                    return p.IdProduto;
            return 0;
        }

        private int getProductId(string produto)
        {
            return RetornaIdProduto(produto);

        }

        private void reloadGrid()
        {
            gridCabaz.Rows.Clear();
            getAllProductsSelectedCabaz();
            gridCabaz.DataSource = ListCabazProduto;

            DesativarCampos(false);
        }

        private void DesativarCampos(bool interruptor)
        {
            txtProduto.Enabled = false;
            txtQuantidade.Enabled = interruptor;
            btnGuardar.Enabled = interruptor;


        }
        string quantidadeProdCabaz = "";
        private void gridCabaz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            conexao = new DbConnection();
           

            if (e.ColumnIndex == 1)
            {

                if (MessageBox.Show("Tem a certeza que quer eliminar o produto?", "Informação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        string query1 = "SELECT * FROM produto WHERE id_produto=@idproduto"; //return quantidade do produto selecionado

                        using (MySqlCommand cmd1 = new MySqlCommand(query1, conexao.FazerConexao()))
                        {
                            cmd1.Parameters.AddWithValue("@idproduto", RetornaIdProduto(txtProduto.Text));

                            using (MySqlDataReader reader = cmd1.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    quantidadeProdCabaz = reader.GetString("stock");
                                    MessageBox.Show("quantidade");
                                }
                            }
                        }

                        int stockNovo = Convert.ToInt32(quantidadeProdCabaz) + Convert.ToInt32(txtQuantidade.Text);

                        string query3 = "UPDATE produto SET stock=@novoStock WHERE id_produto=@idproduto";

                        using (MySqlCommand cmd3 = new MySqlCommand(query3, conexao.FazerConexao()))
                        {
                            cmd3.Parameters.AddWithValue("@novoStock", stockNovo.ToString());
                            cmd3.Parameters.AddWithValue("@idproduto", RetornaIdProduto(txtProduto.Text));

                            cmd3.ExecuteNonQuery();
                            MessageBox.Show("Alterado");
                        }

                        string query_ = "DELETE FROM cabazproduto WHERE id_produto=@idproduto";

                        using (MySqlCommand cmd_ = new MySqlCommand(query_, conexao.FazerConexao()))
                        {
                            cmd_.Parameters.AddWithValue("@idproduto", RetornaIdProduto(txtProduto.Text));

                            cmd_.ExecuteNonQuery();
                            MessageBox.Show("Produto removido com sucesso!");
                        }

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERRO");
                    }
                }
            }
        }

        private void gridCabaz_SelectionChanged(object sender, EventArgs e)
        {

        }
        string quantidade = "";
        private void gridCabaz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nRow = gridCabaz.CurrentCell.RowIndex;

            string produto = gridCabaz.Rows[nRow].Cells[3].Value.ToString();
            quantidade = gridCabaz.Rows[nRow].Cells[4].Value.ToString();
            txtProduto.Text = produto;
            txtQuantidade.Text = quantidade;


            if (gridCabaz.CurrentCell.ColumnIndex == 0)
            {
                DesativarCampos(true);
                btnGuardar.Enabled = true;
            }


        }

        string quantidadeNova = "";

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string sql = "update cabazProduto set quantidade=@quantidade WHERE id_produto=@idproduto AND id_cabaz=@idcabaz";

            using (MySqlCommand cmd = new MySqlCommand(sql, conexao.FazerConexao()))
            {
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                cmd.Parameters.AddWithValue("@idproduto", RetornaIdProduto(txtProduto.Text));
                cmd.Parameters.AddWithValue("@idcabaz", idCabaz);

                int nRegistos = cmd.ExecuteNonQuery();
                quantidadeNova = txtQuantidade.Text;

                int quantidadeInt = Convert.ToInt32(quantidade);
                int quantidadeNovaInt = Convert.ToInt32(quantidadeNova);

                MessageBox.Show("Registo atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (quantidadeNovaInt > quantidadeInt)
                {
                    int stock = selectStock();
                   stock = stock - quantidadeNovaInt;

                    updateStock(stock);
                    
                }
                else
                {
                    int stock = selectStock();
                    stock = stock + quantidadeNovaInt;

                    updateStock(stock);
                }

                reloadGrid();
            }

        }

        string designacaoProd = "";
        private int selectStock()
        {
            string query = "SELECT * from produto where designacao=@designacao";

            using (MySqlCommand cmd = new MySqlCommand(query, conexao.FazerConexao()))
            {
                cmd.Parameters.AddWithValue("@designacao", txtProduto.Text);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        designacaoProd = reader.GetString("stock").ToString();
                        

                    }
                }
            }

            return Convert.ToInt32(designacaoProd);
        }


        private void updateStock(int stock)
        {
            string query = "UPDATE produto SET stock=@stock WHERE designacao=@designacao";

            using (MySqlCommand cmd = new MySqlCommand(query, conexao.FazerConexao()))
            {
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@designacao", txtProduto.Text);

                cmd.ExecuteNonQuery();

            }

        }

        private void preparaInserir()
        {
            txtInserirQuantidade.Enabled = true;
            cbInserirProduto.Enabled = true;

            foreach (Produto item in listaProduto)
            {
                cbInserirProduto.Items.Add(item.Designacao);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                preparaInserir();


                InserirProduto(cbInserirProduto.Text, txtInserirQuantidade.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                
            
            
                

                

            

        }

        private void InserirProduto(string produto, string quantidade)
        {
            try
            {
                string query = "INSERT INTO cabazproduto VALUES (@idcabaz, @idproduto, @quantidade)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao.FazerConexao()))
                {
                    cmd.Parameters.AddWithValue("@idcabaz", idCabaz);
                    cmd.Parameters.AddWithValue("@idproduto", RetornaIdProduto(cbInserirProduto.Text));
                    cmd.Parameters.AddWithValue("@quantidade", txtInserirQuantidade.Text);

                    cmd.ExecuteNonQuery();

                    reloadGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}

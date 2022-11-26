using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto.Forms
{
    public partial class FormInsCabazes : Form
    {
        DbConnection conexao = new DbConnection();


        List<Produto> listaProduto;
        BindingList<Produto> listaProdutoEdit;


        ArrayList linhap = new ArrayList();

        Cabaz cabaz = new Cabaz();


        public bool editing;
        int ultInserido = 0;
        string nomeCabaz = "";
        string idcabaz = "";
        public FormInsCabazes(string idCabaz, bool editing)
        {
            InitializeComponent();
            this.idcabaz = idCabaz;
            this.editing = editing;
        }


        private int RetornaIdProduto(string nomeProduto)
        {
            foreach (Produto p in listaProduto)
                if (p.Designacao == nomeProduto)
                    return p.IdProduto;
            return 0;
        }

        private void PreencheListaProduto()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                listaProduto = new List<Produto>();
                string sql = "select id_produto, designacao from produto";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
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
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }

        private void PreparaGridInsSaidas()
        {
            try
            {
                gridInsSaidas.Columns.Clear();
                
                DataGridViewComboBoxColumn prod = new DataGridViewComboBoxColumn();
                prod.HeaderText = "Produto";
                prod.Name = "produto";
                prod.Width = 250;
                prod.DefaultCellStyle.Font = new Font("Arial", 11);
                foreach (Produto dr in listaProduto)
                {
                    linhap.Add(dr.Designacao.ToString());
                }
                prod.Items.AddRange(linhap.ToArray());
                gridInsSaidas.Columns.Add(prod);

                DataGridViewTextBoxColumn quant = new DataGridViewTextBoxColumn();
                quant.HeaderText = "Quantidade";
                quant.Name = "quant";
                quant.Width = 100;
                gridInsSaidas.Columns.Add(quant);
                quant.DefaultCellStyle.Font = new Font("Arial", 11);

                gridInsSaidas.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridInsSaidas.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;


                gridInsSaidas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }


        private void lastProdCombo()
        {
            try
            {
                DataGridViewComboBoxColumn prod = new DataGridViewComboBoxColumn();
                prod.HeaderText = "Produto";
                prod.Name = "produto";
                prod.Width = 250;
                prod.DefaultCellStyle.Font = new Font("Arial", 11);
                foreach (Produto dr in listaProduto)
                {
                    linhap.Add(dr.Designacao.ToString());
                }
                prod.Items.AddRange(linhap.ToArray());
                gridInsSaidas.Columns.Add(prod);

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }
        private void btnGravaCabaz_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection con = conexao.FazerConexao();

                string sql = "insert into cabaz(id_cabaz, designacao) values (0,@nome)";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nome", txtNomeCabaz.Text);
                    /*cmd.Parameters.AddWithValue("@id_recetor", "");
                    cmd.Parameters.AddWithValue("@estafeta", "-");
                    cmd.Parameters.AddWithValue("@datarececao", "0000-00-00");*/

                    int nRegistos = cmd.ExecuteNonQuery();

                    MessageBox.Show("Registo inserido com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ultInserido = ((int)cmd.LastInsertedId);

                }
                gridInsSaidas.Visible = true;

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }
        private void btnGravarProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (editing)
                {

                    listaProdutoEdit = new BindingList<Produto>();
                    string query = "select * from cabazproduto where id_cabaz=@idcabaz";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao.FazerConexao()))
                    {
                        cmd.Parameters.AddWithValue("idcabaz", idcabaz);


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Produto prod = new Produto(reader.GetInt32("designacao"), reader.GetString("quantidade"));
                                listaProdutoEdit.Add(prod);
                            }
                        }
                    }



                    foreach (Produto item in listaProdutoEdit)
                    {
                        gridInsSaidas.Rows.Add(item);
                    }


                }
                else
                {
                    int stockC;
                    int result;

                    MySqlConnection con = conexao.FazerConexao();

                    for (int i = 0; i < gridInsSaidas.Rows.Count - 1; i++)
                    {
                        try
                        {
                            string sql = "insert into cabazproduto values(@idcabaz,@idproduto, @quant)";

                            using (MySqlCommand cmd = new MySqlCommand(sql, con))
                            {

                                int idp = RetornaIdProduto(gridInsSaidas.Rows[i].Cells[0].Value.ToString());

                                cmd.Parameters.AddWithValue("@idcabaz", ultInserido);
                                cmd.Parameters.AddWithValue("@idproduto", idp);
                                cmd.Parameters.AddWithValue("@quant", gridInsSaidas.Rows[i].Cells[1].Value);

                                int nRegistos = cmd.ExecuteNonQuery();
                            }

                            string sql3 = "select stock from produto where id_produto=@idproduto";

                            using (MySqlCommand cmdN = new MySqlCommand(sql3, con))
                            {

                                int idp = RetornaIdProduto(gridInsSaidas.Rows[i].Cells[0].Value.ToString());

                                cmdN.Parameters.AddWithValue("@idproduto", idp);
                                //getStockProduto(idp);
                                result = (int)cmdN.ExecuteScalar();

                            }

                            string sql2 = "update produto set stock=@stockCalculado where id_produto=@idproduto";

                            using (MySqlCommand cmdX = new MySqlCommand(sql2, con))
                            {

                                int idp = RetornaIdProduto(gridInsSaidas.Rows[i].Cells[0].Value.ToString());
                                //MessageBox.Show(idp.ToString());
                                int x = Convert.ToInt32(gridInsSaidas.Rows[i].Cells[1].Value);
                                //MessageBox.Show(x.ToString());
                                stockC = result - x;

                                if (stockC < 0)
                                {
                                    MessageBox.Show("Não possui produtos suficientes" + "\nApenas possui: " + result.ToString());
                                }
                                else
                                {
                                    cmdX.Parameters.AddWithValue("@stockCalculado", stockC);
                                    cmdX.Parameters.AddWithValue("@idproduto", idp);

                                    int nRegistos = cmdX.ExecuteNonQuery();
                                }



                            }

                            MessageBox.Show("Produtos e cabaz guardados com sucesso!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Essa combinação de dados já existe na base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }


        }

        public void isEditing(bool edit)
        {
            editing = true;
        }

        public void getCabaz(string cabaz)
        {
            nomeCabaz = cabaz;
        }

        string designacao = "";
        private void selectCabaz()
        {
            string query = "SELECT * from cabaz where id_cabaz=@idcabaz";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conexao.FazerConexao()))
                {
                    cmd.Parameters.AddWithValue("@idcabaz", idcabaz);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            designacao = reader.GetString("designacao").ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            

            
        }

        private Produto RetornaProduto(int idProduto)
        {
            foreach (Produto produto in listaProduto)
                if (produto.IdProduto == idProduto)
                    return produto;
            return null;
        }


        BindingList<CabazProduto> ListCabazProduto;

        private void getAllProductsSelectedCabaz()
        {
            string query = "SELECT * FROM cabazproduto where id_cabaz=@idcabaz";

            try
            {
                ListCabazProduto = new BindingList<CabazProduto>();
                using (MySqlCommand cmd = new MySqlCommand(query, conexao.FazerConexao()))
                {
                    cmd.Parameters.AddWithValue("@idcabaz", idcabaz);

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
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

           
         
        }
        public void FormInsSaidas_Load(object sender, EventArgs e)
        {
            try
            {
                if (editing)
                {
                    gridInsSaidas.Visible = true;
                    selectCabaz();
                    PreencheListaProduto();

                    getAllProductsSelectedCabaz();

                    gridInsSaidas.DataSource = ListCabazProduto;
                    txtNomeCabaz.Enabled = false;
                    txtNomeCabaz.Text = designacao;
                }
                else
                {
                    PreencheListaProduto();
                    PreparaGridInsSaidas();
                    txtNomeCabaz.Enabled = false;
                    txtNomeCabaz.Text = Convert.ToString(cabaz.returnNomeCabaz());

                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            
        }


    }
}


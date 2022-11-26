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
    public partial class Entradas : Form
    {
        DbConnection conexao = new DbConnection();

        BindingList<Entrada> listaEntradas;
        List<Produto> listaProduto;
        List<Dador> listaDador;

        ArrayList linhad = new ArrayList();
        ArrayList linhap = new ArrayList();
        public Entradas()
        {
            InitializeComponent();
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
        private void PreencheListaDador()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                listaDador = new List<Dador>();
                string sql = "select id_dador, nome from dadores";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dador dador = new Dador(reader.GetInt32("id_dador"), reader.GetString("nome"));
                            listaDador.Add(dador);
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
        private Dador RetornaDador(int idDador)
        {
            foreach (Dador dador in listaDador)
                if (dador.IdDador == idDador)
                    return dador;
            return null;
        }
        private int RetornaIdDador(string nomeDador)
        {
            foreach (Dador dador in listaDador)
                if (dador.Nome == nomeDador)
                    return dador.IdDador;
            return 0;
        }
        private int RetornaIdProduto(string nomeProduto)
        {
            foreach (Produto p in listaProduto)
                if (p.Designacao == nomeProduto)
                    return p.IdProduto;
            return 0;
        }
        private void CarregarDG()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select * from entradas";
                listaEntradas = new BindingList<Entrada>();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaEntradas.Add(new Entrada(RetornaDador(reader.GetInt32("id_dador")),
                                                  reader.GetDateTime("data_entrada"),
                                                  RetornaProduto(reader.GetInt32("id_produto")),
                                                  reader.GetInt32("quantidade")));
                        }
                    }
                }

                gridEntradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridEntradas.EditMode = DataGridViewEditMode.EditProgrammatically;
                gridEntradas.MultiSelect = false;
                gridEntradas.DataSource = listaEntradas;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }

        }

        private void ListaEntradas()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select * from entradas";
                listaEntradas = new BindingList<Entrada>();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaEntradas.Add(new Entrada(RetornaDador(reader.GetInt32("id_dador")),
                                                  reader.GetDateTime("data_entrada"),
                                                  RetornaProduto(reader.GetInt32("id_produto")),
                                                  reader.GetInt32("quantidade")));
                        }
                    }
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


            gridEntradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEntradas.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridEntradas.MultiSelect = false;
            gridEntradas.DataSource = listaEntradas;

            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();
            eliminar.HeaderText = "";
            eliminar.Text = "Eliminar";
            eliminar.DefaultCellStyle.SelectionBackColor = Color.Red;
            eliminar.DefaultCellStyle.ForeColor = Color.White;
            eliminar.DefaultCellStyle.SelectionForeColor = Color.White;
            eliminar.DefaultCellStyle.BackColor = Color.Red;
            eliminar.FlatStyle = FlatStyle.Flat;
            eliminar.UseColumnTextForButtonValue = true;
            gridEntradas.Columns.Add(eliminar);

            gridEntradas.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridEntradas.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridEntradas.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridEntradas.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            gridEntradas.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
         


            gridEntradas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            gridEntradas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;


            foreach (DataGridViewColumn c in gridEntradas.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 12.5F, GraphicsUnit.Pixel);
            }

            gridEntradas.RowHeadersVisible = false;
            gridEntradas.Columns[0].Width = 230;
            gridEntradas.Columns[1].Width = 140;
            gridEntradas.Columns[2].Width = 220;
            gridEntradas.Columns[3].Width = 150;
            gridEntradas.Columns[4].Width = 78;
            

        }

        private void Entradas_Load(object sender, EventArgs e)
        {
            gridEntradas.BackgroundColor = Color.White;

            PreencheListaDador();
            PreencheListaProduto();
            ListaEntradas();
        }

        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDG();
            gridEntradas.Refresh();
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormInsEntradas child = new FormInsEntradas();
            child.FormClosed += new FormClosedEventHandler(child_FormClosed); 
            child.ShowDialog(this);
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                string days = datePicker.Value.Day.ToString();
                string mes = datePicker.Value.Month.ToString();
                string ano = datePicker.Value.Year.ToString();

                string date = days + "/" + mes + "/" + ano;

                string sql = "SELECT id_dador, data_entrada,  id_produto, quantidade FROM entradas WHERE data_entrada LIKE '%" + date + "%'";
                ListaEntradasPesquisadas(sql);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                
            }
        }
       

        public void ListaEntradasPesquisadas(string query)
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();

                listaEntradas = new BindingList<Entrada>();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaEntradas.Add(new Entrada(RetornaDador(reader.GetInt32("id_dador")),
                                                  reader.GetDateTime("data_entrada"),
                                                  RetornaProduto(reader.GetInt32("id_produto")),
                                                  reader.GetInt32("quantidade")));
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


            gridEntradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEntradas.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridEntradas.MultiSelect = false;
            gridEntradas.DataSource = listaEntradas;

        }

        private void gridEntradas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {           
            try
            {
                MySqlConnection con = conexao.FazerConexao();

                if (e.ColumnIndex == 0)
                {
                    int result;
                    int stockC;

                    if (MessageBox.Show("Tem a certeza que quer eliminar a entrada?", "Informação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {

                            if (gridEntradas.SelectedRows.Count > 0)
                            {
                                int codigo = int.Parse(gridEntradas.Rows[e.RowIndex].Cells[5].Value.ToString());

                                int nRow = gridEntradas.SelectedRows[0].Index;
                                Entrada ent = (Entrada)gridEntradas.SelectedRows[0].DataBoundItem;

                                string sql = "delete from entradas where id_produto=@idproduto and id_dador=@iddador and data_entrada=@data_entrada";

                                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                                {
                                    cmd.Parameters.AddWithValue("@idproduto", ((Produto)ent.IdProduto).IdProduto);
                                    cmd.Parameters.AddWithValue("@iddador", ((Dador)ent.IdDador).IdDador);
                                    cmd.Parameters.AddWithValue("@data_entrada", ent.DataEntrada.ToString("yyyy/MM/dd"));

                                    int nRegistos = cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registo eliminado com suceso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (nRegistos == 1)
                                    {

                                        listaEntradas.Remove(ent);

                                        gridEntradas.Refresh();

                                        if (nRow > 0)
                                        {
                                            gridEntradas.Rows[nRow - 1].Selected = true;
                                        }
                                    }
                                }

                                string sql3 = "select stock from produto where id_produto=@idproduto";

                                using (MySqlCommand cmd = new MySqlCommand(sql3, con))
                                {
                                    cmd.Parameters.AddWithValue("@idproduto", ((Produto)ent.IdProduto).IdProduto);
                                    result = (int)cmd.ExecuteScalar();
                                }

                                string sql2 = "update produto set stock=@stockCalculado where id_produto=@idproduto";

                                using (MySqlCommand cmd = new MySqlCommand(sql2, con))
                                {

                                    stockC = result - codigo;
                                    cmd.Parameters.AddWithValue("@stockCalculado", stockC);
                                    cmd.Parameters.AddWithValue("@idproduto", ((Produto)ent.IdProduto).IdProduto);

                                    int nRegistos = cmd.ExecuteNonQuery();

                                }
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message, "ERRO");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


        }

       
    }
}

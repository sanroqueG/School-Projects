using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Projeto.Forms
{
    public partial class FormCabazes : Form
    {

        DbConnection conexao = new DbConnection();

        BindingList<Cabaz> listaCabaz;


        BindingList<Produto> listaProdutos;


        BindingList<CabazProduto> listaCabazProduto;




        DbConnection con = new DbConnection();
        public FormCabazes()
        {
            InitializeComponent();
        }
        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadCabazes();
            gridNomeCabaz.Refresh();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormInsCabazes child = new FormInsCabazes("", false);
            child.FormClosed += new FormClosedEventHandler(child_FormClosed);
            child.ShowDialog(this);
        }
        private void FormCabazes_Load(object sender, EventArgs e)
        {
            gridProdutos.Visible = false;

            btnEditarProdutosCabaz.Visible = false;
            label1.Visible = false;
            gridNomeCabaz.Rows.Clear();
            gridNomeCabaz.MultiSelect = false;

            gridNomeCabaz.RowHeadersVisible = false;
            gridProdutos.RowHeadersVisible = false;
            gridNomeCabaz.ColumnHeadersVisible = false;
           
            loadCabazes();


            foreach (DataGridViewColumn c in gridNomeCabaz.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 15F, GraphicsUnit.Pixel);
            }
        }
        private void loadProdutos(int idCabaz)
        {

            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select * from cabazproduto WHERE id_cabaz=@idcabaz";

                listaCabazProduto = new BindingList<CabazProduto>();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@idcabaz", idCabaz);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            CabazProduto cp = new CabazProduto(reader.GetInt32("id_cabaz"),
                                                               RetornaProduto(reader.GetInt32("id_produto")),
                                                               reader.GetInt32("quantidade"));

                            listaCabazProduto.Add(cp);

                        }
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           


            gridProdutos.DataSource = listaCabazProduto;

            gridProdutos.RowHeadersVisible = false;
            gridProdutos.Columns[0].Visible = false;

        }
        private void loadCabazes()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                string sql = "select id_cabaz, designacao from cabaz";
                listaCabaz = new BindingList<Cabaz>();
                listaCabaz.Clear();
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaCabaz.Add(new Cabaz(
                                reader.GetInt32("id_cabaz"),
                                reader.GetString("designacao")));
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            

            gridNomeCabaz.DataSource = listaCabaz;
            gridNomeCabaz.Columns[0].Visible = false;
            gridNomeCabaz.RowHeadersVisible = false;
            gridNomeCabaz.Columns[2].Visible = false;
            gridNomeCabaz.Columns[3].Visible = false;
            gridNomeCabaz.Columns[4].Visible = false;
            gridNomeCabaz.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridNomeCabaz.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridNomeCabaz.MultiSelect = false;

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
                                                  reader.GetString("designacao")));
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
            foreach (Produto produto in listaProdutos)
                if (produto.IdProduto == idProduto)
                    return produto;
            return null;
        }

        int codigo = -1;
        private void gridNomeCabaz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridProdutos.Visible = true;

            ListaProdutos();
            btnEditarProdutosCabaz.Visible = true;
            label1.Visible = true;

            codigo = int.Parse(gridNomeCabaz.Rows[e.RowIndex].Cells[0].Value.ToString()); //return id cabaz
            loadProdutos(codigo);

            gridProdutos.Columns[1].Width = 200;
        }

        private void btnEditarProdutosCabaz_Click(object sender, EventArgs e)
        {

            FormEditCabaz child = new FormEditCabaz(codigo.ToString());
            child.FormClosed += new FormClosedEventHandler(child_FormClosed);
            child.ShowDialog(this);

        }

        private void btnApagarCabaz_Click(object sender, EventArgs e)
        {

            DialogResult msg = MessageBox.Show("Deseja mesmo apagar o cabaz?", "Questão?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                deleteCabaz();
                gridNomeCabaz.Rows.Clear();
                gridProdutos.Rows.Clear();
                loadCabazes();
            }
     
           
        }

        private void deleteCabaz()
        {
            string query = "DELETE FROM cabazproduto WHERE id_cabaz=@idcabaz; DELETE FROM cabaz where id_cabaz=@id_cabaz";

            using (MySqlCommand cmd = new MySqlCommand(query, conexao.FazerConexao()))
            {
                cmd.Parameters.AddWithValue("@idcabaz", codigo);
                cmd.Parameters.AddWithValue("@id_cabaz", codigo);
                cmd.ExecuteNonQuery();
            }
        }
    } 
}

using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto.Forms
{
    public partial class FormInsEntradas : Form
    {

        DbConnection conexao = new DbConnection();

        List<Produto> listaProduto;
        List<Dador> listaDador;

        ArrayList linhad = new ArrayList();
        ArrayList linhap = new ArrayList();

        DateTimePicker dateTimePicker;
        public FormInsEntradas()
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

        private void FormInsEntradas_Load(object sender, EventArgs e)
        {
            gridInsEntradas.BackgroundColor = Color.White;

            PreencheListaDador();
            PreencheListaProduto();
            PreparaGridInsEntradas();
        }

        private void PreparaGridInsEntradas()
        {

            try
            {
                DataGridViewComboBoxColumn dador = new DataGridViewComboBoxColumn();
                dador.HeaderText = "Nome Dador";
                dador.Name = "dador";
                dador.Width = 250;
                dador.DefaultCellStyle.Font = new Font("Arial", 11);
                foreach (Dador dr in listaDador)
                {
                    linhad.Add(dr.Nome.ToString());
                }
                dador.Items.AddRange(linhad.ToArray());
                gridInsEntradas.Columns.Add(dador);

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
                gridInsEntradas.Columns.Add(prod);

                DataGridViewTextBoxColumn data = new DataGridViewTextBoxColumn();
                data.HeaderText = "Data Entrada";
                data.Name = "data";
                data.Width = 150;
                gridInsEntradas.Columns.Add(data);
                data.DefaultCellStyle.Font = new Font("Arial", 11);
                DataGridViewTextBoxColumn quant = new DataGridViewTextBoxColumn();
                quant.HeaderText = "Quantidade";
                quant.Name = "quant";
                quant.Width = 100;
                gridInsEntradas.Columns.Add(quant);
                quant.DefaultCellStyle.Font = new Font("Arial", 11);
                gridInsEntradas.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridInsEntradas.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridInsEntradas.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridInsEntradas.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;

                gridInsEntradas.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                gridInsEntradas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }



        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int stockC;
            int result;

            try
            {
                MySqlConnection con = conexao.FazerConexao();

                for (int i = 0; i < gridInsEntradas.Rows.Count - 1; i++)
                {
                    try
                    {
                        //DateTime.ParseExact((string)gridInsEntradas.Rows[i].Cells[2].Value, "yyyy/MM/dd", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd");
                        string sql = "insert into entradas values(@iddador,@data, @idproduto, @quant)";

                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {

                            cmd.Parameters.AddWithValue("@iddador", RetornaIdDador(gridInsEntradas.Rows[i].Cells[0].Value.ToString()));
                            cmd.Parameters.AddWithValue("@idproduto", RetornaIdProduto(gridInsEntradas.Rows[i].Cells[1].Value.ToString()));
                            cmd.Parameters.AddWithValue("@data", dateTimePicker.Value);
                            cmd.Parameters.AddWithValue("@quant", gridInsEntradas.Rows[i].Cells[3].Value);
                            int nRegistos = cmd.ExecuteNonQuery();
                        }

                        string sql3 = "select stock from produto where id_produto=@idproduto";

                        using (MySqlCommand cmd = new MySqlCommand(sql3, con))
                        {
                            cmd.Parameters.AddWithValue("@idproduto", RetornaIdProduto(gridInsEntradas.Rows[i].Cells[1].Value.ToString()));
                            result = (int)cmd.ExecuteScalar();
                        }

                        string sql2 = "update produto set stock=@stockCalculado where id_produto=@idproduto";

                        using (MySqlCommand cmd = new MySqlCommand(sql2, con))
                        {
                            int x = Convert.ToInt32(gridInsEntradas.Rows[i].Cells[3].Value);
                            stockC = result + x;
                            cmd.Parameters.AddWithValue("@stockCalculado", stockC);
                            cmd.Parameters.AddWithValue("@idproduto", RetornaIdProduto(gridInsEntradas.Rows[i].Cells[1].Value.ToString()));

                            int nRegistos = cmd.ExecuteNonQuery();

                            btnCancelar.Enabled = true;
                            btnGravar.Enabled = true;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("A data introduzida está incorreta!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Essa combinação de dados já existe na base de dados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Registo(s) inserido(s) com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridInsEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == 2)
                {
                    dateTimePicker = new DateTimePicker();
                    gridInsEntradas.Controls.Add(dateTimePicker);
                    dateTimePicker.Format = DateTimePickerFormat.Short;
                    Rectangle rectangle = gridInsEntradas.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dateTimePicker.Size = new Size(rectangle.Width, rectangle.Height);
                    dateTimePicker.Location = new Point(rectangle.X, rectangle.Y);
                    dateTimePicker.CloseUp += new EventHandler(datetimepicker_closeup);
                    dateTimePicker.TextChanged += new EventHandler(datetimepicker_textchanged);
                    dateTimePicker.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }

            
        }

        private void datetimepicker_textchanged(object sender, EventArgs e)
        {
            gridInsEntradas.CurrentCell.Value = dateTimePicker.Text.ToString();
        }

        private void datetimepicker_closeup(object sender, EventArgs e)
        {
            dateTimePicker.Visible = false;
        }

        private void gridInsEntradas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                return;
            }
        }
    }
}

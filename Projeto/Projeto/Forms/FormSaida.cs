using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;
using Projeto.Classes.Design;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto.Forms
{
    public partial class FormSaida : Form
    {
        DbConnection conexao = new DbConnection();
        BindingList<Cabaz> listaCabaz;
        BindingList<Recetor> listaRecetor;
        BindingList<Rececao> listaRececao;

        public FormSaida()
        {
            InitializeComponent();
        }
        private Recetor RetornaRecetor(int idRecetor)
        {
            foreach (Recetor recetor in listaRecetor)
                if (recetor.IdRecetor == idRecetor)
                    return recetor;
            return null;
        }
        private Cabaz RetornaCabaz(int idCabaz)
        {
            foreach (Cabaz cabaz in listaCabaz)
                if (cabaz.IdCabaz == idCabaz)
                    return cabaz;
            return null;
        }

        private void PreencheComboRecetor()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                listaRecetor = new BindingList<Recetor>();
                string sql = "select id_recetor, nome from recetores";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recetor tipo = new Recetor(reader.GetInt32("id_recetor"), reader.GetString("nome"));
                            listaRecetor.Add(tipo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           

        }

        private void PreencheComboCabazes()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                listaCabaz = new BindingList<Cabaz>();
                string sql = "select id_cabaz, designacao from cabaz";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cabaz tipo = new Cabaz(reader.GetInt32("id_cabaz"), reader.GetString("designacao"));
                            listaCabaz.Add(tipo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           

        }


        private int RetornaIdRecetor(string nomeRecetor)
        {
            foreach (Recetor p in listaRecetor)
                if (p.Nome == nomeRecetor)
                    return p.IdRecetor;
            return 0;
        }
        private int RetornaIdCabaz(string nomeCabaz)
        {
            foreach (Cabaz p in listaCabaz)
                if (p.Designacao == nomeCabaz)
                    return p.IdCabaz;
            return 0;
        }

        private void CarregaRecetor()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                listaRecetor = new BindingList<Recetor>();
                string sql = "select id_recetor, nome, turma, enc_educacao from recetores";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Recetor rec = new Recetor(reader.GetInt32("id_recetor"), reader.GetString("nome"), reader.GetString("turma"), reader.GetString("enc_educacao"));
                            listaRecetor.Add(rec);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }



        public void ListaSaidas()
        {


            try
            {
                MySqlConnection con = conexao.FazerConexao();
                listaRececao = new BindingList<Rececao>();
                string sql = "select designacao, id_recetor, estafeta, data_rececao from cabaz where data_rececao IS NOT NULL AND estafeta IS NOT NULL AND id_recetor IS NOT NULL";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rececao rec = new Rececao(reader.GetString("designacao"),
                                                      RetornaRecetor(reader.GetInt32("id_recetor")),
                                                      reader.GetString("estafeta"),
                                                      reader.GetDateTime("data_rececao"));
                            listaRececao.Add(rec);

                        }

                        PreencheComboRecetor();
                    }
                }

                gridSaidas.DataSource = listaRececao;

                gridSaidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridSaidas.EditMode = DataGridViewEditMode.EditProgrammatically;
                gridSaidas.MultiSelect = false;



                gridSaidas.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
                gridSaidas.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridSaidas.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridSaidas.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridSaidas.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;




                foreach (DataGridViewColumn c in gridSaidas.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 12.5F, GraphicsUnit.Pixel);
                }

                gridSaidas.RowHeadersVisible = false;


                dc.designGrids(gridSaidas);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            

        }


        DesignComponentes dc = new DesignComponentes();
        private void FormSaida_Load(object sender, EventArgs e)
        {

            PreencheComboRecetor();
            PreencheComboCabazes();

            ListaSaidas();
        }

        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            gridSaidas.Rows.Clear();

           
             ListaSaidas();
            

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormInsSaida child = new FormInsSaida();
            child.FormClosed += new FormClosedEventHandler(child_FormClosed);
            child.ShowDialog(this);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            

            
        }
    }
}

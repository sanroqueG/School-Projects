using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto.Forms
{
    public partial class FormInsSaida : Form
    {
        DbConnection conexao = new DbConnection();
        List<Cabaz> listaCabaz;
        List<Recetor> listaRecetor;
       
        public FormInsSaida()
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
        private void PreencheComboRecetor()
        {
            try
            {
                MySqlConnection con = conexao.FazerConexao();
                listaRecetor = new List<Recetor>();
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
                cmbRecetor.DisplayMember = "Descrição";
                cmbRecetor.DataSource = listaRecetor;
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
                listaCabaz = new List<Cabaz>();
                string sql = "select id_cabaz, designacao from cabaz WHERE id_recetor IS NULL AND estafeta IS NULL AND data_rececao IS NULL"; //
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
                cmbCabaz.DisplayMember = "Descrição";

                foreach (Cabaz cabaz in listaCabaz)
                {
                    cmbCabaz.Items.Add(cabaz.Designacao);
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
                listaRecetor = new List<Recetor>();
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
        private void PreparaGridSaidas()
        {
            try
            {
                DataGridViewTextBoxColumn cabaz = new DataGridViewTextBoxColumn();
                cabaz.HeaderText = "Designação Cabaz";
                cabaz.Name = "cabaz";
                cabaz.Width = 200;
                cabaz.DefaultCellStyle.Font = new Font("Arial", 11);
                gridSaidas.Columns.Add(cabaz);

                DataGridViewTextBoxColumn rec = new DataGridViewTextBoxColumn();
                rec.HeaderText = "Recetor";
                rec.Name = "recetor";
                rec.Width = 250;
                rec.DefaultCellStyle.Font = new Font("Arial", 11);
                gridSaidas.Columns.Add(rec);

                DataGridViewTextBoxColumn est = new DataGridViewTextBoxColumn();
                est.HeaderText = "Estafeta";
                est.Name = "esta";
                est.Width = 200;
                est.DefaultCellStyle.Font = new Font("Arial", 11);
                gridSaidas.Columns.Add(est);

                DataGridViewTextBoxColumn data = new DataGridViewTextBoxColumn();
                data.HeaderText = "Data Receção";
                data.Name = "data";
                data.Width = 120;
                data.DefaultCellStyle.Font = new Font("Arial", 11);
                gridSaidas.Columns.Add(data);

                gridSaidas.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridSaidas.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridSaidas.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridSaidas.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;

                gridSaidas.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                gridSaidas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        
        private void FormSaida_Load(object sender, EventArgs e)
        {
            this.Text = "";
            PreencheComboRecetor();
            PreencheComboCabazes();
            PreparaGridSaidas();
        }

        HandlingSaidas hs = new HandlingSaidas();
        FormSaida fs = new FormSaida();
        private void btnGravaCabaz_Click(object sender, EventArgs e)
        {
            try
            {
                this.Refresh();
                Cabaz cabaz = new Cabaz();

                MySqlConnection con = conexao.FazerConexao();

                string sql = "update cabaz set id_recetor=@recetor," +
                        "estafeta=@estafeta, data_rececao=@datarececao where id_cabaz=@idcabaz";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@recetor", ((Recetor)cmbRecetor.SelectedItem).IdRecetor);
                    cmd.Parameters.AddWithValue("@estafeta", txtEstafeta.Text);
                    cmd.Parameters.AddWithValue("@datarececao", dateTimePicker.Value);

                    cmd.Parameters.AddWithValue("@idcabaz", RetornaIdCabaz(cmbCabaz.SelectedItem.ToString()));

                    int nRegistos = cmd.ExecuteNonQuery();

                    MessageBox.Show("Registo atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (nRegistos > 0)

                    {
                        listaCabaz.Add(new Cabaz(RetornaIdCabaz(cmbCabaz.SelectedItem.ToString()), cmbCabaz.SelectedItem.ToString(), (Recetor)cmbRecetor.SelectedItem, txtEstafeta.Text, dateTimePicker.Value));

                        gridSaidas.Rows.Add(cmbCabaz.SelectedItem.ToString(), cmbRecetor.SelectedItem, txtEstafeta.Text, dateTimePicker.Value);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }




            this.Close();

          
        }

    
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Classes.DbClasses;
using System.Windows.Forms;
using System.ComponentModel;

namespace Projeto.Classes
{
    internal class HandlingSaidas
    {
        BindingList<Rececao> listaRececao;
        BindingList<Recetor> listaRecetor;
        DbConnection conexao = new DbConnection();
        public void ListaSaidas()
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
        }

        public void clearGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }


        private void PreencheComboRecetor()
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

        private Recetor RetornaRecetor(int idRecetor)
        {
            foreach (Recetor recetor in listaRecetor)
                if (recetor.IdRecetor == idRecetor)
                    return recetor;
            return null;
        }



    }
}

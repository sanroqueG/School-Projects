using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto.Classes.DbClasses;

namespace Projeto.Classes
{
    internal class Cabaz
    {
        public int IdCabaz { get; set; }
        public string Designacao { get; set; }
        public Recetor IdRecetor { get; set; }
        public string Estafeta { get; set; }
        public DateTime DataRececao { get; set; }

        DateTime dataCriacao = DateTime.Now;

        DbConnection conn = new DbConnection();

        public Cabaz(int idCabaz, string designacao, Recetor idRecetor, string estafeta, DateTime dataRececao)
        {
            IdCabaz = idCabaz;  
            Designacao= designacao;
            IdRecetor = idRecetor;
            Estafeta = estafeta;
            DataRececao = dataRececao;
        }
        public Cabaz(string designacao)
        {
           
            Designacao = designacao;

        }
        public Cabaz(int idCabaz, string designacao)
        {
            IdCabaz = idCabaz;
            Designacao = designacao;
           
        }

        public Cabaz()
        {
        }

        public string getDate()
        {
            string dia = dataCriacao.Day.ToString();
            string mes = dataCriacao.Month.ToString();
            string ano = dataCriacao.Year.ToString();

            string data = dia + "." + mes + "." + ano;

            return data;
        }

        public string getId()
        {
            string sql = "SELECT max(id_cabaz) FROM cabaz;";
         
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn.FazerConexao());

                int id = (int)cmd.ExecuteScalar();

                int newId = id + 1;

                return newId.ToString();
            }
            catch (Exception)
            {
                return "1";         
            }

        }

        public string returnNomeCabaz()
        {
            string nomeCabaz = getDate() + "." + getId();

            return nomeCabaz;
        }


        public override string ToString()
        {
            return Designacao;
        }

        public override bool Equals(object obj)
        {
            var Cabaz = obj as Cabaz;
            return Cabaz != null && IdCabaz == Cabaz.IdCabaz;
        }

        public override int GetHashCode()
        {
            return -32434556 * IdCabaz.GetHashCode();
        }
    }
}

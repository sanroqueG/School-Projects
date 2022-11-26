using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Classes;
using Projeto.Classes.DbClasses;

namespace Projeto.Classes
{
    internal class UserHandling
    {
        DbConnection con = new DbConnection();
        List<Funcao> listaFuncoes;
        public void PreencheListaFuncoes()
        {
            listaFuncoes = new List<Funcao>();
            string sql = "select * from funcoes";
            using (MySqlCommand cmd = new MySqlCommand(sql, con.FazerConexao()))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Funcao funcao = new Funcao(reader.GetInt32("id_funcao"), reader.GetString("designacao"), reader.GetString("Permissao"));
                        listaFuncoes.Add(funcao);
                    }
                }
            }

        }
        public Funcao RetornaFuncao(int idFuncao)
        {
            foreach (Funcao funcao in listaFuncoes)
                if (funcao.CodFuncao == idFuncao)
                    return funcao;
            return null;
        }

        string usern = "";
        public string returnUsername()
        {
            string username = usern;
            return username;
        }


        public void getUser(string email, string password)
        {
            string sql = "SELECT * FROM users WHERE email=@email AND password_user=@password";

            using (MySqlCommand cmd = new MySqlCommand(sql, con.FazerConexao()))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())

                    while (reader.Read())
                    {
                        Utilizador user = new Utilizador(
                            reader.GetInt32("id_user"),
                            reader.GetString("nome"),
                            reader.GetString("email"),
                            reader.GetString("telemovel"),
                            RetornaFuncao(reader.GetInt32("id_funcao")),
                            reader.GetString("password_user"));

                        usern = reader.GetString("nome");
                    }

                var result = cmd.ExecuteNonQuery();
            }
        }

        public void inserirNovoUtilizador(string nome, string email, string telemovel, int id_funcao, string password)
        {
            string sql = "INSERT INTO users VALUES (0, @nome, @email, @telemovel, @idfuncao, @password)";

            MySqlCommand cmd = new MySqlCommand(sql, con.FazerConexao());
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telemovel", telemovel);
            cmd.Parameters.AddWithValue("@idfuncao", id_funcao);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.ExecuteNonQuery();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto.Classes
{
    internal class Utilizador
    {
        public int IdUser { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Funcao IdFuncao { get; set; }
        public string PasswordUser { get; set; }

        public Utilizador(int idUtilizador, string nome, string email, string telefone, Funcao idFuncao, string passwordUser)
        {
            IdUser = idUtilizador;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            IdFuncao = idFuncao;
            PasswordUser = passwordUser;
        }

        public Utilizador(string nome, Funcao idFuncao, string passwordUser)
        {
            Nome = nome;
            IdFuncao = idFuncao;
            PasswordUser = passwordUser;
        }
    }
}

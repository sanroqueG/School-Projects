using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    internal class Recetor
    {
        public int IdRecetor { get; set; }
        public string Nome { get; set; }
        public string Turma { get; set; }

        [DisplayName("Encarregado Educação")]
        public string EncEducacao { get; set; }

        public Recetor(int idRecetor, string nome, string turma, string encEducacao)
        {
            IdRecetor = idRecetor;
            Nome = nome;
            Turma = turma;
            EncEducacao = encEducacao;
        }
        public Recetor(int idRecetor, string nome)
        {
            IdRecetor = idRecetor;
            Nome = nome;
           
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}

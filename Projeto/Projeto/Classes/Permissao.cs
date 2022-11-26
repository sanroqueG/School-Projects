using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    internal class Permissao
    {
        public int idPermissao { get; set; }
        public string Designacao { get; set; }

        public Permissao(int idPermissao, string designacao)
        {
            this.idPermissao = idPermissao;
            Designacao = designacao;
        }

        public Permissao(string designacao)
        {
            Designacao = designacao;
        }

       
    }
}

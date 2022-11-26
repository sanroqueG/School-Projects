using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    internal class Funcao
    {
        public int CodFuncao { get; set; }
        public string Descricao { get; set; }
        public string Permissao { get; set; }

        public Funcao(int codFuncao, string descricao, string perm)
        {
            CodFuncao = codFuncao;
            Descricao = descricao;
            Permissao = perm;
        }

        public Funcao(int codFuncao)
        {
            CodFuncao = codFuncao;
        }

        public override string ToString()
        {
            return Descricao;
        }

        public override bool Equals(object obj)
        {
            var Funcao = obj as Funcao;
            return Funcao != null && CodFuncao == Funcao.CodFuncao;
        }

        public override int GetHashCode()
        {
            return -32434556 * CodFuncao.GetHashCode();
        }
    }
}

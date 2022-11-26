using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    internal class Marca
    {
        public int CodMarca { get; set; }
        public string Descricao { get; set; }

        public Marca(int codMarca, string descricao)
        {
            CodMarca = codMarca;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return Descricao;
        }

        public override bool Equals(object obj)
        {
            var Marca = obj as Marca;
            return Marca != null && CodMarca == Marca.CodMarca;
        }

        public override int GetHashCode()
        {
            return -32434556 * CodMarca.GetHashCode();
        }
    }
}

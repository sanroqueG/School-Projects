using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    internal class CategoriaDador
    {
        public int CodCategoriaDador { get; set; }
        public string Descricao { get; set; }

        public CategoriaDador(int codCategoriaDador, string descricao)
        {
            CodCategoriaDador = codCategoriaDador;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return Descricao;
        }

        public override bool Equals(object obj)
        {
            var Categoria = obj as Categoria;
            return Categoria != null && CodCategoriaDador == Categoria.IdCategoria;
        }

        public override int GetHashCode()
        {
            return -32434556 * CodCategoriaDador.GetHashCode();
        }
    }
}

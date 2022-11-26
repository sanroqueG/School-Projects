using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    internal class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }

        public Categoria(int idCategoria, string descricao)
        {
            IdCategoria = idCategoria;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return Descricao;
        }

        public override bool Equals(object obj)
        {
            var Categoria = obj as Categoria;
            return Categoria != null && IdCategoria == Categoria.IdCategoria;
        }

        public override int GetHashCode()
        {
            return -32434556 * IdCategoria.GetHashCode();
        }
    }
}

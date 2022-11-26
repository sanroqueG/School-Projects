using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    internal class Produto
    {
        [DisplayName("ID")]
        public int IdProduto { get; set; }

        [DisplayName("Designação")]
        public string Designacao { get; set; }

        [DisplayName("Marca")]
        public Marca Marca { get; set; }

        [DisplayName("Categoria")]
        public Categoria Categoria { get; set; }

        public int Stock { get; set; }

        public Produto(string designacao, int stock)
        {
            Designacao = designacao;
            Stock = stock;
        }
        public Produto(int idProduto, string designacao, Marca marca, Categoria categoria, int stock)
        {
            IdProduto = idProduto;
            Designacao = designacao;
            Marca = marca;
            Categoria = categoria;
            Stock = stock;
        }

        public Produto(int idProduto, string designacao)
        {
            IdProduto = idProduto;
            Designacao = designacao;
            
        }

        public Produto(int idProduto, int stock)
        {
            IdProduto = idProduto;
            Stock = stock;
        }

       

        public override string ToString()
        {
            return Designacao;
        }

        public override bool Equals(object obj)
        {
            var Produto = obj as Produto;
            return Produto != null && IdProduto == Produto.IdProduto;
        }

        public override int GetHashCode()
        {
            return -32434556 * IdProduto.GetHashCode();
        }
    }
}

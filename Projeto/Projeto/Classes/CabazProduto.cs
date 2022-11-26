using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    internal class CabazProduto
    {
        public int IdCabaz { get; set; }
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public CabazProduto(int idCabaz, Produto produto, int quantidade)
        {
            IdCabaz = idCabaz;
            Produto = produto;
            Quantidade = quantidade;    
        }

        public CabazProduto( Produto produto, int quantidade)
        {
           
            Produto = produto;
            Quantidade = quantidade;
        }
        public CabazProduto()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

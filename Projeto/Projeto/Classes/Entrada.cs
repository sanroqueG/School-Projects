using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    internal class Entrada
    {
        [DisplayName("Nome Dador")]
        public Dador IdDador { get; set; }

        [DisplayName("Data Entrada")]
        public DateTime DataEntrada { get; set; }
        
        [DisplayName("Produto")]
        public Produto IdProduto { get; set; }

        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }

        public Entrada(Dador idDador, DateTime dataEntrada, Produto idProduto, int quantidade)
        {
            IdDador = idDador;
            DataEntrada = dataEntrada;
            IdProduto = idProduto;
            Quantidade = quantidade;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    internal class Dador
    {
        [DisplayName("ID")]
        public int IdDador { get; set; }
        
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Categoria")]
        public CategoriaDador IdCategoriaD { get; set; }

        [DisplayName("Morada")]
        public string Morada { get; set; }

        [DisplayName("Localidade")]
        public Local CodPostal { get; set; }

        [DisplayName("NIF")]
        public string Nif { get; set; }

        public Dador(int idDador, string nome, CategoriaDador idCategoriaD, string morada, Local codPostal, string nif)
        {
            IdDador = idDador;
            Nome = nome;
            IdCategoriaD = idCategoriaD;
            Morada = morada;
            CodPostal = codPostal;
            Nif = nif;
        }
        public Dador(int idDador, string nome)
        {
            IdDador = idDador;
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }

        public override bool Equals(object obj)
        {
            var Dador = obj as Dador;
            return Dador != null && IdDador == Dador.IdDador;
        }

        public override int GetHashCode()
        {
            return -32434556 * IdDador.GetHashCode();
        }
    }
}

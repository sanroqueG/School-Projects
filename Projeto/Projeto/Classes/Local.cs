using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    internal class Local
    {
        public string CodLocal { get; set; }
        public string Localidade { get; set; }

        public Local(string codLocal, string localidade)
        {
            CodLocal = codLocal;
            Localidade = localidade;
        }

        public override string ToString()
        {
            return Localidade;
        }

        public override bool Equals(object obj)
        {
            var Local = obj as Local;
            return Local != null && CodLocal == Local.CodLocal;
        }

        public override int GetHashCode()
        {
            return -32434556 * CodLocal.GetHashCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    internal class Turma
    {
        public string IdTurma { get; set; }
        public string Descricao { get; set; }

        public Turma(string idTurma, string descricao)
        {
            IdTurma = idTurma;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return IdTurma;
        }

        public override bool Equals(object obj)
        {
            var Turma = obj as Turma;
            return Turma != null && IdTurma == Turma.IdTurma;
        }

        public override int GetHashCode()
        {
            return -32434556 * IdTurma.GetHashCode();
        }
    }
}

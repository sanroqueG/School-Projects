using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    internal class Rececao
    {
        public string Designacao { get; set; }
        public string Recetor { get; set; }
        public string Estafeta { get; set; }
        public DateTime DataRececao { get; set; }

        public Rececao(string designacao, Recetor recetor, string estafeta, DateTime dataRececao)
        {
            Designacao = designacao;
            Recetor = recetor.Nome;
            Estafeta = estafeta;
            DataRececao = dataRececao;
        }

        public Rececao()
        {
        }
    }
}

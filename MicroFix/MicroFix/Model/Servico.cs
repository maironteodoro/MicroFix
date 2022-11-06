using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFix.Model
{
    internal class Servico
    {
        private int idServico;
        private int idEmpresa;
        private string idFunc;
        private string descricao;
        private DateTime prazo;
        private DateTime dataChegada;
        private float valor;

        public int IdServico { get => idServico; set => idServico = value; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string IdFunc { get => idFunc; set => idFunc = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Prazo { get => prazo; set => prazo = value; }
        public DateTime DataChegada { get => dataChegada; set => dataChegada = value; }
        public float Valor { get => valor; set => valor = value; }
    }
}

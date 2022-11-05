using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFix.Model
{
    internal class Empresa
    {
        private int idEmpresa;
        private string nome;
        private string localizacao;
        private string cNPJ;
        private string email;
        private string nomeResp;
        private string telefone;

        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Localizacao { get => localizacao; set => localizacao = value; }
        public string CNPJ { get => cNPJ; set => cNPJ = value; }
        public string Email { get => email; set => email = value; }
        public string NomeResp { get => nomeResp; set => nomeResp = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}

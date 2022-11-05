using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MicroFix.Model
{
    internal class Status
    {
        private int idStatus;
        private int idMicroscopio;
        private int idServico;
        private string descricaoProblema;
        private string estado;
        private  Bitmap xv;

        public int IdStatus { get => idStatus; set => idStatus = value; }
        public int IdMicroscopio { get => idMicroscopio; set => idMicroscopio = value; }
        public int IdServico { get => idServico; set => idServico = value; }
        public string DescricaoProblema { get => descricaoProblema; set => descricaoProblema = value; }
        public string Estado { get => estado; set => estado = value; }
        public Bitmap Xv { get => xv; set => xv = value; }
    }
}

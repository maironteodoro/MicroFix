using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFix.Model
{
    internal class Microscopio
    {
        private int idMicroscopio;
        private string sala;
        private string marca;
        private string numSerie;
        private string modelo;
        private string numPatrimonio;

        public int IdMicroscopio { get => idMicroscopio; set => idMicroscopio = value; }
        public string Sala { get => sala; set => sala = value; }
        public string Marca { get => marca; set => marca = value; }
        public string NumSerie { get => numSerie; set => numSerie = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string NumPatrimonio { get => numPatrimonio; set => numPatrimonio = value; }
    }
}
 
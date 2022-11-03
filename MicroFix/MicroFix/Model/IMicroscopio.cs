using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFix.Model
{
    internal interface IMicroscopio
    {
        void adicionaMicro(Microscopio m);
        void alteraMicro(Microscopio m);
        void excluiMicro(Microscopio m);
        IEnumerable<Microscopio> Get(string pesquisa);
        Microscopio GetMicroscopio(int id);
        IEnumerable<Microscopio> GetAllMicroscopios();
    }
}

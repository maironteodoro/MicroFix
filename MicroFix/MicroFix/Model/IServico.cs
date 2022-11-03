using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFix.Model
{
    internal interface IServico
    {
        void adicionaServico(Servico se);
        void alteraServico(Servico se);
        void excluiServico(Servico se);
    }
}

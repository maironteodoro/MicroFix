using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFix.Model
{
    internal interface IServico
    {
        int adicionaServico(Servico se);
        void alteraServico(Servico se);
        void excluiServico(Servico se);
        Servico GetServicoById(int id);
        Servico GetServicoByMicroId(int id);
        IEnumerable<Servico> GetAllServico();
    }
}

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
        IEnumerable<Servico> GetServicoByIdEmpresa(int IdEmpresa);
        IEnumerable<Servico> GetServicoByIdFunc(int IdFunc);
        Servico GetServico(int id);
        IEnumerable<Servico> GetAllServico();
    }
}

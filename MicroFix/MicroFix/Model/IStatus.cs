using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFix.Model
{
    internal interface IStatus
    {
        void adicionaStatus(Status s);
        void alteraStatus(Status s);
        void concluiStatus(int cod);
        void excluiStatus(Status s);
        IEnumerable<Status> GetStatusByIdMicroscopio(int IdMicroscopio);
        IEnumerable<Status> GetStatusByIdServico(int IdServico);
        Status GetStatus(int id);
        IEnumerable<Status> GetAllStatus();
    }
}

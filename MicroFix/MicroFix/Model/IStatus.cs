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
        void excluiStatus(Status s);
    }
}

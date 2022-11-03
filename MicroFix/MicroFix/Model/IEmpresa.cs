using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroFix.Model
{
    internal interface IEmpresa
    {
        void adicionaEmp(Empresa e);
        void alteraEmp(Empresa e);
        void excluiEmp(Empresa e);
    }
}

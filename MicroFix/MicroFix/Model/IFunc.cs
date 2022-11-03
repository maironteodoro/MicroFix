using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MicroFix.Model
{
    internal interface IFunc
    {
        void mongoDBAdd(Funcionario f);//lembrar que IdFunc é string
    }

}

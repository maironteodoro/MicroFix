using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MicroFix.Model
{
    internal class Funcionario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        //lembrar que IdFunc é string
        private string idFunc;
        private string nameFunc;
        private string area;
        private string senha;

        public string IdFunc { get => idFunc; set => idFunc = value; }
        public string NameFunc { get => nameFunc; set => nameFunc = value; }
        public string Area { get => area; set => area = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}

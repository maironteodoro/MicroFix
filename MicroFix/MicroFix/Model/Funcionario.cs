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

        private string id;
        private string nameFunc;
        private string area;
        private string senha;

        public string Id { get => id; set => id = value; }
        public string NameFunc { get => nameFunc; set => nameFunc = value; }
        public string Area { get => area; set => area = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroFix.Model;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MicroFix.Repository
{
    internal class RFunc:IFunc
    {
        public async void mongoDBAdd(Funcionario f)//lembrar que IdFunc é string
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "MicroFix";
            string collectionName = "Funcionario";

            var cliente = new MongoClient(connectionString);//se conecta com o banco
            var db = cliente.GetDatabase(databaseName);//conecta ao database
            var collection = db.GetCollection<Funcionario>(collectionName);//e escolhe a 
            await collection.InsertOneAsync(f);
        }
    }
}

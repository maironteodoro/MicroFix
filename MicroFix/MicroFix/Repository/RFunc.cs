using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroFix.Model;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.ObjectModel;
using System.Net.Mail;

namespace MicroFix.Repository
{
    internal class RFunc : IFunc
    {
        public void AdicionarFunc(Funcionario f)//lembrar que IdFunc é string // inserção de informações no banco
        {
            ConnectToMongo<Funcionario>().InsertOne(f);
        }
        
        public void AtualizarFunc(Funcionario f)//lembrar que IdFunc é string // Altera as infos de um Func
        {
            var filtro = Builders<Funcionario>.Filter.Where(c => c.IdFunc == f.IdFunc);
            var alteracao = Builders<Funcionario>.Update.Set(c => c.NomeFunc, f.NomeFunc)
                                                        .Set(c => c.Area, f.Area)
                                                        .Set(c => c.Senha, f.Senha);
            ConnectToMongo<Funcionario>().UpdateMany(filtro, alteracao);
        }
        public void ExcluirFunc(Funcionario f)
        {
            var filtro = Builders<Funcionario>.Filter.Where(c => c.IdFunc == f.IdFunc);//seta o filtro
            ConnectToMongo<Funcionario>().DeleteOne(filtro);
        }
        public  List<Funcionario> GetAllFunc()// retorna lista de todos funcionarios
        {
            var filtro = Builders<Funcionario>.Filter.Empty;

            List<Funcionario> Funcionarios = ConnectToMongo<Funcionario>().Find<Funcionario>(filtro).ToList() ;
            return Funcionarios;
        }
        public List<Funcionario> GetFuncById(string IdFunc)// retorna um funcionario com o id especificado//lembrar que IdFunc é string
        {
            
            var filtro = Builders<Funcionario>.Filter.Where(c => c.IdFunc == IdFunc);

            List<Funcionario> Funcionarios = ConnectToMongo<Funcionario>().Find<Funcionario>(filtro).ToList();
            return Funcionarios;
        }
        public List<Funcionario> GetFuncByName(string NomeFunc)// retorna um funcionario com o id especificado
        {

            var filtro = Builders<Funcionario>.Filter.Where(c => c.NomeFunc == NomeFunc);

            List<Funcionario> Funcionarios =ConnectToMongo<Funcionario>().Find<Funcionario>(filtro).ToList();
            return Funcionarios;
        }
        public bool Confirm(string Nome,string senha)//Confirma login de funcionario
        {
            var filtro = Builders<Funcionario>.Filter.Where(c => c.NomeFunc == Nome && c.Senha == senha);
            var Funcionarios = ConnectToMongo<Funcionario>().Find<Funcionario>(filtro).ToList();
            foreach (var func in Funcionarios)
            {
                if(func.NomeFunc == Nome && func.Senha == senha)
                {
                    return true;
                }
            }
            return false;
        }
        public void AdicionarById(Funcionario f)
        {
            var filtro = Builders<Funcionario>.Filter.Where(c => c.IdFunc == f.IdFunc);
            var alteracao = Builders<Funcionario>.Update.Set(c => c.NomeFunc, f.NomeFunc)
                                                        .Set(c => c.Area, "Funcionario")
                                                        .Set(c => c.Senha, f.Senha);
            ConnectToMongo<Funcionario>().UpdateMany(filtro, alteracao);
        }
        private IMongoCollection<Funcionario> ConnectToMongo<Funcionairo>()//Conecção com o banco 
        {
            var cliente = new MongoClient("mongodb://localhost:27017");//se conecta com o banco
            var db = cliente.GetDatabase("MicroFix");//conecta ao database
            return db.GetCollection<Funcionario>("Funcionario");//e escolhe a 
        }
        public List<Funcionario> GetFuncByNameandSenha(string NomeFunc, string senha)// retorna um funcionario com o id especificado
        {

            var filtro = Builders<Funcionario>.Filter.Where(c => c.NomeFunc == NomeFunc && c.Senha == senha);

            List<Funcionario> Funcionarios = ConnectToMongo<Funcionario>().Find<Funcionario>(filtro).ToList();
            return Funcionarios;
        }
        public void AtualizarCargo(Funcionario f)//lembrar que IdFunc é string // Altera as infos de um Func
        {
            var filtro = Builders<Funcionario>.Filter.Where(c => c.IdFunc == f.IdFunc);
            var alteracao = Builders<Funcionario>.Update.Set(c => c.NomeFunc, f.NomeFunc)
                                                        .Set(c => c.Area, "Gerente")
                                                        .Set(c => c.Senha, f.Senha);
            ConnectToMongo<Funcionario>().UpdateMany(filtro, alteracao);
        }
    }
}

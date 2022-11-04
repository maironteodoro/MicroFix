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
        void AdicionarFunc(Funcionario f);//Adicio um Func//lembrar que IdFunc é string 
        void ExcluirFunc(Funcionario f);//excluir um Func
        void AtualizarFunc(Funcionario f);//Altera um Func
        Funcionario GetFuncById(string IdFunc);// retorna um funcionario com o id especificado
        Funcionario GetFuncByName(string NomeFunc);//Retorna um funcionario pelo nome
        List<Funcionario> GetAllFunc();//Retorna todos os Func's


    }

}

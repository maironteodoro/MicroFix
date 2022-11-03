using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroFix.Model;
using System.Data.SqlClient;

namespace MicroFix.Repository
{
    internal class REmpresa:IEmpresa
    {
        public void adicionaEmp(Empresa e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Insert into Empresa(Nome, Localizacao, CNPJ, Email, NomeResp, Telefone) " +
                $"values ('{e.Nome}', '{e.Localizacao}', '{e.CNPJ}', '{e.Email}', '{e.NomeResp}', '{e.Telefone}')";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void alteraEmp(Empresa e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Update Empresa set Nome = '{e.Nome}', Localizacao = '{e.Localizacao}',CNPJ = '{e.CNPJ}',Email = '{e.Email}', " +
                $"NomeResp = '{e.NomeResp}', Telefone = '{e.Telefone}' where IdEmpresa = {e.IdEmpresa}";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void excluiEmp(Empresa e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Delete Empresa where IdEmpresa = {e.IdEmpresa}";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

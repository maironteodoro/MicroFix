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
        public IEnumerable<Empresa> Get(string pesquisa)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Empresa where Nome like '{pesquisa}%'";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Empresa> ListaDadosEmpresa = new List<Empresa>();
            while (dr.Read())
            {
                Empresa e = new Empresa();
                e.IdEmpresa = int.Parse(dr[0].ToString());
                e.Nome = dr[1].ToString();
                e.Localizacao = dr[2].ToString();
                e.CNPJ = dr[3].ToString();
                e.Email = dr[4].ToString();
                e.NomeResp = dr[5].ToString();
                e.Telefone = dr[6].ToString();
                ListaDadosEmpresa.Add(e);
            }
            return ListaDadosEmpresa;
        }
        public Empresa GetEmpresa(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Empresa where IdEmpresa = {id}";

            SqlDataReader dr = cmd.ExecuteReader();
            Empresa e = new Empresa();

            if (dr.Read())
            {
                e.IdEmpresa = int.Parse(dr[0].ToString());
                e.Nome = dr[1].ToString();
                e.Localizacao = dr[2].ToString();
                e.CNPJ = dr[3].ToString();
                e.Email = dr[4].ToString();
                e.NomeResp = dr[5].ToString();
                e.Telefone = dr[6].ToString();
            }
            return e;
        }
        public IEnumerable<Empresa> GetAllEmpresas()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Empresa";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Empresa> ListaDadosEmpresa = new List<Empresa>();
            while (dr.Read())
            {
                Empresa e = new Empresa();
                e.IdEmpresa = int.Parse(dr[0].ToString());
                e.Nome = dr[1].ToString();
                e.Localizacao = dr[2].ToString();
                e.CNPJ = dr[3].ToString();
                e.Email = dr[4].ToString();
                e.NomeResp = dr[5].ToString();
                e.Telefone = dr[6].ToString();
                ListaDadosEmpresa.Add(e);
            }
            return ListaDadosEmpresa;
        }
    }
}

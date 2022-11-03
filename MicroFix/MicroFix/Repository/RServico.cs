using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroFix.Model;
using System.Data.SqlClient;

namespace MicroFix.Repository
{
    internal class RServico:IServico
    {
        public void adicionaServico(Servico se)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Insert into Status(IdEmpresa, IdFunc,Descricao,Prazo,Valor,DataChegada) " +

                //checar se os tipos date como prazo e Data chegada estão incrementando corretamente
                $"values ('{se.IdEmpresa}', '{se.IdFunc}', '{se.Descricao}', '{se.Prazo}','{se.Valor}','{se.DataChegada}')";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void alteraServico(Servico se)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Update Servico set IdEmpresa = '{se.IdEmpresa}',IdFunc = '{se.IdFunc}',Descricao = '{se.Descricao}'," +
                $"Prazo = '{se.Prazo}',Valor ='{se.Valor}',DataChegada = '{se.DataChegada}' where IdServico = {se.IdServico}";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void excluiServico(Servico se)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Delete Servico where IdServico = {se.IdServico}";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public IEnumerable<Servico> GetServicoByIdEmpresa(int IdEmpresa)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Servico where IdEmpresa like '{IdEmpresa}%'";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Servico> ListaDadosServico = new List<Servico>();
            while (dr.Read())
            {
                Servico se = new Servico();
                se.IdServico = int.Parse(dr[0].ToString());
                se.Descricao = dr[1].ToString();
                se.Prazo = DateTime.Parse(dr[2].ToString());
                se.Valor = double.Parse(dr[3].ToString());
                se.IdEmpresa = int.Parse(dr[4].ToString());
                se.IdFunc = int.Parse(dr[5].ToString());
                se.DataChegada = DateTime.Parse(dr[6].ToString());
                ListaDadosServico.Add(se);
            }
            return ListaDadosServico;
        }
        public IEnumerable<Servico> GetServicoByIdFunc(int IdFunc)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Servico where IdFunc like '{IdFunc}%'";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Servico> ListaDadosServico = new List<Servico>();
            while (dr.Read())
            {
                Servico se = new Servico();
                se.IdServico = int.Parse(dr[0].ToString());
                se.Descricao = dr[1].ToString();
                se.Prazo = DateTime.Parse(dr[2].ToString());
                se.Valor = double.Parse(dr[3].ToString());
                se.IdEmpresa = int.Parse(dr[4].ToString());
                se.IdFunc = int.Parse(dr[5].ToString());
                se.DataChegada = DateTime.Parse(dr[6].ToString());
                ListaDadosServico.Add(se);
            }
            return ListaDadosServico;
        }
        public Servico GetServico(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Servico where IdServico = {id}";

            SqlDataReader dr = cmd.ExecuteReader();
            Servico se = new Servico();

            if (dr.Read())
            {
                se.IdServico = int.Parse(dr[0].ToString());
                se.Descricao = dr[1].ToString();
                se.Prazo = DateTime.Parse(dr[2].ToString());
                se.Valor = double.Parse(dr[3].ToString());
                se.IdEmpresa = int.Parse(dr[4].ToString());
                se.IdFunc = int.Parse(dr[5].ToString());
                se.DataChegada = DateTime.Parse(dr[6].ToString());
            }
            return se;
        }
        public IEnumerable<Servico> GetAllServico()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Servico";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Servico> ListaDadosServico = new List<Servico>();
            while (dr.Read())
            {
                Servico se = new Servico();
                se.IdServico = int.Parse(dr[0].ToString());
                se.Descricao = dr[1].ToString();
                se.Prazo = DateTime.Parse(dr[2].ToString());
                se.Valor = double.Parse(dr[3].ToString());
                se.IdEmpresa = int.Parse(dr[4].ToString());
                se.IdFunc = int.Parse(dr[5].ToString());
                se.DataChegada = DateTime.Parse(dr[6].ToString());
                ListaDadosServico.Add(se);
            }
            return ListaDadosServico;
        }
    }
}

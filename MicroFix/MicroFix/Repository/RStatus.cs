using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroFix.Model;
using System.Data.SqlClient;

namespace MicroFix.Repository
{
    internal class RStatus:IStatus
    {
        public void adicionaStatus(Status s)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Insert into Status(IdMicroscopio, IdServico, Status,DescricaoProblema) " +
                $"values ('{s.IdMicroscopio}', '{s.IdServico}', '{s.Estado}', '{s.DescricaoProblema}')";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void alteraStatus(Status s)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Update Status set IdMicroscopio = '{s.IdMicroscopio}',IdServico = '{s.IdServico}', " +
                $"Status ='{s.Estado}',DescricaoProblema = '{s.DescricaoProblema}' where IdStatus = {s.IdStatus}";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void excluiStatus(Status s)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Delete Status where IdStatus = {s.IdStatus}";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public IEnumerable<Status> GetStatusByIdMicroscopio(int IdMicroscopio)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Status where IdMicroscopio like '{IdMicroscopio}%'";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Status> ListaDadosStatus = new List<Status>();
            while (dr.Read())
            {
                Status s = new Status();
                s.IdStatus = int.Parse(dr[0].ToString());
                s.Estado = dr[1].ToString();
                s.IdMicroscopio = int.Parse(dr[2].ToString());
                s.IdServico = int.Parse(dr[3].ToString());
                s.DescricaoProblema = dr[4].ToString();
                ListaDadosStatus.Add(s);
            }
            return ListaDadosStatus;
        }
        public IEnumerable<Status> GetStatusByIdServico(int IdServico)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Status where IdServico like '{IdServico}%'";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Status> ListaDadosStatus = new List<Status>();
            while (dr.Read())
            {
                Status s = new Status();
                s.IdStatus = int.Parse(dr[0].ToString());
                s.Estado = dr[1].ToString();
                s.IdMicroscopio = int.Parse(dr[2].ToString());
                s.IdServico = int.Parse(dr[3].ToString());
                s.DescricaoProblema = dr[4].ToString();
                ListaDadosStatus.Add(s);
            }
            return ListaDadosStatus;
        }
        public Status GetStatus(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Status where IdStatus = {id}";

            SqlDataReader dr = cmd.ExecuteReader();
            Status s = new Status();

            if (dr.Read())
            {
                s.IdStatus = int.Parse(dr[0].ToString());
                s.Estado = dr[1].ToString();
                s.IdMicroscopio = int.Parse(dr[2].ToString());
                s.IdServico = int.Parse(dr[3].ToString());
                s.DescricaoProblema = dr[4].ToString();
            }
            return s;
        }
        public List<Status> GetStatusByNumSerie(int NumSerie)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select s.IdStatus, s.Status, s.IdMicroscopio,s.IdServico, s.DescricaoProblema from Status s inner join Microscopio m on s.IdMicroscopio = m.IdMicroscopio " +
                $"where m.NumSerie = {NumSerie}";

            SqlDataReader dr = cmd.ExecuteReader();

            List<Status> ListaDadosStatus = new List<Status>();
            while (dr.Read())
            {
                Status s = new Status();
                s.IdStatus = int.Parse(dr[0].ToString());
                s.Estado = dr[1].ToString();
                s.IdMicroscopio = int.Parse(dr[2].ToString());
                s.IdServico = int.Parse(dr[3].ToString());
                s.DescricaoProblema = dr[4].ToString();
                ListaDadosStatus.Add(s);
            }
            return ListaDadosStatus;
        }
        public IEnumerable<Status> GetAllStatus()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Status";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Status> ListaDadosStatus = new List<Status>();
            while (dr.Read())
            {
                Status s = new Status();
                s.IdStatus = int.Parse(dr[0].ToString());
                s.Estado = dr[1].ToString();
                s.IdMicroscopio = int.Parse(dr[2].ToString());
                s.IdServico = int.Parse(dr[3].ToString());
                s.DescricaoProblema = dr[4].ToString();
                ListaDadosStatus.Add(s);
            }
            return ListaDadosStatus;
        }

        public void concluiStatus(int cod)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Update Status set Status = 'concluido' where IdStatus = '{cod}'";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AndamentoStatus(int cod)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Update Status set Status = 'Em andamento' where IdStatus = '{cod}'";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

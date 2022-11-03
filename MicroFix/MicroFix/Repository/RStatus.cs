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
            string sql = $"Insert into Status(IdMicoscopio, IdServico, Satus,DescricaoProblema) " +
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroFix.Model;
using System.Data.SqlClient;

namespace MicroFix.Repository
{
    internal class RMicroscopio:IMicroscopio
    {
        public void adicionaMicro(Microscopio m)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Insert into Microscopio(Sala, Marca, NumSerie, Modelo, NumPatrimonio) " +
                $"values ('{m.Sala}', '{m.Marca}', '{m.NumSerie}', '{m.Modelo}', '{m.NumPatrimonio}')";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void alteraMicro(Microscopio m)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Update Microscopio set Sala = '{m.Sala}', Marca ='{m.Marca}', " +
                $" NumSerie = '{m.NumSerie}',Modelo = '{m.Modelo}',NumPatrimonio = '{m.NumPatrimonio}' where IdMicroscopio = {m.IdMicroscopio}";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void excluiMicro(Microscopio m)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();
            string sql = $"Delete Microscopio where IdMicroscopio = {m.IdMicroscopio}";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

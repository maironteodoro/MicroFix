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
        public IEnumerable<Microscopio> Get(string pesquisa)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Microscopio where NumSerie like '{pesquisa}%'";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Microscopio> ListaDadosMicroscopio = new List<Microscopio>();
            while (dr.Read())
            {
                Microscopio m = new Microscopio();
                m.IdMicroscopio = int.Parse(dr[0].ToString());
                m.Sala = dr[1].ToString();
                m.Marca = dr[2].ToString();
                m.NumSerie = dr[3].ToString();
                m.Modelo = dr[4].ToString();
                m.NumPatrimonio = dr[5].ToString();
                ListaDadosMicroscopio.Add(m);
            }
            return ListaDadosMicroscopio;
        }
        public Microscopio GetMicroscopio(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Microscopio where IdMicroscopio = {id}";

            SqlDataReader dr = cmd.ExecuteReader();
            Microscopio m = new Microscopio();

            if (dr.Read())
            {
                m.IdMicroscopio = int.Parse(dr[0].ToString());
                m.Sala = dr[1].ToString();
                m.Marca = dr[2].ToString();
                m.NumSerie = dr[3].ToString();
                m.Modelo = dr[4].ToString();
                m.NumPatrimonio = dr[5].ToString();
            }
            return m;
        }
        public IEnumerable<Microscopio> GetAllMicroscopios()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server =DESKTOP-0G0JKVA;Database=MicroFix;UID=mairon;PWD=123";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Microscopio";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Microscopio> ListaDadosMicroscopio = new List<Microscopio>();
            while (dr.Read())
            {
                Microscopio m = new Microscopio();
                m.IdMicroscopio = int.Parse(dr[0].ToString());
                m.Sala = dr[1].ToString();
                m.Marca = dr[2].ToString();
                m.NumSerie = dr[3].ToString();
                m.Modelo = dr[4].ToString();
                m.NumPatrimonio = dr[5].ToString();
                ListaDadosMicroscopio.Add(m);
            }
            return ListaDadosMicroscopio;
        }
    }
}

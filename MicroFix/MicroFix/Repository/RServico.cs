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
                $"values ('{se.IdEmpresa}', '{se.IdFunc}', '{se.Descricao}', '{se.Prazo}','{se.Prazo}','{se.Valor}','{se.DataChegada}')";

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
                $"Prazo = '{se.Prazo}',Prazo = '{se.Prazo}',Valor ='{se.Valor}',DataChegada = '{se.DataChegada}' where IdServico = {se.IdServico}";

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
    }
}

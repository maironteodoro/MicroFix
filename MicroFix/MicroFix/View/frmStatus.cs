using MicroFix.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroFix.Model;
using ServiceStack;
using System.Data.SqlClient;

namespace MicroFix.View
{
    public partial class frmStatus : MetroFramework.Forms.MetroForm
    {
        public frmStatus()
        {
            InitializeComponent();
        }

        RStatus rs = new RStatus();
        public int id { get; set; }

        private void btt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btt_concluir_Click(object sender, EventArgs e)
        {
            
            rs.concluiStatus(id);
            MessageBox.Show("Concluido com sucesso!!!");
            dataGridView1.DataSource = rs.GetAllStatus();
        }

        private void btt_pesquisar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rs.GetStatusByNumSerie(int.Parse(txt_numero.Text));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmStatus_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = "Server =DESKTOP-DTIFNMB\\SQLEXPRESS;Database=MicroFix;UID=ph;PWD=123";
            //conn.Open();

            //string sql = "Select * from dbo.StatusCorreto";

            //using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            //{
            //    using (DataTable dt = new DataTable())
            //    {
            //        da.Fill(dt);
            //        dataGridView1.DataSource = dt;
            //    }
            //}
            dataGridView1.DataSource = rs.GetAllStatus();
            dataGridView1.Columns["IdStatus"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btt_andamento_Click(object sender, EventArgs e)
        {
            rs.AndamentoStatus(id);
            MessageBox.Show("Concluido com sucesso!!!");
            dataGridView1.DataSource = rs.GetAllStatus();
        }
    }
}

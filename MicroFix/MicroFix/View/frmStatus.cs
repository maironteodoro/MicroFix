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

namespace MicroFix.View
{
    public partial class frmStatus : Form
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
            id = int.Parse(txt_numero.Text);
            rs.concluiStatus(id);
            MessageBox.Show("Concluido com sucesso!!!");
        }

        private void btt_pesquisar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rs.GetStatus(int.Parse(txt_numero.Text));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

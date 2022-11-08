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
using MicroFix.Repository;
using MicroFix.View;

namespace MicroFix.View
{
    public partial class frmPesquisaEmpresa : MetroFramework.Forms.MetroForm
    {
        public frmPesquisaEmpresa()
        {
            InitializeComponent();
        }
        REmpresa re = new REmpresa();
        Empresa emp = new Empresa();
        private int id;
        public int Id { get => id; set => id = value; }

        private void frmPesquisaEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = re.Get(txtNome.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

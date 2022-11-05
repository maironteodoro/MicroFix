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

namespace MicroFix.View
{
    public partial class frmMenu : Form
    {
        Funcionario f = new Funcionario();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa fe = new frmEmpresa();
            fe.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMicroscopio fm = new frmMicroscopio();
            fm.ShowDialog();

        }

        private void btnFormulário_Click(object sender, EventArgs e)
        {
            frmFormulario ff = new frmFormulario();
            ff.ShowDialog();
        }
    }
}

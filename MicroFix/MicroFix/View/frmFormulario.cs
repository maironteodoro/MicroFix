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
    public partial class frmFormulario : Form
    {
        public frmFormulario()
        {
            InitializeComponent();
        }
        REmpresa re = new REmpresa();
        RMicroscopio rm = new RMicroscopio();
        RFunc rf = new RFunc();
        private string idFunc;
        private int idEmpresa;
        private int idMicroscopio;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmFormulario_Load(object sender, EventArgs e)
        {
            cmbEmpresa.DataSource = re.GetAllEmpresas();
            cmbEmpresa.DisplayMember = "Nome";
            cmbEmpresa.ValueMember = "IdEmpresa";
            cmbFuncionario.DataSource = rf.GetAllFunc();
            cmbFuncionario.DisplayMember = "NomeFunc";
            cmbFuncionario.ValueMember = "IdFunc";
            cmbMicroscopio.DataSource = rm.GetAllMicroscopios();
            cmbMicroscopio.DisplayMember = "NumSerie";
            cmbMicroscopio.ValueMember = "IdMicroscopio";
        }

        private void cmbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            idFunc = ((Funcionario)cmbFuncionario.SelectedItem).IdFunc.ToString();
                 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

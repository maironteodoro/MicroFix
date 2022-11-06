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
    public partial class frmBusca : Form
    {
        public frmBusca()
        {
            InitializeComponent();
        }
        private int flag = 0;
        REmpresa re = new REmpresa();
        RFunc rf = new RFunc();
        RMicroscopio rm = new RMicroscopio();
        RServico rs = new RServico();


        private void habilita()
        {
            if (flag == 0)
            {
                txtNome.Enabled = false;
                label1.Enabled = false;
                label1.Text = "";
                btnBuscar.Enabled = false;
            }
            else if ( flag > 0)
            {
                txtNome.Enabled = true;
                label1.Enabled = true;
                btnBuscar.Enabled = true;
                switch(flag)
                {
                    case 1://Funcionário
                        {   
                            dataGridView1.DataSource = rf.GetAllFunc();
                            dataGridView1.Columns["Senha"].Visible = false;
                            break;
                        }
                    case 2://Microscopio
                        {
                            
                            dataGridView1.DataSource = rm.GetAllMicroscopios();
                            break;
                        }
                    case 3://Empresa
                        { 
                            dataGridView1.DataSource = re.GetAllEmpresas();
                            break;
                        }
                    case 4://Formulário
                        {
                            dataGridView1.DataSource = rs.GetAllServico();
                            break;
                        }
                }
            }
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void rbFunc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFunc.Checked)
            {
                flag = 1;
                habilita();

            }
        }
        private void frmBusca_Load(object sender, EventArgs e)
        {

            flag = 0;
            habilita();
        }

        private void rbMicroscopio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMicroscopio.Checked)
            {
                flag = 2;
                habilita();
            }
        }

        private void rbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpresa.Checked)
            {
                flag = 3;
                habilita();
            }
        }

        private void rbFormulário_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFormulário.Checked)
            {
                flag = 4;
                habilita();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private int Id;
        private string sId;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            frmMostra fm = new frmMostra();
            fm.Flag = flag;

            if (flag == 1)
            {
                sId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
                fm.SId = sId;
                
            }
            else
            {
                Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()); ;
                fm.Id = Id;
            }
            fm.ShowDialog();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmMostra fm = new frmMostra();
            fm.Flag = flag;
            if (flag == 1)
            {
                sId = txtNome.Text;
                fm.SId = sId;
                
            }
            else 
            {
                Id = int.Parse(txtNome.Text);
                fm.Id = Id;
            }
            fm.ShowDialog();
        }
    }
}

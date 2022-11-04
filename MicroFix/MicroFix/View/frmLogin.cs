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

namespace MicroFix
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        RFunc rf = new RFunc();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool confirmacao = rf.Confirm(txtNome.Text,txtSenha.Text);
            if (confirmacao==true)
            {
                frmMenu frmM = new frmMenu();
                frmM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha ou Nome incorreto. Tente Novamente!","Alerta!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }

}

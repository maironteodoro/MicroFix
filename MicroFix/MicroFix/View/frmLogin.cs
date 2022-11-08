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
using System.Diagnostics;
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
            List<Funcionario> lf = new List<Funcionario>();
            Funcionario f = new Funcionario();
            if (confirmacao==true)
            {
                lf = rf.GetFuncByNameandSenha(txtNome.Text, txtSenha.Text);
                foreach(var func in lf)
                {
                    if (func.Senha ==txtSenha.Text && func.NomeFunc == txtNome.Text)
                    {
                        f = func;
                        break;
                    }
                }
                frmMenu frmM = new frmMenu();
                frmM.F = f;
                this.Visible = false;
                frmM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha ou Nome incorreto. Tente Novamente!","Alerta!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadastrarFunc fcf = new frmCadastrarFunc();
            fcf.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.instagram.com/absmicroscopia/");
            Process.Start(sInfo);
        
        }
    }

}

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
    public partial class frmCadastrarFunc : Form
    {

        RFunc rf = new RFunc();
        //lembrar que IdFunc é string
        public frmCadastrarFunc()
        {
            InitializeComponent();
        }

        private void frmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSenha.Text == txtSenha2.Text)
            {
                List<Funcionario> listFunc = new List<Funcionario>();
                listFunc = rf.GetAllFunc();
                foreach(Funcionario func in listFunc)
                {
                    if (func.IdFunc == txtID.Text)
                    {
                        if (func.NomeFunc == null&& func.Senha == null)
                        {
                            Funcionario f = new Funcionario();
                            f.NomeFunc = txtNome.Text;
                            f.Senha = txtSenha.Text;
                            f.IdFunc = txtID.Text;
                            rf.AdicionarById(f);
                            MessageBox.Show("Funcionário cadastrado com sucesso!");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Funcionário com este ID já existente. Contate seu Gerente", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }
                    }
                }   
                    MessageBox.Show("ID não encontrado. Contate seu Gerente", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Senha Incorreta. Tente Novamente!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

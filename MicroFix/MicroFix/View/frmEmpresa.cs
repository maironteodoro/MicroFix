using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroFix.Repository;
using MicroFix.Model;
using System.Data.SqlClient;
using MicroFix.View;

namespace MicroFix.View
{
    public partial class frmEmpresa : MetroFramework.Forms.MetroForm
    {
        public frmEmpresa()
        {
            InitializeComponent();

        }
        private int Flag = 1;//1 = base ; 2 = inserindo //3 = alterando
        REmpresa re = new REmpresa();
        Empresa emp = new Empresa();
        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            Flag = 1;
            Habilita();
            LimpaControle();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Flag = 2;
            Habilita();
            LimpaControle();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LimpaControle()
        {
            txtCNPJ.Text = "";
            txtEmail.Text = "";
            txtNomeEmp.Text = "";
            txtLocalizacao.Text = "";
            txtTelefone.Text = "";
            txtNomeResp.Text = "";
        }
        private void Habilita()
        {
            btnCadastrar.Enabled = (Flag == 1);
            btnPesquisa.Enabled = (Flag == 1);
            btnExcluir.Enabled = (Flag == 3);
            btnSalvar.Enabled = (Flag == 2|| Flag ==3);
            btnSalvar.Visible = (Flag == 2|| Flag == 3);

            if (Flag == 2 || Flag == 3)
            {
                txtCNPJ.Enabled = true;
                txtEmail.Enabled = true;
                txtNomeEmp.Enabled = true;
                txtLocalizacao.Enabled = true;
                txtTelefone.Enabled = true;
                txtNomeResp.Enabled = true;
            }
            else
            {
                txtCNPJ.Enabled = false;
                txtEmail.Enabled = false;
                txtNomeEmp.Enabled = false;
                txtLocalizacao.Enabled = false;
                txtTelefone.Enabled = false;
                txtNomeResp.Enabled = false;
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            frmPesquisaEmpresa fpe = new frmPesquisaEmpresa();
            fpe.ShowDialog();
            int id = fpe.Id;
            emp = re.GetEmpresa(id);
            txtNomeEmp.Text = emp.Nome;
            txtLocalizacao.Text = emp.Localizacao;
            txtCNPJ.Text = emp.CNPJ;
            txtEmail.Text = emp.Email;
            txtNomeResp.Text = emp.NomeResp;
            txtTelefone.Text = emp.Telefone;
            Flag = 3;
            btnExcluir.Enabled = true;
            Habilita();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show
                ("Deseja excluir esse registro?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                if (Flag == 3)
                {
                    re.excluiEmp(emp);
                    MessageBox.Show("Excluido com sucesso!!!");
                    LimpaControle();
                    Flag = 1;
                    Habilita();
                }
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            emp.Nome = txtNomeEmp.Text;
            emp.Localizacao = txtLocalizacao.Text;
            emp.CNPJ = txtCNPJ.Text;
            emp.Email = txtEmail.Text;
            emp.NomeResp = txtNomeResp.Text;
            emp.Telefone = txtTelefone.Text;
            if (Flag == 2)
            {
                re.adicionaEmp(emp);
                MessageBox.Show("Nova empresa cadastrada com sucesso!");
            }
            else if (Flag == 3)
            {
                re.alteraEmp(emp);
                MessageBox.Show("Empresa Alterada com sucesso!");
            }
            LimpaControle();
            Flag = 1;
            Habilita();
        }
    }
}

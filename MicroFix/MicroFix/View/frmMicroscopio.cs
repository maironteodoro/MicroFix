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
    public partial class frmMicroscopio : Form
    {
        public frmMicroscopio()
        {
            InitializeComponent();
        }
        private int Flag = 1;
        RMicroscopio rm = new RMicroscopio();
        Microscopio m = new Microscopio();
        private void frmMicroscopio_Load(object sender, EventArgs e)
        {
            Flag = 1;
            Habilita();
            LimpaControle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LimpaControle()
        {
            txtNumSerie.Text = "";
            txtModelo.Text = "";
            txtSala.Text = "";
            txtMarca.Text = "";
            txtNumPatrimonio.Text = "";
        }
        private void Habilita()
        {
            btnCadastrar.Enabled = (Flag == 1);
            btnPesquisa.Enabled = (Flag == 1);
            btnExcluir.Enabled = (Flag == 3);
            btnSalvar.Enabled = (Flag == 2 || Flag == 3);
            btnSalvar.Visible = (Flag == 2 || Flag == 3);

            if (Flag == 2 || Flag == 3)
            {
                txtNumSerie.Enabled = true;
                txtModelo.Enabled = true;
                txtSala.Enabled = true;
                txtMarca.Enabled = true;
                txtNumPatrimonio.Enabled = true;
            }
            else
            {
                txtNumSerie.Enabled = false;
                txtModelo.Enabled = false;
                txtSala.Enabled = false;
                txtMarca.Enabled = false;
                txtNumPatrimonio.Enabled = false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Flag = 2;
            Habilita();
            LimpaControle();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            frmPesquisaMicroscopio fpm = new frmPesquisaMicroscopio();
            fpm.ShowDialog();
            int id = fpm.Id;
            m = rm.GetMicroscopio(id);
            txtNumSerie.Text= m.NumSerie;
            txtModelo.Text = m.Modelo;
            txtSala.Text= m.Sala;
            txtMarca.Text =m.Marca;
            txtNumPatrimonio.Text =m.NumPatrimonio;
            Flag = 3;
            Habilita();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            m.NumSerie = txtNumSerie.Text;
            m.Modelo = txtModelo.Text;
            m.Sala = txtSala.Text;
            m.Marca = txtMarca.Text;
            m.NumPatrimonio = txtNumPatrimonio.Text;
            if (Flag == 2)
            {
                rm.adicionaMicro(m);
                MessageBox.Show("Nova microscopio cadastrado com sucesso!");
            }
            else if (Flag == 3)
            {
                rm.alteraMicro(m);
                MessageBox.Show("Microscopio alterado com sucesso!");
            }
            LimpaControle();
            Flag = 1;
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
                    rm.excluiMicro(m);
                    MessageBox.Show("Excluido com sucesso!!!");
                    LimpaControle();
                    Flag = 1;
                    Habilita();
                }
            }
        }
    }
}

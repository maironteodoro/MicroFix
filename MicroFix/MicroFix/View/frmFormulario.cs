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
    public partial class frmFormulario : MetroFramework.Forms.MetroForm
    {
        public frmFormulario()
        {
            InitializeComponent();
        }
        REmpresa re = new REmpresa();
        RMicroscopio rm = new RMicroscopio();
        RFunc rf = new RFunc();
        RServico rs = new RServico();
        RStatus rse = new RStatus();
        Servico s = new Servico();
        Status st = new Status();
        private int Flag = 1;//1 = base ; 2 = inserindo //3 = alterando
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmFormulario_Load(object sender, EventArgs e)
        {
            Flag = 1;
            Habilita();
            LimpaControle();
            Loadcmb();
        }

        private void cmbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.IdFunc = ((Funcionario)cmbFuncionario.SelectedItem).IdFunc.ToString();
                 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbMicroscopio_SelectedIndexChanged(object sender, EventArgs e)
        {
            st.IdMicroscopio = int.Parse(((Microscopio)cmbMicroscopio.SelectedItem).IdMicroscopio.ToString());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            s.IdEmpresa = int.Parse(((Empresa)cmbEmpresa.SelectedItem).IdEmpresa.ToString());
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            s.Descricao = txtDescricaoProblema.Text;
            s.Prazo = dtpPrazo.Value;
            s.DataChegada = dtpChegada.Value;
            st.DescricaoProblema = txtDescricaoProblema.Text;
            s.Valor = float.Parse(txtValor.Text);
            st.Estado = "Em Manutenção";
            if (Flag == 2)
            {
                st.IdServico = rs.adicionaServico(s);
                rse.adicionaStatus(st);
                MessageBox.Show("Novo Formulário cadastrado com sucesso!");
            }
            else if (Flag == 3)
            {

                rs.alteraServico(s);
                rse.alteraStatus(st);
                MessageBox.Show("Formulário alterado com sucesso!");
            }
            LimpaControle();
            Flag = 1;
            Habilita();
        }
        private void LimpaControle()
        {
            Loadcmb();
            txtValor.Text = "";
            txtDescricaoProblema.Text = "";
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
                cmbEmpresa.Enabled = true;
                cmbFuncionario.Enabled = true;
                cmbMicroscopio.Enabled = true;
                dtpPrazo.Enabled = true;
                dtpChegada.Enabled = true;
                txtDescricaoProblema.Enabled = true;
                txtValor.Enabled = true;
            }
            else
            {
                cmbEmpresa.Enabled = false;
                cmbFuncionario.Enabled = false;
                cmbMicroscopio.Enabled = false;
                dtpPrazo.Enabled = false;
                dtpChegada.Enabled = false;
                txtDescricaoProblema.Enabled = false;
                txtValor.Enabled = false;
            }
        }
        void Loadcmb()
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
        

        private void txtDescricaoProblema_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Flag = 2;
            Habilita();
            LimpaControle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Flag = 3;
            Habilita();
            LimpaControle();
            frmPesquisaMicroscopio fpm = new frmPesquisaMicroscopio();
            fpm.ShowDialog();
            int id = fpm.Id;


            Servico servico = new Servico();
            servico = rs.GetServicoByMicroId(id);
            s.IdServico = servico.IdServico;
            txtValor.Text = servico.Valor.ToString();
            txtDescricaoProblema.Text = servico.Descricao ;
            dtpChegada.Text = (servico.DataChegada).ToString();
            dtpPrazo.Text = (servico.Prazo).ToString();

            Empresa emp = new Empresa();
            emp= re.GetEmpresa(servico.IdEmpresa);
            cmbEmpresa.Text = emp.Nome;
            //func empresa microscopio
            List<Funcionario> f = new List<Funcionario>();
             f = rf.GetFuncById(servico.IdFunc);
            foreach(var item in f)
            {
                cmbFuncionario.Text = item.NomeFunc;
            }

            Microscopio m = new Microscopio();
             m= rm.GetMicroscopio(id);
            cmbMicroscopio.Text =m.NumSerie;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        { 
            if (DialogResult.Yes == MessageBox.Show
                ("Deseja excluir esse registro?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                if (Flag == 3)
                {
                    rs.excluiServico(s);
                    rse.excluiStatus(st);
                    MessageBox.Show("Excluido com sucesso!!!");
                    LimpaControle();
                    Flag = 1;
                    Habilita();
                }
            }
        }
    }

}

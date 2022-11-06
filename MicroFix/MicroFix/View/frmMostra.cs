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
    public partial class frmMostra : Form
    {
        public frmMostra()
        {
            InitializeComponent();
        }

        private string sId;
        private int id;
        private int flag;
        public string SId { get => sId; set => sId = value; }
        public int Id { get => id; set => id = value; }
        public int Flag { get => flag; set => flag = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMostra_Load(object sender, EventArgs e)
        {
            habilita();
            switch(Flag)
            {
                case 1://funcionario
                    {
                        RFunc rf = new RFunc();
                        List<Funcionario> lf = new List<Funcionario>();
                        lf = rf.GetFuncById(SId);
                        foreach(Funcionario f in lf)
                        {
                            txt1.Text = f.NomeFunc;
                            txt2.Text = f.Area;
                        }
                        break;
                    }
                case 2://microscopio
                    {
                        RMicroscopio rm = new RMicroscopio();
                        Microscopio m = new Microscopio();
                        m = rm.GetMicroscopio(Id);
                        txt1.Text = m.NumSerie;
                        txt2.Text = m.Modelo;
                        txt3.Text = m.NumPatrimonio;
                        txt4.Text = m.Marca;
                        txt5.Text = m.Sala;
                        break;
                    }
                case 3://empresa
                    {
                        REmpresa re = new REmpresa();
                        Empresa emp = new Empresa();
                        emp = re.GetEmpresa(Id);
                        txt1.Text = emp.Nome;
                        txt2.Text = emp.Localizacao;
                        txt3.Text = emp.CNPJ;
                        txt4.Text = emp.Email;
                        txt5.Text = emp.NomeResp;
                        txt6.Text = emp.Telefone;
                        break;
                    }
                case 4://formulario
                    {
                        RServico rs = new RServico();
                        Servico s = new Servico();
                        s = rs.GetServicoById(Id);

                        REmpresa rm = new REmpresa();
                        Empresa emp = new Empresa();
                        emp = rm.GetEmpresa(s.IdEmpresa);

                        SId = s.IdFunc;
                        RFunc rf = new RFunc();
                        List<Funcionario> lf = new List<Funcionario>();
                        lf = rf.GetFuncById(SId);
                        
                        txt1.Text = emp.Nome;
                        foreach (Funcionario f in lf)
                        {
                            txt2.Text = f.NomeFunc;
                        }
                        txt3.Text = s.DataChegada.ToString("dd/MM/yyyy");
                        txt4.Text = s.Prazo.ToString("dd/MM/yyyy");
                        txt5.Text = s.Valor.ToString("R$000.00");
                        txtDescricao.Text = s.Descricao;
                        break;
                    }
            }
        }
        private void habilita()
        { 
            switch(Flag)
            {
                case 1://funcionario
                    {
                        txt1.Visible = true;
                        txt2.Visible = true;
                        lbl1.Visible = true;
                        lbl1.Text = "Funcionáro: ";
                        lbl1.Location = new Point(56, 43);
                        lbl2.Visible = true;
                        lbl2.Text = "Area:";
                        lbl2.Location = new Point(89, 70);
                        break;
                    }
                case 2://microscopio
                    {
                        txt1.Visible = true;
                        txt2.Visible = true;
                        txt3.Visible = true;
                        txt4.Visible = true;
                        txt5.Visible = true;
                        lbl1.Visible=true;
                        lbl1.Text = "Número de série: ";
                        lbl1.Location = new Point(30, 40);

                        lbl2.Visible=true;
                        lbl2.Text = "Modelo: ";
                        lbl2.Location = new Point(75, 67);

                        lbl3.Visible = true;
                        lbl3.Text = "Número de Patrimonio: ";
                        lbl3.Location = new Point(7, 93);

                        lbl4.Visible = true;
                        lbl4.Text = "Marca: ";
                        lbl4.Location = new Point(79, 120);

                        lbl5.Visible = true;
                        lbl5.Text = "Sala: ";
                        lbl5.Location = new Point(88, 145);
                        break;
                    }
                case 3://empresa
                    {
                        txt1.Visible = true;
                        txt2.Visible = true;
                        txt3.Visible = true;
                        txt4.Visible = true;
                        txt5.Visible = true;
                        txt6.Visible = true;
                        lbl1.Visible = true;
                        lbl1.Text = "Empresa: ";
                        lbl1.Location = new Point(66,40);
                        lbl2.Visible = true;
                        lbl2.Text = "Localização: ";
                        lbl2.Location = new Point(53, 67);
                        lbl3.Visible = true;
                        lbl3.Text = "CNPJ: ";
                        lbl4.Visible = true;
                        lbl4.Text = "Email: ";
                        lbl5.Visible = true;
                        lbl5.Text = "Nome do responsável: ";
                        lbl6.Visible = true;
                        lbl6.Text = "Telefone: ";
                        break;
                    }
                case 4://formulario
                    {
                        txt1.Visible = true;
                        txt2.Visible = true;
                        txt3.Visible = true;
                        txt4.Visible = true;
                        txt5.Visible = true;
                        txtDescricao.Visible = true;
                        lbl1.Visible = true;
                        lbl1.Text = "Empresa: ";
                        lbl1.Location = new Point(68, 40);

                        lbl2.Visible = true;
                        lbl2.Text = "Funcionário: ";
                        lbl2.Location = new Point(56, 68);

                        lbl3.Visible = true;
                        lbl3.Text = "Data de chegada: ";
                        lbl3.Location = new Point(27, 95);

                        lbl4.Visible = true;
                        lbl4.Text = "Prazo: ";

                        lbl5.Visible = true;
                        lbl5.Text = "Valor: ";
                        lbl5.Location = new Point(88, 145);

                        lblDescricao.Visible = true;
                        lblDescricao.Text = "Descrição: ";
                        break;
                    }
            }
            
        
        
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }
    }
}

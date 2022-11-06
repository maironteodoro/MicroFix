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
    public partial class frmGerarFunc : Form
    {
        public frmGerarFunc()
        {
            InitializeComponent();
        }
        RFunc rf = new RFunc();
        Funcionario f = new Funcionario();
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            rf.AdicionarFunc(f);
            List<Funcionario> listFunc = new List<Funcionario>();
            listFunc = rf.GetAllFunc();
            foreach (Funcionario func in listFunc)
            {
                if (func.NomeFunc == null && func.Senha == null)
                {
                    Funcionario f = new Funcionario();
                    f.IdFunc = func.IdFunc;
                    break;
                }
            }
            txtNome.Text = f.IdFunc;
         }

        private void frmGerarFunc_Load(object sender, EventArgs e)
        {

        }
    }
}

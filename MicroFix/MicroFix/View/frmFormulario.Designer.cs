namespace MicroFix.View
{
    partial class frmFormulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpChegada = new System.Windows.Forms.DateTimePicker();
            this.dtpPrazo = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtDescricaoProblema = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.cmbMicroscopio = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbFuncionario);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpChegada);
            this.panel2.Controls.Add(this.dtpPrazo);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnPesquisa);
            this.panel2.Controls.Add(this.txtDescricaoProblema);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbEmpresa);
            this.panel2.Controls.Add(this.cmbMicroscopio);
            this.panel2.Location = new System.Drawing.Point(60, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 531);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Funcionario:";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.Enabled = false;
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(206, 183);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(180, 24);
            this.cmbFuncionario.TabIndex = 32;
            this.cmbFuncionario.SelectedIndexChanged += new System.EventHandler(this.cmbFuncionario_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Descrição de problemas:";
            // 
            // dtpChegada
            // 
            this.dtpChegada.Enabled = false;
            this.dtpChegada.Location = new System.Drawing.Point(205, 213);
            this.dtpChegada.Name = "dtpChegada";
            this.dtpChegada.Size = new System.Drawing.Size(280, 22);
            this.dtpChegada.TabIndex = 31;
            // 
            // dtpPrazo
            // 
            this.dtpPrazo.Enabled = false;
            this.dtpPrazo.Location = new System.Drawing.Point(205, 251);
            this.dtpPrazo.Name = "dtpPrazo";
            this.dtpPrazo.Size = new System.Drawing.Size(280, 22);
            this.dtpPrazo.TabIndex = 30;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(418, 325);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 49);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Enabled = false;
            this.btnPesquisa.Location = new System.Drawing.Point(585, 112);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(104, 49);
            this.btnPesquisa.TabIndex = 26;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtDescricaoProblema
            // 
            this.txtDescricaoProblema.BackColor = System.Drawing.Color.White;
            this.txtDescricaoProblema.Enabled = false;
            this.txtDescricaoProblema.Location = new System.Drawing.Point(48, 336);
            this.txtDescricaoProblema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricaoProblema.Multiline = true;
            this.txtDescricaoProblema.Name = "txtDescricaoProblema";
            this.txtDescricaoProblema.Size = new System.Drawing.Size(341, 160);
            this.txtDescricaoProblema.TabIndex = 25;
            this.txtDescricaoProblema.TextChanged += new System.EventHandler(this.txtDescricaoProblema_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(205, 291);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(179, 22);
            this.txtValor.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Prazo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Data chegada:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(418, 421);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(104, 49);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(585, 421);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 49);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Empresa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Microscoio:";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Enabled = false;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(206, 110);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(180, 24);
            this.cmbEmpresa.TabIndex = 28;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // cmbMicroscopio
            // 
            this.cmbMicroscopio.Enabled = false;
            this.cmbMicroscopio.FormattingEnabled = true;
            this.cmbMicroscopio.Location = new System.Drawing.Point(205, 151);
            this.cmbMicroscopio.Name = "cmbMicroscopio";
            this.cmbMicroscopio.Size = new System.Drawing.Size(180, 24);
            this.cmbMicroscopio.TabIndex = 29;
            this.cmbMicroscopio.SelectedIndexChanged += new System.EventHandler(this.cmbMicroscopio_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::MicroFix.Properties.Resources.errado;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(866, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 25);
            this.button7.TabIndex = 14;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(908, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFormulario";
            this.Load += new System.EventHandler(this.frmFormulario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtDescricaoProblema;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpChegada;
        private System.Windows.Forms.DateTimePicker dtpPrazo;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.ComboBox cmbMicroscopio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFuncionario;
    }
}
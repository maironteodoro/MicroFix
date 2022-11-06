namespace MicroFix.View
{
    partial class frmBusca
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.rbMicroscopio = new System.Windows.Forms.RadioButton();
            this.rbFunc = new System.Windows.Forms.RadioButton();
            this.rbFormulário = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 421);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 118);
            this.panel2.TabIndex = 23;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(375, 40);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 49);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(179, 48);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(179, 28);
            this.txtNome.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.rbFormulário);
            this.panel1.Controls.Add(this.rbEmpresa);
            this.panel1.Controls.Add(this.rbMicroscopio);
            this.panel1.Controls.Add(this.rbFunc);
            this.panel1.Location = new System.Drawing.Point(522, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 118);
            this.panel1.TabIndex = 24;
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.Location = new System.Drawing.Point(3, 69);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(83, 20);
            this.rbEmpresa.TabIndex = 19;
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            this.rbEmpresa.CheckedChanged += new System.EventHandler(this.rbEmpresa_CheckedChanged);
            // 
            // rbMicroscopio
            // 
            this.rbMicroscopio.AutoSize = true;
            this.rbMicroscopio.Location = new System.Drawing.Point(3, 40);
            this.rbMicroscopio.Name = "rbMicroscopio";
            this.rbMicroscopio.Size = new System.Drawing.Size(102, 20);
            this.rbMicroscopio.TabIndex = 18;
            this.rbMicroscopio.TabStop = true;
            this.rbMicroscopio.Text = "Microscópio";
            this.rbMicroscopio.UseVisualStyleBackColor = true;
            this.rbMicroscopio.CheckedChanged += new System.EventHandler(this.rbMicroscopio_CheckedChanged);
            // 
            // rbFunc
            // 
            this.rbFunc.AutoSize = true;
            this.rbFunc.Location = new System.Drawing.Point(3, 15);
            this.rbFunc.Name = "rbFunc";
            this.rbFunc.Size = new System.Drawing.Size(98, 20);
            this.rbFunc.TabIndex = 17;
            this.rbFunc.TabStop = true;
            this.rbFunc.Text = "Funcionário";
            this.rbFunc.UseVisualStyleBackColor = true;
            this.rbFunc.CheckedChanged += new System.EventHandler(this.rbFunc_CheckedChanged);
            // 
            // rbFormulário
            // 
            this.rbFormulário.AutoSize = true;
            this.rbFormulário.Location = new System.Drawing.Point(112, 15);
            this.rbFormulário.Name = "rbFormulário";
            this.rbFormulário.Size = new System.Drawing.Size(92, 20);
            this.rbFormulário.TabIndex = 20;
            this.rbFormulário.TabStop = true;
            this.rbFormulário.Text = "Formulário";
            this.rbFormulário.UseVisualStyleBackColor = true;
            this.rbFormulário.CheckedChanged += new System.EventHandler(this.rbFormulário_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::MicroFix.Properties.Resources.errado;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(866, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 25);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(923, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusca";
            this.Load += new System.EventHandler(this.frmBusca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFormulário;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.RadioButton rbMicroscopio;
        private System.Windows.Forms.RadioButton rbFunc;
    }
}
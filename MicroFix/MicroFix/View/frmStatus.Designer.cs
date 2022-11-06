namespace MicroFix.View
{
    partial class frmStatus
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
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btt_pesquisar = new System.Windows.Forms.Button();
            this.btt_concluir = new System.Windows.Forms.Button();
            this.btt_sair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(192, 44);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(296, 30);
            this.txt_numero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de serie:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btt_pesquisar
            // 
            this.btt_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_pesquisar.Location = new System.Drawing.Point(519, 34);
            this.btt_pesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btt_pesquisar.Name = "btt_pesquisar";
            this.btt_pesquisar.Size = new System.Drawing.Size(143, 47);
            this.btt_pesquisar.TabIndex = 2;
            this.btt_pesquisar.Text = "Pesquisar";
            this.btt_pesquisar.UseVisualStyleBackColor = true;
            this.btt_pesquisar.Click += new System.EventHandler(this.btt_pesquisar_Click);
            // 
            // btt_concluir
            // 
            this.btt_concluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_concluir.Location = new System.Drawing.Point(352, 478);
            this.btt_concluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btt_concluir.Name = "btt_concluir";
            this.btt_concluir.Size = new System.Drawing.Size(176, 58);
            this.btt_concluir.TabIndex = 3;
            this.btt_concluir.Text = "Concluido";
            this.btt_concluir.UseVisualStyleBackColor = true;
            this.btt_concluir.Click += new System.EventHandler(this.btt_concluir_Click);
            // 
            // btt_sair
            // 
            this.btt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_sair.Location = new System.Drawing.Point(152, 478);
            this.btt_sair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btt_sair.Name = "btt_sair";
            this.btt_sair.Size = new System.Drawing.Size(112, 58);
            this.btt_sair.TabIndex = 4;
            this.btt_sair.Text = "Sair";
            this.btt_sair.UseVisualStyleBackColor = true;
            this.btt_sair.Click += new System.EventHandler(this.btt_sair_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(527, 336);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btt_sair);
            this.Controls.Add(this.btt_concluir);
            this.Controls.Add(this.btt_pesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_numero);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStatus";
            this.Text = "frmStatus";
            this.Load += new System.EventHandler(this.frmStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btt_pesquisar;
        private System.Windows.Forms.Button btt_concluir;
        private System.Windows.Forms.Button btt_sair;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
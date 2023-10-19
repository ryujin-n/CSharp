namespace miniprojetins
{
    partial class frmProd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtDat = new System.Windows.Forms.MaskedTextBox();
            this.cboQtde = new System.Windows.Forms.NumericUpDown();
            this.btoPesq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboStat = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVa = new System.Windows.Forms.TextBox();
            this.txtVu = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimp = new System.Windows.Forms.Button();
            this.btoRem = new System.Windows.Forms.Button();
            this.btoAlt = new System.Windows.Forms.Button();
            this.btoCad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboQtde)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mtxtDat);
            this.groupBox1.Controls.Add(this.cboQtde);
            this.groupBox1.Controls.Add(this.btoPesq);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtProd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Código";
            // 
            // mtxtDat
            // 
            this.mtxtDat.Location = new System.Drawing.Point(398, 19);
            this.mtxtDat.Mask = "##/##/####";
            this.mtxtDat.Name = "mtxtDat";
            this.mtxtDat.ReadOnly = true;
            this.mtxtDat.Size = new System.Drawing.Size(67, 23);
            this.mtxtDat.TabIndex = 11;
            // 
            // cboQtde
            // 
            this.cboQtde.Location = new System.Drawing.Point(286, 99);
            this.cboQtde.Name = "cboQtde";
            this.cboQtde.Size = new System.Drawing.Size(69, 23);
            this.cboQtde.TabIndex = 3;
            // 
            // btoPesq
            // 
            this.btoPesq.Location = new System.Drawing.Point(66, 36);
            this.btoPesq.Name = "btoPesq";
            this.btoPesq.Size = new System.Drawing.Size(30, 23);
            this.btoPesq.TabIndex = 1;
            this.btoPesq.Text = "...";
            this.btoPesq.UseVisualStyleBackColor = true;
            this.btoPesq.Click += new System.EventHandler(this.btoPesq_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Produto";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(10, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(50, 23);
            this.txtID.TabIndex = 0;
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(10, 99);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(270, 23);
            this.txtProd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantidade";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboStat);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtVa);
            this.groupBox2.Controls.Add(this.txtVu);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 262);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cboStat
            // 
            this.cboStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStat.FormattingEnabled = true;
            this.cboStat.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cboStat.Location = new System.Drawing.Point(259, 37);
            this.cboStat.Name = "cboStat";
            this.cboStat.Size = new System.Drawing.Size(121, 23);
            this.cboStat.TabIndex = 2;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(10, 88);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(455, 153);
            this.txtObs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Unitário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Varejo";
            // 
            // txtVa
            // 
            this.txtVa.Location = new System.Drawing.Point(139, 37);
            this.txtVa.Name = "txtVa";
            this.txtVa.Size = new System.Drawing.Size(114, 23);
            this.txtVa.TabIndex = 1;
            this.txtVa.Enter += new System.EventHandler(this.txtVa_Enter);
            this.txtVa.Leave += new System.EventHandler(this.txtVa_Leave);
            // 
            // txtVu
            // 
            this.txtVu.Location = new System.Drawing.Point(6, 37);
            this.txtVu.Name = "txtVu";
            this.txtVu.Size = new System.Drawing.Size(127, 23);
            this.txtVu.TabIndex = 0;
            this.txtVu.Enter += new System.EventHandler(this.txtVu_Enter);
            this.txtVu.Leave += new System.EventHandler(this.txtVu_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Controls.Add(this.btoLimp);
            this.groupBox3.Controls.Add(this.btoRem);
            this.groupBox3.Controls.Add(this.btoAlt);
            this.groupBox3.Controls.Add(this.btoCad);
            this.groupBox3.Location = new System.Drawing.Point(12, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 44);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(398, 15);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(75, 23);
            this.btoSair.TabIndex = 4;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoLimp
            // 
            this.btoLimp.Location = new System.Drawing.Point(322, 15);
            this.btoLimp.Name = "btoLimp";
            this.btoLimp.Size = new System.Drawing.Size(75, 23);
            this.btoLimp.TabIndex = 3;
            this.btoLimp.Text = "Limpar";
            this.btoLimp.UseVisualStyleBackColor = true;
            this.btoLimp.Click += new System.EventHandler(this.btoLim_Click);
            // 
            // btoRem
            // 
            this.btoRem.Location = new System.Drawing.Point(246, 15);
            this.btoRem.Name = "btoRem";
            this.btoRem.Size = new System.Drawing.Size(75, 23);
            this.btoRem.TabIndex = 2;
            this.btoRem.Text = "Remover";
            this.btoRem.UseVisualStyleBackColor = true;
            this.btoRem.Click += new System.EventHandler(this.btoRem_Click);
            // 
            // btoAlt
            // 
            this.btoAlt.Location = new System.Drawing.Point(170, 15);
            this.btoAlt.Name = "btoAlt";
            this.btoAlt.Size = new System.Drawing.Size(75, 23);
            this.btoAlt.TabIndex = 1;
            this.btoAlt.Text = "Alterar";
            this.btoAlt.UseVisualStyleBackColor = true;
            this.btoAlt.Click += new System.EventHandler(this.btoAlt_Click);
            // 
            // btoCad
            // 
            this.btoCad.Location = new System.Drawing.Point(95, 15);
            this.btoCad.Name = "btoCad";
            this.btoCad.Size = new System.Drawing.Size(75, 23);
            this.btoCad.TabIndex = 0;
            this.btoCad.Text = "Cadastrar";
            this.btoCad.UseVisualStyleBackColor = true;
            this.btoCad.Click += new System.EventHandler(this.btoCad_Click);
            // 
            // frmProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 475);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmProd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboQtde)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox mtxtDat;
        private NumericUpDown cboQtde;
        private Label label1;
        private TextBox txtProd;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label7;
        private Button btoPesq;
        private TextBox txtID;
        private ComboBox cboStat;
        private TextBox txtObs;
        private TextBox txtVa;
        private TextBox txtVu;
        private Button btoSair;
        private Button btoLimp;
        private Button btoRem;
        private Button btoAlt;
        private Button btoCad;
    }
}
namespace miniprojetins
{
    partial class frmOS
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
            this.cboQntde = new System.Windows.Forms.NumericUpDown();
            this.mtxtDat = new System.Windows.Forms.MaskedTextBox();
            this.cboIDprod = new System.Windows.Forms.ComboBox();
            this.cboStat = new System.Windows.Forms.ComboBox();
            this.cboProd = new System.Windows.Forms.ComboBox();
            this.btoPesq = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimp = new System.Windows.Forms.Button();
            this.btoDel = new System.Windows.Forms.Button();
            this.btoAlt = new System.Windows.Forms.Button();
            this.btoCad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboQntde)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboQntde);
            this.groupBox1.Controls.Add(this.mtxtDat);
            this.groupBox1.Controls.Add(this.cboIDprod);
            this.groupBox1.Controls.Add(this.cboStat);
            this.groupBox1.Controls.Add(this.cboProd);
            this.groupBox1.Controls.Add(this.btoPesq);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboQntde
            // 
            this.cboQntde.Location = new System.Drawing.Point(133, 84);
            this.cboQntde.Name = "cboQntde";
            this.cboQntde.Size = new System.Drawing.Size(120, 23);
            this.cboQntde.TabIndex = 15;
            // 
            // mtxtDat
            // 
            this.mtxtDat.Location = new System.Drawing.Point(387, 22);
            this.mtxtDat.Mask = "##/##/####";
            this.mtxtDat.Name = "mtxtDat";
            this.mtxtDat.ReadOnly = true;
            this.mtxtDat.Size = new System.Drawing.Size(67, 23);
            this.mtxtDat.TabIndex = 14;
            // 
            // cboIDprod
            // 
            this.cboIDprod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDprod.FormattingEnabled = true;
            this.cboIDprod.Location = new System.Drawing.Point(389, 83);
            this.cboIDprod.Name = "cboIDprod";
            this.cboIDprod.Size = new System.Drawing.Size(62, 23);
            this.cboIDprod.TabIndex = 2;
            this.cboIDprod.Visible = false;
            // 
            // cboStat
            // 
            this.cboStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStat.FormattingEnabled = true;
            this.cboStat.Location = new System.Drawing.Point(260, 84);
            this.cboStat.Name = "cboStat";
            this.cboStat.Size = new System.Drawing.Size(121, 23);
            this.cboStat.TabIndex = 2;
            // 
            // cboProd
            // 
            this.cboProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProd.FormattingEnabled = true;
            this.cboProd.Location = new System.Drawing.Point(6, 84);
            this.cboProd.Name = "cboProd";
            this.cboProd.Size = new System.Drawing.Size(121, 23);
            this.cboProd.TabIndex = 2;
            // 
            // btoPesq
            // 
            this.btoPesq.Location = new System.Drawing.Point(58, 35);
            this.btoPesq.Name = "btoPesq";
            this.btoPesq.Size = new System.Drawing.Size(25, 23);
            this.btoPesq.TabIndex = 0;
            this.btoPesq.Text = "...";
            this.btoPesq.UseVisualStyleBackColor = true;
            this.btoPesq.Click += new System.EventHandler(this.btoPesq_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 23);
            this.txtID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 133);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(6, 37);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(445, 78);
            this.txtObs.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Observação";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Controls.Add(this.btoLimp);
            this.groupBox3.Controls.Add(this.btoDel);
            this.groupBox3.Controls.Add(this.btoAlt);
            this.groupBox3.Controls.Add(this.btoCad);
            this.groupBox3.Location = new System.Drawing.Point(12, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 44);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(376, 14);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(75, 23);
            this.btoSair.TabIndex = 0;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoLimp
            // 
            this.btoLimp.Location = new System.Drawing.Point(295, 14);
            this.btoLimp.Name = "btoLimp";
            this.btoLimp.Size = new System.Drawing.Size(75, 23);
            this.btoLimp.TabIndex = 0;
            this.btoLimp.Text = "Limpar";
            this.btoLimp.UseVisualStyleBackColor = true;
            this.btoLimp.Click += new System.EventHandler(this.btoLimp_Click);
            // 
            // btoDel
            // 
            this.btoDel.Location = new System.Drawing.Point(214, 14);
            this.btoDel.Name = "btoDel";
            this.btoDel.Size = new System.Drawing.Size(75, 23);
            this.btoDel.TabIndex = 0;
            this.btoDel.Text = "Excluir";
            this.btoDel.UseVisualStyleBackColor = true;
            this.btoDel.Click += new System.EventHandler(this.btoDel_Click);
            // 
            // btoAlt
            // 
            this.btoAlt.Location = new System.Drawing.Point(133, 14);
            this.btoAlt.Name = "btoAlt";
            this.btoAlt.Size = new System.Drawing.Size(75, 23);
            this.btoAlt.TabIndex = 0;
            this.btoAlt.Text = "Alterar";
            this.btoAlt.UseVisualStyleBackColor = true;
            this.btoAlt.Click += new System.EventHandler(this.btoAlt_Click);
            // 
            // btoCad
            // 
            this.btoCad.Location = new System.Drawing.Point(52, 14);
            this.btoCad.Name = "btoCad";
            this.btoCad.Size = new System.Drawing.Size(75, 23);
            this.btoCad.TabIndex = 0;
            this.btoCad.Text = "Cadastrar";
            this.btoCad.UseVisualStyleBackColor = true;
            this.btoCad.Click += new System.EventHandler(this.btoCad_Click);
            // 
            // frmOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 299);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOS";
            this.Load += new System.EventHandler(this.frmOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboQntde)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private GroupBox groupBox3;
        private ComboBox cboStat;
        private ComboBox cboProd;
        private TextBox txtObs;
        private Button btoSair;
        private Button btoLimp;
        private Button btoDel;
        private Button btoAlt;
        private Button btoCad;
        private MaskedTextBox mtxtDat;
        private Button btoPesq;
        private NumericUpDown cboQntde;
        private ComboBox cboIDprod;
    }
}
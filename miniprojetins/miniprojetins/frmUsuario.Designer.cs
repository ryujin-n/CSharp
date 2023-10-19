namespace miniprojetins
{
    partial class frmUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.btoPesq = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboStat = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSen = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimp = new System.Windows.Forms.Button();
            this.btoRem = new System.Windows.Forms.Button();
            this.btoAlt = new System.Windows.Forms.Button();
            this.btoCad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtData);
            this.groupBox1.Controls.Add(this.btoPesq);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // mtxtData
            // 
            this.mtxtData.Location = new System.Drawing.Point(423, 43);
            this.mtxtData.Mask = "##/##/####";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.ReadOnly = true;
            this.mtxtData.Size = new System.Drawing.Size(74, 23);
            this.mtxtData.TabIndex = 3;
            // 
            // btoPesq
            // 
            this.btoPesq.Location = new System.Drawing.Point(71, 43);
            this.btoPesq.Name = "btoPesq";
            this.btoPesq.Size = new System.Drawing.Size(32, 23);
            this.btoPesq.TabIndex = 1;
            this.btoPesq.Text = "...";
            this.btoPesq.UseVisualStyleBackColor = true;
            this.btoPesq.Click += new System.EventHandler(this.btoPesq_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(19, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 23);
            this.txtID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboStat);
            this.groupBox2.Controls.Add(this.Status);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSen);
            this.groupBox2.Controls.Add(this.txtLog);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.txtNom);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 272);
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
            this.cboStat.Location = new System.Drawing.Point(370, 91);
            this.cboStat.Name = "cboStat";
            this.cboStat.Size = new System.Drawing.Size(121, 23);
            this.cboStat.TabIndex = 3;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(370, 73);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(39, 15);
            this.Status.TabIndex = 0;
            this.Status.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Observação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome";
            // 
            // txtSen
            // 
            this.txtSen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSen.Location = new System.Drawing.Point(140, 91);
            this.txtSen.Name = "txtSen";
            this.txtSen.PasswordChar = '*';
            this.txtSen.Size = new System.Drawing.Size(224, 23);
            this.txtSen.TabIndex = 2;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(19, 91);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(115, 23);
            this.txtLog.TabIndex = 1;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(19, 135);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(472, 120);
            this.txtObs.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(19, 47);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(472, 23);
            this.txtNom.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Controls.Add(this.btoLimp);
            this.groupBox3.Controls.Add(this.btoRem);
            this.groupBox3.Controls.Add(this.btoAlt);
            this.groupBox3.Controls.Add(this.btoCad);
            this.groupBox3.Location = new System.Drawing.Point(12, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 37);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(416, 8);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(75, 23);
            this.btoSair.TabIndex = 4;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoLimp
            // 
            this.btoLimp.Location = new System.Drawing.Point(340, 8);
            this.btoLimp.Name = "btoLimp";
            this.btoLimp.Size = new System.Drawing.Size(75, 23);
            this.btoLimp.TabIndex = 3;
            this.btoLimp.Text = "Limpar";
            this.btoLimp.UseVisualStyleBackColor = true;
            this.btoLimp.Click += new System.EventHandler(this.btoLimp_Click);
            // 
            // btoRem
            // 
            this.btoRem.Location = new System.Drawing.Point(263, 8);
            this.btoRem.Name = "btoRem";
            this.btoRem.Size = new System.Drawing.Size(75, 23);
            this.btoRem.TabIndex = 2;
            this.btoRem.Text = "Remover";
            this.btoRem.UseVisualStyleBackColor = true;
            this.btoRem.Click += new System.EventHandler(this.btoRem_Click);
            // 
            // btoAlt
            // 
            this.btoAlt.Location = new System.Drawing.Point(187, 8);
            this.btoAlt.Name = "btoAlt";
            this.btoAlt.Size = new System.Drawing.Size(75, 23);
            this.btoAlt.TabIndex = 1;
            this.btoAlt.Text = "Alterar";
            this.btoAlt.UseVisualStyleBackColor = true;
            this.btoAlt.Click += new System.EventHandler(this.btoAlt_Click);
            // 
            // btoCad
            // 
            this.btoCad.Location = new System.Drawing.Point(111, 8);
            this.btoCad.Name = "btoCad";
            this.btoCad.Size = new System.Drawing.Size(75, 23);
            this.btoCad.TabIndex = 0;
            this.btoCad.Text = "Cadastrar";
            this.btoCad.UseVisualStyleBackColor = true;
            this.btoCad.Click += new System.EventHandler(this.btoCad_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 420);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmProjetin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox mtxtData;
        private Button btoPesq;
        private TextBox txtID;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox txtSen;
        private TextBox txtLog;
        private TextBox txtObs;
        private TextBox txtNom;
        private GroupBox groupBox3;
        private Button btoSair;
        private Button btoLimp;
        private Button btoRem;
        private Button btoAlt;
        private Button btoCad;
        private ComboBox cboStat;
        private Label Status;
    }
}
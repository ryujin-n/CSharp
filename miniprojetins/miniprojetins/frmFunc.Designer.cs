namespace miniprojetins
{
    partial class frmFunc
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
            this.btoPesq = new System.Windows.Forms.Button();
            this.cboStat = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDNas = new System.Windows.Forms.MaskedTextBox();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtBai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mtxtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimp = new System.Windows.Forms.Button();
            this.btoRem = new System.Windows.Forms.Button();
            this.btoAlt = new System.Windows.Forms.Button();
            this.btoCad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btoPesq);
            this.groupBox1.Controls.Add(this.cboStat);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.mtxtCPF);
            this.groupBox1.Controls.Add(this.mtxtDNas);
            this.groupBox1.Controls.Add(this.mtxtData);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btoPesq
            // 
            this.btoPesq.Location = new System.Drawing.Point(58, 36);
            this.btoPesq.Name = "btoPesq";
            this.btoPesq.Size = new System.Drawing.Size(29, 23);
            this.btoPesq.TabIndex = 1;
            this.btoPesq.Text = "...";
            this.btoPesq.UseVisualStyleBackColor = true;
            this.btoPesq.Click += new System.EventHandler(this.btoPesq_Click);
            // 
            // cboStat
            // 
            this.cboStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStat.FormattingEnabled = true;
            this.cboStat.Location = new System.Drawing.Point(326, 92);
            this.cboStat.Name = "cboStat";
            this.cboStat.Size = new System.Drawing.Size(121, 23);
            this.cboStat.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(325, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Status";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(245, 92);
            this.mtxtCPF.Mask = "###.###.###-##";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(77, 23);
            this.mtxtCPF.TabIndex = 4;
            // 
            // mtxtDNas
            // 
            this.mtxtDNas.Location = new System.Drawing.Point(6, 145);
            this.mtxtDNas.Mask = "##/##/####";
            this.mtxtDNas.Name = "mtxtDNas";
            this.mtxtDNas.Size = new System.Drawing.Size(70, 23);
            this.mtxtDNas.TabIndex = 6;
            // 
            // mtxtData
            // 
            this.mtxtData.Location = new System.Drawing.Point(395, 20);
            this.mtxtData.Mask = "##/##/####";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.ReadOnly = true;
            this.mtxtData.Size = new System.Drawing.Size(70, 23);
            this.mtxtData.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(6, 92);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(233, 23);
            this.txtNom.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 23);
            this.txtID.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "CPF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboUF);
            this.groupBox2.Controls.Add(this.mtxtCep);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNum);
            this.groupBox2.Controls.Add(this.txtComp);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCid);
            this.groupBox2.Controls.Add(this.txtBai);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtEnd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(11, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 161);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cboUF
            // 
            this.cboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.cboUF.Location = new System.Drawing.Point(152, 122);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(61, 23);
            this.cboUF.TabIndex = 7;
            // 
            // mtxtCep
            // 
            this.mtxtCep.Location = new System.Drawing.Point(6, 78);
            this.mtxtCep.Mask = "#####-###";
            this.mtxtCep.Name = "mtxtCep";
            this.mtxtCep.Size = new System.Drawing.Size(77, 23);
            this.mtxtCep.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Endereço";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(243, 34);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(51, 23);
            this.txtNum.TabIndex = 3;
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(227, 78);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(139, 23);
            this.txtComp.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "UF";
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(6, 122);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(139, 23);
            this.txtCid.TabIndex = 6;
            // 
            // txtBai
            // 
            this.txtBai.Location = new System.Drawing.Point(85, 78);
            this.txtBai.Name = "txtBai";
            this.txtBai.Size = new System.Drawing.Size(139, 23);
            this.txtBai.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cidade";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(6, 34);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(233, 23);
            this.txtEnd.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Complemento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cep";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.mtxtTel2);
            this.groupBox3.Controls.Add(this.mtxtTel);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtObs);
            this.groupBox3.Location = new System.Drawing.Point(12, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 163);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Observação";
            // 
            // mtxtTel2
            // 
            this.mtxtTel2.Location = new System.Drawing.Point(110, 37);
            this.mtxtTel2.Mask = "(##) #####-####";
            this.mtxtTel2.Name = "mtxtTel2";
            this.mtxtTel2.Size = new System.Drawing.Size(102, 23);
            this.mtxtTel2.TabIndex = 2;
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(11, 37);
            this.mtxtTel.Mask = "(##) #####-####";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(93, 23);
            this.mtxtTel.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Telefone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(108, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Telefone Adicional";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(11, 92);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(454, 62);
            this.txtObs.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btoSair);
            this.groupBox4.Controls.Add(this.btoLimp);
            this.groupBox4.Controls.Add(this.btoRem);
            this.groupBox4.Controls.Add(this.btoAlt);
            this.groupBox4.Controls.Add(this.btoCad);
            this.groupBox4.Location = new System.Drawing.Point(12, 491);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(481, 40);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(398, 11);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(75, 23);
            this.btoSair.TabIndex = 5;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoLimp
            // 
            this.btoLimp.Location = new System.Drawing.Point(322, 11);
            this.btoLimp.Name = "btoLimp";
            this.btoLimp.Size = new System.Drawing.Size(75, 23);
            this.btoLimp.TabIndex = 4;
            this.btoLimp.Text = "Limpar";
            this.btoLimp.UseVisualStyleBackColor = true;
            this.btoLimp.Click += new System.EventHandler(this.btoLimp_Click);
            // 
            // btoRem
            // 
            this.btoRem.Location = new System.Drawing.Point(246, 11);
            this.btoRem.Name = "btoRem";
            this.btoRem.Size = new System.Drawing.Size(75, 23);
            this.btoRem.TabIndex = 3;
            this.btoRem.Text = "Remover";
            this.btoRem.UseVisualStyleBackColor = true;
            this.btoRem.Click += new System.EventHandler(this.btoRem_Click);
            // 
            // btoAlt
            // 
            this.btoAlt.Location = new System.Drawing.Point(171, 11);
            this.btoAlt.Name = "btoAlt";
            this.btoAlt.Size = new System.Drawing.Size(75, 23);
            this.btoAlt.TabIndex = 2;
            this.btoAlt.Text = "Alterar";
            this.btoAlt.UseVisualStyleBackColor = true;
            this.btoAlt.Click += new System.EventHandler(this.btoAlt_Click);
            // 
            // btoCad
            // 
            this.btoCad.Location = new System.Drawing.Point(96, 11);
            this.btoCad.Name = "btoCad";
            this.btoCad.Size = new System.Drawing.Size(75, 23);
            this.btoCad.TabIndex = 1;
            this.btoCad.Text = "Cadastrar";
            this.btoCad.UseVisualStyleBackColor = true;
            this.btoCad.Click += new System.EventHandler(this.btoCad_Click);
            // 
            // frmFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 542);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.frmFunc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private MaskedTextBox mtxtCPF;
        private MaskedTextBox mtxtDNas;
        private MaskedTextBox mtxtData;
        private TextBox txtNom;
        private TextBox txtID;
        private Label label15;
        private MaskedTextBox mtxtCep;
        private TextBox txtNum;
        private TextBox txtEnd;
        private TextBox txtComp;
        private TextBox txtCid;
        private TextBox txtBai;
        private ComboBox cboStat;
        private MaskedTextBox mtxtTel2;
        private MaskedTextBox mtxtTel;
        private TextBox txtObs;
        private Button btoPesq;
        private GroupBox groupBox4;
        private Button btoSair;
        private Button btoLimp;
        private Button btoRem;
        private Button btoAlt;
        private Button btoCad;
        private ComboBox cboUF;
    }
}
namespace miniprojetins
{
    partial class frmMov
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
            this.mtxtDat = new System.Windows.Forms.MaskedTextBox();
            this.cboFunc = new System.Windows.Forms.ComboBox();
            this.cboProd = new System.Windows.Forms.ComboBox();
            this.cboTipM = new System.Windows.Forms.ComboBox();
            this.cboQntde = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btoPesq = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btoLimp = new System.Windows.Forms.Button();
            this.btoDel = new System.Windows.Forms.Button();
            this.cboStat = new System.Windows.Forms.ComboBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoAlt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btoCad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboQntde)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtDat);
            this.groupBox1.Controls.Add(this.cboFunc);
            this.groupBox1.Controls.Add(this.cboProd);
            this.groupBox1.Controls.Add(this.cboTipM);
            this.groupBox1.Controls.Add(this.cboQntde);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btoPesq);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // mtxtDat
            // 
            this.mtxtDat.Location = new System.Drawing.Point(309, 22);
            this.mtxtDat.Mask = "##/##/####";
            this.mtxtDat.Name = "mtxtDat";
            this.mtxtDat.ReadOnly = true;
            this.mtxtDat.Size = new System.Drawing.Size(67, 23);
            this.mtxtDat.TabIndex = 12;
            // 
            // cboFunc
            // 
            this.cboFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunc.FormattingEnabled = true;
            this.cboFunc.Location = new System.Drawing.Point(6, 130);
            this.cboFunc.Name = "cboFunc";
            this.cboFunc.Size = new System.Drawing.Size(121, 23);
            this.cboFunc.TabIndex = 4;
            // 
            // cboProd
            // 
            this.cboProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProd.FormattingEnabled = true;
            this.cboProd.Location = new System.Drawing.Point(6, 85);
            this.cboProd.Name = "cboProd";
            this.cboProd.Size = new System.Drawing.Size(121, 23);
            this.cboProd.TabIndex = 4;
            // 
            // cboTipM
            // 
            this.cboTipM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipM.FormattingEnabled = true;
            this.cboTipM.Items.AddRange(new object[] {
            "ENTRADA",
            "SAÍDA"});
            this.cboTipM.Location = new System.Drawing.Point(141, 130);
            this.cboTipM.Name = "cboTipM";
            this.cboTipM.Size = new System.Drawing.Size(121, 23);
            this.cboTipM.TabIndex = 4;
            // 
            // cboQntde
            // 
            this.cboQntde.Location = new System.Drawing.Point(141, 86);
            this.cboQntde.Name = "cboQntde";
            this.cboQntde.Size = new System.Drawing.Size(69, 23);
            this.cboQntde.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo de Movimentação";
            // 
            // btoPesq
            // 
            this.btoPesq.Location = new System.Drawing.Point(58, 37);
            this.btoPesq.Name = "btoPesq";
            this.btoPesq.Size = new System.Drawing.Size(27, 23);
            this.btoPesq.TabIndex = 0;
            this.btoPesq.Text = "...";
            this.btoPesq.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantidade";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 23);
            this.txtID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
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
            this.groupBox2.Controls.Add(this.btoLimp);
            this.groupBox2.Controls.Add(this.btoDel);
            this.groupBox2.Controls.Add(this.cboStat);
            this.groupBox2.Controls.Add(this.btoSair);
            this.groupBox2.Controls.Add(this.btoAlt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btoCad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 178);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btoLimp
            // 
            this.btoLimp.Location = new System.Drawing.Point(294, 105);
            this.btoLimp.Name = "btoLimp";
            this.btoLimp.Size = new System.Drawing.Size(75, 23);
            this.btoLimp.TabIndex = 0;
            this.btoLimp.Text = "Limpar";
            this.btoLimp.UseVisualStyleBackColor = true;
            // 
            // btoDel
            // 
            this.btoDel.Location = new System.Drawing.Point(216, 105);
            this.btoDel.Name = "btoDel";
            this.btoDel.Size = new System.Drawing.Size(75, 23);
            this.btoDel.TabIndex = 0;
            this.btoDel.Text = "Excluir";
            this.btoDel.UseVisualStyleBackColor = true;
            // 
            // cboStat
            // 
            this.cboStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStat.FormattingEnabled = true;
            this.cboStat.Location = new System.Drawing.Point(216, 37);
            this.cboStat.Name = "cboStat";
            this.cboStat.Size = new System.Drawing.Size(121, 23);
            this.cboStat.TabIndex = 4;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(294, 149);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(75, 23);
            this.btoSair.TabIndex = 0;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            // 
            // btoAlt
            // 
            this.btoAlt.Location = new System.Drawing.Point(294, 76);
            this.btoAlt.Name = "btoAlt";
            this.btoAlt.Size = new System.Drawing.Size(75, 23);
            this.btoAlt.TabIndex = 0;
            this.btoAlt.Text = "Alterar";
            this.btoAlt.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status";
            // 
            // btoCad
            // 
            this.btoCad.Location = new System.Drawing.Point(216, 76);
            this.btoCad.Name = "btoCad";
            this.btoCad.Size = new System.Drawing.Size(75, 23);
            this.btoCad.TabIndex = 0;
            this.btoCad.Text = "Cadastrar";
            this.btoCad.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Observação";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(6, 37);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(204, 125);
            this.txtObs.TabIndex = 2;
            // 
            // frmMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 369);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMov";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboQntde)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboTipM;
        private NumericUpDown cboQntde;
        private Label label5;
        private Label label3;
        private TextBox txtID;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btoLimp;
        private Button btoDel;
        private ComboBox cboStat;
        private Button btoSair;
        private Button btoAlt;
        private Label label7;
        private Button btoCad;
        private Label label6;
        private TextBox txtObs;
        private MaskedTextBox mtxtDat;
        private Button btoPesq;
        private ComboBox cboFunc;
        private ComboBox cboProd;
    }
}
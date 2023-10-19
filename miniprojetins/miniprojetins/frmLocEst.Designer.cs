namespace miniprojetins
{
    partial class frmLocEst
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btoPesq = new System.Windows.Forms.Button();
            this.cboStat = new System.Windows.Forms.ComboBox();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimp = new System.Windows.Forms.Button();
            this.btoDel = new System.Windows.Forms.Button();
            this.btoAlt = new System.Windows.Forms.Button();
            this.btoCad = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(6, 37);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(444, 63);
            this.txtObs.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Observação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btoPesq);
            this.groupBox1.Controls.Add(this.cboStat);
            this.groupBox1.Controls.Add(this.mtxtData);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btoPesq
            // 
            this.btoPesq.Location = new System.Drawing.Point(58, 33);
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
            this.cboStat.Location = new System.Drawing.Point(170, 77);
            this.cboStat.Name = "cboStat";
            this.cboStat.Size = new System.Drawing.Size(121, 23);
            this.cboStat.TabIndex = 3;
            // 
            // mtxtData
            // 
            this.mtxtData.Location = new System.Drawing.Point(380, 22);
            this.mtxtData.Mask = "##/##/####";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.ReadOnly = true;
            this.mtxtData.Size = new System.Drawing.Size(70, 23);
            this.mtxtData.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 23);
            this.txtID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(6, 77);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(147, 23);
            this.txtNom.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Controls.Add(this.btoLimp);
            this.groupBox3.Controls.Add(this.btoDel);
            this.groupBox3.Controls.Add(this.btoAlt);
            this.groupBox3.Controls.Add(this.btoCad);
            this.groupBox3.Location = new System.Drawing.Point(12, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 34);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(392, 11);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(75, 23);
            this.btoSair.TabIndex = 4;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click_1);
            // 
            // btoLimp
            // 
            this.btoLimp.Location = new System.Drawing.Point(311, 11);
            this.btoLimp.Name = "btoLimp";
            this.btoLimp.Size = new System.Drawing.Size(75, 23);
            this.btoLimp.TabIndex = 3;
            this.btoLimp.Text = "Limpar";
            this.btoLimp.UseVisualStyleBackColor = true;
            this.btoLimp.Click += new System.EventHandler(this.btoLimp_Click_1);
            // 
            // btoDel
            // 
            this.btoDel.Location = new System.Drawing.Point(230, 11);
            this.btoDel.Name = "btoDel";
            this.btoDel.Size = new System.Drawing.Size(75, 23);
            this.btoDel.TabIndex = 2;
            this.btoDel.Text = "Excluir";
            this.btoDel.UseVisualStyleBackColor = true;
            this.btoDel.Click += new System.EventHandler(this.btoDel_Click);
            // 
            // btoAlt
            // 
            this.btoAlt.Location = new System.Drawing.Point(149, 11);
            this.btoAlt.Name = "btoAlt";
            this.btoAlt.Size = new System.Drawing.Size(75, 23);
            this.btoAlt.TabIndex = 1;
            this.btoAlt.Text = "Alterar";
            this.btoAlt.UseVisualStyleBackColor = true;
            this.btoAlt.Click += new System.EventHandler(this.btoAlt_Click);
            // 
            // btoCad
            // 
            this.btoCad.Location = new System.Drawing.Point(68, 11);
            this.btoCad.Name = "btoCad";
            this.btoCad.Size = new System.Drawing.Size(75, 23);
            this.btoCad.TabIndex = 0;
            this.btoCad.Text = "Cadastrar";
            this.btoCad.UseVisualStyleBackColor = true;
            this.btoCad.Click += new System.EventHandler(this.btoCad_Click);
            // 
            // frmLocEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 285);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLocEst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLocEst_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private TextBox txtObs;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtID;
        private Label label3;
        private TextBox txtNom;
        private Label label1;
        private MaskedTextBox mtxtData;
        private Label label4;
        private ComboBox cboStat;
        private Button btoPesq;
        private GroupBox groupBox3;
        private Button btoSair;
        private Button btoLimp;
        private Button btoDel;
        private Button btoAlt;
        private Button btoCad;
    }
}
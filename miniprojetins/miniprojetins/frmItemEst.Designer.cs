namespace miniprojetins
{
    partial class frmItemEst
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
            this.button1 = new System.Windows.Forms.Button();
            this.btoStat = new System.Windows.Forms.ComboBox();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            this.cboProd = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.mtxtDat = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoLimp = new System.Windows.Forms.Button();
            this.btoDel = new System.Windows.Forms.Button();
            this.btoAlt = new System.Windows.Forms.Button();
            this.btoCad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btoStat);
            this.groupBox1.Controls.Add(this.cboLoc);
            this.groupBox1.Controls.Add(this.cboProd);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.mtxtDat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btoStat
            // 
            this.btoStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btoStat.FormattingEnabled = true;
            this.btoStat.Location = new System.Drawing.Point(261, 84);
            this.btoStat.Name = "btoStat";
            this.btoStat.Size = new System.Drawing.Size(121, 23);
            this.btoStat.TabIndex = 15;
            // 
            // cboLoc
            // 
            this.cboLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Location = new System.Drawing.Point(133, 84);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(121, 23);
            this.cboLoc.TabIndex = 15;
            // 
            // cboProd
            // 
            this.cboProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProd.FormattingEnabled = true;
            this.cboProd.Location = new System.Drawing.Point(6, 84);
            this.cboProd.Name = "cboProd";
            this.cboProd.Size = new System.Drawing.Size(121, 23);
            this.cboProd.TabIndex = 15;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 23);
            this.txtID.TabIndex = 14;
            // 
            // mtxtDat
            // 
            this.mtxtDat.Location = new System.Drawing.Point(386, 22);
            this.mtxtDat.Mask = "##/##/####";
            this.mtxtDat.Name = "mtxtDat";
            this.mtxtDat.ReadOnly = true;
            this.mtxtDat.Size = new System.Drawing.Size(67, 23);
            this.mtxtDat.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Local de Estoque";
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
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 143);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Observação";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(6, 37);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(445, 92);
            this.txtObs.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Controls.Add(this.btoLimp);
            this.groupBox3.Controls.Add(this.btoDel);
            this.groupBox3.Controls.Add(this.btoAlt);
            this.groupBox3.Controls.Add(this.btoCad);
            this.groupBox3.Location = new System.Drawing.Point(12, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 46);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(376, 17);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(75, 23);
            this.btoSair.TabIndex = 0;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            // 
            // btoLimp
            // 
            this.btoLimp.Location = new System.Drawing.Point(295, 17);
            this.btoLimp.Name = "btoLimp";
            this.btoLimp.Size = new System.Drawing.Size(75, 23);
            this.btoLimp.TabIndex = 0;
            this.btoLimp.Text = "Limpar";
            this.btoLimp.UseVisualStyleBackColor = true;
            // 
            // btoDel
            // 
            this.btoDel.Location = new System.Drawing.Point(214, 17);
            this.btoDel.Name = "btoDel";
            this.btoDel.Size = new System.Drawing.Size(75, 23);
            this.btoDel.TabIndex = 0;
            this.btoDel.Text = "Excluir";
            this.btoDel.UseVisualStyleBackColor = true;
            // 
            // btoAlt
            // 
            this.btoAlt.Location = new System.Drawing.Point(133, 17);
            this.btoAlt.Name = "btoAlt";
            this.btoAlt.Size = new System.Drawing.Size(75, 23);
            this.btoAlt.TabIndex = 0;
            this.btoAlt.Text = "Alterar";
            this.btoAlt.UseVisualStyleBackColor = true;
            // 
            // btoCad
            // 
            this.btoCad.Location = new System.Drawing.Point(52, 17);
            this.btoCad.Name = "btoCad";
            this.btoCad.Size = new System.Drawing.Size(75, 23);
            this.btoCad.TabIndex = 0;
            this.btoCad.Text = "Cadastrar";
            this.btoCad.UseVisualStyleBackColor = true;
            // 
            // frmItemEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 342);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItemEst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmItemEst";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private GroupBox groupBox3;
        private MaskedTextBox mtxtDat;
        private TextBox txtID;
        private TextBox txtObs;
        private Button button1;
        private ComboBox btoStat;
        private ComboBox cboLoc;
        private ComboBox cboProd;
        private Button btoSair;
        private Button btoLimp;
        private Button btoDel;
        private Button btoAlt;
        private Button btoCad;
    }
}
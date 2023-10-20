using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniprojetins
{
    public partial class MDIPrinc : Form
    {
        private int childFormNumber = 0;

        public static string stringConexao = "Data Source=localhost;Initial Catalog=t14_miniprojeto;User ID=sa;Password=123456";
        public static string idUser;
        public static string LoginUser;
        public static string NomeUser;


        public MDIPrinc()
        {
            InitializeComponent();
        }

        private void MDIPrinc_Load(object sender, EventArgs e)
        {
 
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            lblStat.Text = frmLogin.NomeUser;

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProd frm = new frmProd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFunc frm = new frmFunc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForn frm = new frmForn();
            frm.MdiParent = this;
            frm.Show();
        }

        private void localEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocEst frm = new frmLocEst();
            frm.MdiParent= this;
            frm.Show();
        }




 
    }
}

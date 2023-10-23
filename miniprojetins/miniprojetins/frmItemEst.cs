using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniprojetins
{
    public partial class frmItemEst : Form
    {
        public frmItemEst()
        {
            InitializeComponent();
        }
        string stringConexao = MDIPrinc.stringConexao;

        private void TestarConexao()
        {
            SqlConnection conexao = new SqlConnection(stringConexao);

            try
            {
                conexao.Open();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }

        private void CarregarCbo()
        {

            string sql = "select id_produto, nome_produto from prod";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;

            DataTable dt = new DataTable();
            conn.Open();

            try
            {

                reader = cmd.ExecuteReader();
                dt.Load(reader);

                cboIDprod.DisplayMember = "id_produto";
                cboIDprod.DataSource = dt;

                cboProd.DisplayMember = "nome_produto";
                cboProd.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }
    }
}

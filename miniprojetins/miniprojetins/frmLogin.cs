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
    public partial class frmLogin : Form
    {
        string stringConexao = MDIPrinc.stringConexao;
        public static string idUser;
        public static string LoginUser;
        public static string NomeUser;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario where " +
                "login_usuario = '" + txtLog.Text + "' and " +
                "senha_usuario = '" + txtSen.Text + "'";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MDIPrinc.idUser = reader[0].ToString();
                    MDIPrinc.NomeUser = reader[1].ToString();
                    MDIPrinc.LoginUser = reader[2].ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nome ou Senha incorretos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

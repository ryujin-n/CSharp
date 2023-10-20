using System.Data.SqlClient;
using System.Data;

namespace miniprojetins
{
    public partial class frmUsuario : Form
    {
        string stringConexao = MDIPrinc.stringConexao;
        private void testcon()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }
        }
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmProjetin_Load(object sender, EventArgs e)
        {
            testcon();
        }

        private void btoLimp_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtLog.Text = "";
            mtxtData.Text = "";
            txtNom.Text = "";
            txtSen.Text = "";
            txtObs.Text = "";
            cboStat.SelectedIndex = -1;
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btoCad_Click(object sender, EventArgs e)
        {
            string sql = "set dateformat dmy insert into usuario (nome_usuario,login_usuario,senha_usuario,obs_usuario)" +
                "values" +
                    "(" + "'" + txtNom.Text + "'" + "," + "'" + txtLog.Text + "'" + "," + "'" +
                    txtSen.Text + "'" + "," + "'" + txtObs.Text + "'" + ")" + "select scope_identity()";
            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                //int i = cmd.ExecuteNonQuery();

                if (txtLog.Text == "")
                {
                    MessageBox.Show("nuh-uh");
                    txtLog.Focus();
                    return;
                }
                else if (txtSen.Text == "")
                {
                    MessageBox.Show("podih nao");
                    txtSen.Focus();
                    return;
                }
                else if (txtNom.Text == "")
                {
                    MessageBox.Show("nao podih");
                    txtNom.Focus();
                    return;
                }

                //else if (i == 1)
                //{
                //    MessageBox.Show("Cadastro realizado com sucesso");
                //}

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    btoLimp.PerformClick();

                    txtID.Text = reader[0].ToString();
                    MessageBox.Show("Cadastro realizado");

                    btoPesq.PerformClick();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btoAlt_Click(object sender, EventArgs e)
        {
            string sql = "update usuario set " +
                "nome_usuario ='" + txtNom.Text + "'" + "," +
                "login_usuario ='" + txtLog.Text + "'" + "," +
                "senha_usuario ='" + txtSen.Text + "'" + "," +
                "obs_usuario ='" + txtObs.Text + "'" + "," +
                "status_usuario ='" + cboStat.Text + "'" +
                "where id_usuario =" + txtID.Text;
            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (txtLog.Text == "" & txtNom.Text == "" & txtSen.Text == "")
                {
                    MessageBox.Show("Dados precisam ser cadastrados");
                }
                else if (i > 0)
                {
                    MessageBox.Show("Alteração realizada com sucesso");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro: Não foi possível alterar o dado");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btoRem_Click(object sender, EventArgs e)
        {
            string sql = "delete from usuario where id_usuario=" + txtID.Text;
            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
               
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados Excluidos com sucesso");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btoPesq_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario where id_usuario=" + txtID.Text;

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
                    txtID.Text = reader[0].ToString();
                    txtNom.Text = reader[1].ToString();
                    txtLog.Text = reader[2].ToString();
                    txtSen.Text = reader[3].ToString();
                    mtxtData.Text = reader[4].ToString();
                    txtObs.Text = reader[5].ToString();
                    cboStat.Text = reader[6].ToString();
                }
                else
                {
                    MessageBox.Show("Código não encontrado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally 
            {
                conn.Close();
            }
        }
    }
}
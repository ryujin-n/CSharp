using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace miniprojetins
{
    public partial class frmProd : Form
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
        public frmProd()
        {
            InitializeComponent();
        }

        private void frmProd_Load(object sender, EventArgs e)
        {
            testcon();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLim_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtObs.Text = "";
            txtProd.Text = "";
            txtVa.Text = "";
            txtVu.Text = "";
            mtxtDat.Text = "";
            cboQtde.Text = "";
            cboStat.SelectedIndex = -1 ;
        }

        private void btoCad_Click(object sender, EventArgs e)
        {

            string va = txtVa.Text;
            va = va.Replace("R$ ", "");
            va = va.Replace(",", ".");

            string vu = txtVu.Text;
            vu = vu.Replace("R$ ", "");
            vu = vu.Replace(",", ".");

            string sql = "set dateformat dmy insert into prod (nome_produto,qtde_produto,Vcusto_produto,Vvenda_produto,obs_produto)" +
             "values" +
                 "(" + "'" + txtProd.Text + "'" + "," + "'" + cboQtde.Value + "'" + "," + vu + "," +
                  va + "," + "'" + txtObs.Text + "'" + ")" + "select SCOPE_IDENTITY()";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {

                if (txtProd.Text == "")
                {
                    MessageBox.Show("nuh-uhh");
                    txtProd.Focus();
                    return;
                }
                else if (txtVu.Text == "")
                {
                    MessageBox.Show("nop");
                    txtVu.Focus();
                    return;
                }
                else if (txtVa.Text == "")
                {
                    MessageBox.Show("ehh...no");
                    txtVa.Focus();
                    return;
                }
                else if (cboQtde.Value < 0)
                {
                    MessageBox.Show("Blehh");
                    cboQtde.Focus();
                    return;
                }
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
                MessageBox.Show("sua mae :p: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btoAlt_Click(object sender, EventArgs e)
        {
            btoPesq.PerformClick();
            string sql = "update prod set" +

                    "nome_produto ='" + txtProd.Text + "'" + "," +
                    "qtde_produto ='" + cboQtde.Value + "'" + "," +
                    "Vcusto_produto ='" + txtVu.Text + "'" + "," +
                    "Vvenda_produto ='" + txtVa.Text + "'" + "," +
                    "obs_produto ='" + txtObs.Text + "'" +
                    "where id_produto =" + txtID.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (txtProd.Text == "" & txtVa.Text == "" & txtVu.Text == "" & cboQtde.Value < 0)
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
            string sql = "delete from prod where id_produto=" + txtID.Text;
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
            string sql = "select * from prod where id_produto=" + txtID.Text;

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
                    txtProd.Text = reader[1].ToString();
                    mtxtDat.Text = reader[2].ToString();
                    cboQtde.Value = Convert.ToDecimal(reader[3].ToString());
                    txtVu.Text = (decimal.Parse(reader[4].ToString())).ToString("C");
                    txtVa.Text = (decimal.Parse(reader[5].ToString())).ToString("C");
                    txtObs.Text = reader[6].ToString();
                    cboStat.Text = reader[7].ToString();
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

        private void txtVu_Enter(object sender, EventArgs e)
        {
            txtVu.Text = txtVu.Text.Replace("R$ ", "");
        }

        private void txtVa_Enter(object sender, EventArgs e)
        {
            txtVa.Text = txtVa.Text.Replace("R$ ", "");
        }

        private void txtVu_Leave(object sender, EventArgs e)
        {
            float valor;

            if (float.TryParse(txtVu.Text, out valor))
            {
                txtVu.Text = valor.ToString("C");
            }
            else
            {
                txtVu.Text = "";
            }
        }

        private void txtVa_Leave(object sender, EventArgs e)
        {
            float valor;

            if (float.TryParse(txtVa.Text, out valor))
            {
                txtVa.Text = valor.ToString("C");
            }
            else
            {
                txtVa.Text = "";
            }
        }
    }
}

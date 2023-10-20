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
    public partial class frmLocEst : Form
    {

        string stringConexao = MDIPrinc.stringConexao;
        public frmLocEst()
        {
            InitializeComponent();
        }

        private void btoPesq_Click(object sender, EventArgs e)
        {
            string sql = "select * from locest where id_LocalEstoque=" + txtID.Text;

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
                    mtxtData.Text = reader[2].ToString();
                    txtObs.Text = reader[3].ToString();
                    cboStat.Text = reader[4].ToString();
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

        private void frmLocEst_Load(object sender, EventArgs e)
        {

        }

        private void btoSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimp_Click_1(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNom.Text = "";
            txtObs.Text = "";
            mtxtData.Text = "";

            cboStat.SelectedIndex = -1;
        }

        private void btoDel_Click(object sender, EventArgs e)
        {
            string sql = "delete from locest where id_LocalEstoque=" + txtID.Text;
            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados Excluidos com sucesso");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro: no");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btoAlt_Click(object sender, EventArgs e)
        {
            string sql = "update locest set " +
                "nome_LocalEstoque='" + txtNom.Text + "'" + "," +
                "obs_LocalEstoque='" + txtObs.Text + "'" + "," +
                "status_LocalEstoque='" + cboStat.Text + "'" +

                "where id_LocalEstoque =" + txtID.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Alteração realizada com sucesso");
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

        private void btoCad_Click(object sender, EventArgs e)
        {
            string sql = "set dateformat dmy insert into locest (nome_LocalEstoque,obs_LocalEstoque) " +
                "values " +
                        "(" + "'" + txtNom.Text + "'" + "," + "'" + txtObs.Text + "'" + ")" 
                        + "select SCOPE_IDENTITY()";

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
    }
}

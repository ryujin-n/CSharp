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
            finally
            {
                conexao.Close();
            }
        }

        private void CarregarCbo1()
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
            finally
            {
                conn.Close();
            }
        }
        private void CarregarCbo2()
        {

            string sql = "select id_LocalEStoque, nome_LocalEstoque from locest";

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

                cboIDloc.DisplayMember = "id_LocalEstoque";
                cboIDloc.DataSource = dt;

                cboLoc.DisplayMember = "nome_LocalEstoque";
                cboLoc.DataSource = dt;


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

        private void frmItemEst_Load(object sender, EventArgs e)
        {
            CarregarCbo1();
            CarregarCbo2();

            cboLoc.SelectedIndex = -1;
            cboProd.SelectedIndex = -1;
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btoLimp_Click(object sender, EventArgs e)
        {
            cboLoc.SelectedIndex = -1;
            cboIDloc.SelectedIndex = -1;
            cboIDprod.SelectedIndex = -1;
            cboProd.SelectedIndex = -1;
            cboStat.SelectedIndex = -1;

            txtID.Text = "";
            txtObs.Text = "";
            mtxtDat.Text = "";
        }

        private void btoCad_Click(object sender, EventArgs e)
        {
            string sql = "set dateformat dmy insert into itemest (id_produto_ItemEstoque,id_localEstoque_ItemEstoque,obs_ItemEstoque)" +
                    "values" +
                        "(" + cboIDprod.Text + "," + cboIDloc.Text + "," + "'" + txtObs.Text + "'" + ")" + "select SCOPE_IDENTITY()";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                if (cboProd.SelectedIndex == -1 || cboLoc.SelectedIndex == -1)
                {
                    MessageBox.Show("no");
                    return;
                }
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    btoLimp.PerformClick();

                    txtID.Text = reader[0].ToString();
                    MessageBox.Show("Cadastro Concluído");

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
        private void btoDel_Click(object sender, EventArgs e)
        {
            string sql = "delete from itemest where id_ItemEStoque=" + txtID.Text;

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

        private void btoAlt_Click(object sender, EventArgs e)
        {
            btoPesq.PerformClick();
            string sql = "update itemest set " +

                "id_produto_ItemEstoque=" + cboIDprod.Text + "," +
                "id_localEstoque_ItemEstoque=" + cboIDloc.Text + "," +
                "obs_ItemEstoque='" + txtObs.Text + "'" + "," +
                "status_ItemEstoque='" + cboStat.Text + "'" +
                "where id_ItemEstoque =" + txtID.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (cboProd.SelectedIndex == -1 & cboLoc.SelectedIndex == -1)
                {
                    MessageBox.Show("Dados precisam ser cadastrados");
                }
                else if (i > 0)
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

        private void btoPesq_Click(object sender, EventArgs e)
        {
            string sql = "select * from itemest where id_ItemEstoque=" + txtID.Text;

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
                    cboIDprod.Text = reader[1].ToString();
                    cboIDloc.Text = reader[2].ToString();
                    mtxtDat.Text = reader[3].ToString();
                    txtObs.Text = reader[4].ToString();
                    cboStat.Text = reader[5].ToString();

                    cboProd.SelectedIndex = cboIDprod.SelectedIndex;
                    cboLoc.SelectedIndex = cboIDloc.SelectedIndex;
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

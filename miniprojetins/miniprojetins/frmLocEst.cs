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
            btoPesq.PerformClick();
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

        private void CarregarDataGrid()
        {
            string sql = "select itemest.id_ItemEstoque as 'ID', prod.nome_produto as 'Produto',locest.nome_LocalEstoque as 'Local Estoque',obs_ItemEstoque as 'Observação' " +
                            "from itemest " +
                            "inner join prod " +
                            "on itemest.id_produto_ItemEstoque = prod.id_produto " +
                            "inner join locest " +
                            "on itemest.id_localEstoque_ItemEstoque = locest.id_LocalEstoque";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();

            conn.Open();

            try
            {
                ad.Fill(ds);

                dtLocest.DataSource = ds.Tables[0];
                dtLocest.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dtLocest.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
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

        private void txtdatagrid_TextChanged(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void dtLocest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtLocest.CurrentRow.Cells["ID"].Value.ToString();
            btoPesq.PerformClick();
        }
        private void frmLocEst_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }
    }
}

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
    public partial class frmOS : Form
    {
        public frmOS()
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
            finally
            {
                conn.Close();
            }
        }


        private void frmOS_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
            TestarConexao();
            CarregarCbo();

            cboProd.SelectedIndex = -1;
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimp_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtObs.Text = "";
            mtxtDat.Text = "";

            cboProd.SelectedIndex = -1;
            cboQntde.Value = 0;
            cboStat.SelectedIndex = -1;
        }

        private void btoCad_Click(object sender, EventArgs e)
        {
            string sql = "set dateformat dmy insert into os (id_produto_os,qtde_os,obs_os)" +
                    "values" +
                        "(" + cboIDprod.Text + "," + "'" + cboQntde.Value + "'" + "," + "'" + txtObs.Text + "'" + ")" + "select SCOPE_IDENTITY()";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {

                if (cboProd.SelectedIndex == -1 || cboQntde.Value == 0)
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

        private void btoAlt_Click(object sender, EventArgs e)
        {
            btoPesq.PerformClick();
            string sql = "update os set " +

                    "id_produto_os =" + cboIDprod.Text + "," +
                    "qtde_os ='" + cboQntde.Value + "'" + "," +
                    "obs_os ='" + txtObs.Text + "'" +
                    "where id_os =" + txtID.Text;


            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (cboProd.SelectedIndex == -1 & cboQntde.Value == 0)
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

        private void btoDel_Click(object sender, EventArgs e)
        {
            string sql = "delete from os where id_os=" + txtID.Text;

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
            string sql = "select * from os where id_os=" + txtID.Text;

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
                    mtxtDat.Text = reader[2].ToString();
                    cboQntde.Value = Convert.ToDecimal(reader[3].ToString());
                    txtObs.Text = reader[4].ToString();
                    cboStat.Text = reader[5].ToString();

                    cboProd.SelectedIndex = cboIDprod.SelectedIndex;
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
        private void CarregarDataGrid()
        {
            string sql = "select os.id_os as 'ID', prod.nome_produto as 'Produto',qtde_os as 'Quantidade',obs_os as 'Observação' " +
                            "from os " +
                            "inner join prod " +
                            "on os.id_produto_os = prod.id_produto ";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();

            conn.Open();

            try
            {
                ad.Fill(ds);

                dtOS.DataSource = ds.Tables[0];
                dtOS.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dtOS.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

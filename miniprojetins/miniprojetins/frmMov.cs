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
    public partial class frmMov : Form
    {
        public frmMov()
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

            string sql = "select id_funcionario, nome_funcionario from func";

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

                cboIDfunc.DisplayMember = "id_funcionario";
                cboIDfunc.DataSource = dt;

                cboFunc.DisplayMember = "nome_funcionario";
                cboFunc.DataSource = dt;


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

        private void frmMov_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
            CarregarCbo1();
            CarregarCbo2();

            cboProd.SelectedIndex = -1;
            cboFunc.SelectedIndex = -1;
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimp_Click(object sender, EventArgs e)
        {
            cboProd.SelectedIndex = -1;
            cboFunc.SelectedIndex = -1;
            cboIDprod.SelectedIndex = -1;
            cboIDfunc.SelectedIndex = -1;

            cboQntde.Value = 0;
            cboStat.SelectedIndex = -1;
            cboTipM.SelectedIndex = -1;

            txtID.Text = "";
            txtObs.Text = "";
            mtxtDat.Text = "";
        }

        private void btoCad_Click(object sender, EventArgs e)
        {
            string sql = "set dateformat dmy insert into mov (id_Produto_mov,id_funcionario_mov,qtde_mov,tipo_mov,obs_mov)" +
                   "values" +
                       "(" + cboIDprod.Text + "," + cboIDfunc.Text + "," + "'" + cboQntde.Value + "'" + "," + "'" + cboTipM.Text + "'" + "," + "'" + txtObs.Text + "'" + ")" + "select SCOPE_IDENTITY()";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {

                if (cboProd.SelectedIndex == -1 || cboFunc.SelectedIndex == -1 || cboTipM.SelectedIndex == -1 || cboQntde.Value == 0)
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
                    CarregarDataGrid();

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

            string sql = "update mov set " +

                    "id_Produto_mov=" + cboIDprod.Text + "," +
                    "id_funcionario_mov=" + cboIDfunc.Text + "," +
                    "qtde_mov='" + cboQntde.Value + "'" + "," +
                    "tipo_mov='" + cboTipM.Text + "'" + "," +
                    "obs_mov='" + txtObs.Text + "'" +

                    "where id_mov=" + txtID.Text;

            if (txtID.Text == "")
            {
                MessageBox.Show("Dados precisam ser cadastrados");
                return;
            }


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
                    CarregarDataGrid();
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
            string sql = "delete from mov where id_mov=" + txtID.Text;

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
                    CarregarDataGrid();
                    btoLimp.PerformClick();
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
        private void CarregarDataGrid()
        {
            string sql = "select mov.id_mov as 'ID', prod.nome_produto as 'Produto',func.nome_funcionario as 'Funcionário',qtde_mov as 'Quantidade',obs_mov as 'Observação' " +
                            "from mov " +
                            "inner join prod " +
                            "on mov.id_produto_mov = prod.id_produto " +
                            "inner " +
                            "join func " +
                            "on mov.id_funcionario_mov = func.id_funcionario";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();

            conn.Open();

            try
            {
                ad.Fill(ds);

                dtMov.DataSource = ds.Tables[0];
                dtMov.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dtMov.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
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

        private void dtMov_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtMov.CurrentRow.Cells["ID"].Value.ToString();
            btoPesq.PerformClick();
        }

        private void txtdatagrid_TextChanged(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void btoPesq_Click(object sender, EventArgs e)
        {
            string sql = "select * from mov where id_mov=" + txtID.Text;

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
                    cboProd.Text = reader[1].ToString();
                    cboFunc.Text = reader[2].ToString();
                    cboQntde.Text = reader[3].ToString();
                    mtxtDat.Text = reader[4].ToString();
                    cboTipM.Text = reader[5].ToString();
                    txtObs.Text = reader[6].ToString();
                    cboStat.Text = reader[7].ToString();

                    cboProd.SelectedIndex = cboIDprod.SelectedIndex;
                    cboFunc.SelectedIndex = cboIDfunc.SelectedIndex;
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

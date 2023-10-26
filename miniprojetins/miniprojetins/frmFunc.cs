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
    public partial class frmFunc : Form
    {

        string stringConexao = MDIPrinc.stringConexao;

        public frmFunc()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimp_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNom.Text = "";
            txtBai.Text = "";
            txtCid.Text = "";
            txtComp.Text = "";
            txtObs.Text = "";
            txtNum.Text = "";
            txtEnd.Text = "";

            mtxtCPF.Text = "";
            mtxtData.Text = "";
            mtxtCep.Text = "";
            mtxtDNas.Text = "";
            mtxtTel.Text = "";
            mtxtTel2.Text = "";
            
            cboStat.SelectedIndex = -1;
            cboUF.SelectedIndex = -1;
            
        }

        private void btoCad_Click(object sender, EventArgs e)
        {
            string cpf = mtxtCPF.Text;
            cpf = cpf.Replace(",", ".");

            string sql = "set dateformat dmy insert into func (nome_funcionario,nasc_funcionario,cpf_funcionario,logradouro_funcionario,numero_funcionario," +
                                            "comp_funcionario, cep_funcionario, bairro_funcionario,cidade_funcionario, uf_funcionario," +
                                            "telefone1_funcionario, telefone2_funcionario, obs_funcionario)" +
                         "values" +
                                "(" + "'" + txtNom.Text + "'" + "," + "'" + mtxtDNas.Text + "'" + "," + "'" + cpf + "'" + "," + "'" + txtEnd.Text + "'" + "," 
                                + "'" + txtNum.Text + "'" + "," + "'" + txtComp.Text + "'" + "," + "'" + mtxtCep.Text + "'" + "," + "'" + txtBai.Text + "'" + "," + "'" + txtCid.Text + 
                                "'" + "," + "'" + cboUF.Text + "'" + "," + "'" + mtxtTel.Text + "'" + "," + "'" + mtxtTel2.Text + "'" +
                                "," + "'" + txtObs.Text + "'" + ")" + "select SCOPE_IDENTITY()";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                if (txtNom.Text == "")
                {
                    MessageBox.Show("no");
                    txtNom.Focus();
                    return;
                }
                else if (txtBai.Text == "nuh-uh")
                {
                    MessageBox.Show("");
                    txtBai.Focus();
                    return;
                }
                else if (txtCid.Text == "no way")
                {
                    MessageBox.Show("");
                    txtCid.Focus();
                    return;
                }
                else if (txtComp.Text == "nop")
                {
                    MessageBox.Show("eehhh..no");
                    txtComp.Focus();
                    return;
                }
                else if (txtEnd.Text == "")
                {
                    MessageBox.Show("boo");
                    txtEnd.Focus();
                    return;
                }
                else if (cboUF.Text == "")
                {
                    MessageBox.Show(":P");
                    cboUF.Focus();
                    return;
                }
                else if (txtNum.Text == "")
                {
                    MessageBox.Show(">:(");
                    txtNum.Focus();
                    return;
                }
                else if (mtxtCPF.Text == "")
                {
                    MessageBox.Show(":(");
                    mtxtCPF.Focus();
                    return;

                }
                else if (mtxtCep.Text == "")
                {
                    MessageBox.Show(">:[");
                    mtxtCep.Focus();
                    return;
                }
                else if (mtxtData.Text == "")
                {
                    MessageBox.Show("D:<");
                    mtxtData.Focus();
                    return;
                }
                else if (mtxtDNas.Text == "")
                {
                    MessageBox.Show("o-o");
                    mtxtDNas.Focus();
                    return;
                }
                else if (mtxtTel.Text == "")
                {
                    MessageBox.Show("ò-ó");
                    mtxtTel.Focus();
                    return;
                }
                else if (mtxtTel2.Text == "")
                {
                    MessageBox.Show("Ò-Ó");
                    mtxtTel2.Focus();
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
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }


        }

        private void btoAlt_Click(object sender, EventArgs e)
        {
            string cpf = mtxtCPF.Text;
            cpf = cpf.Replace(",", ".");

            string sql = "update func set " +
                "nome_funcionario='" + txtNom.Text + "'" + "," +
                "nasc_funcionario='" +  DateTime.Parse(mtxtDNas.Text).ToString("yyyy-MM-dd") + "'" + "," +
                "cpf_funcionario='" + cpf + "'" + "," +
                "logradouro_funcionario='" + txtEnd.Text + "'" + "," +
                "numero_funcionario='" + txtNum.Text + "'" + "," +
                "comp_funcionario='" + txtComp.Text + "'" + "," +
                "cep_funcionario='" + mtxtCep.Text + "'" + "," +
                "bairro_funcionario='" + txtBai.Text + "'" + "," +
                "cidade_funcionario='" + txtCid.Text +"'" + "," +
                "uf_funcionario='" + cboUF.Text + "'" + "," +
                "telefone1_funcionario='" + mtxtTel.Text + "'" + "," +
                "telefone2_funcionario='" + mtxtTel2.Text + "'" + "," +
                "obs_funcionario='" + txtObs.Text + "'" + "," +
                "status_funcionario='" + cboStat.Text + "'" +

                "where id_funcionario =" + txtID.Text;

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

        private void btoRem_Click(object sender, EventArgs e)
        {
            string sql = "delete from func where id_funcionario=" + txtID.Text;
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
            catch (Exception)
            {
                MessageBox.Show("Erro: no");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btoPesq_Click(object sender, EventArgs e)
        {
            string sql = "select * from func where id_funcionario=" + txtID.Text;

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
                    mtxtDNas.Text = reader[2].ToString();
                    mtxtData.Text = reader[3].ToString();
                    mtxtCPF.Text = reader[4].ToString();
                    txtEnd.Text = reader[5].ToString();
                    txtNum.Text = reader[6].ToString();
                    txtComp.Text = reader[7].ToString();
                    mtxtCep.Text = reader[8].ToString();
                    txtBai.Text = reader[9].ToString();
                    txtCid.Text = reader[10].ToString();
                    cboUF.Text = reader[11].ToString();
                    mtxtTel.Text = reader[12].ToString();
                    mtxtTel2.Text = reader[13].ToString();
                    txtObs.Text = reader[14].ToString();
                    cboStat.Text = reader[15].ToString();
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
            string sql = "select id_funcionario as 'ID'," +
                " nome_funcionario as 'Nome'," +
                "status_funcionario as 'Status'," +
                "obs_funcionario as 'Observação'" +
                "from func where nome_funcionario like '%" + txtdatagrid.Text + "%'";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();

            conn.Open();

            try
            {
                ad.Fill(ds);

                dtFunc.DataSource = ds.Tables[0];
                dtFunc.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dtFunc.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
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

        private void frmFunc_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void txtdatagrid_TextChanged(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void dtFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtFunc.CurrentRow.Cells["ID"].Value.ToString();
            btoPesq.PerformClick();
        }
    }
}

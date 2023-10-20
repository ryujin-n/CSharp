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
    public partial class frmForn : Form
    {
        string stringConexao = MDIPrinc.stringConexao;
        public frmForn()
        {
            InitializeComponent();
        }

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
            txtObs.Text = "";
            cboUF.Text = "";
            txtNum.Text = "";
            txtEnd.Text = "";
            txtCont.Text = "";

            mtxtCNPJ.Text = "";
            mtxtData.Text = "";
            mtxtCep.Text = "";
            mtxtAbe.Text = "";
            mtxtTel.Text = "";
            mtxtTel2.Text = "";

            cboStat.SelectedIndex = -1;
        }

        private void btoCad_Click(object sender, EventArgs e)
        {

            string cnpj = mtxtCNPJ.Text;
            cnpj = cnpj.Replace(",",".");

            string sql = "set dateformat dmy insert into forn (nome_fornecedor,abert_fornecedor,cnpj_fornecedor,logradouro_fornecedor,numero_fornecedor,cep_fornecedor,bairro_fornecedor,cidade_fornecedor,uf_fornecedor,telefone1_fornecedor,telefone2_fornecedor,contato_fornecedor,obs_fornecedor)" +
                         "values" +
                                "(" + "'" + txtNom.Text + "'" + "," + "'" + mtxtAbe.Text + "'" + "," + "'" +  cnpj + "'" + "," + "'" + txtEnd.Text + "'" + ","
                                + "'" + txtNum.Text + "'" + "," + "'" + mtxtCep.Text + "'" + "," + "'" + txtBai.Text + "'" + "," + "'" + txtCid.Text +
                                "'" + "," + "'" + cboUF.Text + "'" + "," + "'" + mtxtTel.Text + "'" + "," + "'" + mtxtTel2.Text + "'" +
                                "," + "'" + txtCont.Text + "'" + "," + "'" + txtObs.Text + "'" + ")" + "select SCOPE_IDENTITY()";

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
                else if (mtxtCNPJ.Text == "")
                {
                    MessageBox.Show(":(");
                    mtxtCNPJ.Focus();
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
                else if (mtxtAbe.Text == "")
                {
                    MessageBox.Show("o-o");
                    mtxtAbe.Focus();
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
                else if (txtCont.Text == "")
                {
                    MessageBox.Show("aaaa");
                    txtCont.Focus();
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
            string sql = "update func set" +
                "nome_fornecedor='" + txtNom.Text + "'" + "," +
                "abert_fornecedor='" + mtxtAbe.Text + "'" + "," +
                "cnpj_fornecedor ='" + mtxtCNPJ.Text + "'" + "," +
                "logradouro_fornecedor='" + txtEnd.Text + "'" + "," +
                "numero_fornecedor='" + txtNum.Text + "'" + "," +
                "cep_fornecedor='" + mtxtCep.Text + "'" + "," +
                "bairro_fornecedor=' " + txtBai.Text + "'" + "," +
                "cidade_fornecedor='" + txtCid.Text + "'" + "," +
                "uf_fornecedor='" + cboUF.Text + "'" + "," +
                "telefone1_fornecedor='" + mtxtTel.Text + "'" + "," +
                "telefone2_fornecedor='" + mtxtTel2.Text + "'" + "," +
                "contato_fornecedor='" + txtCont.Text + "'" + "," +
                "obs_fornecedor='" + txtObs.Text + "'" + "," +
                "stats_fornecedor='" + cboStat.Text + "'" +

                "where id_fornecedor =" + txtID.Text;


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
            string sql = "delete from forn where id_fornecedor=" + txtID.Text;
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
            string sql = "select * from forn where id_fornecedor=" + txtID.Text;

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
                    mtxtAbe.Text = reader[2].ToString();
                    mtxtData.Text = reader[3].ToString();
                    mtxtCNPJ.Text = reader[4].ToString();
                    txtEnd.Text = reader[5].ToString();
                    txtNum.Text = reader[6].ToString();
                    mtxtCep.Text = reader[7].ToString();
                    txtBai.Text = reader[8].ToString();
                    txtCid.Text = reader[9].ToString();
                    cboUF.Text = reader[10].ToString();
                    mtxtTel.Text = reader[11].ToString();
                    mtxtTel2.Text = reader[12].ToString();
                    txtCont.Text = reader[13].ToString();
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

        private void frmForn_Load(object sender, EventArgs e)
        {
            testcon();
        }
    }
}

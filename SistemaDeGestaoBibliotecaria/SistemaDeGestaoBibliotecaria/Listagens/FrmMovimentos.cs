using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaDeGestaoBibliotecaria.Listagens
{
    public partial class FrmMovimentos : Form
    {
        public FrmMovimentos()
        {
            InitializeComponent();
        }
        private void CarregaDGV()
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;

            con = SistemaDeGestaoBibliotecaria.Conexao.Conectando.AbrirConexao();
            con.Open();
            try
            {
                //con = Conexao.Conectando.AbrirConexao();
                //con.Open();
                string SQL = "Select * From ConsultaMovimentos Order By(IDM) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvDados.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvDados.Rows.Add(Dreader["IDM"].ToString(), Dreader["Nome"].ToString(), Dreader["Operacao"].ToString(), Dreader["Descricao"].ToString(), Dreader["Data"].ToString());
                    lblRegisto.Text = dgvDados.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IDM"].ToString(), Dreader["Nome"].ToString(), Dreader["Operacao"].ToString(), Dreader["Descricao"].ToString(), Dreader["Data"].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! Não foi possivel estabelecer a conexão com o servidor" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = true;
            txtPesquisa.Focus();
        }

        private void FrmMovimentos_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;

            con = SistemaDeGestaoBibliotecaria.Conexao.Conectando.AbrirConexao();
            con.Open();
            try
            {
                ////con = Conexao.Conectando.AbrirConexao();
                ////con.Open();
                string SQL = "Select * From ConsultaMovimentos Where " + cboCampo.Text + " like '" + txtPesquisa.Text + "%' Order By(IDM) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvDados.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    //dgvDados.Rows.Add(Dreader["IdFuncionario"].ToString(), Dreader["Nome"].ToString(), Dreader["TipoDoc"].ToString(), Dreader["NumeroDoc"].ToString(), "Profissao", Dreader["Sexo"].ToString(), "EstadoCivil", Dreader["Morada"].ToString(), Dreader["Contacto1"].ToString(), Dreader["Contacto2"].ToString(), Dreader["Email"].ToString());
                    //lblRegisto.Text = dgvDados.RowCount.ToString();
                    //// dgvImprimir.Rows.Add(Dreader["IdCliente"].ToString(), Dreader["Nome"].ToString(), Dreader["TipoDoc"].ToString(), Dreader["NumeroDoc"].ToString(), Dreader["Sexo"].ToString(), Dreader["Morada"].ToString(), Dreader["Contacto"].ToString(), Dreader["ContactoAlternativo"].ToString(), Dreader["Email"].ToString());
                    dgvDados.Rows.Add(Dreader["IDM"].ToString(), Dreader["Nome"].ToString(), Dreader["Operacao"].ToString(), Dreader["Descricao"].ToString(), Dreader["Data"].ToString());
                    lblRegisto.Text = dgvDados.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IDM"].ToString(), Dreader["Nome"].ToString(), Dreader["Operacao"].ToString(), Dreader["Descricao"].ToString(), Dreader["Data"].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! Não foi possivel estabelecer a conexão com o servidor" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Relatório Movimentos".ToUpper();
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "MUSEU DA PRESIDÊNCIA";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvImprimir);
        }
    }
}

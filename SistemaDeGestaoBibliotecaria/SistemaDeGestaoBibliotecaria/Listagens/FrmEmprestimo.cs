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
    public partial class FrmEmprestimo : Form
    {
        public FrmEmprestimo()
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
                string SQL = "Select * From TBEmprestimo Order By(IDEmprestimo) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvEmprestimo.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvEmprestimo.Rows.Add(Dreader["IDEmprestimo"].ToString(), Dreader["Leitor"].ToString(), Dreader["Livro"].ToString(), Dreader["DataRetirada"].ToString(), Dreader["DataEntrega"].ToString(), Dreader["DataDevolucao"].ToString(), Dreader["Devolucao"].ToString());
                    lblRegisto.Text = dgvEmprestimo.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IDEmprestimo"].ToString(), Dreader["Leitor"].ToString(), Dreader["Livro"].ToString(), Dreader["DataRetirada"].ToString(), Dreader["DataEntrega"].ToString(), Dreader["DataDevolucao"].ToString(), Dreader["Devolucao"].ToString());

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
            printer.Title = "Relatório de Emprestimos".ToUpper();
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Solution Explorer";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvImprimir);
        }

        private void FrmEmprestimo_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = true;
            txtPesquisa.Focus();
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
                string SQL = "Select * From TBEmprestimo Where " + cboCampo.Text + " like '" + txtPesquisa.Text + "%' Order By(IdEmprestimo) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvEmprestimo.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvEmprestimo.Rows.Add(Dreader["IDEmprestimo"].ToString(), Dreader["Leitor"].ToString(), Dreader["Livro"].ToString(), Dreader["DataRetirada"].ToString(), Dreader["DataEntrega"].ToString(), Dreader["DataDevolucao"].ToString(), Dreader["Devolucao"].ToString());
                    lblRegisto.Text = dgvEmprestimo.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IDEmprestimo"].ToString(), Dreader["Leitor"].ToString(), Dreader["Livro"].ToString(), Dreader["DataRetirada"].ToString(), Dreader["DataEntrega"].ToString(), Dreader["DataDevolucao"].ToString(), Dreader["Devolucao"].ToString());

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
    }
}

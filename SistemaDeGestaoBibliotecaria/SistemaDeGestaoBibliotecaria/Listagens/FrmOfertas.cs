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
    public partial class FrmOfertas : Form
    {
        public FrmOfertas()
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
                string SQL = "Select * From TBOfertas Order By(IDOferta) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvDados.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvDados.Rows.Add(Dreader["IDOferta"].ToString(), Dreader["CodigoObra"].ToString(), Dreader["Beneficiario"].ToString(), Dreader["Ano"].ToString(), Dreader["Descricao"].ToString(), Dreader["Estado"].ToString(), Dreader["Nomesala"].ToString(), Dreader["Nacionalidade"].ToString(), Dreader["Doador"].ToString());
                    lblRegisto.Text = dgvDados.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IDOferta"].ToString(), Dreader["CodigoObra"].ToString(), Dreader["Beneficiario"].ToString(), Dreader["Ano"].ToString(), Dreader["Descricao"].ToString(), Dreader["Estado"].ToString(), Dreader["Nomesala"].ToString(), Dreader["Nacionalidade"].ToString(), Dreader["Doador"].ToString());

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
        private void FrmOfertas_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Relatório Ofertas".ToUpper();
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "MUSEU DA PRESIDÊNCIA";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvImprimir);
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
                string SQL = "Select * From TBOfertas Where " + cboCampo.Text + " like '" + txtPesquisa.Text + "%' Order By(IDOferta) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvDados.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvDados.Rows.Add(Dreader["IDOferta"].ToString(), Dreader["CodigoObra"].ToString(), Dreader["Beneficiario"].ToString(), Dreader["Ano"].ToString(), Dreader["Descricao"].ToString(), Dreader["Estado"].ToString(), Dreader["Nomesala"].ToString(), Dreader["Nacionalidade"].ToString(), Dreader["Doador"].ToString());
                    lblRegisto.Text = dgvDados.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IDOferta"].ToString(), Dreader["CodigoObra"].ToString(), Dreader["Beneficiario"].ToString(), Dreader["Ano"].ToString(), Dreader["Descricao"].ToString(), Dreader["Estado"].ToString(), Dreader["Nomesala"].ToString(), Dreader["Nacionalidade"].ToString(), Dreader["Doador"].ToString());
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
    }
}

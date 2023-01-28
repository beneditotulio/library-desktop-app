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
    public partial class FrmFOA : Form
    {
        public FrmFOA()
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
                string SQL = "Select * From TBObjectosArte Order By(IDFOA) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvDados.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvDados.Rows.Add(Dreader["IDFOA"].ToString(), Dreader["CodigoObra"].ToString(), Dreader["Autor"].ToString(), Dreader["Tipo"].ToString(), Dreader["Material"].ToString(), Dreader["Dimensoes"].ToString(), Dreader["Proveniencia"].ToString(), Dreader["Tema"].ToString(), Dreader["Museu"].ToString(), Dreader["Posicao"].ToString(), Dreader["Descricao"].ToString(), Dreader["Estado"].ToString());
                    lblRegisto.Text = dgvDados.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IDFOA"].ToString(), Dreader["CodigoObra"].ToString(), Dreader["Autor"].ToString(), Dreader["Tipo"].ToString(), Dreader["Material"].ToString(), Dreader["Dimensoes"].ToString(), Dreader["Proveniencia"].ToString(), Dreader["Tema"].ToString(), Dreader["Museu"].ToString(), Dreader["Posicao"].ToString(), Dreader["Descricao"].ToString(), Dreader["Estado"].ToString());

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
                string SQL = "Select * From TBObjectosArte Where " + cboCampo.Text + " like '" + txtPesquisa.Text + "%' Order By(IDFOA) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvDados.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {

                    dgvDados.Rows.Add(Dreader["IDFOA"].ToString(), Dreader["CodigoObra"].ToString(), Dreader["Autor"].ToString(), Dreader["Tipo"].ToString(), Dreader["Material"].ToString(), Dreader["Dimensoes"].ToString(), Dreader["Proveniencia"].ToString(), Dreader["Tema"].ToString(), Dreader["Museu"].ToString(), Dreader["Posicao"].ToString(), Dreader["Descricao"].ToString(), Dreader["Estado"].ToString());
                    lblRegisto.Text = dgvDados.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IDFOA"].ToString(), Dreader["CodigoObra"].ToString(), Dreader["Autor"].ToString(), Dreader["Tipo"].ToString(), Dreader["Material"].ToString(), Dreader["Dimensoes"].ToString(), Dreader["Proveniencia"].ToString(), Dreader["Tema"].ToString(), Dreader["Museu"].ToString(), Dreader["Posicao"].ToString(), Dreader["Descricao"].ToString(), Dreader["Estado"].ToString());

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

        private void FrmFOA_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Relatório de Fotografias e Objectos de Arte".ToUpper();
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

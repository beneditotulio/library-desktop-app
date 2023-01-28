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
    public partial class FrmLivro : Form
    {
        public FrmLivro()
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
                string SQL = "Select * From TBLivro Order By(IdLivro) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvLivro.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvLivro.Rows.Add(Dreader["IdLivro"].ToString(), Dreader["Titulo"].ToString(), Dreader["Edicao"].ToString(), Dreader["Ano"].ToString(), Dreader["ISBN"].ToString(), Dreader["Localizacao"].ToString(), Dreader["Assunto"].ToString(), Dreader["Classificacao"].ToString(), Dreader["Autor"].ToString(), Dreader["Resenha"].ToString(), Dreader["Editora"].ToString());
                    lblRegisto.Text = dgvLivro.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IdLivro"].ToString(), Dreader["Titulo"].ToString(), Dreader["Edicao"].ToString(), Dreader["Ano"].ToString(), Dreader["ISBN"].ToString(), Dreader["Localizacao"].ToString(), Dreader["Assunto"].ToString(), Dreader["Classificacao"].ToString(), Dreader["Autor"].ToString(), Dreader["Resenha"].ToString(), Dreader["Editora"].ToString());

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
                string SQL = "Select * From TBLivro Where " + cboCampo.Text + " like '" + txtPesquisa.Text + "%' Order By(IdLivro) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvLivro.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvLivro.Rows.Add(Dreader["IdLivro"].ToString(), Dreader["Titulo"].ToString(), Dreader["Edicao"].ToString(), Dreader["Ano"].ToString(), Dreader["ISBN"].ToString(), Dreader["Localizacao"].ToString(), Dreader["Assunto"].ToString(), Dreader["Classificacao"].ToString(), Dreader["Autor"].ToString(), Dreader["Resenha"].ToString(), Dreader["Editora"].ToString());
                    lblRegisto.Text = dgvLivro.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IdLivro"].ToString(), Dreader["Titulo"].ToString(), Dreader["Edicao"].ToString(), Dreader["Ano"].ToString(), Dreader["ISBN"].ToString(), Dreader["Localizacao"].ToString(), Dreader["Assunto"].ToString(), Dreader["Classificacao"].ToString(), Dreader["Autor"].ToString(), Dreader["Resenha"].ToString(), Dreader["Editora"].ToString());

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

        private void adicionarCredenciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Minhas_Classes.VariaveisEstaticas.Livro = dgvLivro.CurrentRow.Cells[1].Value.ToString();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = true;
            txtPesquisa.Focus();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Relatório Livro".ToUpper();
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

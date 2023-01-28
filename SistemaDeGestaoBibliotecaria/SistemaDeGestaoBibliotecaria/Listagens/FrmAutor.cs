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
    public partial class FrmAutor : Form
    {
        public FrmAutor()
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
                string SQL = "Select * From TBAutor Order By(IDAutor) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvAutor.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvAutor.Rows.Add(Dreader["IDAutor"].ToString(), Dreader["Nome"].ToString(), Dreader["Sexo"].ToString(), Dreader["Contacto"].ToString(), Dreader["Email"].ToString());
                    lblRegisto.Text = dgvAutor.RowCount.ToString();
                    // dgvImprimir.Rows.Add(Dreader["IdCliente"].ToString(), Dreader["Nome"].ToString(), Dreader["TipoDoc"].ToString(), Dreader["NumeroDoc"].ToString(), Dreader["Sexo"].ToString(), Dreader["Morada"].ToString(), Dreader["Contacto"].ToString(), Dreader["ContactoAlternativo"].ToString(), Dreader["Email"].ToString());

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
            printer.Title = "Relatório de Autores".ToUpper();
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now);
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Solution Explorer";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvAutor);
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = true;
            txtPesquisa.Focus();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cboCampo.SelectedIndex = -1;
            txtPesquisa.Text = string.Empty;
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
                string SQL = "Select * From TBAutor Where " + cboCampo.Text + " like '" + txtPesquisa.Text + "%' Order By(IDAutor) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvAutor.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvAutor.Rows.Add(Dreader["IDAutor"].ToString(), Dreader["Nome"].ToString(), Dreader["Sexo"].ToString(), Dreader["Contacto"].ToString(), Dreader["Email"].ToString());
                    lblRegisto.Text = dgvAutor.RowCount.ToString();
                    // dgvImprimir.Rows.Add(Dreader["IdCliente"].ToString(), Dreader["Nome"].ToString(), Dreader["TipoDoc"].ToString(), Dreader["NumeroDoc"].ToString(), Dreader["Sexo"].ToString(), Dreader["Morada"].ToString(), Dreader["Contacto"].ToString(), Dreader["ContactoAlternativo"].ToString(), Dreader["Email"].ToString());

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

        private void dgvAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adicionarCredenciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtAutor.Text == string.Empty)
            {
                txtAutor.Text = dgvAutor.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                txtAutor.Text = txtAutor.Text +", "+ dgvAutor.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void FrmAutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Minhas_Classes.VariaveisEstaticas.Autores = txtAutor.Text;
        }
    }
}

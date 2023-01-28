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
using System.Threading;
using System.Data.OleDb;
using SistemaDeGestaoBibliotecaria.Listagens;

namespace SGLViatura_Carheaven.Listagens
{
    public partial class FrmFuncionario : Form
    {
        Thread t1;

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
                string SQL = "Select * From TBFuncionario Order By(IdFuncionario) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvFuncionario.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvFuncionario.Rows.Add(Dreader["IdFuncionario"].ToString(), Dreader["Nome"].ToString(), Dreader["TipoDoc"].ToString(), Dreader["NumeroDoc"].ToString(), Dreader["Profissao"], Dreader["Sexo"].ToString(), Dreader["EstadoCivil"], Dreader["Morada"].ToString(), Dreader["Contacto1"].ToString(), Dreader["Contacto2"].ToString(), Dreader["Email"].ToString());
                    lblRegisto.Text = dgvFuncionario.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IdFuncionario"].ToString(), Dreader["Nome"].ToString(), Dreader["TipoDoc"].ToString(), Dreader["NumeroDoc"].ToString(), Dreader["Sexo"].ToString(), Dreader["Morada"].ToString(), Dreader["Contacto1"].ToString(), Dreader["Contacto2"].ToString(), Dreader["Email"].ToString());

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
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void adicionarCredenciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemaDeGestaoBibliotecaria.Minhas_Classes.VariaveisEstaticas.IdFuncionario = Convert.ToInt32(dgvFuncionario.CurrentRow.Cells[0].Value.ToString());
            SistemaDeGestaoBibliotecaria.Minhas_Classes.VariaveisEstaticas.NomeFuncionario = dgvFuncionario.CurrentRow.Cells[1].Value.ToString();
            SistemaDeGestaoBibliotecaria.Minhas_Classes.VariaveisEstaticas.Profissao = dgvFuncionario.CurrentRow.Cells[4].Value.ToString();
            //Telas.FrmUtilizador Utilizador = new Telas.FrmUtilizador();
            //Utilizador.ShowDialog();

            SistemaDeGestaoBibliotecaria.Telas.frmUtilizador IP = new SistemaDeGestaoBibliotecaria.Telas.frmUtilizador();
            IP.ShowDialog();
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
                string SQL = "Select * From TBFuncionario Where " + cboCampo.Text + " like '" + txtPesquisa.Text + "%' Order By(IdFuncionario) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvFuncionario.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvFuncionario.Rows.Add(Dreader["IdFuncionario"].ToString(), Dreader["Nome"].ToString(), Dreader["TipoDoc"].ToString(), Dreader["NumeroDoc"].ToString(), "Profissao", Dreader["Sexo"].ToString(), "EstadoCivil", Dreader["Morada"].ToString(), Dreader["Contacto1"].ToString(), Dreader["Contacto2"].ToString(), Dreader["Email"].ToString());
                    lblRegisto.Text = dgvFuncionario.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IdFuncionario"].ToString(), Dreader["Nome"].ToString(), Dreader["TipoDoc"].ToString(), Dreader["NumeroDoc"].ToString(), Dreader["Sexo"].ToString(), Dreader["Morada"].ToString(), Dreader["Contacto1"].ToString(), Dreader["Contacto2"].ToString(), Dreader["Email"].ToString());

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

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cboCampo.SelectedIndex = -1;
            txtPesquisa.Text = string.Empty;
            CarregaDGV();
        }

        private void AbrirFormFunc(object obj)
        {
           // Application.Run(new Telas.FrmFuncionario());
        }
        private void alterarRegistoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //t1 = new Thread(AbrirFormFunc);
            //t1.SetApartmentState(ApartmentState.STA);
            //t1.Start();

          //  Telas.FrmFuncionario F = new Telas.FrmFuncionario();
          //  F.IdFuncionario = dgvFuncionario.CurrentRow.Cells[0].Value.ToString();
          ////  MessageBox.Show(F.IdFuncionario);
          //  F.ShowDialog();

        }

        private void FrmFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Minhas_Classes.VariaveisEstaticas.Profissao = null;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Relatório Funcionário".ToUpper();
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

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
    public partial class FrmLeitor : Form
    {
        public FrmLeitor()
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
                string SQL = "Select * From TBLeitor Order By(IdLeitor) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvLeitor.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvLeitor.Rows.Add(Dreader["IdLeitor"].ToString(), Dreader["Nome"].ToString(), Dreader["TipoDoc"].ToString(), Dreader["NumeroDoc"].ToString(), "Profissao", Dreader["Sexo"].ToString(), "EstadoCivil", Dreader["Morada"].ToString(), Dreader["Contacto1"].ToString(), Dreader["Contacto2"].ToString(), Dreader["Email"].ToString());
                    lblRegisto.Text = dgvLeitor.RowCount.ToString();
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

        private void FrmLeitor_Load(object sender, EventArgs e)
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
                string SQL = "Select * From TBLeitor Where " + cboCampo.Text + " like '" + txtPesquisa.Text + "%' Order By(IdLeitor) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvLeitor.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvLeitor.Rows.Add(Dreader["IdLeitor"].ToString(), Dreader["Nome"].ToString(), Dreader["TipoDoc"].ToString(), Dreader["NumeroDoc"].ToString(), "Profissao", Dreader["Sexo"].ToString(), "EstadoCivil", Dreader["Morada"].ToString(), Dreader["Contacto1"].ToString(), Dreader["Contacto2"].ToString(), Dreader["Email"].ToString());
                    lblRegisto.Text = dgvLeitor.RowCount.ToString();
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

        private void adicionarCredenciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Minhas_Classes.VariaveisEstaticas.Leitor = dgvLeitor.CurrentRow.Cells[1].Value.ToString();
        }

        private void alterarRegistoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.frmLeitor IP = new Telas.frmLeitor();
            IP.IDLeitor = dgvLeitor.CurrentRow.Cells[0].Value.ToString();
            //Minhas_Classes.VariaveisEstaticas.IDLeitor = dgvLeitor.CurrentRow.Cells[0].Value.ToString();
            IP.ShowDialog();
            
           
           // MessageBox.Show(Minhas_Classes.VariaveisEstaticas.IDLeitor);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}

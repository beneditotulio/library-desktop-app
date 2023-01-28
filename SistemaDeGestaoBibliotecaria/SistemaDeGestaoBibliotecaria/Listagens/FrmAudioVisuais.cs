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
    public partial class FrmAudioVisuais : Form
    {
        public FrmAudioVisuais()
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
                string SQL = "Select * From TBAudioVisuais Order By(IDAV) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvDados.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dgvDados.Rows.Add(Dreader["IDAV"].ToString(), Dreader["Titulo"].ToString(), Dreader["TipoObra"].ToString(), Dreader["Material"].ToString(), Dreader["Autor"].ToString(), Dreader["Duracao"].ToString(), Dreader["Tempo"].ToString(), Dreader["Assunto"].ToString(), Dreader["Realizador"].ToString(), Dreader["DataRealizacao"].ToString(), Dreader["Actores"].ToString(), Dreader["Descricao"].ToString(), Dreader["Lingua"].ToString(), Dreader["Localizacao"].ToString(), Dreader["Estado"].ToString());
                    lblRegisto.Text = dgvDados.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IDAV"].ToString(), Dreader["Titulo"].ToString(), Dreader["TipoObra"].ToString(), Dreader["Material"].ToString(), Dreader["Autor"].ToString(), Dreader["Duracao"].ToString(), Dreader["Tempo"].ToString(), Dreader["Assunto"].ToString(), Dreader["Realizador"].ToString(), Dreader["DataRealizacao"].ToString(), Dreader["Actores"].ToString(), Dreader["Descricao"].ToString(), Dreader["Lingua"].ToString(), Dreader["Localizacao"].ToString(), Dreader["Estado"].ToString());

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

        private void FrmAudioVisuais_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Relatório AudioVisuais".ToUpper();
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
                string SQL = "Select * From TBAudioVisuais Where " + cboCampo.Text + " like '" + txtPesquisa.Text + "%' Order By(IDAV) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dgvDados.Rows.Clear();
                dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                  
                    dgvDados.Rows.Add(Dreader["IDAV"].ToString(), Dreader["Titulo"].ToString(), Dreader["TipoObra"].ToString(), Dreader["Material"].ToString(), Dreader["Autor"].ToString(), Dreader["Duracao"].ToString(), Dreader["Tempo"].ToString(), Dreader["Assunto"].ToString(), Dreader["Realizador"].ToString(), Dreader["DataRealizacao"].ToString(), Dreader["Actores"].ToString(), Dreader["Descricao"].ToString(), Dreader["Lingua"].ToString(), Dreader["Localizacao"].ToString(), Dreader["Estado"].ToString());
                    lblRegisto.Text = dgvDados.RowCount.ToString();
                    dgvImprimir.Rows.Add(Dreader["IDAV"].ToString(), Dreader["Titulo"].ToString(), Dreader["TipoObra"].ToString(), Dreader["Material"].ToString(), Dreader["Autor"].ToString(), Dreader["Duracao"].ToString(), Dreader["Tempo"].ToString(), Dreader["Assunto"].ToString(), Dreader["Realizador"].ToString(), Dreader["DataRealizacao"].ToString(), Dreader["Actores"].ToString(), Dreader["Descricao"].ToString(), Dreader["Lingua"].ToString(), Dreader["Localizacao"].ToString(), Dreader["Estado"].ToString());

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

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

namespace SistemaDeGestaoBibliotecaria.Telas
{
    public partial class frmOfertas : Form
    {
        public frmOfertas()
        {
            InitializeComponent();
        }
        private void Limpa()
        {
            txtCodigoObra.Text = string.Empty;
            txtBeneficiario.Text = string.Empty;
            txtAno.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            cboEstado.SelectedIndex = 0;
            cboNomeSala.SelectedIndex = -1;
            cboNacionalidade.SelectedIndex = -1;
            txtDoador.Text = string.Empty;
            CarregaCodigo();
        }
        private void CarregaCodigo()
        {
            OleDbConnection con = null;
            OleDbCommand cmd = null;
            OleDbDataReader Dreader = null;

            try
            {
                con = Conexao.Conectando.AbrirConexao();
                con.Open();
                string SQL = "Select * From TBOfertas Order By IDOferta Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                if (Dreader.Read())
                {
                    txtCodigo.Text = Dreader["IDOferta"].ToString();
                    //   txtNome.Text = Dreader["Nome"].ToString();
                    //MessageBox.Show("O codigo é: "+Convert.ToInt32(Convert.ToInt32(txtCodigoLeitor.Text)+1));
                    txtCodigo.Text = Convert.ToString(Convert.ToInt32(Convert.ToInt32(txtCodigo.Text) + 1));
                }
                else
                {
                    txtCodigo.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel estabelecer a conexão com a Base de Dados.");
            }
            finally
            {
                con.Close();
            }
        }
        private void CarregaNomeSala()
        {
            OleDbConnection con = null;
            OleDbCommand cmd = null;
            OleDbDataReader Dreader = null;

            try
            {
                con = Conexao.Conectando.AbrirConexao();
                con.Open();
                string SQL = "Select * From TBNomeSala Order By Descricao Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                cboNomeSala.Items.Clear();
                while (Dreader.Read())
                {
                    cboNomeSala.Items.Add(Dreader["Descricao"].ToString());

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel estabelecer a conexão com a Base de Dados.");
            }
            finally
            {
                con.Close();
            }
        }


        private void btnSai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOfertas_Load(object sender, EventArgs e)
        {
            CarregaNomeSala();
            Limpa();
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstado.Text == "Em Exposição")
            {
                cboNomeSala.Enabled = true;
            }
            else
            {
                cboNomeSala.SelectedIndex = -1;
                cboNomeSala.Enabled = false;
            }
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCarregaFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            Modelos.Ofertas MO = new Modelos.Ofertas();
            MO.CodigoObra = txtCodigoObra.Text;
            MO.Beneficiario = txtBeneficiario.Text;
            MO.Ano = txtAno.Text;
            MO.Descricao = txtDescricao.Text;
            MO.Estado = cboEstado.Text;
            MO.NomeSala = cboNomeSala.Text;
            MO.Nacionalidade = cboNacionalidade.Text;
            MO.Doador = txtDoador.Text;
            Controladores.ControladorOfertas.Salvar(MO);
            Limpa();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa();
        }
    }
}

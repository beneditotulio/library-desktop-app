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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        private void Limpa()
        {
            txtCodigo.Text = "";
            txtNome.Text = string.Empty;
            cboSexo.SelectedIndex = -1;
            txtNumeroDoc.Text = string.Empty;
            cboTipoDoc.SelectedIndex = -1;
            txtMorada.Text = string.Empty;
            txtContacto1.Text = string.Empty;
            txtContacto2.Text = string.Empty;
            txtEmail.Text = string.Empty;
            CarregaLeitor();
        }

        private void CarregaLeitor()
        {
            OleDbConnection con = null;
            OleDbCommand cmd = null;
            OleDbDataReader Dreader = null;

            try
            {
                con = Conexao.Conectando.AbrirConexao();
                con.Open();
                string SQL = "Select * From TBFuncionario Order By IDFuncionario Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                if (Dreader.Read())
                {
                    txtCodigo.Text = Dreader["IDFuncionario"].ToString();
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
        private void btnSai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void btnSai_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtNumeroDoc.Text == string.Empty)
            {
                txtNumeroDoc.Focus();
            }
            else if (txtNome.Text == string.Empty)
            {
                txtNome.Focus();
            }
            else
            {
                Modelos.Funcionario Funcionario = new Modelos.Funcionario();

                Funcionario.Nome = txtNome.Text;
                Funcionario.TipoDoc = cboTipoDoc.Text;
                Funcionario.NumeroDoc = txtNumeroDoc.Text;
                Funcionario.Sexo = cboSexo.Text;
                Funcionario.Morada = txtMorada.Text;
                Funcionario.Contacto = txtContacto1.Text;
                Funcionario.Contacto1 = txtContacto2.Text;
                Funcionario.Email = txtEmail.Text;

                Controladores.ControladorFuncionario.Salvar(Funcionario);

                Limpa();
            }
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            Limpa();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa();
        }
    }
}

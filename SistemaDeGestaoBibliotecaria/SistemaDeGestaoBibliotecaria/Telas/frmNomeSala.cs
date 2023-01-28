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
    public partial class frmNomeSala : Form
    {
        public frmNomeSala()
        {
            InitializeComponent();
        }
        private void CarregaDados()
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
                string SQL = "Select * From TBNomeSala Order By(IDSala) Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                //dgvImprimir.Rows.Clear();
                while (Dreader.Read())
                {
                    dataGridView1.Rows.Add(Dreader["IDSala"].ToString(), Dreader["Descricao"].ToString());
                    // lblRegisto.Text = dgvAutor.RowCount.ToString();
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

        private void Limpa()
        {
            btnApaga.Enabled = false;
            btnEdita.Enabled = false;
            txtCodigo.Text = "";
            txtDescricao.Text = string.Empty;
            txtDescricao.Focus();
            CarregaLocal();
            CarregaDados();
        }
        private void CarregaLocal()
        {
            OleDbConnection con = null;
            OleDbCommand cmd = null;
            OleDbDataReader Dreader = null;

            try
            {
                con = Conexao.Conectando.AbrirConexao();
                con.Open();
                string SQL = "Select * From TBNomeSala Order By IDSala Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                if (Dreader.Read())
                {
                    txtCodigo.Text = Dreader["IDSala"].ToString();
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

        private void frmNomeSala_Load(object sender, EventArgs e)
        {
            Limpa();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == string.Empty)
            {
                txtDescricao.Focus();
            }
            else
            {
                Modelos.NomeSala MSala = new Modelos.NomeSala();

                MSala.Descricao = txtDescricao.Text;


                Controladores.ControladorNomeSala.Salvar(MSala);

                Limpa();
            }
        }
    }
}

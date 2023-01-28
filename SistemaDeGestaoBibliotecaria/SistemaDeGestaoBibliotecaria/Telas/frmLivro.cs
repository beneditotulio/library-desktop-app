using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.OleDb;

namespace SistemaDeGestaoBibliotecaria.Telas
{
    public partial class frmLivro : Form
    {
        public frmLivro()
        {
            InitializeComponent();
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

        private void CarregaLocal()
        {
            OleDbConnection con = null;
            OleDbCommand cmd = null;
            OleDbDataReader Dreader = null;

            try
            {
                con = Conexao.Conectando.AbrirConexao();
                con.Open();
                string SQL = "Select * From TBLocal Order By Descricao Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                cboLocal.Items.Clear();
                while (Dreader.Read())
                {
                    cboLocal.Items.Add(Dreader["Descricao"].ToString());
                  
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
        private void Limpa()
        {
            txtCodigo.Text = "";
            txtTitulo.Text = string.Empty;
            cboEdicao.SelectedIndex = -1;
            txtAno.Text = string.Empty;
            txtISBN.Text = string.Empty; ;
            //txtLocalizacao.Text = string.Empty;
            txtAssunto.Text = string.Empty;
            txtLingua.Text = string.Empty;
            txtAutores.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtEditora.Text = string.Empty;
            cboLocal.SelectedIndex = -1;

            txtNrPag.Text = string.Empty;
            cboTipoPag.SelectedIndex = -1;
            cboTipoCapa.SelectedIndex = -1;
            cboTipo.SelectedIndex = -1;
            txtCopy.Text = string.Empty;
            cboEstado.SelectedIndex = 0;
            cboNomeSala.SelectedIndex = -1;

            Minhas_Classes.VariaveisEstaticas.Autores = null;
            CarregaLivro();
            CarregaNomeSala();
            CarregaLocal();
        }

        private void CarregaLivro()
        {
            OleDbConnection con = null;
            OleDbCommand cmd = null;
            OleDbDataReader Dreader = null;

            try
            {
                con = Conexao.Conectando.AbrirConexao();
                con.Open();
                string SQL = "Select * From TBLivro Order By IDLivro Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                if (Dreader.Read())
                {
                    txtCodigo.Text = Dreader["IDLivro"].ToString();
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

        private void frmLivro_Load(object sender, EventArgs e)
        {
            Limpa();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listagens.FrmAutor IP = new Listagens.FrmAutor();
            IP.ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == string.Empty)
            {
                txtTitulo.Focus();
            }
                else if(txtAutores.Text == string.Empty)
            {
                txtAutores.Focus();
            }
            else
            {
                Modelos.Livro Livro = new Modelos.Livro();
                Livro.Titulo = txtTitulo.Text;
                Livro.Edicao = cboEdicao.Text;
                Livro.Ano = txtAno.Text;
                Livro.ISBN = txtISBN.Text;
                //Livro.Localizacao = txtLocalizacao.Text;
                Livro.Localizacao = cboLocal.Text;
                Livro.Assunto = /*txtAssunto.Text;*/cboGenero.Text;
                Livro.Classificacao = string.Empty;
                Livro.Autor = txtAutores.Text;
                Livro.Descricao = txtDescricao.Text;
                Livro.Editora = txtEditora.Text;

                Livro.Lingua = txtLingua.Text;
                Livro.DataEdicao = dtpDataActual.Value.ToString();
                Livro.NrPag = txtNrPag.Text;
                Livro.TipoPag = cboTipoPag.Text;
                Livro.TipoCapa = cboTipoCapa.Text;
                Livro.Copyright = txtCopy.Text;
                Livro.Tipo = cboTipo.Text;
                Livro.Estado = cboEstado.Text;
                Livro.NomeSala = cboNomeSala.Text;


                Controladores.ControladorLivro.Salvar(Livro);
                Limpa();
            }
        }

        private void groupBox1_Move(object sender, EventArgs e)
        {
            txtAutores.Text = Minhas_Classes.VariaveisEstaticas.Autores;
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Minhas_Classes.VariaveisEstaticas.Autores);
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            txtAutores.Text = Minhas_Classes.VariaveisEstaticas.Autores;
        }

        private void frmLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Minhas_Classes.VariaveisEstaticas.Autores = null;
        }

        private void cboEdicao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdita_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void cboLocal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

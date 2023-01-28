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
    public partial class frmBr : Form
    {
        public frmBr()
        {
            InitializeComponent();
        }
        public int IDBR { get; set; }
        private void Limpa()
        {
            txtNrBR.Text = string.Empty;
            txtSerie.Text = string.Empty;
            txtData.Text = System.DateTime.Now.ToString();
            cboTipo.SelectedIndex = -1;
            cboAssunto.SelectedIndex = -1;
            txtDescricao.Text = string.Empty;
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
                string SQL = "Select * From TBBR Order By IDBR Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                if (Dreader.Read())
                {
                    txtCodigo.Text = Dreader["IDBR"].ToString();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCarregaFoto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor aguarde!");
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBr_Load(object sender, EventArgs e)
        {
            //IDBR = IDBR;
            if(IDBR != null || IDBR > 0)
            {
                Limpa();

                Modelos.BR MB = Controladores.ControladorBR.Pesquisar(IDBR);
                if(MB != null)
                {
                    txtCodigo.Text = MB.idBr.ToString();
                    txtNrBR.Text = MB.NrBR;
                    txtSerie.Text = MB.Serie;
                    txtDescricao.Text = MB.Descricao;
                    txtData.Text = MB.Datapub;
                    cboAssunto.Text = MB.Assunto;
                    cboTipo.Text = MB.Tipo;
                    
                    btnSalva.Enabled = false;
                    btnEdita.Enabled = true;
                    btnApaga.Enabled = true;
                }
                
            }
            else
            { 
                Limpa();
            }
            //MB = null;
            //var M = Controladores.ControladorBR.GetAllBR();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            Modelos.BR MB = new Modelos.BR();
            MB.NrBR = txtNrBR.Text;
            MB.Serie = txtSerie.Text;
            MB.Datapub = txtData.Text;
            MB.Tipo = cboTipo.Text;
            MB.Assunto = cboAssunto.Text;
            MB.Descricao = txtDescricao.Text;
            Controladores.ControladorBR.Salvar(MB);
            Limpa();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa();
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            
            Modelos.BR MB = new Modelos.BR();
            MB.idBr = int.Parse(txtCodigo.Text);
            MB.NrBR = txtNrBR.Text;
            MB.Serie = txtSerie.Text;
            MB.Datapub = txtData.Text;
            MB.Tipo = cboTipo.Text;
            MB.Assunto = cboAssunto.Text;
            MB.Descricao = txtDescricao.Text;
            if (MB.NrBR == string.Empty)
            {
                MessageBox.Show("Por favor informe o codigo do BR");
            }
            else
            {
                Controladores.ControladorBR.Editar(MB);
                Limpa();
            }
            
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            Modelos.BR MB = new Modelos.BR();
            MB.NrBR = txtNrBR.Text;
            MB.Serie = txtSerie.Text;
            MB.Datapub = txtData.Text;
            MB.Tipo = cboTipo.Text;
            MB.Assunto = cboAssunto.Text;
            MB.Descricao = txtDescricao.Text;
            Controladores.ControladorBR.Eliminar(MB);
            Limpa();
        }
    }
}

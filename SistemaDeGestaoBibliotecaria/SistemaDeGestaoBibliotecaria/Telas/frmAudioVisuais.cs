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
using System.IO;
using System.Drawing.Imaging;

namespace SistemaDeGestaoBibliotecaria.Telas
{
    public partial class frmAudioVisuais : Form
    {
        public frmAudioVisuais()
        {
            InitializeComponent();
        }

        OleDbConnection con = null;
        OleDbCommand cmd = null;
        OleDbDataAdapter adapter = null;
        DataSet ds;
        MemoryStream ms;

        void conv_photo()
        {
            //converting photo to binary data
            if (pictureBox1.Image != null)
            {
                //using MemoryStream:
                ms = new MemoryStream();
                pbImagem.Image.Save(ms, ImageFormat.Jpeg);
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@photo", photo_aray);
            }

        }

        private void CarregCodigo()
        {
            OleDbConnection con = null;
            OleDbCommand cmd = null;
            OleDbDataReader Dreader = null;

            try
            {
                con = Conexao.Conectando.AbrirConexao();
                con.Open();
                string SQL = "Select * From TBAudioVisuais Order By IDAV Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                if (Dreader.Read())
                {
                    txtCodigo.Text = Dreader["IDAV"].ToString();
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
        private void Limpa()
        {
            txtTitulo.Text = string.Empty;
            cboTipoObra.SelectedIndex = -1;
            cboMaterial.SelectedIndex = -1;
            txtAutor.Text = string.Empty;
            cboHora.SelectedIndex = 0;
            txtMinuto.Text = "00";
            txtSegundo.Text = "00";
            cboDuracao.SelectedIndex = -1;
            txtTempo.Text = string.Empty;
            txtAssunto.Text = string.Empty;
            txtRealizador.Text = string.Empty;
            //dtpDataActual.Value.ToString();
            txtActores.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtLingua.Text = string.Empty;
            cboNomeSala.SelectedIndex = -1;
            cboEstado.SelectedIndex = 0;
            pbImagem.Image = Properties.Resources.AUDIO_VISUAL;
            CarregCodigo();
            
        }

        private void cboMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboTipoObra.Text == "Musical")
            //{
            //    cboMaterial.Items.Add("Cassete");
            //    cboMaterial.Items.Add("Disco de Vinil");
            //    cboMaterial.Items.Add("CD");
            //}
            //else
            //{
            //    cboMaterial.Items.Add("Cassete");
            //    cboMaterial.Items.Add("Disco de Vinil");
            //    cboMaterial.Items.Add("CD");
            //    cboMaterial.Items.Add("Fita");
            //    cboMaterial.Items.Add("VHS");
            //    cboMaterial.Items.Add("Cartuchos");
            //    cboMaterial.Items.Add("Bluray");
            //    cboMaterial.Items.Add("Disco de Vinil");
            //    cboMaterial.Items.Add("Bobine");


            //}
        }

        private void cboTipoObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMaterial.Items.Clear();
            if (cboTipoObra.Text == "Musical")
            {

                cboMaterial.Items.Add("Cassete");
                cboMaterial.Items.Add("Disco de Vinil");
                cboMaterial.Items.Add("CD");
            }
            else
            {
                cboMaterial.Items.Add("Cassete");
                cboMaterial.Items.Add("Disco de Vinil");
                cboMaterial.Items.Add("CD");
                cboMaterial.Items.Add("Fita");
                cboMaterial.Items.Add("VHS");
                cboMaterial.Items.Add("Cartuchos");
                cboMaterial.Items.Add("Bluray");
                cboMaterial.Items.Add("Bobine");


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCarregaFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File (*.jpg;*.bmp;*.png;*.gif)|*.jpg;*.bmp;*.png;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbImagem.ImageLocation = openFileDialog1.FileName;
                    pbImagem.Load();
                    MessageBox.Show("Caminho: " + openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_DragOver(object sender, DragEventArgs e)
        {
            

        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            txtTempo.Text = string.Empty;
            if (cboHora.SelectedIndex == -1)
            {
                cboHora.SelectedIndex = 0;
            }
            txtTempo.Text = cboHora.Text+":"+txtMinuto.Text+":"+txtSegundo.Text;
        }

        private void frmAudioVisuais_Load(object sender, EventArgs e)
        {
            CarregaNomeSala();
            pbImagem.Image = Properties.Resources.AUDIO_VISUAL;
            cboHora.SelectedIndex = 0;
            Limpa();

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                //OleDbCommand cmd = null;
                //OleDbConnection con = null;
                con = Conexao.Conectando.AbrirConexao();
                con.Open();
                string SQL = "insert into TBAudioVisuais (Titulo, TipoObra, Material, Autor, Duracao, Tempo, Assunto, Realizador, Datarealizacao, Actores, Descricao, Lingua, Localizacao, Estado, Attach)"+
                "values('" +txtTitulo.Text + "','" + cboTipoObra.Text + "','" + cboMaterial.Text+ "','" + txtAutor.Text + "','" + cboDuracao.Text + "','" + txtTempo.Text + "','" + txtAssunto.Text + "','" + txtRealizador.Text + "','" + dtpDataActual.Value.ToString() + "','" + txtActores.Text + "','" + txtDescricao.Text + "','"+txtLingua.Text+"','"+cboNomeSala.Text+"','"+cboEstado.Text+"', @photo);";
                cmd = new OleDbCommand(SQL, con);
                conv_photo();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registo Gravado com sucesso");
                    //Minhas_Classes.VariaveisEstaticas.ComandoSQL = SQL;
                    //Minhas_Classes.VariaveisEstaticas.Operacao = "Registou Fotografias e Objectos de Arte";

                    Modelos.Movimentos MMov = new Modelos.Movimentos();
                    MMov.IDU = Convert.ToString(Minhas_Classes.VariaveisEstaticas.IdUsuario);
                    MMov.Operacao = "Registou AudioVisuais";
                    MMov.Descricao = "insert into TBAudioVisuais (Titulo, TipoObra, Material, Autor, Duracao, Tempo, Assunto, Realizador, Datarealizacao, Actores, Descricao, Lingua, Localizacao, Estado, Attach)";
                    MMov.Data = System.DateTime.Now.ToString();
                    Controladores.ControladorMovimentos.Salvar(MMov);
                    Limpa();

                }
                else
                    MessageBox.Show("Inserção falhou");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro 1" + ex.Message);
            }
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa();
        }

        private void pbImagem_Click(object sender, EventArgs e)
        {

        }
    }
}

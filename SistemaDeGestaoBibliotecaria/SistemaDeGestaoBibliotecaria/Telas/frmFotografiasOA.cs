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
    public partial class frmFotografiasOA : Form
    {
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

        //void loaddata()
        //{
        //    adapter = new OleDbDataAdapter("select * from TBObjectosArte", con);
        //    ds = new DataSet();//student-> table name in stud.accdb/stud.mdb file
        //    adapter.Fill(ds, "TBObjectosArte");
        //    // ds.Tables[0].Constraints.Add("pk_sno", ds.Tables[0].Columns[0], true);//creating primary key for Tables[0] in dataset
        //}
        private void CarregaObra()
        {
            OleDbConnection con = null;
            OleDbCommand cmd = null;
            OleDbDataReader Dreader = null;

            try
            {
                con = Conexao.Conectando.AbrirConexao();
                con.Open();
                string SQL = "Select * From TBObjectosArte Order By IDFOA Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                if (Dreader.Read())
                {
                    txtCodigo.Text = Dreader["IDFOA"].ToString();
                    //   txtNome.Text = Dreader["Nome"].ToString();
                    //MessageBox.Show("O codigo é: "+Convert.ToInt32(Convert.ToInt32(txtCodigoLeitor.Text)+1));
                    txtCodigo.Text = Convert.ToString(Convert.ToInt32(Convert.ToInt32(txtCodigo.Text) + 1));
                    txtCodigoObra.Text = "FOA" + txtCodigo.Text;
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

        private void Limpa()
        {
            cboTipoObra.SelectedIndex = -1;
            cboMaterial.SelectedIndex = -1;
            cboPosicao.SelectedIndex = -1;
            cboNomeSala.SelectedIndex = -1;
            cboEstado.SelectedIndex = 0;
            txtAutor.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtDimensões.Text = string.Empty;
            txtProveniencia.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            CarregaObra();
            pbImagem.Image = Properties.Resources.FOTOGRAFIAS_E_OBRAS_DE_ARTE;
        }
        public frmFotografiasOA()
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

        private void btnSalva_Click(object sender, EventArgs e)
        {
            //if (pictureBox1.Image != null)
            //{
                try
                {
                    //OleDbCommand cmd = null;
                    //OleDbConnection con = null;
                    con = Conexao.Conectando.AbrirConexao();
                    con.Open();
                    string SQL = "insert into TBObjectosArte (CodigoObra, Autor, Tipo, Material, Dimensoes, Proveniencia, Tema, Museu, Posicao, Descricao,Estado, Attach) values('" + txtCodigoObra.Text + "','" + txtAutor.Text + "','" + cboTipoObra.Text + "','" + cboMaterial.Text + "','" + txtDimensões.Text + "','" + txtProveniencia.Text + "','" + txtTitulo.Text + "','" + cboNomeSala.Text + "','" + cboPosicao.Text + "','" + txtDescricao.Text + "','"+cboEstado.Text+"', @photo);";
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
                        MMov.Operacao = "Registou Fotografias e Objectos de Arte";
                        MMov.Descricao = "insert into TBObjectosArte (CodigoObra, Autor, Tipo, Material, Dimensoes, Proveniencia, Tema, Museu, Posicao, Descricao,Estado, Attach)";
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
            //}
            //else
            //{
                //try
                //{
                //    OleDbCommand cmd = null;
                //    OleDbConnection con = null;

                //    con = Conexao.Conectando.AbrirConexao();
                //    con.Open();
                //    string SQL = "insert into TBObjectosArte (CodigoObra, Autor, Tipo, Material, Dimensoes, Proveniencia, Tema, Museu, Posicao, Descricao,) values('" + txtCodigoObra.Text + "','" + txtAutor.Text + "','" + cboTipoObra.Text + "','" + cboMaterial.Text + "','" + txtDimensões.Text + "','" + txtProveniencia.Text + "','" + txtTitulo.Text + "','" + cboNomeSala.Text + "','" + cboPosicao.Text + "','" + txtDescricao.Text + "');";
                //    cmd = new OleDbCommand(SQL, con);
                //    conv_photo();
                //    int i = cmd.ExecuteNonQuery();
                //    if (i > 0)
                //    {
                //        MessageBox.Show("Registo Gravado com sucesso");
                //    }
                //    else
                //        MessageBox.Show("Inserção falhou");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Erro 2" + ex.Message);
                //}
           // }
        }

        private void btnCarregaFoto_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Image File (*.jpg;*.bmp;*.png;*.gif)|*.jpg;*.bmp;*.png;*.gif";
            //openFileDialog1.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
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
                    MessageBox.Show("Erro: "+ex.Message);
                }
            }
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            CarregaNomeSala();
        }

        private void frmFotografiasOA_Load(object sender, EventArgs e)
        {
            //con = Conexao.Conectando.AbrirConexao();
            //cmd =  null;
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            con = Conexao.Conectando.AbrirConexao();
            // CarregaObra();
            Limpa();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa();
            //CarregaObra();
        }

        private void cboPosicao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

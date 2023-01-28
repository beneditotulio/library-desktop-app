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
using Microsoft.VisualBasic;

namespace SistemaDeGestaoBibliotecaria.Telas
{
    public partial class frmLeitor : Form
    {
        //public OleDbCommand cmd = null;
        //public OleDbConnection con = null;
        //public OleDbDataReader Dreader = null;
        
        public frmLeitor()
        {
            InitializeComponent();
        }
        public string IDLeitor { get; set; }

        private void Limpa()
        {
            txtCodigoLeitor.Text = "";
            txtNome.Text = string.Empty;
            cboSexo.SelectedIndex = -1;
            txtNumeroDoc.Text = string.Empty;
            cboTipoDoc.SelectedIndex = -1;
            txtMorada.Text = string.Empty;
            txtContacto1.Text = string.Empty;
            txtContacto2.Text = string.Empty;
            txtEmail.Text = string.Empty;
            CarregaLeitor();

            btnSalva.Enabled = true;
            btnEdita.Enabled = false;
            btnApaga.Enabled = false;

        }
        public void Pesquisa(string busca)
        {

            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;
            if (busca == string.Empty)
            {
                MessageBox.Show("Por favor informe o nome do Leitor");
            }
            else
            {
                try
                {
                    con = Conexao.Conectando.AbrirConexao();
                    con.Open();
                    string SQL = "Select * From TBLeitor Where IDLeitor like  '" + busca +"'";
                    cmd = new OleDbCommand(SQL, con);
                    Dreader = cmd.ExecuteReader();
                    if (Dreader.Read())
                    {
                        txtCodigoLeitor.Text = Dreader["IDLeitor"].ToString();
                        txtNome.Text = Dreader["Nome"].ToString();
                        txtNumeroDoc.Text = Dreader["NumeroDoc"].ToString();
                        txtMorada.Text = Dreader["Morada"].ToString();
                        txtContacto1.Text = Dreader["Contacto1"].ToString();
                        txtContacto2.Text = Dreader["Contacto2"].ToString();
                        txtEmail.Text = Dreader["Email"].ToString();
                        cboSexo.Text = Dreader["Sexo"].ToString();
                        cboTipoDoc.Text = Dreader["TipoDoc"].ToString();

                        //con.Close();
                        //con.Open();
                        //string SQlSexo = "Select * From Sexo Where IdSexo = '" + C.Sexo + "'";
                        //cmd = new SqlCommand(SQlSexo, con);
                        //Dreader = cmd.ExecuteReader();
                        //if (Dreader.Read())
                        //{
                        //    cboSexo.Text = Dreader["Descricao"].ToString();
                        //}

                        //con.Close();
                        //con.Open();
                        //string SQlDoc = "Select * From TipoDoc Where IdTipoDoc = '" + C.TipoDoc + "'";
                        //cmd = new SqlCommand(SQlDoc, con);
                        //Dreader = cmd.ExecuteReader();
                        //if (Dreader.Read())
                        //{
                        //    cboTipoDoc.Text = Dreader["DescricaoDoc"].ToString();
                        //}

                        btnSalva.Enabled = false;
                        btnEdita.Enabled = true;
                        btnApaga.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Registo nao encontrado!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nao foi possivel gravar o registo. Por favor tente novamente.\n" + ex.Message);
                }
                finally
                {
                    //Limpa();
                    con.Close();

                }
            }
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
                string SQL = "Select * From TBLeitor Order By IDLeitor Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                if (Dreader.Read())
                {
                    txtCodigoLeitor.Text = Dreader["IDLeitor"].ToString();
                    //   txtNome.Text = Dreader["Nome"].ToString();
                    //MessageBox.Show("O codigo é: "+Convert.ToInt32(Convert.ToInt32(txtCodigoLeitor.Text)+1));
                    txtCodigoLeitor.Text = Convert.ToString(Convert.ToInt32(Convert.ToInt32(txtCodigoLeitor.Text) + 1));
                }
                else 
                {
                    txtCodigoLeitor.Text = "1";
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

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void frmLeitor_Load(object sender, EventArgs e)
        {
            //CarregaLeitor();
            string Busca;
            Limpa();
            Busca = IDLeitor;
            //Busca = Minhas_Classes.VariaveisEstaticas.IDLeitor;
            //MessageBox.Show(Minhas_Classes.VariaveisEstaticas.IDLeitor);
            MessageBox.Show(Busca);

            if (Busca != null)
            {
                Pesquisa(Busca);
            }

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if(txtNumeroDoc.Text == string.Empty)
            {
                txtNumeroDoc.Focus();
            }
               else if(txtNome.Text == string.Empty)
                {
                    txtNome.Focus();
                }
            else
            {
            Modelos.Leitor Leitor = new Modelos.Leitor();

            Leitor.Nome = txtNome.Text;
            Leitor.TipoDoc = cboTipoDoc.Text;
            Leitor.NumeroDoc = txtNumeroDoc.Text;
            Leitor.Sexo = cboSexo.Text;
            Leitor.Morada = txtMorada.Text;
            Leitor.Contacto = txtContacto1.Text;
            Leitor.Contacto1 = txtContacto2.Text;
            Leitor.Email = txtEmail.Text;

            Controladores.ControladorLeitor.Salvar(Leitor);

            Limpa();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listagens.FrmLeitor IP = new Listagens.FrmLeitor();
            IP.ShowDialog();
        }

        private void btnEdita_Click(object sender, EventArgs e)
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
                Modelos.Leitor Leitor = new Modelos.Leitor();

                Leitor.IDLeitor = int.Parse(txtCodigoLeitor.Text);
                Leitor.Nome = txtNome.Text;
                Leitor.TipoDoc = cboTipoDoc.Text;
                Leitor.NumeroDoc = txtNumeroDoc.Text;
                Leitor.Sexo = cboSexo.Text;
                Leitor.Morada = txtMorada.Text;
                Leitor.Contacto = txtContacto1.Text;
                Leitor.Contacto1 = txtContacto2.Text;
                Leitor.Email = txtEmail.Text;

                Controladores.ControladorLeitor.Editar(Leitor);

                Limpa();
            }
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
           DialogResult  Resultado = MessageBox.Show("Tem certeza que deseja Eliminar o Registo?","",MessageBoxButtons.YesNo);
            if (Resultado == DialogResult.No)
            {
                txtNome.Focus();
            }
            else
            {
                Modelos.Leitor Leitor = new Modelos.Leitor();
                Leitor.IDLeitor = int.Parse(txtCodigoLeitor.Text);
                Leitor.Nome = txtNome.Text;
                Leitor.TipoDoc = cboTipoDoc.Text;
                Leitor.NumeroDoc = txtNumeroDoc.Text;
                Leitor.Sexo = cboSexo.Text;
                Leitor.Morada = txtMorada.Text;
                Leitor.Contacto = txtContacto1.Text;
                Leitor.Contacto1 = txtContacto2.Text;
                Leitor.Email = txtEmail.Text;

                Controladores.ControladorLeitor.Eliminar(Leitor);

                Limpa();
            }
        }

        private void gpbLeitor_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

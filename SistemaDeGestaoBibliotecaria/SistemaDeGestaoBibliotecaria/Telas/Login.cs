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
using System.Threading;


namespace SistemaDeGestaoBibliotecaria.Telas
{
    public partial class Login : Form
    {
        Thread t1;

        public Login()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(object obj)
        {
            // Application.Run(new MenuPrincipal());
            Application.Run(new Telas.frmMenuPrincipal());
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtNomeUsuario.Text == string.Empty)
            {
                MessageBox.Show("O nome de usuario nao pode estar vazio");
                txtNomeUsuario.Focus();
            }
            else
            {
                OleDbCommand cmd = null;
                OleDbConnection con = null;
                OleDbDataReader Dreader = null;

                con = Conexao.Conectando.AbrirConexao();
                con.Open();
                string SQL = "Select * From TBFuncionario Where usuario not in (Select usuario From TBFuncionario Where usuario = '" + string.Empty + "')  and usuario like '" + txtNomeUsuario.Text + "' and senha like '" + txtSenha.Text + "'";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                if (Dreader.Read())
                {
                    //this.Visible = false;
                    // Minhas_Classes.VariaveisEstaticas.NomeUsuario = Dreader["usuario"].ToString();
                   // Minhas_Classes.VariaveisEstaticas.IdFuncionario = Convert.ToInt32(Dreader["IdFunc"].ToString());
                    Minhas_Classes.VariaveisEstaticas.IdUsuario = Convert.ToInt32(Dreader["IdFuncionario"].ToString());
                  //  Minhas_Classes.VariaveisEstaticas.NomeFuncionario = Dreader["Nome"].ToString() + " " + Dreader["Apelido"].ToString();
                    Minhas_Classes.VariaveisEstaticas.NomeUsuario = Dreader["Nome"].ToString();
                    //Minhas_Classes.VariaveisEstaticas.Profissao = Dreader["Profissao"].ToString();
                    string permissao = Dreader["permissao"].ToString();

                    if (permissao == "0")
                    {
                        MessageBox.Show("Sem permissao para aceder o sistema.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {


                        MessageBox.Show("Autenticaçao bem sucedida!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                            this.Close();
                            t1 = new Thread(AbrirFormulario);
                            t1.SetApartmentState(ApartmentState.STA);
                            t1.Start();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Erro de autenticação! SENHA ou USUARIO INCORRECTO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Text = string.Empty;
                    txtSenha.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Telas.Definicoes IP = new Definicoes();
            IP.ShowDialog();
        }

        private void BtnHideShow_Click(object sender, EventArgs e)
        {
            if(txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }
    }
}

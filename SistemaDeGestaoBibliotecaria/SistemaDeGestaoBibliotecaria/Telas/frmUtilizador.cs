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
    public partial class frmUtilizador : Form
    {
        public frmUtilizador()
        {
            InitializeComponent();
        }
        string permissao = "0";
        private void Actualizar()
        {

            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;

            con = Conexao.Conectando.AbrirConexao();
            con.Open();
            string SQL = "Select * From TBFuncionario Where IDFuncionario like '" + Minhas_Classes.VariaveisEstaticas.IdFuncionario + "'";
            cmd = new OleDbCommand(SQL, con);
            Dreader = cmd.ExecuteReader();
            if (Dreader.Read())
            {
                txtNomeUsuario.Text = Dreader["usuario"].ToString();
                txtSenha.Text = Dreader["senha"].ToString();
                txtSenhaConfirmacao.Text = txtSenha.Text;
                permissao = Dreader["permissao"].ToString();


                if (permissao == "0")
                {
                    chBPermissao.Checked = false;
                }
                else
                {
                    chBPermissao.Checked = true;
                }
            }

        }
        private void btnEdita_Click(object sender, EventArgs e)
        {

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtSenhaConfirmacao.Text)
            {
                MessageBox.Show("As senhas nao coincidem");
                txtSenha.Focus();
            }
            else
            {
                OleDbCommand cmd = null;
                OleDbConnection con = null;
                try
                {
                    con = Conexao.Conectando.AbrirConexao();
                    con.Open();
                    string SQL = "Update TBFuncionario Set usuario = '" + txtNomeUsuario.Text + "', Senha = '" + txtSenha.Text + "', Permissao = '" + permissao + "' Where IDFuncionario like '" + Minhas_Classes.VariaveisEstaticas.IdFuncionario + "'";
                    cmd = new OleDbCommand(SQL, con);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registo actualizado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar estabelecer conexao com o servidor\n" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void chBPermissao_CheckedChanged(object sender, EventArgs e)
        {
            if (chBPermissao.Checked == true)
            {
                chBPermissao.Text = "SIM";
                permissao = "1";
            }
            else
            {
                chBPermissao.Text = "NÃO";
                permissao = "0";
            }
        }

        private void frmUtilizador_Load(object sender, EventArgs e)
        {
            Actualizar();
            txtFuncionario.Text = Minhas_Classes.VariaveisEstaticas.NomeFuncionario.ToUpper();
            txtProfissao.Text = Minhas_Classes.VariaveisEstaticas.Profissao;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}

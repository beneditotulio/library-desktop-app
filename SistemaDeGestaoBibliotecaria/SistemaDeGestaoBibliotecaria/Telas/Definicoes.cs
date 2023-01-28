using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestaoBibliotecaria.Telas
{
    public partial class Definicoes : Form
    {
        public Definicoes()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" & txtSenha.Text == "12345")
            {
                MessageBox.Show("Autenticação bem sucedida");

                //Telas.frmMenuRelatorio IP = new frmMenuRelatorio();
                //IP.ShowDialog();
                frmConexaoBD IP = new frmConexaoBD();
                IP.ShowDialog();
            }
            else
            {
                txtSenha.Text = string.Empty;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Definicoes_Load(object sender, EventArgs e)
        {

        }
    }
}

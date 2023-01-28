using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestaoBibliotecaria
{
    public partial class frmConexaoBD : Form
    {
        public frmConexaoBD()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CaminhoBD = txtCaminho.Text;
            Properties.Settings.Default.Save();
        }

        private void btnApresentar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("O nome da BD é: " + Properties.Settings.Default.NomeBanco);
            MessageBox.Show("O Caminho da BD é: " + Properties.Settings.Default.CaminhoBD);
           // txtNomeBD.Text = Properties.Settings.Default.NomeBanco;
            txtCaminho.Text = Properties.Settings.Default.CaminhoBD;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtCaminho.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro"+ex.Message);
                }
            }

        }
    }
}

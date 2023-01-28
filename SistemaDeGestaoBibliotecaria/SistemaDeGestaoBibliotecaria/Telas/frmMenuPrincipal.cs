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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelMove.Height = btnInicio.Height;
            panelMove.Top = btnInicio.Top;
            Telas.frmMenuInicio Tulio = new Telas.frmMenuInicio();
            Tulio.Location = new Point(235,99);
            Tulio.ShowDialog();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            panelMove.Height = btnCadastro.Height;
            panelMove.Top = btnCadastro.Top;
            Telas.frmCadastro Tulio = new Telas.frmCadastro();
            Tulio.Location = new Point(235,99);
            Tulio.ShowDialog();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Estamos actualmente trabalhando nos RELATÓRIOS, por favor aguarde.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            panelMove.Height = btnLista.Height;
            panelMove.Top = btnLista.Top;
            Telas.frmMenuListagem Tulio = new Telas.frmMenuListagem();
            Tulio.Location = new Point(235,99);
            //Tulio.Location = new Point(235,99);
            Tulio.ShowDialog();
           
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            panelMove.Height = btnParametrizacao.Height;
            panelMove.Top = btnParametrizacao.Top;
            Telas.frmMenuRelatorio Tulio = new Telas.frmMenuRelatorio();
            Tulio.Location = new Point(235, 99);
            Tulio.ShowDialog();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            panelMove.Height = btnAjuda.Height;
            panelMove.Top = btnAjuda.Top;
            Telas.frmMenuAjuda Tulio = new Telas.frmMenuAjuda();   
            Tulio.Location = new Point(235,99);
            Tulio.ShowDialog();
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja terminar sessão?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult==DialogResult.Yes)
            {
                Minhas_Classes.VariaveisEstaticas.Operacao = "Terminou sessao";
                Application.Exit();
            }
            else
            {

            }
            
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            btnUtilizador.Text = "UTILIZADOR: " + Minhas_Classes.VariaveisEstaticas.NomeUsuario;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

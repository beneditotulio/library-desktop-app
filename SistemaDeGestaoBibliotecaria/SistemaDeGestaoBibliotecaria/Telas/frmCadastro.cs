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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTerminaSessao_Click(object sender, EventArgs e)
        {
            Telas.frmFuncionario KM = new Telas.frmFuncionario();
            KM.ShowDialog();
        }

        private void btnFotoTerminarSessao_Click(object sender, EventArgs e)
        {
            Telas.frmFuncionario km = new Telas.frmFuncionario();
            km.ShowDialog();
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            Telas.frmLivro KM = new Telas.frmLivro();
            KM.ShowDialog();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            //Telas.frmAutor KM = new Telas.frmAutor();
            //KM.ShowDialog();
            frmBr IP = new frmBr();
            IP.ShowDialog();
        }

        private void btnLeitor_Click(object sender, EventArgs e)
        {
            FrmEmprestimo IP = new FrmEmprestimo();
            IP.ShowDialog();
            //Telas.frmLeitor KM = new Telas.frmLeitor();
            //KM.ShowDialog();
            //Telas.frmFotografiasOA IP = new frmFotografiasOA();
            //IP.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmLeitor frmLeitor = new frmLeitor();
            frmLeitor.ShowDialog();
            //FrmEmprestimo IP = new FrmEmprestimo();
            //IP.ShowDialog();
            //frmAudioVisuais IP = new frmAudioVisuais();
            //IP.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEmprestimo IP = new FrmEmprestimo();
            IP.ShowDialog();
        }

        private void btnAddOferta_Click(object sender, EventArgs e)
        {
            frmOfertas IP = new frmOfertas();
            IP.ShowDialog();
        }

        private void btnAddExposicao_Click(object sender, EventArgs e)
        {
            frmExposicoes IP = new frmExposicoes();
            IP.ShowDialog();
        }

        private void BtnFotoLeitor_Click(object sender, EventArgs e)
        {

        }
    }
}

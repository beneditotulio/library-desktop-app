using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGLViatura_Carheaven;
namespace SistemaDeGestaoBibliotecaria.Telas
{
    public partial class frmMenuListagem : Form
    {
        public frmMenuListagem()
        {
            InitializeComponent();
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            SGLViatura_Carheaven.Listagens.FrmFuncionario IP = new SGLViatura_Carheaven.Listagens.FrmFuncionario();
            IP.ShowDialog();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            //Listagens.FrmAutor IP = new Listagens.FrmAutor();
            //IP.ShowDialog();
            Listagens.FrmBR IP = new Listagens.FrmBR();
            IP.ShowDialog();
        }

        private void btnLeitor_Click(object sender, EventArgs e)
        {
            Listagens.FrmLeitor IP = new Listagens.FrmLeitor();
            IP.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listagens.FrmEmprestimo emprestimo = new Listagens.FrmEmprestimo();
            emprestimo.ShowDialog();
            //Listagens.FrmEmprestimo IP = new Listagens.FrmEmprestimo();
            //IP.ShowDialog();
           // MessageBox.Show("Estamos actualmente trabalhando nos RELATÓRIOS, por favor aguarde.");
            //Listagens.FrmAudioVisuais IP = new Listagens.FrmAudioVisuais();
            //IP.ShowDialog();
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            Listagens.FrmLivro IP = new Listagens.FrmLivro();
            IP.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Estamos actualmente trabalhando nos RELATÓRIOS, por favor aguarde.");
        }

        private void btnLeitor_Click_1(object sender, EventArgs e)
        {
            //Listagens.FrmFOA IP = new Listagens.FrmFOA();
            //IP.ShowDialog();
            Listagens.FrmLeitor frm = new Listagens.FrmLeitor();
            frm.ShowDialog();
            //MessageBox.Show("Estamos actualmente trabalhando nos RELATÓRIOS, por favor aguarde.");
        }

        private void btnFotoLeitor_Click(object sender, EventArgs e)
        {
            frmLeitor frm = new frmLeitor();
            frm.ShowDialog();
            //MessageBox.Show("Estamos actualmente trabalhando nos RELATÓRIOS, por favor aguarde.");
        }

        private void btnAddOferta_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Estamos actualmente trabalhando nos RELATÓRIOS, por favor aguarde.");
            Listagens.FrmOfertas IP = new Listagens.FrmOfertas();
            IP.ShowDialog();
        }

        private void btnOferta_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Estamos actualmente trabalhando nos RELATÓRIOS, por favor aguarde.");
        }

        private void btnExposicao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos actualmente trabalhando nos RELATÓRIOS, por favor aguarde.");
        }

        private void btnAddExposicao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos actualmente trabalhando nos RELATÓRIOS, por favor aguarde.");
        }

        private void btnAddBR_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuListagem_Load(object sender, EventArgs e)
        {

        }

        private void BtnFotoLivro_Click(object sender, EventArgs e)
        {

        }
    }
}

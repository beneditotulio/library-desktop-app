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
    public partial class frmMenuRelatorio : Form
    {
        public frmMenuRelatorio()
        {
            InitializeComponent();
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTerminaSessao_Click(object sender, EventArgs e)
        {
            //frmConexaoBD IP = new frmConexaoBD();
            //IP.ShowDialog();
            frmFuncionario IP = new frmFuncionario();
            IP.Show();
        }

        private void btnFotoTerminarSessao_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Telas.frmAutor KM = new Telas.frmAutor();
            KM.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Telas.Definicoes IP = new Definicoes();
            IP.ShowDialog();
        }

        private void btnDefinicoes_Click(object sender, EventArgs e)
        {
            Telas.Definicoes IP = new Definicoes();
            IP.ShowDialog();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            frmLocal IP = new frmLocal();
            IP.ShowDialog();
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            frmNomeSala IP = new frmNomeSala();
            IP.ShowDialog();
        }

        private void frmMenuRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Listagens.FrmMovimentos IP = new Listagens.FrmMovimentos();
            IP.ShowDialog();
        }

        private void btnProfissao_Click(object sender, EventArgs e)
        {
            frmProfissao p = new frmProfissao();
            p.ShowDialog();
        }

        private void btnEstadoCivil_Click(object sender, EventArgs e)
        {
            frmEstadoCivil frmEstadoCivil = new frmEstadoCivil();
            frmEstadoCivil.ShowDialog();
        }

        private void btnTipoDoc_Click(object sender, EventArgs e)
        {
            frmTipoDoc frmTipoDoc = new frmTipoDoc();
            frmTipoDoc.ShowDialog();
        }
    }
}

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
    public partial class frmMenuInicio : Form
    {
        public frmMenuInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            Telas.frmFuncionario KM = new Telas.frmFuncionario();
            KM.ShowDialog();
        }

        private void btnFuncuinario_Click(object sender, EventArgs e)
        {
            Telas.frmFuncionario KM = new Telas.frmFuncionario();
            KM.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFotoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTerminaSessao_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnDefinicoes_Click(object sender, EventArgs e)
        {
            Telas.Definicoes IP = new Definicoes();
            IP.ShowDialog();
            
        }

        private void btnFotoDefinicoes_Click(object sender, EventArgs e)
        {
            Telas.Definicoes IP = new Definicoes();
            IP.ShowDialog();
        }
    }
}

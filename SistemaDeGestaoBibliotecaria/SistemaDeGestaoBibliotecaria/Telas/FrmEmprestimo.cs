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
    public partial class FrmEmprestimo : Form
    {
        public FrmEmprestimo()
        {
            InitializeComponent();
        }
        public int ID;

        private void Limpa()
        {
            txtCodigo.Text = "";
            Minhas_Classes.VariaveisEstaticas.Leitor = null;
            Minhas_Classes.VariaveisEstaticas.Livro = null;
            cboDevolucao.Text = "NÃO";
            CarregaEmprestimo();
        }
        private void CarregaEmprestimo()
        {
            OleDbConnection con = null;
            OleDbCommand cmd = null;
            OleDbDataReader Dreader = null;

            try
            {
                con = Conexao.Conectando.AbrirConexao();
                con.Open();
                string SQL = "Select * From TBEmprestimo Order By IDEmprestimo Desc";
                cmd = new OleDbCommand(SQL, con);
                Dreader = cmd.ExecuteReader();
                if (Dreader.Read())
                {
                    txtCodigo.Text = Dreader["IDEmprestimo"].ToString();
                    //   txtNome.Text = Dreader["Nome"].ToString();
                    //MessageBox.Show("O codigo é: "+Convert.ToInt32(Convert.ToInt32(txtCodigoLeitor.Text)+1));
                    txtCodigo.Text = Convert.ToString(Convert.ToInt32(Convert.ToInt32(txtCodigo.Text) + 1));
                }
                else
                {
                    txtCodigo.Text = "1";
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

        private void btnLeitor_Click(object sender, EventArgs e)
        {
            Listagens.FrmLeitor IP = new Listagens.FrmLeitor();
            IP.ShowDialog();
        }

        private void FrmEmprestimo_MouseHover(object sender, EventArgs e)
        {
            txtLeitor.Text = Minhas_Classes.VariaveisEstaticas.Leitor;
            txtLivro.Text = Minhas_Classes.VariaveisEstaticas.Livro;
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            Listagens.FrmLivro IP = new Listagens.FrmLivro();
            IP.ShowDialog();
        }

        private void FrmEmprestimo_Load(object sender, EventArgs e)
        {
            cboDevolucao.Text = "NÃO";
            CarregaEmprestimo();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(dgvEmprestimo.RowCount.ToString());
            if (count > 1)
            {
                MessageBox.Show("Infelizmente só pode efectuar o emprestimo de 2 livros");
            }
            else
            {
            ID = dgvEmprestimo.Rows.Count;
           // dgvEmprestimo.Rows.Add(Convert.ToInt32(ID + 1).ToString(), txtLeitor.Text, txtLivro.Text,  System.DateTime.Now ,dtpDataInicio.Value.ToString().Substring(0, 11) + dtpHoraInicio.Text, dtpDataFim.Value.ToString().Substring(0, 11) + dtpHoraFim.Text, cboDevolucao.Text);
            dgvEmprestimo.Rows.Add(Convert.ToInt32(ID + 1).ToString(), txtLeitor.Text, txtLivro.Text, System.DateTime.Now, dtpDataInicio.Value.ToString().Substring(0, 11) + dtpHoraInicio.Text, "", cboDevolucao.Text);
            }

        }

        private void FrmEmprestimo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dgvEmprestimo.Rows.Count > 0)
            {
                btnCancelar.Visible = true;
            }
            else
            {
                btnCancelar.Visible = false;
            }


            //Alterando txtNrHoras para 1
            if (txtLeitor.Text == "" | txtLivro.Text == string.Empty | cboDevolucao.Text == string.Empty)
            {
                btnAdicionar.Enabled = false;
            }
            else
            {
                btnAdicionar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvEmprestimo.Rows.Count > 0)
            {
                btnCancelar.Visible = true;

                dgvEmprestimo.Rows.Remove(dgvEmprestimo.CurrentRow);
                
            }
            else
            {
                btnCancelar.Visible = false;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa();
        }

        private void dgvEmprestimo_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtLeitor.Text = Minhas_Classes.VariaveisEstaticas.Leitor;
            txtLivro.Text = Minhas_Classes.VariaveisEstaticas.Livro;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            Modelos.Emprestimo EMPRESTIMO = new Modelos.Emprestimo();
            
            if (dgvEmprestimo.Rows.Count == 0)
            { MessageBox.Show("Por favor efectue pelo menos um EMPRESTIMO"); }
            else
            {

                //INSERIR EMPRESTIMO


                for (int i = 0; i <= dgvEmprestimo.RowCount - 1; i += 1)
                {
                    dgvEmprestimo.Rows[i].Selected = true;
                   // MessageBox.Show(i.ToString());
                    //MessageBox.Show(dgvDetalhesReserva.Rows[i].Cells[0].Value.ToString() + " " + dgvDetalhesReserva.Rows[i].Cells[1].Value.ToString() + " " + dgvDetalhesReserva.Rows[i].Cells[2].Value.ToString() + " " + dgvDetalhesReserva.Rows[i].Cells[3].Value.ToString());


                    //ATRIBUINDO VALORES AO MODELO EMPRESTIMO

                    EMPRESTIMO.Leitor = dgvEmprestimo.Rows[i].Cells[1].Value.ToString();
                    EMPRESTIMO.Livro = dgvEmprestimo.Rows[i].Cells[2].Value.ToString();
                    EMPRESTIMO.DataRetirada = dgvEmprestimo.Rows[i].Cells[3].Value.ToString();
                    EMPRESTIMO.DataEntrega = dgvEmprestimo.Rows[i].Cells[4].Value.ToString();
                    EMPRESTIMO.DataDevolucao = dgvEmprestimo.Rows[i].Cells[5].Value.ToString();
                    EMPRESTIMO.Devolucao = dgvEmprestimo.Rows[i].Cells[6].Value.ToString();

                    Controladores.ControladorEmprestimo.Salvar(EMPRESTIMO);
                    Limpa();
                    //dgvDetalhesReserva.Rows[i].Selected = false;
                }
            }
        }
    }
}

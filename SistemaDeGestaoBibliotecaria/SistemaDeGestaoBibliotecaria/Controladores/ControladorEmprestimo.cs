using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaDeGestaoBibliotecaria.Controladores
{
    class ControladorEmprestimo
    {
        public static void Salvar(Modelos.Emprestimo MEmprestimo)
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;

            con = Conexao.Conectando.AbrirConexao();
            con.Open();

            try
            {
                string SQL = "Insert Into TBEmprestimo(Leitor, Livro, DataRetirada, DataEntrega,DataDevolucao, Devolucao) Values('" + MEmprestimo.Leitor + "','" + MEmprestimo.Livro + "','" + MEmprestimo.DataRetirada + "','" + MEmprestimo.DataEntrega + "','" + MEmprestimo.DataDevolucao + "','" + MEmprestimo.Devolucao + "');";
                cmd = new OleDbCommand(SQL, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { MessageBox.Show("Registo Gravado com sucesso"); }
            }
            catch (Exception ex)
            { MessageBox.Show("Erro! Não foi possível estabelecer a conexão com a Base de Dados."); }
            finally { con.Close(); }
        }
    }
}

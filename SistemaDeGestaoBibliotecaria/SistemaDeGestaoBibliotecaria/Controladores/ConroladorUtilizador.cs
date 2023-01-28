using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaDeGestaoBibliotecaria.Controladores
{
    class ConroladorUtilizador
    {
        public static void Salvar(Modelos.Utilizador MUtilizador)
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;

            con = Conexao.Conectando.AbrirConexao();
            con.Open();

            try
            {
               //Minhas_Classes.VariaveisEstaticas.ComandoSQL = SQL;
               //Minhas_Classes.VariaveisEstaticas.Operacao = "Iniciou sessao";

                string SQL = "Insert Into TBMovimentos(IDU, Operacao, Descricao, Data) Values('" +MUtilizador.IDU +"','" +MUtilizador.Operacao +"','" +MUtilizador.Descricao +"','" + MUtilizador.Data+"');";
                cmd = new OleDbCommand(SQL, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registo Gravado com sucesso");
                    
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Erro! Não foi possível estabelecer a conexão com a Base de Dados."); }
            finally { con.Close(); }
        }
    
    }
}

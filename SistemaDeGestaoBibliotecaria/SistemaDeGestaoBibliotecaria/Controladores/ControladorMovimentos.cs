using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaDeGestaoBibliotecaria.Controladores
{
    class ControladorMovimentos
    {
        public static void Salvar(Modelos.Movimentos MMovimentos)
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

                string SQL = "Insert Into TBMovimentos(IDU, Operacao, Descricao, Data) Values('" + MMovimentos.IDU + "','" + MMovimentos.Operacao + "','" + MMovimentos.Descricao + "','" + MMovimentos.Data + "');";
                cmd = new OleDbCommand(SQL, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                   // MessageBox.Show("Registo Gravado com sucesso");

                }
            }
            catch (Exception ex)
            { MessageBox.Show("Erro! Não foi possível estabelecer a conexão com a Base de Dados."+ex.Message); }
            finally { con.Close(); }
        }
    }
}

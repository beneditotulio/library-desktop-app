using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaDeGestaoBibliotecaria.Controladores
{
    class ControladorLivro
    {
        public static void Salvar(Modelos.Livro MLivro)
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;

            con = Conexao.Conectando.AbrirConexao();
            con.Open();

            try
            {
                string SQL = "Insert Into TBLivro(Titulo, Edicao, Ano, ISBN, Localizacao, Assunto, Classificacao, Autor, Resenha, Editora, Estado, Lingua, DataEdicao, NrPag, TipoPag, TipoCapa, Copyright, Tipo, NomeSala) Values('" + MLivro.Titulo + "', '" + MLivro.Edicao + "', '" + MLivro.Ano + "','" + MLivro.ISBN + "', '"+MLivro.Localizacao+"', '"+MLivro.Assunto+"', '"+MLivro.Classificacao+"', '"+MLivro.Autor+"', '"+MLivro.Descricao+"', '"+MLivro.Editora+"', '"+MLivro.Estado+"','"+MLivro.Lingua+"','"+MLivro.DataEdicao+"','"+MLivro.NrPag+"','"+MLivro.TipoPag+"','"+MLivro.TipoCapa+"','"+MLivro.Copyright+"','"+MLivro.Tipo+"','"+MLivro.NomeSala+"');";
                cmd = new OleDbCommand(SQL, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { MessageBox.Show("Registo Gravado com sucesso");
                //Minhas_Classes.VariaveisEstaticas.ComandoSQL = SQL;
                //Minhas_Classes.VariaveisEstaticas.Operacao = "Registou Livro";

                Modelos.Movimentos MMov = new Modelos.Movimentos();
                MMov.IDU = Convert.ToString(Minhas_Classes.VariaveisEstaticas.IdUsuario);
                MMov.Operacao = "Registou Livro";
                MMov.Descricao = "Insert Into TBLivro(Titulo, Edicao, Ano, ISBN, Localizacao, Assunto, Classificacao, Autor, Resenha, Editora, Estado, Lingua, DataEdicao, NrPag, TipoPag, TipoCapa, Copyright, Tipo, NomeSala) Values " + MLivro.Titulo;
                MMov.Data = System.DateTime.Now.ToString();
                Controladores.ControladorMovimentos.Salvar(MMov);
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Erro! Não foi possível estabelecer a conexão com a Base de Dados."); }
            finally
            { con.Close(); }
        }
    }
}

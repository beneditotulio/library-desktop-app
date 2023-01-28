using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaDeGestaoBibliotecaria.Controladores
{
    class ControladorAutor
    {
         public static void Salvar(Modelos.Autor MAutor)
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;

            con = Conexao.Conectando.AbrirConexao();
            con.Open();

            try
            {
                string SQL = "Insert Into TBAutor(Nome, Sexo, Contacto, Email) Values('" + MAutor.Nome + "', '" + MAutor.Sexo + "', '" + MAutor.Contacto + "','" + MAutor.Email + "');";
                cmd = new OleDbCommand(SQL, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { MessageBox.Show("Registo Gravado com sucesso"); }
                //Minhas_Classes.VariaveisEstaticas.ComandoSQL = SQL;
                //Minhas_Classes.VariaveisEstaticas.Operacao = "Registou Autor";

                Modelos.Movimentos MMov = new Modelos.Movimentos();
                MMov.IDU = Convert.ToString(Minhas_Classes.VariaveisEstaticas.IdUsuario);
                MMov.Operacao = "Registou Autor";
                MMov.Descricao = "Insert Into TBAutor(Nome, Sexo, Contacto, Email) Values "+MAutor.Nome;
                MMov.Data = System.DateTime.Now.ToString();
                Controladores.ControladorMovimentos.Salvar(MMov);

            }
            catch (Exception ex)
            { MessageBox.Show("Erro! Não foi possível estabelecer a conexão com a Base de Dados."); }
            finally { con.Close(); }
        }
    }
    
}

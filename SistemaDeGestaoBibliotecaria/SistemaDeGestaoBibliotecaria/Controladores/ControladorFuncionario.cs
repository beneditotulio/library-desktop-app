using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaDeGestaoBibliotecaria.Controladores
{
    class ControladorFuncionario
    {
        public static void Salvar(Modelos.Funcionario MFuncionario)
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;

            con = Conexao.Conectando.AbrirConexao();
            con.Open();

            try
            {
                string SQL = "Insert Into TBFuncionario(Nome, TipoDoc, NumeroDoc, Sexo,Morada, Contacto1, Contacto2, Email, EstadoCivil, Profissao) Values('" + MFuncionario.Nome + "','" + MFuncionario.TipoDoc + "','" + MFuncionario.NumeroDoc + "','" + MFuncionario.Sexo + "','" + MFuncionario.Morada + "','" + MFuncionario.Contacto + "','" + MFuncionario.Contacto1 + "','" + MFuncionario.Email + "', '"+MFuncionario.EstadoCivil+"', '"+MFuncionario.Profissao+"');";
                cmd = new OleDbCommand(SQL, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { MessageBox.Show("Registo Gravado com sucesso"); }
                Minhas_Classes.VariaveisEstaticas.ComandoSQL = SQL;
                Minhas_Classes.VariaveisEstaticas.Operacao = "Registou Funcionario";
            }
            catch (Exception ex)
            { MessageBox.Show("Erro! Não foi possível estabelecer a conexão com a Base de Dados."); }
            finally { con.Close(); }
        }
    }
}

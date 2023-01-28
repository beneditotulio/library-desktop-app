using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace SistemaDeGestaoBibliotecaria.Controladores
{
    class ControladorOfertas
    {
        public static void Salvar(Modelos.Ofertas MO)
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;

            con = Conexao.Conectando.AbrirConexao();
            con.Open();

            try
            {
                string SQL = "Insert Into TBOfertas(CodigoObra, Beneficiario, Ano, Descricao, Estado, NomeSala, Nacionalidade, Doador) Values('" + MO.CodigoObra + "','" + MO.Beneficiario + "','" + MO.Ano + "','" + MO.Descricao + "','" + MO.Estado + "','" + MO.NomeSala + "','" + MO.Nacionalidade + "','" + MO.Doador + "');";
                cmd = new OleDbCommand(SQL, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { MessageBox.Show("Registo Gravado com sucesso"); }
                //Minhas_Classes.VariaveisEstaticas.ComandoSQL = SQL;
                //Minhas_Classes.VariaveisEstaticas.Operacao = "Registou Funcionario";
                Modelos.Movimentos MMov = new Modelos.Movimentos();
                MMov.IDU = Convert.ToString(Minhas_Classes.VariaveisEstaticas.IdUsuario);
                MMov.Operacao = "Registou Oferta";
                MMov.Descricao = "Insert Into TBOfertas(CodigoObra, Beneficiario, Ano, Descricao, Estado, NomeSala, Nacionalidade, Doador) Values " + MO.CodigoObra;
                MMov.Data = System.DateTime.Now.ToString();
                Controladores.ControladorMovimentos.Salvar(MMov);
            }
            catch (Exception ex)
            { MessageBox.Show("Erro! Não foi possível estabelecer a conexão com a Base de Dados."); }
            finally { con.Close(); }
        }
    }
}

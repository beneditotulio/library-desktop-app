using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaDeGestaoBibliotecaria.Conexao
{
    class Conectando
    {
        public static OleDbConnection AbrirConexao()
        {
            OleDbConnection con = null;

            try
            {
                //string SQLConexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\IP FILES\Projectos\Projecto Biblioteca\BD Biblioteca\BD_Biblioteca.accdb";
               // string SQLConexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\FILES\BACKUP Mrs Amazing Lenovo\Projecto Biblioteca\Projecto Biblioteca\BD Biblioteca\BD_Biblioteca.accdb";
                string SQLConexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Properties.Settings.Default.CaminhoBD+"";
                
                con = new OleDbConnection(SQLConexao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível estaberecer a conexão com o servidor."+ex);
            }
            return con;


        }
    }
}

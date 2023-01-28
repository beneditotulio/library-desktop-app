using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaDeGestaoBibliotecaria.Controladores
{
    class ControladorLeitor
    {
        public static void Salvar(Modelos.Leitor MLeitor)
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;

            con = Conexao.Conectando.AbrirConexao();
            con.Open();

            try
            {
                string SQL = "Insert Into TBLeitor(Nome, TipoDoc, NumeroDoc, Sexo,Morada, Contacto1, Contacto2, Email) Values('"+MLeitor.Nome+"','"+MLeitor.TipoDoc+"','"+MLeitor.NumeroDoc+"','"+MLeitor.Sexo+"','"+MLeitor.Morada+"','"+MLeitor.Contacto+"','"+MLeitor.Contacto1+"','"+MLeitor.Email+"');";
                cmd = new OleDbCommand(SQL, con);
                int i = cmd.ExecuteNonQuery();
                if(i>0)
                { MessageBox.Show("Registo Gravado com sucesso"); }
            }
            catch (Exception ex)
            { MessageBox.Show("Erro! Não foi possível estabelecer a conexão com a Base de Dados."); }
            finally { con.Close(); }
        }

        public static void Editar(Modelos.Leitor MLeitor)
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            if (MLeitor.Nome == string.Empty)
            {
                MessageBox.Show("Por favor informe o nome do cliente");
            }
            else
            {
                OleDbConnection conn = null;
                //SqlCommand cmd = null;
                OleDbDataReader Dread = null;


                conn = Conexao.Conectando.AbrirConexao();
                conn.Open();
                {
                    string SQl = "select * from TBLeitor Where Nome like '" + MLeitor.Nome + "' and TipoDoc like '" + MLeitor.TipoDoc + "' and NumeroDoc like '" + MLeitor.NumeroDoc + "' and Sexo like '" + MLeitor.Sexo + "' and Morada like '" + MLeitor.Morada + "' and Contacto1 like '" + MLeitor.Contacto+ "' and Contacto2 like '" + MLeitor.Contacto1 + "' and Email like '" + MLeitor.Email + "'";
                    cmd = new OleDbCommand(SQl, conn);
                    Dread = cmd.ExecuteReader();
                    if (Dread.Read())
                    {
                        MessageBox.Show("Este registo ja existe.");
                    }
                    else
                    {
                        try
                        {
                            con = Conexao.Conectando.AbrirConexao();
                            con.Open();
                            string SQL = "Update TBLeitor Set Nome = '" + MLeitor.Nome + "', TipoDoc = '" + MLeitor.TipoDoc + "', NumeroDoc = '" + MLeitor.NumeroDoc + "', Sexo = '" + MLeitor.Sexo + "', Morada = '" + MLeitor.Morada + "', Contacto1 = '" + MLeitor.Contacto + "', Contacto2 = '" + MLeitor.Contacto1 + "', Email = '" + MLeitor.Email + "' Where IDLeitor like '" + MLeitor.IDLeitor + "'";
                            cmd = new OleDbCommand(SQL, con);
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Registo actualizado com sucesso!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nao foi possivel gravar o registo. Por favor tente novamente.\n" + ex.Message);
                        }
                        finally
                        {
                            //Limpa();
                            con.Close();

                        }
                    }
                }
            }
        }

        public static void Eliminar(Modelos.Leitor MLeitor)
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            if (MLeitor.Nome == string.Empty)
            {
                MessageBox.Show("Por favor informe o nome do Leitor");
            }
            else
            {
                OleDbConnection conn = null;
                //SqlCommand cmd = null;
                OleDbDataReader Dread = null;


                conn = Conexao.Conectando.AbrirConexao();
                conn.Open();
                {
                    
                    
                        try
                        {
                            con = Conexao.Conectando.AbrirConexao();
                            con.Open();
                            string SQL = "Delete From TBLeitor  Where IDLeitor like '" + MLeitor.IDLeitor + "'";
                            cmd = new OleDbCommand(SQL, con);
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Registo eliminado com sucesso!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nao foi possivel gravar o registo. Por favor tente novamente.\n" + ex.Message);
                        }
                        finally
                        {
                            //Limpa();
                            con.Close();

                        }
                    }
                
            }
        }
    
    }

}

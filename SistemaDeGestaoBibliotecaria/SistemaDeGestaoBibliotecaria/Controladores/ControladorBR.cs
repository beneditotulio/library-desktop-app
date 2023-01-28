using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaDeGestaoBibliotecaria.Controladores
{
    class ControladorBR
    {
        public static void Salvar(Modelos.BR MBR)
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;

            con = Conexao.Conectando.AbrirConexao();
            con.Open();

            try
            {
                string SQL = "Insert Into TBBR(NrBR, Serie, Datapub, Tipo, Assunto, Descricao) Values('" + MBR.NrBR + "', '" + MBR.Serie + "', '" + MBR.Datapub + "','" + MBR.Tipo + "', '" + MBR.Assunto + "', '" + MBR.Descricao + "');";
                cmd = new OleDbCommand(SQL, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { MessageBox.Show("Registo Gravado com sucesso"); }
                //Minhas_Classes.VariaveisEstaticas.ComandoSQL = SQL;
                //Minhas_Classes.VariaveisEstaticas.Operacao = "Registou Autor";

                Modelos.Movimentos MMov = new Modelos.Movimentos();
                MMov.IDU = Convert.ToString(Minhas_Classes.VariaveisEstaticas.IdUsuario);
                MMov.Operacao = "Registou BR";
                MMov.Descricao = "Insert Into TBBR(NrBR, Serie, Datapub, Tipo, Assunto, Descricao) Values " + MBR.NrBR;
                MMov.Data = System.DateTime.Now.ToString();
                Controladores.ControladorMovimentos.Salvar(MMov);

            }
            catch (Exception ex)
            { MessageBox.Show("Erro! Não foi possível estabelecer a conexão com a Base de Dados."); }
            finally { con.Close(); }
        }
        public static void Editar(Modelos.BR MBR)
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
          
            
            {
                OleDbConnection conn = null;
                //SqlCommand cmd = null;
                OleDbDataReader Dread = null;

                conn = Conexao.Conectando.AbrirConexao();
                conn.Open();
                {
                    string SQl = "select * from TBBR Where NRBR like '" + MBR.NrBR + "'";
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
                            string SQL = "Update TBBR Set NrBR = '" + MBR.NrBR + "', Serie = '" + MBR.Serie + "', DataPub = '" + MBR.Datapub + "', Tipo = '" + MBR.Tipo + "', Assunto = '" + MBR.Assunto + "', Descricao = '" + MBR.Descricao + "' Where IDBR like '" + MBR.idBr + "'";
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
        public static void Eliminar(Modelos.BR MBR)
        {
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            if (MBR.NrBR == string.Empty)
            {
                MessageBox.Show("Por favor informe o codigp do BR");
            }
            else
            {
                OleDbConnection conn = null;
                //SqlCommand cmd = null;
                OleDbDataReader Dread = null;

                conn = Conexao.Conectando.AbrirConexao();
                conn.Open();
                {
                    //string SQl = "select * from TBBR Where NrBR like '" + MBR.NrBR + "'";
                    //cmd = new OleDbCommand(SQl, conn);
                    //Dread = cmd.ExecuteReader();
                    //if (Dread.Read())
                    //{
                    //    MessageBox.Show("Este registo ja existe.");
                    //}
                    //else
                    {
                        try
                        {
                            con = Conexao.Conectando.AbrirConexao();
                            con.Open();
                            string SQL = "Delete From TBBR Where IDBR like '" + MBR + "'";
                            cmd = new OleDbCommand(SQL, con);
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Eliminado actualizado com sucesso!");
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
        public static Modelos.BR Pesquisar(int IDBR)
         {
            Modelos.BR BR = new Modelos.BR();

            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;
            if (IDBR == null)
            {
                MessageBox.Show("Por favor informe o codigo do BR");
            }
            else
            {
                try
                {
                    con = Conexao.Conectando.AbrirConexao();
                    con.Open();
                    string SQL = "Select * From TBBR Where IDBR like  '" + IDBR + "'";
                    cmd = new OleDbCommand(SQL, con);
                    Dreader = cmd.ExecuteReader();
                    if (Dreader.Read())
                    {
                        BR.idBr = int.Parse(Dreader["IDBR"].ToString());
                        BR.NrBR = Dreader["NrBr"].ToString();
                        BR.Serie = Dreader["Serie"].ToString();
                        BR.Datapub = Dreader["DataPub"].ToString();
                        BR.Tipo = Dreader["Tipo"].ToString();
                        BR.Assunto = Dreader["Assunto"].ToString();
                        BR.Descricao = Dreader["Descricao"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nao foi possivel gravar o registo. Por favor tente novamente.\n" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return BR;

        }

        public static List <Modelos.BR> GetAllBR()
        {
            List<Modelos.BR> BR = new List<Modelos.BR>();
            OleDbCommand cmd = null;
            OleDbConnection con = null;
            OleDbDataReader Dreader = null;
                try
                {
                    con = Conexao.Conectando.AbrirConexao();
                    con.Open();
                    string SQL = "Select * From TBBR";
                    cmd = new OleDbCommand(SQL, con);
                    Dreader = cmd.ExecuteReader();
                    while(Dreader.Read())
                    {
                        //BR.idBr = int.Parse(Dreader["IDBR"].ToString());
                        //BR.NrBR = Dreader["NrBr"].ToString();
                        //BR.Serie = Dreader["Serie"].ToString();
                        //BR.Datapub = Dreader["DataPub"].ToString();
                        //BR.Tipo = Dreader["Tipo"].ToString();
                        //BR.Assunto = Dreader["Assunto"].ToString();
                        //BR.Descricao = Dreader["Descricao"].ToString();
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nao foi possivel gravar o registo. Por favor tente novamente.\n" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            return BR;

        }
    }
}

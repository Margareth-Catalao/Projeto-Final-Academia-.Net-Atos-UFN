using Biblioteca_Livros_Emprestimo.DataContext;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Biblioteca_Livros_Emprestimo.DataModels
{
    public class Leitor
    {
        public int IdLeitor { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public bool GravarLeitor()
        {
            Contexto contexto = new Contexto();

            SqlConnection cn = contexto.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into Leitores " +
                "values (@Nome, @Endereco, @Cpf, @Telefone);";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@Endereco", SqlDbType.VarChar);
            command.Parameters.Add("@Cpf", SqlDbType.VarChar);
            command.Parameters.Add("@Telefone", SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Endereco;
            command.Parameters[2].Value = Cpf;
            command.Parameters[3].Value = Telefone;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                contexto.fecharConexao();
            }
        }

        public bool ExcluirLeitor()
        {
            Contexto contexto = new Contexto();

            SqlConnection cn = contexto.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Leitores where IdLeitor = @IdLeitor";
            command.Parameters.Add("@IdLeitor", SqlDbType.Int);
            command.Parameters[0].Value = IdLeitor;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                contexto.fecharConexao();
            }
        }

        public bool EditarLeitor()
        {
            Contexto contexto = new Contexto();

            SqlConnection cn = contexto.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Leitores set Nome = @Nome, " +
                "Endereco = @Endereco, Cpf = @Cpf, Telefone = @Telefone where IdLeitor = @IdLeitor";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@Endereco", SqlDbType.VarChar);
            cmd.Parameters.Add("@Cpf", SqlDbType.VarChar);
            cmd.Parameters.Add("@Telefone", SqlDbType.VarChar);
            cmd.Parameters.Add("@IdLeitor", SqlDbType.Int);
            cmd.Parameters[0].Value = Nome;
            cmd.Parameters[1].Value = Endereco;
            cmd.Parameters[2].Value = Cpf;
            cmd.Parameters[3].Value = Telefone;
            cmd.Parameters[4].Value = IdLeitor;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                contexto.fecharConexao();
            }
        }

        public Leitor ConsultaLeitor(int idLeitor)
        {
            Contexto contexto = new Contexto();
            try
            {
                SqlConnection cn = contexto.abrirConexao();
                SqlCommand command = new SqlCommand("select * from Leitores",
                    cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == IdLeitor)
                    {
                        this.IdLeitor = reader.GetInt32(0);
                        Nome = reader.GetString(1);
                        Endereco = reader.GetString(2);
                        Cpf = reader.GetString(3);
                        Telefone= reader.GetString(4);

                        return this;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                contexto.fecharConexao();
            }
        }
    }
    
}

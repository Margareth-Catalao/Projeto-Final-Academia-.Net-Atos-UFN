using Biblioteca_Livros_Emprestimo.DataContext;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Biblioteca_Livros_Emprestimo.DataModels
{
    public class Emprestimo
    {
        public int IdEmprestimo { get; set; }
        public int IdLeitor { get; set; }   
        public Leitor Leitor { get; set; }  
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public string Status { get; set; }    

        public ICollection<EmprestimoLivros> Itens { get; set; }

        public bool GravarEmprestimo()
        {
          Contexto contexto = new Contexto();

            SqlConnection cn = contexto.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into Emprestimos " +
                "values (@IdLeitor, @DataInicio, @DataTermino, @Status);";
            command.Parameters.Add("@IdLeitor", SqlDbType.Int);
            command.Parameters.Add("@DataInicio", SqlDbType.DateTime);
            command.Parameters.Add("@DataTermino", SqlDbType.DateTime);
            command.Parameters.Add("@Status", SqlDbType.VarChar);
            command.Parameters[0].Value = IdLeitor;
            command.Parameters[1].Value = DataInicio;
            command.Parameters[2].Value = DataTermino;
            command.Parameters[3].Value = Status;

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

        public bool ExcluirEmprestimo()
        {

            Contexto contexto = new Contexto();

            SqlConnection cn = contexto.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Emprestimos where IdEmprestimo = @IdEmprestimo";
            command.Parameters.Add("@IdEmprestimo", SqlDbType.Int);
            command.Parameters[0].Value = IdEmprestimo;

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
        public bool EditarEmprestimo()
        {
            Contexto contexto = new Contexto();

            SqlConnection cn = contexto.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Emprestimos set  IdLeitor= @IdLeitor, " +
                "DataInicio = @DataInicio,  DataTermino= @DataTermino, Status=@Status where IdEmprestimo = @IdEmprestimo";
            cmd.Parameters.Add("@IdLeitor", SqlDbType.Int);
            cmd.Parameters.Add("@DataInicio", SqlDbType.DateTime);
            cmd.Parameters.Add("@DataTermino", SqlDbType.DateTime);
            cmd.Parameters.Add("@Status", SqlDbType.VarChar);
            cmd.Parameters[0].Value = IdLeitor;
            cmd.Parameters[1].Value = DataInicio;
            cmd.Parameters[2].Value = DataTermino;
            cmd.Parameters[3].Value = Status;


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

        public Emprestimo ConsultaEmprestimo(int IdEmprestimo)
        {
            Contexto contexto = new Contexto();

            try
            {
                SqlConnection cn = contexto.abrirConexao();
                SqlCommand command = new SqlCommand("select * from Emprestimos",
                    cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == IdEmprestimo)
                    {
                        this.IdEmprestimo = reader.GetInt32(0);
                        IdLeitor = reader.GetInt32(1);
                        DataInicio = reader.GetDateTime(2);
                        DataTermino = reader.GetDateTime(3);
                        Status = reader.GetString(4);   

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

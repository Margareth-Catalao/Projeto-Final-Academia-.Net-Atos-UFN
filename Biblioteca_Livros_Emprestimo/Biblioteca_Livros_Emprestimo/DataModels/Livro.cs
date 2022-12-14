using Biblioteca_Livros_Emprestimo.DataContext;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Livros_Emprestimo.DataModels
{
    public class Livro
    {
        public int IdLivro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Edicao { get; set; }
        public string Genero { get; set; }


        public bool gravarLivro()
        {
            Contexto contexto = new Contexto();

            SqlConnection cn = contexto.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into Livros " +
                "values (@Titulo, @Autor, @Editora, @Edicao, @Genero);";

            command.Parameters.Add("@Titulo", SqlDbType.VarChar);
            command.Parameters.Add("@Autor", SqlDbType.VarChar);
            command.Parameters.Add("@Editora", SqlDbType.VarChar);
            command.Parameters.Add("@Edicao", SqlDbType.VarChar);
            command.Parameters.Add("@Genero", SqlDbType.VarChar);
            command.Parameters[0].Value = Titulo;
            command.Parameters[1].Value = Autor;
            command.Parameters[2].Value = Editora;
            command.Parameters[3].Value = Edicao;
            command.Parameters[4].Value = Genero;

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
        public bool ExcluirLivro()
        {
            Contexto contexto = new Contexto();

            SqlConnection cn = contexto.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Livro where IdLivro = @IdLivro";
            command.Parameters.Add("@IdLivro", SqlDbType.Int);
            command.Parameters[0].Value = IdLivro;

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

        public bool EditarLivro()
        {
            Contexto contexto = new Contexto();

            SqlConnection cn = contexto.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Livro set Titulo = @Titulo, " +
                "Autor = @Autor, Editora = @Editora, Edicao = @Edicao, Genero = @Genero, "+
                "where IdLivro = @IdLivro";
            cmd.Parameters.Add("@Titulo", SqlDbType.VarChar);
            cmd.Parameters.Add("@Autor", SqlDbType.VarChar);
            cmd.Parameters.Add("@Editora", SqlDbType.VarChar);
            cmd.Parameters.Add("@Edicao", SqlDbType.VarChar);
            cmd.Parameters.Add("@Genero", SqlDbType.VarChar);
            cmd.Parameters.Add("@IdLivro", SqlDbType.Int);
            cmd.Parameters[0].Value = Titulo;
            cmd.Parameters[1].Value = Autor;
            cmd.Parameters[2].Value = Editora;
            cmd.Parameters[3].Value = Edicao;
            cmd.Parameters[4].Value = Genero;
            cmd.Parameters[5].Value = IdLivro;

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

        public Livro ConsultaLivro(int IdLivro)
        {
            Contexto contexto = new Contexto();

            try
            {
                SqlConnection cn = contexto.abrirConexao();
                SqlCommand command = new SqlCommand("select * from Livros", cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == IdLivro)
                    {
                        this.IdLivro = reader.GetInt32(0);
                        Titulo = reader.GetString(1);
                        Autor = reader.GetString(2);
                        Editora = reader.GetString(3);
                        Edicao = reader.GetString(4);
                        Genero = reader.GetString(5);

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

using System;
using System.Data.SqlClient;

namespace ProjetoLogin.Conexao
{
    class Tarefas
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool tarefaFazer(String tarefa, String email)
        {
            //comandos sql para verificar se já tem tarefas cadastradas no banco
            cmd.CommandText = "select descricao from tarefas where email = @email and finalizadas ='N'";
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//se foi encontrado
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }

            return tem;
        }

        public bool tarefaFeitas(string tarefa, string email)
        {
            //comandos sql para verificar se já tem tarefas cadastradas no banco
            cmd.CommandText = "select descricao from tarefas where email = @email and finalizadas ='S'";
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//se foi encontrado
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }

            return tem;
        }

        public String cadastrarTarefa(string tarefa, string login)
        {
            //comandos para inserir no banco
            if (!string.IsNullOrWhiteSpace(tarefa))
            {
                cmd.CommandText = "insert into tarefas values (@t, @s, @l);";
                cmd.Parameters.AddWithValue("@t", tarefa);
                cmd.Parameters.AddWithValue("@s", 'N');
                cmd.Parameters.AddWithValue("@l", login);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Tarefa Cadastrada com sucesso!";
                }
                catch
                {
                    this.mensagem = "Erro ao Cadastrar tarefa!";
                }
            }
            else
            {
                this.mensagem = "Tarefa não pode ser cadastrada em branco!";
            }
            return mensagem;
        }
    }
}

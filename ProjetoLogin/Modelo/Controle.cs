using ProjetoLogin.Conexao;
using System;


namespace ProjetoLogin.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String login, String senha)
        {
            LoginComandos loginComando = new LoginComandos();
            tem = loginComando.verificarLogin(login, senha);
            if (!loginComando.mensagem.Equals(""))
            {
                this.mensagem = loginComando.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            LoginComandos loginComando = new LoginComandos();
            this.mensagem = loginComando.cadastrar(email, senha, confSenha);

            if(loginComando.tem)//Mensagem de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }

        public string cadastrarTarefa(string tarefa, string login)
        {

            Tarefas trf = new Tarefas();
            this.mensagem = trf.cadastrarTarefa(tarefa, login);

            if (trf.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

    }
}

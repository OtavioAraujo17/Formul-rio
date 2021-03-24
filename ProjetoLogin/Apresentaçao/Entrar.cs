using ProjetoLogin.Modelo;
using System;
using System.Windows.Forms;


namespace ProjetoLogin.Apresentaçao
{
    public partial class Entrar : MaterialSkin.Controls.MaterialForm
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtSenha.Text);
            if (controle.mensagem.Equals("") && !string.IsNullOrWhiteSpace(txtLogin.Text) && controle.tem)
            {
                MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Entrar entrar = new Entrar();
                entrar.Close();
                NovaTarefa novaTarefa = new NovaTarefa();
                novaTarefa.Show();
                AFazer aFazer = new AFazer();
                aFazer.Show();
                Feitas feitas = new Feitas();
                feitas.Show();
            }
            else
            {
                MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Entrar_Load(object sender, EventArgs e)
        {

        }
    }
}

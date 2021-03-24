using ProjetoLogin.Apresentaçao;
using ProjetoLogin.Modelo;
using System;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoLogin
{
    public partial class Cadastrar : MaterialSkin.Controls.MaterialForm
    {
        Thread nt;

        public Cadastrar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novaForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novaForm()
        {
            Application.Run(new Entrar());
        }

        private void btnCriar_Click_1(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.cadastrar(txtLogin.Text, txtSenha.Text, txtConfirmarSenha.Text);
            if(controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);//Menssagem de erro
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

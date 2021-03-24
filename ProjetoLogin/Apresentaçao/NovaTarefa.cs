using ProjetoLogin.Modelo;
using ProjetoLogin.Apresentaçao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ProjetoLogin
{
    public partial class NovaTarefa : MaterialSkin.Controls.MaterialForm
    {
        public NovaTarefa()
        {
            InitializeComponent();
        }

        private void NovaTarefa_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarTar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.cadastrarTarefa(txtDescricao.Text, txtLogin.Text);
            this.txtDescricao.Clear();
            if (controle.tem)//Mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);//Menssagem de erro
            }
        }
    }
}

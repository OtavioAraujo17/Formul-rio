using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentaçao
{
    public partial class AFazer : MaterialSkin.Controls.MaterialForm
    {
        public AFazer()
        {
            InitializeComponent();
        }

        private void AFazer_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao buscar registo" + erro);
            }
        }
    }
}

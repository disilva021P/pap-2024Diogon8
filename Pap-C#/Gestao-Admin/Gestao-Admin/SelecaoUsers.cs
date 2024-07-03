using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class SelecaoUsers : Form
    {
        List<Utilizador> users;
        static public Utilizador devolvido;
        public SelecaoUsers(List<Utilizador> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void SelecaoUsers_Load(object sender, EventArgs e)
        {
            for (int i=0; i< users.Count; i++)
            {
                panelUsers.Controls.Add(new User(users[i]));

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(User.nifSelecionado == 0)
            {
                PopUp newa = new PopUp("Selecione alguém!", 1);
                newa.Show();
                devolvido = null;
            }
            else
            {
                devolvido = users.Where(u => u.Nif == User.nifSelecionado).First();
                User.nifSelecionado = 0;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            devolvido = null;
            this.Close();
        }
    }
}

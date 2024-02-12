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
    public partial class Utilizadores : UserControl
    {
        List<Utilizador> users;
        public Utilizadores(List<Utilizador> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                User user = new User(users[i]);
                if (PanelUnico.Controls.Count > 0)
                {
                    PanelUnico.Controls.Clear();
                }
                PanelUnico.Controls.Add(user);

            }
        }
    }
}

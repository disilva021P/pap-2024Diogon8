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
            scrollbar1.Minimum = PanelUnico.VerticalScroll.Minimum;
            scrollbar1.Maximum = PanelUnico.VerticalScroll.Maximum;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (PanelUnico.Controls.Count > 0)
            {
                PanelUnico.Controls.Clear();
            }
            foreach (Utilizador u in users)
            {
                User user = new User(u);
                
                PanelUnico.Controls.Add(user);

            }
        }

        private void PanelUnico_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void PanelUnico_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditarUser_Click(object sender, EventArgs e)
        {
            PopUp newa = new PopUp(User.nifSelecionado.ToString(),1);
            newa.Show();
        }
    }
}

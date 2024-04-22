using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class Lugar : UserControl
    {
        Utilizador utilizador;
        int n;
        public Lugar(Utilizador user,int n)
        {
            InitializeComponent();
            utilizador = user;
            this.n = n;
            if (user!=null ) {
                using (MemoryStream ms = new MemoryStream(user.Foto))
                {
                    Image imagem = Image.FromStream(ms);
                    guna2PictureBox1.Image = imagem;
                }
            }
            nLugar.Text = (n + 1).ToString();
            nLugar.Location = new Point(nLugar.PreferredWidth - 10, 0);
            nLugar.Parent = guna2PictureBox1;
            nLugar.BackColor = Color.Transparent;
        }
        public Lugar(int n)
        {
            InitializeComponent();
            this.n = n;
            nLugar.Text = (n + 1).ToString();
            nLugar.Parent = guna2PictureBox1;
            nLugar.BackColor = Color.Transparent;
            nLugar.Anchor = AnchorStyles.None;
            int x = (this.ClientSize.Width - nLugar.Width) / 2;
            int y = (this.ClientSize.Height - nLugar.Height) / 2;
            nLugar.Location = new Point(x, y);
        }
        public Lugar()
        {
            InitializeComponent();
            guna2PictureBox1.Visible=false;
            nLugar.Visible=false;
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Lugar_Load(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            guna2PictureBox1.Click += ClickForm;
            nLugar.Click += ClickForm;
        }
        private void ClickForm(object sender, EventArgs e)
        {
            if (!EstacionamentoControl.edit)
            {
                if (utilizador != null)
                {
                    MessageBox.Show(utilizador.Nif.ToString());
                }
                else
                {
                    MessageBox.Show("Quer adicionar um utilizador aqui?");
                }
            }
            else
            {
                if()
            }
            
        }
        private void panelClick_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelClick_Click(object sender, EventArgs e)
        {
        }
    }
}

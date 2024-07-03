
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class User : UserControl
    {
        Utilizador u;
        bool clicado=false;
        static public int nifSelecionado;
        public static bool ativo;
        public User(Utilizador u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void User_Load(object sender, EventArgs e)
        {
            txtNif.Text = u.Nif.ToString();
            txtEmail.Text = u.Email.ToString();
            txtNome.Text = u.Nome.ToString() + " " + u.Sobrenome.ToString();
            txtNumero.Text = u.Numero.ToString();
            txtDataNascimento.Text = u.DataNascimento.Date.ToString("dd/MM/yyyy");
            txtDataInscricao.Text = u.DataInscricao.Date.ToString("dd/MM/yyyy");
            txtOcorrencias.Text = u.Numero.ToString();
            txtEstado.Text = u.IdEstadoUtilizador.ToString();
            using (MemoryStream ms = new MemoryStream(u.Foto))
            {
                Image imagem = Image.FromStream(ms);
                ImageUser.Image = imagem;
            }
            for(int i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].Click += User_Click;
            }
        }

        private void User_Click(object sender, EventArgs e)
        {
            if (!clicado)
            {
                this.BackColor = Color.FromArgb(208, 232, 236);
                clicado = true;
                nifSelecionado = u.Nif;
                Gestao gestaform = Application.OpenForms["Gestao"] as Gestao;
                Pagamentos p = null;
                Control panel = gestaform.Controls["PanelPrincipal"];
                p = (panel as System.Windows.Forms.Panel).Controls["Pagamentos"] as Pagamentos;
                if (p != null)
                {
                    p.nifVisualizar = u.Nif;
                    p.atualiza();
                }
                

            }
            else
            {
                this.BackColor = Color.Transparent;
                clicado = false;
                Gestao gestaform = Application.OpenForms["Gestao"] as Gestao;
                Pagamentos p = null;
                Control panel = gestaform.Controls["PanelPrincipal"];
                p = (panel as System.Windows.Forms.Panel).Controls["Pagamentos"] as Pagamentos;
                if (p != null)
                {
                    p.nifVisualizar = -1;
                    p.atualiza();
                }
            }

        }

        private void User_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void User_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
            clicado = false;
        }

        private void txtDataNascimento_Click(object sender, EventArgs e)
        {

        }
    }
}

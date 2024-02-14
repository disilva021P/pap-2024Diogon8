using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class User : UserControl
    {
        Utilizador u;
        bool clicado=false;
        public static int nifSelecionado;
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
            txtDataNascimento.Text = u.DataNascimento.ToString();
            txtDataInscricao.Text = u.DataInscricao.ToString();
            txtOcorrencias.Text = u.Numero.ToString();
            txtEstado.Text = u.IdEstadoUtilizador.ToString();
            if (u.Foto != null){
                byte[] fotoBytes = u.Foto.Select(b => b.GetValueOrDefault()).ToArray();
                using (MemoryStream ms = new MemoryStream(fotoBytes))
                {
                    ImageUser.Image = Image.FromStream(ms);
                }
            }
            else
            {
                string caminhAtual = Directory.GetCurrentDirectory();
                string caminhoAnterior = Path.GetDirectoryName(Path.GetDirectoryName(caminhAtual));
                string pastaImagens = Path.Combine(caminhoAnterior, "arquivos");
                string ImagemDefault = Path.Combine(pastaImagens, "ImagemDefault.jpeg");
                ImageUser.Image = Image.FromFile(ImagemDefault);
            }


        }

        private void User_Click(object sender, EventArgs e)
        {
            if (!clicado)
            {
                this.BackColor = Color.FromArgb(208, 232, 236);
                nifSelecionado = u.Nif;
                clicado = true;

            }
            else
            {
                this.BackColor = Color.Transparent;
                clicado = false;
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
    }
}

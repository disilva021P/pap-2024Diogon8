using Org.BouncyCastle.Utilities;
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
    public partial class User : UserControl
    {
        Utilizador u;
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
    }
}

using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
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
    public partial class AdicionarUser : UserControl
    {
        List<Utilizador> users = new List<Utilizador>();
        List<Plano> planos = new List<Plano>();
        List<EstadoUtilizador> estados = new List<EstadoUtilizador>();
        Utilizador utilizador;
        string caminhoDaImagem;
        int edicao=-1;
        public AdicionarUser(List<Utilizador> users)
        {
            InitializeComponent();
            this.users = users;
        }
        public AdicionarUser(List<Utilizador> users,Utilizador u)
        {
            InitializeComponent();
            this.users = users;
            this.edicao = u.Nif;
            this.utilizador = u;
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de imagem|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Todos os arquivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obter o caminho do arquivo selecionado
                    caminhoDaImagem = openFileDialog.FileName;

                    // Carregar a imagem no PictureBox
                    ImagemAdicionar.Image = Image.FromFile(caminhoDaImagem);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form formularioPrincipal = this.FindForm();

            // Verifica se o formulário pai é do tipo desejado (Gestao)
            if (formularioPrincipal is Gestao gestao)
            {

                // Acesse o painel no formulário principal
                Guna2Panel painelPrincipal = (Guna2Panel)gestao.ObterPainelPrincipal();
                Utilizadores utilizadores = new Utilizadores(users);
                painelPrincipal.Controls.Clear();
                painelPrincipal.Controls.Add(utilizadores);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnVoltar_Click(sender, e);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNif.Text) &&
                !string.IsNullOrEmpty(txtEmail.Text) &&
                !string.IsNullOrEmpty(txtNome.Text) &&
                !string.IsNullOrEmpty(txtSobreNome.Text) &&
                dataInscricao.Value  != null &&
                dataNascimento.Value != null &&
                cbPlanoUser.SelectedIndex != -1 &&
                cbEstado.SelectedIndex != -1)
            {
                Utilizador u = new Utilizador();
                if (caminhoDaImagem != null)
                {
                    u.Foto = File.ReadAllBytes(caminhoDaImagem);                   
                }
                u.Nif = Convert.ToInt32(txtNif.Text);
                u.Comentarios = txtComentario.Text;
                u.Morada = txtMorada.Text;
                u.Nome = txtNome.Text;
                u.Email = txtEmail.Text;
                u.Sobrenome = txtSobreNome.Text;
                u.DataNascimento = dataNascimento.Value;
                u.Numero = txtNumero.Text;
                u.DataInscricao = dataInscricao.Value;
                u.NOcorrenciasCometidas = 0;
                u.IdEstadoUtilizador = estados[cbEstado.SelectedIndex].Estado;
                u.IdPlano = planos[cbPlanoUser.SelectedIndex].Titulo;
                u.IdLocalizacao = "Fora";
                users.Add(u);
                if (edicao == -1)
                {
                    if(u.Foto == null)
                    {
                        if (caminhoDaImagem == null)
                        {
                            string caminhAtual = Directory.GetCurrentDirectory();
                            string caminhoAnterior = Path.GetDirectoryName(Path.GetDirectoryName(caminhAtual));
                            string pastaImagens = Path.Combine(caminhoAnterior, "arquivos");
                            string ImagemDefault = Path.Combine(pastaImagens, "ImagemDefault.jpeg");
                            u.Foto = File.ReadAllBytes(ImagemDefault);
                        }
                    }
                    using (MySqlConnection connection = new MySqlConnection(LoginAdmin.connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO utilizador (Nif, Nome, Sobrenome, Morada, DataNascimento, Email, Foto, Comentarios, Numero, DataInscricao, NOcorrenciasCometidas, idlocalizao, idEstadoUtilizador, idplano, rececao) " +
                                       "VALUES (@Nif, @Nome, @Sobrenome, @Morada, @DataNascimento, @Email, @Foto, @Comentarios, @Numero, @DataInscricao, @NOcorrenciasCometidas, @IdLocalizacao, @IdEstadoUtilizador, @IdPlano, @rececao)";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Nif", u.Nif);
                        cmd.Parameters.AddWithValue("@Nome", u.Nome);
                        cmd.Parameters.AddWithValue("@Sobrenome", u.Sobrenome);
                        cmd.Parameters.AddWithValue("@Morada", u.Morada);
                        cmd.Parameters.AddWithValue("@DataNascimento", u.DataNascimento);
                        cmd.Parameters.AddWithValue("@Email", u.Email);
                        cmd.Parameters.AddWithValue("@Foto", u.Foto);
                        cmd.Parameters.AddWithValue("@Comentarios", u.Comentarios);
                        cmd.Parameters.AddWithValue("@Numero", u.Numero);
                        cmd.Parameters.AddWithValue("@DataInscricao", u.DataInscricao);
                        cmd.Parameters.AddWithValue("@NOcorrenciasCometidas", 0);
                        cmd.Parameters.AddWithValue("@IdLocalizacao", 0);
                        cmd.Parameters.AddWithValue("@IdEstadoUtilizador", estados[cbEstado.SelectedIndex].IdEstadoUtilizador);
                        cmd.Parameters.AddWithValue("@IdPlano", planos[cbPlanoUser.SelectedIndex].IdPlano);
                        cmd.Parameters.AddWithValue("@rececao", 0);
                        if (cmd.ExecuteNonQuery() <= 0)
                        {
                            PopUp erro = new PopUp("Erro ao adicionar utilizador!", 1);
                            erro.ShowDialog();
                        }
                        else
                        {
                            connection.Close();
                            btnVoltar_Click(sender, e);
                        }
                        connection.Close();
                    }

                }
                else
                {
                    if(u.Foto == null)
                    {
                        u.Foto = utilizador.Foto;

                    }

                    using (MySqlConnection connection = new MySqlConnection(LoginAdmin.connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE utilizador SET Nome = @Nome, Sobrenome = @Sobrenome, Morada = @Morada, DataNascimento = @DataNascimento, Email = @Email," +
                            " foto = COALESCE(@foto, foto), Comentarios = @Comentarios, Numero = @Numero, DataInscricao = @DataInscricao," +
                            " idEstadoUtilizador = COALESCE(@IdEstadoUtilizador, idEstadoUtilizador),idplano = COALESCE(@IdPlano, idplano) WHERE Nif = @Nif";

                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Nif", u.Nif);
                        cmd.Parameters.AddWithValue("@Nome", u.Nome);
                        cmd.Parameters.AddWithValue("@Sobrenome", u.Sobrenome);
                        cmd.Parameters.AddWithValue("@Morada", u.Morada);
                        cmd.Parameters.AddWithValue("@DataNascimento", u.DataNascimento);
                        cmd.Parameters.AddWithValue("@Email", u.Email);
                        cmd.Parameters.AddWithValue("@Foto", u.Foto);
                        cmd.Parameters.AddWithValue("@Comentarios", u.Comentarios);
                        cmd.Parameters.AddWithValue("@Numero", u.Numero);
                        cmd.Parameters.AddWithValue("@DataInscricao", u.DataInscricao);
                        if(cbEstado.SelectedIndex != -1)
                        {
                            cmd.Parameters.AddWithValue("@IdEstadoUtilizador", estados[cbEstado.SelectedIndex].IdEstadoUtilizador);
                        }
                        if (cbPlanoUser.SelectedIndex != -1)
                        {
                            cmd.Parameters.AddWithValue("@IdPlano", planos[cbPlanoUser.SelectedIndex].IdPlano);
                        }
                        if (cmd.ExecuteNonQuery() <= 0)
                        {
                            PopUp erro = new PopUp("Erro ao atualizar utilizador!", 1);
                            erro.ShowDialog();
                        }
                        else
                        {
                            connection.Close();
                            users.RemoveAll(ut => ut.Nif == edicao);
                            users.Add(u);
                            btnVoltar_Click(sender, e);
                        }
                        connection.Close();
                    }
                }
            }
                
            else
            {
                PopUp erro = new PopUp("Valores inválidos!", 1);
                erro.ShowDialog();
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarUser_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(LoginAdmin.connectionString))
            {
                connection.Open();
                string query = "SELECT * from planos";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Plano p = new Plano();
                    p.IdPlano = dr.GetInt32(0);
                    p.Titulo = dr.GetString(3);
                    cbPlanoUser.Items.Add(p.Titulo);
                    planos.Add(p);
                }
                dr.Close();
                string query1 = "SELECT * from estadoutilizador";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    EstadoUtilizador eu = new EstadoUtilizador();
                    eu.IdEstadoUtilizador = dr1.GetInt32(0);
                    eu.Estado = dr1.GetString(1);
                    cbEstado.Items.Add(eu.Estado);
                    estados.Add(eu);
                }
                dr1.Close();
                connection.Close();
            }
            if (edicao != -1)
            {
                btnAdicionar.Text = "Editar";
                txtNif.Enabled = false;
                txtNif.Text = utilizador.Nif.ToString();
                txtComentario.Text = utilizador.Comentarios;
                txtEmail.Text = utilizador.Email;
                txtMorada.Text = utilizador.Morada;
                txtNome.Text = utilizador.Nome;
                txtNumero.Text = utilizador.Numero;
                txtSobreNome.Text = utilizador.Sobrenome;
                if (utilizador.Foto != null)
                {
                    using (MemoryStream ms = new MemoryStream(utilizador.Foto))
                    {
                        ImagemAdicionar.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    string caminhAtual = Directory.GetCurrentDirectory();
                    string caminhoAnterior = Path.GetDirectoryName(Path.GetDirectoryName(caminhAtual));
                    string pastaImagens = Path.Combine(caminhoAnterior, "arquivos");
                    string ImagemDefault = Path.Combine(pastaImagens, "ImagemDefault.jpeg");
                    ImagemAdicionar.Image = Image.FromFile(ImagemDefault);
                }
                dataInscricao.Value = utilizador.DataInscricao;
                dataNascimento.Value = utilizador.DataNascimento;
                cbEstado.Text  = utilizador.IdEstadoUtilizador;
                cbPlanoUser.Text = utilizador.IdPlano;
            } 

        }
    }
}

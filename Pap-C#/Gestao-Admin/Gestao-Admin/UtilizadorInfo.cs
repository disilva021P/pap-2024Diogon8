using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class UtilizadorInfo : Form
    {
        public UtilizadorInfo(Utilizador user)
        {
            InitializeComponent();
            using (MemoryStream ms = new MemoryStream(user.Foto))
            {
                System.Drawing.Image imagem = System.Drawing.Image.FromStream(ms);
                foto.Image = imagem;
            }
            lblNif.Text = user.Nif.ToString();
            nomeUtilizador.Text = user.Nome + " " + user.Sobrenome;
            lblDataNascimento.Text = user.DataNascimento.ToString("dd/MM/yyyy");
            lblMorada.Text = user.Morada;
            txtComent.Text = user.Comentarios;
            lblNumero.Text = user.Numero;
            lblDataInscricao.Text = user.DataInscricao.ToString("dd/MM/yyyy");
            lblOcorrencias.Text = user.NOcorrenciasCometidas.ToString();
            lblEstado.Text = user.IdEstadoUtilizador;
            lblPlano.Text = user.IdPlano;
            using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
            {
                conn.Open();
                string sql = "Select * from pagamento where nif=@nif order by dataPagamentoRecebido";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nif", user.Nif);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.GetString(1).StartsWith("P"))
                {
                    if (reader.GetInt32(4) == 1)
                    {
                        lblPagou.Text = "Último pagamento pago";
                        lblPagou.ForeColor = Color.Green;
                    }
                }
                reader.Close();
                conn.Close();
            }
        }

        private void UtilizadorInfo_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

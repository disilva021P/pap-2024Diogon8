
using MySql.Data.MySqlClient;
using System;

using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class OcorrenciaControl : UserControl
    {
        int id;
        public OcorrenciaControl(int id)
        {
            InitializeComponent();
            this.id= id;
        }

        private void OcorrenciaControl_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
            {
                conn.Open();
                string sql = "Select ocorrencias.*,utilizador.nome,utilizador.sobrenome from ocorrencias,utilizador where idOcorrencia=@id and ocorrencias.nif= utilizador.nif";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                NomeSubmetido.Text = reader.GetString(8)+" "+reader.GetString(9);
                motivo.Text = reader.GetString(2);
                descricao.Text = reader.GetString(3);
                dataOcorrencia.Text = reader.GetDateTime(4).ToString("dd-MM-yyyy");
                matricula.Text = reader.IsDBNull(6) ? "": reader.GetString(6);
                using (MemoryStream ms = new MemoryStream((byte[])reader[5]))
                {
                    Image imagem = Image.FromStream(ms);
                    foto.Image = imagem;
                }
                reader.Close();


            }
        }
    }
}

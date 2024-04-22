using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class Cofiguracoes : Form
    {
        public static string connectionString = "Data Source=[localhost];Initial Catalog=[papgestaofinal];User ID=[root];Password=[mysql]";
        bool? pago;
        bool? lugaresmarcados;


        public Cofiguracoes()
        {
            InitializeComponent();
        }

        private void Cofiguracoes_Load(object sender, EventArgs e)
        {

        }

        private void rdPago_Click(object sender, EventArgs e)
        {
            if (rdPago.Checked)
            {
                rdNaoPago.Checked = false;
                Guna2TileButton btn = (Guna2TileButton)sender;
                btn.FillColor = Color.FromArgb(60, 0, 0, 0);
                rdNaoPago.FillColor = Color.Transparent;
                pago = true;
            }
        }

        private void rdNaoPago_Click(object sender, EventArgs e)
        {
            if (rdNaoPago.Checked)
            {
                rdPago.Checked = false;
                Guna2TileButton btn = (Guna2TileButton)sender;
                btn.FillColor = Color.FromArgb(60, 0, 0, 0);
                rdPago.FillColor = Color.Transparent;
                pago = false;
            }
        }

        private void rdLugaresMarcados_Click(object sender, EventArgs e)
        {
            if (rdLugaresMarcados.Checked)
            {
                rdNaoLugaresMarcados.Checked = false;
                Guna2TileButton btn=(Guna2TileButton)sender;
                btn.FillColor = Color.FromArgb(60, 0, 0, 0);
                rdNaoLugaresMarcados.FillColor = Color.Transparent;
                lugaresmarcados = true;
            }
        }

        private void rdNaoLugaresMarcados_Click(object sender, EventArgs e)
        {
            if (rdNaoLugaresMarcados.Checked)
            {
                rdLugaresMarcados.Checked = false;
                Guna2TileButton btn = (Guna2TileButton)sender;
                btn.FillColor = Color.FromArgb(60, 0, 0, 0);
                rdLugaresMarcados.FillColor = Color.Transparent;
                lugaresmarcados = false;
            }
        }
        public bool Pago;
        private void btnConf_Click(object sender, EventArgs e)
        {
            if (pago != null || lugaresmarcados != null)
            {
                if (!(bool)lugaresmarcados)
                {
                    using (MySqlConnection connection = new MySqlConnection(LoginAdmin.connectionString))
                    {
                        connection.Open();
                        string query = "Insert into confs(ConfigPago,LugaresMarcados) Values (@pago,@lugares);";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        if ((bool)pago)
                        {
                            cmd.Parameters.AddWithValue("@pago", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@pago", 0);
                        }
                        cmd.Parameters.AddWithValue("@lugares", 0);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            this.Hide();
                            PopUp bemsucedido = new PopUp("Configurações definidas!", 1);
                            bemsucedido.ShowDialog();
                            LoginAdmin form = new LoginAdmin();
                            form.ShowDialog();
                        }
                        else
                        {
                            PopUp erro = new PopUp("Erro ao adicionar configurações tente denovo!", 1);
                            erro.ShowDialog();
                        }
                    }
                }
                else
                {
                    PopUp finalizar = new PopUp(5,(bool)pago);
                    finalizar.ShowDialog();
                }
                
            }
            else
            {
                PopUp erro = new PopUp("Insira as configurações!", 1);
                erro.ShowDialog();
            }
        }
    }
}

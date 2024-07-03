using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class LoginAdmin : Form
    {

        public static string connectionString = "Server=localhost;Database=papgestaofinal;User ID=root;Password=mysql;Port=3306;";
        public LoginAdmin()
        {
            InitializeComponent();
        }
        public static int nivel = 0;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string textonif = txtnif.Text;
            int nif;
            string password = txtpass.Text;
            if (textonif == "" || password == "")
            {
                PopUp popupContainer = new PopUp("Erro, por favor insira todos os campos!", 1);
                popupContainer.ShowDialog();
            }
            else {
                if (!Int32.TryParse(textonif, out nif))
                {
                    PopUp popupContainer = new PopUp("Erro, por favor insira um nif válido!", 1);
                    popupContainer.ShowDialog();
                }
                else
                {                   
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlQuery = "SELECT nivel FROM utilizadorlogin WHERE nif=@nif AND password=@password AND (nivel=1 OR nivel=2);";
                        using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@nif", nif);
                            cmd.Parameters.AddWithValue("@password", password);
                            MySqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                nivel = dr.GetInt32(0);
                                this.Hide();
                                Form formGestao = new Gestao();
                                formGestao.ShowDialog();
                                if (!PopUp.Valor)
                                {
                                    this.Show();
                                }
                            }
                            else
                            {
                                PopUp popupContainer = new PopUp("Erro, admin não encontrado!", 1);
                                popupContainer.ShowDialog();

                            }
                        }
                        connection.Close();

                    }
                }


            }

        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            
            
        }

        private void txtpass_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnFecharLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


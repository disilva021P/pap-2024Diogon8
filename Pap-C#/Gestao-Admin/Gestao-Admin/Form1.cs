using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Gestao_Admin
{
    public partial class LoginAdmin : Form
    {

        private static string chave = "Encriptar0120321";
        private static string iv = "Encriptar0120321";
        public static string connectionString = "Server=localhost;Database=papgestaofinal;User ID=root;Password=mysql;Port=3306;";
        public LoginAdmin()
        {
            InitializeComponent();
        }
        public static int nivel = 0;

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string textonif = txtnif.Text;
            int nif;
            string password = txtpass.Text;
            if (textonif == "" || password == "")
            {
                PopUp popupContainer = new PopUp("Erro, porfavor insira todos os campos!", 1);
                popupContainer.ShowDialog();
            }
            else {
                if (!Int32.TryParse(textonif, out nif))
                {
                    PopUp popupContainer = new PopUp("Erro, porfavor insira um nif válido!", 1);
                    popupContainer.ShowDialog();
                }
                else
                {
                    string passwordCoded;
                    using (Aes aesAlg = Aes.Create())
                    {
                        aesAlg.Key = Encoding.UTF8.GetBytes(chave);
                        aesAlg.IV = Encoding.UTF8.GetBytes(iv);

                        ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                        using (MemoryStream msEncrypt = new MemoryStream())
                        {
                            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                            {
                                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                                {
                                    swEncrypt.Write(password);
                                }
                            }

                            passwordCoded = Convert.ToBase64String(msEncrypt.ToArray());

                        }
                    }
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
    }
}


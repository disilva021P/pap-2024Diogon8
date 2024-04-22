using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Gestao_Admin
{
    internal static class Program
    {
        public static int pago;
        public static int marcados;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //modificar alerta!
            using (MySqlConnection connection = new MySqlConnection(LoginAdmin.connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM confs;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) {
                        int id = reader.GetInt32("ConfigPago");
                        int nome = reader.GetInt32("LugaresMarcados");
                        Application.Run(new LoginAdmin());
                    }
                    else
                    {
                        Application.Run(new Cofiguracoes());
                    }
                    reader.Close();
                }
                connection.Close();


            }
        }
    }
}

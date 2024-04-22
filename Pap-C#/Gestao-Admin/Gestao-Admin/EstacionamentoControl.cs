using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestao_Admin
{
    public partial class EstacionamentoControl : UserControl
    {
        int nLugares;
        Dictionary<int, int?> lugares = new Dictionary<int, int?>();//lugar:nif
        static public bool edit=false;

        public EstacionamentoControl(int nLugares)
        {
            InitializeComponent();
            edit = true;
            for (int i = 0; i < 128; i++)
            {
                Lugar currentPanel = new Lugar();
                currentPanel.Name = i.ToString();
                PanelUnico.Controls.Add(currentPanel);
            }
            
        }
        private void click(object sender, EventArgs e)
        {

        }
        public EstacionamentoControl(List<Utilizador> users)
        {
            InitializeComponent();
            using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
            {
                conn.Open();
                string sql = "SELECT nLugarGrid FROM papgestaofinal.lugar";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dr = cmd.ExecuteReader(); ;
                while (dr.Read()) {
                    lugares.Add(dr.GetInt32(0),null);
                }
                dr.Close();
                conn.Close();
            }
            using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
            {
                conn.Open();
                string sql1 = "SELECT nLugarGrid FROM papgestaofinal.lugar,utilizador where lugar.nif=utilizador.nif and lugar.nif=@nif;";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                for (int i = 0; i < users.Count; i++)
                {
                    cmd1.Parameters.AddWithValue("@nif", users[i].Nif);
                    MySqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        lugares[dr.GetInt32(0)] = users[i].Nif;
                    }
                    dr.Close(); 
                    cmd1.Parameters.Clear();
                }
                conn.Close();
            }
            for (int i = 0; i < 128; i++)
            {
                Lugar currentPanel;
                if (lugares.ContainsKey(i) && lugares[i] != null)
                {
                    currentPanel = new Lugar(users.Where(u=> u.Nif == lugares[i]).First(),i);
                }
                else if (lugares.ContainsKey(i) && lugares[i] == null)
                {
                    currentPanel = new Lugar(i);
                }else
                {
                    currentPanel = new Lugar();
                }
                currentPanel.Name = i.ToString();
                PanelUnico.Controls.Add(currentPanel);
            }
        }
        
        private void EstacionamentoControl_Load(object sender, EventArgs e)
        {
            PanelUnico.Padding = new Padding(0, 0, 110, 0);


        }

        private void panelConfiguracoes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

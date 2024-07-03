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
        Dictionary<int, int?[]> lugares = new Dictionary<int, int?[]>();//lugar:nif
        static public bool edit=false;
        static public int nLugares=-1;
        static public int LugaresInseridos=0;
        int preencherautomaticoLugares;
        static public int porpreencher=0;
        static public int preenchido;
        public EstacionamentoControl(int n)
        {
            InitializeComponent();
            edit = true;
            nLugares = n;
            preencherautomaticoLugares = n;
            for (int i = 0; i < 128; i++)
            {
                Lugar currentPanel = new Lugar();
                currentPanel.Name = i.ToString();
                currentPanel.Click += currentPanel.ClickForm;
                
                currentPanel.DoubleClick += doubleclick;
                PanelUnico.Controls.Add(currentPanel);
            }
            painelEditarInicial.Visible = true;
            painelEdita.Visible = false;
            btnEditar.Visible = false;
            lblnPorPreencher.Text = n.ToString();
            
        }
        
        public EstacionamentoControl(List<Utilizador> users)
        {
            edit = false;
            nLugares = -1;
            InitializeComponent();
            using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
            {
                conn.Open();
                string sql1 = "SELECT nLugarGrid,nLugar,nif FROM papgestaofinal.lugar";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                MySqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    int nLugarGrid = dr.GetInt32(0);
                    int nLugar = dr.GetInt32(1);
                    int? nif = dr.IsDBNull(2) ? null : (int?)dr.GetInt32(2);
                    lugares[nLugarGrid] = new int?[] { nif, nLugar };
                    cmd1.Parameters.Clear();
                    porpreencher++;
                }
                dr.Close();
                conn.Close();
            }
            for (int i = 0; i < 128; i++)
            {
                Lugar currentPanel;
                if (lugares.ContainsKey(i) && lugares[i] != null && lugares[i][0] != null)
                {
                    currentPanel = new Lugar(users.Where(u=> u.Nif == lugares[i][0]).First(), (int)lugares[i][1]);
                    ++preenchido;
                }
                else if (lugares.ContainsKey(i) && lugares[i] != null && lugares[i][0] == null)
                {
                    currentPanel = new Lugar((int)lugares[i][1]);
                    ++porpreencher;
                }else
                {
                    currentPanel = new Lugar();
                }
                currentPanel.Name = i.ToString();
                //currentPanel.Click += click;
                currentPanel.DoubleClick += doubleclick;
                PanelUnico.Controls.Add(currentPanel);
            }
            
        }
        
        private void doubleclick(object sender, EventArgs e)
        {
            Lugar painel = sender as Lugar;
            if (!edit)
            {
                painel.doubleclick(sender, e);
            }
        }
        private void EstacionamentoControl_Load(object sender, EventArgs e)
        {
            PanelUnico.Padding = new Padding(0, 0, 110, 0);
        }

        private void panelConfiguracoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (edit) 
            {
                edit = false;
                btnEditar.Text = "Editar";
                painelEdita.Visible = false;
            }
            else
            {
                edit = true;
                btnEditar.Text = "Parar de Editar";
                painelEdita.Visible = true;
            }
            

        }
        static public string[] preenchetxt()
        {
            string[] retomar = new string[2];
            using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
            {
                conn.Open();
                string sqlPaint = "SELECT Count(nif),Count(Nlugar) FROM papgestaofinal.lugar";
                MySqlCommand cmd1 = new MySqlCommand(sqlPaint, conn);
                MySqlDataReader reader = cmd1.ExecuteReader();
                reader.Read();
                retomar[0] = reader.GetInt32(0).ToString();
                retomar[1] =(reader.GetInt32(1) - reader.GetInt32(0)).ToString();
                reader.Close();
                conn.Close();
            }
            return retomar;
        }
        private void painelEdita_Paint(object sender, PaintEventArgs e)
        {
            string[] textos = preenchetxt();
            lblLugaresInseridos.Text = textos[0];
            lblPorInserir.Text = textos[1];

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
                if (nLugares == 0)
            {
                Dictionary<int, int?> dicionario = EstacionamentoCriar.lugaresIniciais;
                for (int i = 0; i < 128; i++)
                {
                    if (dicionario.ContainsKey(i) && dicionario[i] != null) {
                        using (MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
                        {
                            conn.Open();
                            string sql = "Update lugar set nLugarGrid=@lugarGrid where Nlugar=@nlugar";
                            MySqlCommand cmd = new MySqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@lugarGrid", i);
                            cmd.Parameters.AddWithValue("@nlugar", dicionario[i]);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            cmd.Parameters.Clear();
                            conn.Close();
                        }
                    }
                    

                }
                this.ParentForm.Close();
            }
            else { PopUp erro = new PopUp("Insira todos os lugares primeiro!", 1);erro.ShowDialog(); }
            
        }

        private void btnPreencher_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < preencherautomaticoLugares; i++) {
                ((Lugar)PanelUnico.Controls[i]).ClickForm(sender,e);
            }
            LugaresInseridos = preencherautomaticoLugares;
            nLugares = 0;
            lblnPorPreencher.Text = nLugares.ToString();
        }
    }
}

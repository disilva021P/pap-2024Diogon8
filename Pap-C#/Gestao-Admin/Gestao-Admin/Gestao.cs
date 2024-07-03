using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class Gestao : Form
    {
        bool menu_aberto = false;
        List<Guna2Button> botoesMenu = new List<Guna2Button>();
        public Gestao()
        {
            InitializeComponent();
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
        }
        private void Gestao_Load(object sender, EventArgs e)
        {
            botoesMenu.Add(btnDashboard);
            botoesMenu.Add(btnUsers);
            botoesMenu.Add(btnOcorrencias);
            botoesMenu.Add(btnLugares);
            botoesMenu.Add(btnPagamentos);
            botoesMenu.Add(btnSair);
        }
        
        private async void btn_menu_ClickAsync(object sender, EventArgs e)
        {
            if (menu_aberto)
            {
                int novalargura = Menu.Width - 110;
                Point novaloc = new Point(btn_menu.Location.X - 110, btn_menu.Location.Y);
                while (Menu.Width > novalargura)
                {
                    Menu.Width -= 8;
                    btn_menu.Location = new Point(btn_menu.Location.X - 8, btn_menu.Location.Y);
                    await Task.Delay(10);
                }
                foreach (Guna2Button botao in botoesMenu){
                    botao.Width = novalargura - 5;
                    botao.Padding = new Padding(0, 0, 100, 0);
                    botao.ImageAlign = HorizontalAlignment.Center;
                }
                Menu.Width = novalargura;
                btn_menu.Location = novaloc;
                menu_aberto = false;
                btn_menu.Text = ">";
            }
            else
            {

                int novalargura = Menu.Width + 110;
                Point novaloc = new Point(btn_menu.Location.X + 110, btn_menu.Location.Y);                
                foreach (Guna2Button botao in botoesMenu)
                {
                    botao.Width = novalargura - 5;
                    botao.ImageAlign = HorizontalAlignment.Left;
                    botao.Padding = new Padding(0, 0, 0, 0);
                }
                while (Menu.Width < novalargura)
                {
                    Menu.Width += 8;
                    btn_menu.Location = new Point(btn_menu.Location.X + 8, btn_menu.Location.Y);
                    await Task.Delay(10);
                }
                Menu.Width = novalargura;
                btn_menu.Location = novaloc;
                menu_aberto = true;
                btn_menu.Text = "<";
            }
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            Pagamentos p = carregarPagamentos();
            p.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(p);
            PanelPrincipal.BringToFront();
            User.nifSelecionado = -1;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            PopUp confirmar = new PopUp("Tem a certeza que deseja sair?", 4);
            confirmar.ShowDialog();
            if (PopUp.Valor)
            {
                Application.Exit();
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserControl utilizadores = carregarUsers();
            utilizadores.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(utilizadores);
            PanelPrincipal.BringToFront();
        }
        public UserControl carregarUsers()
        {
            UserControl utilizadores = new Utilizadores(Utilizador.getUsers());
            return utilizadores;
        }
        public Pagamentos carregarPagamentos()
        {
            Pagamentos panlepagamento = new Pagamentos(Utilizador.getUsers());
            return panlepagamento;
        }
        public EstacionamentoControl carregarEstacionamento()
        {
            EstacionamentoControl panelEstacionamento = new EstacionamentoControl(Utilizador.getUsers());
            return panelEstacionamento;
        }
        public Ocorrencias carregarOcorrencias()
        {
            Ocorrencias panelEstacionamento = new Ocorrencias();
            return panelEstacionamento;
        }
        public Panel ObterPainelPrincipal()
        {
            return PanelPrincipal;
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLugares_Click(object sender, EventArgs e)
        {
            User.nifSelecionado = 0;
            EstacionamentoControl panelEstacionamento = carregarEstacionamento();
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(panelEstacionamento);
            PanelPrincipal.BringToFront();
        }

        private void btnOcorrencias_Click(object sender, EventArgs e)
        {
            Ocorrencias panelEstacionamento = carregarOcorrencias();
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(panelEstacionamento);
            PanelPrincipal.BringToFront();
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(LoginAdmin.connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM confs;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader.GetInt32("ConfigPago") == 0)
                        {
                            btnPagamentos.Visible = false;
                        }
                       if(reader.GetInt32("LugaresMarcados")==0)
                        {
                            btnLugares.Visible = false;
                        }

                    }
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            User.nifSelecionado = 0;
            PanelPrincipal.Controls.Clear();
        }

        private async void btnAbrirPortao_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("http://127.0.0.1:5000/abrir_portao/");
            }
        }

        private async void btnFecharPortao_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("http://127.0.0.1:5000/fechar_portao/");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    
    }
}

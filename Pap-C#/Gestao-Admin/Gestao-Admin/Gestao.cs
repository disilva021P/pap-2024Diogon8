using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class Gestao : Form
    {
        string connectionString = "Server=localhost;Database=papgestaofinal;User ID=root;Password=mysql;Port=3306;";
        bool menu_aberto = false;
        List<Guna2Button> botoesMenu = new List<Guna2Button>();
        List<Utilizador> users = new List<Utilizador>();
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

        }

        private void Gestao_Shown(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
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
            Utilizador  u = new Utilizador();
            u.Nif = 123456789;
            u.Nome = "Diogo";
            u.Email = "email";
            u.Sobrenome = "String";
            u.DataNascimento = DateTime.Now;
            u.Numero = "";
            u.DataInscricao = DateTime.Now;
            u.NOcorrenciasCometidas = 1;
            u.IdLocalizacao = 1;
            u.IdEstadoUtilizador = 1;
            u.IdPlano = 1;
            users.Add(u);
            UserControl utilizadores = new Utilizadores(users);
            utilizadores.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(utilizadores);
            PanelPrincipal.BringToFront();
        }
    }
}

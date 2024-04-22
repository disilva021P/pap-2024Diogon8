using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
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
            preencheUsers();
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
        void preencheUsers()
        {
            users.Clear();
            using (MySqlConnection connection = new MySqlConnection(LoginAdmin.connectionString))
            {
                connection.Open();
                string query = "SELECT nif, nome, sobrenome, morada, dataNascimento, email, foto,comentarios,numero,dataInscricao,nOcorrenciasCometidas," +
                    "(SELECT estado FROM estadoutilizador WHERE idEstadoUtilizador = utilizador.idEstadoUtilizador) AS estado_utilizador," +
                    "(SELECT titulo FROM planos WHERE idPlano = utilizador.idplano) AS nome_plano," +
                    "(SELECT localizacaoTxt FROM localizacao WHERE idlocalizacao = utilizador.idlocalizao) AS localizacao FROM    utilizador;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Utilizador u = new Utilizador();
                    u.Nif = dr.GetInt32(0);
                    u.Nome = dr.GetString(1);
                    u.Sobrenome = dr.GetString(2);
                    u.Morada = dr.GetString(3);
                    u.DataNascimento = dr.GetDateTime(4).Date;
                    u.Email = dr.GetString(5);
                    u.Foto = (byte[])dr[6];
                    u.Comentarios = dr.GetString(7);
                    u.Numero = dr.GetString(8);
                    u.DataInscricao = dr.GetDateTime(9).Date;
                    u.NOcorrenciasCometidas = dr.GetInt32(10);
                    u.IdEstadoUtilizador = dr.GetString(11);
                    u.IdPlano = dr.GetString(12);
                    u.IdLocalizacao = dr.GetString(13);
                    users.Add(u);
                }
                dr.Close();
            }
        }
        public UserControl carregarUsers()
        {
            UserControl utilizadores = new Utilizadores(users);
            return utilizadores;
        }
        public Pagamentos carregarPagamentos()
        {
            Pagamentos panlepagamento = new Pagamentos(users);
            return panlepagamento;
        }
        public EstacionamentoControl carregarEstacionamento()
        {
            EstacionamentoControl panelEstacionamento = new EstacionamentoControl(users);
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
            EstacionamentoControl panelEstacionamento = carregarEstacionamento();
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(panelEstacionamento);
            PanelPrincipal.BringToFront();
        }
    }
}

using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class Utilizadores : UserControl
    {
        List<Utilizador> users;
        public Utilizadores(List<Utilizador> users)
        {
            InitializeComponent();
            this.users = users;
            scrollbar1.Minimum = PanelUnico.VerticalScroll.Minimum;
            scrollbar1.Maximum = PanelUnico.VerticalScroll.Maximum;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (PanelUnico.Controls.Count > 0)
            {
                PanelUnico.Controls.Clear();
            }
            foreach (Utilizador u in users)
            {
                User user = new User(u);
                PanelUnico.Controls.Add(user);

            }
        }

        private void PanelUnico_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void PanelUnico_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text.Count() > 0)
            {
                if (int.TryParse(txtPesquisa.Text,out int resultado))
                {
                    List<Utilizador> usersProcurados = users.Where(u => u.Nif.ToString().StartsWith(txtPesquisa.Text, StringComparison.OrdinalIgnoreCase) ).ToList();
                    if (PanelUnico.Controls.Count > 0)
                    {
                        PanelUnico.Controls.Clear();
                    }
                    foreach (Utilizador u in usersProcurados)
                    {
                        User user = new User(u);
                        PanelUnico.Controls.Add(user);
                    }
                }
                else
                {
                    List<Utilizador> usersProcurados = users.Where(u => u.Nome.StartsWith(txtPesquisa.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                    if (PanelUnico.Controls.Count > 0)
                    {
                        PanelUnico.Controls.Clear();
                    }
                    foreach (Utilizador u in usersProcurados)
                    {
                        User user = new User(u);
                        PanelUnico.Controls.Add(user);
                    }
                }
                
            }
            else
            {
                PanelUnico.Controls.Clear();
                foreach (Utilizador u in users)
                {
                    User user = new User(u);
                    PanelUnico.Controls.Add(user);
                }
            }

        }

        private void btnEditarUser_Click(object sender, EventArgs e)
        {
            if (User.nifSelecionado == 0)
            {
                PopUp newa = new PopUp("Selecione alguém!", 1);
                newa.Show();
            }
            else
            {
                Form formularioPrincipal = this.FindForm();

                // Verifica se o formulário pai é do tipo desejado (Gestao) 
                if (formularioPrincipal is Gestao gestao)
                {
                    // Acesse o painel no formulário principal
                    Guna2Panel painelPrincipal = (Guna2Panel)gestao.ObterPainelPrincipal();
                    AdicionarUser plusUser = new AdicionarUser(users,users.Where(u => u.Nif == User.nifSelecionado).ToList()[0]);
                    
                    painelPrincipal.Controls.Clear();
                    painelPrincipal.Controls.Add(plusUser);
                }
                User.nifSelecionado = 0;
            }
        }

        private void btnRemoverUsesr_Click(object sender, EventArgs e)
        {
            if(User.nifSelecionado != 0)
            {
                using (MySqlConnection connection = new MySqlConnection(LoginAdmin.connectionString))
                {
                    connection.Open();
                    string sqls = "Select COUNT(*) FROM utilizadorlogin WHERE nif = @n AND nivel=1";
                    MySqlCommand cmds = new MySqlCommand(sqls, connection);
                    cmds.Parameters.AddWithValue("@n", User.nifSelecionado);
                    if (cmds.ExecuteNonQuery() <= 0)
                    {
                        if (LoginAdmin.nivel != 2)
                        {
                            PopUp erro = new PopUp("Não pode remover um Admin sem ser o administrador principal!", 1);
                            erro.ShowDialog();
                            return;
                        }
                        PopUp remover = new PopUp("Tem a certeza que deseja remover o utilizador com o nif: \n" + User.nifSelecionado.ToString(), 3);
                        remover.ShowDialog();
                        if (PopUp.Valor)
                        {
                            try
                            {
                            Utilizador userDelete = users.Where(u => u.Nif == User.nifSelecionado).First();
                            users.Remove(userDelete);
                            string sql = "DELETE FROM utilizador WHERE nif = @n";
                            MySqlCommand cmd = new MySqlCommand(sql, connection);
                            cmd.Parameters.AddWithValue("@n", User.nifSelecionado);
                                try
                                {


                                    if (cmd.ExecuteNonQuery() > 0)
                                    {
                                        if (PanelUnico.Controls.Count > 0)
                                        {
                                            PanelUnico.Controls.Clear();
                                        }
                                        foreach (Utilizador u in users)
                                        {
                                            User user = new User(u);

                                            PanelUnico.Controls.Add(user);
                                            User.nifSelecionado = 0;

                                        }
                                        //string sql1 = "DELETE FROM utilizadorlogin WHERE nif = @n";
                                        //MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
                                        //cmd1.Parameters.AddWithValue("@n", User.nifSelecionado);
                                        PopUp sucesso = new PopUp("Utilizador removido com sucesso!", 1);
                                        sucesso.ShowDialog();
                                    }
                                else
                                {
                                    PopUp erro = new PopUp("Erro inesperado", 1);
                                    erro.ShowDialog();
                                }
                                }
                                catch (Exception ex) { }

                                connection.Close();
                            }
                            catch (Exception ex)
                            {
                                PopUp sucesso = new PopUp("Não pode remover um utilizador presente, coloque em desativado!", 1);
                                sucesso.ShowDialog();

                            }
                        }
                    }
                    }
                }
            else
            {
                PopUp erro = new PopUp("Selecione alguém!", 1);
                erro.ShowDialog();
            }
        }
                        
            
            
        

        private void btnAdicionarUser_Click(object sender, EventArgs e)
        {
            Form formularioPrincipal = this.FindForm();

            // Verifica se o formulário pai é do tipo desejado (Gestao)
            if (formularioPrincipal is Gestao gestao)
            {
                // Acesse o painel no formulário principal
                Guna2Panel painelPrincipal = (Guna2Panel)gestao.ObterPainelPrincipal();
                AdicionarUser plusUser = new AdicionarUser(users);
                painelPrincipal.Controls.Clear();
                painelPrincipal.Controls.Add(plusUser);
            }
            User.nifSelecionado = 0;
        }
    }
}

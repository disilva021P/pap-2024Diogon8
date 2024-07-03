using MySql.Data.MySqlClient;
using System;

using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class Lugar : UserControl
    {
        public Utilizador utilizador;
        int n;
        public bool clicado = false;
        public bool lugarRegistado=false;
        public Lugar(Utilizador user,int n)
        {
            InitializeComponent();
            this.utilizador = user;
            this.n = n;
            if (user!=null ) {
                using (MemoryStream ms = new MemoryStream(user.Foto))
                {
                    Image imagem = Image.FromStream(ms);
                    guna2PictureBox1.Image = imagem;
                }
            }
            nLugar.Text = (n).ToString();
            nLugar.Location = new Point(nLugar.PreferredWidth - 10, 0);
            nLugar.Parent = guna2PictureBox1;
            nLugar.BackColor = Color.Transparent;
            lugarRegistado=true;
            
        }
        public Lugar(int n)
        {
            InitializeComponent();
            this.n = n;
            nLugar.Text = (n).ToString();
            nLugar.Parent = guna2PictureBox1;
            nLugar.BackColor = Color.Transparent;
            nLugar.Anchor = AnchorStyles.None;
            int x = (this.ClientSize.Width - nLugar.Width) / 2;
            int y = (this.ClientSize.Height - nLugar.Height) / 2;
            nLugar.Location = new Point(x, y);
            lugarRegistado = true;
        }
        public Lugar()
        {
            InitializeComponent();
            guna2PictureBox1.Visible=false;
            nLugar.Visible=false;
            nLugar.Parent = guna2PictureBox1;
            nLugar.BackColor = Color.Transparent;
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Lugar_Load(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            guna2PictureBox1.Click += ClickForm;
            nLugar.Click += ClickForm;
            nLugar.DoubleClick += doubleclick;
            guna2PictureBox1.DoubleClick += doubleclick;
        }
        public void ClickForm(object sender, EventArgs e)
        {
            if (EstacionamentoControl.edit)
            {
                if (lugarRegistado && utilizador == null)
                {
                    PopUp confirmar = new PopUp("Deseja adicionar um utilizador?", 2);
                    confirmar.ShowDialog();
                    if (PopUp.Valor)
                    {
                        SelecaoUsers janela = new SelecaoUsers(Utilizador.getUsersSemLugar());
                        janela.ShowDialog();
                        if (SelecaoUsers.devolvido != null)
                        {
                            utilizador = SelecaoUsers.devolvido;
                            using(MySqlConnection con = new MySqlConnection(LoginAdmin.connectionString))
                            {
                                con.Open();
                                string sql = "UPDATE lugar SET nif=@nif where nLugarGrid=@lugarGrid;";
                                MySqlCommand cmd = new MySqlCommand(sql,con);
                                cmd.Parameters.AddWithValue("@nif", utilizador.Nif);
                                cmd.Parameters.AddWithValue("@lugarGrid", n-1);
                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    nLugar.Text = (n).ToString();
                                    nLugar.Location = new Point(nLugar.PreferredWidth - 10, 0);
                                    using (MemoryStream ms = new MemoryStream(utilizador.Foto))
                                    {
                                        Image imagem = Image.FromStream(ms);
                                        guna2PictureBox1.Image = imagem;
                                    }
                                   
                                    var panel = this.Parent.Parent.Controls["panelConfiguracoes"].Controls["painelEdita"];
                                    string[] txt = EstacionamentoControl.preenchetxt();
                                    ((Label)panel.Controls["lblLugaresInseridos"]).Text = txt[0];
                                    ((Label)panel.Controls["lblPorInserir"]).Text = txt[1];
                                }
                                con.Close();
                            }
                        }
                    }
                    return;
                }
                else if (utilizador != null)
                {
                    PopUp confirmar = new PopUp("Deseja remover o / a utilizador(a) " + utilizador.Nome + " deste lugar ? ", 3);
                    confirmar.ShowDialog();
                    if (PopUp.Valor)
                    {
                        
                        using (MySqlConnection con = new MySqlConnection(LoginAdmin.connectionString))
                        {
                            con.Open();
                            string sql = "UPDATE lugar SET nif=null where Nlugar=@lugar;";
                            MySqlCommand cmd = new MySqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@lugar", n);
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                guna2PictureBox1.Image = null;
                                int x = (this.ClientSize.Width - nLugar.Width) / 2;
                                int y = (this.ClientSize.Height - nLugar.Height) / 2;
                                nLugar.Location = new Point(x, y);
                                utilizador=null;
                                var panel = this.Parent.Parent.Controls["panelConfiguracoes"].Controls["painelEdita"];
                                string[] txt = EstacionamentoControl.preenchetxt();
                                ((Label)panel.Controls["lblLugaresInseridos"]).Text = txt[0];
                                ((Label)panel.Controls["lblPorInserir"]).Text = txt[1];


                            }
                            con.Close();
                        }
                    }
                }
            }
            if (EstacionamentoControl.nLugares != -1)
            {
                

                if (guna2PictureBox1.Visible)
                {
                    if (nLugar.Text == EstacionamentoControl.LugaresInseridos.ToString())
                    {
                        guna2PictureBox1.Visible = false;
                        nLugar.Visible = false;
                        EstacionamentoCriar.lugaresIniciais[Convert.ToInt32(this.Name)] = null;
                        ++EstacionamentoControl.nLugares;
                        --EstacionamentoControl.LugaresInseridos;

                    }
                    else
                    {
                        PopUp erro = new PopUp("Não pode retirar um lugar colocado antes (tem de ser o mais recente)", 1);
                        erro.ShowDialog();
                    }
                    
                }
                else
                {
                    if (EstacionamentoControl.nLugares < 1)
                    {
                        PopUp msg = new PopUp("Não pode inserir mais lugares!", 1);
                        msg.ShowDialog();
                        return;
                    }
                    EstacionamentoCriar.lugaresIniciais[Convert.ToInt32(this.Name)] = EstacionamentoControl.LugaresInseridos+1;

                    ++EstacionamentoControl.LugaresInseridos;
                    --EstacionamentoControl.nLugares;
                    guna2PictureBox1.Visible = true;
                    nLugar.Text = EstacionamentoControl.LugaresInseridos.ToString();
                    nLugar.Visible = true;


                }
            }

            return;
        }
        public void doubleclick(object sender, EventArgs e)
        {
            if (utilizador != null)
            {
                UtilizadorInfo painelUser = new UtilizadorInfo(utilizador);
                painelUser.Show();
                
            }
        }
    }
}

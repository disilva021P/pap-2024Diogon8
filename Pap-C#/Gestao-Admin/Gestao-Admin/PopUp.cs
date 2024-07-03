using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class PopUp : Form
    {
        private static bool clique;
        static public bool Valor
        {
            get { return clique; }
        }
        int caso;
        public PopUp(string mensagemR, int caso)
        {
            InitializeComponent();
            this.caso = caso;
            //caso 1- apenas ok the horse is here
            //caso 2- confirmar algo
            //caso 3- eliminar algo
            //caso 4- sair
            this.mensagem.Text = mensagemR;
            if (caso == 1)
            {
                btn2.Enabled = false;
                btn2.Visible = false;
                btn1.Width = guna2Panel2.Width;
            }
            else if (caso == 2)
            {
                btn1.Text = "Cancelar";
            }
            else if(caso == 3)
            {
                btn1.Text = "Cancelar";
                btn2.Text = "Eliminar";
                btn2.FillColor = Color.FromArgb(226, 71, 71);
            }
            else
            {
                btn1.Text = "Cancelar";
                btn2.Text = "Sair";
                btn2.FillColor = Color.FromArgb(226, 71, 71);
            }
        }
        bool pago;
        public PopUp(int caso,bool pago)
        {
            InitializeComponent();
            //o caso 5 é especifico para o processo inicial
            this.caso = caso;
            this.pago = pago;
            mensagem.Text = "Número de lugares:";
            btn2.Enabled = false;
            btn2.Visible = false;
            txtLugares.Visible = true;
            btn1.Text = "Inserir";
            btn1.Width = guna2Panel2.Width;
            
        }

        private void mensagem_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (caso != 5)
            {
                clique = false;
                this.Close();
            }
            else
            {
                if(Int32.TryParse(txtLugares.Text, out int val))
                {
                    using (MySqlConnection connection = new MySqlConnection(LoginAdmin.connectionString))
                    {
                        connection.Open();
                        string query = "Insert into confs(ConfigPago,LugaresMarcados) Values (@pago,@lugares);";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        if ((bool)pago)
                        {
                            cmd.Parameters.AddWithValue("@pago", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@pago", 0);
                        }
                        cmd.Parameters.AddWithValue("@lugares", 1);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            
                        }
                        else
                        {
                            PopUp erro = new PopUp("Erro ao adicionar configurações tente denovo!", 1);
                            erro.ShowDialog();
                        }
                        string sql1 = "INSERT INTO lugar(idOcupacao) Values (0) ";
                        MySqlCommand cmd1 = new MySqlCommand(sql1, connection);
                        for (int i = 0; i < val; i++)
                        {
                            cmd1.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    this.Hide();
                    EstacionamentoCriar est = new EstacionamentoCriar(val);
                    est.ShowDialog();
                    PopUp sucesso = new PopUp("Configurações inseridas\n Bom Proveito!", 1);
                    sucesso.ShowDialog();
                    LoginAdmin form = new LoginAdmin();
                    form.ShowDialog();
                    
                }
                else
                {
                    PopUp erro = new PopUp("Erro insira um valor válido!", 1);
                    erro.ShowDialog();
                }
                
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            clique = true;
            this.Close();

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

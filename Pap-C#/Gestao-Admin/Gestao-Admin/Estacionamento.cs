using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;

namespace Gestao_Admin
{
    public partial class Estacionamento : Form
    {
        bool clicado = false;
        int n_lugares;
        List<int> lugaresnopainel = new List<int>();
        
        public Estacionamento(int n_lugares)
        {
            InitializeComponent();
            EstacionamentoControl ec = new EstacionamentoControl(n_lugares);
            this.panelEstacionamentoEdit.Controls.Add(ec);
        }
        private void Estacionamento_Load(object sender, EventArgs e)
        {
            
        }



        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lugar_MouseDown(object sender, MouseEventArgs e)
        {
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (lugaresnopainel.Count < n_lugares)
            {
                PopUp erro = new PopUp("Tem que escolher os lugares todos!", 1);
                erro.ShowDialog();
                return;
            }
            using(MySqlConnection conn = new MySqlConnection(LoginAdmin.connectionString))
            {
                conn.Open();
                string sql = "UPDATE lugar SET nLugarGrid=@grid where Nlugar=@lugar ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                for (int i = 0; i < n_lugares; i++)
                {
                    cmd.Parameters.AddWithValue("@grid", lugaresnopainel[i]);
                    cmd.Parameters.AddWithValue("@lugar", i+1);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                conn.Close();
            }
            
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
    }
}


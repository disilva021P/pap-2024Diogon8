using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Admin
{
    public partial class PopUp : Form
    {
        bool clique;
        public bool Valor
        {
            get { return clique; }
        }
        public PopUp(string mensagem, int caso)
        {
            InitializeComponent();

            //caso 1- apenas ok the horse is here
            //caso 2- confirmar algo
            //caso 3- eliminar algo
            this.mensagem.Text = mensagem;
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
            else
            {
                btn1.Text = "Cancelar";
                btn2.Text = "Eliminar";
                btn2.FillColor = Color.FromArgb(226, 71, 71);
            }
        }

        private void mensagem_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            clique = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.n_lugares = n_lugares;
        }

        private void Estacionamento_Load(object sender, EventArgs e)
        {
            CriarNovoPainelInicial();
            lblPorInserir.Text = n_lugares.ToString();
        }

        private void CriarNovoPainelInicial()
        {
            for(int i = -9; i < 117 ; i++) 
            {
                Panel currentPanel = new Panel
                {
                    Size = new Size(100, 80),
                    BackColor = Color.Blue,
                    BorderStyle = BorderStyle.FixedSingle,
                    Name = i.ToString(),
                    
                        
                };
                if (i < 0)
                    currentPanel.Enabled = false;
                Panel.Controls.Add(currentPanel);
            }
            

            

        }



        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lugar_MouseDown(object sender, MouseEventArgs e)
        {
            clicado=true;
        }

        private void Lugar_MouseUp(object sender, MouseEventArgs e)
        {
            clicado = false;
            Control controleSobOMouse = Panel.GetChildAtPoint(e.Location);
            if(controleSobOMouse == null)
            {
                return; 
            }
            if(!controleSobOMouse.Enabled)
            {
                return ;
            }
            int lugar = Convert.ToInt32(controleSobOMouse.Name);
            if (lugaresnopainel.Contains(lugar))
            {
                return;
            }
            if(lugaresnopainel.Count< n_lugares)
            {
                controleSobOMouse.BackColor = Color.Red;
                lugaresnopainel.Add(lugar);
                lblLugaresInseridos.Text = lugaresnopainel.Count.ToString();
                lblPorInserir.Text = (n_lugares - lugaresnopainel.Count).ToString();
            }
            else
            {
                PopUp erro = new PopUp("Já desenhou todos o lugares possivei, se quiser adicionar mais volte nas configurações e aumente o valor", 1);
                erro.ShowDialog();
            }
            
                
        }
    }
}


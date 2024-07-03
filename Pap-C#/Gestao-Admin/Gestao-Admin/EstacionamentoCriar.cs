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
    public partial class EstacionamentoCriar : Form
    {
        static public Dictionary<int,int?> lugaresIniciais = new Dictionary<int,int?>();
        int n;
        public EstacionamentoCriar(int n)
        {
            InitializeComponent();
            this.n = n;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EstacionamentoCriar_Leave(object sender, EventArgs e)
        {

        }

        private void EstacionamentoCriar_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(new EstacionamentoControl(n));
            panel1.Padding = new Padding(50,0,0,0);
        }
    }
}

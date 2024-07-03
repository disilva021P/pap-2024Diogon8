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
    public partial class MostrarOcorrencia : Form
    {
        int id;
        public MostrarOcorrencia(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void MostrarOcorrencia_Load(object sender, EventArgs e)
        {
            OcorrenciaControl oc = new OcorrenciaControl(id);
            guna2Panel1.Controls.Add(oc);
        }
    }
}

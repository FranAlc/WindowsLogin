using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsCRUD
{
    public partial class escritorioWindows : Form
    {
        public escritorioWindows()
        {
            InitializeComponent();
        }

        private void pbApagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbWindows_Click(object sender, EventArgs e)
        {
            if(gbDespliegue.Visible == false)
            {
                 gbDespliegue.Visible = true;
             
            }
            else
            {
                gbDespliegue.Visible = false;
            }
        }

        private void lblhorario_Click(object sender, EventArgs e)
        {

        }

        private void escritorioWindows_Load(object sender, EventArgs e)
        {
            tmrTiempo.Enabled = true;
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            lblhorario.Text = DateTime.Now.ToString("HH:mm");
        }

        private void label2_Click(object sender, EventArgs e) //abre calculadora
        {
            Calculadora calculadora = new Calculadora();
            calculadora.ShowDialog();
        }

        private void pbCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.ShowDialog();
        }
    }
}

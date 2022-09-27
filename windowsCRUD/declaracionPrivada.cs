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
    public partial class declaracionPrivada : Form
    {
        public declaracionPrivada()
        {
            InitializeComponent();
        }

        private void pbRegresaIngreso_Click(object sender, EventArgs e)
        {
            ingresoWindows ingreso = new ingresoWindows();
            ingreso.Show();

        }
    }
}

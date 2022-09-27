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
    public partial class login : Form
    {


        public login(ingresoWindows.usuarioText_Ingreso info)
        {
            InitializeComponent();
            
            txtUsuarioLogin.Text = info.usuario;
            txtPassLogin.Text = info.pass;
        }

        private void pbOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            escritorioWindows escritorio = new escritorioWindows();
            escritorio.ShowDialog();
        }
    }
}

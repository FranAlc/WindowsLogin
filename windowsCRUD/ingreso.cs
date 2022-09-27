using MySql.Data.MySqlClient.Authentication;
using MySql.Data.Types;
using MySql.Data.MySqlClient;


namespace windowsCRUD
{
   
    public partial class ingresoWindows : Form
    {
       
        public ingresoWindows()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblDeclaracion_Click(object sender, EventArgs e)
        {
            
            declaracionPrivada decla = new declaracionPrivada();
            decla.Show();
            
        }

        

        /*
         *usuario
         */
        public struct usuarioText_Ingreso {
            public string usuario;
            public string pass;
        }

        /******************************************************
         *  Registro a la base de datos SQL :P
         ******************************************************/

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

             


            if (txtClave.Text == "" && txtClave2.Text == "" ) //Si las claves no son iguales no se ingresa
            {
                errorProvider.SetError(txtClave, "Ingresa una clave.");

                if (txtClave.Text != txtClave2.Text)
                {
                    errorProvider.SetError(txtClave, "Las contraseñas son diferentes.");

                }
                
            }
            else if (txtClave.Text == txtClave2.Text) 
            {
                usuarioText_Ingreso dato; //Ingreso desde la struct
                dato.usuario = txtUsuario.Text;
                dato.pass = txtClave.Text;
                login login = new login(dato);

                
                login.Show();

                this.Hide();
                
            }

            else
            {
                errorProvider.SetError(txtClave, "Error al ingresar la contraseña.");
            }

   

        }

        private void label7_Click(object sender, EventArgs e)
        {
            escritorioWindows escritorio = new escritorioWindows();

            escritorio.ShowDialog();
            this.Hide();

        }
    }
}
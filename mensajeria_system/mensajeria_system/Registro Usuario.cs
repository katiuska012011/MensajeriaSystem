using System;
using System.Windows.Forms;

namespace mensajeria_system
{
    public partial class Registro_Usuario : Form
    {
        //instancia de nuestra clase donde se aloja la coneccion
        dbconection conect = new dbconection();
        public Registro_Usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            //Validar contrasenas
            if(txtContrasena.Text != txtVerificarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            if(txtNombre.Text == "" || txtApellido.Text == "" || txtCorreo.Text == "" || txtContrasena.Text==""){
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                //Hacemos instancia de nuestra conexion y llamamos nuestra funcion de crear usuario
                conect.crearUsuario(txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtContrasena.Text);
                MessageBox.Show("Usuario de " + txtNombre.Text + "  creado con exito");
                login login = new login();
                login.Show();
                this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Usuario_Load(object sender, EventArgs e)
        {
            login login = new login();
            login.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;

namespace mensajeria_system
{
    public partial class login : Form
    {
        dbconection conect = new dbconection();
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            //Evento para abrir el validar la contrase;a del admin de registrar usuario
            confirmarAdmin admin = new confirmarAdmin();
            admin.Show();
            this.Hide();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if(conect.Login(txtCorreo.Text, txtContrasena.Text) == true)
            {
                MessageBox.Show("Bienvenido");
                Principal principal = new Principal();
                principal.Show();
                this.Hide();
            }
        }
    }
}

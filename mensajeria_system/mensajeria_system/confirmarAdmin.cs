using System;
using System.Windows.Forms;

namespace mensajeria_system
{
    public partial class confirmarAdmin : Form
    {
        dbconection conect = new dbconection();
        public confirmarAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(conect.Admin(txtAdmin.Text) == true)
            {
                 MessageBox.Show("Usted es administrador");
                 Registro_Usuario registro = new Registro_Usuario();
                 registro.Show();
                 this.Hide();
            }
            else
            {
                MessageBox.Show("No eres admnistrador");
            }
        }
    }
}

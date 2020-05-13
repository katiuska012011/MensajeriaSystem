using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace mensajeria_system
{

    class dbconection
    {
    SqlConnection  conn; //Conexion
    SqlCommand cmd; //Query
        public dbconection()
        {
            try
            {
                //Esta es la conexion de nuestra base de datos
                conn = new SqlConnection("Data Source=.;Initial Catalog=sistema_mensajeria;Integrated Security=True");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion" + ex.ToString());
            }
            conn.Close();
        }

        //Esta es nuestra funcion para crear un usuario
        public string crearUsuario(string nombre, string apellido, string correo, string contrasena)
        {
            string salida = "Se creo";

            try
            {
                conn.Open();
                //Comando para insertar los datos en la base de datos
                cmd = new SqlCommand("insert into usuarios(Nombre, Apellido, Correo, Contrasena) values ('"+nombre+"','"+apellido+"','"+correo+"','"+contrasena+"')",conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                 salida = "No se creo"+ex.ToString();
            }
            conn.Close();
            return salida;
        }

        public Boolean Login(string correo, string contrasena)
        {
            Boolean resultado = false;
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * From usuarios where Correo = @Correo AND Contrasena = @Contrasena", conn);
                cmd.Parameters.AddWithValue("Correo", correo);
                cmd.Parameters.AddWithValue("Contrasena", contrasena);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    resultado = true;
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            return resultado;
        }

        public Boolean Admin(string contrasena)
        {
            Boolean resultado = false;
            if (contrasena == "123")
            {
                resultado = true;
            }
            return resultado;

        }
    }
}

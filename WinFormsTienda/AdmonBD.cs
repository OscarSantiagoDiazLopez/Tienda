using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using Mysqlx.Crud;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;


namespace WinFormsTienda
{
    public class AdmonBD
    {
        private MySqlConnection connection;
        
        public AdmonBD()
        {
            this.Connect();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                //MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool ValidarUsuario(string usuario, string contrasena)
        {
            try
            {
                // Consulta SQL para verificar las credenciales
                string query = "SELECT COUNT(*) FROM cuentas WHERE Usuario = @Usuario AND Contrasena = @Contrasena";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);

                    // Ejecutar la consulta
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Si el resultado es 1, las credenciales son correctas
                    return count == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////


        public void Connect()
        {
            string cadena = "Server=localhost; Database=tienda; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

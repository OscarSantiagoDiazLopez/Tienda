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
        
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool ValidarUsuario(string usuario, string contrasena)
        {
            try
            {
                // Cadena de conexión
                string connectionString = "Server=localhost; Database=tienda; User=root; Password=; SslMode=none;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL corregida
                    string query = "SELECT COUNT(*) FROM cuentas WHERE APODO = @Usuario AND CONTRASENA = @Contrasena";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar parámetros
                        command.Parameters.AddWithValue("@Usuario", usuario);
                        command.Parameters.AddWithValue("@Contrasena", contrasena);

                        // Ejecutar la consulta
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count == 1; // Devuelve true si el usuario existe
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public string ObtenerModoUsuario(string usuario)
{
    try
    {
        // Cadena de conexión
        string connectionString = "Server=localhost; Database=tienda; User=root; Password=; SslMode=none;";

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            // Consulta SQL para obtener el campo MODO
            string query = "SELECT MODO FROM cuentas WHERE APODO = @Usuario";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // Agregar parámetros
                command.Parameters.AddWithValue("@Usuario", usuario);

                // Ejecutar la consulta y obtener el valor
                object result = command.ExecuteScalar();
                return result?.ToString() ?? string.Empty; // Devuelve el valor o una cadena vacía si no hay resultados
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error al obtener el modo del usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return string.Empty;
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
                //MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

    }
}

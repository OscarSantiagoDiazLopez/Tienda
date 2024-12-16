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
<<<<<<< HEAD

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

=======
        
>>>>>>> 4dbb0cbc5f5156335bf38028c0bdd6a4f5810411
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
<<<<<<< HEAD
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
        
        public string MostrarUsuario(string usuario)
        {
            try
            {
                // Cadena de conexión
                string connectionString = "Server=localhost; Database=tienda; User=root; Password=; SslMode=none;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //Cosulta SQL para obtener el campo NOMBRECOMPLETO
                    string query = "SELECT NOMBRECOMPLETO FROM cuentas WHERE APODO = @Usuario";
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

        public List<Colmena> MostrarInformacion()
        {
                List<Colmena> data = new List<Colmena>();
                Colmena item;

                int idP;
                string imagen;
                string descripcion;
                int precio;
                int existencias;

            try
                {
                    string query = "SELECT * FROM productos";
                    MySqlCommand command = new MySqlCommand(query, this.connection);

                    // Ejecutar la consulta y leer los resultados
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        idP = Convert.ToInt32(reader["ID"]);
                        imagen = Convert.ToString(reader["IMAGEN"]) ?? "";
                        descripcion = Convert.ToString(reader["DESCRIPCION"]) ?? "";
                        precio = Convert.ToInt32(reader["PRECIO"]);
                        existencias = Convert.ToInt32(reader["EXISTENCIA"]);

                    item = new Colmena(idP, imagen, descripcion, precio, existencias);
                        data.Add(item);
                    }

                    reader.Close();
                }
                catch(Exception ex)
                {
                this.Disconnect();
                }

                return data;
         }
    
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
=======
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
>>>>>>> 4dbb0cbc5f5156335bf38028c0bdd6a4f5810411


        public void Connect()
        {
            string cadena = "Server=localhost; Database=tienda; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
<<<<<<< HEAD
                //MessageBox.Show("Conexión establecida exitosamente.", "Información" MessageBoxButtons.OK, MessageBoxIcon.Information);
=======
                //MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
>>>>>>> 4dbb0cbc5f5156335bf38028c0bdd6a4f5810411
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

    }
}

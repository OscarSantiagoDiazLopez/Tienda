﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsTienda
{
    public partial class FormLOGIN : Form
    {
        public FormLOGIN()
        {
            InitializeComponent();
        }

        private void buttonSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void bottonINICIAR_Click_1(object sender, EventArgs e)
        {
            string usuario = textBoxUSUARIO.Text.Trim();
            string contrasena = textBoxCONTRASENA.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AdmonBD db = new AdmonBD();

                // Validar usuario
                if (db.ValidarUsuario(usuario, contrasena))
                {
                    // Obtener el modo del usuario
                    string modo = db.ObtenerModoUsuario(usuario);
<<<<<<< HEAD
                    string nombre = db.MostrarUsuario(usuario);
=======
>>>>>>> 4dbb0cbc5f5156335bf38028c0bdd6a4f5810411

                    // Redirigir segun el modo
                    if (modo == "administrador")
                    {
                        MessageBox.Show("Bienvenido, Administrador.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
<<<<<<< HEAD
                        FormAdmin formAdmin = new FormAdmin();
                        this.Hide();
                        formAdmin.ShowDialog();
=======
                        this.Hide();
                        FormAdmin formAdmin = new FormAdmin();
>>>>>>> 4dbb0cbc5f5156335bf38028c0bdd6a4f5810411
                        formAdmin.Show();
                    }
                    else if (modo == "usuario")
                    {
                        MessageBox.Show("Bienvenido, Usuario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
<<<<<<< HEAD
                        FormUsuario formUsuario = new FormUsuario(nombre);
                        this.Hide();
                        formUsuario.ShowDialog();
                        this.Show();
=======
                        this.Hide();
                        FormUsuario formUsuario = new FormUsuario();
                        formUsuario.Show();
>>>>>>> 4dbb0cbc5f5156335bf38028c0bdd6a4f5810411
                    }
                    else
                    {
                        //MessageBox.Show("Modo de usuario desconocido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Acceso denegado. Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

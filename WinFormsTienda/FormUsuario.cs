using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTienda
{
    public partial class FormUsuario : Form
    {
        List<Colmena> data;
        private string nombre;
        public FormUsuario(string nombre)
        {
            this.nombre = nombre;
            InitializeComponent();
            CargarImagenesEnPictureBox();
            timer1.Enabled = true;
            this.textBoxNombre.Text = this.nombre;
            //NombreUsu();
        }

        /*private void NombreUsu()
        {
            AdmonBD obj = new AdmonBD();
            data = obj.Mostrarusuario();

            /*mostrar toda la informacion
            this.textBoxNombre.Clear();
            data.ForEach(x =>
            {
                this.textBoxNombre.AppendText(x.Nomcompleto);
            });

            obj.Disconnect();
        }*/

        private void Info()
        {
            AdmonBD obj = new AdmonBD();
            data = obj.MostrarInformacion();
            
            //mostrar toda la informacion
            data.ForEach(x =>
            {

            }

        }

        private void CargarImagenesEnPictureBox()
        {

            // Lista de nombres de las imágenes
            List<string> imagen = new List<string>()
            {
                "crema.jpeg",
                "jarabe.jpeg",
                "mielAbeja.jpeg",
                "mielP.jpeg",
                "shampoo.jpeg"
            };

            // Array de PictureBox
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };

            // Ruta de la carpeta donde se almacenan las imágenes
            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagen");



            // Cargar las imágenes
            for (int i = 0; i < imagen.Count; i++)

            {
                // string rutaImagen = Path.Combine(rutaCarpeta, imagen[i]);
                string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagen", imagen[i]);
                // MessageBox.Show($"Ruta generada: {rutaImagen}");


                // Verifica si el archivo existe
                if (File.Exists(rutaImagen))
                {
                    pictureBoxes[i].Image = Image.FromFile(rutaImagen);
                    pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta la imagen al tamaño del PictureBox
                }
                else
                {
                    MessageBox.Show($"No se encontró la imagen: {rutaImagen}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelFECHA.Text = DateTime.Now.ToLongDateString();
            labelHORA.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void buttonLOGOUT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CERRANDO SESION");
            this.Close();
        }
    }
}

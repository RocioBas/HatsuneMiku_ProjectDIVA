using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HatsuneMiku_ProjectDIVA
{
    public partial class Reproductor : Form
    {
        public Reproductor()
        {
            InitializeComponent();
            leerFicheroVideos();
        }

        private void leerFicheroVideos()
        {
            string line;
            try
            {
                StreamReader fileVideos = new StreamReader($"./ficheros/canciones.txt");
                while ((line = fileVideos.ReadLine()) != null)
                {
                    string[] partes = line.Split(';');
                    lbListaVideos.Items.Add(partes[0]);
                }
                fileVideos.Close();
            }
            catch (FileNotFoundException)
            {
                // Cambiar ??
                MessageBox.Show("Fichero no encontrado");
            }
            catch (IOException error)
            {
                // Cambiar ??
                MessageBox.Show("ERROR: " + error);
            }
        }

        private void btReproducir_Click(object sender, EventArgs e)
        {
            string ruta =  "./videos/"+ (string)lbListaVideos.SelectedItem + ".mp4";
            axWindowsMediaPlayer.URL = ruta;
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Form modoJuego = new ModoJuego();

            axWindowsMediaPlayer.Ctlcontrols.stop();
            this.Hide();
            modoJuego.ShowDialog();
        }

        
    }
}

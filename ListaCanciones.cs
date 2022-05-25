using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HatsuneMiku_ProjectDIVA
{
    public class ListaCanciones
    {
        List<Cancion> listaCanciones;

        public ListaCanciones()
        {
            listaCanciones = new List<Cancion>();
            leerCanciones();
        }

        private void leerCanciones()
        {
            string line;
            Cancion c;

            try
            {
                StreamReader fileCanciones = new StreamReader("./ficheros/canciones.txt");
                while ((line = fileCanciones.ReadLine()) != null)
                {
                    c = crearCancion(line);
                    listaCanciones.Add(c);
                }
                fileCanciones.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se ha encontrado el fichero de las canciones", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException error)
            {
                MessageBox.Show(error + "", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Cancion crearCancion(string line)
        {
            string[] partes = line.Split(';');
            return new Cancion(partes[0], Single.Parse(partes[1]), Int32.Parse(partes[2]));
        }

       
        public Cancion CancionAleatoria()
        {
            Random rng = new Random();

            Cancion[] canciones = listaCanciones.ToArray();

            rng.Shuffle(canciones);
            return canciones[rng.Next(0, canciones.Length)];
        }
    }
}

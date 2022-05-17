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
                StreamReader fileCanciones = new StreamReader(".\\ficheros\\canciones.txt");
                while ((line = fileCanciones.ReadLine()) != null)
                {
                    c = crearCancion(line);
                    listaCanciones.Add(c);
                }
                fileCanciones.Close();
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

        private Cancion crearCancion(string line)
        {
            string[] partes = line.Split(';');
            return new Cancion(partes[0], Single.Parse(partes[1]));
        }

        private int randomNumber()
        {
            Random rnd = new Random();
            //int random  = rnd.Next(0, listaCanciones.Count() + 1);
            return rnd.Next(0, listaCanciones.Count()); 
        }

        public Cancion CancionAleatoria()
        {
            //List<Cancion> randomized = (List<Cancion>)listaCanciones.OrderBy(item => rnd.Next());
            //return listaCanciones[rnd.Next(listaCanciones.Count())]; 

            return listaCanciones[randomNumber()];
        }
    }
}

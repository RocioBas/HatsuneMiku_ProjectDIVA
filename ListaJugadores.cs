using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HatsuneMiku_ProjectDIVA
{
    class ListaJugadores
    {
        List<Jugador> jugadores;

        public ListaJugadores()
        {
            jugadores = new List<Jugador>();
            leerJugadores();
            jugadores.Sort();
        }

        private void leerJugadores()
        {
            string line;
            Jugador jugador;

            try
            {
                StreamReader file = new StreamReader("./ficheros/ranking.txt");

                while ((line = file.ReadLine()) != null)
                {
                    if (line != null)
                    {
                        jugador = crearJugador(line);
                        jugadores.Add(jugador);
                    }
                }
                file.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se ha encontrado el fichero del ranking", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException error)
            {
                MessageBox.Show(error + "", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Jugador crearJugador(string line)
        {
            string[] datos = line.Split(';');
            return new Jugador(datos[0], Double.Parse(datos[1]));
        }

        public List<Jugador> GetListaJugadores()
        {
            return jugadores;
        }
        /*
        public Jugador[] topJugadores()
        {
            jugadores.Sort();
            Jugador[] top5 = new Jugador[4];
            int ma

            if(jugadores.Count < 5)
            {

            }

            for(int i = 0; i < 5; i++)
            {
                top5[i] = new Jugador(jugadores[i].GetNombre(), jugadores[i].GetPuntos());
            }
            return top5;

        }*/
    }
}

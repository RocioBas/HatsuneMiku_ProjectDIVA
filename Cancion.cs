using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HatsuneMiku_ProjectDIVA
{
    public class Cancion
    {
        List<String> movimientos;
        string nombre;
        float duracion;
        bool terminada;
        //string nivelDificultad;

        public Cancion(string nombre, float duracion)
        {
            this.nombre = nombre;
            this.duracion = duracion; // en segundos??
            terminada = false;
            movimientos = new List<String>();
            leerMovimientos();
        }
        
        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public float GetDuracion()
        {
            return duracion;
        }

        public void SetDuracion(float duracion)
        {
            this.duracion = duracion;
        }

        public bool GetEstaTerminada()
        {
            return terminada;
        }

        public void Terminar()
        {
            terminada = true;
        }

        private void leerMovimientos()
        {
            string line;
            //Flecha f;

            try
            {
                StreamReader fileMovimientos = new StreamReader($"./ficheros/movimientosCanciones/movimientos{nombre}.txt");
                while((line = fileMovimientos.ReadLine()) != null)
                {
                    //f = crearFlecha(line);
                    movimientos.Add(line);
                }
                fileMovimientos.Close();
            }
            catch(FileNotFoundException)
            {
                // Cambiar ??
                MessageBox.Show("Fichero no encontrado");
            }
            catch(IOException error)
            {
                // Cambiar ??
                MessageBox.Show("ERROR: " + error);
            }
        }

        public List<String> GetMovimientos()
        {
            return movimientos;
        }

        /*
        private Flecha crearFlecha(string line)
        {
            return new Flecha(line);
        }*/
    }
}

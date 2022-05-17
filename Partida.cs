using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HatsuneMiku_ProjectDIVA
{
    public class Partida
    {
        Cancion cancion;
        double puntos;
        int vida;
        bool terminada;
        ListaCanciones listaCanciones;

        public Partida()
        {
            puntos = 0;
            vida = 100;
            terminada = false;
            listaCanciones = new ListaCanciones();
            cancion = listaCanciones.CancionAleatoria();
        }

        public Partida(Cancion cancion):this()
        {
            this.cancion = cancion;
        }

        public ListaCanciones GetListaCanciones()
        {
            return listaCanciones;
        }

        public Cancion GetCancion()
        {
            return cancion;
        }

        public void SetCancion(Cancion cancion)
        {
            this.cancion = cancion;
        }

        public double GetPuntos()
        {
            return puntos;
        }

        public void SetPuntos(int puntos)
        {
            this.puntos = puntos;
        }

        public int GetVida()
        {
            return vida;
        }

        public void SetVida(int vida)
        {
            this.vida = vida;
        }

        public bool EstaTerminada()
        {
            return terminada;
        }

        public void Terminar()
        {
            terminada = true;
        }

        public void AddPuntos(bool pulsacionCorrecta)
        {
            if(pulsacionCorrecta)
            {
                puntos += 100;
            }
            else
            {
                puntos += 50;
            }
        }

        public void AddVida(bool pulsacionCorrecta)
        {
            if(pulsacionCorrecta)
            {
                vida += 15;
            }
            else
            {
                vida += 10;
            }
        }

        public void QuitarVida()
        {
            vida -= 20;
        }

        public bool TeclaPresionadaCorrectamente()
        {
            return false;
        }

        public void GenerarFlechas()
        {
           
        }

        public void Juego()
        {

        }

    }
}

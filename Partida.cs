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
        protected Cancion cancion;
        protected double puntosJugador1;
        protected int vidaJugador1;
        protected bool terminada;
        ListaCanciones listaCanciones;

        public Partida()
        {
            puntosJugador1 = 0;
            vidaJugador1 = 100;
            terminada = false;
            listaCanciones = new ListaCanciones();
            cancion = listaCanciones.CancionAleatoria();
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

        public double GetPuntosJugador1()
        {
            return puntosJugador1;
        }

        public void SetPuntosJugador1(int puntos)
        {
            this.puntosJugador1 = puntos;
        }

        public int GetVidaJugador1()
        {
            int salida;

            if(vidaJugador1 > 100)
            {
                salida = 100;
            }
            else
            {
                salida = vidaJugador1;
            }
            return salida;
        }

        public void SetVidaJugador1(int vida)
        {
            this.vidaJugador1 = vida;
        }

        public bool GetTerminada()
        {
            return terminada;
        }

        public virtual bool EstaTerminada(long tiempoPartida)
        {
            if(tiempoPartida < cancion.GetDuracion() && vidaJugador1 > 0)
            {
                terminada = false;
            }
            else
            {
                terminada = true;
            }
            return terminada;
        }

        public void AddPuntosJugador1(bool pulsacionCorrecta)
        {
            if(pulsacionCorrecta)
            {
                puntosJugador1 += 100;
            }
            else
            {
                puntosJugador1 += 30;
            }
        }

        public void AddVidaJugador1(bool pulsacionCorrecta)
        {
            if(vidaJugador1 < 100)
            {
                if (pulsacionCorrecta)
                {
                    vidaJugador1 += 10;
                }
                else
                {
                    vidaJugador1 += 5;
                }
            }
        }

        public void QuitarVidaJugador1()
        {
            vidaJugador1 -= 15;

            if (vidaJugador1 < 0)
                vidaJugador1 = 0;
        }


    }
}

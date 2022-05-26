using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatsuneMiku_ProjectDIVA
{
    class PartidaMultiplayer : Partida
    {
        Jugador jugador2;
        public PartidaMultiplayer():base()
        {
            jugador2 = new Jugador();
        }

        /*public int GetVidaJugador2()
        {
            int salida;

            if (vidaJugador2 > 100)
            {
                salida = 100;
            }
            else
            {
                salida = vidaJugador2;
            }
            return salida;
        }

        public void SetVidaJugador2(int vidaJugador2)
        {
            this.vidaJugador2 = vidaJugador2;
        }

        public double GetPuntosJugador2()
        {
            return puntosJugador2;
        }

        public void SetPuntosJugador2(int puntos)
        {
            this.puntosJugador2 = puntos;
        }*/

        public Jugador GetJugador2()
        {
            return jugador2;
        }

        public override bool EstaTerminada(long tiempoPartida)
        {
            if (tiempoPartida < cancion.GetDuracion() &&  jugador1.GetVida() > 0 && jugador2.GetVida() > 0)
            {
                terminada = false;
            }
            else
            {
                terminada = true;
            }
            return terminada;
        }

        public string JugadorGanador()
        {
            string ganador = "ambos";

            if(jugador1.GetVida() > 0 && jugador2.GetVida() <= 0)
            {
                ganador = "jugador1";
            }
            else
            {
                if(jugador2.GetVida() > 0 && jugador1.GetVida() <= 0)
                {
                    ganador = "jugador2";
                }
            }
            return ganador;
        }

        /*public void AddPuntosJugador2(bool pulsacionCorrecta)
        {
            if (pulsacionCorrecta)
            {
                puntosJugador2 += 100;
            }
            else
            {
                puntosJugador2 += 20;
            }
        }

        public void AddVidaJugador2(bool pulsacionCorrecta)
        {
            if (vidaJugador2< 100)
            {
                if (pulsacionCorrecta)
                {
                    vidaJugador2 += 15;
                }
                else
                {
                    vidaJugador2 += 10;
                }
            }
        }

        public void QuitarVidaJugador2()
        {
            vidaJugador2 -= 15;

            if (vidaJugador2 < 0)
                vidaJugador2 = 0;
        }*/
    }
}

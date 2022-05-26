using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatsuneMiku_ProjectDIVA
{
    public class Jugador : IComparable<Jugador>
    {
        string nombre;
        double puntos;
        int vida;

        public Jugador(string nombre, double puntos)
        {
            this.nombre = nombre;
            this.puntos = puntos;
        }

        public Jugador(string nombre, double puntos, int vida)
        {
            this.nombre = nombre;
            this.puntos = puntos;
            this.vida = vida;
        }

        public Jugador():this("",0,100)
        { }

        public string GetNombre()
        {
            return nombre;
        }

        public double GetPuntos()
        {
            return puntos;
        }

        public int GetVida()
        {
            int salida;

            if (vida > 100)
            {
                salida = 100;
            }
            else
            {
                salida = vida;
            }
            return salida;
        }

        public void SetVida(int vida)
        {
            this.vida = vida;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetPuntos(double puntos)
        {
            this.puntos = puntos;
        }

        public void AddPuntos(bool pulsacionCorrecta)
        {
            if (pulsacionCorrecta)
            {
                puntos += 100;
            }
            else
            {
                puntos += 30;
            }
        }

        public void AddVida(bool pulsacionCorrecta)
        {
            if (vida < 100)
            {
                if (pulsacionCorrecta)
                {
                    vida += 10;
                }
                else
                {
                    vida += 5;
                }
            }
        }

        public void QuitarVida()
        {
            vida -= 15;

            if (vida < 0)
                vida = 0;
        }

        public int CompareTo(Jugador j2)
        {
            int resultado;

            if(puntos < j2.puntos)
            {
                resultado = 1;
            }
            else
            {
                if(puntos > j2.puntos)
                {
                    resultado = -1;
                }
                else
                {
                    resultado = nombre.CompareTo(j2.nombre);
                }
            }
            return resultado;

        }
        

    }
}

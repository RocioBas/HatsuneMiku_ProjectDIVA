using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatsuneMiku_ProjectDIVA
{
    class Jugador : IComparable<Jugador>
    {
        string nombre;
        double puntos;

        public Jugador(string nombre, double puntos)
        {
            this.nombre = nombre;
            this.puntos = puntos;
        }

        public Jugador():this("",0)
        { }

        public string GetNombre()
        {
            return nombre;
        }

        public double GetPuntos()
        {
            return puntos;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetPuntos(double puntos)
        {
            this.puntos = puntos;
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

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
        string nombre;
        float duracion;
        int tiempoEnEmpezar;
        bool terminada;

        public Cancion(string nombre, float duracion, int tiempoEnEmpezar)
        {
            this.nombre = nombre;
            this.duracion = duracion;
            this.tiempoEnEmpezar = tiempoEnEmpezar;
            terminada = false;
        }

        public int GetTiempoEnEmpezar()
        {
            return tiempoEnEmpezar;
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

    }
}

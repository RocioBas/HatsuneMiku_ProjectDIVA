using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatsuneMiku_ProjectDIVA
{
    public class Flecha:Sprite
    {
        string direccion;

        public Flecha():base()
        {
            direccion = "";
        }

        public Flecha(string direccion):this()
        {
            this.direccion = direccion;
        }

        public override void Dibujar()
        {

        }

        public override void Borrar()
        {

        }

        public void Mover()
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatsuneMiku_ProjectDIVA
{
    public abstract class Sprite
    {
        int x;
        int y;
        string imagen;

        public Sprite()
        {
            x = 0;
            y = 0;
            imagen = "";
        }

        public int GetX()
        {
            return x;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetY()
        {
            return y;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public String GetImagen()
        {
            return imagen;
        }

        public void SetImagen(String imagen)
        {
            this.imagen = imagen;
        }

        public abstract void Dibujar();

        public abstract void Borrar();

       
    }
}

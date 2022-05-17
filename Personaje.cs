using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatsuneMiku_ProjectDIVA
{
    public class Personaje:Sprite
    {
        //List<String> imagenesMovimiento;
        bool muerto;

        public Personaje() : base()
        {
            muerto = false;
        }

        public bool GetMuerto()
        {
            return muerto;
        }

        public void SetMuerto(bool muerto)
        {
            this.muerto = muerto;
        }

        public override void Borrar()
        { }

        public override void Dibujar()
        { }

        //public void LeerMovimientos();
    }
}

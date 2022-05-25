using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HatsuneMiku_ProjectDIVA
{
    public partial class MenuPrincipal : Form
    {
        Form modoJuego;
        Form ayuda;
        Form ranking;
        //SoundPlayer sonidoFondo;
        
        public MenuPrincipal()
        {
            InitializeComponent();
            ayuda = new Ayuda();
            modoJuego = new ModoJuego();
            ranking = new Ranking();
            //sonidoFondo = new SoundPlayer(@".\wav\CancionMENU.wav");
           // sonidoFondo.PlayLooping();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            modoJuego.ShowDialog();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAyuda_Click(object sender, EventArgs e)
        {
            this.Hide();
            //sonidoFondo.Stop();
            ayuda.ShowDialog();
        }

        private void btRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            ranking.ShowDialog();
        }
    }
}

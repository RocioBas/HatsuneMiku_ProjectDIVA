using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HatsuneMiku_ProjectDIVA
{
    public partial class ModoJuego : Form
    {
        Form juegoSingleplayer;
        Form reproductor;
        Form juegoMultiplayer;
        Form juegoCpu;
        public ModoJuego()
        {
            InitializeComponent();
            juegoSingleplayer = new JuegoSinglePlayer();
            reproductor = new Reproductor();
            juegoMultiplayer = new JuegoMultiPlayer();
            juegoCpu = new JuegoCPU();

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Form menuPrincipal = new MenuPrincipal();
            this.Hide();

            menuPrincipal.ShowDialog();
        }

        private void btAlone_Click(object sender, EventArgs e)
        {
            this.Hide();
            juegoSingleplayer.ShowDialog();
        }

        private void btReproductor_Click(object sender, EventArgs e)
        {
            this.Hide();
            reproductor.ShowDialog();
        }

        private void bt1vs1_Click(object sender, EventArgs e)
        {
            this.Hide();
            juegoMultiplayer.ShowDialog();
        }

        private void btVsIA_Click(object sender, EventArgs e)
        {
            this.Hide();
            juegoCpu.ShowDialog();
        }
    }
}

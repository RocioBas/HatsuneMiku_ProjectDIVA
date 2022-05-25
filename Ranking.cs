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
    public partial class Ranking : Form
    {
        ListaJugadores jugadores;
        public Ranking()
        {
            InitializeComponent();
            jugadores = new ListaJugadores();
            rellenarRanking(jugadores.GetListaJugadores());
        }

        private void Ranking_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form modoJuego = new ModoJuego();

                this.Hide();
                modoJuego.ShowDialog();
            }
        }

        private void rellenarRanking(List<Jugador> listaJugadores)
        {
            if(listaJugadores.Count >= 5)
            {
                top5Jugadores(listaJugadores);
            }
            else
            {
                switch (listaJugadores.Count)
                {
                    case 4:
                        top4Jugadores(listaJugadores);
                        break;

                    case 3:
                        top3Jugadores(listaJugadores);
                        break;

                    case 2:
                        top2Jugadores(listaJugadores);
                        break;

                    case 1:
                        lbNombre1.Text = listaJugadores[0].GetNombre();
                        lbPuntos1.Text = listaJugadores[0].GetPuntos() + "";
                        break;
                }
            }
            
        }

        private void top5Jugadores(List<Jugador> listaJugadores)
        {
            lbNombre1.Text = listaJugadores[0].GetNombre();
            lbPuntos1.Text = listaJugadores[0].GetPuntos() + "";
            lbNombre2.Text = listaJugadores[1].GetNombre();
            lbPuntos2.Text = listaJugadores[1].GetPuntos() + "";
            lbNombre3.Text = listaJugadores[2].GetNombre();
            lbPuntos3.Text = listaJugadores[2].GetPuntos() + "";
            lbNombre4.Text = listaJugadores[3].GetNombre();
            lbPuntos4.Text = listaJugadores[3].GetPuntos() + "";
            lbNombre5.Text = listaJugadores[4].GetNombre();
            lbPuntos5.Text = listaJugadores[4].GetPuntos() + "";
        }

        private void top4Jugadores(List<Jugador> listaJugadores)
        {
            lbNombre1.Text = listaJugadores[0].GetNombre();
            lbPuntos1.Text = listaJugadores[0].GetPuntos() + "";
            lbNombre2.Text = listaJugadores[1].GetNombre();
            lbPuntos2.Text = listaJugadores[1].GetPuntos() + "";
            lbNombre3.Text = listaJugadores[2].GetNombre();
            lbPuntos3.Text = listaJugadores[2].GetPuntos() + "";
            lbNombre4.Text = listaJugadores[3].GetNombre();
            lbPuntos4.Text = listaJugadores[3].GetPuntos() + "";
        }

        private void top3Jugadores(List<Jugador> listaJugadores)
        {
            lbNombre1.Text = listaJugadores[0].GetNombre();
            lbPuntos1.Text = listaJugadores[0].GetPuntos() + "";
            lbNombre2.Text = listaJugadores[1].GetNombre();
            lbPuntos2.Text = listaJugadores[1].GetPuntos() + "";
            lbNombre3.Text = listaJugadores[2].GetNombre();
            lbPuntos3.Text = listaJugadores[2].GetPuntos() + "";
        }

        private void top2Jugadores(List<Jugador> listaJugadores)
        {
            lbNombre1.Text = listaJugadores[0].GetNombre();
            lbPuntos1.Text = listaJugadores[0].GetPuntos() + "";
            lbNombre2.Text = listaJugadores[1].GetNombre();
            lbPuntos2.Text = listaJugadores[1].GetPuntos() + "";
        }

        
    }
}

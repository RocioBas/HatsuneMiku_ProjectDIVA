using HatsuneMiku_ProjectDIVA.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HatsuneMiku_ProjectDIVA
{
    public partial class JuegoSinglePlayer : Form
    {
        Partida partida;
        SoundPlayer cancion;
        Stopwatch sw;
        CancellationTokenSource tokenCancel;
        PictureBox flechaMovimiento;
        public JuegoSinglePlayer()
        {
            InitializeComponent();
            partida = new Partida();
            cancion = null;
            sw = new Stopwatch();
            flechaMovimiento = null;
        }

        private async void JuegoSinglePlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pbPJ1.BackgroundImage = Image.FromFile("./imagenes/personaje1/p1_izquierda.png");
                comprobarPuntos();

            }
            if (e.KeyCode == Keys.Right)
            {
                pbPJ1.BackgroundImage = Image.FromFile("./imagenes/personaje1/p1_derecha.png");
                comprobarPuntos();

            }
            if (e.KeyCode == Keys.Up)
            {
                pbPJ1.BackgroundImage = Image.FromFile("./imagenes/personaje1/p1_arriba.png");
                comprobarPuntos();

            }
            if (e.KeyCode == Keys.Down)
            {
                pbPJ1.BackgroundImage = Image.FromFile("./imagenes/personaje1/p1_abajo.png");
                comprobarPuntos();

            }
            if (e.KeyCode == Keys.Enter)
            {
                cancion = new SoundPlayer("./wav/" + partida.GetCancion().GetNombre() + ".wav");
                cancion.Play();
                await juego();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Form modoJuego = new ModoJuego();
                reiniciarJuego();

                if(cancion != null)
                {
                    tokenCancel.Cancel();
                }
               
                this.Hide();
                modoJuego.ShowDialog();
            }
            //pbPJ1.BackgroundImageLayout = ImageLayout.Stretch;

           
        }

        private void JuegoSinglePlayer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right
                || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                pbPJ1.BackgroundImage = Image.FromFile(".\\imagenes\\personaje1\\p1_quieta.png");

            }
            pbPJ1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private async Task juego()
        {
          
            sw.Start();
            //int i = 0;
            //int max = partida.GetCancion().GetMovimientos().Count();
            tokenCancel = new CancellationTokenSource();
            var token = tokenCancel.Token;
           
            await Task.Run(() =>
            {
                Task.Delay(partida.GetCancion().GetTiempoEnEmpezar()).Wait();
                while ( !partida.EstaTerminada(sw.ElapsedMilliseconds) &&  !token.IsCancellationRequested)
                {
                    if (!partida.GetTerminada() )
                    {
                        //PictureBox flecha = flechaElegida(partida.GetCancion().GetMovimientos()[i]);
                        PictureBox flecha = flechaElegida(flechaRandom());

                        if (flecha != null)
                        {
                            indicaFlechaEnMovimiento(flecha);
                            generarFlechas(flecha);
                           // i++;
                        }
                        /*
                        if(i >= max)
                        {
                            i = 0;
                        }*/
                    }
                } 
                sw.Stop();
             }, token);

            if(!token.IsCancellationRequested)
                terminarPartida();

        }

        private string flechaRandom()
        {
            Random rng= new Random();

            string[] flechas = {"Right", "Up", "Down", "Left"};
            
            rng.Shuffle(flechas);
            return flechas[rng.Next(0, 4)];
        }

        private void reiniciarJuego()
        {
            partida.SetCancion(partida.GetListaCanciones().CancionAleatoria());

            if (cancion != null)
            {
                cancion.Stop();
                sw.Reset();
            }
        }

        private void terminarPartida()
        {
            reiniciarJuego();

            if (partida.GetVidaJugador1() > 0)
            {
                PartidaGanadaSinglePlayer estado = new PartidaGanadaSinglePlayer();
                estado.lbPuntos.Text = partida.GetPuntosJugador1() + "";

                this.Hide();
                estado.ShowDialog();
            }
            else
            {
                PartidaPerdidaSinglePlayer estado = new PartidaPerdidaSinglePlayer();
                estado.lbPuntos.Text = partida.GetPuntosJugador1() + "";

                this.Hide();
                estado.ShowDialog();
            }

                           
        }

        private void generarFlechas(PictureBox flecha)
        {
            crearFlecha(flecha);
            moverFlecha(flecha);
            //Task.Delay(200).Wait();
            borrarFlecha(flecha);
        }

        private void comprobarPuntos()
        {
            if(flechaMovimiento != null)
            {
                int x = flechaMovimiento.Location.X;
                int y = flechaMovimiento.Location.Y;

                if (y <= 40 &&  y >= 11 && x == flechaFija(flechaMovimiento).Location.X)
                {
                    addStats(true);
                    lbTipoPuntacion.Text = "Perfect >.<";
                    lbTipoPuntacion.ForeColor = Color.HotPink;
                }
                else
                {
                    if (y <= 50 && y >= 15 && x == flechaFija(flechaMovimiento).Location.X)
                    {
                        addStats(false);
                        lbTipoPuntacion.Text = "Cool :)";
                        lbTipoPuntacion.ForeColor = Color.Lime;
                    }
                    else
                    {
                        partida.QuitarVidaJugador1();
                        lbVida.Text = partida.GetVidaJugador1() + "";
                        lbTipoPuntacion.Text = "Bad :(";
                        lbTipoPuntacion.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void flechaPerdida()
        {
            partida.QuitarVidaJugador1();
        }

        private void addStats(bool accionCorrecta)
        {
            partida.AddPuntosJugador1(accionCorrecta);
            partida.AddVidaJugador1(accionCorrecta);
            lbPuntos.Text = partida.GetPuntosJugador1() + "";
            lbVida.Text = partida.GetVidaJugador1() + "";
        }

        private void indicaFlechaEnMovimiento(PictureBox flecha)
        {
            flechaMovimiento = flecha;
        }

        private PictureBox flechaFija(PictureBox flechaMovimiento)
        {
            PictureBox flechaFija = null;

            switch (flechaMovimiento.Name)
            {
                case "LeftArrow":
                    flechaFija = LeftArrowFija;
                    break;

                case "RightArrow":
                    flechaFija = RightArrowFija;
                    break;

                case "UpArrow":
                    flechaFija = UpArrowFija;
                    break;

                case "DownArrow":
                    flechaFija = DownArrowFija;
                    break;
            }
            return flechaFija;
        }

        private void crearFlecha(PictureBox flecha)
        {
            flecha.BackgroundImage = Image.FromFile($"./imagenes/flechas/{flecha.Name}.png");
            flecha.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void borrarFlecha(PictureBox flecha)
        {
            flecha.BackgroundImage = null;
        }

        private PictureBox flechaElegida(string direccion)
        {
            PictureBox flecha = null;

            switch (direccion)
            {
                case "Left":
                    flecha = LeftArrow;
                    break;

                case "Right":
                    flecha = RightArrow;
                    break;

                case "Up":
                    flecha = UpArrow;
                    break;

                case "Down":
                    flecha = DownArrow;
                    break;
            }
            return flecha;
        }

        private void moverFlecha(PictureBox flecha)
        {
            CheckForIllegalCrossThreadCalls = false;
            bool seguir = true;

            //await Task.Run(() => {

                while (seguir)
                {
                    int x = flecha.Location.X;
                    int y = flecha.Location.Y;
                    y -= 5;

                    if (y <= 11)
                    {
                        seguir = false;
                        y = 435;
                    }
                    flecha.Location = new Point(x, y);
                }
            //});
        }

        

      
    }
}

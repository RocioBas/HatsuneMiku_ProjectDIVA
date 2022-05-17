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
        public JuegoSinglePlayer()
        {
            InitializeComponent();
            timeFlechasMov.Start();
            partida = new Partida();
            cancion = null;
            sw = new Stopwatch();
        }

        private async void JuegoSinglePlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pbPJ1.BackgroundImage = Image.FromFile("./imagenes/personaje1/p1_izquierda.png");

            }
            if (e.KeyCode == Keys.Right)
            {
                pbPJ1.BackgroundImage = Image.FromFile("./imagenes/personaje1/p1_derecha.png");

            }
            if (e.KeyCode == Keys.Up)
            {
                pbPJ1.BackgroundImage = Image.FromFile("./imagenes/personaje1/p1_arriba.png");

            }
            if (e.KeyCode == Keys.Down)
            {
                pbPJ1.BackgroundImage = Image.FromFile("./imagenes/personaje1/p1_abajo.png");

            }
            if (e.KeyCode == Keys.Enter)
            {
                cancion = new SoundPlayer("./wav/" + partida.GetCancion().GetNombre() + ".wav");
                cancion.Play();
                await generarFlechas();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Form modoJuego = new ModoJuego();
                partida.SetCancion(partida.GetListaCanciones().CancionAleatoria());
                if(cancion != null)
                {
                    cancion.Stop();
                    sw.Reset();
                    tokenCancel.Cancel();
                }
                this.Hide();
                modoJuego.ShowDialog();
            }
            pbPJ1.BackgroundImageLayout = ImageLayout.Stretch;

                
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

        private async Task generarFlechas()
        {
            sw.Start();
            int i = 0;
            int max = partida.GetCancion().GetMovimientos().Count();
            tokenCancel = new CancellationTokenSource();
            var token = tokenCancel.Token;

            await Task.Run(() =>
            {
                Task.Delay(3000).Wait();
                while ((sw.ElapsedMilliseconds != partida.GetCancion().GetDuracion()) || (i < max))
                {
                    if (token.IsCancellationRequested)
                    {
                        break;
                    }

                    if ((sw.ElapsedMilliseconds != partida.GetCancion().GetDuracion()) || (i < max))
                    {
                        PictureBox flecha = flechaElegida((partida.GetCancion().GetMovimientos())[i]);

                        if (flecha != null)
                        {
                            crearFlecha(flecha);
                            timeFlechasMov.Enabled = true;
                            Task.Delay(2000).Wait();
                            borrarFlecha(flecha);
                            i++;
                        }
                    }
                } 
                sw.Stop();
             }, token);
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

        private void timeFlechasMov_Tick(object sender, EventArgs e)
        {
            int x = LeftArrow.Location.X;
            int y = LeftArrow.Location.Y;
            y -= 5;


            if (y >= 593)
            {
                y = 435;
            }
   

            Point punto = new Point(x, y);
            LeftArrow.Location = punto;
        }
    }
}

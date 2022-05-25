﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.Threading;

namespace HatsuneMiku_ProjectDIVA
{
    public partial class JuegoMultiPlayer : Form
    {
        PartidaMultiplayer partida;
        SoundPlayer cancion;
        Stopwatch sw;
        CancellationTokenSource tokenCancel;
        PictureBox flechaMovimiento;
        PictureBox teclaMovimiento;
        public JuegoMultiPlayer()
        {
            InitializeComponent();
            partida = new PartidaMultiplayer();
            cancion = null;
            sw = new Stopwatch();
            flechaMovimiento = null;
            teclaMovimiento = null;
        }

        private async void JuegoMultiPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pbPJ1.BackgroundImage = Image.FromFile("./imagenes/personaje1/p1_izquierda.png");
                comprobarPuntosPJ1();

            }
            if (e.KeyCode == Keys.Right)
            {
                pbPJ1.BackgroundImage = Image.FromFile("./imagenes/personaje1/p1_derecha.png");
                comprobarPuntosPJ1();

            }
            if (e.KeyCode == Keys.Up)
            {
                pbPJ1.BackgroundImage = Image.FromFile("./imagenes/personaje1/p1_arriba.png");
                comprobarPuntosPJ1();

            }
            if (e.KeyCode == Keys.Down)
            {
                pbPJ1.BackgroundImage = Image.FromFile("./imagenes/personaje1/p1_abajo.png");
                comprobarPuntosPJ1();

            }
            if (e.KeyCode == Keys.A)
            {
                pbPJ2.BackgroundImage = Image.FromFile("./imagenes/personaje2/p2_izquierda.png");
                comprobarPuntosPJ2();
            }
            if (e.KeyCode == Keys.D)
            {
                pbPJ2.BackgroundImage = Image.FromFile("./imagenes/personaje2/p2_derecha.png");
                comprobarPuntosPJ2();
            }
            if (e.KeyCode == Keys.W)
            {
                pbPJ2.BackgroundImage = Image.FromFile("./imagenes/personaje2/p2_arriba.png");
                comprobarPuntosPJ2();
            }
            if (e.KeyCode == Keys.S)
            {
                pbPJ2.BackgroundImage = Image.FromFile("./imagenes/personaje2/p2_abajo.png");
                comprobarPuntosPJ2();
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

                if (cancion != null)
                {
                    tokenCancel.Cancel();
                }

                this.Hide();
                modoJuego.ShowDialog();
            }
  
        }

        private void JuegoMultiPlayer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right
                || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                pbPJ1.BackgroundImage = Image.FromFile(".\\imagenes\\personaje1\\p1_quieta.png");
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.D
                || e.KeyCode == Keys.W || e.KeyCode == Keys.S)
            {
                pbPJ2.BackgroundImage = Image.FromFile(".\\imagenes\\personaje2\\p2_quieta.png");
            }
        }

        private async Task juego()
        {
            sw.Start();
            tokenCancel = new CancellationTokenSource();
            var token = tokenCancel.Token;

            await Task.Run(() =>
            {
                Task.Delay(partida.GetCancion().GetTiempoEnEmpezar()).Wait();
                while (!partida.EstaTerminada(sw.ElapsedMilliseconds) && !token.IsCancellationRequested)
                {
                    if (!partida.GetTerminada())
                    {
                        PictureBox flecha = teclaElegida(flechaRandom());
                        PictureBox tecla = teclaElegida(teclaRandom());

                        if (flecha != null && tecla != null)
                        {
                            indicaFlechaEnMovimiento(flecha);
                            indicaTeclaEnMovimiento(tecla);

                            generarTeclas(flecha, tecla);
                        }
                    }
                }
                sw.Stop();
            }, token);

            if (!token.IsCancellationRequested)
                terminarPartida();
        }

        private string teclaRandom()
        {
            Random rng = new Random();

            string[] teclas = { "D", "W", "S", "A" };

            rng.Shuffle(teclas);
            return teclas[rng.Next(0, 4)];
        }

        private string flechaRandom()
        {
            Random rng = new Random();

            string[] flechas = { "Right", "Up", "Down", "Left" };

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

            if (partida.GetVidaJugador1() > 0 || partida.GetVidaJugador2() > 0)
            {
                PartidaGanadaMultiPlayer estado = new PartidaGanadaMultiPlayer();

                estado.lbGanador.Text = partida.JugadorGanador() ;
                estado.lbPuntos1.Text = partida.GetPuntosJugador1() + "";
                estado.lbPuntos2.Text = partida.GetPuntosJugador2() + "";

                this.Hide();
                estado.ShowDialog();
            }
            else
            {
                PartidaPerdidaMultiPlayer estado = new PartidaPerdidaMultiPlayer();
                estado.lbPuntos1.Text = partida.GetPuntosJugador1() + "";
                estado.lbPuntos2.Text = partida.GetPuntosJugador2() + "";

                this.Hide();
                estado.ShowDialog();
            }
        }

        private void generarTeclas(PictureBox flecha, PictureBox tecla)
        {
            crearTeclas(flecha, tecla);
            moverTeclas(flecha, tecla);
            borrarTeclas(flecha, tecla);
        }

        
        private void comprobarPuntosPJ1()
        {
            if (flechaMovimiento != null)
            {
                int x = flechaMovimiento.Location.X;
                int y = flechaMovimiento.Location.Y;

                if (y <= 40 && y >= 11 && x == flechaFija(flechaMovimiento).Location.X)
                {
                    addStatsPJ1(true);
                    lbTipoPuntacion1.Text = "Perfect >.<";
                    lbTipoPuntacion1.ForeColor = Color.HotPink;
                }
                else
                {
                    if (y <= 50 && y >= 15 && x == flechaFija(flechaMovimiento).Location.X)
                    {
                        addStatsPJ1(false);
                        lbTipoPuntacion1.Text = "Cool :)";
                        lbTipoPuntacion1.ForeColor = Color.Lime;
                    }
                    else
                    {
                        partida.QuitarVidaJugador1();
                        lbVida1.Text = partida.GetVidaJugador1() + "";
                        lbTipoPuntacion1.Text = "Bad :(";
                        lbTipoPuntacion1.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void comprobarPuntosPJ2()
        {
            if (teclaMovimiento != null)
            {
                int x = teclaMovimiento.Location.X;
                int y = teclaMovimiento.Location.Y;

                if (y <= 40 && y >= 11 && x == teclaFija(teclaMovimiento).Location.X)
                {
                    addStatsPJ2(true);
                    lbTipoPuntacion2.Text = "Perfect >.<";
                    lbTipoPuntacion2.ForeColor = Color.HotPink;
                }
                else
                {
                    if (y <= 50 && y >= 15 && x == teclaFija(teclaMovimiento).Location.X)
                    {
                        addStatsPJ2(false);
                        lbTipoPuntacion2.Text = "Cool :)";
                        lbTipoPuntacion2.ForeColor = Color.Lime;
                    }
                    else
                    {
                        partida.QuitarVidaJugador2();
                        lbVida2.Text = partida.GetVidaJugador2() + "";
                        lbTipoPuntacion2.Text = "Bad :(";
                        lbTipoPuntacion2.ForeColor = Color.Red;
                    }
                }
            }
        }


        private void addStatsPJ1(bool accionCorrecta)
        {
            partida.AddPuntosJugador1(accionCorrecta);
            partida.AddVidaJugador1(accionCorrecta);
            lbPuntos1.Text = partida.GetPuntosJugador1() + "";
            lbVida1.Text = partida.GetVidaJugador1() + "";
        }

        private void addStatsPJ2(bool accionCorrecta)
        {
            partida.AddPuntosJugador2(accionCorrecta);
            partida.AddVidaJugador2(accionCorrecta);
            lbPuntos2.Text = partida.GetPuntosJugador2() + "";
            lbVida2.Text = partida.GetVidaJugador2() + "";
        }

        private void indicaFlechaEnMovimiento(PictureBox flecha)
        {
            flechaMovimiento = flecha;
        }

        private void indicaTeclaEnMovimiento(PictureBox tecla)
        {
            teclaMovimiento = tecla;
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

        private PictureBox teclaFija(PictureBox teclaMovimiento)
        {
            PictureBox teclaFija = null;

            switch (teclaMovimiento.Name)
            {
                case "A":
                    teclaFija = A;
                    break;

                case "S":
                    teclaFija = S;
                    break;

                case "D":
                    teclaFija = D;
                    break;

                case "W":
                    teclaFija = W;
                    break;
            }
            return teclaFija;
        }


        private void crearTeclas(PictureBox flecha, PictureBox tecla)
        {
            flecha.BackgroundImage = Image.FromFile($"./imagenes/flechas/{flecha.Name}.png");
            flecha.BackgroundImageLayout = ImageLayout.Stretch;

            tecla.BackgroundImage = Image.FromFile($"./imagenes/teclas/{tecla.Name}.png");
            tecla.BackgroundImageLayout = ImageLayout.Stretch;

        }

        

        private void borrarTeclas(PictureBox flecha, PictureBox tecla)
        {
            flecha.BackgroundImage = null;
            tecla.BackgroundImage = null;
        }

        private PictureBox teclaElegida(string tecla)
        {
            PictureBox resultado = null;

            switch (tecla)
            {
                case "Left":
                    resultado = LeftArrow;
                    break;

                case "Right":
                    resultado = RightArrow;
                    break;

                case "Up":
                    resultado = UpArrow;
                    break;

                case "Down":
                    resultado = DownArrow;
                    break;

                case "D":
                    resultado = D;
                    break;

                case "A":
                    resultado = A;
                    break;

                case "W":
                    resultado = W;
                    break;

                case "S":
                    resultado = S;
                    break;
            }
            return resultado;
        }

        private void moverTeclas(PictureBox flecha, PictureBox tecla)
        {
            CheckForIllegalCrossThreadCalls = false;
            bool seguir = true;

            //await Task.Run(() => {

            while (seguir)
            {
                int xFlecha = flecha.Location.X;
                int yFlecha = flecha.Location.Y;

                int xTecla = tecla.Location.X;
                int yTecla = tecla.Location.Y;

                yFlecha -= 5;
                yTecla -= 5;

                if (yFlecha <= 11  || yTecla <= 11)
                {
                    seguir = false;
                    yFlecha = 435;
                    yTecla = 435;
                }
                flecha.Location = new Point(xFlecha, yFlecha);
                tecla.Location = new Point(xTecla, yTecla);
            }
            //});
        }

        
    }
}

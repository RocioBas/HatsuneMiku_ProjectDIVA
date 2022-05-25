using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HatsuneMiku_ProjectDIVA
{
    public partial class PartidaGanadaMultiPlayer : Form
    {
        Form modoJuego;
        public PartidaGanadaMultiPlayer()
        {
            InitializeComponent();
            modoJuego = new ModoJuego();
        }

        private void PartidaGanadaMultiPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                modoJuego.ShowDialog();
            }
        }

        private void btRanking_Click(object sender, EventArgs e)
        {
            string nombre =
               Microsoft.VisualBasic.Interaction.InputBox("Dime tu nombre: ", "Nombre Ganador", "Usuario");

            try
            {
                StreamWriter ranking = new StreamWriter("./ficheros/ranking.txt", true);

                if(lbGanador.Text ==  "jugador1")
                {
                    ranking.WriteLine(nombre + ";" + lbPuntos1.Text);
                }
                else
                {
                    if(lbGanador.Text == "jugador2" || lbGanador.Text == "CPU")
                    {
                        ranking.WriteLine(nombre + ";" + lbPuntos2.Text);
                    }
                    else
                    {
                        ranking.WriteLine(nombre + ";" + MayorCantidadPuntos());
                    }
                }
                
                ranking.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se ha encontrado el fichero del ranking", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException error)
            {
                MessageBox.Show(error + "", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Puntos guardados correctamente", "Guardar",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            modoJuego.ShowDialog();
        }

        public double MayorCantidadPuntos()
        {
            double puntosPJ1 = Double.Parse(lbPuntos1.Text);
            double puntosPJ2 = Double.Parse(lbPuntos2.Text);
            double resultado = puntosPJ1;

            if(puntosPJ1 > puntosPJ2)
            {
                resultado = puntosPJ1;
            }
            else
            {
                resultado = puntosPJ2;
            }
            return resultado;
        }
    }
}

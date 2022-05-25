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
    public partial class PartidaGanadaSinglePlayer : Form
    {
        Form modoJuego;
        public PartidaGanadaSinglePlayer()
        {
            InitializeComponent();
            modoJuego = new ModoJuego();
        }

        private void PartidaGanada_KeyDown(object sender, KeyEventArgs e)
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
                Microsoft.VisualBasic.Interaction.InputBox("Dime tu nombre: ", "Nombre", "Usuario");

            try
            {
                StreamWriter ranking = new StreamWriter("./ficheros/ranking.txt", true);

                ranking.WriteLine(nombre+";"+lbPuntos.Text);
                ranking.Close();
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("No se ha encontrado el fichero del ranking", "Error",
                    MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            catch(IOException error)
            {
                MessageBox.Show(error + "", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Puntos guardados correctamente", "Guardar",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            modoJuego.ShowDialog();
        }
    }
}

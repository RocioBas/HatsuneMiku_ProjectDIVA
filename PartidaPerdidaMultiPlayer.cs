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
    public partial class PartidaPerdidaMultiPlayer : Form
    {
        public PartidaPerdidaMultiPlayer()
        {
            InitializeComponent();
        }

        private void PartidaPerdidaMultiPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form modoJuego = new ModoJuego();

                this.Hide();
                modoJuego.ShowDialog();
            }
        }
    }
}

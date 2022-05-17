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
    public partial class Inicio : Form
    {
        Form menuPrincipal;

        public Inicio()
        {
            InitializeComponent();
            menuPrincipal = new MenuPrincipal();

        }

        private void pbStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal.ShowDialog();
        }

        
    }
}

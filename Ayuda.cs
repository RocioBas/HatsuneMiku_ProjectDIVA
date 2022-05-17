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
    public partial class Ayuda : Form
    {

        public Ayuda()
        {
            InitializeComponent();

        }

        

        private void pbBack_Click(object sender, EventArgs e)
        {
            Form menuPrincipal = new MenuPrincipal();
            this.Hide();

            menuPrincipal.ShowDialog();
        }
    }
}

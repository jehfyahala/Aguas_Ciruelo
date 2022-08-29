using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aguas_Ciruelo.Vistas;
using Aguas_Ciruelo.Vistas.Home;

namespace Aguas_Ciruelo.Vistas.Inicio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           this.Hide();
           Menu_Principal menu = new Menu_Principal();
            menu.Show();
        }
    }
}

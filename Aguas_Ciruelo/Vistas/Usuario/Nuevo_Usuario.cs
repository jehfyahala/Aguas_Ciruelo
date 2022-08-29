using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aguas_Ciruelo.Vistas.Usuario
{
    public partial class Nuevo_Usuario : Form
    {
        public Nuevo_Usuario()
        {
            InitializeComponent();
        }

        private void Nuevo_Usuario_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }
    }
}

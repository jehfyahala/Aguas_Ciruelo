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
using Aguas_Ciruelo.Vistas.Inicio;

namespace Aguas_Ciruelo.Vistas.Home
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Clientes.Lista_Clientes lista_Clientes = new Clientes.Lista_Clientes();
            lista_Clientes.Show();
            this.Hide();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            Usuario.Lista_Usuarios lista_Usuarios = new Usuario.Lista_Usuarios();  
            lista_Usuarios.Show();
            this.Hide();
        }

        private void BtnPrecios_Click(object sender, EventArgs e)
        {
            Precios.Lista_de_Precios lista_Precios = new Precios.Lista_de_Precios();
            lista_Precios.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login= new Login();
            login.Show();
            this.Close();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}

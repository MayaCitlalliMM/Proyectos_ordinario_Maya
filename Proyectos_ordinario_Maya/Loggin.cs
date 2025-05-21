using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyectos_ordinario_Maya
{
    public partial class Loggin : Form
    {
        Usuario casa = new Usuario();

        public Loggin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txbUsuario.Text;
            string Password = txbContraseña.Text;

            var lista = casa.ObtenerUsuario();
            var valida = lista.FirstOrDefault(u => u.NombreUsuario == user && u.Contrasenia == Password);
            if (valida != null)
            {
                this.Hide();
                Form1 inicio = new Form1();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("ERROR en algo");
            }
        }
    }
}

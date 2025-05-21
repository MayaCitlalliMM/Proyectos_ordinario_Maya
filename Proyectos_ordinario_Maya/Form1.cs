using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectos_ordinario_Maya
{
    public partial class Form1 : Form
    {
        Acciones acc = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataAutos.DataSource = acc.MostrarAutos();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (acc.ExportarExcel())
            {
                MessageBox.Show("Exportando con exito...");
                DataAutos.DataSource = null;
                DataAutos.DataSource = acc.MostrarAutos();
            }
            else
            {
                MessageBox.Show("Fallo el exportado...");
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (acc.Importar())
            {
                MessageBox.Show("Importando...");
                DataAutos.DataSource = null;
                DataAutos.DataSource = acc.MostrarAutos();

            }
            else
            {
                MessageBox.Show("Error...");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txbID.Text);
            int anio = Convert.ToInt32(txbAño.Text);
            double precio = Convert.ToDouble(txbPrecio.Text);


            if (acc.Actualizar(ID, txbMarca.Text, txbModelo.Text, anio, txbColor.Text, precio, txbEstado.Text))
            {
                MessageBox.Show("Actualizado con exito");
                DataAutos.DataSource = null;
                DataAutos.DataSource = acc.MostrarAutos();

            }
            else
            {
                MessageBox.Show("fallo en actualizar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id3 = Convert.ToInt32(txbID.Text);
            int anio3 = Convert.ToInt32(txbAño.Text);
            double precio3 = Convert.ToDouble(txbPrecio.Text);

            if (acc.Eliminar(id3, txbMarca.Text, txbModelo.Text, anio3, txbColor.Text, precio3, txbEstado.Text))
            {
                MessageBox.Show("Eliminado con éxito");
               
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int ID2 = Convert.ToInt32(txbID.Text);
            int anio2 = Convert.ToInt32(txbAño.Text);
            double precio2 = Convert.ToDouble(txbPrecio.Text);

            if (acc.Agregar(ID2, txbMarca.Text, txbModelo.Text, anio2, txbColor.Text, precio2, txbEstado.Text))
            {
                MessageBox.Show("Agregado con éxito");
                DataAutos.DataSource = null;
                DataAutos.DataSource = acc.MostrarAutos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txbID.Text = "";
            txbMarca.Text = "";
            txbModelo.Text = "";
            txbAño.Text = "";
            txbColor.Text = "";
            txbPrecio.Text = "";
            txbEstado.Text = "";

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasDeComida__C__Windows_Forms_
{
    public partial class Form1 : Form
    {
        private int totalAcumulado = 0;
        private int cambioTotal = 0;



        public Form1()
        {
            InitializeComponent();
        }

 

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int numeroEfectivo;
            bool resultado = int.TryParse(textBoxEfectivo.Text, out numeroEfectivo);
            cambioTotal = numeroEfectivo - totalAcumulado;
            labelCambio.Text = $"Cambio Total: bs {cambioTotal} ";
        }



        private void iconButton2_Click(object sender, EventArgs e)
        {
            string producto = "Coca Cola";
            int precio = 15;
            if (labelProductos.Text.Length > 0)  // Verifica si el Label ya tiene texto
            {
                labelProductos.Text += "\n";     // Añade una nueva línea si ya hay productos listados
            }
            labelProductos.Text += $"Producto: {producto} | Precio: bs {precio}";
            totalAcumulado += precio;
            labelprecioTotal.Text = $"Total: bs {totalAcumulado}";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string producto = "Sprite";
            int precio = 15;
            if (labelProductos.Text.Length > 0)  // Verifica si el Label ya tiene texto
            {
                labelProductos.Text += "\n";     // Añade una nueva línea si ya hay productos listados
            }
            labelProductos.Text += $"Producto: {producto} | Precio: bs {precio}";
            totalAcumulado += precio;
            labelprecioTotal.Text = $"Total: bs {totalAcumulado}";
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string producto = "Broaster";
            int precio = 100;
            if (labelProductos.Text.Length > 0)  // Verifica si el Label ya tiene texto
            {
                labelProductos.Text += "\n";     // Añade una nueva línea si ya hay productos listados
            }
            labelProductos.Text += $"Producto: {producto} | Precio: bs {precio}";
            totalAcumulado += precio;
            labelprecioTotal.Text = $"Total: bs {totalAcumulado}";
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            string producto = "Hamburguesa";
            int precio = 70;
            if (labelProductos.Text.Length > 0)  // Verifica si el Label ya tiene texto
            {
                labelProductos.Text += "\n";     // Añade una nueva línea si ya hay productos listados
            }
            labelProductos.Text += $"Producto: {producto} | Precio: bs {precio}";
            totalAcumulado += precio;
            labelprecioTotal.Text = $"Total: bs {totalAcumulado}";
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            string producto = "Pizza";
            int precio = 100;
            if (labelProductos.Text.Length > 0)  // Verifica si el Label ya tiene texto
            {
                labelProductos.Text += "\n";     // Añade una nueva línea si ya hay productos listados
            }
            labelProductos.Text += $"Producto: {producto} | Precio: bs {precio}";
            totalAcumulado += precio;
            labelprecioTotal.Text = $"Total: bs {totalAcumulado}";

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            string producto = "Papas Fritas";
            int precio = 30;
            if (labelProductos.Text.Length > 0)  // Verifica si el Label ya tiene texto
            {
                labelProductos.Text += "\n";     // Añade una nueva línea si ya hay productos listados
            }
            labelProductos.Text += $"Producto: {producto} | Precio: bs {precio}";
            totalAcumulado += precio;
            labelprecioTotal.Text = $"Total: bs {totalAcumulado}";

        }
    }
}

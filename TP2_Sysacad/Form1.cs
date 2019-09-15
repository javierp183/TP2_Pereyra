using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catalogo;


namespace TP2_Sysacad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
  
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            VerdetalleArticulo verdetalleArticulo = new VerdetalleArticulo();
            verdetalleArticulo.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo agregararticulo = new AgregarArticulo();
            agregararticulo.Show();

        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            ListadoArticulos listadoArticulos = new ListadoArticulos();
            listadoArticulos.Show();
        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            ModificarArticulo modificarArticulo = new ModificarArticulo();
            modificarArticulo.Show();
        }

        private void button_borrar_Click(object sender, EventArgs e)
        {
            EliminarArticulo eliminarArticulo = new EliminarArticulo();
            eliminarArticulo.Show();

        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            BusquedaDeArticulo busquedaDeArticulo = new BusquedaDeArticulo();
            busquedaDeArticulo.Show();
        }
    }
}

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
using Dominio;

namespace TP2_Sysacad
{
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        Articulo aux = new Articulo();
        CatalogoDeArticulos catalogo = new CatalogoDeArticulos();
        string Nombre;
        string Codigo;
        string Descripcion;
        string Precio;
        string Marca;
        string Categoria;
       

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {


        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Codigo = txtCodigo.Text;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Nombre = txtNombre.Text;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            Descripcion = txtDescripcion.Text;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            Precio = txtPrecio.Text;
        }

        private void agregarMiArticulo(Articulo art)
        {
            
            art.Nombre = Nombre;
            art.Descripcion = Descripcion;
            art.Codigo = Codigo;
            art.Precio = System.Convert.ToDecimal(Precio);
            art.Marca = Marca;
            art.Categoria = Categoria;
            catalogo.agregar(art);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarMiArticulo(aux);
            MessageBox.Show("Agreado el articulo: " + Nombre);
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            Marca = txtMarca.Text;
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            Categoria = txtCategoria.Text;
        }
    }
}

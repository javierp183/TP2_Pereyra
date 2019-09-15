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
    public partial class ModificarArticulo : Form
    {
        public ModificarArticulo()
        {
            InitializeComponent();
        }

        Articulo aux = new Articulo();
        string Codigo;
        string Nombre;
        string Descripcion;
        decimal Precio;
        string Marca;
        string Categoria;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            Categoria = txtCategoria.Text;
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

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            Marca = txtMarca.Text;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDatosAmodificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModificarArticulo_Load(object sender, EventArgs e)
        {


            //Console.WriteLine(dgvDatosAmodificar.Rows[0].Cells["Codigo"].Value.ToString());

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {    
            CatalogoDeArticulos catalogo = new CatalogoDeArticulos();
            dgvDatosAmodificar.DataSource = catalogo.buscar(Codigo);


            for (int rows = 0; rows < dgvDatosAmodificar.Rows.Count; rows++)
            {
              //  if (Codigo == dgvDatosAmodificar.Rows[rows].Cells["Codigo"].Value.ToString())
                //{
                    //Console.WriteLine(dgvDatosAmodificar.Rows[rows].Cells["Id"].Value.ToString());
                   aux.Id = (int)dgvDatosAmodificar.Rows[rows].Cells["Id"].Value;
                   aux.Codigo = dgvDatosAmodificar.Rows[rows].Cells["Codigo"].ToString();
                   aux.Nombre = dgvDatosAmodificar.Rows[rows].Cells["Nombre"].ToString();
                   aux.Descripcion = dgvDatosAmodificar.Rows[rows].Cells["Descripcion"].ToString();
                   aux.Marca = dgvDatosAmodificar.Rows[rows].Cells["Marca"].ToString();
                   aux.Precio = (decimal)dgvDatosAmodificar.Rows[rows].Cells["Precio"].Value;
                   aux.Categoria = dgvDatosAmodificar.Rows[rows].Cells["Categoria"].ToString();

                    //dgvDatosAmodificar.DataSource = aux.Id;
                //}
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CatalogoDeArticulos update_catalogo = new CatalogoDeArticulos();
            agregarModificaciones();
            update_catalogo.modificar(aux);     

        }

        private void agregarModificaciones()
        {

            if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                aux.Codigo = Codigo;
            }
            if(!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                aux.Nombre = Nombre;
            }
            if(!string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                aux.Descripcion = Descripcion;
            }
            if(!string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                aux.Marca = Marca;
            }
            if(!string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                aux.Precio = (decimal)Precio;
            }
            if(!string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                aux.Categoria = Categoria;
            }

        }
    }
}

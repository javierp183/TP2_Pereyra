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
    public partial class EliminarArticulo : Form
    {
        public EliminarArticulo()
        {
            InitializeComponent();
        }
        string Codigo;

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Codigo = txtCodigo.Text;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CatalogoDeArticulos catalogo = new CatalogoDeArticulos();

            try
            {
                catalogo.borrar(Codigo);
                MessageBox.Show("Articulo con codigo: " + Codigo + " Borrado.");
            }
            catch (Exception ex)
            {

                throw ex;
            }

            

        }
    }
}

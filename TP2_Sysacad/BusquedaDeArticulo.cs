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
    public partial class BusquedaDeArticulo : Form
    {
        string Codigo;

        public BusquedaDeArticulo()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Codigo = txtCodigo.Text;
            CatalogoDeArticulos catalogo = new CatalogoDeArticulos();
            dgvDetalleArticulo.DataSource = catalogo.buscar(Codigo);
            dgvDetalleArticulo.Columns[0].Visible = false;

        }

        private void btnArtCodeBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void BusquedaDeArticulo_Load(object sender, EventArgs e)
        {
            
 
        }

    }
}

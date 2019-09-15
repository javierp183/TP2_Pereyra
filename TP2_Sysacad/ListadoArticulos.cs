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
    public partial class ListadoArticulos : Form
    {
        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            CatalogoDeArticulos catalogo = new CatalogoDeArticulos();
            try
            {
                dgvListadoArticulos.DataSource = catalogo.listar();
                dgvListadoArticulos.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListadoArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

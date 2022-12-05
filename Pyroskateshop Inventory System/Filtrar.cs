using System;
using System.Windows.Forms;

namespace Pyroskateshop_Inventory_System
{
    public partial class Filtrar : Form
    {
        string filtro;

        public Filtrar()
        {
            InitializeComponent();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            cbTipo.SelectedIndex = 0;
        }

        private void cbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            cbCategoria.SelectedIndex = 0;
        }
    }
}

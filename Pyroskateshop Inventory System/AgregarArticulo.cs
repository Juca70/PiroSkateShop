using Pyroskateshop_Inventory_System.Modelo.Entidad;
using Pyroskateshop_Inventory_System.Modelo.Table;
using System;
using System.Windows.Forms;

namespace Pyroskateshop_Inventory_System
{
    public partial class AgregarArticulo : Form
    {
        TableManager manager;

        public AgregarArticulo()
        {
            InitializeComponent();
            manager = new TableManager();
            cbCategorias.SelectedIndex = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int categoria = cbCategorias.SelectedIndex;
            string descripcion = tbDescripcion.Text.Trim();
            string marca = tbMarca.Text.Trim();
            string medida = tbMedida.Text.Trim();
            string cantExistencias = tbCantidad.Text.Trim();
            string costoCompra = tbPrecioCompra.Text.Trim();
            string costoDolares = tbPrecioDolares.Text.Trim();
            string precioVenta = tbPrecioVenta.Text.Trim();

            if (descripcion == "" || marca == "" || cantExistencias == "" || costoCompra == "" ||
                precioVenta == "")
            {
                MessageBox.Show("Los siguientes campos no pueden estar vacíos: descripción, marca, " +
                    "existencias, costo de compra y precio de venta.", "Error");
            }
            else
            {
                int cant = int.Parse(cantExistencias);
                decimal costoc = decimal.Parse(costoCompra);
                decimal preciov = decimal.Parse(precioVenta);
                decimal costod;

                if (medida == "")
                {
                    medida = "N/A";
                }

                if (costoDolares == "")
                {
                    costod = 0;
                }
                else
                {
                    costod = decimal.Parse(costoDolares);
                }

                if (cant == 0)
                {
                    MessageBox.Show("Cantidad no puede ser igual a 0");
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Desea crear un artículo con esos datos?",
                        "Ingresar artículo", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Articulo articulo = new Articulo();
                        Categoria c = new Categoria();
                        c.Id = categoria + 1;
                        articulo.Categoria = c;
                        articulo.Descripcion = descripcion;
                        articulo.Marca = marca;
                        articulo.Medida = medida;
                        articulo.CantExistencia = cant;
                        articulo.CostoCompra = costoc;
                        articulo.CostoDolares = costod;
                        articulo.PrecioVenta = preciov;
                        articulo.Estado = "Activo";

                        manager.ArticuloTable.Insertar(articulo);

                        MessageBox.Show("Se agregó el artículo correctamente", "Correcto");
                        tbDescripcion.Text = "";
                        tbMarca.Text = "";
                        tbMedida.Text = "";
                        tbCantidad.Text = "";
                        tbPrecioCompra.Text = "";
                        tbPrecioDolares.Text = "";
                        tbPrecioVenta.Text = "";
                    }
                }
            }
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbPrecioDolares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
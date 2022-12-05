using Pyroskateshop_Inventory_System.Modelo.Entidad;
using Pyroskateshop_Inventory_System.Modelo.Table;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pyroskateshop_Inventory_System
{
    public partial class Modificaciones : Form
    {
        private Articulo articulo;
        TableManager manager;

        public Modificaciones(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            manager = new TableManager();
            inicializarCampos();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void inicializarCampos()
        {
            cbCategorias.SelectedIndex = articulo.Categoria.Id-1;
            tbDescripcion.Text = articulo.Descripcion;
            tbMarca.Text = articulo.Marca;
            tbMedida.Text = articulo.Medida;
            tbCantidad.Text = articulo.CantExistencia.ToString();
            tbPrecioCompra.Text = articulo.CostoCompra.ToString();
            tbPrecioDolares.Text = articulo.CostoDolares.ToString();
            tbPrecioVenta.Text = articulo.PrecioVenta.ToString();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
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
                MessageBox.Show("Los siguientes campos no pueden estar vacíos: descripción, marca," +
                    "existencias, costo de compra y precio de venta.");

            }
            else
            {
                int cant = int.Parse(cantExistencias);
                decimal costoc = decimal.Parse(costoCompra);
                decimal preciov = decimal.Parse(precioVenta);
                decimal costod;

                if (medida == "" || costoDolares == "")
                {
                    medida = "N/A";
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
                    DialogResult result = MessageBox.Show("¿Desea modificar un artículo con esos datos?",
                        "Ingresar artículo", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
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

                        manager.ArticuloTable.Modificar(articulo);

                        MessageBox.Show("Se modificó el artículo correctamente", "Bien hecho");
                        this.Dispose();
                    }
                }
            }
        }

        private void pAgregarArticulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

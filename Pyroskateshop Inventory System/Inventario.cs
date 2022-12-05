using Pyroskateshop_Inventory_System.Modelo.Entidad;
using Pyroskateshop_Inventory_System.Modelo.Table;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pyroskateshop_Inventory_System
{
    public partial class Inventario : Form
    {
        private TableManager tableManager;

        public Inventario()
        {
            InitializeComponent();
            tableManager = new TableManager();
            inicializarTabla();
        }

        private void inicializarTabla()
        {
            List<Articulo> articulos = tableManager.ArticuloTable.ObtenerTodos();
            foreach (Articulo articulo in articulos)
            {
                int row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = articulo.Id;
                dataGridView1.Rows[row].Cells[1].Value = articulo.Categoria.Descripcion;
                dataGridView1.Rows[row].Cells[2].Value = articulo.Categoria.Tipo;
                dataGridView1.Rows[row].Cells[3].Value = articulo.Descripcion;
                dataGridView1.Rows[row].Cells[4].Value = articulo.Marca;
                dataGridView1.Rows[row].Cells[5].Value = articulo.Medida;
                dataGridView1.Rows[row].Cells[6].Value = articulo.CantExistencia;
                dataGridView1.Rows[row].Cells[7].Value = articulo.CostoCompra;
                dataGridView1.Rows[row].Cells[8].Value = articulo.CostoDolares;
                dataGridView1.Rows[row].Cells[9].Value = articulo.PrecioVenta;
                dataGridView1.Rows[row].Cells[10].Value = articulo.Estado;
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            /*if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGridView1.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\Modificar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGridView1.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\Eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar el artículo?", "Eliminar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                    Articulo articulo = tableManager.ArticuloTable.Obtener(id);
                    tableManager.ArticuloTable.Eliminar(articulo);

                    //dataGridView1.(dataGridView1.CurrentRow);

                    dataGridView1.Rows.Clear();
                    inicializarTabla();
                    dataGridView1.Refresh();
                }
            }

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Modificar")
            {
                int id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                Articulo articulo = tableManager.ArticuloTable.Obtener(id);

                Modificaciones form = new Modificaciones(articulo);
                form.ShowDialog();

                dataGridView1.Rows.Clear();
                inicializarTabla();
                dataGridView1.Refresh();
            }
        }
    }
}

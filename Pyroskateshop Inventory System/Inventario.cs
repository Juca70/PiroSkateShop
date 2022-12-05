using Pyroskateshop_Inventory_System.Modelo.Entidad;
using Pyroskateshop_Inventory_System.Modelo.Table;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            inicializarTabla(tableManager.ArticuloTable.ObtenerTodos());
        }

        private void inicializarTabla(List<Articulo> lista)
        {
            List<Articulo> articulos = lista;
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
                    inicializarTabla(tableManager.ArticuloTable.ObtenerTodos());
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
                inicializarTabla(tableManager.ArticuloTable.ObtenerTodos());
                dataGridView1.Refresh();
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Filtrar form = new Filtrar();
            form.ShowDialog();
        }

        private void tbBusqueda_TextChanged(object sender, System.EventArgs e)
        {
            string text = tbBusqueda.Text.Trim().ToLower();

            List<Articulo> lista = new List<Articulo>();

            foreach (Articulo articulo in tableManager.ArticuloTable.ObtenerTodos())
            {
                if (articulo.Descripcion.ToLower().Contains(text))
                {
                    lista.Add(articulo);
                }
            }

            dataGridView1.Rows.Clear();
            inicializarTabla(lista);
            dataGridView1.Refresh();
        }

        private void tbBusqueda_Enter(object sender, System.EventArgs e)
        {
            if (tbBusqueda.Text == "Buscar por descripción")
            {
                tbBusqueda.Text = "";
                tbBusqueda.ForeColor = Color.Black;
            }
        }

        private void tbBusqueda_Leave(object sender, System.EventArgs e)
        {
            if (tbBusqueda.Text == "")
            {
                tbBusqueda.Text = "Buscar por descripción";
                tbBusqueda.ForeColor = Color.DimGray;

                dataGridView1.Rows.Clear();
                inicializarTabla(tableManager.ArticuloTable.ObtenerTodos());
                dataGridView1.Refresh();
            }
        }
    }
}

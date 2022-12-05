using Pyroskateshop_Inventory_System.Modelo.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyroskateshop_Inventory_System.Modelo.Table
{
    public class ArticuloTable : Table<Articulo, int>
    {
        private string stringConnection;

        private const string SELECTALL =
            "SELECT " +
            "A.id, " +
            "C.id," +
            "C.descripcion, " +
            "C.tipo, " +
            "A.descripcion, " +
            "A.marca, " +
            "A.medida, " +
            "A.cant_existencias, " +
            "A.costo_compra, " +
            "A.costo_dolares, " +
            "A.precio_venta, " +
            "A.estado " +
            "FROM Articulo A INNER JOIN Categoria C ON A.categoria = C.id";

        private const string SELECTBY =
            SELECTALL + " WHERE A.id = @id";

        private const string SELECTBYTIPO =
            SELECTALL + " WHERE C.tipo = @tipo";

        private const string SELECTBYCATEGORIA =
            SELECTALL + " WHERE C.descripcion = @descrip";

        private const string SELECTBYDESCRIPCION =
           SELECTALL + " WHERE A.descripcion LIKE '%@descrip%'";

        private const string INSERT =
            "INSERT INTO Articulo (categoria, descripcion, marca, medida, " +
            "cant_existencias, costo_compra, costo_dolares, precio_venta, estado) " +
            "values(@cat, @descrip, @marca, @medida, @cant, @costc, @costod, " +
            "@preciov, @estado)";

        private const string UPDATE =
            "UPDATE Articulo SET " +
            "categoria = @cat, " +
            "descripcion = @descrip, " +
            "marca = @marca, " +
            "medida = @medida, " +
            "cant_existencias = @cant," +
            "costo_compra = @costoc, " +
            "costo_dolares = @costod, " +
            "precio_venta = @preciov, " +
            "estado = @estado " +
            "WHERE id = @id";

        private const string DELETE =
            "DELETE FROM Articulo WHERE id = @id";

        public ArticuloTable(string stringConnection)
        {
            this.stringConnection = stringConnection;
        }

        public void Eliminar(Articulo obj)
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand cmd = new SqlCommand(DELETE, conn);
                cmd.Parameters.AddWithValue("@id", obj.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Insertar(Articulo obj)
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand cmd = new SqlCommand(INSERT, conn);
                cmd.Parameters.AddWithValue("@cat", obj.Categoria.Id);
                cmd.Parameters.AddWithValue("@descrip", obj.Descripcion);
                cmd.Parameters.AddWithValue("@marca", obj.Marca);
                cmd.Parameters.AddWithValue("@medida", obj.Medida);
                cmd.Parameters.AddWithValue("@cant", obj.CantExistencia);
                cmd.Parameters.AddWithValue("@costc", obj.CostoCompra);
                cmd.Parameters.AddWithValue("@costod", obj.CostoDolares);
                cmd.Parameters.AddWithValue("@preciov", obj.PrecioVenta);
                cmd.Parameters.AddWithValue("@estado", obj.Estado);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Articulo Obtener(int id)
        {
            Articulo articulo = null;

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand command = new SqlCommand(SELECTBY, conn);
                command.Parameters.AddWithValue("@id", id);

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    articulo = Convertir(reader);
                }
            }

            return articulo;
        }

        private Articulo Convertir(SqlDataReader reader)
        {
            Articulo obj = new Articulo();
            obj.Id = reader.GetInt32(0);

            Categoria c = new Categoria();
            c.Id = reader.GetInt32(1);
            c.Descripcion = reader.GetString(2);
            c.Tipo = reader.GetString(3);

            obj.Categoria = c;
            obj.Descripcion = reader.GetString(4);
            obj.Marca = reader.GetString(5);
            obj.Medida = reader.GetString(6);
            obj.CantExistencia = reader.GetInt32(7);
            obj.CostoCompra = reader.GetDecimal(8);
            obj.CostoDolares = reader.GetDecimal(9);
            obj.PrecioVenta = reader.GetDecimal(10);
            obj.Estado = reader.GetString(11);
            return obj;
        }
        public List<Articulo> ObtenerTodos()
        {
            List<Articulo> lista = new List<Articulo>();

            using (SqlConnection conn = new SqlConnection(this.stringConnection))
            {
                SqlCommand cmd = new SqlCommand(SELECTALL, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(Convertir(reader));
                }
            }

            return lista;
        }

        public List<Articulo> ObtenerPorCategoria(string categoria)
        {
            List<Articulo> lista = new List<Articulo>();

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand cmd = new SqlCommand(SELECTBYCATEGORIA, conn);
                cmd.Parameters.AddWithValue("@descrip", categoria);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(Convertir(reader));
                }
            }

            return lista;
        }

        public List<Articulo> ObtenerPorTipo(string tipo)
        {
            List<Articulo> lista = new List<Articulo>();

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand cmd = new SqlCommand(SELECTBYTIPO, conn);
                cmd.Parameters.AddWithValue("@tipo", tipo);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(Convertir(reader));
                }
            }

            return lista;
        }

        public List<Articulo> ObtenerPorDescripcion(string descripcion)
        {
            List<Articulo> lista = new List<Articulo>();

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand cmd = new SqlCommand(SELECTBYDESCRIPCION, conn);
                cmd.Parameters.AddWithValue("@descrip", descripcion);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(Convertir(reader));
                }
            }

            return lista;
        }

        public void Modificar(Articulo obj)
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand cmd = new SqlCommand(UPDATE, conn);
                cmd.Parameters.AddWithValue("@cat", obj.Categoria.Id);
                cmd.Parameters.AddWithValue("@descrip", obj.Descripcion);
                cmd.Parameters.AddWithValue("@marca", obj.Marca);
                cmd.Parameters.AddWithValue("@medida", obj.Medida);
                cmd.Parameters.AddWithValue("@cant", obj.CantExistencia);
                cmd.Parameters.AddWithValue("@costoc", obj.CostoCompra);
                cmd.Parameters.AddWithValue("@costod", obj.CostoDolares);
                cmd.Parameters.AddWithValue("@preciov", obj.PrecioVenta);
                cmd.Parameters.AddWithValue("@estado", obj.Estado);
                cmd.Parameters.AddWithValue("@id", obj.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

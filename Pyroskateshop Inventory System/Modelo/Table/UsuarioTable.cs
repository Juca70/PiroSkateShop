using Pyroskateshop_Inventory_System.Modelo.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pyroskateshop_Inventory_System.Modelo.Table
{
    public class UsuarioTable : Table<Usuario, int>
    {
        private const string SELECT = "SELECT * FROM Usuario WHERE nombre=@username and contrasenia=@password";

        private string stringConnection;

        public UsuarioTable(string stringConnection)
        {
            this.stringConnection = stringConnection;
        }

        public void Eliminar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Usuario Obtener(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public Usuario Obtener(string username, string password)
        {
            Usuario usuario = null;

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand cmd = new SqlCommand(SELECT, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.Id = reader.GetInt32(0);
                    usuario.NombreUsuario = reader.GetString(1);
                    usuario.Contraseña = reader.GetString(2);
                    usuario.FechaAlta = reader.GetString(3);
                    usuario.PreguntaRecup = reader.GetString(4);
                    usuario.RespuestaRecup = reader.GetString(5);
                    usuario.TipoUsuario = reader.GetString(6);
                }
            }

            return usuario;
        }
    }
}

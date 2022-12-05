using System.Collections.Generic;

namespace Pyroskateshop_Inventory_System.Modelo.Table
{
    public interface Table<T, K>
    {
        /// <summary>
        /// Inserta el objeto pasado por parámeto en la tabla
        /// </summary>
        /// <param name="obj"></param>
        void Insertar(T obj);

        /// <summary>
        /// Modifica el objeto pasado por parámetro de la tabla
        /// </summary>
        /// <param name="obj"></param>
        void Modificar(T obj);

        /// <summary>
        /// Elimina el objeto pasado por parámetro de la tabla
        /// </summary>
        /// <param name="obj"></param>
        void Eliminar(T obj);

        /// <summary>
        /// Regresa la tupla especificada por el Id que se pasa por parámetro
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        T Obtener(K Id);

        /// <summary>
        /// Regresa una lista con todas la tuplas de la tabla
        /// </summary>
        /// <returns></returns>
        List<T> ObtenerTodos();
    }
}

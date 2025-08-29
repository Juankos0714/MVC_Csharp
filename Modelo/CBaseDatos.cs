using Modelo.Entities;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modelo
{
    public class CBaseDatos

    {
        private Conexion conexion;
        List<CLibro> libroLista = new List<CLibro>();
        public CBaseDatos()
        {
            conexion = new Conexion();
            try
            {
                conexion.CrearTabla().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine("advertencia al crear tabla " + ex.ToString());
            }
        }
        public string GuardarLibros(string nombre, string editorial, int precio)
        {
            try
            {
                string consulta = "INSERT INTO libro (nombre, editorial, precio) VALUES (@nombre, @editorial, @precio)";
                MySqlParameter[] parametros = {
                    new MySqlParameter("@nombre",nombre),
                    new MySqlParameter("@editorial",editorial),
                    new MySqlParameter("@precio",precio)
                };
                int filasAfectadas = conexion.EjecutarComando(consulta, parametros);
                if (filasAfectadas > 0)
                    return "Libro guardado";
                else
                    return "No se pudo guardar el libro";
            }
            catch (Exception ex)
            {
                return "Error al guardar: " + ex.Message;

            }

        }
        public string ActualizarLibro(int id, string nombre, string editorial, int precio)
        {
            try
            {
                string consulta = "UPDATE libro SET nombre = @nombre, editorial = @editorial, precio = @precio WHERE id = @id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("@id",id),
                    new MySqlParameter("@nombre",nombre),
                    new MySqlParameter("@editorial",editorial),
                    new MySqlParameter("@precio",precio)
                };
                int filasAfectadas = conexion.EjecutarComando(consulta, parametros);
                if (filasAfectadas > 0)
                    return "Libro actualizado";
                else
                    return "No se pudo actualizar el libro";
            }
            catch (Exception ex)
            {
                return "Error al actualizar: " + ex.Message;

            }
        }
        public string EliminarLibro(int id)
        {
            try
            {
                string consulta = "DELETE FROM libro WHERE id = @id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("@id",id),

                };
                int filasAfectadas = conexion.EjecutarComando(consulta, parametros);
                if (filasAfectadas > 0)
                    return "Libro eliminado";
                else
                    return "No se pudo eliminar el libro";
            }
            catch (Exception ex)
            {
                return "Error al eliminar: " + ex.Message;
            }
        }

        public List<CLibro> listaLibrosActual()
        {
            List<CLibro> listaLibros = new List<CLibro>();
            MySqlDataReader reader = null;

            try
            {
                string consulta = "SELECT id, nombre, editorial, precio FROM libro ORDER BY id";
                reader = conexion.EjecutarConsulta(consulta);
                while (reader.Read())
                {
                    CLibro libro = new CLibro
                    {
                        ID = reader.GetInt32("id"),
                        nombre = reader.GetString("nombre"),
                        editorial = reader.GetString("editorial"),
                        precio = reader.GetInt32("precio"),
                    };
                    listaLibros.Add(libro);
                }
                return listaLibros;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de libros: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
        }
    }
}
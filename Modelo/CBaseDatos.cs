
using Modelo.Entities;

namespace Modelo
{
    public class CBaseDatos
    {
        List<CLibro> libroLista = new List<CLibro>();
        public string GuardarLibros(string nombre, string editorial, int precio)
        {
            string respuesta = "";
            CLibro cLibro = new CLibro();  
            cLibro.ID = 1;
            cLibro.nombre = nombre;
            cLibro.editorial = editorial;   
            cLibro.precio = precio;

            libroLista.Add(cLibro);
            respuesta = "guardado";
            return respuesta;
        }
        public List<CLibro> listaLibrosActual()
        {
            List<CLibro> respuesta = libroLista;
            return respuesta;
        }
         
            
    }

}

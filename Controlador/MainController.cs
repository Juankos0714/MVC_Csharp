using Modelo;
using Modelo.Entities;

namespace Controlador
{
    public class MainController
    {
        CBaseDatos baseDatos;
        public MainController()
        {
            baseDatos = new CBaseDatos();
        }
        public string GuardarDatos(string nombre, string editorial, int precio)
        {
            string respuesta = "";
            respuesta = baseDatos.GuardarLibros(nombre, editorial, precio); 
            return respuesta;
        }
        public List<CLibro> listarLibros()
        {
            List<CLibro> lista;
            lista = baseDatos.listaLibrosActual();
            return lista;
        }
        





            
    }
}

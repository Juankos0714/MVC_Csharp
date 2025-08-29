namespace Modelo.Entities
{
    public class CLibro
    {
        public int ID { get; set; }

        public string nombre { get; set; } = string.Empty;
        public string editorial { get; set; } = string.Empty;

        public int precio { get; set; }
    }
}

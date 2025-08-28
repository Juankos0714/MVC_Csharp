using Controlador;
using System.Windows.Forms;
namespace MVC
{
    public partial class Main : Form
    {
        Controlador.MainController oMainController = new Controlador.MainController();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void lblAnio_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string editorial = tbEditorial.Text;
            int precio = Convert.ToInt32(tbPrecio.Text);
            string respuesta = oMainController.GuardarDatos(nombre, editorial, precio);
            MessageBox.Show(respuesta);

            var listaLibros = oMainController.listarLibros();
            dgvLibros.Rows.Clear();

            dgvLibros.Rows.Add(nombre, editorial, precio);
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

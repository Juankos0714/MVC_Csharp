using Controlador;
using System.Windows.Forms;
namespace MVC
{
    public partial class Main : Form
    {
        Controlador.MainController oMainController = new Controlador.MainController();
        private int libroSeleccionadoID = -1;

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
            if (ValidarCampos())
            {
                try
                {
                    string nombre = tbNombre.Text;
                    string editorial = tbEditorial.Text;
                    int precio = Convert.ToInt32(tbPrecio.Text);
                    string respuesta = oMainController.GuardarDatos(nombre, editorial, precio);
                    MessageBox.Show(respuesta);
                    var listaLibros = oMainController.listarLibros();
                    dgvLibros.Rows.Clear();

                    dgvLibros.Rows.Add(nombre, editorial, precio);

                    if (respuesta.Contains("well"))
                    {
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el libro " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (libroSeleccionadoID == -1)
            {
                MessageBox.Show("Seleccione un libro");
            }
            if (ValidarCampos())
            {
                try
                {
                    string nombre = tbNombre.Text;
                    string editorial = tbEditorial.Text;
                    int precio = Convert.ToInt32(tbPrecio.Text);
                    string respuesta = oMainController.ActualizarLibro(libroSeleccionadoID, nombre, editorial, precio);
                    MessageBox.Show(respuesta);
                    var listaLibros = oMainController.listarLibros();
                    dgvLibros.Rows.Clear();

                    dgvLibros.Rows.Add(nombre, editorial, precio);

                    if (respuesta.Contains("well"))
                    {
                        LimpiarCampos();
                        libroSeleccionadoID = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el libro " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];
                    libroSeleccionadoID = Convert.ToInt32(fila.Tag);
                    tbNombre.Text = fila.Cells["ID"].Value.ToString();
                    tbEditorial.Text = fila.Cells["Editorial"].Value.ToString();
                    tbPrecio.Text = fila.Cells["Precio"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("falta el nombre del libro");
                tbNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbEditorial.Text))
            {
                MessageBox.Show("falta la editorial");
                tbEditorial.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbPrecio.Text))
            {
                MessageBox.Show("falta el precio");
                tbPrecio.Focus();
                return false;
            }

            if (!int.TryParse(tbPrecio.Text, out int precio) || precio <= 0)
            {
                MessageBox.Show("falta un precio válido (número entero mayor a 0)");
                tbPrecio.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            tbNombre.Text = "";
            tbEditorial.Text = "";
            tbPrecio.Text = "";
            dgvLibros.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (libroSeleccionadoID == -1)
            {
                MessageBox.Show("Seleccione un libro");
            }
            DialogResult resultado = MessageBox.Show("Seguro?","COnfirmar seleccion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado==DialogResult.Yes)
            {
                try
                {

                    string respuesta = oMainController.EliminarLibros(libroSeleccionadoID);
                    MessageBox.Show(respuesta);


                    if (respuesta.Contains("well"))
                    {
                        LimpiarCampos();
                        libroSeleccionadoID = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el libro " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            libroSeleccionadoID = -1;
        }
    }
}

using Controlador;
using Modelo.Entities;
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
            CargarLibros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    int precio = int.Parse(tbPrecio.Text);

                    string resultado = oMainController.GuardarDatos(tbNombre.Text.Trim(),
                                                              tbEditorial.Text.Trim(),
                                                              precio);

                    MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK,
                                  resultado.Contains("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information);

                    if (!resultado.Contains("Error"))
                    {
                        LimpiarCampos();
                        CargarLibros();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("El precio debe ser un número válido", "Error de validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarLibros()
        {
            dgvLibros.Rows.Clear();
            List<CLibro> libros = oMainController.listarLibros();
            foreach (CLibro libro in libros)
            {
                int index = dgvLibros.Rows.Add(libro.ID, libro.nombre, libro.editorial, libro.precio);
                dgvLibros.Rows[index].Tag = libro.ID; 
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (libroSeleccionadoID == -1)
            {
                MessageBox.Show("Seleccione un libro");
                return;
            }

            if (ValidarCampos())
            {
                try
                {
                    string nombre = tbNombre.Text.Trim();
                    string editorial = tbEditorial.Text.Trim();
                    int precio = Convert.ToInt32(tbPrecio.Text);

                    string respuesta = oMainController.ActualizarLibro(libroSeleccionadoID, nombre, editorial, precio);
                    MessageBox.Show(respuesta);

                    if (respuesta.Contains("actualizado"))
                    {
                        LimpiarCampos();
                        libroSeleccionadoID = -1;
                        CargarLibros(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    libroSeleccionadoID = Convert.ToInt32(fila.Cells["ID"].Value); 
                    tbNombre.Text = fila.Cells["Nombre"].Value.ToString();
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
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar este libro?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string respuesta = oMainController.EliminarLibros(libroSeleccionadoID);
                    MessageBox.Show(respuesta);

                    if (respuesta.Contains("eliminado"))
                    {
                        LimpiarCampos();
                        libroSeleccionadoID = -1;
                        CargarLibros(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

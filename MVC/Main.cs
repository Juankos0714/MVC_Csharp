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
            oMainController.GetList();
        }

        private void lblAnio_Click(object sender, EventArgs e)
        {

        }
    }
}

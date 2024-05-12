namespace pryBlaiottaEtapa2
{
    public partial class Form1 : Form
    {
        clsVehiculo objVehiculo;
        public Form1()
        {
            InitializeComponent();

            objVehiculo = new clsVehiculo();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            objVehiculo.crearVehiculo(pictureBox1);
        }
    }
}
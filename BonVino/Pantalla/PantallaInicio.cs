namespace BonVino
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void btnGenerarRaking_Click(object sender, EventArgs e)
        {
            PantallaGenerarRakings pantallaGenerarRakings = new PantallaGenerarRakings();
            pantallaGenerarRakings.opcionGenerarRakingVinos();
           // this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tituloInicio_Click(object sender, EventArgs e)
        {

        }
    }
}

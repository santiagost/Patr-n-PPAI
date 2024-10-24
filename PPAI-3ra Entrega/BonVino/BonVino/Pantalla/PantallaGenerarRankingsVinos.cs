using BonVino.Entidad;
using BonVino.Gestor;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace BonVino
{
    public partial class PantallaGenerarRakings : Form
    {
        // ATRIBUTOS
        private bool confirmacion;
        private DateTime fechaReseñaDesde;
        private DateTime fechaReseñaHasta;
        private string seleccionTipoReseña;
        private string seleccionTipoVisualizacion;
        GestorRakingsVinos gestorRakingsVinos;

        //METODOS
        public PantallaGenerarRakings()
        {
            InitializeComponent();
            gestorRakingsVinos = new GestorRakingsVinos(this);
        }
        public void habilitarPantalla()
        {
            this.Show();
        }
        public void opcionGenerarRakingVinos()
        {
            habilitarPantalla();
            gestorRakingsVinos.opcionGenerarRakingVinos();
        }
        public void solicitarFechaReseñaDesdeYHasta()
        {
            dateTimePickerFechaDesde.Enabled = true;
        }
        private void PantallaGenerarRankingsVinos_Load(object sender, EventArgs e)
        {
            //En la carga de la pantalla se ponen visibles algunos elementos
            textoErrorPeriodoFechas.Visible = false;
            lblTipoReseña.Visible = false;
            tipoReseña.Visible = false;
            lblFormasVisualizacion.Visible = false;
            formasVisualizacion.Visible = false;
            btnConfirmar.Visible = false;
            confirmacion = false;
        }

        
        private void tomarFechaReseñaDesde()
        {
            fechaReseñaDesde = dateTimePickerFechaDesde.Value;
        }

        private void tomarFechaReseñaHasta()
        {
            fechaReseñaHasta = dateTimePickerFechaHasta.Value;
            
        }

        private void validarFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            //se toma el valor del DatiTimePicker y se compara la fecha desde y hasta para ver que la
            //fecha desde sea mayor a la fecha hasta

            if (fechaDesde >= fechaHasta)
            {
                textoErrorPeriodoFechas.Visible = true;
            }
            else
            {   if (fechaHasta > DateTime.Now)
                {
                    textoErrorPeriodoFechas.Visible = false;
                    gestorRakingsVinos.tomarFechaReseñaDesde(fechaDesde);
                    gestorRakingsVinos.tomarFechaReseñaHasta(fechaHasta);
                }
            }
        }
        public void solicitarSeleccionTipoReseña()
        {
            dateTimePickerFechaDesde.Enabled = false;
            dateTimePickerFechaHasta.Enabled = false;
            tipoReseña.Visible = true;
            lblTipoReseña.Visible = true;   
        }
        private void tomarSeleccionTipoReseña(object sender, EventArgs e)
        {
            if (tipoReseña.SelectedItem != null)
            {
                seleccionTipoReseña = tipoReseña.SelectedItem.ToString();

                // ALTERNATIVA 1;A6: Tipo de reseñas: Reseñas normales
                if (seleccionTipoReseña == "Normales")
                {
                    MessageBox.Show("Selecciono reseñas del tipo \"Normales\"");
                    this.Close();
                }
                // ALTERNATIVA 2; A7: Tipo de reseñas: Reseñas de amigos
                if (seleccionTipoReseña == "De Amigos")
                {
                    MessageBox.Show("Selecciono reseñas del tipo \"De Amigos\"");
                    this.Close();
                }

                gestorRakingsVinos.tomarSeleccionTipoReseña(seleccionTipoReseña);
            }
        }
        public void mostrarTiposVisualizacion()
        {
            lblFormasVisualizacion.Visible = true;
            formasVisualizacion.Visible = true;
            tipoReseña.Enabled = false;
        }
        private void tomarSeleccionTipoVisualizacion(object sender, EventArgs e)
        {
            if (formasVisualizacion.SelectedItem != null) 
            {
                seleccionTipoVisualizacion = formasVisualizacion.SelectedItem.ToString();
                gestorRakingsVinos.tomarSeleccionFormaVisualizacion(seleccionTipoVisualizacion);
            }

        }

        public void solicitaConfirmacion()
        {
            btnConfirmar.Visible = true;
            formasVisualizacion.Enabled = false;
        }

        public void tomarConfirmacion()
        {
            confirmacion = true;
            gestorRakingsVinos.tomarConfirmacion(confirmacion);
        }

        public void informarGeneracionExitosa()
        {
            MessageBox.Show("Se genero exitosamente el archivo");
        }

        //CAMBIOS EN LA PANTALLA

        private void dateTimePickerFechas_ValueChanged(object sender, EventArgs e)
        {
            //cada vez que cambia el valor de la fecha puesta por el usuario se validan las fechas
            this.tomarFechaReseñaDesde();
            this.tomarFechaReseñaHasta();   
            validarFechas(fechaReseñaDesde, fechaReseñaHasta);
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            confirmacion = true;
            gestorRakingsVinos.tomarConfirmacion(confirmacion);
        }
    }
}

using BonVino.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using BonVino.Pantalla;
using BonVino.Interfaz;

namespace BonVino.Gestor
{
    public class GestorRakingsVinos : Agregado
    {
        public bool confirmacion;
        public List<Vino> vinos;
        public List<(string, float, string, string, string, float, List<string>)> datosVinosEnPeriodoSomelierConPromedio;
        private PantallaGenerarRakings pantallaGenerarRaking;
        private DateTime fechaReseñaDesde;
        private DateTime fechaReseñaHasta;
        private string seleccionTipoReseña;
        private string seleccionFormaVisualizacion;
        private InterfazExcel interfazExcel;
        private IteradorVinos iteradorVinos;

        public GestorRakingsVinos(PantallaGenerarRakings pantallaGenerarRakings)
        {
            this.pantallaGenerarRaking = pantallaGenerarRakings;
            this.vinos = new List<Vino>();
            this.interfazExcel = new InterfazExcel();
            this.datosVinosEnPeriodoSomelierConPromedio = new List<(string, float, string, string, string, float, List<string>)>();
        }

        public void opcionGenerarRakingVinos()
        {
            pantallaGenerarRaking.solicitarFechaReseñaDesdeYHasta();
        }

        public Iterador crearIterador(Object[] elementos)
        {
            return new IteradorVinos(elementos);
        }

        public void tomarFechaReseñaDesde(DateTime fechaDesde)
        {
            this.fechaReseñaDesde = fechaDesde;
        }
        public void tomarFechaReseñaHasta(DateTime fechaHasta)
        {
            this.fechaReseñaHasta = fechaHasta;
            pantallaGenerarRaking.solicitarSeleccionTipoReseña();
        }

        public void tomarSeleccionTipoReseña(string tipoReseña)
        {
            this.seleccionTipoReseña = tipoReseña;
            pantallaGenerarRaking.mostrarTiposVisualizacion();
        }
        public void tomarSeleccionFormaVisualizacion(string tipoVisualizacion)
        {
            this.seleccionFormaVisualizacion = tipoVisualizacion;
            pantallaGenerarRaking.solicitaConfirmacion();

        }

        public void tomarConfirmacion(bool confirmacionPantalla)
        {
            this.confirmacion = confirmacionPantalla;
            buscarVinosDeSomelierEnPeriodo();
            ordenarVinosEnPeriodoDeSomelierConPromedio();
            generarArchivoRakingsVinos();
            pantallaGenerarRaking.informarGeneracionExitosa();
            finCU();

        }
        public void buscarVinosDeSomelierEnPeriodo()
        {
            //crear los vinos
            string rutaVinosJSON = "C:\\Users\\santi\\source\\BonVino\\BonVino\\Recursos\\jsonVinos.json";
            string contenidoVinosJson = File.ReadAllText(rutaVinosJSON);
            vinos = JsonConvert.DeserializeObject<List<Vino>>(contenidoVinosJson);
            int cant = 0;
            while (cant < vinos.Count) {
                MessageBox.Show(vinos[cant].ToString());
                cant++;
            }
            foreach (Vino vino in vinos)
            {
                float promedioReseñasEnPeriodoDeSomelier = vino.calcularPromedioReseñasEnPeriodo(this.fechaReseñaDesde, this.fechaReseñaHasta);
                //MessageBox.Show(promedioReseñasEnPeriodoDeSomelier.ToString());
                if (promedioReseñasEnPeriodoDeSomelier == -1) {
                    return;
                }
                string nombreVino = vino.getNombre;
                float precioVino = vino.getPrecioARS;
                List<string> varietales = vino.buscarVarietal();
                (string nombreBodega, string nombreRegion, string nombrePais) = vino.buscarDatosBodegaRegionPais();
                datosVinosEnPeriodoSomelierConPromedio.Add((nombreVino, precioVino, nombreBodega, nombreRegion, nombrePais, promedioReseñasEnPeriodoDeSomelier, varietales));
            }
        }
        public void ordenarVinosEnPeriodoDeSomelierConPromedio()
        {
            datosVinosEnPeriodoSomelierConPromedio.Sort((x, y) => y.Item6.CompareTo(x.Item6));
            if (datosVinosEnPeriodoSomelierConPromedio.Count > 10)
            {
                datosVinosEnPeriodoSomelierConPromedio.RemoveRange(10, this.datosVinosEnPeriodoSomelierConPromedio.Count - 10);
            }
        }
        public void generarArchivoRakingsVinos()
        {
            interfazExcel.exportarExcel(datosVinosEnPeriodoSomelierConPromedio);
        }
        public void finCU()
        {
            pantallaGenerarRaking.WindowState = FormWindowState.Minimized;
            interfazExcel.WindowState = FormWindowState.Minimized;
            
        }
        

    } }

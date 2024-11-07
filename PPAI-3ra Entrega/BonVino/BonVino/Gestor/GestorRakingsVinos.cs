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
using Newtonsoft.Json.Serialization;
using System.Collections;

namespace BonVino.Gestor
{
    public class GestorRakingsVinos : Agregado
    {
        public bool confirmacion;
        public Vino[] vinos;
        public List<(string, float, string, string, string, float, string[])> datosVinosEnPeriodoSomelierConPromedio;
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
            //this.vinos = Vino[90];
            this.interfazExcel = new InterfazExcel();
            this.datosVinosEnPeriodoSomelierConPromedio = new List<(string, float, string, string, string, float, string[])>();
        }

        public void opcionGenerarRakingVinos()
        {
            pantallaGenerarRaking.solicitarFechaReseñaDesdeYHasta();
        }

        public Iterador crearIterador(object[] elementos)
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
            string rutaVinosJSON = "C:\\Users\\santi\\source\\BonVino\\BonVino\\Recursos\\jsonVinos.json";
            string rutaVinosJSONSinReseñasSomelier = "C:\\Users\\santi\\source\\Patron-PPAI - copia\\PPAI-3ra Entrega\\BonVino\\BonVino\\Recursos\\jsonVinos - Sin reseñas somelier.json";
            string contenidoVinosJson = File.ReadAllText(rutaVinosJSONSinReseñasSomelier);
            this.vinos = JsonConvert.DeserializeObject<Vino[]>(contenidoVinosJson); 

            //APLICANDO ITERADOR DE VINOS

            iteradorVinos = (IteradorVinos) this.crearIterador(vinos);

            while (iteradorVinos.hasTerminado() == false) 
            {
                iteradorVinos.hasTerminado();

                Vino vinoActual = (Vino)iteradorVinos.actual();

                //CALCULAR PROMEDIO DE LAS RESEÑAS DE SOMELIERDE CADA VINO 

                float promedioReseñasEnPeriodoDeSomelier = vinoActual.calcularPromedioReseñasEnPeriodo(fechaReseñaDesde, fechaReseñaHasta, seleccionTipoReseña);
                if (promedioReseñasEnPeriodoDeSomelier == -1)
                {
                    return;
                }
                
                //ARMANDO ATRIBUTO QUE CONTIENE LA INFORMACION A MOSTRAR DE CADA VINO

                string nombreVino = vinoActual.getNombre;
                float precioVino = vinoActual.getPrecioARS;

                (string nombreBodega, string nombreRegion, string nombrePais) = vinoActual.buscarDatosBodegaRegionPais();
                string[] varietales = vinoActual.buscarVarietal();
                              
                datosVinosEnPeriodoSomelierConPromedio.Add((nombreVino, precioVino, nombreBodega, nombreRegion, nombrePais, promedioReseñasEnPeriodoDeSomelier, varietales));
                iteradorVinos.siguiente();
            }

            bool sinReseñasSomelier = true;
            foreach((string, float, string, string, string, float, string[]) datosVinos in datosVinosEnPeriodoSomelierConPromedio)
            {
                (string nombre, float precioARS, string nombreBodega, string nombreRegion, string nombrePais, float promedioPuntaje, string[] listaVarietales) = datosVinos;
                if (promedioPuntaje != 0)
                {
                    sinReseñasSomelier = false;
                    break;
                }
            }
            if (sinReseñasSomelier)
            {
                MessageBox.Show("No se encontraron reseñas de Sommelier");
                this.finCU();
            }
            
            

        }
        public void ordenarVinosEnPeriodoDeSomelierConPromedio()
        {   
            //ORDENANDO VINOS SEGUN PROMEDIO
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
            //pantallaGenerarRaking.Close();
            //interfazExcel.Close();
        }
    } }

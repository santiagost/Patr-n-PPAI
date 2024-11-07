using BonVino.Interfaz;
using Newtonsoft.Json;
using System.Text;

namespace BonVino.Entidad
{
    public class Vino : Agregado
    {
        [JsonProperty("nombre")]
        private string nombre;
        [JsonProperty("precioARS")]
        private float precioARS;
        [JsonProperty("añada")]
        private int añada;
        [JsonProperty("imagenEtiqueta")]
        private string imagenEtiqueta;
        [JsonProperty("notaDeCataBodega")]
        private float notaDeCataBodega;
        [JsonProperty("bodega")]
        private Bodega bodega;
        [JsonProperty("varietales")]
        private Varietal[] varietales;
        [JsonProperty("reseñas")]
        public Reseña[] reseñas;
        internal IteradorReseñas iteradorReseñas;
        internal IteradorVarietales iteradorVarietales;
        private bool banderaItReseñas = false;
        private bool banderaItVarietales = false;

        public Vino(string nombre, float precioARS, int añada, string imagenEtiqueta, float notaDeCata, Bodega bodega, Varietal[] varietales, Reseña[] reseñas)
        {
            this.nombre = nombre;
            this.precioARS = precioARS;
            this.añada = añada;
            this.imagenEtiqueta = imagenEtiqueta;
            this.notaDeCataBodega = notaDeCata;
            this.bodega = bodega;
            this.varietales = varietales;
            this.reseñas = reseñas;
        }

        public Iterador crearIterador(object[] elementos)
        {
            if (iteradorReseñas == null) 
            {
                return new IteradorReseñas(elementos);
            }
            else
            {
                return new IteradorVarietales(elementos);
            }
            
        }
        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }

        public float getPrecioARS { get { return precioARS; } }
        public float setPrecioARS { set { precioARS = value; } }
        public int getAñada { get { return añada; } }
        public int setAñada { set { añada = value; } }
        public Bodega getBodega { get { return bodega; } }
        public Bodega setBodega { set { bodega = value; } }
        public Reseña[] getReseña { get { return reseñas; } }
        public Varietal[] getVarietales { get { return varietales; }
}


        public float calcularPromedioReseñasEnPeriodo(DateTime fechaDesde, DateTime fechaHasta, string tipoReseña)
        {
            // calcula y devuelve el promedio de puntajes de las reseñas de un vino
            int cont = 0;
            float acum = 0;

            //Filtros
            string filtroSommelier = tipoReseña;
            string filtroFechaDesde = fechaDesde.ToString();
            string filtroFechaHasta = fechaHasta.ToString();
            string[] filtros = [filtroSommelier, filtroFechaDesde, filtroFechaHasta];

            //CREANDO ITERADOR RESEÑAS

            iteradorReseñas = (IteradorReseñas)this.crearIterador(reseñas);
            iteradorReseñas.setFiltros(filtros);
            iteradorReseñas.primero();

            while (iteradorReseñas.hasTerminado() == false) 
            { 
                iteradorReseñas.hasTerminado();
                Reseña reseñaActual = (Reseña)iteradorReseñas.actual();
                
                if (reseñaActual != null)
                {
                    acum += reseñaActual.getPuntaje;
                    cont++;
                }
                
                iteradorReseñas.siguiente();
            }

            if (cont > 0)
            {   
                float promedioReseñas = this.calcularPromedioPuntaje(cont, acum);
                return promedioReseñas;

            }
            else
            {
                return -1;
            }
        }
        public float calcularPromedioPuntaje(int contador, float acumulador)
        {   
            //Calcula el promedio del puntaje de una reseña
            return acumulador / contador;
        }
        public (string, string, string) buscarDatosBodegaRegionPais()
        {   
            //obtiene los datos de la bodega, region y del pais, nombre de la bodega, nombre de la region, nombre del pais
            string nombreBodega = bodega.getNombre;
            (string nombreRegion, string nombrePais) = this.bodega.buscarRegionPais();
            return (nombreBodega, nombreRegion, nombrePais);
        }

        public string[] buscarVarietal()
        {
            //recorre los varietales de un vino y devuelve el nombre de cada uno en un arreglo
            List<string> varietales = new List<string>();
            
            //CREANDO ITERADOR DE VARIETALES
            iteradorVarietales = (IteradorVarietales) crearIterador(this.varietales);

            iteradorVarietales.primero();

            while (iteradorVarietales.hasTerminado() == false)
            {
                iteradorVarietales.hasTerminado();
                Varietal vartietalActual = (Varietal)iteradorVarietales.actual();

                varietales.Add(vartietalActual.getDescripcion);
                iteradorVarietales.siguiente();
            }
           
            return varietales.ToArray();
            
        }
    }
}
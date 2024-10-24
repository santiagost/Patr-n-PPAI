using System.Text;

namespace BonVino.Entidad
{
    public class Vino
    {
        private string nombre;
        private float precioARS;
        private int añada;
        private string imagenEtiqueta;
        private float notaDeCataBodega;
        private Bodega bodega;
        private List<Varietal> varietales;
        public List<Reseña> reseñas;

        public Vino(string nombre, float precioARS, int añada, string imagenEtiqueta, float notaDeCata, Bodega bodega, List<Varietal> varietales, List<Reseña> reseñas)
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


        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }

        public float getPrecioARS { get { return precioARS; } }
        public float setPrecioARS { set { precioARS = value; } }
        public int getAñada { get { return añada; } }
        public int setAñada { set { añada = value; } }
        public Bodega getBodega { get { return bodega; } }
        public Bodega setBodega { set { bodega = value; } }
        public List<Reseña> getReseña { get { return reseñas; } }
        public List<Varietal> getVarietales { get { return varietales; } }

        public float calcularPromedioReseñasEnPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {   
            // calcula y devuelve el promedio de puntajes de las reseñas de un vino
            int cont = 0;
            float acum = 0;
            foreach (Reseña reseña in reseñas)
            {   
                if (reseña.estaEnPeriodo(fechaDesde, fechaHasta))
                {
                    cont++;
                    acum += reseña.getPuntaje;
                }
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

        public List<string> buscarVarietal()
        {   
            //recorre los varietales de un vino y devuelve el nombre de cada uno en un arreglo
            List<string> varietales = [];
            foreach (Varietal variteal in this.varietales)
            {
                varietales.Add(variteal.getDescripcion);
            }
            return varietales;
        }
        override
        public String ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(nombre)
                .Append(",")
                .Append(precioARS)
                .Append(",")
                .Append(añada);
            return stringBuilder.ToString();
        }
    }
}

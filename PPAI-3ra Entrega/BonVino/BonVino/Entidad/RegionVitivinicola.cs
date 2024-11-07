using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidad
{
    public class RegionVitivinicola
    {
        [JsonProperty("nombre")]
        private string nombre;
        [JsonProperty("descripcion")]
        private string descripcion;
        [JsonProperty("provincia")]
        private Provincia provincia;

        public RegionVitivinicola(string nombre, string descripcion, Provincia provincia)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.provincia = provincia;
        }
        
        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }
        public string getDescripcion { get { return descripcion; } }
        public string setDescripcion { set { descripcion = value; } }
        public Provincia getProvincia {  get { return provincia; } }

        public string buscarPais()
        {
            return provincia.buscarPais();
        }
        
    }
}

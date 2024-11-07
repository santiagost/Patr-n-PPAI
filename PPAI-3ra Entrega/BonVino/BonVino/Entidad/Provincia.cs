using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidad
{
    public class Provincia
    {
        [JsonProperty("nombre")]
        private string nombre;
        //private List<RegionVitivinicola> regionesVitivinicolas;
        [JsonProperty("pais")]
        private Pais pais;
        public Provincia (string nombre, Pais pais) //List<RegionVitivinicola> regionesVitivinicolas)
        {
            this.nombre = nombre;
            //this.regionesVitivinicolas = regionesVitivinicolas;
            this.pais = pais;
        }

        public string getNombre { get { return nombre; } }
        public string setNombre {  set { nombre = value; } }
        public Pais getPais { get { return pais; } }

        public string buscarPais()
        {
            return pais.getNombre;
        }
        //public List<RegionVitivinicola> getRegionesVitivinicolas { get { return regionesVitivinicolas; } }   
    }
}

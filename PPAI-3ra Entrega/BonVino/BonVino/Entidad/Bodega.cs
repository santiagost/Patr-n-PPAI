using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidad
{
    public class Bodega
    {
        private string descripcion;
        private string nombre;
        private string periodoActualizacion;
        private RegionVitivinicola regionVitivinicola;

        public Bodega(string nombre,string descripcion,string periodoActualizacion, RegionVitivinicola regionVitivinicola)
        {
            
            this.descripcion = descripcion;
            //this.historia = historia;
            this.nombre = nombre;
            this.periodoActualizacion = periodoActualizacion;
            this.regionVitivinicola = regionVitivinicola;
        }
        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }

        public string getDescripcion { get { return descripcion; } }
        public string setDescripcion { set { descripcion = value; } }
        public string getPeriodoActualizacion { get { return periodoActualizacion; } }
        public string setPeriodoActualizacion { set { periodoActualizacion = value; } }

        public RegionVitivinicola getRegionVitivinicola { get { return regionVitivinicola; } }

        public (string, string) buscarRegionPais()
        {
            string nombreRegion = regionVitivinicola.getNombre;
            string nombrePais = regionVitivinicola.buscarPais();
            return (nombreRegion, nombrePais);
        }
    }
}

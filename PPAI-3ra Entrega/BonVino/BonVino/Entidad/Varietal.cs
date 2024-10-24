using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidad
{
    public class Varietal
    {
        private string descripcion;
        private int porcentajeComposicion;

        public Varietal(string descripcion, int porcentajeComposicion)
        {
            this.descripcion = descripcion;
            this.porcentajeComposicion = porcentajeComposicion;
        }

        public string getDescripcion { get { return descripcion; } }

        public string setDescripcion { set { descripcion = value; } }
        public int getPorcentajeComposicion { get {return porcentajeComposicion; } }
        public int setPorcentajeComposicion { set { porcentajeComposicion = value; } }
    }
}

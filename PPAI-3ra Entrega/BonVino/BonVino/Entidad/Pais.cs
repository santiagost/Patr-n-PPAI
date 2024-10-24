using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidad
{
    public class Pais
    {
        private string nombre;
        //private List<Provincia> provincias;

        public Pais (string nombre)//List<Provincia> provincias)
        {
            this.nombre = nombre;
            //this.provincias = provincias;
        }

        public string getNombre { get { return nombre; } }
        public string setNombre { set { nombre = value; } }
        //public List<Provincia> getProvincias { get { return provincias; } }
    }
}

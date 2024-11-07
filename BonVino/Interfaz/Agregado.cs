using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Interfaz
{
    public interface Agregado
    {
        public Iterador crearIterador(object[] elementos);
    }
}

using BonVino.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidad
{
    internal class IteradorVinos : Iterador
    {
        public int posicion;
        public Vino[] vinos;
        public IteradorVinos(Object[] elementos)
        {
            vinos = elementos.Cast<Vino>().ToArray();
        }
        public void primero()
        {
            posicion = 0;
        }

        public void siguiente()
        {
            posicion++;
        }
        public bool hasTerminado()
        {
            return posicion >= vinos.Length;
        }
        public Object actual()
        {
            if (posicion < vinos.Length)
            {
                return vinos[posicion];
            }
            return null;
        }
    }
}

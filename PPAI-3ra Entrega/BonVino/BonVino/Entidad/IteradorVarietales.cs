using BonVino.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidad
{
    internal class IteradorVarietales : Iterador
    {
        private int posicion;
        private Varietal[] varietales;

        public IteradorVarietales(Object[] elementos)
        {
            varietales = elementos.Cast<Varietal>().ToArray();
        }
        public void primero()
        {
            posicion = 0;
        }
        public void siguiente()
        {
            posicion++;
        }
        public object actual()
        {
            if (posicion < varietales.Length)
            {
                return varietales[posicion];
            }
            return null;
        }
        public bool hasTerminado()
        {
            return posicion >= varietales.Length;
        }

        public bool cumpleFiltros(string[] filtros)
        {
            throw new NotImplementedException();
        }
    }
}

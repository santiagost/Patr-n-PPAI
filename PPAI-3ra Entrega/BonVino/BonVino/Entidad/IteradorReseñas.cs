using BonVino.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidad
{
    internal class IteradorReseñas : Iterador
    {
        private int posicion;
        private Reseña[] reseñas;
        private string[] filtros;

        public IteradorReseñas(Object[] elementos)//, string[] filtros)
        {
            this.reseñas = elementos.Cast<Reseña>().ToArray();
            this.filtros = Array.Empty<string>();
        }

        public void setFiltros(string[] filtros)
        {
            this.filtros = filtros;
        }
        public void getFiltros()
        {
            for (int i = 0; i < this.filtros.Length; i++) {
                MessageBox.Show(filtros[i]); 
         } }

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
            if (posicion < reseñas.Length)
            {
                if (this.cumpleFiltros(this.filtros))
                    return reseñas[posicion];
            }
            return null;
        }
        public bool hasTerminado()
        {
            return posicion >= reseñas.Length; 
        }
        public bool cumpleFiltros(string[] filtros)
        {
            Reseña reseñaActual = reseñas[posicion];
            bool cumpleSommelier = false;
            bool cumplePeriodo = false;

            if (filtros[0] == "De Somelier")
            {
                cumpleSommelier = reseñaActual.sosDeSomelier();
            }
            DateTime fechaDesde = DateTime.Parse(filtros[1]);
            DateTime fechaHasta = DateTime.Parse(filtros[2]);

            cumplePeriodo = reseñaActual.estaEnPeriodo(fechaDesde, fechaHasta);

            return cumplePeriodo && cumpleSommelier;
        }
    }
}

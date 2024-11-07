using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Interfaz
{
    public interface Iterador
    {
        public void primero();
        public void siguiente();
        public object actual();
        public bool hasTerminado();
        public bool cumpleFiltros(String[] filtros);
    }
}

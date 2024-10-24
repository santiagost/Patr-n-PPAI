using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonVino.Entidad
{
    public class Reseña
    {
        private string comentario;
        private bool esPremium;
        private DateTime fechaReseña;
        private int puntaje;

        public Reseña(DateTime fechaReseña, int puntaje, string comentario, bool esPremiun)
        {
            this.comentario = comentario;
            this.esPremium = esPremiun;
            this.fechaReseña = fechaReseña;
            this.puntaje = puntaje;
        }

        //metodos set y get
        public string getComentario { get { return comentario; } }
        public string setComentario { set { comentario = value; } }
        public bool getEsPremium { get { return esPremium; } }
        public bool setEsPremiun { set { esPremium = value; } }
        public int getPuntaje { get {return puntaje;} }
        public int setPuntaje { set { puntaje = value; } }

        public bool estaEnPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {   
            return this.fechaReseña >= fechaDesde && this.fechaReseña <= fechaHasta;
        }
        public bool sosDeSomelier()
        {
            return this.getEsPremium;   
        }
    }
}

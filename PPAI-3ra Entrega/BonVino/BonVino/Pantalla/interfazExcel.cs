using BonVino.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonVino.Pantalla
{
    public partial class InterfazExcel : Form
    {
        public InterfazExcel()
        {
            InitializeComponent();
            listaRanking.AllowUserToAddRows = false;
        }

        public void exportarExcel(List<(string, float, string, string, string, float, string[])> datosAExportar)
        {
            float cont = 1;
            foreach ((string, float, string, string, string, float, string[]) datosVinos in datosAExportar)
            {
                (string nombre, float precioARS, string nombreBodega, string nombreRegion, string nombrePais, float promedioPuntaje, string[] listaVarietales) = datosVinos;
                string varietales = string.Join(",", listaVarietales);
                listaRanking.Rows.Add(cont++, nombre, precioARS, nombreBodega, nombreRegion, nombrePais, promedioPuntaje, varietales);
            }
       
            this.Show();
        }
        private void InterfazExcel_Load(object sender, EventArgs e)
        {

        }
    }
}

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
        }

        public void exportarExcel(List<(string, float, string, string, string, float, List<string>)> datosAExportar)
        {
            float cont = 0;
            foreach ((string, float, string, string, string, float, List<string>) datosVinos in datosAExportar)
            {
                (string nombre, float precioARS, string nombreBodega, string nombreRegion, string nombrePais, float promedioPuntaje, List<string> listaVarietales) = datosVinos;
                string varietales = string.Join(",", listaVarietales);
                listaRanking.Rows.Add(nombre, precioARS, nombreBodega, nombreRegion, nombrePais, promedioPuntaje, varietales);
            }
            this.Show();
        }
        private void InterfazExcel_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_tarea_1
{
    public partial class Ejerciciotarea1 : Form
    {
        public Ejerciciotarea1()
        {
            InitializeComponent();
        }

        private void Calcularbutton1_Click(object sender, EventArgs e)
        {
            int numero;
            numero = int.Parse(IngresoBox1.Text);

            if ( numero % 2 == 0)
            {
                ResultadoBox1.Text = "El numero " + numero  + " es par";
            }
            else
            {
                ResultadoBox1.Text = "El numero " + numero  + " es impar";
            }
        }

        private void Vaciarbutton1_Click(object sender, EventArgs e)
        {
            IngresoBox1.Clear();
            ResultadoBox1.Clear();
        }
    }
}

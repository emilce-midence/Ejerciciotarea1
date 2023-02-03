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

        private void Mostrarbutton1_Click(object sender, EventArgs e)
        {
            int Numero;

            Numero = int.Parse(IngresoBox1.Text);
            int Modulo = Numero % 2;

            if (Numero ==0)
            {
                string Cero = " El numero es 0 ";
                MessageBox.Show(Cero);
            }

            if (Modulo == 0)
            {
                string Par = "Par";
                MessageBox.Show(Par);
            }
            else
            {
                string Impar = "Impar";
                MessageBox.Show(Impar);
            }

            if (Numero > 0)
            {
                string Positivo = "Positivo";
                MessageBox.Show(Positivo);
            }
            else
            {
                string Negativo = "Negativo";
                MessageBox.Show(Negativo);
            }
        }

        private void Borrarbutton1_Click(object sender, EventArgs e)
        {

        }
    }
}

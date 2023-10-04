using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoFinal_AAE
{
    public partial class BusquedaBinaria : Form
    {
        public BusquedaBinaria()
        {
            InitializeComponent();
        }
        public static void selectSort(IEnumerable<int> listDesor, ListBox listBoxSalida)
        {
            
            var list = listDesor.ToArray();
            var minIndice = 0;
            var minValorEncontrado = 0;

            for (int princIndice = 0; princIndice < list.Length; princIndice++)
            {
                minIndice = princIndice;
                for (int restoIndice = princIndice + 1; restoIndice < list.Length; restoIndice++)
                {
                    if (list[restoIndice] < list[minIndice])
                        minIndice = restoIndice;
                }

                minValorEncontrado = list[minIndice];
                list[minIndice] = list[princIndice];
                list[princIndice] = minValorEncontrado;
                listBoxSalida.Items.Add(list[princIndice]);

            }
        }

        static int busquedaBinariaWhile(List<int> lista, int numero)
        {
            int izquierda = 0, derecha = lista.Count - 1;

            while (izquierda <= derecha)
            {
                int indiceCentral = Convert.ToInt32(Math.Floor(Convert.ToDouble(izquierda + derecha) / 2));
                int valorCentral = lista[indiceCentral];
                if (valorCentral == numero)
                {
                    return indiceCentral;
                }
                if (numero < valorCentral)
                {
                    derecha = indiceCentral - 1;
                }
                else
                {
                    izquierda = indiceCentral + 1;
                }
            }
            return -1;
        }

        private void BusquedaBinaria_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = null;
            listBoxListado.Items.Clear();
            lblIndice.Text = null;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            listBoxListado.Items.Clear();

            for (int i = 0; i < 20; i++)
            {
                list.Add(rnd.Next(1, 100));
            }
            
            selectSort(list.Distinct(), listBoxListado);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            int numero = int.Parse(txtNumero.Text);
            
            foreach(var i in listBoxListado.Items)
            {
                list.Add((int)i);
            }

            int izquierda = 0, derecha = list.Count;

            int indice = busquedaBinariaWhile(list, numero);

            if (indice == -1)
                lblIndice.Text = "No existe";
            else
                lblIndice.Text = "Indice: " + indice;

        }
    }
}

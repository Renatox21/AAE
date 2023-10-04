using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_AAE
{
    public partial class BusquedaLineal : Form
    {
        public BusquedaLineal()
        {
            InitializeComponent();
        }
        
        static int buscar(List<string> lista, int n, string x)
        {
            for (int i = 0; i < n; i++)
            {
                if (lista[i].ToUpper().Equals(x.ToUpper()))
                    return i;                
            }
            return -1;
        }
        
        private void txtPalabra_TextChanged(object sender, EventArgs e)
        {

        }

        List<string> lista = new List<string>();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text;
            lista.Add(palabra);

            txtPalabra.Text = null;
            listBoxListado.Items.Clear();

            foreach (string s in lista)
            {
                listBoxListado.Items.Add(s);
            }            

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text;

            int result = buscar(lista, lista.Count, palabra);

            if (result == -1)
                lblPosicion.Text = "No se encontro la palabra";
            else
                lblPosicion.Text = "Palabra en el indice: " + result;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lista = new List<string>();
            txtPalabra.Text = null;
            listBoxListado.Items.Clear();
            lblPosicion.Text= null;
        }

        private void BusquedaLineal_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }
    }
}

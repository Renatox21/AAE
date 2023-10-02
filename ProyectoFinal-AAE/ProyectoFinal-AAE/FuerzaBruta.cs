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
    public partial class FuerzaBruta : Form
    {
        public FuerzaBruta()
        {
            InitializeComponent();
        }
        // Lista para almacenar los números ingresados
        private List<int> numeros = new List<int>();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            // Validamos si el contenido de la caja de texto es un número válido
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                // Agregamos el número a la lista y al RichTextBox
                numeros.Add(numero);
                richTextBox1.AppendText(numero.ToString() + Environment.NewLine);

                // Limpiamos la caja de texto
                txtNumero.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Filtramos los números primos de la lista
            List<int> primos = numeros.Where(EsPrimo).ToList();

            // Mostramos los números primos en el TextBox de resultado
            txtResultado.Text = "Los números primos son: " + string.Join(", ", primos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiamos el RichTextBox, la lista y el TextBox de resultado
            richTextBox1.Clear();
            numeros.Clear();
            txtResultado.Clear();
        }

        private void FuerzaBruta_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }
    }
}

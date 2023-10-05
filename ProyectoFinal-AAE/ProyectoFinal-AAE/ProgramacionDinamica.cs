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
   
    public partial class ProgramacionDinamica : Form
    {
        private List<int> pesosContenedores = new List<int>();
        public ProgramacionDinamica()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPesoContenedor.Text, out int peso))
            {
                pesosContenedores.Add(peso);
                ActualizarListaContenedores();
                txtPesoContenedor.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un peso válido (número entero).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (pesosContenedores.Count > 0)
            {
                // Llama a tu función de Programación Dinámica aquí y obtén el resultado.
                // Supongamos que la función se llama CalcularSeleccionOptima.
                var resultado = CalcularSeleccionOptima(pesosContenedores, 700);

                // Muestra el resultado en el componente adecuado (Label o TextBox).
                txtResultado.Text = "Selección óptima: " + string.Join(", ", resultado);
            }
            else
            {
                MessageBox.Show("Agregue al menos un contenedor antes de calcular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ActualizarListaContenedores()
        {
            // Actualiza el ListBox o DataGridView con la lista de contenedores y pesos.
            // Supongamos que tienes un ListBox llamado lstContenedores.
            lstContenedores.Items.Clear();
            foreach (var peso in pesosContenedores)
            {
                lstContenedores.Items.Add("Contenedor: " + peso + " Ton");
            }
        }

        // Función para calcular la selección óptima de contenedores utilizando Programación Dinámica.
        private List<int> CalcularSeleccionOptima(List<int> pesos, int capacidad)
        {
            int n = pesos.Count; // Número de contenedores.
            int[,] dp = new int[n + 1, capacidad + 1]; // Matriz para almacenar resultados intermedios.

            // Llenar la matriz dp usando Programación Dinámica.
            for (int i = 0; i <= n; i++)
            {
                for (int w = 0; w <= capacidad; w++)
                {
                    if (i == 0 || w == 0)
                    {
                        dp[i, w] = 0; // Inicializar valores base.
                    }
                    else if (pesos[i - 1] <= w)
                    {
                        // Comparar dos casos: incluir el i-ésimo contenedor o no.
                        dp[i, w] = Math.Max(pesos[i - 1] + dp[i - 1, w - pesos[i - 1]], dp[i - 1, w]);
                    }
                    else
                    {
                        dp[i, w] = dp[i - 1, w]; // No se puede incluir el i-ésimo contenedor.
                    }
                }
            }

            List<int> seleccionOptima = new List<int>(); // Almacenar la selección óptima.
            int j = capacidad;
            for (int i = n; i > 0 && j > 0; i--)
            {
                if (dp[i, j] != dp[i - 1, j])
                {
                    // Si el valor cambia, el i-ésimo contenedor está incluido en la selección óptima.
                    seleccionOptima.Add(pesos[i - 1]);
                    j -= pesos[i - 1]; // Restar el peso del contenedor seleccionado.
                }
            }

            return seleccionOptima; // Devolver la lista de contenedores seleccionados.
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Borra la lista de contenedores y actualiza la interfaz.
            pesosContenedores.Clear();
            ActualizarListaContenedores();

            // Borra el resultado mostrado.
            txtResultado.Text = "";

            // También puedes borrar el contenido de la caja de texto de ingreso de pesos.
            txtPesoContenedor.Clear();
        }
    }
}

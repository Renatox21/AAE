using ProyectoFinal_AAE.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_AAE
{
    public partial class AlgoritmoVoraz : Form
    {
        public AlgoritmoVoraz()
        {
            InitializeComponent();
        }

        private void AlgoritmoVoraz_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int monto = int.Parse(txtMonto.Text);
            foreach (var d in Contabilidad.DesglosarDinero(monto))
            {
                listBoxSalida.Items.Add(d);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMonto.Text = null;
            listBoxSalida.Items.Clear();
        }
    }
}

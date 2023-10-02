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
    public partial class Form1 : Form
    {
        Form recursividad = new Recursividad();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recursividad.MdiParent = this;
        }

        private void recursividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recursividad.Show();
            // hijo2.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

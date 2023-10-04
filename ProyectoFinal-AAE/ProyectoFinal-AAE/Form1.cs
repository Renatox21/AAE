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
        Form fuerzaBruta = new FuerzaBruta();
        Form paralelo_Con_Hilos = new Paralelo_Con_Hilos();
        Form backtracking = new Backtracking();
        Form algoritmoVoraz = new AlgoritmoVoraz();
        Form busquedaLineal = new BusquedaLineal();
        Form busquedaBinaria = new BusquedaBinaria();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recursividad.MdiParent = this;
            fuerzaBruta.MdiParent = this;
            paralelo_Con_Hilos.MdiParent = this;
            backtracking.MdiParent = this;
            algoritmoVoraz.MdiParent = this;
            busquedaLineal.MdiParent = this;
            busquedaBinaria.MdiParent = this;
        }

        private void recursividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recursividad.Hide();
            fuerzaBruta.Show();
            paralelo_Con_Hilos.Hide();
            backtracking.Hide();
            algoritmoVoraz.Hide();
            busquedaLineal.Hide();
            busquedaBinaria.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recursividad.Hide();
            fuerzaBruta.Hide();
            paralelo_Con_Hilos.Hide();
            backtracking.Hide();
            algoritmoVoraz.Show();
            busquedaLineal.Hide();
            busquedaBinaria.Hide();
        }

        private void formulario11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recursividad.Hide();
            fuerzaBruta.Hide();
            paralelo_Con_Hilos.Show();
            backtracking.Hide();
            algoritmoVoraz.Hide();
            busquedaLineal.Hide();
            busquedaBinaria.Hide();
        }

        private void formulario7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recursividad.Hide();
            fuerzaBruta.Hide();
            paralelo_Con_Hilos.Hide();
            backtracking.Show();
            algoritmoVoraz.Hide();
            busquedaLineal.Hide();
            busquedaBinaria.Hide();
        }

        private void forToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void formulario4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recursividad.Show();
            fuerzaBruta.Hide();
            paralelo_Con_Hilos.Hide();
            backtracking.Hide();
            algoritmoVoraz.Hide();
            busquedaLineal.Hide();
            busquedaBinaria.Hide();
        }

        private void busquedaLinealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recursividad.Hide();
            fuerzaBruta.Hide();
            paralelo_Con_Hilos.Hide();
            backtracking.Hide();
            algoritmoVoraz.Hide();
            busquedaLineal.Show();
            busquedaBinaria.Hide();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recursividad.Hide();
            fuerzaBruta.Hide();
            paralelo_Con_Hilos.Hide();
            backtracking.Hide();
            algoritmoVoraz.Hide();
            busquedaLineal.Hide();
            busquedaBinaria.Show();
        }
    }
}

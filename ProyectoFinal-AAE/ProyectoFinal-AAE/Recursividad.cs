using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoFinal_AAE.Recursividad;

namespace ProyectoFinal_AAE
{
    public partial class Recursividad : Form
    {
        public Recursividad()
        {
            InitializeComponent();
        }

        public class Libro
        {
            public String name { get; set; }
            public int page { get; set; }
        }

        private void Recursividad_Load(object sender, EventArgs e)
        {

        }

        private void Recursividad_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        static int CalcularTotalPaginas(List<int> pagina, int indice)
        {

            if (indice == pagina.Count)
                return 0;

            int paginasRestantes = CalcularTotalPaginas(pagina, indice + 1);

            return pagina[indice] + paginasRestantes;
        }

        List<Libro> lista = new List<Libro>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            listBoxSalida.Items.Clear();
            List<int> num = new List<int>();
            Libro libro = new Libro();
            
            libro.name = txtNameLibro.Text;
            libro.page = int.Parse(txtNroPagina.Text);

            lista.Add(libro);

            foreach(var l in lista) 
            {
                num.Add(l.page);
                listBoxSalida.Items.Add("El libro " + l.name + " tiene " + l.page + " paginas");
            }

            listBoxSalida.Items.Add("--------------------------------");
            listBoxSalida.Items.Add("El total de paginas es:" + CalcularTotalPaginas(num, 0));
            

            txtNameLibro.Text = null;
            txtNroPagina.Text = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNameLibro.Text = null;
            txtNroPagina.Text = null;
            listBoxSalida.Items.Clear();
        }
    }
}

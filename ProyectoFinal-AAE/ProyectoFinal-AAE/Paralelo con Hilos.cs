using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_AAE
{
    public partial class Paralelo_Con_Hilos : Form
    {
        Thread p1;
        Thread p2;
        Random random = new Random();
        void Generar01()
        {

            for (int i = 0; i < 20; i++)
            {
                var numero1 = random.Next(1, 100);
                label1.Text = ("" + numero1);
                Thread.Sleep(500);
                listBox1.Items.Add(numero1);
                label1.Update();
            }
        }
        void Generar02()
        {

            for (int i = 0; i < 20; i++)
            {
                var numero2 = random.Next(1, 100);
                label2.Text = ("" + numero2);
                Thread.Sleep(500);
                listBox2.Items.Add(numero2);
                label2.Update();
            }
        }
        public Paralelo_Con_Hilos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1 = new Thread(new ThreadStart(Generar01));
            p1.Start();
            p2 = new Thread(new ThreadStart(Generar02));
            p2.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Paralelo_Con_Hilos_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }
    }
}

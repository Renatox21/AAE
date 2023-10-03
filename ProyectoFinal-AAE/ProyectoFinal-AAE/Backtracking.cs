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
    public partial class Backtracking : Form
    {
        public Backtracking()
        {
            InitializeComponent();
        }
        class Permutar
        {
            public string[] GenerateFor(string s)
            {
                if (s.Length == 1)
                {
                    return new[] { s };
                }
                else if (s.Length == 2)
                {
                    return new[] { s[1].ToString() + s[0].ToString(), s[0].ToString() + s[1].ToString() };
                }

                var combinaciones = new List<string>();
                foreach (var c in s)
                {
                    string cStr = c.ToString();
                    var sToProcess = s.Replace(cStr, "");
                    if (!string.IsNullOrEmpty(sToProcess) && sToProcess.Length > 0)
                    {
                        var conCatenarStr = GenerateFor(sToProcess);
                        foreach (var a in conCatenarStr)
                        {
                            combinaciones.Add(c.ToString() + a);
                        }
                    }
                }
                return combinaciones.ToArray();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string palabra = textBox1.Text;
            var permutacion = new Permutar().GenerateFor(palabra);
            listBox1.Items.Clear();
            foreach (var perm in permutacion)
            {
                listBox1.Items.Add(perm);
            }
            textBox2.Text = permutacion.Length.ToString();
        }

        private void Backtracking_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DU_Znova_CS
{
    public partial class Form2 : Form
    {
        Form f;
        Random r = new Random();
        int[] pole1;
        public Form2(Form f1)
        {
            InitializeComponent();
            f = f1;
            this.FormClosing += fFormClosing;
        }

        private void fFormClosing(Object sender, FormClosingEventArgs e)
        {
            f.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            int[] pole = new int[n];
            pole1 = new int[n];

            for (int i = 0; i<n;i++)
            {
                pole[i] = r.Next(101);
            }
            Array.Sort(pole);
            listBox1.Items.Clear();
            foreach(int i in pole)
            {
                listBox1.Items.Add(i);
            }
            pole1 = pole;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = 0;
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            for (int i = 0; i<pole1.Length; i++)
            {
                if (pole1[i]<(int)numericUpDown2.Value)
                {
                    b = i+1;
                }
                else
                    i = pole1.Length;
            }
            foreach (int i in pole1.Take(b).ToArray())
            {
                listBox2.Items.Add(i);
            }
            foreach (int i in pole1.Skip(b+1).ToArray())
            {
                listBox3.Items.Add(i);
            }
        }
    }
}

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
    public partial class Form3 : Form
    {
        Form f;
        bool prvni = true;
        public Form3(Form f1)
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
            int[] pole = new int[textBox1.Lines.Length];
            bool preskocit = false;

            int n = 0;
            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                try
                {
                    int.Parse(textBox1.Lines[i]);
                }
                catch
                {
                    i = textBox1.Lines.Length;
                    preskocit = true;
                    MessageBox.Show("Špatně zadaná čísla", "Error");
                }
            }
            if (!preskocit)
            {
                for (int i = 0; i < textBox1.Lines.Length; i++)
                {
                    if (textBox1.Lines[i] == "0")
                    {
                        i = textBox1.Lines.Length;
                    }
                    else
                    {
                        n = i;
                        pole[i] = int.Parse(textBox1.Lines[i]);
                    }
                }
                try
                {
                    label1.Text = ((double)pole[0] / pole[n]).ToString();
                }
                catch
                {
                    MessageBox.Show("Špatně zadaná čísla", "Error");
                }
            listBox1.Items.Clear();
                foreach (int i in pole)
                {
                    listBox1.Items.Add(i + " na pozici " + (listBox1.Items.Count + 1));
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (prvni)
                textBox1.Text = "";
        }
    }
}

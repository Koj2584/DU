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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form2(this);
            form.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form3(this);
            form.Show();
            Visible = false;
        }
    }
}

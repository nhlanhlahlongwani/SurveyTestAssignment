using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 sw = new Form2();
            sw.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 sw = new Form3();
            sw.Show();

        }
    }
}

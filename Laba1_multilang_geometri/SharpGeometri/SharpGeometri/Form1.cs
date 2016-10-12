using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpGeometri
{
    public partial class Form1 : Form
    {
        public float side;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            side = float.Parse(textBox2.Text.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            VBLibrary.BasicO obj = new VBLibrary.BasicO();
            textBox1.AppendText(Environment.NewLine+ "Об'єм куба = "+obj.Volume(side).ToString()+" одиниць.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassLibrary1.GetSqrt obj2 = new ClassLibrary1.GetSqrt();
            textBox1.AppendText(Environment.NewLine+"Площа куба = " + obj2.Volume(side,1).ToString() + " одиниць.");
        }
    }
}

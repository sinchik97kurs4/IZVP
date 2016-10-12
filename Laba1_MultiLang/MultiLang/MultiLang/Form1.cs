using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLang
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassLibrary1.HelloVB vb = new ClassLibrary1.HelloVB();
            СPlusPlus.Class1 cpp = new СPlusPlus.Class1();
            

           textBox1.AppendText(vb.line+ Environment.NewLine);
           textBox1.AppendText(cpp.line+ Environment.NewLine);
            textBox1.AppendText("Hello from C# =)");

           
        }
    }
    public class HelloSC
    {
        public string line = "Hello from CSHARP!";
    }
}

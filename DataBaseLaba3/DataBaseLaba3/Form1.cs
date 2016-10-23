using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace DataBaseLaba3
{
    public partial class Form1 : Form
    {
        public Autorization parent;
        string username;
       MySqlConnection connetion = new MySqlConnection("server=127.0.0.1;user id=root;database=game");

        public Form1(string name,Autorization form)
        {
            parent = form;
            username = name;
            InitializeComponent();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConnetcBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connetion.Open();
            label1.Text = "Welcom, "+ username+" =)";
            ConnectionLabel.Text = "Database is connected";
        
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace DataBaseLaba3
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
       MySqlConnection connetion = new MySqlConnection("server=127.0.0.1;user id=root;database=RPG_DB");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConnetcBtn_Click(object sender, EventArgs e)
        {
            if (isConnected == false)
            {
                isConnected = true;
                ConnectionLabel.Text = "Database is connected";
                ConnetcBtn.Text = "Disconnect";
                connetion.Open();
            }
            else
            {
                isConnected = false;
                ConnectionLabel.Text = "Database is disconnected";
                ConnetcBtn.Text = "Connect";
                connetion.Close();

            }
        }
    }
}

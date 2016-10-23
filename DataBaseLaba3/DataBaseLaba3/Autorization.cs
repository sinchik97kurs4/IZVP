using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseLaba3
{
    public partial class Autorization : Form
    {
        string login, ex_login, pass, ex_pass;

        private void Autorization_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        bool IsAllowed =false;


        public Autorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connetion = new MySqlConnection("server=127.0.0.1;user id=root;database=game");
            connetion.Open();

            MySqlCommand query = connetion.CreateCommand();
            
            query.CommandText = " SELECT* FROM `user` WHERE `login` LIKE " + "'" + textBox1.Text + "'" +" AND `password` LIKE " + "'" + maskedTextBox1.Text + "'" ;
            MySqlDataReader data = query.ExecuteReader();


            while (data.Read())
            {
                ex_login = data["login"].ToString();
                ex_pass = data["password"].ToString();
            }

            if (textBox1.Text == ex_login)
            {
                if (maskedTextBox1.Text == ex_pass) IsAllowed = true;
            }
            if (data["privilege"].ToString() == "admin")
            {
                Form1 adminform = new Form1(data["login"].ToString(), this);
                adminform.Show();
                this.Hide();
            }
            else
            {
                // Здесь могла быть ваша реклама...
                User userform = new User(data["login"].ToString(),this);
                
                userform.Show();
                this.Hide();

                //Все гаражи проданы...
            }
              



        }

    }
}

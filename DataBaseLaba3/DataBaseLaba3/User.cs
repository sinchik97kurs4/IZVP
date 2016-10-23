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
    public partial class User : Form
    {
        public string user_name;
        public Autorization parent;
        public User()
        {
            InitializeComponent();
        }

        public User(string user,Autorization form)
        {
            user_name = user;
            parent = form;
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}

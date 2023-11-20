using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            //MessageBox.Show("You have entered right username and password");

            this.Hide();
            Dashboard ds = new Dashboard();
            ds.Show();
            //if (username == "admin" && password == "1234")
            //{
                
            //}
            //else
            //{
            //    MessageBox.Show("Wrong username and password");
            //}
        }
    }
}

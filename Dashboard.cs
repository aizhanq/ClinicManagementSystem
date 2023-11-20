using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            labelIndecator1.ForeColor = Color.Red;
            labelIndecator2.ForeColor = Color.Black;
            labelIndecator3.ForeColor = Color.Black;
            labelIndecator4.ForeColor = Color.Black;

            panel1.Visible = true;

        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            labelIndecator1.ForeColor = Color.Black;
            labelIndecator2.ForeColor = Color.Red;
            labelIndecator3.ForeColor = Color.Black;
            labelIndecator4.ForeColor = Color.Black;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            labelIndecator1.ForeColor = Color.Black;
            labelIndecator2.ForeColor = Color.Black;
            labelIndecator3.ForeColor = Color.Red;
            labelIndecator4.ForeColor = Color.Black;
        }

        private void btnClinic_Click(object sender, EventArgs e)
        {
            labelIndecator1.ForeColor = Color.Black;
            labelIndecator2.ForeColor = Color.Black;
            labelIndecator3.ForeColor = Color.Black;
            labelIndecator4.ForeColor = Color.Red;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var address = txtAddress.Text;
            var contact = Convert.ToInt64(txtContact.Text);
            var age = Convert.ToInt32(txtAge.Text);
            var gender = comboGender.Text;
            var blood = txtBlood.Text;
            var disease = txtDisease.Text;
            var pid = Convert.ToInt32(txtPid.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = USER-PC\\SQLEXPRESS; database = ClinicDb; integrated security = True;";
        }
    }
}

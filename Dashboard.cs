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
            try
            {
                String name = txtName.Text;
                String address = txtAddress.Text;
                Int64 contact = Convert.ToInt64(txtContact.Text);
                int age = Convert.ToInt32(txtAge.Text);
                String gender = comboGender.Text;
                String blood = txtBlood.Text;
                String disease = txtDisease.Text;
                int pid = Convert.ToInt32(txtPid.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=ClinicDb;Integrated Security=True;Pooling=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into AddPatient values ('" + name + "','" + address + "'," + contact + "," + age + ",'" + gender + "','" + blood + "','" + disease + "'," + pid + ")";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

            MessageBox.Show("Data Saved!");
            
            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtAge.Clear();
            comboGender.ResetText();
            txtBlood.Clear();
            txtDisease.Clear();
            txtPid.Clear();

        }
    }
}

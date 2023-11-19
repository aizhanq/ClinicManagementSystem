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
    }
}

namespace ClinicManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnAddDiagnosis = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnClinic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelIndecator1 = new System.Windows.Forms.Label();
            this.labelIndecator4 = new System.Windows.Forms.Label();
            this.labelIndecator3 = new System.Windows.Forms.Label();
            this.labelIndecator2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.txtDisease = new System.Windows.Forms.TextBox();
            this.txtBlood = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(429, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clinic Management System";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPatient.Location = new System.Drawing.Point(55, 266);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(187, 40);
            this.btnAddPatient.TabIndex = 1;
            this.btnAddPatient.Text = "Add New Patient Record";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnAddDiagnosis
            // 
            this.btnAddDiagnosis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDiagnosis.Location = new System.Drawing.Point(55, 312);
            this.btnAddDiagnosis.Name = "btnAddDiagnosis";
            this.btnAddDiagnosis.Size = new System.Drawing.Size(187, 40);
            this.btnAddDiagnosis.TabIndex = 2;
            this.btnAddDiagnosis.Text = "Add Diagnosis Information";
            this.btnAddDiagnosis.UseVisualStyleBackColor = false;
            this.btnAddDiagnosis.Click += new System.EventHandler(this.btnAddDiagnosis_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHistory.Location = new System.Drawing.Point(55, 358);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(187, 40);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "Full History of the Patient";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnClinic
            // 
            this.btnClinic.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClinic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClinic.Location = new System.Drawing.Point(55, 404);
            this.btnClinic.Name = "btnClinic";
            this.btnClinic.Size = new System.Drawing.Size(187, 40);
            this.btnClinic.TabIndex = 4;
            this.btnClinic.Text = "Clinic Information";
            this.btnClinic.UseVisualStyleBackColor = false;
            this.btnClinic.Click += new System.EventHandler(this.btnClinic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Philosopher", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(102, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "MENU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(255, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(757, 527);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(91, 504);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // labelIndecator1
            // 
            this.labelIndecator1.AutoSize = true;
            this.labelIndecator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIndecator1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelIndecator1.Location = new System.Drawing.Point(21, 266);
            this.labelIndecator1.Name = "labelIndecator1";
            this.labelIndecator1.Size = new System.Drawing.Size(37, 39);
            this.labelIndecator1.TabIndex = 9;
            this.labelIndecator1.Text = "»";
            // 
            // labelIndecator4
            // 
            this.labelIndecator4.AutoSize = true;
            this.labelIndecator4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIndecator4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelIndecator4.Location = new System.Drawing.Point(21, 405);
            this.labelIndecator4.Name = "labelIndecator4";
            this.labelIndecator4.Size = new System.Drawing.Size(37, 39);
            this.labelIndecator4.TabIndex = 10;
            this.labelIndecator4.Text = "»";
            // 
            // labelIndecator3
            // 
            this.labelIndecator3.AutoSize = true;
            this.labelIndecator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIndecator3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelIndecator3.Location = new System.Drawing.Point(21, 358);
            this.labelIndecator3.Name = "labelIndecator3";
            this.labelIndecator3.Size = new System.Drawing.Size(37, 39);
            this.labelIndecator3.TabIndex = 11;
            this.labelIndecator3.Text = "»";
            // 
            // labelIndecator2
            // 
            this.labelIndecator2.AutoSize = true;
            this.labelIndecator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIndecator2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelIndecator2.Location = new System.Drawing.Point(21, 313);
            this.labelIndecator2.Name = "labelIndecator2";
            this.labelIndecator2.Size = new System.Drawing.Size(37, 39);
            this.labelIndecator2.TabIndex = 12;
            this.labelIndecator2.Text = "»";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboGender);
            this.panel1.Controls.Add(this.txtPid);
            this.panel1.Controls.Add(this.txtDisease);
            this.panel1.Controls.Add(this.txtBlood);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(255, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 527);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(69, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // comboGender
            // 
            this.comboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Location = new System.Drawing.Point(200, 261);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(466, 28);
            this.comboGender.TabIndex = 7;
            // 
            // txtPid
            // 
            this.txtPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPid.Location = new System.Drawing.Point(69, 443);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(500, 26);
            this.txtPid.TabIndex = 6;
            // 
            // txtDisease
            // 
            this.txtDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDisease.Location = new System.Drawing.Point(69, 383);
            this.txtDisease.Name = "txtDisease";
            this.txtDisease.Size = new System.Drawing.Size(597, 26);
            this.txtDisease.TabIndex = 5;
            // 
            // txtBlood
            // 
            this.txtBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBlood.Location = new System.Drawing.Point(200, 304);
            this.txtBlood.Name = "txtBlood";
            this.txtBlood.Size = new System.Drawing.Size(466, 26);
            this.txtBlood.TabIndex = 4;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContact.Location = new System.Drawing.Point(200, 176);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(466, 26);
            this.txtContact.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAge.Location = new System.Drawing.Point(200, 219);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(466, 26);
            this.txtAge.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.Location = new System.Drawing.Point(200, 133);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(466, 26);
            this.txtAddress.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(200, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(466, 26);
            this.txtName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(587, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 26);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(69, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(69, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(69, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(69, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(69, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Blood Croup";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(65, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Any Major Disease Suffered Earlier";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(65, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Patient Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(195, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(268, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Add New Patient Record";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClinic);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnAddDiagnosis);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.labelIndecator1);
            this.Controls.Add(this.labelIndecator2);
            this.Controls.Add(this.labelIndecator3);
            this.Controls.Add(this.labelIndecator4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Management System";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnAddDiagnosis;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnClinic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelIndecator1;
        private System.Windows.Forms.Label labelIndecator4;
        private System.Windows.Forms.Label labelIndecator3;
        private System.Windows.Forms.Label labelIndecator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.TextBox txtDisease;
        private System.Windows.Forms.TextBox txtBlood;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
    }
}
namespace CustomerDataEntry
{
    partial class frmCustomerDataEntry
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.chkSports = new System.Windows.Forms.CheckBox();
            this.rdoMarried = new System.Windows.Forms.RadioButton();
            this.rdoUnmarried = new System.Windows.Forms.RadioButton();
            this.groupboxGender = new System.Windows.Forms.GroupBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtgCustomers = new System.Windows.Forms.DataGridView();
            this.groupboxGender.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(26, 30);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(29, 60);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Country";
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Location = new System.Drawing.Point(29, 188);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(46, 13);
            this.lblHobbies.TabIndex = 3;
            this.lblHobbies.Text = "Hobbies";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(115, 30);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(121, 20);
            this.txtCustomerName.TabIndex = 5;
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "India",
            "UK",
            "USA",
            "Russia",
            "Africa",
            "China",
            "Japan",
            "Australia"});
            this.cboCountry.Location = new System.Drawing.Point(115, 60);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(121, 21);
            this.cboCountry.TabIndex = 6;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(65, 19);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 7;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(65, 42);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 8;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // chkReading
            // 
            this.chkReading.AutoSize = true;
            this.chkReading.Location = new System.Drawing.Point(118, 188);
            this.chkReading.Name = "chkReading";
            this.chkReading.Size = new System.Drawing.Size(66, 17);
            this.chkReading.TabIndex = 9;
            this.chkReading.Text = "Reading";
            this.chkReading.UseVisualStyleBackColor = true;
            // 
            // chkSports
            // 
            this.chkSports.AutoSize = true;
            this.chkSports.Location = new System.Drawing.Point(200, 188);
            this.chkSports.Name = "chkSports";
            this.chkSports.Size = new System.Drawing.Size(56, 17);
            this.chkSports.TabIndex = 10;
            this.chkSports.Text = "Sports";
            this.chkSports.UseVisualStyleBackColor = true;
            // 
            // rdoMarried
            // 
            this.rdoMarried.AutoSize = true;
            this.rdoMarried.Location = new System.Drawing.Point(17, 19);
            this.rdoMarried.Name = "rdoMarried";
            this.rdoMarried.Size = new System.Drawing.Size(60, 17);
            this.rdoMarried.TabIndex = 11;
            this.rdoMarried.TabStop = true;
            this.rdoMarried.Text = "Married";
            this.rdoMarried.UseVisualStyleBackColor = true;
            // 
            // rdoUnmarried
            // 
            this.rdoUnmarried.AutoSize = true;
            this.rdoUnmarried.Location = new System.Drawing.Point(17, 42);
            this.rdoUnmarried.Name = "rdoUnmarried";
            this.rdoUnmarried.Size = new System.Drawing.Size(73, 17);
            this.rdoUnmarried.TabIndex = 12;
            this.rdoUnmarried.TabStop = true;
            this.rdoUnmarried.Text = "Unmarried";
            this.rdoUnmarried.UseVisualStyleBackColor = true;
            // 
            // groupboxGender
            // 
            this.groupboxGender.Controls.Add(this.rdoMale);
            this.groupboxGender.Controls.Add(this.rdoFemale);
            this.groupboxGender.Location = new System.Drawing.Point(32, 87);
            this.groupboxGender.Name = "groupboxGender";
            this.groupboxGender.Size = new System.Drawing.Size(200, 78);
            this.groupboxGender.TabIndex = 13;
            this.groupboxGender.TabStop = false;
            this.groupboxGender.Text = "Gender";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.rdoMarried);
            this.groupBoxStatus.Controls.Add(this.rdoUnmarried);
            this.groupBoxStatus.Location = new System.Drawing.Point(32, 211);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(200, 85);
            this.groupBoxStatus.TabIndex = 14;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(118, 303);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 303);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtgCustomers
            // 
            this.dtgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomers.Location = new System.Drawing.Point(284, 30);
            this.dtgCustomers.Name = "dtgCustomers";
            this.dtgCustomers.Size = new System.Drawing.Size(391, 266);
            this.dtgCustomers.TabIndex = 18;
            this.dtgCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomers_CellClick);
            this.dtgCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomers_CellContentClick);
            // 
            // frmCustomerDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 355);
            this.Controls.Add(this.dtgCustomers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupboxGender);
            this.Controls.Add(this.chkSports);
            this.Controls.Add(this.chkReading);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "frmCustomerDataEntry";
            this.Text = "Customer Data Entry";
            this.Load += new System.EventHandler(this.frmCustomerDataEntry_Load);
            this.groupboxGender.ResumeLayout(false);
            this.groupboxGender.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.CheckBox chkSports;
        private System.Windows.Forms.RadioButton rdoMarried;
        private System.Windows.Forms.RadioButton rdoUnmarried;
        private System.Windows.Forms.GroupBox groupboxGender;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dtgCustomers;
    }
}


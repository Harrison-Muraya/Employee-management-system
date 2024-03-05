namespace Employee_management_System
{
    partial class Salaries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salaries));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Periodtb = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DaysAttd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Employee = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.SEmployee = new System.Windows.Forms.Label();
            this.SalaryList = new System.Windows.Forms.DataGridView();
            this.Amountb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(566, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
            // 
            // Updatebtn
            // 
            this.Updatebtn.FlatAppearance.BorderSize = 3;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Updatebtn.ForeColor = System.Drawing.Color.Teal;
            this.Updatebtn.Location = new System.Drawing.Point(175, 701);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(112, 42);
            this.Updatebtn.TabIndex = 34;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            this.Addbtn.FlatAppearance.BorderSize = 3;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Addbtn.ForeColor = System.Drawing.Color.Teal;
            this.Addbtn.Location = new System.Drawing.Point(47, 701);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(112, 42);
            this.Addbtn.TabIndex = 33;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 118);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Periodtb
            // 
            this.Periodtb.CalendarForeColor = System.Drawing.Color.Teal;
            this.Periodtb.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.Periodtb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Periodtb.Location = new System.Drawing.Point(45, 393);
            this.Periodtb.MaxDate = new System.DateTime(2024, 2, 23, 23, 59, 59, 0);
            this.Periodtb.Name = "Periodtb";
            this.Periodtb.Size = new System.Drawing.Size(238, 22);
            this.Periodtb.TabIndex = 31;
            this.Periodtb.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.Periodtb.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 762);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1281, 43);
            this.panel2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(37, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Period";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(39, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Salary Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(43, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Days Attended";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(43, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Employee ";
            // 
            // DaysAttd
            // 
            this.DaysAttd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DaysAttd.ForeColor = System.Drawing.Color.Teal;
            this.DaysAttd.Location = new System.Drawing.Point(49, 322);
            this.DaysAttd.Name = "DaysAttd";
            this.DaysAttd.Size = new System.Drawing.Size(238, 27);
            this.DaysAttd.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(636, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Manage Employees";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 105);
            this.panel1.TabIndex = 15;
            // 
            // Employee
            // 
            this.Employee.FormattingEnabled = true;
            this.Employee.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Rather Not To Say"});
            this.Employee.Location = new System.Drawing.Point(49, 261);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(238, 24);
            this.Employee.TabIndex = 29;
            this.Employee.SelectionChangeCommitted += new System.EventHandler(this.Employee_SelectionChangeCommitted);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(580, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 63);
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(338, 113);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 63);
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(852, 113);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 63);
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1045, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 63);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Logout.ForeColor = System.Drawing.Color.Teal;
            this.Logout.Location = new System.Drawing.Point(1115, 135);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(87, 29);
            this.Logout.TabIndex = 37;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(935, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 38;
            this.label5.Text = "Salary";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Department.ForeColor = System.Drawing.Color.Teal;
            this.Department.Location = new System.Drawing.Point(650, 135);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(150, 29);
            this.Department.TabIndex = 39;
            this.Department.Text = "Departments";
            this.Department.Click += new System.EventHandler(this.Department_Click);
            // 
            // SEmployee
            // 
            this.SEmployee.AutoSize = true;
            this.SEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SEmployee.ForeColor = System.Drawing.Color.Teal;
            this.SEmployee.Location = new System.Drawing.Point(408, 135);
            this.SEmployee.Name = "SEmployee";
            this.SEmployee.Size = new System.Drawing.Size(136, 29);
            this.SEmployee.TabIndex = 40;
            this.SEmployee.Text = "Epmployee";
            this.SEmployee.Click += new System.EventHandler(this.SEmployee_Click);
            // 
            // SalaryList
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            this.SalaryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.SalaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalaryList.Location = new System.Drawing.Point(338, 261);
            this.SalaryList.Name = "SalaryList";
            this.SalaryList.RowHeadersWidth = 51;
            this.SalaryList.RowTemplate.Height = 24;
            this.SalaryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalaryList.Size = new System.Drawing.Size(864, 470);
            this.SalaryList.TabIndex = 45;
            this.SalaryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalaryList_CellContentClick);
            // 
            // Amountb
            // 
            this.Amountb.BackColor = System.Drawing.Color.White;
            this.Amountb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Amountb.Enabled = false;
            this.Amountb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Amountb.ForeColor = System.Drawing.Color.Teal;
            this.Amountb.Location = new System.Drawing.Point(41, 466);
            this.Amountb.Name = "Amountb";
            this.Amountb.Size = new System.Drawing.Size(238, 27);
            this.Amountb.TabIndex = 18;
            this.Amountb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Amountb.TextChanged += new System.EventHandler(this.Amountb_TextChanged);
            // 
            // Salaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1281, 805);
            this.Controls.Add(this.SalaryList);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.SEmployee);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Periodtb);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Amountb);
            this.Controls.Add(this.DaysAttd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salaries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salaries";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker Periodtb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DaysAttd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Employee;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label SEmployee;
        private System.Windows.Forms.DataGridView SalaryList;
        private System.Windows.Forms.TextBox Amountb;
    }
}
namespace Employee_management_System
{
    partial class Departments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            this.DepList = new System.Windows.Forms.DataGridView();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DepNametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Employees = new System.Windows.Forms.Label();
            this.lDepart = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Label();
            this.Deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DepList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // DepList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow;
            this.DepList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DepList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepList.Location = new System.Drawing.Point(354, 273);
            this.DepList.Name = "DepList";
            this.DepList.RowHeadersWidth = 51;
            this.DepList.RowTemplate.Height = 24;
            this.DepList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepList.Size = new System.Drawing.Size(864, 470);
            this.DepList.TabIndex = 35;
            this.DepList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepList_CellContentClick);
            // 
            // Editbtn
            // 
            this.Editbtn.FlatAppearance.BorderSize = 3;
            this.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Editbtn.ForeColor = System.Drawing.Color.Teal;
            this.Editbtn.Location = new System.Drawing.Point(165, 348);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(112, 42);
            this.Editbtn.TabIndex = 34;
            this.Editbtn.Text = "Update";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.FlatAppearance.BorderSize = 3;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Addbtn.ForeColor = System.Drawing.Color.Teal;
            this.Addbtn.Location = new System.Drawing.Point(37, 348);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(112, 42);
            this.Addbtn.TabIndex = 33;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 153);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(31, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Department Name";
            // 
            // DepNametb
            // 
            this.DepNametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DepNametb.ForeColor = System.Drawing.Color.Teal;
            this.DepNametb.Location = new System.Drawing.Point(37, 273);
            this.DepNametb.Name = "DepNametb";
            this.DepNametb.Size = new System.Drawing.Size(238, 27);
            this.DepNametb.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(589, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Manage Departments";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 91);
            this.panel1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(349, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 29);
            this.label10.TabIndex = 20;
            this.label10.Text = "Department List";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1061, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 98);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(596, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 98);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(868, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 98);
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(354, 99);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(74, 98);
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // Employees
            // 
            this.Employees.AutoSize = true;
            this.Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Employees.ForeColor = System.Drawing.Color.Teal;
            this.Employees.Location = new System.Drawing.Point(434, 121);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(136, 29);
            this.Employees.TabIndex = 20;
            this.Employees.Text = "Epmployee";
            this.Employees.Click += new System.EventHandler(this.Employees_Click);
            // 
            // lDepart
            // 
            this.lDepart.AutoSize = true;
            this.lDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lDepart.ForeColor = System.Drawing.Color.Teal;
            this.lDepart.Location = new System.Drawing.Point(678, 121);
            this.lDepart.Name = "lDepart";
            this.lDepart.Size = new System.Drawing.Size(150, 29);
            this.lDepart.TabIndex = 20;
            this.lDepart.Text = "Departments";
            this.lDepart.Click += new System.EventHandler(this.lDepart_Click);
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Salary.ForeColor = System.Drawing.Color.Teal;
            this.Salary.Location = new System.Drawing.Point(950, 121);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(80, 29);
            this.Salary.TabIndex = 20;
            this.Salary.Text = "Salary";
            this.Salary.Click += new System.EventHandler(this.Salary_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.logout.ForeColor = System.Drawing.Color.Teal;
            this.logout.Location = new System.Drawing.Point(1145, 121);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(87, 29);
            this.logout.TabIndex = 20;
            this.logout.Text = "Logout";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.FlatAppearance.BorderSize = 3;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Deletebtn.ForeColor = System.Drawing.Color.Teal;
            this.Deletebtn.Location = new System.Drawing.Point(114, 431);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(112, 42);
            this.Deletebtn.TabIndex = 37;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1281, 805);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DepList);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.lDepart);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DepNametb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Departments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departments";
            ((System.ComponentModel.ISupportInitialize)(this.DepList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DepList;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DepNametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label Employees;
        private System.Windows.Forms.Label lDepart;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.Button Deletebtn;
    }
}
namespace assignment_oop
{
    partial class Find_Student_form
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
            this.gridOutput = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Present = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudentFaculty = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkPre = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOutput
            // 
            this.gridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameStudent,
            this.Faculty,
            this.Email,
            this.Phonenumber,
            this.Present});
            this.gridOutput.Enabled = false;
            this.gridOutput.Location = new System.Drawing.Point(284, 102);
            this.gridOutput.Name = "gridOutput";
            this.gridOutput.Size = new System.Drawing.Size(624, 150);
            this.gridOutput.TabIndex = 35;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 80;
            // 
            // NameStudent
            // 
            this.NameStudent.HeaderText = "Name";
            this.NameStudent.Name = "NameStudent";
            // 
            // Faculty
            // 
            this.Faculty.HeaderText = "Faculty";
            this.Faculty.Name = "Faculty";
            this.Faculty.Width = 50;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email (@hcmut.edu.vn)";
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // Phonenumber
            // 
            this.Phonenumber.HeaderText = "Phone No.";
            this.Phonenumber.Name = "Phonenumber";
            // 
            // Present
            // 
            this.Present.HeaderText = "Present";
            this.Present.Name = "Present";
            this.Present.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Present.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Present.Width = 50;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(111, 170);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(157, 20);
            this.txtPhonenumber.TabIndex = 34;
            this.txtPhonenumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhonenumber_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Phone number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "List Of Students";
            // 
            // txtStudentFaculty
            // 
            this.txtStudentFaculty.Location = new System.Drawing.Point(111, 144);
            this.txtStudentFaculty.Name = "txtStudentFaculty";
            this.txtStudentFaculty.Size = new System.Drawing.Size(157, 20);
            this.txtStudentFaculty.TabIndex = 31;
            this.txtStudentFaculty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentFaculty_KeyDown);
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(111, 118);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(157, 20);
            this.txtStudentEmail.TabIndex = 30;
            this.txtStudentEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentEmail_KeyDown);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(111, 20);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(157, 20);
            this.txtStudentID.TabIndex = 29;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            this.txtStudentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentID_KeyDown);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(111, 92);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(157, 20);
            this.txtStudentName.TabIndex = 28;
            this.txtStudentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentName_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Faculty: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Email: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Student ID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Name of Student: ";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(284, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 25);
            this.btnFind.TabIndex = 36;
            this.btnFind.Text = "Find Student";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(16, 229);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(110, 23);
            this.btnSaveChanges.TabIndex = 37;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(426, 12);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(146, 26);
            this.btnWrite.TabIndex = 38;
            this.btnWrite.Text = "Write to file";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::assignment_oop.Properties.Resources.LogoCTCT;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(667, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 64);
            this.panel1.TabIndex = 39;
            // 
            // checkPre
            // 
            this.checkPre.AutoSize = true;
            this.checkPre.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkPre.Location = new System.Drawing.Point(111, 196);
            this.checkPre.Name = "checkPre";
            this.checkPre.Size = new System.Drawing.Size(15, 14);
            this.checkPre.TabIndex = 40;
            this.checkPre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkPre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Present";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(141, 229);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(127, 23);
            this.btnDel.TabIndex = 42;
            this.btnDel.Text = "Delete student";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Find_Student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 264);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkPre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.gridOutput);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStudentFaculty);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "Find_Student_form";
            this.Text = "Find_Student_form";
            this.Load += new System.EventHandler(this.Find_Student_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOutput;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudentFaculty;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkPre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phonenumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Present;
        private System.Windows.Forms.Button btnDel;
    }
}
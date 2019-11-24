namespace assignment_oop
{
    partial class Insert_Student_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertStudent = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentFaculty = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbSession = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.gridOutput = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Present = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWrite2File = new System.Windows.Forms.Button();
            this.checkPre = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Session: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name of Student: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student ID: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Faculty: ";
            // 
            // btnInsertStudent
            // 
            this.btnInsertStudent.Location = new System.Drawing.Point(156, 214);
            this.btnInsertStudent.Name = "btnInsertStudent";
            this.btnInsertStudent.Size = new System.Drawing.Size(112, 35);
            this.btnInsertStudent.TabIndex = 11;
            this.btnInsertStudent.Text = "Insert";
            this.btnInsertStudent.UseVisualStyleBackColor = true;
            this.btnInsertStudent.Click += new System.EventHandler(this.btnInsertStudent_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(111, 84);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(157, 20);
            this.txtStudentName.TabIndex = 13;
            this.txtStudentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentName_KeyDown);
            this.txtStudentName.Validating += new System.ComponentModel.CancelEventHandler(this.txtStudentName_Validating);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(111, 58);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(157, 20);
            this.txtStudentID.TabIndex = 12;
            this.txtStudentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentID_KeyDown);
            this.txtStudentID.Validating += new System.ComponentModel.CancelEventHandler(this.txtStudentID_Validating);
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(111, 110);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(157, 20);
            this.txtStudentEmail.TabIndex = 14;
            this.txtStudentEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentEmail_KeyDown);
            this.txtStudentEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtStudentEmail_Validating);
            // 
            // txtStudentFaculty
            // 
            this.txtStudentFaculty.Location = new System.Drawing.Point(111, 136);
            this.txtStudentFaculty.Name = "txtStudentFaculty";
            this.txtStudentFaculty.Size = new System.Drawing.Size(157, 20);
            this.txtStudentFaculty.TabIndex = 15;
            this.txtStudentFaculty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentFaculty_KeyDown);
            this.txtStudentFaculty.Validating += new System.ComponentModel.CancelEventHandler(this.txtStudentFaculty_Validating);
            // 
            // tbSubject
            // 
            this.tbSubject.Enabled = false;
            this.tbSubject.Location = new System.Drawing.Point(95, 21);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(52, 20);
            this.tbSubject.TabIndex = 16;
            // 
            // tbSession
            // 
            this.tbSession.Enabled = false;
            this.tbSession.Location = new System.Drawing.Point(200, 21);
            this.tbSession.Name = "tbSession";
            this.tbSession.Size = new System.Drawing.Size(97, 20);
            this.tbSession.TabIndex = 17;
            // 
            // tbDate
            // 
            this.tbDate.Enabled = false;
            this.tbDate.Location = new System.Drawing.Point(342, 22);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(93, 20);
            this.tbDate.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "List Of Students";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Phone number";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(111, 162);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(157, 20);
            this.txtPhonenumber.TabIndex = 22;
            this.txtPhonenumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhonenumber_KeyDown);
            this.txtPhonenumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhonenumber_Validating);
            // 
            // gridOutput
            // 
            this.gridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameStudent,
            this.Email,
            this.Faculty,
            this.Phonenumber,
            this.Present});
            this.gridOutput.Enabled = false;
            this.gridOutput.Location = new System.Drawing.Point(284, 99);
            this.gridOutput.Name = "gridOutput";
            this.gridOutput.Size = new System.Drawing.Size(623, 150);
            this.gridOutput.TabIndex = 23;
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
            // Email
            // 
            this.Email.HeaderText = "Email (@hcmut.edu.vn)";
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // Faculty
            // 
            this.Faculty.HeaderText = "Faculty";
            this.Faculty.Name = "Faculty";
            this.Faculty.Width = 50;
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
            this.Present.Width = 50;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::assignment_oop.Properties.Resources.LogoCTCT;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(646, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 60);
            this.panel1.TabIndex = 24;
            // 
            // btnWrite2File
            // 
            this.btnWrite2File.Location = new System.Drawing.Point(26, 214);
            this.btnWrite2File.Name = "btnWrite2File";
            this.btnWrite2File.Size = new System.Drawing.Size(103, 35);
            this.btnWrite2File.TabIndex = 25;
            this.btnWrite2File.Text = "Write to file";
            this.btnWrite2File.UseVisualStyleBackColor = true;
            this.btnWrite2File.Click += new System.EventHandler(this.btnWrite2File_Click);
            // 
            // checkPre
            // 
            this.checkPre.AutoSize = true;
            this.checkPre.Location = new System.Drawing.Point(111, 194);
            this.checkPre.Name = "checkPre";
            this.checkPre.Size = new System.Drawing.Size(15, 14);
            this.checkPre.TabIndex = 26;
            this.checkPre.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Present";
            // 
            // Insert_Student_form
            // 
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 272);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkPre);
            this.Controls.Add(this.btnWrite2File);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridOutput);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbSession);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.txtStudentFaculty);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.btnInsertStudent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Insert_Student_form";
            this.Text = "Insert_Student";
            this.Load += new System.EventHandler(this.Insert_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsertStudent;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentFaculty;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbSession;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.DataGridView gridOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWrite2File;
        private System.Windows.Forms.CheckBox checkPre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phonenumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Present;
    }
}
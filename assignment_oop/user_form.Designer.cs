namespace assignment_oop
{
    partial class user_form
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
            this.bt_Logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Subject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Class = new System.Windows.Forms.ComboBox();
            this.lb_Student = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_Logout
            // 
            this.bt_Logout.Location = new System.Drawing.Point(12, 12);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Size = new System.Drawing.Size(57, 24);
            this.bt_Logout.TabIndex = 0;
            this.bt_Logout.Text = "Log out";
            this.bt_Logout.UseVisualStyleBackColor = true;
            this.bt_Logout.Click += new System.EventHandler(this.Bt_Logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject";
            // 
            // cb_Subject
            // 
            this.cb_Subject.FormattingEnabled = true;
            this.cb_Subject.Location = new System.Drawing.Point(71, 45);
            this.cb_Subject.Name = "cb_Subject";
            this.cb_Subject.Size = new System.Drawing.Size(125, 21);
            this.cb_Subject.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class";
            // 
            // cb_Class
            // 
            this.cb_Class.FormattingEnabled = true;
            this.cb_Class.Location = new System.Drawing.Point(284, 45);
            this.cb_Class.Name = "cb_Class";
            this.cb_Class.Size = new System.Drawing.Size(144, 21);
            this.cb_Class.TabIndex = 4;
            // 
            // lb_Student
            // 
            this.lb_Student.FormattingEnabled = true;
            this.lb_Student.Location = new System.Drawing.Point(12, 81);
            this.lb_Student.Name = "lb_Student";
            this.lb_Student.Size = new System.Drawing.Size(550, 121);
            this.lb_Student.TabIndex = 5;
            // 
            // user_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 270);
            this.Controls.Add(this.lb_Student);
            this.Controls.Add(this.cb_Class);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Logout);
            this.Name = "user_form";
            this.Text = "user_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frame_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Class;
        private System.Windows.Forms.ListBox lb_Student;
    }
}
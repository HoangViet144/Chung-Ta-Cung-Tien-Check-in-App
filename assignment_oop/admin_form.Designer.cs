namespace assignment_oop
{
    partial class admin_form
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
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.btnModifyStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Logout
            // 
            this.bt_Logout.Location = new System.Drawing.Point(15, 13);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Size = new System.Drawing.Size(75, 25);
            this.bt_Logout.TabIndex = 0;
            this.bt_Logout.Text = "Log out";
            this.bt_Logout.UseVisualStyleBackColor = true;
            this.bt_Logout.Click += new System.EventHandler(this.Bt_Logout_Click);
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.Location = new System.Drawing.Point(39, 90);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(118, 45);
            this.btnCreateClass.TabIndex = 1;
            this.btnCreateClass.Text = "Create Class";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Location = new System.Drawing.Point(229, 90);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(118, 45);
            this.btnFindStudent.TabIndex = 2;
            this.btnFindStudent.Text = "Find Student";
            this.btnFindStudent.UseVisualStyleBackColor = true;
            // 
            // btnModifyStudent
            // 
            this.btnModifyStudent.Location = new System.Drawing.Point(422, 90);
            this.btnModifyStudent.Name = "btnModifyStudent";
            this.btnModifyStudent.Size = new System.Drawing.Size(118, 45);
            this.btnModifyStudent.TabIndex = 3;
            this.btnModifyStudent.Text = "Modify Student";
            this.btnModifyStudent.UseVisualStyleBackColor = true;
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 255);
            this.Controls.Add(this.btnModifyStudent);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.btnCreateClass);
            this.Controls.Add(this.bt_Logout);
            this.Name = "admin_form";
            this.Text = "admin_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frame_FormClosing);
            this.Load += new System.EventHandler(this.Admin_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.Button btnCreateClass;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.Button btnModifyStudent;
    }
}
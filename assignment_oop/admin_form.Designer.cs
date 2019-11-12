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
            this.btnModifyStu = new System.Windows.Forms.Button();
            this.btnImportFile = new System.Windows.Forms.Button();
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
            this.btnCreateClass.Location = new System.Drawing.Point(32, 44);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(118, 45);
            this.btnCreateClass.TabIndex = 1;
            this.btnCreateClass.Text = "Create Class";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            this.btnCreateClass.Click += new System.EventHandler(this.btnCreateClass_Click);
            // 
            // btnModifyStu
            // 
            this.btnModifyStu.Location = new System.Drawing.Point(260, 44);
            this.btnModifyStu.Name = "btnModifyStu";
            this.btnModifyStu.Size = new System.Drawing.Size(118, 45);
            this.btnModifyStu.TabIndex = 2;
            this.btnModifyStu.Text = "Modify Student";
            this.btnModifyStu.UseVisualStyleBackColor = true;
            this.btnModifyStu.Click += new System.EventHandler(this.btnModifyStu_Click);
            // 
            // btnImportFile
            // 
            this.btnImportFile.Location = new System.Drawing.Point(478, 44);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(118, 45);
            this.btnImportFile.TabIndex = 3;
            this.btnImportFile.Text = "Import File";
            this.btnImportFile.UseVisualStyleBackColor = true;
            this.btnImportFile.Click += new System.EventHandler(this.btnImportClass_Click);
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 255);
            this.Controls.Add(this.btnImportFile);
            this.Controls.Add(this.btnModifyStu);
            this.Controls.Add(this.btnCreateClass);
            this.Controls.Add(this.bt_Logout);
            this.Name = "admin_form";
            this.Text = "admin_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frame_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.Button btnCreateClass;
        private System.Windows.Forms.Button btnModifyStu;
        private System.Windows.Forms.Button btnImportFile;
    }
}
﻿namespace assignment_oop
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createClassToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.btnImportClass = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnModifyStu = new System.Windows.Forms.Button();
            this.Bt_Logout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.createClassToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // createClassToolStripMenuItem1
            // 
            this.createClassToolStripMenuItem1.Name = "createClassToolStripMenuItem1";
            this.createClassToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.createClassToolStripMenuItem1.Text = "Create class";
            this.createClassToolStripMenuItem1.Click += new System.EventHandler(this.createClassToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createClassToolStripMenuItem,
            this.modifyStudentToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // createClassToolStripMenuItem
            // 
            this.createClassToolStripMenuItem.Name = "createClassToolStripMenuItem";
            this.createClassToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createClassToolStripMenuItem.Text = "Insert student";
            this.createClassToolStripMenuItem.Click += new System.EventHandler(this.createClassToolStripMenuItem_Click);
            // 
            // modifyStudentToolStripMenuItem
            // 
            this.modifyStudentToolStripMenuItem.Name = "modifyStudentToolStripMenuItem";
            this.modifyStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyStudentToolStripMenuItem.Text = "Modify student";
            this.modifyStudentToolStripMenuItem.Click += new System.EventHandler(this.modifyStudentToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.Location = new System.Drawing.Point(12, 45);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(99, 38);
            this.btnCreateClass.TabIndex = 6;
            this.btnCreateClass.Text = "Creat Class";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            this.btnCreateClass.Click += new System.EventHandler(this.btnCreateClass_Click);
            // 
            // btnImportClass
            // 
            this.btnImportClass.Location = new System.Drawing.Point(138, 45);
            this.btnImportClass.Name = "btnImportClass";
            this.btnImportClass.Size = new System.Drawing.Size(99, 38);
            this.btnImportClass.TabIndex = 7;
            this.btnImportClass.Text = "Import File";
            this.btnImportClass.UseVisualStyleBackColor = true;
            this.btnImportClass.Click += new System.EventHandler(this.btnImportClass_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(270, 45);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(99, 38);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert Student";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnModifyStu
            // 
            this.btnModifyStu.Location = new System.Drawing.Point(401, 45);
            this.btnModifyStu.Name = "btnModifyStu";
            this.btnModifyStu.Size = new System.Drawing.Size(99, 38);
            this.btnModifyStu.TabIndex = 9;
            this.btnModifyStu.Text = "Modify Student";
            this.btnModifyStu.UseVisualStyleBackColor = true;
            this.btnModifyStu.Click += new System.EventHandler(this.btnModifyStu_Click);
            // 
            // Bt_Logout
            // 
            this.Bt_Logout.Location = new System.Drawing.Point(531, 45);
            this.Bt_Logout.Name = "Bt_Logout";
            this.Bt_Logout.Size = new System.Drawing.Size(99, 38);
            this.Bt_Logout.TabIndex = 10;
            this.Bt_Logout.Text = "Log out";
            this.Bt_Logout.UseVisualStyleBackColor = true;
            this.Bt_Logout.Click += new System.EventHandler(this.Bt_Logout_Click);
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 255);
            this.Controls.Add(this.Bt_Logout);
            this.Controls.Add(this.btnModifyStu);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnImportClass);
            this.Controls.Add(this.btnCreateClass);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin_form";
            this.Text = "admin_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frame_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createClassToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnCreateClass;
        private System.Windows.Forms.Button btnImportClass;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnModifyStu;
        private System.Windows.Forms.Button Bt_Logout;
    }
}
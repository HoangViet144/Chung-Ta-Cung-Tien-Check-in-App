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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_add_Subject = new System.Windows.Forms.TextBox();
            this.bt_add_Subject = new System.Windows.Forms.Button();
            this.f = new System.Windows.Forms.Label();
            this.tb_add_Class = new System.Windows.Forms.TextBox();
            this.bt_add_Class = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Subject = new System.Windows.Forms.ComboBox();
            this.cb_Class = new System.Windows.Forms.ComboBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject";
            // 
            // tb_add_Subject
            // 
            this.tb_add_Subject.Location = new System.Drawing.Point(61, 51);
            this.tb_add_Subject.Name = "tb_add_Subject";
            this.tb_add_Subject.Size = new System.Drawing.Size(100, 20);
            this.tb_add_Subject.TabIndex = 2;
            // 
            // bt_add_Subject
            // 
            this.bt_add_Subject.Location = new System.Drawing.Point(167, 47);
            this.bt_add_Subject.Name = "bt_add_Subject";
            this.bt_add_Subject.Size = new System.Drawing.Size(84, 27);
            this.bt_add_Subject.TabIndex = 3;
            this.bt_add_Subject.Text = "Add Subject";
            this.bt_add_Subject.UseVisualStyleBackColor = true;
            this.bt_add_Subject.Click += new System.EventHandler(this.Bt_add_Subject_Click);
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(15, 84);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(32, 13);
            this.f.TabIndex = 4;
            this.f.Text = "Class";
            // 
            // tb_add_Class
            // 
            this.tb_add_Class.Location = new System.Drawing.Point(61, 81);
            this.tb_add_Class.Name = "tb_add_Class";
            this.tb_add_Class.Size = new System.Drawing.Size(100, 20);
            this.tb_add_Class.TabIndex = 5;
            // 
            // bt_add_Class
            // 
            this.bt_add_Class.Location = new System.Drawing.Point(167, 80);
            this.bt_add_Class.Name = "bt_add_Class";
            this.bt_add_Class.Size = new System.Drawing.Size(82, 27);
            this.bt_add_Class.TabIndex = 6;
            this.bt_add_Class.Text = "Add Class";
            this.bt_add_Class.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Class";
            // 
            // cb_Subject
            // 
            this.cb_Subject.FormattingEnabled = true;
            this.cb_Subject.Location = new System.Drawing.Point(311, 46);
            this.cb_Subject.Name = "cb_Subject";
            this.cb_Subject.Size = new System.Drawing.Size(160, 21);
            this.cb_Subject.TabIndex = 9;
            // 
            // cb_Class
            // 
            this.cb_Class.FormattingEnabled = true;
            this.cb_Class.Location = new System.Drawing.Point(497, 45);
            this.cb_Class.Name = "cb_Class";
            this.cb_Class.Size = new System.Drawing.Size(160, 21);
            this.cb_Class.TabIndex = 10;
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 255);
            this.Controls.Add(this.cb_Class);
            this.Controls.Add(this.cb_Subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_add_Class);
            this.Controls.Add(this.tb_add_Class);
            this.Controls.Add(this.f);
            this.Controls.Add(this.bt_add_Subject);
            this.Controls.Add(this.tb_add_Subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Logout);
            this.Name = "admin_form";
            this.Text = "admin_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frame_FormClosing);
            this.Load += new System.EventHandler(this.Admin_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_add_Subject;
        private System.Windows.Forms.Button bt_add_Subject;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.TextBox tb_add_Class;
        private System.Windows.Forms.Button bt_add_Class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Subject;
        private System.Windows.Forms.ComboBox cb_Class;
    }
}
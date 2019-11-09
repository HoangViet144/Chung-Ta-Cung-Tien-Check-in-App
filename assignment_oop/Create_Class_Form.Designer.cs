namespace assignment_oop
{
    partial class Create_Class_Form
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.datClassDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateAndInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Section";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "VL1",
            "VL2",
            "GT1",
            "GT2",
            "HDC",
            "DSTT"});
            this.comboBox1.Location = new System.Drawing.Point(122, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Sat. Morning",
            "Sat. Evening",
            "Sun. Morning",
            "Sun. Evening"});
            this.comboBox2.Location = new System.Drawing.Point(122, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // datClassDate
            // 
            this.datClassDate.Location = new System.Drawing.Point(124, 125);
            this.datClassDate.Name = "datClassDate";
            this.datClassDate.Size = new System.Drawing.Size(134, 20);
            this.datClassDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose date:";
            // 
            // btnCreateAndInsert
            // 
            this.btnCreateAndInsert.Location = new System.Drawing.Point(89, 171);
            this.btnCreateAndInsert.Name = "btnCreateAndInsert";
            this.btnCreateAndInsert.Size = new System.Drawing.Size(136, 32);
            this.btnCreateAndInsert.TabIndex = 6;
            this.btnCreateAndInsert.Text = "Create and Insert Student";
            this.btnCreateAndInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateAndInsert.UseVisualStyleBackColor = true;
            // 
            // Create_Class_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 221);
            this.Controls.Add(this.btnCreateAndInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datClassDate);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Create_Class_Form";
            this.Text = "Create_Class_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker datClassDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateAndInsert;
    }
}
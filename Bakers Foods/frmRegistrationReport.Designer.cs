namespace Bakers_Foods
{
    partial class frmRegistrationReport
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
            this.Label16 = new System.Windows.Forms.Label();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.GroupBox8 = new System.Windows.Forms.GroupBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button11 = new System.Windows.Forms.Button();
            this.Button12 = new System.Windows.Forms.Button();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.dtpOrderDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDateFrom = new System.Windows.Forms.DateTimePicker();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.GroupBox9.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(20, 18);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(135, 21);
            this.Label16.TabIndex = 9;
            this.Label16.Text = "Distributor Name";
          
            // GroupBox9
            // 
            this.GroupBox9.Controls.Add(this.cmbCustomerName);
            this.GroupBox9.Controls.Add(this.Label16);
            this.GroupBox9.Location = new System.Drawing.Point(8, 43);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new System.Drawing.Size(461, 147);
            this.GroupBox9.TabIndex = 29;
            this.GroupBox9.TabStop = false;
           
            // cmbCustomerName
            // 
            this.cmbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(24, 45);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(422, 21);
            this.cmbCustomerName.TabIndex = 25;
         
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button8.Location = new System.Drawing.Point(18, 63);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(215, 100);
            this.Button8.TabIndex = 0;
            this.Button8.Text = "&View Report";
            this.Button8.UseVisualStyleBackColor = true;
          
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button9.Location = new System.Drawing.Point(118, 63);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(215, 100);
            this.Button9.TabIndex = 1;
            this.Button9.Text = "&Reset";
            this.Button9.UseVisualStyleBackColor = true;
           
            // GroupBox8
            // 
            this.GroupBox8.Controls.Add(this.Button8);
            this.GroupBox8.Controls.Add(this.Button9);
            this.GroupBox8.Location = new System.Drawing.Point(354, 44);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new System.Drawing.Size(352, 147);
            this.GroupBox8.TabIndex = 30;
            this.GroupBox8.TabStop = false;
                       // TabPage3
            // 
            this.TabPage3.Controls.Add(this.GroupBox8);
            this.TabPage3.Controls.Add(this.GroupBox9);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(933, 605);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "By Distributor Name";
            this.TabPage3.UseVisualStyleBackColor = true;
         // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Cancelled",
            "Completed",
            "Uncompleted"});
            this.cmbStatus.Location = new System.Drawing.Point(24, 45);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(332, 21);
            this.cmbStatus.TabIndex = 25;
             // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(20, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(54, 21);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Status";
           // 
            // Button11
            // 
            this.Button11.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button11.Location = new System.Drawing.Point(18, 63);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(215, 100);
            this.Button11.TabIndex = 0;
            this.Button11.Text = "&View Report";
            this.Button11.UseVisualStyleBackColor = true;
            // 
            // Button12
            // 
            this.Button12.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button12.Location = new System.Drawing.Point(118, 63);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(215, 100);
            this.Button12.TabIndex = 1;
            this.Button12.Text = "&Reset";
            this.Button12.UseVisualStyleBackColor = true;
           // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.Button11);
            this.GroupBox5.Controls.Add(this.Button12);
            this.GroupBox5.Location = new System.Drawing.Point(279, 43);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(351, 147);
            this.GroupBox5.TabIndex = 30;
            this.GroupBox5.TabStop = false;
             // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(86, 4);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 21);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "From";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(252, 4);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(28, 21);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "To";
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.cmbStatus);
            this.GroupBox6.Controls.Add(this.Label2);
            this.GroupBox6.Location = new System.Drawing.Point(8, 43);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(386, 147);
            this.GroupBox6.TabIndex = 29;
            this.GroupBox6.TabStop = false;
          // 
            // dtpOrderDateTo
            // 
            this.dtpOrderDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpOrderDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDateTo.Location = new System.Drawing.Point(256, 28);
            this.dtpOrderDateTo.Name = "dtpOrderDateTo";
            this.dtpOrderDateTo.Size = new System.Drawing.Size(241, 20);
            this.dtpOrderDateTo.TabIndex = 107;
            // 
            // dtpOrderDateFrom
            // 
            this.dtpOrderDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpOrderDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDateFrom.Location = new System.Drawing.Point(90, 28);
            this.dtpOrderDateFrom.Name = "dtpOrderDateFrom";
            this.dtpOrderDateFrom.Size = new System.Drawing.Size(241, 20);
            this.dtpOrderDateFrom.TabIndex = 106;
          // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.dtpOrderDateTo);
            this.GroupBox1.Controls.Add(this.dtpOrderDateFrom);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Location = new System.Drawing.Point(8, 43);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(452, 147);
            this.GroupBox1.TabIndex = 22;
            this.GroupBox1.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(135, 122);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(215, 100);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "&View Report";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(235, 122);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(215, 100);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "&Reset";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Button1);
            this.GroupBox2.Controls.Add(this.Button2);
            this.GroupBox2.Location = new System.Drawing.Point(354, 44);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(350, 147);
            this.GroupBox2.TabIndex = 23;
            this.GroupBox2.TabStop = false;
           // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1054, 665);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "By Order Date";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.GroupBox5);
            this.TabPage2.Controls.Add(this.GroupBox6);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(933, 605);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "By Status";
            this.TabPage2.UseVisualStyleBackColor = true;
           // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Location = new System.Drawing.Point(-70, -53);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1062, 691);
            this.TabControl1.TabIndex = 1;
            // frmRegistrationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegistrationReport";
            this.Text = "frmRegistrationReport";
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.ComboBox cmbCustomerName;
        internal System.Windows.Forms.Button Button8;
        internal System.Windows.Forms.Button Button9;
        internal System.Windows.Forms.GroupBox GroupBox8;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.ComboBox cmbStatus;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button11;
        internal System.Windows.Forms.Button Button12;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.DateTimePicker dtpOrderDateTo;
        internal System.Windows.Forms.DateTimePicker dtpOrderDateFrom;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TabControl TabControl1;
    }
}
namespace Bakers_Foods
{
    partial class frmSalesReport
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
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Label12 = new System.Windows.Forms.Label();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.GroupBox7 = new System.Windows.Forms.GroupBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.dtpInvoiceDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpInvoiceDateFrom = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.GroupBox6.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CustomFormat = "dd/MMM/yyyy";
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker1.Location = new System.Drawing.Point(190, 42);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.DateTimePicker1.TabIndex = 107;
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.CustomFormat = "dd/MMM/yyyy";
            this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker2.Location = new System.Drawing.Point(24, 42);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(120, 20);
            this.DateTimePicker2.TabIndex = 106;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(20, 18);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(47, 21);
            this.Label12.TabIndex = 9;
            this.Label12.Text = "From";
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.DateTimePicker1);
            this.GroupBox6.Controls.Add(this.DateTimePicker2);
            this.GroupBox6.Controls.Add(this.Label12);
            this.GroupBox6.Controls.Add(this.Label13);
            this.GroupBox6.Location = new System.Drawing.Point(8, 6);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(331, 87);
            this.GroupBox6.TabIndex = 21;
            this.GroupBox6.TabStop = false;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(186, 18);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(28, 21);
            this.Label13.TabIndex = 10;
            this.Label13.Text = "To";
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.Location = new System.Drawing.Point(18, 26);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(94, 40);
            this.Button5.TabIndex = 0;
            this.Button5.Text = "&View Report";
            this.Button5.UseVisualStyleBackColor = true;
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.Location = new System.Drawing.Point(118, 26);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(94, 40);
            this.Button7.TabIndex = 1;
            this.Button7.Text = "&Reset";
            this.Button7.UseVisualStyleBackColor = true;
            // 
            // GroupBox7
            // 
            this.GroupBox7.Controls.Add(this.Button5);
            this.GroupBox7.Controls.Add(this.Button7);
            this.GroupBox7.Location = new System.Drawing.Point(356, 6);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new System.Drawing.Size(227, 87);
            this.GroupBox7.TabIndex = 22;
            this.GroupBox7.TabStop = false;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.GroupBox7);
            this.TabPage3.Controls.Add(this.GroupBox6);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(958, 625);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "By Payment Due";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(24, 45);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(301, 21);
            this.cmbCustomerName.TabIndex = 25;
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
            // 
            // GroupBox9
            // 
            this.GroupBox9.Controls.Add(this.cmbCustomerName);
            this.GroupBox9.Controls.Add(this.Label16);
            this.GroupBox9.Location = new System.Drawing.Point(8, 6);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new System.Drawing.Size(340, 87);
            this.GroupBox9.TabIndex = 27;
            this.GroupBox9.TabStop = false;
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(19, 27);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(94, 40);
            this.Button3.TabIndex = 0;
            this.Button3.Text = "View Report";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.Location = new System.Drawing.Point(119, 25);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(94, 40);
            this.Button4.TabIndex = 21;
            this.Button4.Text = "&Reset";
            this.Button4.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Button3);
            this.GroupBox3.Controls.Add(this.Button4);
            this.GroupBox3.Location = new System.Drawing.Point(354, 6);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(228, 87);
            this.GroupBox3.TabIndex = 29;
            this.GroupBox3.TabStop = false;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.GroupBox3);
            this.TabPage2.Controls.Add(this.GroupBox9);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(958, 625);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "By Distributor";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpInvoiceDateTo
            // 
            this.dtpInvoiceDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpInvoiceDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDateTo.Location = new System.Drawing.Point(190, 42);
            this.dtpInvoiceDateTo.Name = "dtpInvoiceDateTo";
            this.dtpInvoiceDateTo.Size = new System.Drawing.Size(120, 20);
            this.dtpInvoiceDateTo.TabIndex = 107;
            // 
            // dtpInvoiceDateFrom
            // 
            this.dtpInvoiceDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpInvoiceDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDateFrom.Location = new System.Drawing.Point(24, 42);
            this.dtpInvoiceDateFrom.Name = "dtpInvoiceDateFrom";
            this.dtpInvoiceDateFrom.Size = new System.Drawing.Size(120, 20);
            this.dtpInvoiceDateFrom.TabIndex = 106;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(20, 18);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 21);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "From";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(186, 18);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(28, 21);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "To";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.dtpInvoiceDateTo);
            this.GroupBox1.Controls.Add(this.dtpInvoiceDateFrom);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Location = new System.Drawing.Point(6, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(331, 87);
            this.GroupBox1.TabIndex = 19;
            this.GroupBox1.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(19, 27);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(94, 40);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "View Report";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.Location = new System.Drawing.Point(119, 25);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(94, 40);
            this.Button6.TabIndex = 21;
            this.Button6.Text = "&Reset";
            this.Button6.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Button1);
            this.GroupBox2.Controls.Add(this.Button6);
            this.GroupBox2.Location = new System.Drawing.Point(343, 6);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(228, 87);
            this.GroupBox2.TabIndex = 22;
            this.GroupBox2.TabStop = false;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(958, 625);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "By Invoice Date";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(966, 651);
            this.TabControl1.TabIndex = 1;
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 650);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSalesReport";
            this.Text = "frmSalesReport";
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.DateTimePicker DateTimePicker2;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.GroupBox GroupBox7;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.ComboBox cmbCustomerName;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.DateTimePicker dtpInvoiceDateTo;
        internal System.Windows.Forms.DateTimePicker dtpInvoiceDateFrom;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TabControl TabControl1;
    }
}
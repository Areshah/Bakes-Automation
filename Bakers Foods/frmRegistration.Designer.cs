namespace Bakers_Foods
{
    partial class frmRegistration
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ContactNo = new System.Windows.Forms.MaskedTextBox();
            this.UserName = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GetDetails = new System.Windows.Forms.Button();
            this.Update_record = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.NewRecord = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ContactNo);
            this.GroupBox1.Controls.Add(this.UserName);
            this.GroupBox1.Controls.Add(this.txtName);
            this.GroupBox1.Controls.Add(this.Password);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(28, 64);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(338, 202);
            this.GroupBox1.TabIndex = 52;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "User Details";
            // 
            // ContactNo
            // 
            this.ContactNo.Location = new System.Drawing.Point(126, 146);
            this.ContactNo.Mask = "0000000000";
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(99, 24);
            this.ContactNo.TabIndex = 3;
            // 
            // UserName
            // 
            this.UserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UserName.FormattingEnabled = true;
            this.UserName.Location = new System.Drawing.Point(126, 38);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(183, 25);
            this.UserName.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 24);
            this.txtName.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(126, 75);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(183, 24);
            this.Password.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(31, 149);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 18);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "Contact No.";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(31, 110);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(45, 18);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Name";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(31, 75);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 18);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Password";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(31, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 18);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "User Name";
            // 
            // GetDetails
            // 
            this.GetDetails.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDetails.Location = new System.Drawing.Point(14, 150);
            this.GetDetails.Name = "GetDetails";
            this.GetDetails.Size = new System.Drawing.Size(94, 28);
            this.GetDetails.TabIndex = 4;
            this.GetDetails.Text = "&Get Data";
            this.GetDetails.UseVisualStyleBackColor = true;
            // 
            // Update_record
            // 
            this.Update_record.Enabled = false;
            this.Update_record.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_record.Location = new System.Drawing.Point(14, 117);
            this.Update_record.Name = "Update_record";
            this.Update_record.Size = new System.Drawing.Size(94, 27);
            this.Update_record.TabIndex = 3;
            this.Update_record.Text = "&Update";
            this.Update_record.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(14, 84);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 27);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "&Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(14, 51);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 27);
            this.Save.TabIndex = 1;
            this.Save.Text = "&Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // NewRecord
            // 
            this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.Location = new System.Drawing.Point(14, 18);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(94, 27);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = true;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.LightGray;
            this.Label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(30, 26);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(139, 22);
            this.Label11.TabIndex = 54;
            this.Label11.Text = "User Registration";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GetDetails);
            this.panel1.Controls.Add(this.Update_record);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.NewRecord);
            this.panel1.Location = new System.Drawing.Point(380, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 194);
            this.panel1.TabIndex = 53;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 293);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegistration";
            this.Text = "frmRegistration";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.MaskedTextBox ContactNo;
        internal System.Windows.Forms.ComboBox UserName;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox Password;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Button GetDetails;
        public System.Windows.Forms.Button Update_record;
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Button Save;
        public System.Windows.Forms.Button NewRecord;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Panel panel1;
    }
}
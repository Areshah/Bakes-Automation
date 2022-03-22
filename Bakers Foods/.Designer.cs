namespace Bakers_Foods
{
    partial class frmProduct
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.NewRecord = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Update_Record = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbWeight = new System.Windows.Forms.ComboBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.NewRecord);
            this.Panel1.Controls.Add(this.Delete);
            this.Panel1.Controls.Add(this.Save);
            this.Panel1.Controls.Add(this.Update_Record);
            this.Panel1.Location = new System.Drawing.Point(597, 34);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(101, 164);
            this.Panel1.TabIndex = 3;
            // 
            // NewRecord
            // 
            this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.Location = new System.Drawing.Point(11, 12);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(75, 29);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(11, 121);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 29);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "&Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(11, 50);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 29);
            this.Save.TabIndex = 1;
            this.Save.Text = "&Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Update_Record
            // 
            this.Update_Record.Enabled = false;
            this.Update_Record.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Record.Location = new System.Drawing.Point(11, 86);
            this.Update_Record.Name = "Update_Record";
            this.Update_Record.Size = new System.Drawing.Size(75, 29);
            this.Update_Record.TabIndex = 2;
            this.Update_Record.Text = "&Update";
            this.Update_Record.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(143, 173);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(91, 24);
            this.txtPrice.TabIndex = 3;
            // 
            // cmbWeight
            // 
            this.cmbWeight.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbWeight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWeight.FormattingEnabled = true;
            this.cmbWeight.Location = new System.Drawing.Point(143, 134);
            this.cmbWeight.Name = "cmbWeight";
            this.cmbWeight.Size = new System.Drawing.Size(91, 25);
            this.cmbWeight.TabIndex = 2;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(341, 30);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(29, 25);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "<";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(143, 99);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(302, 25);
            this.cmbCategory.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(143, 65);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(376, 24);
            this.txtProductName.TabIndex = 0;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(143, 31);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(189, 24);
            this.txtProductCode.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(28, 99);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(59, 17);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Category";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(28, 176);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(61, 17);
            this.Label8.TabIndex = 10;
            this.Label8.Text = "Unit Price";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(28, 137);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 17);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Weight (Per Qty)";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(28, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(87, 17);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Product Name";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(28, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(83, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Product Code";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtPrice);
            this.GroupBox1.Controls.Add(this.cmbWeight);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.cmbCategory);
            this.GroupBox1.Controls.Add(this.txtProductName);
            this.GroupBox1.Controls.Add(this.txtProductCode);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(35, 25);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(544, 218);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Product Details";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 269);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Panel1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button NewRecord;
        internal System.Windows.Forms.Button Delete;
        internal System.Windows.Forms.Button Save;
        internal System.Windows.Forms.Button Update_Record;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.ComboBox cmbWeight;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.ComboBox cmbCategory;
        internal System.Windows.Forms.TextBox txtProductName;
        internal System.Windows.Forms.TextBox txtProductCode;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}
namespace Bakers_Foods
{
    partial class frmOrders
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox2.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Button1);
            this.GroupBox2.Controls.Add(this.Button2);
            this.GroupBox2.Location = new System.Drawing.Point(354, 7);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(231, 87);
            this.GroupBox2.TabIndex = 24;
            this.GroupBox2.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(18, 26);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(94, 40);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "&Get Data";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(118, 26);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(94, 40);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "&Reset";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.DateTimePicker1);
            this.GroupBox6.Controls.Add(this.DateTimePicker2);
            this.GroupBox6.Controls.Add(this.Label12);
            this.GroupBox6.Controls.Add(this.Label13);
            this.GroupBox6.Location = new System.Drawing.Point(7, 7);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(331, 87);
            this.GroupBox6.TabIndex = 25;
            this.GroupBox6.TabStop = false;
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
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(7, 100);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(649, 497);
            this.DataGridView1.TabIndex = 26;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 604);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox6);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.DateTimePicker DateTimePicker2;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.DataGridView DataGridView1;
    }
}
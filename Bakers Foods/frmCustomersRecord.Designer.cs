namespace Bakers_Foods
{
    partial class frmCustomersRecord
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.TabPage2.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1071, 669);
            this.TabControl1.TabIndex = 1;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.DataGridView1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1063, 643);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "All Records";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(8, 6);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(1055, 637);
            this.DataGridView1.TabIndex = 16;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.GroupBox2);
            this.TabPage2.Controls.Add(this.GroupBox1);
            this.TabPage2.Controls.Add(this.DataGridView2);
            this.TabPage2.Controls.Add(this.groupBox5);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1063, 643);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "By Distributor Name";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtCustomer);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Location = new System.Drawing.Point(398, 3);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(292, 87);
            this.GroupBox2.TabIndex = 19;
            this.GroupBox2.TabStop = false;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(24, 45);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(231, 20);
            this.txtCustomer.TabIndex = 7;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(21, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(125, 18);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Search Distributors";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Location = new System.Drawing.Point(696, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(123, 87);
            this.GroupBox1.TabIndex = 18;
            this.GroupBox1.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(15, 30);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(94, 40);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "&Reset";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // DataGridView2
            // 
            this.DataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Location = new System.Drawing.Point(8, 96);
            this.DataGridView2.MultiSelect = false;
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.Size = new System.Drawing.Size(1055, 547);
            this.DataGridView2.TabIndex = 17;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtName);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(8, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(379, 87);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.FormattingEnabled = true;
            this.txtName.Location = new System.Drawing.Point(24, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(328, 24);
            this.txtName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Distributor Name";
            // 
            // frmCustomersRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 669);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomersRecord";
            this.Text = "frmCustomersRecord";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtCustomer;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.DataGridView DataGridView2;
        internal System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.ComboBox txtName;
        internal System.Windows.Forms.Label label6;
    }
}
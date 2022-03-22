namespace Bakers_Foods
{
    partial class frmSalesRecord1
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
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(115, 6);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(90, 38);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "Print &DGV";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(11, 6);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(98, 38);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "&Print Report";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(0, 53);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(449, 283);
            this.DataGridView1.TabIndex = 4;
            // 
            // frmSalesRecord1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 342);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSalesRecord1";
            this.Text = "frmSalesRecord1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.DataGridView DataGridView1;
    }
}
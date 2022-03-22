namespace Bakers_Foods
{
    partial class frmInvoice
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
            this.components = new System.ComponentModel.Container();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label21 = new System.Windows.Forms.Label();
            this.cmbInvoiceNo = new System.Windows.Forms.ComboBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(133, 113);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(87, 27);
            this.Button2.TabIndex = 31;
            this.Button2.Text = "&Cancel";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(25, 113);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(87, 27);
            this.Button1.TabIndex = 30;
            this.Button1.Text = "&Show";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.Location = new System.Drawing.Point(22, 31);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(79, 18);
            this.Label21.TabIndex = 28;
            this.Label21.Text = "Invoice No.";
            // 
            // cmbInvoiceNo
            // 
            this.cmbInvoiceNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbInvoiceNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbInvoiceNo.FormattingEnabled = true;
            this.cmbInvoiceNo.Location = new System.Drawing.Point(25, 58);
            this.cmbInvoiceNo.Name = "cmbInvoiceNo";
            this.cmbInvoiceNo.Size = new System.Drawing.Size(195, 21);
            this.cmbInvoiceNo.TabIndex = 29;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 171);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.cmbInvoiceNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInvoice";
            this.Text = "frmInvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.ComboBox cmbInvoiceNo;
        internal System.Windows.Forms.Timer Timer1;
    }
}
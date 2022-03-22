namespace Bakers_Foods
{
    partial class frmPasswordRecovery
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
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(57, 38);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 15);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "(Only For Admin)";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(51, 80);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(115, 31);
            this.Button1.TabIndex = 13;
            this.Button1.Text = "Send";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // frmPasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 149);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPasswordRecovery";
            this.Text = "frmPasswordRecovery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button1;
    }
}
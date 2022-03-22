namespace Bakers_Foods
{
    partial class frmPOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtgCart = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXTITEMID = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.btnaddQty = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblvat = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.FlowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label2 = new System.Windows.Forms.Label();
            this.LBLSUBTOT = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.TXTTENDERED = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.FlowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label9 = new System.Windows.Forms.Label();
            this.LBLCHANGE = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.BTNESCAPE = new System.Windows.Forms.Button();
            this.BTNTENDER = new System.Windows.Forms.Button();
            this.Mnstrp_ShortCutMenu = new System.Windows.Forms.MenuStrip();
            this.TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VoidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TENDEREDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label1 = new System.Windows.Forms.Label();
            this.BTNADD = new System.Windows.Forms.Button();
            this.toolstrpUtype = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstrpDatetime = new System.Windows.Forms.ToolStripLabel();
            this.toolstrpAccountId = new System.Windows.Forms.ToolStripLabel();
            this.LBLUSERID = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.LBLTOTPRICE = new System.Windows.Forms.Label();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label4 = new System.Windows.Forms.Label();
            this.lbltotalsales = new System.Windows.Forms.Label();
            this.FlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label5 = new System.Windows.Forms.Label();
            this.LBLSUBTOTAL = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.LBLTRANSID = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCart)).BeginInit();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.FlowLayoutPanel4.SuspendLayout();
            this.FlowLayoutPanel3.SuspendLayout();
            this.Mnstrp_ShortCutMenu.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            this.FlowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCart
            // 
            this.dtgCart.AllowUserToAddRows = false;
            this.dtgCart.AllowUserToDeleteRows = false;
            this.dtgCart.AllowUserToResizeColumns = false;
            this.dtgCart.AllowUserToResizeRows = false;
            this.dtgCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgCart.Location = new System.Drawing.Point(8, 40);
            this.dtgCart.MultiSelect = false;
            this.dtgCart.Name = "dtgCart";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCart.Size = new System.Drawing.Size(720, 410);
            this.dtgCart.TabIndex = 36;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Barcode";
            this.Column6.Name = "Column6";
            this.Column6.Width = 72;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.Width = 56;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.Width = 71;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sub Total";
            this.Column5.Name = "Column5";
            this.Column5.Width = 78;
            // 
            // TXTITEMID
            // 
            this.TXTITEMID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TXTITEMID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TXTITEMID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTITEMID.Location = new System.Drawing.Point(102, 9);
            this.TXTITEMID.Name = "TXTITEMID";
            this.TXTITEMID.Size = new System.Drawing.Size(621, 26);
            this.TXTITEMID.TabIndex = 35;
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label16);
            this.Panel1.Controls.Add(this.Label15);
            this.Panel1.Controls.Add(this.Label14);
            this.Panel1.Controls.Add(this.Label12);
            this.Panel1.Controls.Add(this.btnaddQty);
            this.Panel1.Controls.Add(this.btnVoid);
            this.Panel1.Controls.Add(this.BTNSAVE);
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Controls.Add(this.BTNESCAPE);
            this.Panel1.Controls.Add(this.BTNTENDER);
            this.Panel1.Controls.Add(this.Mnstrp_ShortCutMenu);
            this.Panel1.Location = new System.Drawing.Point(733, 86);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(287, 377);
            this.Panel1.TabIndex = 41;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(213, 75);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(48, 13);
            this.Label16.TabIndex = 25;
            this.Label16.Text = "escape";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(158, 75);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(51, 26);
            this.Label15.TabIndex = 25;
            this.Label15.Text = "Tender \r\nAmount";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(106, 75);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(32, 13);
            this.Label14.TabIndex = 25;
            this.Label14.Text = "Void";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(41, 75);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(54, 13);
            this.Label12.TabIndex = 25;
            this.Label12.Text = "Quantity";
            // 
            // btnaddQty
            // 
            this.btnaddQty.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnaddQty.Enabled = false;
            this.btnaddQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddQty.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnaddQty.Location = new System.Drawing.Point(40, 16);
            this.btnaddQty.Name = "btnaddQty";
            this.btnaddQty.Size = new System.Drawing.Size(50, 56);
            this.btnaddQty.TabIndex = 12;
            this.btnaddQty.Text = "F3";
            this.btnaddQty.UseVisualStyleBackColor = false;
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVoid.Enabled = false;
            this.btnVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnVoid.Location = new System.Drawing.Point(96, 16);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(50, 56);
            this.btnVoid.TabIndex = 12;
            this.btnVoid.Text = "F10";
            this.btnVoid.UseVisualStyleBackColor = false;
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.Enabled = false;
            this.BTNSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSAVE.Location = new System.Drawing.Point(67, 319);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(169, 40);
            this.BTNSAVE.TabIndex = 11;
            this.BTNSAVE.Text = "Save & Print";
            this.BTNSAVE.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblvat);
            this.GroupBox1.Controls.Add(this.Label17);
            this.GroupBox1.Controls.Add(this.FlowLayoutPanel4);
            this.GroupBox1.Controls.Add(this.TXTTENDERED);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.FlowLayoutPanel3);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(9, 99);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(271, 214);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Summary";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvat.Location = new System.Drawing.Point(175, 31);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(49, 20);
            this.lblvat.TabIndex = 16;
            this.lblvat.Text = "12 %";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(127, 31);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(42, 20);
            this.Label17.TabIndex = 16;
            this.Label17.Text = "Vat :";
            // 
            // FlowLayoutPanel4
            // 
            this.FlowLayoutPanel4.Controls.Add(this.Label2);
            this.FlowLayoutPanel4.Controls.Add(this.LBLSUBTOT);
            this.FlowLayoutPanel4.Controls.Add(this.Label13);
            this.FlowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlowLayoutPanel4.Location = new System.Drawing.Point(6, 65);
            this.FlowLayoutPanel4.Name = "FlowLayoutPanel4";
            this.FlowLayoutPanel4.Size = new System.Drawing.Size(259, 29);
            this.FlowLayoutPanel4.TabIndex = 12;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(219, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(37, 17);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "GBP";
            // 
            // LBLSUBTOT
            // 
            this.LBLSUBTOT.AutoSize = true;
            this.LBLSUBTOT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LBLSUBTOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSUBTOT.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LBLSUBTOT.Location = new System.Drawing.Point(168, 0);
            this.LBLSUBTOT.Name = "LBLSUBTOT";
            this.LBLSUBTOT.Size = new System.Drawing.Size(45, 29);
            this.LBLSUBTOT.TabIndex = 7;
            this.LBLSUBTOT.Text = "0.0";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(106, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(56, 18);
            this.Label13.TabIndex = 7;
            this.Label13.Text = "Total :";
            // 
            // TXTTENDERED
            // 
            this.TXTTENDERED.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTTENDERED.Location = new System.Drawing.Point(90, 100);
            this.TXTTENDERED.Multiline = true;
            this.TXTTENDERED.Name = "TXTTENDERED";
            this.TXTTENDERED.Size = new System.Drawing.Size(175, 34);
            this.TXTTENDERED.TabIndex = 15;
            this.TXTTENDERED.Text = "0.0";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(6, 100);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(78, 34);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "Tendered\r\n Amount :";
            // 
            // FlowLayoutPanel3
            // 
            this.FlowLayoutPanel3.Controls.Add(this.Label9);
            this.FlowLayoutPanel3.Controls.Add(this.LBLCHANGE);
            this.FlowLayoutPanel3.Controls.Add(this.Label11);
            this.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlowLayoutPanel3.Location = new System.Drawing.Point(10, 173);
            this.FlowLayoutPanel3.Name = "FlowLayoutPanel3";
            this.FlowLayoutPanel3.Size = new System.Drawing.Size(255, 35);
            this.FlowLayoutPanel3.TabIndex = 11;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(216, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(36, 16);
            this.Label9.TabIndex = 9;
            this.Label9.Text = "GBP";
            // 
            // LBLCHANGE
            // 
            this.LBLCHANGE.AutoSize = true;
            this.LBLCHANGE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LBLCHANGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCHANGE.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LBLCHANGE.Location = new System.Drawing.Point(175, 0);
            this.LBLCHANGE.Name = "LBLCHANGE";
            this.LBLCHANGE.Size = new System.Drawing.Size(35, 24);
            this.LBLCHANGE.TabIndex = 7;
            this.LBLCHANGE.Text = "0.0";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(93, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(76, 20);
            this.Label11.TabIndex = 7;
            this.Label11.Text = "Change:";
            // 
            // BTNESCAPE
            // 
            this.BTNESCAPE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNESCAPE.Enabled = false;
            this.BTNESCAPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNESCAPE.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTNESCAPE.Location = new System.Drawing.Point(208, 15);
            this.BTNESCAPE.Name = "BTNESCAPE";
            this.BTNESCAPE.Size = new System.Drawing.Size(50, 56);
            this.BTNESCAPE.TabIndex = 12;
            this.BTNESCAPE.Text = "ESC";
            this.BTNESCAPE.UseVisualStyleBackColor = false;
            // 
            // BTNTENDER
            // 
            this.BTNTENDER.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNTENDER.Enabled = false;
            this.BTNTENDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTENDER.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTNTENDER.Location = new System.Drawing.Point(152, 15);
            this.BTNTENDER.Name = "BTNTENDER";
            this.BTNTENDER.Size = new System.Drawing.Size(50, 56);
            this.BTNTENDER.TabIndex = 12;
            this.BTNTENDER.Text = " F11";
            this.BTNTENDER.UseVisualStyleBackColor = false;
            // 
            // Mnstrp_ShortCutMenu
            // 
            this.Mnstrp_ShortCutMenu.AutoSize = false;
            this.Mnstrp_ShortCutMenu.BackColor = System.Drawing.Color.Transparent;
            this.Mnstrp_ShortCutMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.Mnstrp_ShortCutMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TToolStripMenuItem,
            this.VoidToolStripMenuItem,
            this.TENDEREDToolStripMenuItem,
            this.ESCToolStripMenuItem});
            this.Mnstrp_ShortCutMenu.Location = new System.Drawing.Point(57, 33);
            this.Mnstrp_ShortCutMenu.Name = "Mnstrp_ShortCutMenu";
            this.Mnstrp_ShortCutMenu.Size = new System.Drawing.Size(22, 26);
            this.Mnstrp_ShortCutMenu.TabIndex = 24;
            this.Mnstrp_ShortCutMenu.Text = "MenuStrip1";
            // 
            // TToolStripMenuItem
            // 
            this.TToolStripMenuItem.AutoSize = false;
            this.TToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TToolStripMenuItem.Name = "TToolStripMenuItem";
            this.TToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.TToolStripMenuItem.Size = new System.Drawing.Size(38, 62);
            this.TToolStripMenuItem.Text = "Qty";
            // 
            // VoidToolStripMenuItem
            // 
            this.VoidToolStripMenuItem.AutoSize = false;
            this.VoidToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.VoidToolStripMenuItem.Name = "VoidToolStripMenuItem";
            this.VoidToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.VoidToolStripMenuItem.Size = new System.Drawing.Size(43, 62);
            this.VoidToolStripMenuItem.Text = "Void";
            // 
            // TENDEREDToolStripMenuItem
            // 
            this.TENDEREDToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TENDEREDToolStripMenuItem.Name = "TENDEREDToolStripMenuItem";
            this.TENDEREDToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.TENDEREDToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.TENDEREDToolStripMenuItem.Text = "Tender Amount";
            // 
            // ESCToolStripMenuItem
            // 
            this.ESCToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ESCToolStripMenuItem.Name = "ESCToolStripMenuItem";
            this.ESCToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.ESCToolStripMenuItem.Text = "ESC";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(19, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(77, 20);
            this.Label1.TabIndex = 39;
            this.Label1.Text = "Barcode :";
            // 
            // BTNADD
            // 
            this.BTNADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNADD.Location = new System.Drawing.Point(635, 75);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(81, 26);
            this.BTNADD.TabIndex = 40;
            this.BTNADD.Text = "Add";
            this.BTNADD.UseVisualStyleBackColor = true;
            // 
            // toolstrpUtype
            // 
            this.toolstrpUtype.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstrpUtype.Image = ((System.Drawing.Image)(resources.GetObject("toolstrpUtype.Image")));
            this.toolstrpUtype.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstrpUtype.Name = "toolstrpUtype";
            this.toolstrpUtype.Size = new System.Drawing.Size(99, 22);
            this.toolstrpUtype.Text = "ToolStripButton1";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrpDatetime,
            this.toolstrpAccountId,
            this.toolstrpUtype});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 513);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1028, 25);
            this.ToolStrip1.TabIndex = 45;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // toolstrpDatetime
            // 
            this.toolstrpDatetime.Name = "toolstrpDatetime";
            this.toolstrpDatetime.Size = new System.Drawing.Size(87, 22);
            this.toolstrpDatetime.Text = "ToolStripLabel1";
            // 
            // toolstrpAccountId
            // 
            this.toolstrpAccountId.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.toolstrpAccountId.Name = "toolstrpAccountId";
            this.toolstrpAccountId.Size = new System.Drawing.Size(87, 22);
            this.toolstrpAccountId.Text = "ToolStripLabel1";
            // 
            // LBLUSERID
            // 
            this.LBLUSERID.AutoSize = true;
            this.LBLUSERID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUSERID.Location = new System.Drawing.Point(345, 292);
            this.LBLUSERID.Name = "LBLUSERID";
            this.LBLUSERID.Size = new System.Drawing.Size(19, 20);
            this.LBLUSERID.TabIndex = 44;
            this.LBLUSERID.Text = "2";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(55, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(132, 25);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Total Sales :";
            // 
            // LBLTOTPRICE
            // 
            this.LBLTOTPRICE.AutoSize = true;
            this.LBLTOTPRICE.BackColor = System.Drawing.Color.DimGray;
            this.LBLTOTPRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTOTPRICE.ForeColor = System.Drawing.Color.Cyan;
            this.LBLTOTPRICE.Location = new System.Drawing.Point(219, 25);
            this.LBLTOTPRICE.Name = "LBLTOTPRICE";
            this.LBLTOTPRICE.Size = new System.Drawing.Size(65, 37);
            this.LBLTOTPRICE.TabIndex = 7;
            this.LBLTOTPRICE.Text = "0.0";
            this.LBLTOTPRICE.Visible = false;
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.Controls.Add(this.Label4);
            this.FlowLayoutPanel1.Controls.Add(this.lbltotalsales);
            this.FlowLayoutPanel1.Controls.Add(this.Label3);
            this.FlowLayoutPanel1.Controls.Add(this.LBLTOTPRICE);
            this.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(729, 15);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(287, 29);
            this.FlowLayoutPanel1.TabIndex = 42;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(241, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(43, 20);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "GBP";
            // 
            // lbltotalsales
            // 
            this.lbltotalsales.AutoSize = true;
            this.lbltotalsales.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbltotalsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalsales.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbltotalsales.Location = new System.Drawing.Point(193, 0);
            this.lbltotalsales.Name = "lbltotalsales";
            this.lbltotalsales.Size = new System.Drawing.Size(42, 25);
            this.lbltotalsales.TabIndex = 10;
            this.lbltotalsales.Text = "0.0";
            // 
            // FlowLayoutPanel2
            // 
            this.FlowLayoutPanel2.Controls.Add(this.Label5);
            this.FlowLayoutPanel2.Controls.Add(this.LBLSUBTOTAL);
            this.FlowLayoutPanel2.Controls.Add(this.Label7);
            this.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlowLayoutPanel2.Location = new System.Drawing.Point(316, 456);
            this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            this.FlowLayoutPanel2.Size = new System.Drawing.Size(407, 28);
            this.FlowLayoutPanel2.TabIndex = 43;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(367, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(37, 17);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "GBP";
            // 
            // LBLSUBTOTAL
            // 
            this.LBLSUBTOTAL.AutoSize = true;
            this.LBLSUBTOTAL.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LBLSUBTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSUBTOTAL.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LBLSUBTOTAL.Location = new System.Drawing.Point(319, 0);
            this.LBLSUBTOTAL.Name = "LBLSUBTOTAL";
            this.LBLSUBTOTAL.Size = new System.Drawing.Size(42, 25);
            this.LBLSUBTOTAL.TabIndex = 7;
            this.LBLSUBTOTAL.Text = "0.0";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(254, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(59, 20);
            this.Label7.TabIndex = 7;
            this.Label7.Text = "Total :";
            // 
            // LBLTRANSID
            // 
            this.LBLTRANSID.AutoSize = true;
            this.LBLTRANSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTRANSID.Location = new System.Drawing.Point(885, 57);
            this.LBLTRANSID.Name = "LBLTRANSID";
            this.LBLTRANSID.Size = new System.Drawing.Size(85, 20);
            this.LBLTRANSID.TabIndex = 37;
            this.LBLTRANSID.Text = "Trans Id :";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(751, 56);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(128, 20);
            this.Label10.TabIndex = 38;
            this.Label10.Text = "Transaction # :";
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 538);
            this.Controls.Add(this.dtgCart);
            this.Controls.Add(this.TXTITEMID);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BTNADD);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.LBLUSERID);
            this.Controls.Add(this.FlowLayoutPanel1);
            this.Controls.Add(this.FlowLayoutPanel2);
            this.Controls.Add(this.LBLTRANSID);
            this.Controls.Add(this.Label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCart)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.FlowLayoutPanel4.ResumeLayout(false);
            this.FlowLayoutPanel4.PerformLayout();
            this.FlowLayoutPanel3.ResumeLayout(false);
            this.FlowLayoutPanel3.PerformLayout();
            this.Mnstrp_ShortCutMenu.ResumeLayout(false);
            this.Mnstrp_ShortCutMenu.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.FlowLayoutPanel1.PerformLayout();
            this.FlowLayoutPanel2.ResumeLayout(false);
            this.FlowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.DataGridView dtgCart;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.TextBox TXTITEMID;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Button btnaddQty;
        internal System.Windows.Forms.Button btnVoid;
        internal System.Windows.Forms.Button BTNSAVE;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblvat;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label LBLSUBTOT;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox TXTTENDERED;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel3;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label LBLCHANGE;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button BTNESCAPE;
        internal System.Windows.Forms.Button BTNTENDER;
        internal System.Windows.Forms.MenuStrip Mnstrp_ShortCutMenu;
        internal System.Windows.Forms.ToolStripMenuItem TToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem VoidToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TENDEREDToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ESCToolStripMenuItem;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button BTNADD;
        internal System.Windows.Forms.ToolStripButton toolstrpUtype;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripLabel toolstrpDatetime;
        internal System.Windows.Forms.ToolStripLabel toolstrpAccountId;
        internal System.Windows.Forms.Label LBLUSERID;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label LBLTOTPRICE;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lbltotalsales;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label LBLSUBTOTAL;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label LBLTRANSID;
        internal System.Windows.Forms.Label Label10;
    }
}
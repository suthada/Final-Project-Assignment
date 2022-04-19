namespace Final_Project_Assignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelAssess = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxAssess = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAssess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(5, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(26, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "ขื่อ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1533, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(5, 79);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(34, 20);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "ที่อยู่";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(5, 113);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(51, 20);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "ประเภท";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(5, 144);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(174, 20);
            this.labelSize.TabIndex = 4;
            this.labelSize.Text = "ขนาดพื้นที่สิ่งปลูกสร้าง(ตรม.)";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(5, 176);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(146, 20);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "ราคาประเมินสิ่งปลูกสร้าง";
            // 
            // labelAssess
            // 
            this.labelAssess.AutoSize = true;
            this.labelAssess.Location = new System.Drawing.Point(5, 209);
            this.labelAssess.Name = "labelAssess";
            this.labelAssess.Size = new System.Drawing.Size(186, 20);
            this.labelAssess.TabIndex = 6;
            this.labelAssess.Text = "คิดเป็นราคาประเมินสิ่งปลูกสร้าง";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(5, 241);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(93, 20);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "ภาษีที่ต้องชำระ";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "บ้านเดี่ยว",
            "บ้านแถว",
            "ตึกแถว",
            "ห้างสรรพสินค้า",
            "ห้องเช่า",
            "โรงแรม",
            "โรงเรือน"});
            this.comboBoxType.Location = new System.Drawing.Point(58, 110);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(264, 28);
            this.comboBoxType.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(58, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(264, 27);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(58, 79);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(264, 27);
            this.textBoxAddress.TabIndex = 10;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(189, 141);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(133, 27);
            this.textBoxSize.TabIndex = 11;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(157, 173);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(165, 27);
            this.textBoxPrice.TabIndex = 12;
            // 
            // textBoxAssess
            // 
            this.textBoxAssess.Location = new System.Drawing.Point(197, 206);
            this.textBoxAssess.Name = "textBoxAssess";
            this.textBoxAssess.Size = new System.Drawing.Size(125, 27);
            this.textBoxAssess.TabIndex = 13;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(104, 241);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(218, 27);
            this.textBoxTotal.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnAddress,
            this.ColumnType,
            this.ColumnSize,
            this.ColumnPrice,
            this.ColumnAssess,
            this.ColumnTotal});
            this.dataGridView1.Location = new System.Drawing.Point(342, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1167, 309);
            this.dataGridView1.TabIndex = 15;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "ชื่อ";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 150;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "ที่อยู่";
            this.ColumnAddress.MinimumWidth = 6;
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.Width = 150;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "ประเภท";
            this.ColumnType.MinimumWidth = 6;
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.Width = 125;
            // 
            // ColumnSize
            // 
            this.ColumnSize.HeaderText = "ขนาดพื้นที่สิ่งปลูกสร้าง(ตรม.)";
            this.ColumnSize.MinimumWidth = 6;
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.Width = 190;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "ราคาประเมินสิ่งปลูกส้ราง";
            this.ColumnPrice.MinimumWidth = 6;
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.Width = 190;
            // 
            // ColumnAssess
            // 
            this.ColumnAssess.HeaderText = "คิดเป็นราคาประเมินสิ่งปลูกสร้าง";
            this.ColumnAssess.MinimumWidth = 6;
            this.ColumnAssess.Name = "ColumnAssess";
            this.ColumnAssess.Width = 190;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "ภาษีที่ต้องชำระ";
            this.ColumnTotal.MinimumWidth = 6;
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.Width = 170;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(5, 286);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(149, 64);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "บันทึก";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(173, 286);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(149, 64);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "ลบ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 605);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxAssess);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelAssess);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelName;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Label labelAddress;
        private Label labelType;
        private Label labelSize;
        private Label labelPrice;
        private Label labelAssess;
        private Label labelTotal;
        private ComboBox comboBoxType;
        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private TextBox textBoxSize;
        private TextBox textBoxPrice;
        private TextBox textBoxAssess;
        private TextBox textBoxTotal;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewTextBoxColumn ColumnType;
        private DataGridViewTextBoxColumn ColumnSize;
        private DataGridViewTextBoxColumn ColumnPrice;
        private DataGridViewTextBoxColumn ColumnAssess;
        private DataGridViewTextBoxColumn ColumnTotal;
        private Button buttonSave;
        private Button buttonDelete;
    }
}
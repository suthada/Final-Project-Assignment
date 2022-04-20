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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
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
            this.textBoxAssess = new System.Windows.Forms.TextBox();
            this.labelAssess = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 45);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(26, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "ขื่อ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Chocolate;
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
            this.labelAddress.Location = new System.Drawing.Point(14, 82);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(34, 20);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "ที่อยู่";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(14, 124);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(51, 20);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "ประเภท";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(14, 161);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(174, 20);
            this.labelSize.TabIndex = 4;
            this.labelSize.Text = "ขนาดพื้นที่สิ่งปลูกสร้าง(ตรม.)";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(14, 199);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(146, 20);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "ราคาประเมินสิ่งปลูกสร้าง";
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.PapayaWhip;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "ประเภทที่อยู่อาศัย",
            "ประเภทพาณิชยกรรม",
            "ประเภทที่ว่างเปล่า"});
            this.comboBoxType.Location = new System.Drawing.Point(67, 121);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(264, 28);
            this.comboBoxType.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBoxName.Location = new System.Drawing.Point(67, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(264, 27);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBoxAddress.Location = new System.Drawing.Point(67, 82);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(264, 27);
            this.textBoxAddress.TabIndex = 10;
            // 
            // textBoxSize
            // 
            this.textBoxSize.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBoxSize.Location = new System.Drawing.Point(198, 158);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(133, 27);
            this.textBoxSize.TabIndex = 11;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBoxPrice.Location = new System.Drawing.Point(166, 196);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(165, 27);
            this.textBoxPrice.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnAddress,
            this.ColumnType,
            this.ColumnSize,
            this.ColumnPrice,
            this.ColumnAssess,
            this.ColumnTotal});
            this.dataGridView1.GridColor = System.Drawing.Color.DarkOrange;
            this.dataGridView1.Location = new System.Drawing.Point(358, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1163, 606);
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
            this.ColumnTotal.Width = 125;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(14, 287);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(149, 64);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "บันทึก";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(182, 287);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(149, 64);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "ลบ";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxAssess
            // 
            this.textBoxAssess.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBoxAssess.Location = new System.Drawing.Point(206, 234);
            this.textBoxAssess.Name = "textBoxAssess";
            this.textBoxAssess.ReadOnly = true;
            this.textBoxAssess.Size = new System.Drawing.Size(125, 27);
            this.textBoxAssess.TabIndex = 13;
            // 
            // labelAssess
            // 
            this.labelAssess.AutoSize = true;
            this.labelAssess.Location = new System.Drawing.Point(14, 237);
            this.labelAssess.Name = "labelAssess";
            this.labelAssess.Size = new System.Drawing.Size(186, 20);
            this.labelAssess.TabIndex = 6;
            this.labelAssess.Text = "คิดเป็นราคาประเมินสิ่งปลูกสร้าง";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1533, 660);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxAssess);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxType);
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
        private ComboBox comboBoxType;
        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private TextBox textBoxSize;
        private TextBox textBoxPrice;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnTotal;
        private Button buttonSave;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewTextBoxColumn ColumnType;
        private DataGridViewTextBoxColumn ColumnSize;
        private DataGridViewTextBoxColumn ColumnPrice;
        private DataGridViewTextBoxColumn ColumnAssess;
        private TextBox textBoxAssess;
        private Label labelAssess;
    }
}
namespace UPnP
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.UDP_checkBox = new System.Windows.Forms.CheckBox();
			this.TCP_checkBox = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.remove_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.Flush_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.listView1 = new UPnP.DoubleBufferListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.UDP_checkBox);
			this.panel1.Controls.Add(this.TCP_checkBox);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.numericUpDown2);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 343);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(561, 130);
			this.panel1.TabIndex = 1;
			// 
			// UDP_checkBox
			// 
			this.UDP_checkBox.AutoSize = true;
			this.UDP_checkBox.Checked = true;
			this.UDP_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.UDP_checkBox.Location = new System.Drawing.Point(209, 70);
			this.UDP_checkBox.Name = "UDP_checkBox";
			this.UDP_checkBox.Size = new System.Drawing.Size(42, 16);
			this.UDP_checkBox.TabIndex = 11;
			this.UDP_checkBox.Text = "UDP";
			this.UDP_checkBox.UseVisualStyleBackColor = true;
			// 
			// TCP_checkBox
			// 
			this.TCP_checkBox.AutoSize = true;
			this.TCP_checkBox.Checked = true;
			this.TCP_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.TCP_checkBox.Location = new System.Drawing.Point(209, 41);
			this.TCP_checkBox.Name = "TCP_checkBox";
			this.TCP_checkBox.Size = new System.Drawing.Size(42, 16);
			this.TCP_checkBox.TabIndex = 10;
			this.TCP_checkBox.Text = "TCP";
			this.TCP_checkBox.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(59, 94);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(269, 21);
			this.textBox1.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "内部端口：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "外部端口：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "选择 IP 地址：";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(83, 68);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 21);
			this.numericUpDown2.TabIndex = 5;
			this.numericUpDown2.Tag = "";
			this.numericUpDown2.Value = new decimal(new int[] {
            1551,
            0,
            0,
            0});
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(83, 39);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
			this.numericUpDown1.TabIndex = 4;
			this.numericUpDown1.Value = new decimal(new int[] {
            1551,
            0,
            0,
            0});
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(107, 13);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(221, 20);
			this.comboBox1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(253, 39);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "添加";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Flush_MenuItem,
            this.toolStripSeparator1,
            this.remove_MenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(101, 54);
			// 
			// remove_MenuItem
			// 
			this.remove_MenuItem.Name = "remove_MenuItem";
			this.remove_MenuItem.Size = new System.Drawing.Size(100, 22);
			this.remove_MenuItem.Text = "移除";
			this.remove_MenuItem.Click += new System.EventHandler(this.remove_MenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
			// 
			// Flush_MenuItem
			// 
			this.Flush_MenuItem.Name = "Flush_MenuItem";
			this.Flush_MenuItem.Size = new System.Drawing.Size(100, 22);
			this.Flush_MenuItem.Text = "刷新";
			this.Flush_MenuItem.Click += new System.EventHandler(this.Flush_MenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 473);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(561, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// StatusLabel
			// 
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(56, 17);
			this.StatusLabel.Text = "欢迎使用";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(561, 343);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "应用描述";
			this.columnHeader1.Width = 101;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "外部端口";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "协议类型";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "内部端口";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "内部 IP 地址";
			this.columnHeader5.Width = 142;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "外部 IP 地址";
			this.columnHeader6.Width = 104;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 12;
			this.label4.Text = "描述：";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 495);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Name = "MainForm";
			this.Text = "UPnPClient";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DoubleBufferListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem remove_MenuItem;
		private System.Windows.Forms.CheckBox UDP_checkBox;
		private System.Windows.Forms.CheckBox TCP_checkBox;
		private System.Windows.Forms.ToolStripMenuItem Flush_MenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
		private System.Windows.Forms.Label label4;
	}
}


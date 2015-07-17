namespace VirusEffectedFolderScan
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelSecond = new System.Windows.Forms.Panel();
			this.panelFirst = new System.Windows.Forms.Panel();
			this.removableOnly = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboDrives = new System.Windows.Forms.ComboBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.buttonNext = new System.Windows.Forms.Button();
			this.panelReport = new System.Windows.Forms.Panel();
			this.labelReport = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panelSecond.SuspendLayout();
			this.panelFirst.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panelReport.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(340, 138);
			this.dataGridView1.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Select";
			this.Column1.Name = "Column1";
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Column1.Width = 50;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Folder Name";
			this.Column2.Name = "Column2";
			this.Column2.Width = 200;
			// 
			// panelSecond
			// 
			this.panelSecond.Controls.Add(this.dataGridView1);
			this.panelSecond.Location = new System.Drawing.Point(387, 12);
			this.panelSecond.Name = "panelSecond";
			this.panelSecond.Size = new System.Drawing.Size(340, 141);
			this.panelSecond.TabIndex = 1;
			// 
			// panelFirst
			// 
			this.panelFirst.Controls.Add(this.removableOnly);
			this.panelFirst.Controls.Add(this.checkBox1);
			this.panelFirst.Controls.Add(this.label2);
			this.panelFirst.Controls.Add(this.label1);
			this.panelFirst.Controls.Add(this.textBox1);
			this.panelFirst.Controls.Add(this.comboDrives);
			this.panelFirst.Location = new System.Drawing.Point(12, 12);
			this.panelFirst.Name = "panelFirst";
			this.panelFirst.Size = new System.Drawing.Size(340, 210);
			this.panelFirst.TabIndex = 2;
			// 
			// removableOnly
			// 
			this.removableOnly.AutoSize = true;
			this.removableOnly.Checked = true;
			this.removableOnly.CheckState = System.Windows.Forms.CheckState.Checked;
			this.removableOnly.Location = new System.Drawing.Point(194, 179);
			this.removableOnly.Name = "removableOnly";
			this.removableOnly.Size = new System.Drawing.Size(135, 19);
			this.removableOnly.TabIndex = 8;
			this.removableOnly.Text = "Removable disk only";
			this.removableOnly.UseVisualStyleBackColor = true;
			this.removableOnly.CheckedChanged += new System.EventHandler(this.removableOnly_CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(6, 152);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(128, 19);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "I accept this license";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(314, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "To use this tool you must accept this license agreement";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 180);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "Drive:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 23);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(323, 123);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// comboDrives
			// 
			this.comboDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboDrives.FormattingEnabled = true;
			this.comboDrives.Location = new System.Drawing.Point(47, 177);
			this.comboDrives.Name = "comboDrives";
			this.comboDrives.Size = new System.Drawing.Size(141, 23);
			this.comboDrives.TabIndex = 6;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.buttonCancel);
			this.panel4.Controls.Add(this.buttonBack);
			this.panel4.Controls.Add(this.buttonNext);
			this.panel4.Location = new System.Drawing.Point(14, 228);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(340, 33);
			this.panel4.TabIndex = 4;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(249, 3);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(80, 26);
			this.buttonCancel.TabIndex = 11;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
			// 
			// buttonBack
			// 
			this.buttonBack.Enabled = false;
			this.buttonBack.Location = new System.Drawing.Point(77, 3);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(80, 26);
			this.buttonBack.TabIndex = 10;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// buttonNext
			// 
			this.buttonNext.Enabled = false;
			this.buttonNext.Location = new System.Drawing.Point(163, 3);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(80, 26);
			this.buttonNext.TabIndex = 9;
			this.buttonNext.Text = "Next";
			this.buttonNext.UseVisualStyleBackColor = true;
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			// 
			// panelReport
			// 
			this.panelReport.Controls.Add(this.labelReport);
			this.panelReport.Location = new System.Drawing.Point(387, 180);
			this.panelReport.Name = "panelReport";
			this.panelReport.Size = new System.Drawing.Size(340, 141);
			this.panelReport.TabIndex = 5;
			// 
			// labelReport
			// 
			this.labelReport.AutoSize = true;
			this.labelReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelReport.ForeColor = System.Drawing.Color.Green;
			this.labelReport.Location = new System.Drawing.Point(14, 29);
			this.labelReport.Name = "labelReport";
			this.labelReport.Size = new System.Drawing.Size(49, 17);
			this.labelReport.TabIndex = 0;
			this.labelReport.Text = "Report";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Green;
			this.label3.Location = new System.Drawing.Point(16, 274);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Please like us on";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(115, 274);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(184, 15);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "www.facebook.com/mundhaSoft";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(366, 298);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panelReport);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panelFirst);
			this.Controls.Add(this.panelSecond);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Virus Effected Folder Scan 2.0";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panelSecond.ResumeLayout(false);
			this.panelFirst.ResumeLayout(false);
			this.panelFirst.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panelReport.ResumeLayout(false);
			this.panelReport.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panelSecond;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.Panel panelFirst;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panelReport;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ComboBox comboDrives;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox removableOnly;
		private System.Windows.Forms.Button buttonNext;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelReport;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel linkLabel1;

	}
}


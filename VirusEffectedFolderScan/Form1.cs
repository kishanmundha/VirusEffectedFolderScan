using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VirusEffectedFolderScan
{
	public partial class Form1 : Form
	{
		// Custom Function

		/// <summary>
		/// Step counter. Max 5 step
		/// </summary>
		int step = 0;

		/// <summary>
		/// Last time scan drive path for repair function
		/// </summary>
		string lastScanDrive = "";

		/// <summary>
		/// Repaired Folder count
		/// </summary>
		int rCount = 0;

		/// <summary>
		/// Refresh Drive ComboBox List
		/// </summary>
		private void refreshDriveList()
		{
			// Clear combobox Items
			comboDrives.Items.Clear();
			comboDrives.Text = "";

			// Get Drives List
			DriveInfo[] allDrives = DriveInfo.GetDrives();
			foreach (DriveInfo d in allDrives)
			{
				if (d.Name != Environment.SystemDirectory.Substring(0, 3))	// System Drive Like as C:\ not allowed
				{
					if (!removableOnly.Checked)
					{
						// Add All Fixed, Ram, Removable Disc in combo box
						if (d.IsReady && (d.DriveType == DriveType.Fixed || d.DriveType == DriveType.Ram || d.DriveType == DriveType.Removable))
							comboDrives.Items.Add(d.Name);
					}
					else
					{
						// Add only Removable Disc in combo box
						if (d.IsReady && d.DriveType == DriveType.Removable)
							comboDrives.Items.Add(d.Name);
					}
				}
			}
			if (comboDrives.Items.Count > 0) comboDrives.SelectedIndex = 0;		// if items added in combobox then select first item
		}

		/// <summary>
		/// Scan Folder who effected from virus and hidden. and store result in datagrid view
		/// </summary>
		/// <returns>if no error in path and exuted then return true</returns>
		private bool scanFolder()
		{
			// clear datagridview output
			dataGridView1.Rows.Clear();

			string[] whiteList = new string[] { "$Recycle.Bin", "System Volume Information" };		// white list folder like as system folder
			string path = comboDrives.Text;	// drive path to scan

			// path validation
			// path is not 0 lengh string, length less then 4, and not system drive
			if (path != "" && path.Length < 4 && path != Environment.SystemDirectory.Substring(0, 3) && Directory.Exists(path))
			{
				string[] dirs = Directory.GetDirectories(path);	// get directories
				foreach (string d in dirs)
				{
					DirectoryInfo dInfo = new DirectoryInfo(d);
					bool wt = false;
					bool nt = false;

					if (dInfo.Attributes == FileAttributes.Hidden) wt = true;						// is folder hidden normal
					else if ((dInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)	// is folder hidden hardly
					{
						foreach (string w in whiteList)		// scan that folder is not white list
							if (w.ToLower() == dInfo.Name.ToLower()) wt = true;
					}
					else nt = true;

					if (File.Exists(dInfo.Name + ".lnk") || File.Exists(dInfo.Name + ".exe"))		// virus scan
					{
						wt = false;
					}

					if (!nt) dataGridView1.Rows.Add(!wt, dInfo.Name);	// if folder required to show for action, show in data grid
				}
				lastScanDrive = path;
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Repair Folder who effected from virus and hidden
		/// </summary>
		private void repairFolder()
		{
			rCount = 0;
			int n = dataGridView1.Rows.Count;	// length of folders list for repair (datagridview Rows length)
			for (int i = 0; i < n; i++)
			{
				if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "True")
				{
					// change attribute for show folder (hidden=false, if system then system=false)
					string path = lastScanDrive + dataGridView1.Rows[i].Cells[1].Value.ToString();
					if (Directory.Exists(path))
					{
						DirectoryInfo dInfo = new DirectoryInfo(path);
						dInfo.Attributes &= (~FileAttributes.Hidden);	// Remove Hidden Attributes
						dInfo.Attributes &= (~FileAttributes.System);	// Remove System Attributes
					}

					// if *.lnk or *.exe file found same name of folder then delete file
					if (File.Exists(path + ".lnk"))
						File.Delete(path + ".lnk");
					if (File.Exists(path + ".exe"))
						File.Delete(path + ".exe");

					rCount++;	// repaired folder count
				}
			}
		}

		/// <summary>
		/// Show report of repaired folder
		/// </summary>
		private void showReport()
		{
			string rText = "";
			rText += rCount + " folder repaired";
			labelReport.Text = rText;
		}

		// System Function
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.Columns[1].ReadOnly = true;
			dataGridView1.Left = panelReport.Left = panelSecond.Left = panelFirst.Left;
			dataGridView1.Top = panelReport.Top = panelSecond.Top = panelFirst.Top;
			dataGridView1.Height = panelReport.Height = panelSecond.Height = panelFirst.Height;
			dataGridView1.Width = panelReport.Width = panelSecond.Width = panelFirst.Width;
			panelFirst.Show();
			panelSecond.Hide();
			panelReport.Hide();

			refreshDriveList();
			linkLabel1.Links.Add(0, 27, "www.facebook.com/mundhaSoft");
		}

		private void removableOnly_CheckedChanged(object sender, EventArgs e)
		{
			refreshDriveList();
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			switch (step)
			{
				case 0:
					if (comboDrives.Text == "")
					{
						MessageBox.Show("Please select drive first");
						break;
					}
					if (!scanFolder())
						break;
					// initlize second step
					panelFirst.Hide();
					panelSecond.Show();
					buttonBack.Enabled = true;
					step++;
					break;
				case 1:
					repairFolder();
					showReport();
					// initlize report step
					panelSecond.Hide();
					panelReport.Show();
					buttonBack.Enabled = false;
					buttonBack.Hide();
					buttonNext.Text = "Run again";
					buttonCancel.Text = "Close";
					step++;
					break;
				case 2:
					// intilize first step for Re-again run program
					panelReport.Hide();
					panelFirst.Show();
					buttonNext.Text = "Next";
					buttonCancel.Text = "Cancel";
					buttonBack.Enabled = false;
					buttonBack.Show();
					step = 0;
					break;
			}
		}

		private void buttonCancel_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			switch (step)
			{
				case 0:
					break;
				case 1:
					panelSecond.Hide();
					panelFirst.Show();
					buttonBack.Enabled = false;
					step--;
					break;
				case 2:
					break;
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				buttonNext.Enabled = true;
			}
			else buttonNext.Enabled = false;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
		}

	}
}

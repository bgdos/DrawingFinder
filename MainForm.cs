/*
 * Created by SharpDevelop.
 * User: JuanS
 * Date: 7/7/2015
 * Time: 2:13 PM
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using System.Linq;
using System.Collections.Specialized;

namespace DWGFinder
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public string[] cells;
		List<string> ext = new List<string> {".dwg", ".pdf"};
		string path = "";
		string pathV = @"\\translead.com\engineering\GlobalData\productiondwgs\";
		string pathC = @"chassis\";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			txtFind.Focus();
		}
		
		void BtnFindClick(object sender, EventArgs e)
		{
			lbResults.Items.Clear();
			if (rbVT.Checked)
			{
				path = pathV;
				VT();
			}
			else{
				path = pathV + pathC;
				Chassis();
			}
		}
		void LbResultsMouseDoubleClick(object sender, MouseEventArgs e)
		{
			OpenDwg();
			/*try 
			{
				Process.Start(@"C:\Program Files\Common Files\eDrawings2014\EModelViewer.exe", lbResults.SelectedItem.ToString());
				
			} catch (Exception) {
				
				try {
					Process.Start(@"C:\Program Files (x86)\Common Files\eDrawings2014\EModelViewer.exe", lbResults.SelectedItem.ToString());
				} catch (Exception) {
					
					throw;
				}
			}*/
		}
		public void Paste()
		{
			ClearList();
			string data = Clipboard.GetData(DataFormats.Text).ToString();
			string[] stringSeparators = new string[] { "\r\n" };
            cells = data.Split(stringSeparators, StringSplitOptions.None);
            dgvDrawings.Rows.Add(cells.Length-1);
           	for (int i = 0; i < cells.Length; i++)
            {
           		dgvDrawings[0, i].Value = cells[i];
            }
		}
		public void ClearList()
		{
			dgvDrawings.Rows.Clear();
		}
		void TxtFindClick(object sender, System.EventArgs e)
		{
			txtFind.SelectAll();
		}
		
		void BtnOpenClick(object sender, System.EventArgs e)
		{
			OpenDwg();
		}
		
		void BtnPasteClick(object sender, System.EventArgs e)
		{
			try {
				Paste();
			} catch (Exception) {
				
				MessageBox.Show("Must be more than one item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void BtnFind2Click(object sender, EventArgs e)
		{
			try {
				findAll();
			} catch (Exception) {
				
				throw;
			}
		}
		
		void BtnClearListClick(object sender, EventArgs e)
		{
			ClearList();
			btnOpen2.Enabled = false;
		}
		void BtnOpen2Click(object sender, EventArgs e)
		{
			OpenDwg(dgvDrawings[1, dgvDrawings.SelectedRows[0].Index].Value.ToString());
		}
		
		void DgvDrawingsCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvDrawings[1, dgvDrawings.SelectedRows[0].Index].Value != null)
				OpenDwg(dgvDrawings[1, dgvDrawings.SelectedRows[0].Index].Value.ToString());
		}
		//find files
		public void Chassis()
		{
			var files = Directory.GetFiles(path , txtFind.Text+"*", SearchOption.AllDirectories)
				.Where(s => ext.Any(e => s.EndsWith(e)));
			txtResults.Text = files.Count().ToString();
			lbResults.Items.Clear();
			foreach (string f in files)
			{
				var file = f.Remove(0,62);
				lbResults.Items.Add(file);
				if (files.Count() == 1)
					OpenDwg(path+file);
			}
			if (files.Count() == 0)
			    MessageBox.Show("File not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		public void VT()
		{
			var files = Directory.GetFiles(path, txtFind.Text+"*")
				.Where(s => s.EndsWith(".dwg") || s.EndsWith(".pdf"))
				.Where(s => !s.Contains("recover"));
			txtResults.Text = files.Count().ToString();
			lbResults.Items.Clear();
			foreach (string f in files)
			{
				var file = f.Remove(0,54);
				lbResults.Items.Add(file);
				if (files.Count() == 1)
					OpenDwg(file);
			}
			if (files.Count() == 0)
			    MessageBox.Show("File not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		public void findAll()
		{
			path = pathV;
			for (int i = 0; i < dgvDrawings.Rows.Count-1; i++)
			{
				var files = Directory.GetFiles(path, dgvDrawings[0,i].Value+"*")
					.Where(s => ext.Any(e => s.EndsWith(e)))
					.Where(s => !s.Contains("recover"));
				if (files.Count() > 0)
					btnOpen2.Enabled = true;
				else
					btnOpen2.Enabled = false;
				foreach (string f in files)
				{
					var file = f.Remove(0,54);
					dgvDrawings[1, i].Value = file;
				}
			}
		}
		//open files
		public void OpenDwg()
		{
			try 
			{
				ProcessStartInfo startApp = new ProcessStartInfo();
				startApp.FileName = path + lbResults.SelectedItem.ToString();
			    startApp.UseShellExecute = true;
			    Process.Start(startApp);
			} catch (Exception) {
				
				MessageBox.Show("There is no file selected or There is no program associated to the file", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
		}
		public void OpenDwg(string file)
		{
			if (file != "")
			{
				try 
				{
					ProcessStartInfo startApp = new ProcessStartInfo();
				    startApp.FileName = path + file;
				    startApp.UseShellExecute = true;
					Process.Start(startApp);
				} catch (Exception) {
					
					MessageBox.Show("There is no file selected or There is no program associated to the file", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
		//copy files
		void BtnCopyClick(object sender, EventArgs e)
		{
			StringCollection paths = new StringCollection();
			paths.Add(path + lbResults.SelectedItem.ToString());
			Clipboard.SetFileDropList(paths);
		}
		
		void BtnCopy2Click(object sender, EventArgs e)
		{
			StringCollection paths = new StringCollection();
			for (var i = 0; i < dgvDrawings.SelectedRows.Count; i++)
				paths.Add(path + dgvDrawings.SelectedRows[i].Cells["DrawingPath"].Value);
			Clipboard.SetFileDropList(paths);
		}
	}
}

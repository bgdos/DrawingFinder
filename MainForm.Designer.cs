/*
 * Created by SharpDevelop.
 * User: JuanS
 * Date: 7/7/2015
 * Time: 2:13 PM
 * 
 */
namespace DWGFinder
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tbSearch = new System.Windows.Forms.TabControl();
			this.tbss = new System.Windows.Forms.TabPage();
			this.btnCopy = new System.Windows.Forms.Button();
			this.rbCA = new System.Windows.Forms.RadioButton();
			this.rbVT = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.txtResults = new System.Windows.Forms.TextBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.lbResults = new System.Windows.Forms.ListBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFind = new System.Windows.Forms.TextBox();
			this.tbsm = new System.Windows.Forms.TabPage();
			this.btnCopy2 = new System.Windows.Forms.Button();
			this.btnClearList = new System.Windows.Forms.Button();
			this.btnFind2 = new System.Windows.Forms.Button();
			this.btnPaste = new System.Windows.Forms.Button();
			this.btnOpen2 = new System.Windows.Forms.Button();
			this.dgvDrawings = new System.Windows.Forms.DataGridView();
			this.Drawing = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DrawingPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblFindM = new System.Windows.Forms.Label();
			this.tbSearch.SuspendLayout();
			this.tbss.SuspendLayout();
			this.tbsm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDrawings)).BeginInit();
			this.SuspendLayout();
			// 
			// tbSearch
			// 
			this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbSearch.Controls.Add(this.tbss);
			this.tbSearch.Controls.Add(this.tbsm);
			this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSearch.Location = new System.Drawing.Point(12, 12);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.SelectedIndex = 0;
			this.tbSearch.Size = new System.Drawing.Size(568, 411);
			this.tbSearch.TabIndex = 8;
			// 
			// tbss
			// 
			this.tbss.BackColor = System.Drawing.Color.White;
			this.tbss.Controls.Add(this.btnCopy);
			this.tbss.Controls.Add(this.rbCA);
			this.tbss.Controls.Add(this.rbVT);
			this.tbss.Controls.Add(this.label2);
			this.tbss.Controls.Add(this.txtResults);
			this.tbss.Controls.Add(this.btnOpen);
			this.tbss.Controls.Add(this.lbResults);
			this.tbss.Controls.Add(this.btnFind);
			this.tbss.Controls.Add(this.label1);
			this.tbss.Controls.Add(this.txtFind);
			this.tbss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbss.Location = new System.Drawing.Point(4, 24);
			this.tbss.Name = "tbss";
			this.tbss.Padding = new System.Windows.Forms.Padding(3);
			this.tbss.Size = new System.Drawing.Size(560, 383);
			this.tbss.TabIndex = 0;
			this.tbss.Text = "Single Search";
			// 
			// btnCopy
			// 
			this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
			this.btnCopy.Location = new System.Drawing.Point(383, 348);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(90, 28);
			this.btnCopy.TabIndex = 8;
			this.btnCopy.Text = "Copy File";
			this.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.BtnCopyClick);
			// 
			// rbCA
			// 
			this.rbCA.Location = new System.Drawing.Point(405, 7);
			this.rbCA.Name = "rbCA";
			this.rbCA.Size = new System.Drawing.Size(81, 24);
			this.rbCA.TabIndex = 4;
			this.rbCA.Text = "Chassis";
			this.rbCA.UseVisualStyleBackColor = true;
			// 
			// rbVT
			// 
			this.rbVT.Checked = true;
			this.rbVT.Location = new System.Drawing.Point(300, 7);
			this.rbVT.Name = "rbVT";
			this.rbVT.Size = new System.Drawing.Size(99, 24);
			this.rbVT.TabIndex = 3;
			this.rbVT.TabStop = true;
			this.rbVT.Text = "Van Trailer";
			this.rbVT.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 353);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Results :";
			// 
			// txtResults
			// 
			this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResults.Location = new System.Drawing.Point(96, 353);
			this.txtResults.Name = "txtResults";
			this.txtResults.ReadOnly = true;
			this.txtResults.Size = new System.Drawing.Size(100, 21);
			this.txtResults.TabIndex = 6;
			this.txtResults.Text = "0";
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
			this.btnOpen.Location = new System.Drawing.Point(479, 349);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 28);
			this.btnOpen.TabIndex = 7;
			this.btnOpen.Text = "Open";
			this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.BtnOpenClick);
			// 
			// lbResults
			// 
			this.lbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbResults.FormattingEnabled = true;
			this.lbResults.ItemHeight = 15;
			this.lbResults.Location = new System.Drawing.Point(6, 36);
			this.lbResults.Name = "lbResults";
			this.lbResults.Size = new System.Drawing.Size(548, 304);
			this.lbResults.TabIndex = 5;
			this.lbResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbResultsMouseDoubleClick);
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.Color.Transparent;
			this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
			this.btnFind.Location = new System.Drawing.Point(202, 6);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(61, 26);
			this.btnFind.TabIndex = 2;
			this.btnFind.Text = "Find";
			this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Click += new System.EventHandler(this.BtnFindClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Drawing No.";
			// 
			// txtFind
			// 
			this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFind.Location = new System.Drawing.Point(96, 9);
			this.txtFind.Name = "txtFind";
			this.txtFind.Size = new System.Drawing.Size(100, 21);
			this.txtFind.TabIndex = 0;
			this.txtFind.Click += new System.EventHandler(this.TxtFindClick);
			// 
			// tbsm
			// 
			this.tbsm.Controls.Add(this.btnCopy2);
			this.tbsm.Controls.Add(this.btnClearList);
			this.tbsm.Controls.Add(this.btnFind2);
			this.tbsm.Controls.Add(this.btnPaste);
			this.tbsm.Controls.Add(this.btnOpen2);
			this.tbsm.Controls.Add(this.dgvDrawings);
			this.tbsm.Controls.Add(this.lblFindM);
			this.tbsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbsm.Location = new System.Drawing.Point(4, 24);
			this.tbsm.Name = "tbsm";
			this.tbsm.Padding = new System.Windows.Forms.Padding(3);
			this.tbsm.Size = new System.Drawing.Size(560, 383);
			this.tbsm.TabIndex = 1;
			this.tbsm.Text = "Multiple Search";
			this.tbsm.UseVisualStyleBackColor = true;
			// 
			// btnCopy2
			// 
			this.btnCopy2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCopy2.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy2.Image")));
			this.btnCopy2.Location = new System.Drawing.Point(379, 349);
			this.btnCopy2.Name = "btnCopy2";
			this.btnCopy2.Size = new System.Drawing.Size(94, 28);
			this.btnCopy2.TabIndex = 6;
			this.btnCopy2.Text = "Copy Files";
			this.btnCopy2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCopy2.UseVisualStyleBackColor = true;
			this.btnCopy2.Click += new System.EventHandler(this.BtnCopy2Click);
			// 
			// btnClearList
			// 
			this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnClearList.Image = ((System.Drawing.Image)(resources.GetObject("btnClearList.Image")));
			this.btnClearList.Location = new System.Drawing.Point(87, 349);
			this.btnClearList.Name = "btnClearList";
			this.btnClearList.Size = new System.Drawing.Size(85, 28);
			this.btnClearList.TabIndex = 5;
			this.btnClearList.Text = "Clear List";
			this.btnClearList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClearList.UseVisualStyleBackColor = true;
			this.btnClearList.Click += new System.EventHandler(this.BtnClearListClick);
			// 
			// btnFind2
			// 
			this.btnFind2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnFind2.Image = ((System.Drawing.Image)(resources.GetObject("btnFind2.Image")));
			this.btnFind2.Location = new System.Drawing.Point(178, 349);
			this.btnFind2.Name = "btnFind2";
			this.btnFind2.Size = new System.Drawing.Size(75, 28);
			this.btnFind2.TabIndex = 4;
			this.btnFind2.Text = "Find";
			this.btnFind2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFind2.UseVisualStyleBackColor = true;
			this.btnFind2.Click += new System.EventHandler(this.BtnFind2Click);
			// 
			// btnPaste
			// 
			this.btnPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
			this.btnPaste.Location = new System.Drawing.Point(6, 349);
			this.btnPaste.Name = "btnPaste";
			this.btnPaste.Size = new System.Drawing.Size(75, 28);
			this.btnPaste.TabIndex = 3;
			this.btnPaste.Text = "Paste";
			this.btnPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPaste.UseVisualStyleBackColor = true;
			this.btnPaste.Click += new System.EventHandler(this.BtnPasteClick);
			// 
			// btnOpen2
			// 
			this.btnOpen2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen2.Enabled = false;
			this.btnOpen2.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen2.Image")));
			this.btnOpen2.Location = new System.Drawing.Point(479, 349);
			this.btnOpen2.Name = "btnOpen2";
			this.btnOpen2.Size = new System.Drawing.Size(75, 28);
			this.btnOpen2.TabIndex = 2;
			this.btnOpen2.Text = "Open";
			this.btnOpen2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOpen2.UseVisualStyleBackColor = true;
			this.btnOpen2.Click += new System.EventHandler(this.BtnOpen2Click);
			// 
			// dgvDrawings
			// 
			this.dgvDrawings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDrawings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDrawings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Drawing,
									this.DrawingPath});
			this.dgvDrawings.Location = new System.Drawing.Point(6, 38);
			this.dgvDrawings.Name = "dgvDrawings";
			this.dgvDrawings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDrawings.Size = new System.Drawing.Size(548, 305);
			this.dgvDrawings.TabIndex = 1;
			this.dgvDrawings.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDrawingsCellContentDoubleClick);
			// 
			// Drawing
			// 
			this.Drawing.HeaderText = "Drawing No.";
			this.Drawing.Name = "Drawing";
			// 
			// DrawingPath
			// 
			this.DrawingPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DrawingPath.HeaderText = "Drawing Name";
			this.DrawingPath.MinimumWidth = 200;
			this.DrawingPath.Name = "DrawingPath";
			this.DrawingPath.ReadOnly = true;
			// 
			// lblFindM
			// 
			this.lblFindM.Location = new System.Drawing.Point(6, 12);
			this.lblFindM.Name = "lblFindM";
			this.lblFindM.Size = new System.Drawing.Size(211, 23);
			this.lblFindM.TabIndex = 0;
			this.lblFindM.Text = "Use this tab to find multiple drawings";
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnFind;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(592, 435);
			this.Controls.Add(this.tbSearch);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Drawing Finder || JS Software";
			this.tbSearch.ResumeLayout(false);
			this.tbss.ResumeLayout(false);
			this.tbss.PerformLayout();
			this.tbsm.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDrawings)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnCopy2;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnClearList;
		private System.Windows.Forms.Button btnFind2;
		private System.Windows.Forms.Button btnOpen2;
		private System.Windows.Forms.Button btnPaste;
		private System.Windows.Forms.Label lblFindM;
		private System.Windows.Forms.DataGridViewTextBoxColumn DrawingPath;
		private System.Windows.Forms.DataGridViewTextBoxColumn Drawing;
		private System.Windows.Forms.DataGridView dgvDrawings;
		private System.Windows.Forms.RadioButton rbVT;
		private System.Windows.Forms.RadioButton rbCA;
		private System.Windows.Forms.TextBox txtResults;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.ListBox lbResults;
		private System.Windows.Forms.TabPage tbsm;
		private System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TabPage tbss;
		private System.Windows.Forms.TabControl tbSearch;
	}
}

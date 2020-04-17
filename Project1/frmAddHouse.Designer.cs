namespace Project1
{
	partial class frmAddHouse
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddHouse));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuViewHouse = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuViewExit = new System.Windows.Forms.ToolStripMenuItem();
			this.lblAddHouse = new System.Windows.Forms.Label();
			this.lstAddHouse = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuView});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(407, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuView
			// 
			this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewHouse,
            this.toolStripSeparator1,
            this.mnuViewExit});
			this.mnuView.Name = "mnuView";
			this.mnuView.Size = new System.Drawing.Size(44, 20);
			this.mnuView.Text = "&View";
			// 
			// mnuViewHouse
			// 
			this.mnuViewHouse.Name = "mnuViewHouse";
			this.mnuViewHouse.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.mnuViewHouse.Size = new System.Drawing.Size(160, 22);
			this.mnuViewHouse.Text = "&House...";
			this.mnuViewHouse.Click += new System.EventHandler(this.mnuViewHouse_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
			// 
			// mnuViewExit
			// 
			this.mnuViewExit.Name = "mnuViewExit";
			this.mnuViewExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.mnuViewExit.Size = new System.Drawing.Size(160, 22);
			this.mnuViewExit.Text = "&Exit";
			this.mnuViewExit.Click += new System.EventHandler(this.mnuViewExit_Click);
			// 
			// lblAddHouse
			// 
			this.lblAddHouse.AutoSize = true;
			this.lblAddHouse.Location = new System.Drawing.Point(21, 50);
			this.lblAddHouse.Name = "lblAddHouse";
			this.lblAddHouse.Size = new System.Drawing.Size(137, 13);
			this.lblAddHouse.TabIndex = 1;
			this.lblAddHouse.Text = "Details of house(s) selected";
			// 
			// lstAddHouse
			// 
			this.lstAddHouse.FormattingEnabled = true;
			this.lstAddHouse.Location = new System.Drawing.Point(24, 66);
			this.lstAddHouse.Name = "lstAddHouse";
			this.lstAddHouse.Size = new System.Drawing.Size(358, 134);
			this.lstAddHouse.TabIndex = 2;
			// 
			// frmAddHouse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 235);
			this.Controls.Add(this.lstAddHouse);
			this.Controls.Add(this.lblAddHouse);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmAddHouse";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Add House";
			this.Activated += new System.EventHandler(this.frmAddHouse_Activated);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuView;
		private System.Windows.Forms.ToolStripMenuItem mnuViewHouse;
		private System.Windows.Forms.ToolStripMenuItem mnuViewExit;
		private System.Windows.Forms.Label lblAddHouse;
		private System.Windows.Forms.ListBox lstAddHouse;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}


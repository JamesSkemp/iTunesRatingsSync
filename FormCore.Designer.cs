namespace JamesRSkemp.iTunes.RatingsSync {
	partial class FormCore {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCore));
			this.statusStripCore = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelCore = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBarCore = new System.Windows.Forms.ToolStripProgressBar();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.linkLabelContact = new System.Windows.Forms.LinkLabel();
			this.labelAppleInc = new System.Windows.Forms.Label();
			this.groupBoxMain = new System.Windows.Forms.GroupBox();
			this.textBoxUpdates = new System.Windows.Forms.TextBox();
			this.buttonSyncData = new System.Windows.Forms.Button();
			this.labelDetails2 = new System.Windows.Forms.Label();
			this.labelDetails1 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonPreview = new System.Windows.Forms.Button();
			this.sourceListing2 = new System.Windows.Forms.ComboBox();
			this.sourceListing1 = new System.Windows.Forms.ComboBox();
			this.labelSource2 = new System.Windows.Forms.Label();
			this.labelSource1 = new System.Windows.Forms.Label();
			this.statusStripCore.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBoxMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStripCore
			// 
			this.statusStripCore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCore,
            this.toolStripProgressBarCore});
			this.statusStripCore.Location = new System.Drawing.Point(0, 692);
			this.statusStripCore.Name = "statusStripCore";
			this.statusStripCore.Size = new System.Drawing.Size(563, 22);
			this.statusStripCore.TabIndex = 0;
			this.statusStripCore.Text = "statusStrip1";
			// 
			// toolStripStatusLabelCore
			// 
			this.toolStripStatusLabelCore.Name = "toolStripStatusLabelCore";
			this.toolStripStatusLabelCore.Size = new System.Drawing.Size(548, 17);
			this.toolStripStatusLabelCore.Spring = true;
			this.toolStripStatusLabelCore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripProgressBarCore
			// 
			this.toolStripProgressBarCore.Name = "toolStripProgressBarCore";
			this.toolStripProgressBarCore.Size = new System.Drawing.Size(100, 16);
			this.toolStripProgressBarCore.Visible = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.sourcesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(563, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.connectToolStripMenuItem.Text = "Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
			// 
			// sourcesToolStripMenuItem
			// 
			this.sourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
			this.sourcesToolStripMenuItem.Name = "sourcesToolStripMenuItem";
			this.sourcesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.sourcesToolStripMenuItem.Text = "Sources";
			this.sourcesToolStripMenuItem.Visible = false;
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// linkLabelContact
			// 
			this.linkLabelContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabelContact.AutoSize = true;
			this.linkLabelContact.Location = new System.Drawing.Point(424, 679);
			this.linkLabelContact.Name = "linkLabelContact";
			this.linkLabelContact.Size = new System.Drawing.Size(127, 13);
			this.linkLabelContact.TabIndex = 2;
			this.linkLabelContact.TabStop = true;
			this.linkLabelContact.Text = "Created by James Skemp";
			this.linkLabelContact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelContact_LinkClicked);
			// 
			// labelAppleInc
			// 
			this.labelAppleInc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelAppleInc.AutoSize = true;
			this.labelAppleInc.Location = new System.Drawing.Point(12, 679);
			this.labelAppleInc.Name = "labelAppleInc";
			this.labelAppleInc.Size = new System.Drawing.Size(146, 13);
			this.labelAppleInc.TabIndex = 3;
			this.labelAppleInc.Text = "iTunes is copyright Apple Inc.";
			// 
			// groupBoxMain
			// 
			this.groupBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxMain.Controls.Add(this.textBoxUpdates);
			this.groupBoxMain.Controls.Add(this.buttonSyncData);
			this.groupBoxMain.Controls.Add(this.labelDetails2);
			this.groupBoxMain.Controls.Add(this.labelDetails1);
			this.groupBoxMain.Controls.Add(this.dataGridView2);
			this.groupBoxMain.Controls.Add(this.dataGridView1);
			this.groupBoxMain.Controls.Add(this.buttonPreview);
			this.groupBoxMain.Controls.Add(this.sourceListing2);
			this.groupBoxMain.Controls.Add(this.sourceListing1);
			this.groupBoxMain.Controls.Add(this.labelSource2);
			this.groupBoxMain.Controls.Add(this.labelSource1);
			this.groupBoxMain.Location = new System.Drawing.Point(12, 27);
			this.groupBoxMain.Name = "groupBoxMain";
			this.groupBoxMain.Size = new System.Drawing.Size(539, 649);
			this.groupBoxMain.TabIndex = 8;
			this.groupBoxMain.TabStop = false;
			this.groupBoxMain.Visible = false;
			// 
			// textBoxUpdates
			// 
			this.textBoxUpdates.Location = new System.Drawing.Point(9, 446);
			this.textBoxUpdates.Multiline = true;
			this.textBoxUpdates.Name = "textBoxUpdates";
			this.textBoxUpdates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxUpdates.Size = new System.Drawing.Size(524, 197);
			this.textBoxUpdates.TabIndex = 20;
			// 
			// buttonSyncData
			// 
			this.buttonSyncData.Location = new System.Drawing.Point(225, 413);
			this.buttonSyncData.Name = "buttonSyncData";
			this.buttonSyncData.Size = new System.Drawing.Size(75, 23);
			this.buttonSyncData.TabIndex = 19;
			this.buttonSyncData.Text = "Sync data";
			this.buttonSyncData.UseVisualStyleBackColor = true;
			this.buttonSyncData.Click += new System.EventHandler(this.buttonSyncData_Click);
			// 
			// labelDetails2
			// 
			this.labelDetails2.AutoSize = true;
			this.labelDetails2.Location = new System.Drawing.Point(6, 241);
			this.labelDetails2.Name = "labelDetails2";
			this.labelDetails2.Size = new System.Drawing.Size(0, 13);
			this.labelDetails2.TabIndex = 18;
			// 
			// labelDetails1
			// 
			this.labelDetails1.AutoSize = true;
			this.labelDetails1.Location = new System.Drawing.Point(6, 72);
			this.labelDetails1.Name = "labelDetails1";
			this.labelDetails1.Size = new System.Drawing.Size(0, 13);
			this.labelDetails1.TabIndex = 17;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(9, 257);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(524, 150);
			this.dataGridView2.TabIndex = 16;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(9, 88);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(524, 150);
			this.dataGridView1.TabIndex = 15;
			// 
			// buttonPreview
			// 
			this.buttonPreview.Location = new System.Drawing.Point(225, 59);
			this.buttonPreview.Name = "buttonPreview";
			this.buttonPreview.Size = new System.Drawing.Size(75, 23);
			this.buttonPreview.TabIndex = 14;
			this.buttonPreview.Text = "Preview";
			this.buttonPreview.UseVisualStyleBackColor = true;
			this.buttonPreview.Visible = false;
			this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
			// 
			// sourceListing2
			// 
			this.sourceListing2.DropDownWidth = 164;
			this.sourceListing2.FormattingEnabled = true;
			this.sourceListing2.Location = new System.Drawing.Point(225, 32);
			this.sourceListing2.Name = "sourceListing2";
			this.sourceListing2.Size = new System.Drawing.Size(210, 21);
			this.sourceListing2.TabIndex = 13;
			// 
			// sourceListing1
			// 
			this.sourceListing1.FormattingEnabled = true;
			this.sourceListing1.Location = new System.Drawing.Point(9, 32);
			this.sourceListing1.Name = "sourceListing1";
			this.sourceListing1.Size = new System.Drawing.Size(210, 21);
			this.sourceListing1.TabIndex = 12;
			// 
			// labelSource2
			// 
			this.labelSource2.AutoSize = true;
			this.labelSource2.Location = new System.Drawing.Point(222, 16);
			this.labelSource2.Name = "labelSource2";
			this.labelSource2.Size = new System.Drawing.Size(94, 13);
			this.labelSource2.TabIndex = 11;
			this.labelSource2.Text = "Source to copy to:";
			// 
			// labelSource1
			// 
			this.labelSource1.AutoSize = true;
			this.labelSource1.Location = new System.Drawing.Point(6, 16);
			this.labelSource1.Name = "labelSource1";
			this.labelSource1.Size = new System.Drawing.Size(105, 13);
			this.labelSource1.TabIndex = 10;
			this.labelSource1.Text = "Source to copy from:";
			// 
			// FormCore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 714);
			this.Controls.Add(this.groupBoxMain);
			this.Controls.Add(this.labelAppleInc);
			this.Controls.Add(this.linkLabelContact);
			this.Controls.Add(this.statusStripCore);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormCore";
			this.Text = "iTunes Ratings Sync 0.3";
			this.statusStripCore.ResumeLayout(false);
			this.statusStripCore.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBoxMain.ResumeLayout(false);
			this.groupBoxMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStripCore;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarCore;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCore;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sourcesToolStripMenuItem;
		private System.Windows.Forms.LinkLabel linkLabelContact;
		private System.Windows.Forms.Label labelAppleInc;
		private System.Windows.Forms.GroupBox groupBoxMain;
		private System.Windows.Forms.Label labelSource2;
		private System.Windows.Forms.Label labelSource1;
		private System.Windows.Forms.ComboBox sourceListing2;
		private System.Windows.Forms.ComboBox sourceListing1;
		private System.Windows.Forms.Button buttonPreview;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label labelDetails2;
		private System.Windows.Forms.Label labelDetails1;
		private System.Windows.Forms.Button buttonSyncData;
		private System.Windows.Forms.TextBox textBoxUpdates;
	}
}


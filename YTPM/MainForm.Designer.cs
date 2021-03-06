﻿namespace YTMP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.playlistOptionsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlaylistButton = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistOptionsSeparatorA = new System.Windows.Forms.ToolStripSeparator();
            this.importFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.importURLButton = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistOptionsSeparatorB = new System.Windows.Forms.ToolStripSeparator();
            this.exportFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.autoPlayToggleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleToggleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpButton = new System.Windows.Forms.ToolStripMenuItem();
            this.GuideButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.minMaxToggleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.onInOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.videoNameLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.videoUploaderLabel = new System.Windows.Forms.Label();
            this.videoDescriptionBox = new System.Windows.Forms.TextBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.importURL = new System.ComponentModel.BackgroundWorker();
            this.importFile = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistOptionsButton,
            this.autoPlayToggleButton,
            this.shuffleToggleButton,
            this.helpButton,
            this.minMaxToggleButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "Menu Strip";
            // 
            // playlistOptionsButton
            // 
            this.playlistOptionsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlaylistButton,
            this.playlistOptionsSeparatorA,
            this.importFileButton,
            this.importURLButton,
            this.playlistOptionsSeparatorB,
            this.exportFileButton});
            this.playlistOptionsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playlistOptionsButton.Name = "playlistOptionsButton";
            this.playlistOptionsButton.ShortcutKeyDisplayString = "";
            this.playlistOptionsButton.Size = new System.Drawing.Size(101, 20);
            this.playlistOptionsButton.Text = "Playlist Options";
            // 
            // newPlaylistButton
            // 
            this.newPlaylistButton.Enabled = false;
            this.newPlaylistButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newPlaylistButton.Name = "newPlaylistButton";
            this.newPlaylistButton.Size = new System.Drawing.Size(172, 22);
            this.newPlaylistButton.Text = "New Playlist";
            this.newPlaylistButton.Click += new System.EventHandler(this.newPlaylistButton_Click);
            // 
            // playlistOptionsSeparatorA
            // 
            this.playlistOptionsSeparatorA.Name = "playlistOptionsSeparatorA";
            this.playlistOptionsSeparatorA.Size = new System.Drawing.Size(169, 6);
            // 
            // importFileButton
            // 
            this.importFileButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.importFileButton.Name = "importFileButton";
            this.importFileButton.Size = new System.Drawing.Size(172, 22);
            this.importFileButton.Text = "Import from File...";
            this.importFileButton.Click += new System.EventHandler(this.importFileButton_Click);
            // 
            // importURLButton
            // 
            this.importURLButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.importURLButton.Name = "importURLButton";
            this.importURLButton.Size = new System.Drawing.Size(172, 22);
            this.importURLButton.Text = "Import from URL...";
            this.importURLButton.Click += new System.EventHandler(this.importURLButton_Click);
            // 
            // playlistOptionsSeparatorB
            // 
            this.playlistOptionsSeparatorB.Name = "playlistOptionsSeparatorB";
            this.playlistOptionsSeparatorB.Size = new System.Drawing.Size(169, 6);
            // 
            // exportFileButton
            // 
            this.exportFileButton.Enabled = false;
            this.exportFileButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exportFileButton.Name = "exportFileButton";
            this.exportFileButton.Size = new System.Drawing.Size(172, 22);
            this.exportFileButton.Text = "Export to File...";
            this.exportFileButton.Click += new System.EventHandler(this.exportFileButton_Click);
            // 
            // autoPlayToggleButton
            // 
            this.autoPlayToggleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.autoPlayToggleButton.Name = "autoPlayToggleButton";
            this.autoPlayToggleButton.Size = new System.Drawing.Size(96, 20);
            this.autoPlayToggleButton.Text = "Auto-Play: ON";
            this.autoPlayToggleButton.Click += new System.EventHandler(this.autoPlayToggleButton_Click);
            // 
            // shuffleToggleButton
            // 
            this.shuffleToggleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shuffleToggleButton.Name = "shuffleToggleButton";
            this.shuffleToggleButton.Size = new System.Drawing.Size(83, 20);
            this.shuffleToggleButton.Text = "Shuffle: OFF";
            this.shuffleToggleButton.Click += new System.EventHandler(this.shuffleToggleButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GuideButton,
            this.helpSeparator,
            this.AboutButton});
            this.helpButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(44, 20);
            this.helpButton.Text = "Help";
            // 
            // GuideButton
            // 
            this.GuideButton.Enabled = false;
            this.GuideButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GuideButton.Name = "GuideButton";
            this.GuideButton.Size = new System.Drawing.Size(138, 22);
            this.GuideButton.Text = "Guide [TBA]";
            // 
            // helpSeparator
            // 
            this.helpSeparator.Name = "helpSeparator";
            this.helpSeparator.Size = new System.Drawing.Size(135, 6);
            // 
            // AboutButton
            // 
            this.AboutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(138, 22);
            this.AboutButton.Text = "About";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // minMaxToggleButton
            // 
            this.minMaxToggleButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minMaxToggleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minMaxToggleButton.Name = "minMaxToggleButton";
            this.minMaxToggleButton.Size = new System.Drawing.Size(104, 20);
            this.minMaxToggleButton.Text = "Maximise Player";
            this.minMaxToggleButton.Visible = false;
            this.minMaxToggleButton.Click += new System.EventHandler(this.MinMaxToggleButton_Click);
            // 
            // onInOrderToolStripMenuItem
            // 
            this.onInOrderToolStripMenuItem.Name = "onInOrderToolStripMenuItem";
            this.onInOrderToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.searchBox.Location = new System.Drawing.Point(14, 30);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(742, 31);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(657, 30);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 31);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // videoNameLabel
            // 
            this.videoNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.videoNameLabel.AutoSize = true;
            this.videoNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.videoNameLabel.Location = new System.Drawing.Point(763, 306);
            this.videoNameLabel.MaximumSize = new System.Drawing.Size(480, 0);
            this.videoNameLabel.Name = "videoNameLabel";
            this.videoNameLabel.Size = new System.Drawing.Size(0, 37);
            this.videoNameLabel.TabIndex = 9;
            this.videoNameLabel.Visible = false;
            this.videoNameLabel.Click += new System.EventHandler(this.videoNameLabel_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            this.saveFileDialog.Title = "Export Playlist";
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.DefaultExt = "txt";
            this.loadFileDialog.Filter = "Text Files (*.txt)|*.txt";
            this.loadFileDialog.Title = "Import Playlist";
            // 
            // videoUploaderLabel
            // 
            this.videoUploaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.videoUploaderLabel.AutoSize = true;
            this.videoUploaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoUploaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.videoUploaderLabel.Location = new System.Drawing.Point(766, 343);
            this.videoUploaderLabel.Name = "videoUploaderLabel";
            this.videoUploaderLabel.Size = new System.Drawing.Size(0, 20);
            this.videoUploaderLabel.TabIndex = 10;
            this.videoUploaderLabel.Visible = false;
            // 
            // videoDescriptionBox
            // 
            this.videoDescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoDescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.videoDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoDescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoDescriptionBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.videoDescriptionBox.Location = new System.Drawing.Point(770, 371);
            this.videoDescriptionBox.Multiline = true;
            this.videoDescriptionBox.Name = "videoDescriptionBox";
            this.videoDescriptionBox.ReadOnly = true;
            this.videoDescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.videoDescriptionBox.Size = new System.Drawing.Size(480, 259);
            this.videoDescriptionBox.TabIndex = 11;
            this.videoDescriptionBox.Visible = false;
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previousButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.previousButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.previousButton.Location = new System.Drawing.Point(770, 636);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(237, 31);
            this.previousButton.TabIndex = 12;
            this.previousButton.Text = "◀  Previous Video";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Visible = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nextButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextButton.Location = new System.Drawing.Point(1013, 636);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(237, 31);
            this.nextButton.TabIndex = 13;
            this.nextButton.Text = "Next Video  ▶";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // importURL
            // 
            this.importURL.WorkerSupportsCancellation = true;
            this.importURL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.importURL_DoWork);
            this.importURL.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.importURL_RunWorkerCompleted);
            // 
            // importFile
            // 
            this.importFile.WorkerSupportsCancellation = true;
            this.importFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.importFile_DoWork);
            this.importFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.importFile_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.videoDescriptionBox);
            this.Controls.Add(this.videoUploaderLabel);
            this.Controls.Add(this.videoNameLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Text = "YouTube Playlist Manager [BETA]";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem playlistOptionsButton;
        private System.Windows.Forms.ToolStripMenuItem importFileButton;
        private System.Windows.Forms.ToolStripMenuItem importURLButton;
        private System.Windows.Forms.ToolStripSeparator playlistOptionsSeparatorB;
        private System.Windows.Forms.ToolStripMenuItem exportFileButton;
        private System.Windows.Forms.ToolStripMenuItem onInOrderToolStripMenuItem;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ToolStripMenuItem autoPlayToggleButton;
        private System.Windows.Forms.ToolStripMenuItem shuffleToggleButton;
        private System.Windows.Forms.ToolStripMenuItem helpButton;
        private System.Windows.Forms.ToolStripMenuItem GuideButton;
        private System.Windows.Forms.ToolStripSeparator helpSeparator;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.ToolStripMenuItem minMaxToggleButton;
        private System.Windows.Forms.Label videoNameLabel;
        private System.Windows.Forms.ToolStripMenuItem newPlaylistButton;
        private System.Windows.Forms.ToolStripSeparator playlistOptionsSeparatorA;
        private System.Windows.Forms.Label videoUploaderLabel;
        private System.Windows.Forms.TextBox videoDescriptionBox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        public System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.ComponentModel.BackgroundWorker importURL;
        private System.ComponentModel.BackgroundWorker importFile;
    }
}


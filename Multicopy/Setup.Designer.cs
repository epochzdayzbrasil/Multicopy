namespace Multicopy
{
    partial class Setup
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
            this.sourceBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.sourceButton = new System.Windows.Forms.Button();
            this.sourceBox = new System.Windows.Forms.TextBox();
            this.usbDrivesCheckbox = new System.Windows.Forms.CheckedListBox();
            this.usbDrivesRescan = new System.Windows.Forms.Button();
            this.optionEraseBefore = new System.Windows.Forms.CheckBox();
            this.optionSetName = new System.Windows.Forms.CheckBox();
            this.optionVolumeSetText = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.captionLabel = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.destinationDrivesLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.setupGoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // sourceBrowser
            // 
            this.sourceBrowser.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // sourceButton
            // 
            this.sourceButton.Location = new System.Drawing.Point(284, 107);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(75, 20);
            this.sourceButton.TabIndex = 1;
            this.sourceButton.Text = "Browse";
            this.sourceButton.UseVisualStyleBackColor = true;
            this.sourceButton.Click += new System.EventHandler(this.sourceButton_Click);
            // 
            // sourceBox
            // 
            this.sourceBox.Location = new System.Drawing.Point(13, 107);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(265, 20);
            this.sourceBox.TabIndex = 2;
            // 
            // usbDrivesCheckbox
            // 
            this.usbDrivesCheckbox.FormattingEnabled = true;
            this.usbDrivesCheckbox.Location = new System.Drawing.Point(12, 171);
            this.usbDrivesCheckbox.Name = "usbDrivesCheckbox";
            this.usbDrivesCheckbox.Size = new System.Drawing.Size(265, 94);
            this.usbDrivesCheckbox.TabIndex = 3;
            // 
            // usbDrivesRescan
            // 
            this.usbDrivesRescan.Location = new System.Drawing.Point(283, 171);
            this.usbDrivesRescan.Name = "usbDrivesRescan";
            this.usbDrivesRescan.Size = new System.Drawing.Size(75, 20);
            this.usbDrivesRescan.TabIndex = 1;
            this.usbDrivesRescan.Text = "Scan";
            this.usbDrivesRescan.UseVisualStyleBackColor = true;
            this.usbDrivesRescan.Click += new System.EventHandler(this.usbDrivesRescan_Click);
            // 
            // optionEraseBefore
            // 
            this.optionEraseBefore.AutoSize = true;
            this.optionEraseBefore.Location = new System.Drawing.Point(12, 298);
            this.optionEraseBefore.Name = "optionEraseBefore";
            this.optionEraseBefore.Size = new System.Drawing.Size(118, 17);
            this.optionEraseBefore.TabIndex = 4;
            this.optionEraseBefore.Text = "Erase before copy?";
            this.optionEraseBefore.UseVisualStyleBackColor = true;
            // 
            // optionSetName
            // 
            this.optionSetName.AutoSize = true;
            this.optionSetName.Location = new System.Drawing.Point(12, 322);
            this.optionSetName.Name = "optionSetName";
            this.optionSetName.Size = new System.Drawing.Size(114, 17);
            this.optionSetName.TabIndex = 5;
            this.optionSetName.Text = "Set volume name?";
            this.optionSetName.UseVisualStyleBackColor = true;
            this.optionSetName.CheckedChanged += new System.EventHandler(this.optionSetName_CheckedChanged);
            // 
            // optionVolumeSetText
            // 
            this.optionVolumeSetText.Enabled = false;
            this.optionVolumeSetText.Location = new System.Drawing.Point(133, 322);
            this.optionVolumeSetText.Name = "optionVolumeSetText";
            this.optionVolumeSetText.Size = new System.Drawing.Size(225, 20);
            this.optionVolumeSetText.TabIndex = 6;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(13, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(175, 45);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Multicopy";
            // 
            // captionLabel
            // 
            this.captionLabel.AutoSize = true;
            this.captionLabel.Location = new System.Drawing.Point(13, 62);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(246, 13);
            this.captionLabel.TabIndex = 8;
            this.captionLabel.Text = "Easily copy folder\'s contents to multiple USB drives";
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(13, 88);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(73, 13);
            this.sourceLabel.TabIndex = 9;
            this.sourceLabel.Text = "Source folder:";
            // 
            // destinationDrivesLabel
            // 
            this.destinationDrivesLabel.AutoSize = true;
            this.destinationDrivesLabel.Location = new System.Drawing.Point(12, 152);
            this.destinationDrivesLabel.Name = "destinationDrivesLabel";
            this.destinationDrivesLabel.Size = new System.Drawing.Size(94, 13);
            this.destinationDrivesLabel.TabIndex = 10;
            this.destinationDrivesLabel.Text = "Destination drives:";
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Location = new System.Drawing.Point(12, 279);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(46, 13);
            this.optionsLabel.TabIndex = 11;
            this.optionsLabel.Text = "Options:";
            // 
            // setupGoButton
            // 
            this.setupGoButton.Location = new System.Drawing.Point(12, 389);
            this.setupGoButton.Name = "setupGoButton";
            this.setupGoButton.Size = new System.Drawing.Size(346, 42);
            this.setupGoButton.TabIndex = 12;
            this.setupGoButton.Text = "Go";
            this.setupGoButton.UseVisualStyleBackColor = true;
            this.setupGoButton.Click += new System.EventHandler(this.setupGoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Robert Phipps 2016";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(323, 362);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 443);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setupGoButton);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.destinationDrivesLabel);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.captionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.optionVolumeSetText);
            this.Controls.Add(this.optionSetName);
            this.Controls.Add(this.optionEraseBefore);
            this.Controls.Add(this.usbDrivesCheckbox);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.usbDrivesRescan);
            this.Controls.Add(this.sourceButton);
            this.Name = "Setup";
            this.Text = "Multicopy - Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog sourceBrowser;
        private System.Windows.Forms.Button sourceButton;
        private System.Windows.Forms.TextBox sourceBox;
        private System.Windows.Forms.CheckedListBox usbDrivesCheckbox;
        private System.Windows.Forms.Button usbDrivesRescan;
        private System.Windows.Forms.CheckBox optionEraseBefore;
        private System.Windows.Forms.CheckBox optionSetName;
        private System.Windows.Forms.TextBox optionVolumeSetText;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label destinationDrivesLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Button setupGoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


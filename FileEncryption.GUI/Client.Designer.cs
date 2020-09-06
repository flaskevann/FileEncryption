namespace FileEncryption.GUI
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.decryptLabel = new System.Windows.Forms.Label();
            this.encryptLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptButton = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox1 = new System.Windows.Forms.TextBox();
            this.passwordBox2 = new System.Windows.Forms.TextBox();
            this.setupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.processBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.setupBox.SuspendLayout();
            this.processBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // decryptLabel
            // 
            this.decryptLabel.AllowDrop = true;
            this.decryptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decryptLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.decryptLabel.Location = new System.Drawing.Point(222, 65);
            this.decryptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decryptLabel.Name = "decryptLabel";
            this.decryptLabel.Size = new System.Drawing.Size(184, 168);
            this.decryptLabel.TabIndex = 6;
            this.decryptLabel.Text = "Drag and drop here";
            this.decryptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.decryptLabel.Click += new System.EventHandler(this.controlDecrypt_Click);
            this.decryptLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDecrypt_DragDrop);
            this.decryptLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_DragEnter);
            // 
            // encryptLabel
            // 
            this.encryptLabel.AllowDrop = true;
            this.encryptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encryptLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.encryptLabel.Location = new System.Drawing.Point(23, 65);
            this.encryptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encryptLabel.Name = "encryptLabel";
            this.encryptLabel.Size = new System.Drawing.Size(179, 168);
            this.encryptLabel.TabIndex = 7;
            this.encryptLabel.Text = "Drag and drop here";
            this.encryptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.encryptLabel.Click += new System.EventHandler(this.controlEncrypt_Click);
            this.encryptLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelEncrypt_DragDrop);
            this.encryptLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_DragEnter);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(222, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Decrypt :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptButton,
            this.decryptButton});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.aboutToolStripMenuItem1.Text = "File";
            // 
            // encryptButton
            // 
            this.encryptButton.Enabled = false;
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(148, 22);
            this.encryptButton.Text = "Encrypt files ..";
            this.encryptButton.Click += new System.EventHandler(this.controlEncrypt_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Enabled = false;
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(148, 22);
            this.decryptButton.Text = "Decrypt files ..";
            this.decryptButton.Click += new System.EventHandler(this.controlDecrypt_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.userManualToolStripMenuItem.Text = "User manual (online)";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.userManualToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Encryption password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Confirm password :";
            // 
            // passwordBox1
            // 
            this.passwordBox1.Location = new System.Drawing.Point(136, 22);
            this.passwordBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordBox1.MaxLength = 1000;
            this.passwordBox1.Name = "passwordBox1";
            this.passwordBox1.Size = new System.Drawing.Size(269, 23);
            this.passwordBox1.TabIndex = 13;
            this.passwordBox1.UseSystemPasswordChar = true;
            this.passwordBox1.TextChanged += new System.EventHandler(this.passwordBox1_TextChanged);
            // 
            // passwordBox2
            // 
            this.passwordBox2.Location = new System.Drawing.Point(136, 51);
            this.passwordBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.Size = new System.Drawing.Size(269, 23);
            this.passwordBox2.TabIndex = 15;
            this.passwordBox2.UseSystemPasswordChar = true;
            this.passwordBox2.TextChanged += new System.EventHandler(this.passwordBox2_TextChanged);
            // 
            // setupBox
            // 
            this.setupBox.Controls.Add(this.label9);
            this.setupBox.Controls.Add(this.label2);
            this.setupBox.Controls.Add(this.passwordBox2);
            this.setupBox.Controls.Add(this.label1);
            this.setupBox.Controls.Add(this.passwordBox1);
            this.setupBox.Location = new System.Drawing.Point(14, 42);
            this.setupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.setupBox.Name = "setupBox";
            this.setupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.setupBox.Size = new System.Drawing.Size(426, 122);
            this.setupBox.TabIndex = 16;
            this.setupBox.TabStop = false;
            this.setupBox.Text = "Settings";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(136, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 30);
            this.label9.TabIndex = 101;
            this.label9.Text = "Note :  Lost password = undecryptable file data\r\n             So write it down an" +
    "d keep it safe!";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processBox
            // 
            this.processBox.Controls.Add(this.decryptLabel);
            this.processBox.Controls.Add(this.encryptLabel);
            this.processBox.Controls.Add(this.label3);
            this.processBox.Controls.Add(this.label4);
            this.processBox.Enabled = false;
            this.processBox.Location = new System.Drawing.Point(14, 171);
            this.processBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.processBox.Name = "processBox";
            this.processBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.processBox.Size = new System.Drawing.Size(426, 257);
            this.processBox.TabIndex = 17;
            this.processBox.TabStop = false;
            this.processBox.Text = "Process files";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Encrypt :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 444);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(454, 22);
            this.statusStrip.TabIndex = 18;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 466);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.setupBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.processBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 505);
            this.MinimumSize = new System.Drawing.Size(470, 505);
            this.Name = "Client";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Encryption";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.setupBox.ResumeLayout(false);
            this.setupBox.PerformLayout();
            this.processBox.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label decryptLabel;
        private System.Windows.Forms.Label encryptLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox1;
        private System.Windows.Forms.TextBox passwordBox2;
        private System.Windows.Forms.GroupBox setupBox;
        private System.Windows.Forms.GroupBox processBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem encryptButton;
        private System.Windows.Forms.ToolStripMenuItem decryptButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}


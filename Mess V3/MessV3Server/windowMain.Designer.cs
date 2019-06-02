﻿namespace MessV3Server {
    partial class windowMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowMain));
            this.tableLayoutMessagesMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupLog = new System.Windows.Forms.GroupBox();
            this.lblLog = new System.Windows.Forms.RichTextBox();
            this.groupOnlineUsers = new System.Windows.Forms.GroupBox();
            this.listOnlineUsers = new System.Windows.Forms.ListBox();
            this.tableLayoutSettings = new System.Windows.Forms.TableLayoutPanel();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.numServerPort = new System.Windows.Forms.NumericUpDown();
            this.btnResetServerPort = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOnlineUsers = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutMessagesMain.SuspendLayout();
            this.groupLog.SuspendLayout();
            this.groupOnlineUsers.SuspendLayout();
            this.tableLayoutSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabOnlineUsers.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMessagesMain
            // 
            this.tableLayoutMessagesMain.ColumnCount = 2;
            this.tableLayoutMessagesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutMessagesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutMessagesMain.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutMessagesMain.Controls.Add(this.groupLog, 0, 0);
            this.tableLayoutMessagesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMessagesMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMessagesMain.Name = "tableLayoutMessagesMain";
            this.tableLayoutMessagesMain.RowCount = 2;
            this.tableLayoutMessagesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutMessagesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutMessagesMain.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutMessagesMain.TabIndex = 5;
            // 
            // groupLog
            // 
            this.groupLog.Controls.Add(this.lblLog);
            this.groupLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLog.Location = new System.Drawing.Point(3, 3);
            this.groupLog.Name = "groupLog";
            this.groupLog.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutMessagesMain.SetRowSpan(this.groupLog, 2);
            this.groupLog.Size = new System.Drawing.Size(542, 555);
            this.groupLog.TabIndex = 0;
            this.groupLog.TabStop = false;
            this.groupLog.Text = "Server Log";
            // 
            // lblLog
            // 
            this.lblLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLog.Location = new System.Drawing.Point(10, 23);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(522, 522);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "";
            // 
            // groupOnlineUsers
            // 
            this.groupOnlineUsers.Controls.Add(this.listOnlineUsers);
            this.groupOnlineUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupOnlineUsers.Location = new System.Drawing.Point(3, 3);
            this.groupOnlineUsers.Name = "groupOnlineUsers";
            this.groupOnlineUsers.Size = new System.Drawing.Size(216, 523);
            this.groupOnlineUsers.TabIndex = 1;
            this.groupOnlineUsers.TabStop = false;
            this.groupOnlineUsers.Text = "Online Users";
            // 
            // listOnlineUsers
            // 
            this.listOnlineUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOnlineUsers.FormattingEnabled = true;
            this.listOnlineUsers.Location = new System.Drawing.Point(3, 16);
            this.listOnlineUsers.Name = "listOnlineUsers";
            this.listOnlineUsers.Size = new System.Drawing.Size(210, 504);
            this.listOnlineUsers.TabIndex = 3;
            // 
            // tableLayoutSettings
            // 
            this.tableLayoutSettings.ColumnCount = 2;
            this.tableLayoutSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutSettings.Controls.Add(this.lblServerPort, 0, 0);
            this.tableLayoutSettings.Controls.Add(this.numServerPort, 0, 1);
            this.tableLayoutSettings.Controls.Add(this.btnResetServerPort, 1, 0);
            this.tableLayoutSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutSettings.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutSettings.Name = "tableLayoutSettings";
            this.tableLayoutSettings.RowCount = 2;
            this.tableLayoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutSettings.Size = new System.Drawing.Size(216, 84);
            this.tableLayoutSettings.TabIndex = 2;
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServerPort.Location = new System.Drawing.Point(3, 0);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(102, 42);
            this.lblServerPort.TabIndex = 0;
            this.lblServerPort.Text = "Server Listen Port";
            this.lblServerPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numServerPort
            // 
            this.tableLayoutSettings.SetColumnSpan(this.numServerPort, 2);
            this.numServerPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numServerPort.Location = new System.Drawing.Point(3, 45);
            this.numServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numServerPort.Name = "numServerPort";
            this.numServerPort.Size = new System.Drawing.Size(210, 20);
            this.numServerPort.TabIndex = 1;
            this.numServerPort.ValueChanged += new System.EventHandler(this.numServerPort_ValueChanged);
            // 
            // btnResetServerPort
            // 
            this.btnResetServerPort.AutoSize = true;
            this.btnResetServerPort.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnResetServerPort.Location = new System.Drawing.Point(111, 3);
            this.btnResetServerPort.Name = "btnResetServerPort";
            this.btnResetServerPort.Size = new System.Drawing.Size(102, 36);
            this.btnResetServerPort.TabIndex = 2;
            this.btnResetServerPort.Text = "Set Default";
            this.btnResetServerPort.UseVisualStyleBackColor = true;
            this.btnResetServerPort.Click += new System.EventHandler(this.btnResetServerPort_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOnlineUsers);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(551, 3);
            this.tabControl1.Name = "tabControl1";
            this.tableLayoutMessagesMain.SetRowSpan(this.tabControl1, 2);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(230, 555);
            this.tabControl1.TabIndex = 6;
            // 
            // tabOnlineUsers
            // 
            this.tabOnlineUsers.Controls.Add(this.groupOnlineUsers);
            this.tabOnlineUsers.Location = new System.Drawing.Point(4, 22);
            this.tabOnlineUsers.Name = "tabOnlineUsers";
            this.tabOnlineUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabOnlineUsers.Size = new System.Drawing.Size(222, 529);
            this.tabOnlineUsers.TabIndex = 0;
            this.tabOnlineUsers.Text = "Online Users";
            this.tabOnlineUsers.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tableLayoutSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(222, 529);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // windowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutMessagesMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "windowMain";
            this.Text = "Mess V3 Server";
            this.Load += new System.EventHandler(this.windowMain_Load);
            this.tableLayoutMessagesMain.ResumeLayout(false);
            this.groupLog.ResumeLayout(false);
            this.groupOnlineUsers.ResumeLayout(false);
            this.tableLayoutSettings.ResumeLayout(false);
            this.tableLayoutSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabOnlineUsers.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMessagesMain;
        private System.Windows.Forms.GroupBox groupLog;
        private System.Windows.Forms.GroupBox groupOnlineUsers;
        private System.Windows.Forms.ListBox listOnlineUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutSettings;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.NumericUpDown numServerPort;
        private System.Windows.Forms.RichTextBox lblLog;
        private System.Windows.Forms.Button btnResetServerPort;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOnlineUsers;
        private System.Windows.Forms.TabPage tabSettings;
    }
}


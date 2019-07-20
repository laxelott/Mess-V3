namespace MessV3Server {
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabOnlineUsers = new System.Windows.Forms.TabPage();
            this.groupOnlineUsers = new System.Windows.Forms.GroupBox();
            this.listOnlineUsers = new System.Windows.Forms.ListBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutSettings = new System.Windows.Forms.TableLayoutPanel();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.numServerPort = new System.Windows.Forms.NumericUpDown();
            this.btnResetServerPort = new System.Windows.Forms.Button();
            this.groupLog = new System.Windows.Forms.GroupBox();
            this.lblLog = new System.Windows.Forms.RichTextBox();
            this.groupUserControls = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnLockDownServer = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.tableLayoutMessagesMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabOnlineUsers.SuspendLayout();
            this.groupOnlineUsers.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tableLayoutSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).BeginInit();
            this.groupLog.SuspendLayout();
            this.groupUserControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMessagesMain
            // 
            this.tableLayoutMessagesMain.ColumnCount = 2;
            this.tableLayoutMessagesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutMessagesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutMessagesMain.Controls.Add(this.tabControlMain, 1, 0);
            this.tableLayoutMessagesMain.Controls.Add(this.groupLog, 0, 0);
            this.tableLayoutMessagesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMessagesMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMessagesMain.Name = "tableLayoutMessagesMain";
            this.tableLayoutMessagesMain.RowCount = 2;
            this.tableLayoutMessagesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutMessagesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutMessagesMain.Size = new System.Drawing.Size(811, 465);
            this.tableLayoutMessagesMain.TabIndex = 5;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabOnlineUsers);
            this.tabControlMain.Controls.Add(this.tabSettings);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(570, 3);
            this.tabControlMain.Name = "tabControlMain";
            this.tableLayoutMessagesMain.SetRowSpan(this.tabControlMain, 2);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(238, 459);
            this.tabControlMain.TabIndex = 6;
            // 
            // tabOnlineUsers
            // 
            this.tabOnlineUsers.Controls.Add(this.tableLayoutPanel1);
            this.tabOnlineUsers.Location = new System.Drawing.Point(4, 22);
            this.tabOnlineUsers.Name = "tabOnlineUsers";
            this.tabOnlineUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabOnlineUsers.Size = new System.Drawing.Size(230, 433);
            this.tabOnlineUsers.TabIndex = 0;
            this.tabOnlineUsers.Text = "Users";
            this.tabOnlineUsers.UseVisualStyleBackColor = true;
            // 
            // groupOnlineUsers
            // 
            this.groupOnlineUsers.Controls.Add(this.listOnlineUsers);
            this.groupOnlineUsers.Location = new System.Drawing.Point(3, 88);
            this.groupOnlineUsers.Name = "groupOnlineUsers";
            this.groupOnlineUsers.Size = new System.Drawing.Size(216, 336);
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
            this.listOnlineUsers.Size = new System.Drawing.Size(210, 317);
            this.listOnlineUsers.TabIndex = 3;
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
            // groupLog
            // 
            this.groupLog.Controls.Add(this.lblLog);
            this.groupLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLog.Location = new System.Drawing.Point(3, 3);
            this.groupLog.Name = "groupLog";
            this.groupLog.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutMessagesMain.SetRowSpan(this.groupLog, 2);
            this.groupLog.Size = new System.Drawing.Size(561, 459);
            this.groupLog.TabIndex = 0;
            this.groupLog.TabStop = false;
            this.groupLog.Text = "Server Log";
            // 
            // lblLog
            // 
            this.lblLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLog.Location = new System.Drawing.Point(10, 23);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(541, 426);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "";
            // 
            // groupUserControls
            // 
            this.groupUserControls.Controls.Add(this.tableLayoutPanel2);
            this.groupUserControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupUserControls.Location = new System.Drawing.Point(3, 3);
            this.groupUserControls.Name = "groupUserControls";
            this.groupUserControls.Size = new System.Drawing.Size(218, 79);
            this.groupUserControls.TabIndex = 4;
            this.groupUserControls.TabStop = false;
            this.groupUserControls.Text = "User Controls";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupOnlineUsers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupUserControls, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 427);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteUser, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnMute, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnLockDownServer, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(212, 60);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnMute
            // 
            this.btnMute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMute.Location = new System.Drawing.Point(3, 33);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(100, 24);
            this.btnMute.TabIndex = 0;
            this.btnMute.Text = "Mute User";
            this.btnMute.UseVisualStyleBackColor = true;
            // 
            // btnLockDownServer
            // 
            this.btnLockDownServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLockDownServer.Location = new System.Drawing.Point(3, 3);
            this.btnLockDownServer.Name = "btnLockDownServer";
            this.btnLockDownServer.Size = new System.Drawing.Size(100, 24);
            this.btnLockDownServer.TabIndex = 1;
            this.btnLockDownServer.Text = "Lock Server";
            this.btnLockDownServer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(109, 33);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 24);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // windowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(811, 465);
            this.Controls.Add(this.tableLayoutMessagesMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "windowMain";
            this.Text = "Mess V3 Server";
            this.Load += new System.EventHandler(this.windowMain_Load);
            this.tableLayoutMessagesMain.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabOnlineUsers.ResumeLayout(false);
            this.groupOnlineUsers.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tableLayoutSettings.ResumeLayout(false);
            this.tableLayoutSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).EndInit();
            this.groupLog.ResumeLayout(false);
            this.groupUserControls.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabOnlineUsers;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupUserControls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnLockDownServer;
    }
}


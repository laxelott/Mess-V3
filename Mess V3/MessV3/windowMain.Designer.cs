namespace MessV3
{
    partial class windowMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowMain));
			this.groupMessages = new System.Windows.Forms.GroupBox();
			this.tableMessages = new System.Windows.Forms.TableLayoutPanel();
			this.txtMessage = new System.Windows.Forms.RichTextBox();
			this.listOnlineUsers = new System.Windows.Forms.ListBox();
			this.tableLayoutMessagesMain = new System.Windows.Forms.TableLayoutPanel();
			this.lblMessagingLoggedinName = new System.Windows.Forms.Label();
			this.btnSendMessage = new System.Windows.Forms.Button();
			this.groupOnlineUsers = new System.Windows.Forms.GroupBox();
			this.lblMessageTitle = new System.Windows.Forms.Label();
			this.menuStripSend = new System.Windows.Forms.MenuStrip();
			this.menuStripItemSendMain = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStripItemSendImage = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStripItemSendFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabMessaging = new System.Windows.Forms.TabPage();
			this.tabLogin = new System.Windows.Forms.TabPage();
			this.lblLoginLoggedinName = new System.Windows.Forms.Label();
			this.tableLayoutLoginMain = new System.Windows.Forms.TableLayoutPanel();
			this.chkLoginRegistration = new System.Windows.Forms.CheckBox();
			this.groupBoxLogin = new System.Windows.Forms.GroupBox();
			this.tableLayoutLoginDetails = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutUsername = new System.Windows.Forms.TableLayoutPanel();
			this.txtLoginUsername = new System.Windows.Forms.TextBox();
			this.lblLoginUsername = new System.Windows.Forms.Label();
			this.tableLayoutDisplayName = new System.Windows.Forms.TableLayoutPanel();
			this.txtLoginDisplayName = new System.Windows.Forms.TextBox();
			this.lblLoginDisplayName = new System.Windows.Forms.Label();
			this.tableLayoutPassword = new System.Windows.Forms.TableLayoutPanel();
			this.txtLoginPassword = new System.Windows.Forms.TextBox();
			this.lblLoginPassword = new System.Windows.Forms.Label();
			this.tableLayoutPassword2 = new System.Windows.Forms.TableLayoutPanel();
			this.txtLoginPassword2 = new System.Windows.Forms.TextBox();
			this.lblLoginPassword2 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.tabSettings = new System.Windows.Forms.TabPage();
			this.groupBoxUserSettings = new System.Windows.Forms.GroupBox();
			this.tableLayoutUserSettings = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSettingsDisplayName = new System.Windows.Forms.TextBox();
			this.btnSettingsDisplayNameSave = new System.Windows.Forms.Button();
			this.groupBoxAppSettings = new System.Windows.Forms.GroupBox();
			this.tableLayoutAppSettings = new System.Windows.Forms.TableLayoutPanel();
			this.chkSettingsSound = new System.Windows.Forms.CheckBox();
			this.groupBoxServerSettings = new System.Windows.Forms.GroupBox();
			this.tableLayoutServerSettings = new System.Windows.Forms.TableLayoutPanel();
			this.numSettingsPort = new System.Windows.Forms.NumericUpDown();
			this.btnSettingsRecievePortDefault = new System.Windows.Forms.Button();
			this.lblSettingsRecievePort = new System.Windows.Forms.Label();
			this.txtSettingsServerLocation = new System.Windows.Forms.TextBox();
			this.btnSettingsSave = new System.Windows.Forms.Button();
			this.lblSettingsServerLocation = new System.Windows.Forms.Label();
			this.imageListTabs = new System.Windows.Forms.ImageList(this.components);
			this.btnConnect = new System.Windows.Forms.Button();
			this.lblInfo = new System.Windows.Forms.Label();
			this.tableLayoutInfo = new System.Windows.Forms.TableLayoutPanel();
			this.groupMessages.SuspendLayout();
			this.tableLayoutMessagesMain.SuspendLayout();
			this.groupOnlineUsers.SuspendLayout();
			this.menuStripSend.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabMessaging.SuspendLayout();
			this.tabLogin.SuspendLayout();
			this.tableLayoutLoginMain.SuspendLayout();
			this.groupBoxLogin.SuspendLayout();
			this.tableLayoutLoginDetails.SuspendLayout();
			this.tableLayoutUsername.SuspendLayout();
			this.tableLayoutDisplayName.SuspendLayout();
			this.tableLayoutPassword.SuspendLayout();
			this.tableLayoutPassword2.SuspendLayout();
			this.tabSettings.SuspendLayout();
			this.groupBoxUserSettings.SuspendLayout();
			this.tableLayoutUserSettings.SuspendLayout();
			this.groupBoxAppSettings.SuspendLayout();
			this.tableLayoutAppSettings.SuspendLayout();
			this.groupBoxServerSettings.SuspendLayout();
			this.tableLayoutServerSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSettingsPort)).BeginInit();
			this.tableLayoutInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupMessages
			// 
			this.groupMessages.Controls.Add(this.tableMessages);
			this.groupMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupMessages.Location = new System.Drawing.Point(3, 25);
			this.groupMessages.Name = "groupMessages";
			this.groupMessages.Size = new System.Drawing.Size(519, 287);
			this.groupMessages.TabIndex = 0;
			this.groupMessages.TabStop = false;
			this.groupMessages.Text = "Messages";
			// 
			// tableMessages
			// 
			this.tableMessages.AutoSize = true;
			this.tableMessages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableMessages.BackColor = System.Drawing.Color.Silver;
			this.tableMessages.ColumnCount = 1;
			this.tableMessages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableMessages.Location = new System.Drawing.Point(3, 16);
			this.tableMessages.Margin = new System.Windows.Forms.Padding(0);
			this.tableMessages.MinimumSize = new System.Drawing.Size(100, 100);
			this.tableMessages.Name = "tableMessages";
			this.tableMessages.RowCount = 1;
			this.tableMessages.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMessages.Size = new System.Drawing.Size(513, 268);
			this.tableMessages.TabIndex = 0;
			// 
			// txtMessage
			// 
			this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMessage.Location = new System.Drawing.Point(3, 340);
			this.txtMessage.Name = "txtMessage";
			this.tableLayoutMessagesMain.SetRowSpan(this.txtMessage, 2);
			this.txtMessage.Size = new System.Drawing.Size(519, 86);
			this.txtMessage.TabIndex = 1;
			this.txtMessage.Text = "";
			this.txtMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessage_KeyPress);
			// 
			// listOnlineUsers
			// 
			this.listOnlineUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listOnlineUsers.FormattingEnabled = true;
			this.listOnlineUsers.Location = new System.Drawing.Point(3, 16);
			this.listOnlineUsers.Name = "listOnlineUsers";
			this.listOnlineUsers.Size = new System.Drawing.Size(213, 312);
			this.listOnlineUsers.TabIndex = 3;
			// 
			// tableLayoutMessagesMain
			// 
			this.tableLayoutMessagesMain.ColumnCount = 2;
			this.tableLayoutMessagesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutMessagesMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutMessagesMain.Controls.Add(this.lblMessagingLoggedinName, 0, 0);
			this.tableLayoutMessagesMain.Controls.Add(this.btnSendMessage, 1, 4);
			this.tableLayoutMessagesMain.Controls.Add(this.txtMessage, 0, 3);
			this.tableLayoutMessagesMain.Controls.Add(this.groupMessages, 0, 1);
			this.tableLayoutMessagesMain.Controls.Add(this.groupOnlineUsers, 1, 0);
			this.tableLayoutMessagesMain.Controls.Add(this.lblMessageTitle, 0, 2);
			this.tableLayoutMessagesMain.Controls.Add(this.menuStripSend, 1, 3);
			this.tableLayoutMessagesMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutMessagesMain.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutMessagesMain.Name = "tableLayoutMessagesMain";
			this.tableLayoutMessagesMain.RowCount = 5;
			this.tableLayoutMessagesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
			this.tableLayoutMessagesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.42105F));
			this.tableLayoutMessagesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
			this.tableLayoutMessagesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
			this.tableLayoutMessagesMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
			this.tableLayoutMessagesMain.Size = new System.Drawing.Size(750, 429);
			this.tableLayoutMessagesMain.TabIndex = 4;
			// 
			// lblMessagingLoggedinName
			// 
			this.lblMessagingLoggedinName.AutoSize = true;
			this.lblMessagingLoggedinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessagingLoggedinName.Location = new System.Drawing.Point(3, 0);
			this.lblMessagingLoggedinName.Name = "lblMessagingLoggedinName";
			this.lblMessagingLoggedinName.Size = new System.Drawing.Size(101, 16);
			this.lblMessagingLoggedinName.TabIndex = 4;
			this.lblMessagingLoggedinName.Text = "Not logged in";
			// 
			// btnSendMessage
			// 
			this.btnSendMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSendMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnSendMessage.Image")));
			this.btnSendMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSendMessage.Location = new System.Drawing.Point(528, 385);
			this.btnSendMessage.Name = "btnSendMessage";
			this.btnSendMessage.Size = new System.Drawing.Size(219, 41);
			this.btnSendMessage.TabIndex = 2;
			this.btnSendMessage.Text = "Send Message";
			this.btnSendMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSendMessage.UseVisualStyleBackColor = true;
			this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
			// 
			// groupOnlineUsers
			// 
			this.groupOnlineUsers.Controls.Add(this.listOnlineUsers);
			this.groupOnlineUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupOnlineUsers.Location = new System.Drawing.Point(528, 3);
			this.groupOnlineUsers.Name = "groupOnlineUsers";
			this.tableLayoutMessagesMain.SetRowSpan(this.groupOnlineUsers, 3);
			this.groupOnlineUsers.Size = new System.Drawing.Size(219, 331);
			this.groupOnlineUsers.TabIndex = 1;
			this.groupOnlineUsers.TabStop = false;
			this.groupOnlineUsers.Text = "Online Users";
			// 
			// lblMessageTitle
			// 
			this.lblMessageTitle.AutoSize = true;
			this.lblMessageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMessageTitle.Location = new System.Drawing.Point(3, 315);
			this.lblMessageTitle.Name = "lblMessageTitle";
			this.lblMessageTitle.Size = new System.Drawing.Size(519, 22);
			this.lblMessageTitle.TabIndex = 3;
			this.lblMessageTitle.Text = "Message";
			this.lblMessageTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// menuStripSend
			// 
			this.menuStripSend.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menuStripSend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemSendMain});
			this.menuStripSend.Location = new System.Drawing.Point(525, 337);
			this.menuStripSend.Name = "menuStripSend";
			this.menuStripSend.Size = new System.Drawing.Size(225, 45);
			this.menuStripSend.TabIndex = 5;
			this.menuStripSend.Text = "menuStrip1";
			// 
			// menuStripItemSendMain
			// 
			this.menuStripItemSendMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemSendImage,
            this.menuStripItemSendFile});
			this.menuStripItemSendMain.Name = "menuStripItemSendMain";
			this.menuStripItemSendMain.Size = new System.Drawing.Size(106, 41);
			this.menuStripItemSendMain.Text = "Send Something";
			this.menuStripItemSendMain.Visible = false;
			// 
			// menuStripItemSendImage
			// 
			this.menuStripItemSendImage.Name = "menuStripItemSendImage";
			this.menuStripItemSendImage.Size = new System.Drawing.Size(152, 22);
			this.menuStripItemSendImage.Text = "Send an Image";
			this.menuStripItemSendImage.Click += new System.EventHandler(this.menuStripItemSendImage_Click);
			// 
			// menuStripItemSendFile
			// 
			this.menuStripItemSendFile.Name = "menuStripItemSendFile";
			this.menuStripItemSendFile.Size = new System.Drawing.Size(152, 22);
			this.menuStripItemSendFile.Text = "Send a File";
			this.menuStripItemSendFile.Click += new System.EventHandler(this.menuStripItemSendFile_Click);
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabMessaging);
			this.tabControlMain.Controls.Add(this.tabLogin);
			this.tabControlMain.Controls.Add(this.tabSettings);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.ImageList = this.imageListTabs;
			this.tabControlMain.Location = new System.Drawing.Point(10, 39);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(764, 462);
			this.tabControlMain.TabIndex = 7;
			this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
			// 
			// tabMessaging
			// 
			this.tabMessaging.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabMessaging.Controls.Add(this.tableLayoutMessagesMain);
			this.tabMessaging.ImageIndex = 0;
			this.tabMessaging.Location = new System.Drawing.Point(4, 23);
			this.tabMessaging.Name = "tabMessaging";
			this.tabMessaging.Padding = new System.Windows.Forms.Padding(3);
			this.tabMessaging.Size = new System.Drawing.Size(756, 435);
			this.tabMessaging.TabIndex = 0;
			this.tabMessaging.Text = "Messaging";
			// 
			// tabLogin
			// 
			this.tabLogin.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabLogin.Controls.Add(this.lblLoginLoggedinName);
			this.tabLogin.Controls.Add(this.tableLayoutLoginMain);
			this.tabLogin.ImageIndex = 1;
			this.tabLogin.Location = new System.Drawing.Point(4, 23);
			this.tabLogin.Name = "tabLogin";
			this.tabLogin.Padding = new System.Windows.Forms.Padding(15);
			this.tabLogin.Size = new System.Drawing.Size(756, 435);
			this.tabLogin.TabIndex = 2;
			this.tabLogin.Text = "Login / Registration";
			// 
			// lblLoginLoggedinName
			// 
			this.lblLoginLoggedinName.AutoSize = true;
			this.lblLoginLoggedinName.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblLoginLoggedinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoginLoggedinName.Location = new System.Drawing.Point(15, 15);
			this.lblLoginLoggedinName.Name = "lblLoginLoggedinName";
			this.lblLoginLoggedinName.Size = new System.Drawing.Size(101, 16);
			this.lblLoginLoggedinName.TabIndex = 3;
			this.lblLoginLoggedinName.Text = "Not logged in";
			// 
			// tableLayoutLoginMain
			// 
			this.tableLayoutLoginMain.AutoSize = true;
			this.tableLayoutLoginMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutLoginMain.ColumnCount = 1;
			this.tableLayoutLoginMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutLoginMain.Controls.Add(this.chkLoginRegistration, 0, 1);
			this.tableLayoutLoginMain.Controls.Add(this.groupBoxLogin, 0, 0);
			this.tableLayoutLoginMain.Location = new System.Drawing.Point(230, 92);
			this.tableLayoutLoginMain.Name = "tableLayoutLoginMain";
			this.tableLayoutLoginMain.RowCount = 2;
			this.tableLayoutLoginMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.tableLayoutLoginMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutLoginMain.Size = new System.Drawing.Size(296, 250);
			this.tableLayoutLoginMain.TabIndex = 2;
			// 
			// chkLoginRegistration
			// 
			this.chkLoginRegistration.AutoSize = true;
			this.chkLoginRegistration.Location = new System.Drawing.Point(3, 228);
			this.chkLoginRegistration.Name = "chkLoginRegistration";
			this.chkLoginRegistration.Size = new System.Drawing.Size(88, 17);
			this.chkLoginRegistration.TabIndex = 2;
			this.chkLoginRegistration.Text = "Registration?";
			this.chkLoginRegistration.UseVisualStyleBackColor = true;
			this.chkLoginRegistration.CheckedChanged += new System.EventHandler(this.chkLoginRegistration_CheckedChanged);
			// 
			// groupBoxLogin
			// 
			this.groupBoxLogin.AutoSize = true;
			this.groupBoxLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBoxLogin.Controls.Add(this.tableLayoutLoginDetails);
			this.groupBoxLogin.Location = new System.Drawing.Point(3, 3);
			this.groupBoxLogin.Name = "groupBoxLogin";
			this.groupBoxLogin.Size = new System.Drawing.Size(290, 219);
			this.groupBoxLogin.TabIndex = 1;
			this.groupBoxLogin.TabStop = false;
			this.groupBoxLogin.Text = "Login";
			// 
			// tableLayoutLoginDetails
			// 
			this.tableLayoutLoginDetails.AutoSize = true;
			this.tableLayoutLoginDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutLoginDetails.ColumnCount = 1;
			this.tableLayoutLoginDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutLoginDetails.Controls.Add(this.tableLayoutUsername, 0, 0);
			this.tableLayoutLoginDetails.Controls.Add(this.tableLayoutDisplayName, 0, 1);
			this.tableLayoutLoginDetails.Controls.Add(this.tableLayoutPassword, 0, 2);
			this.tableLayoutLoginDetails.Controls.Add(this.tableLayoutPassword2, 0, 3);
			this.tableLayoutLoginDetails.Controls.Add(this.btnLogin, 0, 4);
			this.tableLayoutLoginDetails.Location = new System.Drawing.Point(15, 25);
			this.tableLayoutLoginDetails.Margin = new System.Windows.Forms.Padding(10);
			this.tableLayoutLoginDetails.Name = "tableLayoutLoginDetails";
			this.tableLayoutLoginDetails.RowCount = 5;
			this.tableLayoutLoginDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutLoginDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
			this.tableLayoutLoginDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutLoginDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
			this.tableLayoutLoginDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutLoginDetails.Size = new System.Drawing.Size(262, 168);
			this.tableLayoutLoginDetails.TabIndex = 0;
			// 
			// tableLayoutUsername
			// 
			this.tableLayoutUsername.ColumnCount = 1;
			this.tableLayoutUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutUsername.Controls.Add(this.txtLoginUsername, 0, 1);
			this.tableLayoutUsername.Controls.Add(this.lblLoginUsername, 0, 0);
			this.tableLayoutUsername.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutUsername.Name = "tableLayoutUsername";
			this.tableLayoutUsername.RowCount = 2;
			this.tableLayoutUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutUsername.Size = new System.Drawing.Size(256, 49);
			this.tableLayoutUsername.TabIndex = 3;
			// 
			// txtLoginUsername
			// 
			this.txtLoginUsername.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLoginUsername.Location = new System.Drawing.Point(3, 27);
			this.txtLoginUsername.Name = "txtLoginUsername";
			this.txtLoginUsername.Size = new System.Drawing.Size(250, 20);
			this.txtLoginUsername.TabIndex = 1;
			this.txtLoginUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
			// 
			// lblLoginUsername
			// 
			this.lblLoginUsername.AutoSize = true;
			this.lblLoginUsername.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblLoginUsername.Location = new System.Drawing.Point(3, 0);
			this.lblLoginUsername.Name = "lblLoginUsername";
			this.lblLoginUsername.Size = new System.Drawing.Size(250, 24);
			this.lblLoginUsername.TabIndex = 0;
			this.lblLoginUsername.Text = "Username";
			this.lblLoginUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// tableLayoutDisplayName
			// 
			this.tableLayoutDisplayName.ColumnCount = 1;
			this.tableLayoutDisplayName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutDisplayName.Controls.Add(this.txtLoginDisplayName, 0, 1);
			this.tableLayoutDisplayName.Controls.Add(this.lblLoginDisplayName, 0, 0);
			this.tableLayoutDisplayName.Enabled = false;
			this.tableLayoutDisplayName.Location = new System.Drawing.Point(3, 58);
			this.tableLayoutDisplayName.Name = "tableLayoutDisplayName";
			this.tableLayoutDisplayName.RowCount = 2;
			this.tableLayoutDisplayName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutDisplayName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutDisplayName.Size = new System.Drawing.Size(256, 1);
			this.tableLayoutDisplayName.TabIndex = 4;
			// 
			// txtLoginDisplayName
			// 
			this.txtLoginDisplayName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLoginDisplayName.Location = new System.Drawing.Point(3, 3);
			this.txtLoginDisplayName.Name = "txtLoginDisplayName";
			this.txtLoginDisplayName.Size = new System.Drawing.Size(250, 20);
			this.txtLoginDisplayName.TabIndex = 2;
			this.txtLoginDisplayName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
			// 
			// lblLoginDisplayName
			// 
			this.lblLoginDisplayName.AutoSize = true;
			this.lblLoginDisplayName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblLoginDisplayName.Location = new System.Drawing.Point(3, 0);
			this.lblLoginDisplayName.Name = "lblLoginDisplayName";
			this.lblLoginDisplayName.Size = new System.Drawing.Size(250, 1);
			this.lblLoginDisplayName.TabIndex = 3;
			this.lblLoginDisplayName.Text = "Display Name";
			this.lblLoginDisplayName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// tableLayoutPassword
			// 
			this.tableLayoutPassword.ColumnCount = 1;
			this.tableLayoutPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPassword.Controls.Add(this.txtLoginPassword, 0, 1);
			this.tableLayoutPassword.Controls.Add(this.lblLoginPassword, 0, 0);
			this.tableLayoutPassword.Location = new System.Drawing.Point(3, 58);
			this.tableLayoutPassword.Name = "tableLayoutPassword";
			this.tableLayoutPassword.RowCount = 2;
			this.tableLayoutPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPassword.Size = new System.Drawing.Size(256, 49);
			this.tableLayoutPassword.TabIndex = 5;
			// 
			// txtLoginPassword
			// 
			this.txtLoginPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLoginPassword.Location = new System.Drawing.Point(3, 27);
			this.txtLoginPassword.Name = "txtLoginPassword";
			this.txtLoginPassword.PasswordChar = '*';
			this.txtLoginPassword.Size = new System.Drawing.Size(250, 20);
			this.txtLoginPassword.TabIndex = 3;
			this.txtLoginPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
			// 
			// lblLoginPassword
			// 
			this.lblLoginPassword.AutoSize = true;
			this.lblLoginPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblLoginPassword.Location = new System.Drawing.Point(3, 0);
			this.lblLoginPassword.Name = "lblLoginPassword";
			this.lblLoginPassword.Size = new System.Drawing.Size(250, 24);
			this.lblLoginPassword.TabIndex = 2;
			this.lblLoginPassword.Text = "Password";
			this.lblLoginPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// tableLayoutPassword2
			// 
			this.tableLayoutPassword2.ColumnCount = 1;
			this.tableLayoutPassword2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPassword2.Controls.Add(this.txtLoginPassword2, 0, 1);
			this.tableLayoutPassword2.Controls.Add(this.lblLoginPassword2, 0, 0);
			this.tableLayoutPassword2.Enabled = false;
			this.tableLayoutPassword2.Location = new System.Drawing.Point(3, 113);
			this.tableLayoutPassword2.Name = "tableLayoutPassword2";
			this.tableLayoutPassword2.RowCount = 2;
			this.tableLayoutPassword2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPassword2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPassword2.Size = new System.Drawing.Size(256, 1);
			this.tableLayoutPassword2.TabIndex = 6;
			// 
			// txtLoginPassword2
			// 
			this.txtLoginPassword2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLoginPassword2.Location = new System.Drawing.Point(3, 3);
			this.txtLoginPassword2.Name = "txtLoginPassword2";
			this.txtLoginPassword2.PasswordChar = '*';
			this.txtLoginPassword2.Size = new System.Drawing.Size(250, 20);
			this.txtLoginPassword2.TabIndex = 4;
			this.txtLoginPassword2.TextChanged += new System.EventHandler(this.txtLoginPassword2_TextChanged);
			this.txtLoginPassword2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
			// 
			// lblLoginPassword2
			// 
			this.lblLoginPassword2.AutoSize = true;
			this.lblLoginPassword2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblLoginPassword2.Location = new System.Drawing.Point(3, 0);
			this.lblLoginPassword2.Name = "lblLoginPassword2";
			this.lblLoginPassword2.Size = new System.Drawing.Size(250, 1);
			this.lblLoginPassword2.TabIndex = 2;
			this.lblLoginPassword2.Text = "Password Again";
			this.lblLoginPassword2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnLogin
			// 
			this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Image = global::MessV3.Properties.Resources.key_32;
			this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLogin.Location = new System.Drawing.Point(3, 113);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(256, 50);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// tabSettings
			// 
			this.tabSettings.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.tabSettings.Controls.Add(this.groupBoxUserSettings);
			this.tabSettings.Controls.Add(this.groupBoxAppSettings);
			this.tabSettings.Controls.Add(this.groupBoxServerSettings);
			this.tabSettings.ImageIndex = 2;
			this.tabSettings.Location = new System.Drawing.Point(4, 23);
			this.tabSettings.Name = "tabSettings";
			this.tabSettings.Padding = new System.Windows.Forms.Padding(30);
			this.tabSettings.Size = new System.Drawing.Size(756, 435);
			this.tabSettings.TabIndex = 1;
			this.tabSettings.Text = "Settings";
			// 
			// groupBoxUserSettings
			// 
			this.groupBoxUserSettings.AutoSize = true;
			this.groupBoxUserSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBoxUserSettings.Controls.Add(this.tableLayoutUserSettings);
			this.groupBoxUserSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxUserSettings.Location = new System.Drawing.Point(30, 262);
			this.groupBoxUserSettings.Name = "groupBoxUserSettings";
			this.groupBoxUserSettings.Padding = new System.Windows.Forms.Padding(10);
			this.groupBoxUserSettings.Size = new System.Drawing.Size(696, 85);
			this.groupBoxUserSettings.TabIndex = 1;
			this.groupBoxUserSettings.TabStop = false;
			this.groupBoxUserSettings.Text = "User Settings";
			this.groupBoxUserSettings.Visible = false;
			// 
			// tableLayoutUserSettings
			// 
			this.tableLayoutUserSettings.AutoSize = true;
			this.tableLayoutUserSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutUserSettings.ColumnCount = 2;
			this.tableLayoutUserSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutUserSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutUserSettings.Controls.Add(this.label1, 0, 0);
			this.tableLayoutUserSettings.Controls.Add(this.txtSettingsDisplayName, 0, 1);
			this.tableLayoutUserSettings.Controls.Add(this.btnSettingsDisplayNameSave, 1, 1);
			this.tableLayoutUserSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutUserSettings.Location = new System.Drawing.Point(10, 23);
			this.tableLayoutUserSettings.Name = "tableLayoutUserSettings";
			this.tableLayoutUserSettings.RowCount = 2;
			this.tableLayoutUserSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutUserSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutUserSettings.Size = new System.Drawing.Size(676, 52);
			this.tableLayoutUserSettings.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Location = new System.Drawing.Point(3, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(467, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Display Name";
			// 
			// txtSettingsDisplayName
			// 
			this.txtSettingsDisplayName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSettingsDisplayName.Location = new System.Drawing.Point(3, 29);
			this.txtSettingsDisplayName.Name = "txtSettingsDisplayName";
			this.txtSettingsDisplayName.Size = new System.Drawing.Size(467, 20);
			this.txtSettingsDisplayName.TabIndex = 1;
			this.txtSettingsDisplayName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSettingsNameSave_KeyPress);
			// 
			// btnSettingsDisplayNameSave
			// 
			this.btnSettingsDisplayNameSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSettingsDisplayNameSave.Location = new System.Drawing.Point(476, 29);
			this.btnSettingsDisplayNameSave.Name = "btnSettingsDisplayNameSave";
			this.btnSettingsDisplayNameSave.Size = new System.Drawing.Size(197, 20);
			this.btnSettingsDisplayNameSave.TabIndex = 2;
			this.btnSettingsDisplayNameSave.Text = "Save";
			this.btnSettingsDisplayNameSave.UseVisualStyleBackColor = true;
			this.btnSettingsDisplayNameSave.Click += new System.EventHandler(this.btnSettingsNameSave_Click);
			// 
			// groupBoxAppSettings
			// 
			this.groupBoxAppSettings.AutoSize = true;
			this.groupBoxAppSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBoxAppSettings.Controls.Add(this.tableLayoutAppSettings);
			this.groupBoxAppSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxAppSettings.Location = new System.Drawing.Point(30, 206);
			this.groupBoxAppSettings.Name = "groupBoxAppSettings";
			this.groupBoxAppSettings.Padding = new System.Windows.Forms.Padding(10);
			this.groupBoxAppSettings.Size = new System.Drawing.Size(696, 56);
			this.groupBoxAppSettings.TabIndex = 2;
			this.groupBoxAppSettings.TabStop = false;
			this.groupBoxAppSettings.Text = "Application Settings";
			// 
			// tableLayoutAppSettings
			// 
			this.tableLayoutAppSettings.AutoSize = true;
			this.tableLayoutAppSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutAppSettings.ColumnCount = 2;
			this.tableLayoutAppSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutAppSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutAppSettings.Controls.Add(this.chkSettingsSound, 0, 0);
			this.tableLayoutAppSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutAppSettings.Location = new System.Drawing.Point(10, 23);
			this.tableLayoutAppSettings.Name = "tableLayoutAppSettings";
			this.tableLayoutAppSettings.RowCount = 1;
			this.tableLayoutAppSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutAppSettings.Size = new System.Drawing.Size(676, 23);
			this.tableLayoutAppSettings.TabIndex = 0;
			// 
			// chkSettingsSound
			// 
			this.chkSettingsSound.AutoSize = true;
			this.chkSettingsSound.Checked = true;
			this.chkSettingsSound.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSettingsSound.Location = new System.Drawing.Point(3, 3);
			this.chkSettingsSound.Name = "chkSettingsSound";
			this.chkSettingsSound.Size = new System.Drawing.Size(84, 17);
			this.chkSettingsSound.TabIndex = 4;
			this.chkSettingsSound.Text = "Play sound?";
			this.chkSettingsSound.UseVisualStyleBackColor = true;
			// 
			// groupBoxServerSettings
			// 
			this.groupBoxServerSettings.AutoSize = true;
			this.groupBoxServerSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBoxServerSettings.Controls.Add(this.tableLayoutServerSettings);
			this.groupBoxServerSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxServerSettings.Location = new System.Drawing.Point(30, 30);
			this.groupBoxServerSettings.Name = "groupBoxServerSettings";
			this.groupBoxServerSettings.Padding = new System.Windows.Forms.Padding(10);
			this.groupBoxServerSettings.Size = new System.Drawing.Size(696, 176);
			this.groupBoxServerSettings.TabIndex = 3;
			this.groupBoxServerSettings.TabStop = false;
			this.groupBoxServerSettings.Text = "Server Settings";
			// 
			// tableLayoutServerSettings
			// 
			this.tableLayoutServerSettings.AutoSize = true;
			this.tableLayoutServerSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutServerSettings.ColumnCount = 2;
			this.tableLayoutServerSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutServerSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutServerSettings.Controls.Add(this.numSettingsPort, 0, 3);
			this.tableLayoutServerSettings.Controls.Add(this.btnSettingsRecievePortDefault, 1, 3);
			this.tableLayoutServerSettings.Controls.Add(this.lblSettingsRecievePort, 0, 2);
			this.tableLayoutServerSettings.Controls.Add(this.txtSettingsServerLocation, 0, 1);
			this.tableLayoutServerSettings.Controls.Add(this.btnSettingsSave, 0, 4);
			this.tableLayoutServerSettings.Controls.Add(this.lblSettingsServerLocation, 0, 0);
			this.tableLayoutServerSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutServerSettings.Location = new System.Drawing.Point(10, 23);
			this.tableLayoutServerSettings.Name = "tableLayoutServerSettings";
			this.tableLayoutServerSettings.RowCount = 5;
			this.tableLayoutServerSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
			this.tableLayoutServerSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
			this.tableLayoutServerSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
			this.tableLayoutServerSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
			this.tableLayoutServerSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.68421F));
			this.tableLayoutServerSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutServerSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutServerSettings.Size = new System.Drawing.Size(676, 143);
			this.tableLayoutServerSettings.TabIndex = 0;
			// 
			// numSettingsPort
			// 
			this.numSettingsPort.AllowDrop = true;
			this.numSettingsPort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numSettingsPort.Location = new System.Drawing.Point(3, 78);
			this.numSettingsPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numSettingsPort.Name = "numSettingsPort";
			this.numSettingsPort.Size = new System.Drawing.Size(467, 20);
			this.numSettingsPort.TabIndex = 2;
			this.numSettingsPort.ValueChanged += new System.EventHandler(this.inputSettings_Changed);
			this.numSettingsPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputSettings_KeyPress);
			// 
			// btnSettingsRecievePortDefault
			// 
			this.btnSettingsRecievePortDefault.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSettingsRecievePortDefault.Location = new System.Drawing.Point(476, 78);
			this.btnSettingsRecievePortDefault.Name = "btnSettingsRecievePortDefault";
			this.btnSettingsRecievePortDefault.Size = new System.Drawing.Size(197, 19);
			this.btnSettingsRecievePortDefault.TabIndex = 4;
			this.btnSettingsRecievePortDefault.Text = "Reset Value";
			this.btnSettingsRecievePortDefault.UseVisualStyleBackColor = true;
			this.btnSettingsRecievePortDefault.Click += new System.EventHandler(this.btnSettingsRecievePortDefault_Click);
			// 
			// lblSettingsRecievePort
			// 
			this.lblSettingsRecievePort.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblSettingsRecievePort.Location = new System.Drawing.Point(3, 55);
			this.lblSettingsRecievePort.Name = "lblSettingsRecievePort";
			this.lblSettingsRecievePort.Size = new System.Drawing.Size(467, 20);
			this.lblSettingsRecievePort.TabIndex = 0;
			this.lblSettingsRecievePort.Text = "Client Port:";
			this.lblSettingsRecievePort.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// txtSettingsServerLocation
			// 
			this.txtSettingsServerLocation.AllowDrop = true;
			this.txtSettingsServerLocation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSettingsServerLocation.Location = new System.Drawing.Point(3, 28);
			this.txtSettingsServerLocation.Name = "txtSettingsServerLocation";
			this.txtSettingsServerLocation.Size = new System.Drawing.Size(467, 20);
			this.txtSettingsServerLocation.TabIndex = 1;
			this.txtSettingsServerLocation.TextChanged += new System.EventHandler(this.inputSettings_Changed);
			this.txtSettingsServerLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputSettings_KeyPress);
			// 
			// btnSettingsSave
			// 
			this.tableLayoutServerSettings.SetColumnSpan(this.btnSettingsSave, 2);
			this.btnSettingsSave.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSettingsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnSettingsSave.Location = new System.Drawing.Point(3, 103);
			this.btnSettingsSave.Name = "btnSettingsSave";
			this.btnSettingsSave.Size = new System.Drawing.Size(670, 30);
			this.btnSettingsSave.TabIndex = 6;
			this.btnSettingsSave.Text = "Save Settings";
			this.btnSettingsSave.UseVisualStyleBackColor = true;
			this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
			// 
			// lblSettingsServerLocation
			// 
			this.lblSettingsServerLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblSettingsServerLocation.Location = new System.Drawing.Point(3, 5);
			this.lblSettingsServerLocation.Name = "lblSettingsServerLocation";
			this.lblSettingsServerLocation.Size = new System.Drawing.Size(467, 20);
			this.lblSettingsServerLocation.TabIndex = 0;
			this.lblSettingsServerLocation.Text = "Server Location:";
			this.lblSettingsServerLocation.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// imageListTabs
			// 
			this.imageListTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabs.ImageStream")));
			this.imageListTabs.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListTabs.Images.SetKeyName(0, "bubble_16.png");
			this.imageListTabs.Images.SetKeyName(1, "user_16.png");
			this.imageListTabs.Images.SetKeyName(2, "gear_16.png");
			// 
			// btnConnect
			// 
			this.btnConnect.AutoSize = true;
			this.btnConnect.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnConnect.Location = new System.Drawing.Point(658, 3);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(103, 23);
			this.btnConnect.TabIndex = 9;
			this.btnConnect.Text = "Connect to Server";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblInfo.Location = new System.Drawing.Point(3, 0);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(605, 13);
			this.lblInfo.TabIndex = 10;
			this.lblInfo.Text = "Awaiting Input";
			// 
			// tableLayoutInfo
			// 
			this.tableLayoutInfo.AutoSize = true;
			this.tableLayoutInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutInfo.ColumnCount = 2;
			this.tableLayoutInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutInfo.Controls.Add(this.btnConnect, 1, 0);
			this.tableLayoutInfo.Controls.Add(this.lblInfo, 0, 0);
			this.tableLayoutInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutInfo.Location = new System.Drawing.Point(10, 10);
			this.tableLayoutInfo.Name = "tableLayoutInfo";
			this.tableLayoutInfo.RowCount = 1;
			this.tableLayoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutInfo.Size = new System.Drawing.Size(764, 29);
			this.tableLayoutInfo.TabIndex = 11;
			// 
			// windowMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 511);
			this.Controls.Add(this.tabControlMain);
			this.Controls.Add(this.tableLayoutInfo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripSend;
			this.Name = "windowMain";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Text = "Mess V3";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.windowMain_FormClosing);
			this.groupMessages.ResumeLayout(false);
			this.groupMessages.PerformLayout();
			this.tableLayoutMessagesMain.ResumeLayout(false);
			this.tableLayoutMessagesMain.PerformLayout();
			this.groupOnlineUsers.ResumeLayout(false);
			this.menuStripSend.ResumeLayout(false);
			this.menuStripSend.PerformLayout();
			this.tabControlMain.ResumeLayout(false);
			this.tabMessaging.ResumeLayout(false);
			this.tabLogin.ResumeLayout(false);
			this.tabLogin.PerformLayout();
			this.tableLayoutLoginMain.ResumeLayout(false);
			this.tableLayoutLoginMain.PerformLayout();
			this.groupBoxLogin.ResumeLayout(false);
			this.groupBoxLogin.PerformLayout();
			this.tableLayoutLoginDetails.ResumeLayout(false);
			this.tableLayoutUsername.ResumeLayout(false);
			this.tableLayoutUsername.PerformLayout();
			this.tableLayoutDisplayName.ResumeLayout(false);
			this.tableLayoutDisplayName.PerformLayout();
			this.tableLayoutPassword.ResumeLayout(false);
			this.tableLayoutPassword.PerformLayout();
			this.tableLayoutPassword2.ResumeLayout(false);
			this.tableLayoutPassword2.PerformLayout();
			this.tabSettings.ResumeLayout(false);
			this.tabSettings.PerformLayout();
			this.groupBoxUserSettings.ResumeLayout(false);
			this.groupBoxUserSettings.PerformLayout();
			this.tableLayoutUserSettings.ResumeLayout(false);
			this.tableLayoutUserSettings.PerformLayout();
			this.groupBoxAppSettings.ResumeLayout(false);
			this.groupBoxAppSettings.PerformLayout();
			this.tableLayoutAppSettings.ResumeLayout(false);
			this.tableLayoutAppSettings.PerformLayout();
			this.groupBoxServerSettings.ResumeLayout(false);
			this.groupBoxServerSettings.PerformLayout();
			this.tableLayoutServerSettings.ResumeLayout(false);
			this.tableLayoutServerSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSettingsPort)).EndInit();
			this.tableLayoutInfo.ResumeLayout(false);
			this.tableLayoutInfo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMessages;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.ListBox listOnlineUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMessagesMain;
        private System.Windows.Forms.GroupBox groupOnlineUsers;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabMessaging;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Label lblLoginDisplayName;
        private System.Windows.Forms.TextBox txtLoginDisplayName;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label lblLoginPassword2;
        private System.Windows.Forms.TextBox txtLoginPassword2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLoginMain;
        private System.Windows.Forms.CheckBox chkLoginRegistration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPassword2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutUsername;
        private System.Windows.Forms.TableLayoutPanel tableLayoutDisplayName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLoginDetails;
        private System.Windows.Forms.ImageList imageListTabs;
        private System.Windows.Forms.MenuStrip menuStripSend;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSendMain;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSendImage;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSendFile;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutInfo;
        private System.Windows.Forms.Label lblLoginLoggedinName;
        private System.Windows.Forms.Label lblMessagingLoggedinName;
        private System.Windows.Forms.GroupBox groupBoxUserSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutUserSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSettingsDisplayName;
        private System.Windows.Forms.Button btnSettingsDisplayNameSave;
        private System.Windows.Forms.GroupBox groupBoxAppSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAppSettings;
        private System.Windows.Forms.GroupBox groupBoxServerSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutServerSettings;
        private System.Windows.Forms.NumericUpDown numSettingsPort;
        private System.Windows.Forms.Button btnSettingsRecievePortDefault;
        private System.Windows.Forms.Label lblSettingsRecievePort;
        private System.Windows.Forms.TextBox txtSettingsServerLocation;
        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.Label lblSettingsServerLocation;
        private System.Windows.Forms.CheckBox chkSettingsSound;
        private System.Windows.Forms.TableLayoutPanel tableMessages;
    }
}


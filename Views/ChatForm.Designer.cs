namespace Views
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.panInfoConnection = new System.Windows.Forms.Panel();
            this.btnCon = new Guna.UI2.WinForms.Guna2Button();
            this.numPortHost = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtServerIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.PictureBox();
            this.txtmessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.paneInfo = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.Label();
            this.panInfoConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPortHost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).BeginInit();
            this.paneInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panInfoConnection
            // 
            this.panInfoConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.panInfoConnection.Controls.Add(this.btnCon);
            this.panInfoConnection.Controls.Add(this.numPortHost);
            this.panInfoConnection.Controls.Add(this.lblPort);
            this.panInfoConnection.Controls.Add(this.txtServerIP);
            this.panInfoConnection.Controls.Add(this.lblStatus);
            this.panInfoConnection.Controls.Add(this.lblUsername);
            this.panInfoConnection.Controls.Add(this.btnClose);
            this.panInfoConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panInfoConnection.Location = new System.Drawing.Point(0, 0);
            this.panInfoConnection.Name = "panInfoConnection";
            this.panInfoConnection.Size = new System.Drawing.Size(523, 62);
            this.panInfoConnection.TabIndex = 0;
            // 
            // btnCon
            // 
            this.btnCon.CheckedState.Parent = this.btnCon;
            this.btnCon.CustomImages.Parent = this.btnCon;
            this.btnCon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCon.ForeColor = System.Drawing.Color.White;
            this.btnCon.HoverState.Parent = this.btnCon;
            this.btnCon.Location = new System.Drawing.Point(150, 23);
            this.btnCon.Name = "btnCon";
            this.btnCon.ShadowDecoration.Parent = this.btnCon;
            this.btnCon.Size = new System.Drawing.Size(82, 16);
            this.btnCon.TabIndex = 10;
            this.btnCon.Text = "Connecter";
            this.btnCon.Click += new System.EventHandler(this.BtnCon_Click);
            // 
            // numPortHost
            // 
            this.numPortHost.BackColor = System.Drawing.Color.Transparent;
            this.numPortHost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numPortHost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numPortHost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numPortHost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numPortHost.DisabledState.Parent = this.numPortHost;
            this.numPortHost.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numPortHost.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numPortHost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numPortHost.FocusedState.Parent = this.numPortHost;
            this.numPortHost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPortHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numPortHost.Location = new System.Drawing.Point(92, 23);
            this.numPortHost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numPortHost.Name = "numPortHost";
            this.numPortHost.ShadowDecoration.Parent = this.numPortHost;
            this.numPortHost.Size = new System.Drawing.Size(48, 16);
            this.numPortHost.TabIndex = 9;
            this.numPortHost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Location = new System.Drawing.Point(99, 3);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(32, 17);
            this.lblPort.TabIndex = 8;
            this.lblPort.Text = "Port";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServerIP.DefaultText = "127.0.0.1";
            this.txtServerIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServerIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServerIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServerIP.DisabledState.Parent = this.txtServerIP;
            this.txtServerIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServerIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServerIP.FocusedState.Parent = this.txtServerIP;
            this.txtServerIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServerIP.HoverState.Parent = this.txtServerIP;
            this.txtServerIP.Location = new System.Drawing.Point(6, 23);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.PasswordChar = '\0';
            this.txtServerIP.PlaceholderText = "";
            this.txtServerIP.SelectedText = "";
            this.txtServerIP.SelectionStart = 9;
            this.txtServerIP.ShadowDecoration.Parent = this.txtServerIP;
            this.txtServerIP.Size = new System.Drawing.Size(73, 16);
            this.txtServerIP.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.SlateGray;
            this.lblStatus.Location = new System.Drawing.Point(253, 23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Online";
            this.lblStatus.Click += new System.EventHandler(this.LblStatus_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(3, 3);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(67, 17);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Hostname";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(493, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(6, 11);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(37, 36);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.txtmessage);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 54);
            this.panel2.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSend.Image = global::Views.Properties.Resources.icons8_telegram_app_32;
            this.btnSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSend.Location = new System.Drawing.Point(478, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(42, 41);
            this.btnSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSend.TabIndex = 7;
            this.btnSend.TabStop = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // txtmessage
            // 
            this.txtmessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmessage.BackColor = System.Drawing.Color.White;
            this.txtmessage.BorderRadius = 20;
            this.txtmessage.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.txtmessage.BorderThickness = 2;
            this.txtmessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmessage.DefaultText = "";
            this.txtmessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmessage.DisabledState.Parent = this.txtmessage;
            this.txtmessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmessage.FocusedState.Parent = this.txtmessage;
            this.txtmessage.ForeColor = System.Drawing.Color.Black;
            this.txtmessage.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.txtmessage.HoverState.Parent = this.txtmessage;
            this.txtmessage.Location = new System.Drawing.Point(3, 12);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.PasswordChar = '\0';
            this.txtmessage.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtmessage.PlaceholderText = "Entrer un message";
            this.txtmessage.SelectedText = "";
            this.txtmessage.ShadowDecoration.Parent = this.txtmessage;
            this.txtmessage.Size = new System.Drawing.Size(469, 43);
            this.txtmessage.TabIndex = 1;
            this.txtmessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtMessage_KeyUp);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(523, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // panContainer
            // 
            this.panContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panContainer.AutoScroll = true;
            this.panContainer.Location = new System.Drawing.Point(3, 130);
            this.panContainer.Name = "panContainer";
            this.panContainer.Size = new System.Drawing.Size(517, 295);
            this.panContainer.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // paneInfo
            // 
            this.paneInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.paneInfo.Controls.Add(this.status);
            this.paneInfo.Controls.Add(this.txtUser);
            this.paneInfo.Controls.Add(this.guna2CirclePictureBox1);
            this.paneInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneInfo.Location = new System.Drawing.Point(0, 62);
            this.paneInfo.Name = "paneInfo";
            this.paneInfo.Size = new System.Drawing.Size(523, 62);
            this.paneInfo.TabIndex = 7;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.SlateGray;
            this.status.Location = new System.Drawing.Point(99, 40);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(38, 13);
            this.status.TabIndex = 6;
            this.status.Text = "Online";
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(99, 11);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(67, 17);
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "Username";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 479);
            this.Controls.Add(this.paneInfo);
            this.Controls.Add(this.panContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panInfoConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Shown += new System.EventHandler(this.ChatForm_Shown);
            this.panInfoConnection.ResumeLayout(false);
            this.panInfoConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPortHost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).EndInit();
            this.paneInfo.ResumeLayout(false);
            this.paneInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panInfoConnection;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnSend;
        private Guna.UI2.WinForms.Guna2TextBox txtmessage;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panContainer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel paneInfo;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label txtUser;
        private Guna.UI2.WinForms.Guna2TextBox txtServerIP;
        private System.Windows.Forms.Label lblPort;
        private Guna.UI2.WinForms.Guna2Button btnCon;
        private Guna.UI2.WinForms.Guna2NumericUpDown numPortHost;
        private System.Windows.Forms.Label lblStatus;
    }
}
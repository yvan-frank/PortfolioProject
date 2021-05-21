namespace Views.HomeForm.HomeAdmin
{
    partial class HomeAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdministrator));
            this.panSidebar = new System.Windows.Forms.Panel();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.panContentInfoAdmin = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnDeconnexion = new Guna.UI2.WinForms.Guna2Button();
            this.btnParams = new Guna.UI2.WinForms.Guna2Button();
            this.btnSendMails = new Guna.UI2.WinForms.Guna2Button();
            this.btnGesEsMem = new Guna.UI2.WinForms.Guna2Button();
            this.btnGesProjet = new Guna.UI2.WinForms.Guna2Button();
            this.btnGestUsers = new Guna.UI2.WinForms.Guna2Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.picAdmin = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panHeader = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnFermer = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panSecondHead = new System.Windows.Forms.Panel();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblStatusButton = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panSidebar.SuspendLayout();
            this.panContentInfoAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panSecondHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSidebar
            // 
            this.panSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.panSidebar.Controls.Add(this.btnNew);
            this.panSidebar.Controls.Add(this.btnHome);
            this.panSidebar.Controls.Add(this.panContentInfoAdmin);
            this.panSidebar.Controls.Add(this.btnDeconnexion);
            this.panSidebar.Controls.Add(this.btnParams);
            this.panSidebar.Controls.Add(this.btnSendMails);
            this.panSidebar.Controls.Add(this.btnGesEsMem);
            this.panSidebar.Controls.Add(this.btnGesProjet);
            this.panSidebar.Controls.Add(this.btnGestUsers);
            this.panSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSidebar.Location = new System.Drawing.Point(0, 0);
            this.panSidebar.Name = "panSidebar";
            this.panSidebar.Size = new System.Drawing.Size(212, 550);
            this.panSidebar.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.BorderRadius = 3;
            this.btnNew.CheckedState.Parent = this.btnNew;
            this.btnNew.CustomImages.Parent = this.btnNew;
            this.btnNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(213)))));
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.HoverState.Parent = this.btnNew;
            this.btnNew.Location = new System.Drawing.Point(28, 99);
            this.btnNew.Name = "btnNew";
            this.btnNew.ShadowDecoration.Parent = this.btnNew;
            this.btnNew.Size = new System.Drawing.Size(136, 37);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nouveau";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = global::Views.Properties.Resources.icons8_home_48;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(2, 177);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(207, 45);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "    Accueil";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panContentInfoAdmin
            // 
            this.panContentInfoAdmin.Controls.Add(this.lblDate);
            this.panContentInfoAdmin.Location = new System.Drawing.Point(3, 3);
            this.panContentInfoAdmin.Name = "panContentInfoAdmin";
            this.panContentInfoAdmin.Size = new System.Drawing.Size(206, 48);
            this.panContentInfoAdmin.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblDate.Location = new System.Drawing.Point(55, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 37);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "LOGO";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnDeconnexion.CheckedState.Parent = this.btnDeconnexion;
            this.btnDeconnexion.CustomImages.Parent = this.btnDeconnexion;
            this.btnDeconnexion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnDeconnexion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.ForeColor = System.Drawing.Color.White;
            this.btnDeconnexion.HoverState.Parent = this.btnDeconnexion;
            this.btnDeconnexion.Image = global::Views.Properties.Resources.icons8_login_rounded_48;
            this.btnDeconnexion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeconnexion.Location = new System.Drawing.Point(3, 502);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.ShadowDecoration.Parent = this.btnDeconnexion;
            this.btnDeconnexion.Size = new System.Drawing.Size(206, 45);
            this.btnDeconnexion.TabIndex = 6;
            this.btnDeconnexion.Text = "    Déconnexion";
            this.btnDeconnexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeconnexion.Click += new System.EventHandler(this.BtnDeconnexion_Click);
            // 
            // btnParams
            // 
            this.btnParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnParams.CheckedState.Parent = this.btnParams;
            this.btnParams.CustomImages.Parent = this.btnParams;
            this.btnParams.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnParams.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParams.ForeColor = System.Drawing.Color.White;
            this.btnParams.HoverState.Parent = this.btnParams;
            this.btnParams.Image = global::Views.Properties.Resources.icons8_settingsblanc_32;
            this.btnParams.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnParams.Location = new System.Drawing.Point(2, 430);
            this.btnParams.Name = "btnParams";
            this.btnParams.ShadowDecoration.Parent = this.btnParams;
            this.btnParams.Size = new System.Drawing.Size(207, 45);
            this.btnParams.TabIndex = 5;
            this.btnParams.Text = "    Paramètres";
            this.btnParams.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSendMails
            // 
            this.btnSendMails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnSendMails.CheckedState.Parent = this.btnSendMails;
            this.btnSendMails.CustomImages.Parent = this.btnSendMails;
            this.btnSendMails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnSendMails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMails.ForeColor = System.Drawing.Color.White;
            this.btnSendMails.HoverState.Parent = this.btnSendMails;
            this.btnSendMails.Image = global::Views.Properties.Resources.icons8_topic_48;
            this.btnSendMails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSendMails.Location = new System.Drawing.Point(3, 379);
            this.btnSendMails.Name = "btnSendMails";
            this.btnSendMails.ShadowDecoration.Parent = this.btnSendMails;
            this.btnSendMails.Size = new System.Drawing.Size(206, 45);
            this.btnSendMails.TabIndex = 4;
            this.btnSendMails.Text = "    Envoyer des mails";
            this.btnSendMails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnGesEsMem
            // 
            this.btnGesEsMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnGesEsMem.CheckedState.Parent = this.btnGesEsMem;
            this.btnGesEsMem.CustomImages.Parent = this.btnGesEsMem;
            this.btnGesEsMem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnGesEsMem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesEsMem.ForeColor = System.Drawing.Color.White;
            this.btnGesEsMem.HoverState.Parent = this.btnGesEsMem;
            this.btnGesEsMem.Image = global::Views.Properties.Resources.icons8_add_user_group_man_man_filled_48;
            this.btnGesEsMem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGesEsMem.Location = new System.Drawing.Point(3, 328);
            this.btnGesEsMem.Name = "btnGesEsMem";
            this.btnGesEsMem.ShadowDecoration.Parent = this.btnGesEsMem;
            this.btnGesEsMem.Size = new System.Drawing.Size(206, 45);
            this.btnGesEsMem.TabIndex = 3;
            this.btnGesEsMem.Text = "    Gestion espace membre";
            this.btnGesEsMem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnGesProjet
            // 
            this.btnGesProjet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnGesProjet.CheckedState.Parent = this.btnGesProjet;
            this.btnGesProjet.CustomImages.Parent = this.btnGesProjet;
            this.btnGesProjet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnGesProjet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGesProjet.ForeColor = System.Drawing.Color.White;
            this.btnGesProjet.HoverState.Parent = this.btnGesProjet;
            this.btnGesProjet.Image = global::Views.Properties.Resources.icons8_trainingbig_48;
            this.btnGesProjet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGesProjet.Location = new System.Drawing.Point(2, 277);
            this.btnGesProjet.Name = "btnGesProjet";
            this.btnGesProjet.ShadowDecoration.Parent = this.btnGesProjet;
            this.btnGesProjet.Size = new System.Drawing.Size(209, 45);
            this.btnGesProjet.TabIndex = 2;
            this.btnGesProjet.Text = "    Gestion des projets";
            this.btnGesProjet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGesProjet.Click += new System.EventHandler(this.BtnGesProjet_Click);
            // 
            // btnGestUsers
            // 
            this.btnGestUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnGestUsers.CheckedState.Parent = this.btnGestUsers;
            this.btnGestUsers.CustomImages.Parent = this.btnGestUsers;
            this.btnGestUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.btnGestUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestUsers.ForeColor = System.Drawing.Color.White;
            this.btnGestUsers.HoverState.Parent = this.btnGestUsers;
            this.btnGestUsers.Image = global::Views.Properties.Resources.icons8_groupsbig_48;
            this.btnGestUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGestUsers.Location = new System.Drawing.Point(3, 226);
            this.btnGestUsers.Name = "btnGestUsers";
            this.btnGestUsers.ShadowDecoration.Parent = this.btnGestUsers;
            this.btnGestUsers.Size = new System.Drawing.Size(206, 45);
            this.btnGestUsers.TabIndex = 1;
            this.btnGestUsers.Text = "    Gestion des utilisateurs";
            this.btnGestUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGestUsers.Click += new System.EventHandler(this.BtnGestUsers_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAdmin.Location = new System.Drawing.Point(361, 12);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(82, 13);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "Administrateur";
            // 
            // picAdmin
            // 
            this.picAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picAdmin.Image")));
            this.picAdmin.Location = new System.Drawing.Point(451, 6);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAdmin.ShadowDecoration.Parent = this.picAdmin;
            this.picAdmin.Size = new System.Drawing.Size(25, 25);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmin.TabIndex = 2;
            this.picAdmin.TabStop = false;
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.panHeader.Controls.Add(this.guna2CirclePictureBox1);
            this.panHeader.Controls.Add(this.guna2ControlBox3);
            this.panHeader.Controls.Add(this.lblAdmin);
            this.panHeader.Controls.Add(this.guna2ControlBox2);
            this.panHeader.Controls.Add(this.picAdmin);
            this.panHeader.Controls.Add(this.btnFermer);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(212, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(688, 36);
            this.panHeader.TabIndex = 1;
            this.panHeader.TabStop = true;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox1.Image = global::Views.Properties.Resources.icons8_settingsblanc_32;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(491, 9);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(21, 19);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.Gray;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(592, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox3.TabIndex = 4;
            this.guna2ControlBox3.UseTransparentBackground = true;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Gray;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(541, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox2.TabIndex = 3;
            this.guna2ControlBox2.UseTransparentBackground = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.BackColor = System.Drawing.Color.Transparent;
            this.btnFermer.FillColor = System.Drawing.Color.Transparent;
            this.btnFermer.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnFermer.HoverState.Parent = this.btnFermer;
            this.btnFermer.IconColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(643, 3);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.PressedColor = System.Drawing.Color.Red;
            this.btnFermer.ShadowDecoration.Parent = this.btnFermer;
            this.btnFermer.Size = new System.Drawing.Size(45, 30);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // panSecondHead
            // 
            this.panSecondHead.Controls.Add(this.guna2RatingStar1);
            this.panSecondHead.Controls.Add(this.lblStatusButton);
            this.panSecondHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSecondHead.Location = new System.Drawing.Point(212, 36);
            this.panSecondHead.Name = "panSecondHead";
            this.panSecondHead.Size = new System.Drawing.Size(688, 28);
            this.panSecondHead.TabIndex = 3;
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.BorderThickness = 1;
            this.guna2RatingStar1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2RatingStar1.Location = new System.Drawing.Point(3, 4);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.Size = new System.Drawing.Size(57, 18);
            this.guna2RatingStar1.TabIndex = 0;
            this.guna2RatingStar1.Value = 4F;
            // 
            // lblStatusButton
            // 
            this.lblStatusButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatusButton.AutoSize = true;
            this.lblStatusButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStatusButton.Location = new System.Drawing.Point(282, 3);
            this.lblStatusButton.Name = "lblStatusButton";
            this.lblStatusButton.Size = new System.Drawing.Size(63, 21);
            this.lblStatusButton.TabIndex = 4;
            this.lblStatusButton.Text = "Accueil";
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(212, 64);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(688, 486);
            this.panelContainer.TabIndex = 4;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContainer_Paint);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panHeader;
            // 
            // HomeAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panSecondHead);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.panSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeAdministrator";
            this.Load += new System.EventHandler(this.HomeAdministrator_Load);
            this.panSidebar.ResumeLayout(false);
            this.panContentInfoAdmin.ResumeLayout(false);
            this.panContentInfoAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panSecondHead.ResumeLayout(false);
            this.panSecondHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSidebar;
        private Guna.UI2.WinForms.Guna2Button btnGestUsers;
        private System.Windows.Forms.Panel panHeader;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox btnFermer;
        private Guna.UI2.WinForms.Guna2Button btnGesProjet;
        private Guna.UI2.WinForms.Guna2Button btnDeconnexion;
        private Guna.UI2.WinForms.Guna2Button btnParams;
        private Guna.UI2.WinForms.Guna2Button btnSendMails;
        private Guna.UI2.WinForms.Guna2Button btnGesEsMem;
        private System.Windows.Forms.Panel panContentInfoAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAdmin;
        private System.Windows.Forms.Panel panSecondHead;
        private System.Windows.Forms.Label lblStatusButton;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
    }
}
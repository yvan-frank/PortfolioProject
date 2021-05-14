namespace Views.HomeForm.HomeMembreProjet
{
    partial class MembreProjetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembreProjetForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTache = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnChat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDeco = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnReduire = new System.Windows.Forms.PictureBox();
            this.btnMaximized = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.PictureBox();
            this.toolTipBtnclo = new System.Windows.Forms.ToolTip(this.components);
            this.btnHome = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSendMail = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panbtnClo = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReduire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).BeginInit();
            this.panbtnClo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.btnSendMail);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDeco);
            this.panel1.Controls.Add(this.btnChat);
            this.panel1.Controls.Add(this.btnTache);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 518);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panbtnClo);
            this.panel2.Controls.Add(this.btnRestore);
            this.panel2.Controls.Add(this.btnMaximized);
            this.panel2.Controls.Add(this.btnReduire);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 43);
            this.panel2.TabIndex = 1;
            // 
            // btnTache
            // 
            this.btnTache.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTache.BackColor = System.Drawing.Color.Transparent;
            this.btnTache.CheckedState.Parent = this.btnTache;
            this.btnTache.CustomImages.Parent = this.btnTache;
            this.btnTache.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnTache.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnTache.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTache.ForeColor = System.Drawing.Color.White;
            this.btnTache.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.btnTache.HoverState.Parent = this.btnTache;
            this.btnTache.Image = ((System.Drawing.Image)(resources.GetObject("btnTache.Image")));
            this.btnTache.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTache.Location = new System.Drawing.Point(8, 253);
            this.btnTache.Name = "btnTache";
            this.btnTache.ShadowDecoration.Parent = this.btnTache;
            this.btnTache.Size = new System.Drawing.Size(185, 38);
            this.btnTache.TabIndex = 3;
            this.btnTache.Text = "Tâches";
            this.btnTache.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTache.Click += new System.EventHandler(this.BtnTache_Click);
            // 
            // btnChat
            // 
            this.btnChat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnChat.BackColor = System.Drawing.Color.Transparent;
            this.btnChat.CheckedState.Parent = this.btnChat;
            this.btnChat.CustomImages.Parent = this.btnChat;
            this.btnChat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnChat.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnChat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.btnChat.HoverState.Parent = this.btnChat;
            this.btnChat.Image = ((System.Drawing.Image)(resources.GetObject("btnChat.Image")));
            this.btnChat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChat.Location = new System.Drawing.Point(8, 297);
            this.btnChat.Name = "btnChat";
            this.btnChat.ShadowDecoration.Parent = this.btnChat;
            this.btnChat.Size = new System.Drawing.Size(185, 38);
            this.btnChat.TabIndex = 4;
            this.btnChat.Text = "Chat";
            this.btnChat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChat.Click += new System.EventHandler(this.BtnChat_Click);
            // 
            // btnDeco
            // 
            this.btnDeco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeco.BackColor = System.Drawing.Color.Transparent;
            this.btnDeco.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnDeco.CheckedState.Parent = this.btnDeco;
            this.btnDeco.CustomImages.Parent = this.btnDeco;
            this.btnDeco.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDeco.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDeco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeco.ForeColor = System.Drawing.Color.White;
            this.btnDeco.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.btnDeco.HoverState.Parent = this.btnDeco;
            this.btnDeco.Image = ((System.Drawing.Image)(resources.GetObject("btnDeco.Image")));
            this.btnDeco.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeco.Location = new System.Drawing.Point(8, 468);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.ShadowDecoration.Parent = this.btnDeco;
            this.btnDeco.Size = new System.Drawing.Size(185, 38);
            this.btnDeco.TabIndex = 5;
            this.btnDeco.Text = "Déconnexion";
            this.btnDeco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeco.Click += new System.EventHandler(this.BtnDeco_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(10, 134);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(180, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Mettre à jour";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(49, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(12, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.toolTipBtnclo.SetToolTip(this.btnClose, "Fermer");
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnClose_MouseDown);
            // 
            // btnReduire
            // 
            this.btnReduire.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReduire.Image = ((System.Drawing.Image)(resources.GetObject("btnReduire.Image")));
            this.btnReduire.Location = new System.Drawing.Point(641, 12);
            this.btnReduire.Name = "btnReduire";
            this.btnReduire.Size = new System.Drawing.Size(18, 18);
            this.btnReduire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReduire.TabIndex = 3;
            this.btnReduire.TabStop = false;
            this.btnReduire.Click += new System.EventHandler(this.BtnReduire_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(674, 12);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(18, 18);
            this.btnMaximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximized.TabIndex = 4;
            this.btnMaximized.TabStop = false;
            this.btnMaximized.Click += new System.EventHandler(this.BtnMaximized_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.Location = new System.Drawing.Point(674, 12);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(18, 18);
            this.btnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestore.TabIndex = 5;
            this.btnRestore.TabStop = false;
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // toolTipBtnclo
            // 
            this.toolTipBtnclo.AutoPopDelay = 10000;
            this.toolTipBtnclo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.toolTipBtnclo.ForeColor = System.Drawing.Color.White;
            this.toolTipBtnclo.InitialDelay = 500;
            this.toolTipBtnclo.ReshowDelay = 100;
            this.toolTipBtnclo.ShowAlways = true;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnHome.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(8, 209);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(185, 38);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSendMail.BackColor = System.Drawing.Color.Transparent;
            this.btnSendMail.CheckedState.Parent = this.btnSendMail;
            this.btnSendMail.CustomImages.Parent = this.btnSendMail;
            this.btnSendMail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSendMail.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSendMail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.btnSendMail.HoverState.Parent = this.btnSendMail;
            this.btnSendMail.Image = ((System.Drawing.Image)(resources.GetObject("btnSendMail.Image")));
            this.btnSendMail.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSendMail.Location = new System.Drawing.Point(8, 341);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.ShadowDecoration.Parent = this.btnSendMail;
            this.btnSendMail.Size = new System.Drawing.Size(185, 38);
            this.btnSendMail.TabIndex = 8;
            this.btnSendMail.Text = "Envoyer mail";
            this.btnSendMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSendMail.Click += new System.EventHandler(this.BtnSendMail_Click);
            // 
            // panbtnClo
            // 
            this.panbtnClo.BackColor = System.Drawing.Color.Transparent;
            this.panbtnClo.Controls.Add(this.btnClose);
            this.panbtnClo.Location = new System.Drawing.Point(698, 0);
            this.panbtnClo.Name = "panbtnClo";
            this.panbtnClo.Size = new System.Drawing.Size(44, 43);
            this.panbtnClo.TabIndex = 2;
            this.panbtnClo.MouseLeave += new System.EventHandler(this.PanbtnClo_MouseLeave);
            this.panbtnClo.MouseHover += new System.EventHandler(this.PanbtnClo_MouseHover);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel2;
            // 
            // MembreProjetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MembreProjetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MembreProjetForm";
            this.Load += new System.EventHandler(this.MembreProjetForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReduire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).EndInit();
            this.panbtnClo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeco;
        private Guna.UI2.WinForms.Guna2GradientButton btnChat;
        private Guna.UI2.WinForms.Guna2GradientButton btnTache;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMaximized;
        private System.Windows.Forms.PictureBox btnReduire;
        private System.Windows.Forms.PictureBox btnRestore;
        private System.Windows.Forms.ToolTip toolTipBtnclo;
        private Guna.UI2.WinForms.Guna2GradientButton btnSendMail;
        private Guna.UI2.WinForms.Guna2GradientButton btnHome;
        private System.Windows.Forms.Panel panbtnClo;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}
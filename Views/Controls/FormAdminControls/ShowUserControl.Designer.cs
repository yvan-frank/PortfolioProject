namespace Views.Controls.FormAdminControls
{
    partial class ShowUserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowUserControl));
            this.pc_show_photo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblProfil = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCountprojet = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCountModule = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.progressBarTaux = new Bunifu.Framework.UI.BunifuProgressBar();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnAssigner = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnShowuser = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnParamsUser = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnDeleteuser = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pc_show_photo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pc_show_photo
            // 
            this.pc_show_photo.Image = ((System.Drawing.Image)(resources.GetObject("pc_show_photo.Image")));
            this.pc_show_photo.Location = new System.Drawing.Point(3, 3);
            this.pc_show_photo.Name = "pc_show_photo";
            this.pc_show_photo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pc_show_photo.ShadowDecoration.Parent = this.pc_show_photo;
            this.pc_show_photo.Size = new System.Drawing.Size(56, 66);
            this.pc_show_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_show_photo.TabIndex = 0;
            this.pc_show_photo.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(71, 3);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(46, 21);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfil.Location = new System.Drawing.Point(74, 24);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(43, 18);
            this.lblProfil.TabIndex = 2;
            this.lblProfil.Text = "Profil";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteuser);
            this.panel1.Controls.Add(this.btnParamsUser);
            this.panel1.Controls.Add(this.btnShowuser);
            this.panel1.Controls.Add(this.btnAssigner);
            this.panel1.Location = new System.Drawing.Point(75, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 29);
            this.panel1.TabIndex = 4;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Assigner un projet";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Afficher les détails";
            // 
            // toolTip3
            // 
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip3.ToolTipTitle = "Voir plus";
            // 
            // toolTip4
            // 
            this.toolTip4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip4.ToolTipTitle = "Supprimer";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(1, 80);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(183, 16);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCountprojet);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 85);
            this.panel2.TabIndex = 6;
            // 
            // lblCountprojet
            // 
            this.lblCountprojet.AutoSize = true;
            this.lblCountprojet.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountprojet.Location = new System.Drawing.Point(40, 52);
            this.lblCountprojet.Name = "lblCountprojet";
            this.lblCountprojet.Size = new System.Drawing.Size(16, 18);
            this.lblCountprojet.TabIndex = 9;
            this.lblCountprojet.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(89, 35);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Projet en cours";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblCountModule);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(96, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(87, 85);
            this.panel4.TabIndex = 7;
            // 
            // lblCountModule
            // 
            this.lblCountModule.AutoSize = true;
            this.lblCountModule.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountModule.Location = new System.Drawing.Point(32, 52);
            this.lblCountModule.Name = "lblCountModule";
            this.lblCountModule.Size = new System.Drawing.Size(16, 18);
            this.lblCountModule.TabIndex = 10;
            this.lblCountModule.Text = "0";
            this.lblCountModule.Click += new System.EventHandler(this.LblCountModule_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(87, 35);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre de\r\n   module";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.progressBarTaux);
            this.panel6.Location = new System.Drawing.Point(3, 188);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 23);
            this.panel6.TabIndex = 8;
            // 
            // progressBarTaux
            // 
            this.progressBarTaux.BackColor = System.Drawing.Color.Silver;
            this.progressBarTaux.BorderRadius = 5;
            this.progressBarTaux.Location = new System.Drawing.Point(1, 3);
            this.progressBarTaux.MaximumValue = 100;
            this.progressBarTaux.Name = "progressBarTaux";
            this.progressBarTaux.ProgressColor = System.Drawing.Color.Teal;
            this.progressBarTaux.Size = new System.Drawing.Size(176, 28);
            this.progressBarTaux.TabIndex = 9;
            this.progressBarTaux.Value = 25;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnAssigner
            // 
            this.btnAssigner.CheckedState.Parent = this.btnAssigner;
            this.btnAssigner.HoverState.Parent = this.btnAssigner;
            this.btnAssigner.Image = ((System.Drawing.Image)(resources.GetObject("btnAssigner.Image")));
            this.btnAssigner.Location = new System.Drawing.Point(2, 3);
            this.btnAssigner.Name = "btnAssigner";
            this.btnAssigner.PressedState.Parent = this.btnAssigner;
            this.btnAssigner.Size = new System.Drawing.Size(25, 23);
            this.btnAssigner.TabIndex = 9;
            // 
            // btnShowuser
            // 
            this.btnShowuser.CheckedState.Parent = this.btnShowuser;
            this.btnShowuser.HoverState.Parent = this.btnShowuser;
            this.btnShowuser.Image = ((System.Drawing.Image)(resources.GetObject("btnShowuser.Image")));
            this.btnShowuser.Location = new System.Drawing.Point(24, 4);
            this.btnShowuser.Name = "btnShowuser";
            this.btnShowuser.PressedState.Parent = this.btnShowuser;
            this.btnShowuser.Size = new System.Drawing.Size(25, 23);
            this.btnShowuser.TabIndex = 10;
            // 
            // btnParamsUser
            // 
            this.btnParamsUser.CheckedState.Parent = this.btnParamsUser;
            this.btnParamsUser.HoverState.Parent = this.btnParamsUser;
            this.btnParamsUser.Image = ((System.Drawing.Image)(resources.GetObject("btnParamsUser.Image")));
            this.btnParamsUser.Location = new System.Drawing.Point(55, 3);
            this.btnParamsUser.Name = "btnParamsUser";
            this.btnParamsUser.PressedState.Parent = this.btnParamsUser;
            this.btnParamsUser.Size = new System.Drawing.Size(25, 23);
            this.btnParamsUser.TabIndex = 11;
            // 
            // btnDeleteuser
            // 
            this.btnDeleteuser.CheckedState.Parent = this.btnDeleteuser;
            this.btnDeleteuser.HoverState.Parent = this.btnDeleteuser;
            this.btnDeleteuser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteuser.Image")));
            this.btnDeleteuser.Location = new System.Drawing.Point(80, 3);
            this.btnDeleteuser.Name = "btnDeleteuser";
            this.btnDeleteuser.PressedState.Parent = this.btnDeleteuser;
            this.btnDeleteuser.Size = new System.Drawing.Size(25, 23);
            this.btnDeleteuser.TabIndex = 12;
            // 
            // ShowUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProfil);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pc_show_photo);
            this.Name = "ShowUserControl";
            this.Size = new System.Drawing.Size(187, 222);
            ((System.ComponentModel.ISupportInitialize)(this.pc_show_photo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pc_show_photo;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuProgressBar progressBarTaux;
        private System.Windows.Forms.Label lblCountprojet;
        private System.Windows.Forms.Label lblCountModule;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton btnDeleteuser;
        private Guna.UI2.WinForms.Guna2ImageButton btnParamsUser;
        private Guna.UI2.WinForms.Guna2ImageButton btnShowuser;
        private Guna.UI2.WinForms.Guna2ImageButton btnAssigner;
    }
}

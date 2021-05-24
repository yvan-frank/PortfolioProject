namespace Views.HomeForm.HomeAdmin.FormAdmin
{
    partial class GestionUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.groupeBoxChef = new Guna.UI2.WinForms.Guna2GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupeBoxChef.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAdd.PressedState.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(59, 46);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupeBoxChef
            // 
            this.groupeBoxChef.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupeBoxChef.BorderThickness = 5;
            this.groupeBoxChef.Controls.Add(this.flowLayoutPanel1);
            this.groupeBoxChef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupeBoxChef.FillColor = System.Drawing.Color.DarkGray;
            this.groupeBoxChef.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupeBoxChef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupeBoxChef.Location = new System.Drawing.Point(0, 64);
            this.groupeBoxChef.Name = "groupeBoxChef";
            this.groupeBoxChef.ShadowDecoration.Parent = this.groupeBoxChef;
            this.groupeBoxChef.Size = new System.Drawing.Size(766, 447);
            this.groupeBoxChef.TabIndex = 1;
            this.groupeBoxChef.Text = "Chef projet";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(742, 390);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // GestionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 511);
            this.Controls.Add(this.groupeBoxChef);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionUser";
            this.Text = "GestionUser";
            this.Load += new System.EventHandler(this.GestionUser_Load);
            this.panel1.ResumeLayout(false);
            this.groupeBoxChef.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        public Guna.UI2.WinForms.Guna2GroupBox groupeBoxChef;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
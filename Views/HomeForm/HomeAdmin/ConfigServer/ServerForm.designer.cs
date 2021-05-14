namespace Views.HomeForm.HomeAdmin
{
    partial class ServerForm
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIP = new System.Windows.Forms.TextBox();
            this.listLog = new System.Windows.Forms.ListBox();
            this.numericPORT = new System.Windows.Forms.NumericUpDown();
            this.btnStartserver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPORT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(12, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(153, 20);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "127.0.0.1";
            // 
            // listLog
            // 
            this.listLog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 17;
            this.listLog.Location = new System.Drawing.Point(12, 38);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(482, 276);
            this.listLog.TabIndex = 1;
            // 
            // numericPORT
            // 
            this.numericPORT.Location = new System.Drawing.Point(171, 12);
            this.numericPORT.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericPORT.Name = "numericPORT";
            this.numericPORT.Size = new System.Drawing.Size(120, 20);
            this.numericPORT.TabIndex = 2;
            this.numericPORT.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnStartserver
            // 
            this.btnStartserver.Location = new System.Drawing.Point(328, 12);
            this.btnStartserver.Name = "btnStartserver";
            this.btnStartserver.Size = new System.Drawing.Size(166, 23);
            this.btnStartserver.TabIndex = 3;
            this.btnStartserver.Text = "Start server";
            this.btnStartserver.UseVisualStyleBackColor = true;
            this.btnStartserver.Click += new System.EventHandler(this.BtnStartserver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 319);
            this.Controls.Add(this.btnStartserver);
            this.Controls.Add(this.numericPORT);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.txtIP);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start server";
            ((System.ComponentModel.ISupportInitialize)(this.numericPORT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.NumericUpDown numericPORT;
        private System.Windows.Forms.Button btnStartserver;
    }
}


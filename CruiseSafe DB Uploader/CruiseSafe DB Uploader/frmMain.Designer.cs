namespace CruiseSafe_DB_Uploader
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbChangeLog = new System.Windows.Forms.Label();
            this.tbChangelog = new System.Windows.Forms.TextBox();
            this.lbFile = new System.Windows.Forms.Label();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btSelectFile = new System.Windows.Forms.Button();
            this.btUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbVersion
            // 
            this.tbVersion.Location = new System.Drawing.Point(108, 12);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(255, 27);
            this.tbVersion.TabIndex = 0;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(34, 15);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(68, 19);
            this.lbVersion.TabIndex = 1;
            this.lbVersion.Text = "Version:";
            // 
            // lbChangeLog
            // 
            this.lbChangeLog.AutoSize = true;
            this.lbChangeLog.Location = new System.Drawing.Point(12, 48);
            this.lbChangeLog.Name = "lbChangeLog";
            this.lbChangeLog.Size = new System.Drawing.Size(90, 19);
            this.lbChangeLog.TabIndex = 3;
            this.lbChangeLog.Text = "Changelog:";
            // 
            // tbChangelog
            // 
            this.tbChangelog.Location = new System.Drawing.Point(108, 45);
            this.tbChangelog.Multiline = true;
            this.tbChangelog.Name = "tbChangelog";
            this.tbChangelog.Size = new System.Drawing.Size(255, 152);
            this.tbChangelog.TabIndex = 2;
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.Location = new System.Drawing.Point(63, 205);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(39, 19);
            this.lbFile.TabIndex = 4;
            this.lbFile.Text = "File:";
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(108, 202);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(215, 27);
            this.tbFile.TabIndex = 5;
            // 
            // btSelectFile
            // 
            this.btSelectFile.Location = new System.Drawing.Point(329, 201);
            this.btSelectFile.Name = "btSelectFile";
            this.btSelectFile.Size = new System.Drawing.Size(34, 28);
            this.btSelectFile.TabIndex = 6;
            this.btSelectFile.Text = "...";
            this.btSelectFile.UseVisualStyleBackColor = true;
            this.btSelectFile.Click += new System.EventHandler(this.btSelectFile_Click);
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(108, 235);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(255, 49);
            this.btUpload.TabIndex = 7;
            this.btUpload.Text = "Upload";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 297);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.btSelectFile);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.lbChangeLog);
            this.Controls.Add(this.tbChangelog);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.tbVersion);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CruiseSafe DB Uploader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbChangeLog;
        private System.Windows.Forms.TextBox tbChangelog;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btSelectFile;
        private System.Windows.Forms.Button btUpload;
    }
}


namespace SafeAbuse.Pages
{
    partial class PopUpSwitchPos
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSwitchPos = new System.Windows.Forms.Label();
            this.btnSwitchOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSwitchPos
            // 
            this.lblSwitchPos.AutoSize = true;
            this.lblSwitchPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblSwitchPos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSwitchPos.Location = new System.Drawing.Point(91, 41);
            this.lblSwitchPos.Name = "lblSwitchPos";
            this.lblSwitchPos.Size = new System.Drawing.Size(161, 26);
            this.lblSwitchPos.TabIndex = 0;
            this.lblSwitchPos.Text = "Switch Position";
            // 
            // btnSwitchOkay
            // 
            this.btnSwitchOkay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSwitchOkay.Location = new System.Drawing.Point(125, 88);
            this.btnSwitchOkay.Name = "btnSwitchOkay";
            this.btnSwitchOkay.Size = new System.Drawing.Size(85, 48);
            this.btnSwitchOkay.TabIndex = 1;
            this.btnSwitchOkay.Text = "Okay";
            this.btnSwitchOkay.UseVisualStyleBackColor = false;
            this.btnSwitchOkay.Click += new System.EventHandler(this.btnSwitchOkay_Click);
            // 
            // PopUpSwitchPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnSwitchOkay);
            this.Controls.Add(this.lblSwitchPos);
            this.Name = "PopUpSwitchPos";
            this.Size = new System.Drawing.Size(326, 220);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSwitchPos;
        private System.Windows.Forms.Button btnSwitchOkay;
    }
}

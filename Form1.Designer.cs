namespace SafeAbuse
{
    partial class SafeAbuse
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
            this.components = new System.ComponentModel.Container();
            this.txtTimeStand = new System.Windows.Forms.TextBox();
            this.lblStand = new System.Windows.Forms.Label();
            this.txtTimeSit = new System.Windows.Forms.TextBox();
            this.lblSit = new System.Windows.Forms.Label();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtTimeStand
            // 
            this.txtTimeStand.Location = new System.Drawing.Point(141, 27);
            this.txtTimeStand.Name = "txtTimeStand";
            this.txtTimeStand.Size = new System.Drawing.Size(172, 20);
            this.txtTimeStand.TabIndex = 0;
            // 
            // lblStand
            // 
            this.lblStand.AutoSize = true;
            this.lblStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStand.Location = new System.Drawing.Point(12, 20);
            this.lblStand.Name = "lblStand";
            this.lblStand.Size = new System.Drawing.Size(113, 26);
            this.lblStand.TabIndex = 1;
            this.lblStand.Text = "Stand (00)";
            // 
            // txtTimeSit
            // 
            this.txtTimeSit.Location = new System.Drawing.Point(141, 89);
            this.txtTimeSit.Name = "txtTimeSit";
            this.txtTimeSit.Size = new System.Drawing.Size(172, 20);
            this.txtTimeSit.TabIndex = 2;
            // 
            // lblSit
            // 
            this.lblSit.AutoSize = true;
            this.lblSit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblSit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSit.Location = new System.Drawing.Point(12, 70);
            this.lblSit.Name = "lblSit";
            this.lblSit.Size = new System.Drawing.Size(82, 26);
            this.lblSit.TabIndex = 3;
            this.lblSit.Text = "Sit (00)";
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.BackColor = System.Drawing.Color.Lime;
            this.btnStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTimer.Location = new System.Drawing.Point(141, 134);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(82, 67);
            this.btnStartTimer.TabIndex = 4;
            this.btnStartTimer.Text = "Start";
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.BackColor = System.Drawing.Color.Red;
            this.btnStopTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopTimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStopTimer.Location = new System.Drawing.Point(238, 134);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(75, 67);
            this.btnStopTimer.TabIndex = 5;
            this.btnStopTimer.Text = "Stop";
            this.btnStopTimer.UseVisualStyleBackColor = false;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // SafeAbuse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(412, 293);
            this.Controls.Add(this.btnStopTimer);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.lblSit);
            this.Controls.Add(this.txtTimeSit);
            this.Controls.Add(this.lblStand);
            this.Controls.Add(this.txtTimeStand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SafeAbuse";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafeAbuse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimeStand;
        private System.Windows.Forms.Label lblStand;
        private System.Windows.Forms.TextBox txtTimeSit;
        private System.Windows.Forms.Label lblSit;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Timer timer;
    }
}


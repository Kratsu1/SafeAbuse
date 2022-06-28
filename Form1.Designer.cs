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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeAbuse));
            this.timerStand = new System.Windows.Forms.Timer(this.components);
            this.timerSeconds = new System.Windows.Forms.Timer(this.components);
            this.timerSit = new System.Windows.Forms.Timer(this.components);
            this.panelBody = new System.Windows.Forms.Panel();
            this.lblSecondCounter = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.lblSit = new System.Windows.Forms.Label();
            this.txtTimeSit = new System.Windows.Forms.TextBox();
            this.lblStand = new System.Windows.Forms.Label();
            this.txtTimeStand = new System.Windows.Forms.TextBox();
            this.popUpSwitchPos2 = new Pages.PopUpSwitchPos();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerStand
            // 
            this.timerStand.Interval = 1000;
            this.timerStand.Tick += new System.EventHandler(this.TimerStand_Tick);
            // 
            // timerSeconds
            // 
            this.timerSeconds.Interval = 1000;
            this.timerSeconds.Tick += new System.EventHandler(this.TimerSeconds_Tick);
            // 
            // timerSit
            // 
            this.timerSit.Interval = 1000;
            this.timerSit.Tick += new System.EventHandler(this.TimerSit_Tick);
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.popUpSwitchPos2);
            this.panelBody.Controls.Add(this.lblSecondCounter);
            this.panelBody.Controls.Add(this.lblinfo);
            this.panelBody.Controls.Add(this.btnStopTimer);
            this.panelBody.Controls.Add(this.btnStartTimer);
            this.panelBody.Controls.Add(this.lblSit);
            this.panelBody.Controls.Add(this.txtTimeSit);
            this.panelBody.Controls.Add(this.lblStand);
            this.panelBody.Controls.Add(this.txtTimeStand);
            this.panelBody.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(326, 220);
            this.panelBody.TabIndex = 18;
            // 
            // lblSecondCounter
            // 
            this.lblSecondCounter.AutoSize = true;
            this.lblSecondCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSecondCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(88)))), ((int)(((byte)(78)))));
            this.lblSecondCounter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSecondCounter.Location = new System.Drawing.Point(154, 14);
            this.lblSecondCounter.Name = "lblSecondCounter";
            this.lblSecondCounter.Size = new System.Drawing.Size(0, 17);
            this.lblSecondCounter.TabIndex = 16;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(20)))), ((int)(((byte)(95)))));
            this.lblinfo.Location = new System.Drawing.Point(15, 150);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(121, 34);
            this.lblinfo.TabIndex = 15;
            this.lblinfo.Text = "* Please enter the\r\ntime in minutes.";
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStopTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopTimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStopTimer.Location = new System.Drawing.Point(239, 139);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(75, 67);
            this.btnStopTimer.TabIndex = 14;
            this.btnStopTimer.Text = "Stop";
            this.btnStopTimer.UseVisualStyleBackColor = false;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.BackColor = System.Drawing.Color.Lime;
            this.btnStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTimer.Location = new System.Drawing.Point(157, 139);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(76, 67);
            this.btnStartTimer.TabIndex = 13;
            this.btnStartTimer.Text = "Start";
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // lblSit
            // 
            this.lblSit.AutoSize = true;
            this.lblSit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblSit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(88)))), ((int)(((byte)(78)))));
            this.lblSit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSit.Location = new System.Drawing.Point(13, 87);
            this.lblSit.Name = "lblSit";
            this.lblSit.Size = new System.Drawing.Size(82, 26);
            this.lblSit.TabIndex = 12;
            this.lblSit.Text = "Sit (00)";
            // 
            // txtTimeSit
            // 
            this.txtTimeSit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.txtTimeSit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTimeSit.ForeColor = System.Drawing.Color.White;
            this.txtTimeSit.Location = new System.Drawing.Point(157, 94);
            this.txtTimeSit.Name = "txtTimeSit";
            this.txtTimeSit.Size = new System.Drawing.Size(157, 20);
            this.txtTimeSit.TabIndex = 11;
            // 
            // lblStand
            // 
            this.lblStand.AutoSize = true;
            this.lblStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(88)))), ((int)(((byte)(78)))));
            this.lblStand.Location = new System.Drawing.Point(13, 32);
            this.lblStand.Name = "lblStand";
            this.lblStand.Size = new System.Drawing.Size(113, 26);
            this.lblStand.TabIndex = 10;
            this.lblStand.Text = "Stand (00)";
            // 
            // txtTimeStand
            // 
            this.txtTimeStand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.txtTimeStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtTimeStand.ForeColor = System.Drawing.Color.White;
            this.txtTimeStand.Location = new System.Drawing.Point(157, 38);
            this.txtTimeStand.Name = "txtTimeStand";
            this.txtTimeStand.Size = new System.Drawing.Size(157, 23);
            this.txtTimeStand.TabIndex = 9;
            // 
            // popUpSwitchPos2
            // 
            this.popUpSwitchPos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.popUpSwitchPos2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popUpSwitchPos2.Location = new System.Drawing.Point(0, 0);
            this.popUpSwitchPos2.Name = "popUpSwitchPos2";
            this.popUpSwitchPos2.Size = new System.Drawing.Size(326, 220);
            this.popUpSwitchPos2.TabIndex = 17;
            this.popUpSwitchPos2.Visible = false;
            // 
            // SafeAbuse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(326, 220);
            this.Controls.Add(this.panelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SafeAbuse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafeAbuse";
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerStand;
        private System.Windows.Forms.Timer timerSeconds;
        private System.Windows.Forms.Timer timerSit;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label lblSecondCounter;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Label lblSit;
        private System.Windows.Forms.TextBox txtTimeSit;
        private System.Windows.Forms.Label lblStand;
        private System.Windows.Forms.TextBox txtTimeStand;
        private Pages.PopUpSwitchPos popUpSwitchPos2;
    }
}


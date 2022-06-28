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
            this.txtTimeStand = new System.Windows.Forms.TextBox();
            this.lblStand = new System.Windows.Forms.Label();
            this.txtTimeSit = new System.Windows.Forms.TextBox();
            this.lblSit = new System.Windows.Forms.Label();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.timerStand = new System.Windows.Forms.Timer(this.components);
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblSecondCounter = new System.Windows.Forms.Label();
            this.timerSeconds = new System.Windows.Forms.Timer(this.components);
            this.timerSit = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtTimeStand
            // 
            this.txtTimeStand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.txtTimeStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtTimeStand.ForeColor = System.Drawing.Color.White;
            this.txtTimeStand.Location = new System.Drawing.Point(156, 33);
            this.txtTimeStand.Name = "txtTimeStand";
            this.txtTimeStand.Size = new System.Drawing.Size(157, 23);
            this.txtTimeStand.TabIndex = 0;
            // 
            // lblStand
            // 
            this.lblStand.AutoSize = true;
            this.lblStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(88)))), ((int)(((byte)(78)))));
            this.lblStand.Location = new System.Drawing.Point(12, 27);
            this.lblStand.Name = "lblStand";
            this.lblStand.Size = new System.Drawing.Size(113, 26);
            this.lblStand.TabIndex = 1;
            this.lblStand.Text = "Stand (00)";
            // 
            // txtTimeSit
            // 
            this.txtTimeSit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.txtTimeSit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTimeSit.ForeColor = System.Drawing.Color.White;
            this.txtTimeSit.Location = new System.Drawing.Point(156, 89);
            this.txtTimeSit.Name = "txtTimeSit";
            this.txtTimeSit.Size = new System.Drawing.Size(157, 20);
            this.txtTimeSit.TabIndex = 2;
            // 
            // lblSit
            // 
            this.lblSit.AutoSize = true;
            this.lblSit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblSit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(88)))), ((int)(((byte)(78)))));
            this.lblSit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSit.Location = new System.Drawing.Point(12, 82);
            this.lblSit.Name = "lblSit";
            this.lblSit.Size = new System.Drawing.Size(82, 26);
            this.lblSit.TabIndex = 3;
            this.lblSit.Text = "Sit (00)";
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.BackColor = System.Drawing.Color.Lime;
            this.btnStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTimer.Location = new System.Drawing.Point(156, 134);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(67, 67);
            this.btnStartTimer.TabIndex = 4;
            this.btnStartTimer.Text = "Start";
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStopTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopTimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStopTimer.Location = new System.Drawing.Point(238, 134);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(75, 67);
            this.btnStopTimer.TabIndex = 5;
            this.btnStopTimer.Text = "Stop";
            this.btnStopTimer.UseVisualStyleBackColor = false;
            this.btnStopTimer.DoubleClick += new System.EventHandler(this.btnResetTimer_Click);
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // timerStand
            // 
            this.timerStand.Interval = 1000;
            this.timerStand.Tick += new System.EventHandler(this.TimerStand_Tick);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(20)))), ((int)(((byte)(95)))));
            this.lblinfo.Location = new System.Drawing.Point(14, 145);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(121, 34);
            this.lblinfo.TabIndex = 7;
            this.lblinfo.Text = "* Please enter the\r\ntime in minutes.";
            // 
            // lblSecondCounter
            // 
            this.lblSecondCounter.AutoSize = true;
            this.lblSecondCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSecondCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(88)))), ((int)(((byte)(78)))));
            this.lblSecondCounter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSecondCounter.Location = new System.Drawing.Point(153, 9);
            this.lblSecondCounter.Name = "lblSecondCounter";
            this.lblSecondCounter.Size = new System.Drawing.Size(0, 17);
            this.lblSecondCounter.TabIndex = 8;
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
            // SafeAbuse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(326, 220);
            this.Controls.Add(this.lblSecondCounter);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btnStopTimer);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.lblSit);
            this.Controls.Add(this.txtTimeSit);
            this.Controls.Add(this.lblStand);
            this.Controls.Add(this.txtTimeStand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SafeAbuse";
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
        private System.Windows.Forms.Timer timerStand;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblSecondCounter;
        private System.Windows.Forms.Timer timerSeconds;
        private System.Windows.Forms.Timer timerSit;
    }
}


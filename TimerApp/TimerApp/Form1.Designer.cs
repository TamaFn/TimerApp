namespace TimerApp
{
    partial class TimerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerApp));
            this.label1 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(331, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 169);
            this.label1.TabIndex = 0;
            this.label1.Text = "00.00.00.00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.StartBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartBtn.BackgroundImage")));
            this.StartBtn.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartBtn.Location = new System.Drawing.Point(222, 433);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Padding = new System.Windows.Forms.Padding(5);
            this.StartBtn.Size = new System.Drawing.Size(185, 58);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.StopBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopBtn.BackgroundImage")));
            this.StopBtn.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StopBtn.Location = new System.Drawing.Point(505, 433);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Padding = new System.Windows.Forms.Padding(5);
            this.StopBtn.Size = new System.Drawing.Size(185, 58);
            this.StopBtn.TabIndex = 2;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // RestartBtn
            // 
            this.RestartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.RestartBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RestartBtn.BackgroundImage")));
            this.RestartBtn.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RestartBtn.Location = new System.Drawing.Point(774, 433);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Padding = new System.Windows.Forms.Padding(5);
            this.RestartBtn.Size = new System.Drawing.Size(185, 58);
            this.RestartBtn.TabIndex = 3;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // TimerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 690);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimerApp";
            this.Load += new System.EventHandler(this.TimerApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button RestartBtn;
    }
}


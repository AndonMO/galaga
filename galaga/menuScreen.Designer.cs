namespace galaga
{
    partial class menuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.leaderboardLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Monotxt_IV25", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.titleLabel.Location = new System.Drawing.Point(219, 116);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(584, 108);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "SKY BLASTER";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionLabel.Font = new System.Drawing.Font("Monotxt_IV25", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.instructionLabel.Location = new System.Drawing.Point(40, 434);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(433, 79);
            this.instructionLabel.TabIndex = 9;
            this.instructionLabel.Text = "INSTRUCTIONS";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.instructionLabel.Click += new System.EventHandler(this.instructionLabel_Click);
            // 
            // leaderboardLabel
            // 
            this.leaderboardLabel.BackColor = System.Drawing.Color.Transparent;
            this.leaderboardLabel.Font = new System.Drawing.Font("Monotxt_IV25", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.leaderboardLabel.Location = new System.Drawing.Point(568, 434);
            this.leaderboardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leaderboardLabel.Name = "leaderboardLabel";
            this.leaderboardLabel.Size = new System.Drawing.Size(433, 79);
            this.leaderboardLabel.TabIndex = 10;
            this.leaderboardLabel.Text = "Leaderboards";
            this.leaderboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.leaderboardLabel.Click += new System.EventHandler(this.leaderboardLabel_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Black;
            this.playButton.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(414, 278);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(186, 43);
            this.playButton.TabIndex = 11;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(414, 366);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(186, 43);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::galaga.Properties.Resources.menubackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.leaderboardLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "menuScreen";
            this.Size = new System.Drawing.Size(1051, 716);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label leaderboardLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
    }
}

namespace galaga
{
    partial class gameOver
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
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.saveLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.gameOverLabel.Location = new System.Drawing.Point(226, 41);
            this.gameOverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(584, 121);
            this.gameOverLabel.TabIndex = 15;
            this.gameOverLabel.Text = "Game Over!";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.scoreLabel.Location = new System.Drawing.Point(312, 188);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(409, 68);
            this.scoreLabel.TabIndex = 16;
            this.scoreLabel.Text = "scoreLabel";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveLabel
            // 
            this.saveLabel.BackColor = System.Drawing.Color.Transparent;
            this.saveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.saveLabel.Location = new System.Drawing.Point(321, 324);
            this.saveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(409, 68);
            this.saveLabel.TabIndex = 17;
            this.saveLabel.Text = "Would you like to save your score to the leaderboard?";
            this.saveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Black;
            this.saveButton.Font = new System.Drawing.Font("Monotxt_IV25", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(254, 471);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(157, 52);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "YES";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Font = new System.Drawing.Font("Monotxt_IV25", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(608, 471);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(157, 52);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "NO";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // gameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::galaga.Properties.Resources.menubackground;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.saveLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Name = "gameOver";
            this.Size = new System.Drawing.Size(1051, 716);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
    }
}

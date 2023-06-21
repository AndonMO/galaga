namespace galaga
{
    partial class leaderboard
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
            this.backButton = new System.Windows.Forms.Button();
            this.highscoresLabel = new System.Windows.Forms.Label();
            this.scoresLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.Font = new System.Drawing.Font("Monotxt_IV25", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(466, 474);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(157, 52);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // highscoresLabel
            // 
            this.highscoresLabel.BackColor = System.Drawing.Color.Transparent;
            this.highscoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoresLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.highscoresLabel.Location = new System.Drawing.Point(339, 0);
            this.highscoresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highscoresLabel.Name = "highscoresLabel";
            this.highscoresLabel.Size = new System.Drawing.Size(394, 69);
            this.highscoresLabel.TabIndex = 15;
            this.highscoresLabel.Text = "Highscores";
            this.highscoresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoresLabel
            // 
            this.scoresLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.scoresLabel.Location = new System.Drawing.Point(305, 82);
            this.scoresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoresLabel.Name = "scoresLabel";
            this.scoresLabel.Size = new System.Drawing.Size(464, 325);
            this.scoresLabel.TabIndex = 16;
            this.scoresLabel.Text = "Highscores";
            this.scoresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::galaga.Properties.Resources.menubackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.scoresLabel);
            this.Controls.Add(this.highscoresLabel);
            this.Controls.Add(this.backButton);
            this.Name = "leaderboard";
            this.Size = new System.Drawing.Size(1051, 716);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label highscoresLabel;
        private System.Windows.Forms.Label scoresLabel;
    }
}

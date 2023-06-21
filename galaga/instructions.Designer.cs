namespace galaga
{
    partial class instructions
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
            this.moveLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.shootLabel = new System.Windows.Forms.Label();
            this.goalLabel = new System.Windows.Forms.Label();
            this.infoLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.Font = new System.Drawing.Font("Monotxt_IV25", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(453, 602);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(157, 52);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // moveLabel
            // 
            this.moveLabel.BackColor = System.Drawing.Color.Transparent;
            this.moveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.moveLabel.Location = new System.Drawing.Point(243, 150);
            this.moveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moveLabel.Name = "moveLabel";
            this.moveLabel.Size = new System.Drawing.Size(584, 121);
            this.moveLabel.TabIndex = 11;
            this.moveLabel.Text = "Move left and right: A and D";
            this.moveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moveLabel.Visible = false;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.instructionsLabel.Location = new System.Drawing.Point(243, 0);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(584, 121);
            this.instructionsLabel.TabIndex = 12;
            this.instructionsLabel.Text = "INSTRUCTIONS";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.instructionsLabel.Visible = false;
            // 
            // shootLabel
            // 
            this.shootLabel.BackColor = System.Drawing.Color.Transparent;
            this.shootLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.shootLabel.Location = new System.Drawing.Point(243, 271);
            this.shootLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shootLabel.Name = "shootLabel";
            this.shootLabel.Size = new System.Drawing.Size(584, 75);
            this.shootLabel.TabIndex = 13;
            this.shootLabel.Text = "Shoot key: Shift";
            this.shootLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shootLabel.Visible = false;
            // 
            // goalLabel
            // 
            this.goalLabel.BackColor = System.Drawing.Color.Transparent;
            this.goalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.goalLabel.Location = new System.Drawing.Point(243, 384);
            this.goalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(584, 75);
            this.goalLabel.TabIndex = 14;
            this.goalLabel.Text = "GOAL";
            this.goalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.goalLabel.Visible = false;
            // 
            // infoLable
            // 
            this.infoLable.BackColor = System.Drawing.Color.Transparent;
            this.infoLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLable.ForeColor = System.Drawing.Color.OrangeRed;
            this.infoLable.Location = new System.Drawing.Point(243, 477);
            this.infoLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLable.Name = "infoLable";
            this.infoLable.Size = new System.Drawing.Size(584, 110);
            this.infoLable.TabIndex = 15;
            this.infoLable.Text = "Your goal in this game is to survive round with moving and shooting in order to l" +
    "ast as long as possible!";
            this.infoLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoLable.Visible = false;
            // 
            // instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::galaga.Properties.Resources.menubackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.infoLable);
            this.Controls.Add(this.goalLabel);
            this.Controls.Add(this.shootLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.moveLabel);
            this.Controls.Add(this.backButton);
            this.Name = "instructions";
            this.Size = new System.Drawing.Size(1051, 716);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label moveLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label shootLabel;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Label infoLable;
    }
}

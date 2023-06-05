namespace galaga
{
    partial class gameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameEngine = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.bossNameLabel = new System.Windows.Forms.Label();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.roundStartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            this.SuspendLayout();
            // 
            // gameEngine
            // 
            this.gameEngine.Enabled = true;
            this.gameEngine.Interval = 20;
            this.gameEngine.Tick += new System.EventHandler(this.gameEngine_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.timeLabel.Location = new System.Drawing.Point(4, 17);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(316, 23);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "timeLabel";
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.scoreLabel.Location = new System.Drawing.Point(4, 40);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(267, 23);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "scoreLabel";
            // 
            // roundLabel
            // 
            this.roundLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.roundLabel.Location = new System.Drawing.Point(4, 63);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(300, 23);
            this.roundLabel.TabIndex = 3;
            this.roundLabel.Text = "roundLabel";
            // 
            // bossNameLabel
            // 
            this.bossNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.bossNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bossNameLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.bossNameLabel.Location = new System.Drawing.Point(228, 0);
            this.bossNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bossNameLabel.Name = "bossNameLabel";
            this.bossNameLabel.Size = new System.Drawing.Size(584, 121);
            this.bossNameLabel.TabIndex = 10;
            this.bossNameLabel.Text = "Galactic Insect";
            this.bossNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bossNameLabel.Visible = false;
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Transparent;
            this.heart1.Image = global::galaga.Properties.Resources.resizeHeart;
            this.heart1.Location = new System.Drawing.Point(950, 638);
            this.heart1.Margin = new System.Windows.Forms.Padding(4);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(97, 74);
            this.heart1.TabIndex = 11;
            this.heart1.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Transparent;
            this.heart2.Image = global::galaga.Properties.Resources.resizeHeart;
            this.heart2.Location = new System.Drawing.Point(950, 556);
            this.heart2.Margin = new System.Windows.Forms.Padding(4);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(97, 74);
            this.heart2.TabIndex = 12;
            this.heart2.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Transparent;
            this.heart3.Image = global::galaga.Properties.Resources.resizeHeart;
            this.heart3.Location = new System.Drawing.Point(950, 474);
            this.heart3.Margin = new System.Windows.Forms.Padding(4);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(97, 74);
            this.heart3.TabIndex = 13;
            this.heart3.TabStop = false;
            // 
            // roundStartLabel
            // 
            this.roundStartLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundStartLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.roundStartLabel.Location = new System.Drawing.Point(233, 298);
            this.roundStartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundStartLabel.Name = "roundStartLabel";
            this.roundStartLabel.Size = new System.Drawing.Size(584, 121);
            this.roundStartLabel.TabIndex = 14;
            this.roundStartLabel.Text = "round start";
            this.roundStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundStartLabel.Visible = false;
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundStartLabel);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.bossNameLabel);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.timeLabel);
            this.Name = "gameScreen";
            this.Size = new System.Drawing.Size(1051, 716);
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameEngine;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label bossNameLabel;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.Label roundStartLabel;
    }
}

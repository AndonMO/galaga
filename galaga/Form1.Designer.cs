namespace galaga
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameEngine = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundStartLabel = new System.Windows.Forms.Label();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.bossNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameEngine
            // 
            this.gameEngine.Enabled = true;
            this.gameEngine.Interval = 20;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.timeLabel.Location = new System.Drawing.Point(16, 11);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(316, 23);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "timeLabel";
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.scoreLabel.Location = new System.Drawing.Point(16, 34);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(267, 23);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "scoreLabel";
            // 
            // roundLabel
            // 
            this.roundLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.roundLabel.Location = new System.Drawing.Point(16, 58);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(300, 23);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "roundLabel";
            // 
            // roundStartLabel
            // 
            this.roundStartLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundStartLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.roundStartLabel.Location = new System.Drawing.Point(244, 308);
            this.roundStartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundStartLabel.Name = "roundStartLabel";
            this.roundStartLabel.Size = new System.Drawing.Size(584, 76);
            this.roundStartLabel.TabIndex = 3;
            this.roundStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Transparent;
            this.heart3.Image = global::galaga.Properties.Resources.resizeHeart;
            this.heart3.Location = new System.Drawing.Point(953, 487);
            this.heart3.Margin = new System.Windows.Forms.Padding(4);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(97, 74);
            this.heart3.TabIndex = 6;
            this.heart3.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Transparent;
            this.heart2.Image = global::galaga.Properties.Resources.resizeHeart;
            this.heart2.Location = new System.Drawing.Point(953, 569);
            this.heart2.Margin = new System.Windows.Forms.Padding(4);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(97, 74);
            this.heart2.TabIndex = 5;
            this.heart2.TabStop = false;
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Transparent;
            this.heart1.Image = global::galaga.Properties.Resources.resizeHeart;
            this.heart1.Location = new System.Drawing.Point(953, 650);
            this.heart1.Margin = new System.Windows.Forms.Padding(4);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(97, 74);
            this.heart1.TabIndex = 4;
            this.heart1.TabStop = false;
            // 
            // bossNameLabel
            // 
            this.bossNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.bossNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bossNameLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.bossNameLabel.Location = new System.Drawing.Point(244, -7);
            this.bossNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bossNameLabel.Name = "bossNameLabel";
            this.bossNameLabel.Size = new System.Drawing.Size(584, 121);
            this.bossNameLabel.TabIndex = 9;
            this.bossNameLabel.Text = "Galactic Insect";
            this.bossNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bossNameLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1051, 716);
            this.Controls.Add(this.bossNameLabel);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.roundStartLabel);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.timeLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sky Blaster";
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameEngine;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label roundStartLabel;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.Label bossNameLabel;
    }
}


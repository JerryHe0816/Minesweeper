﻿namespace Minesweeper
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.gameProgress = new System.Windows.Forms.ProgressBar();
            this.score = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.remainingFlags = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.secondsBox = new System.Windows.Forms.TextBox();
            this.minutesBox = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coef = new System.Windows.Forms.TextBox();
            this.percent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameProgress
            // 
            this.gameProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gameProgress.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gameProgress.Location = new System.Drawing.Point(0, 651);
            this.gameProgress.MarqueeAnimationSpeed = 0;
            this.gameProgress.Name = "gameProgress";
            this.gameProgress.Size = new System.Drawing.Size(884, 10);
            this.gameProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.gameProgress.TabIndex = 0;
            this.gameProgress.Click += new System.EventHandler(this.gameProgress_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.score.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(12, 614);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(92, 29);
            this.score.TabIndex = 1;
            this.score.Text = "Score:";
            // 
            // heightBox
            // 
            this.heightBox.BackColor = System.Drawing.Color.Silver;
            this.heightBox.Location = new System.Drawing.Point(369, 39);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(35, 20);
            this.heightBox.TabIndex = 2;
            // 
            // widthBox
            // 
            this.widthBox.BackColor = System.Drawing.Color.Silver;
            this.widthBox.Location = new System.Drawing.Point(556, 38);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(35, 20);
            this.widthBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height (5 - 25):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Width (5 - 40):";
            // 
            // Play
            // 
            this.Play.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(632, 33);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(237, 29);
            this.Play.TabIndex = 6;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mine Density:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 14;
            // 
            // remainingFlags
            // 
            this.remainingFlags.AutoSize = true;
            this.remainingFlags.BackColor = System.Drawing.Color.Transparent;
            this.remainingFlags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remainingFlags.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingFlags.Location = new System.Drawing.Point(189, 614);
            this.remainingFlags.Name = "remainingFlags";
            this.remainingFlags.Size = new System.Drawing.Size(83, 29);
            this.remainingFlags.TabIndex = 15;
            this.remainingFlags.Text = "Flags:";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // secondsBox
            // 
            this.secondsBox.BackColor = System.Drawing.Color.SpringGreen;
            this.secondsBox.Enabled = false;
            this.secondsBox.Location = new System.Drawing.Point(849, 623);
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(23, 20);
            this.secondsBox.TabIndex = 16;
            // 
            // minutesBox
            // 
            this.minutesBox.BackColor = System.Drawing.Color.SpringGreen;
            this.minutesBox.Enabled = false;
            this.minutesBox.Location = new System.Drawing.Point(815, 623);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(23, 20);
            this.minutesBox.TabIndex = 17;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(729, 616);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(80, 29);
            this.time.TabIndex = 18;
            this.time.Text = "Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(837, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = ":";
            // 
            // coef
            // 
            this.coef.Location = new System.Drawing.Point(153, 37);
            this.coef.Name = "coef";
            this.coef.Size = new System.Drawing.Size(41, 20);
            this.coef.TabIndex = 20;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.BackColor = System.Drawing.Color.Transparent;
            this.percent.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(189, 37);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(21, 21);
            this.percent.TabIndex = 21;
            this.percent.Text = "%";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.coef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.secondsBox);
            this.Controls.Add(this.remainingFlags);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.score);
            this.Controls.Add(this.gameProgress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 554);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar gameProgress;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label remainingFlags;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox secondsBox;
        private System.Windows.Forms.TextBox minutesBox;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox coef;
        private System.Windows.Forms.Label percent;
    }
}
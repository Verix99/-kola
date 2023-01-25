
namespace PONG_hra
{
    partial class PONG_2
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
            this.ball = new System.Windows.Forms.PictureBox();
            this.playerBlue = new System.Windows.Forms.PictureBox();
            this.playerRed = new System.Windows.Forms.PictureBox();
            this.blueScore = new System.Windows.Forms.Label();
            this.redScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRed)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ball.Location = new System.Drawing.Point(464, 394);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(26, 26);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // playerBlue
            // 
            this.playerBlue.BackColor = System.Drawing.Color.Blue;
            this.playerBlue.Location = new System.Drawing.Point(12, 255);
            this.playerBlue.Name = "playerBlue";
            this.playerBlue.Size = new System.Drawing.Size(27, 127);
            this.playerBlue.TabIndex = 1;
            this.playerBlue.TabStop = false;
            // 
            // playerRed
            // 
            this.playerRed.BackColor = System.Drawing.Color.Red;
            this.playerRed.Location = new System.Drawing.Point(840, 241);
            this.playerRed.Name = "playerRed";
            this.playerRed.Size = new System.Drawing.Size(27, 127);
            this.playerRed.TabIndex = 2;
            this.playerRed.TabStop = false;
            // 
            // blueScore
            // 
            this.blueScore.AutoSize = true;
            this.blueScore.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueScore.Location = new System.Drawing.Point(123, 9);
            this.blueScore.Name = "blueScore";
            this.blueScore.Size = new System.Drawing.Size(45, 35);
            this.blueScore.TabIndex = 3;
            this.blueScore.Text = "00";
            // 
            // redScore
            // 
            this.redScore.AutoSize = true;
            this.redScore.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redScore.Location = new System.Drawing.Point(703, 9);
            this.redScore.Name = "redScore";
            this.redScore.Size = new System.Drawing.Size(45, 35);
            this.redScore.TabIndex = 4;
            this.redScore.Text = "00";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTicks);
            // 
            // PONG_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 574);
            this.Controls.Add(this.redScore);
            this.Controls.Add(this.blueScore);
            this.Controls.Add(this.playerRed);
            this.Controls.Add(this.playerBlue);
            this.Controls.Add(this.ball);
            this.Name = "PONG_2";
            this.Text = "PONG 1v1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox playerBlue;
        private System.Windows.Forms.PictureBox playerRed;
        private System.Windows.Forms.Label blueScore;
        private System.Windows.Forms.Label redScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}
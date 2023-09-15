namespace SpaceInvaders
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainTimer = new System.Windows.Forms.Timer(components);
            scoreLabel = new Label();
            SuspendLayout();
            // 
            // mainTimer
            // 
            mainTimer.Interval = 16;
            mainTimer.Tick += mainTimer_Tick;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.ForeColor = Color.Yellow;
            scoreLabel.Location = new Point(23, 20);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(103, 28);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "SCORE:  0";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 575);
            Controls.Add(scoreLabel);
            Name = "Game";
            Text = "Space Invaders";
            Load += Game_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer mainTimer;
        private Label scoreLabel;
    }
}
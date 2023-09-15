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
            button1 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
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
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(637, 20);
            button1.Name = "button1";
            button1.Size = new Size(113, 33);
            button1.TabIndex = 1;
            button1.Text = "Pause";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(368, 20);
            label1.Name = "label1";
            label1.Size = new Size(72, 31);
            label1.TabIndex = 2;
            label1.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += gameTimer_Tick;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(scoreLabel);
            Controls.Add(label1);
            Controls.Add(button1);
            KeyPreview = true;
            Name = "Game";
            Text = "Space Invaders";
            Load += Game_Load;
            KeyDown += this.Form1_KeyDown;
            KeyUp += this.Form1_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        private void PlayPauseButton_Clickk(object sender, EventArgs e)
        {

        }

        #endregion
        private System.Windows.Forms.Timer mainTimer;
        private Label scoreLabel;
        private Button button1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
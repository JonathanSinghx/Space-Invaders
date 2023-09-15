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
            playerBox = new PictureBox();
            mainTimer = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)playerBox).BeginInit();
            SuspendLayout();
            // 
            // playerBox
            // 
            playerBox.BackColor = SystemColors.Highlight;
            playerBox.Location = new Point(352, 517);
            playerBox.Name = "playerBox";
            playerBox.Size = new Size(75, 46);
            playerBox.TabIndex = 0;
            playerBox.TabStop = false;
            playerBox.Click += playerBox_Click;
            // 
            // mainTimer
            // 
            mainTimer.Interval = 16;
            mainTimer.Tick += mainTimer_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(637, 27);
            button1.Name = "button1";
            button1.Size = new Size(113, 43);
            button1.TabIndex = 1;
            button1.Text = "Pause";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(button1);
            Controls.Add(playerBox);
            Name = "Game";
            Text = "Space Invaders";
            Load += Game_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)playerBox).EndInit();
            ResumeLayout(false);
        }

        private void PlayPauseButton_Clickk(object sender, EventArgs e)
        {

        }



        #endregion

        private PictureBox playerBox;
        private System.Windows.Forms.Timer mainTimer;
        private Button button1;
    }
}
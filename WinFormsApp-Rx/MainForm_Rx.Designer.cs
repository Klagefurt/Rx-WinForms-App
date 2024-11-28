namespace WinFormsApp_Rx
{
    partial class MainForm_Rx
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
            progressBar = new ProgressBar();
            startButton = new Button();
            stopButton = new Button();
            timeLabel = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(73, 146);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(416, 29);
            progressBar.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.Location = new Point(259, 225);
            startButton.Name = "startButton";
            startButton.Size = new Size(100, 30);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += start_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(389, 225);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(100, 30);
            stopButton.TabIndex = 2;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stop_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(73, 82);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(42, 20);
            timeLabel.TabIndex = 3;
            timeLabel.Text = "Time";
            // 
            // MainForm_Rx
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 360);
            Controls.Add(timeLabel);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Controls.Add(progressBar);
            Name = "MainForm_Rx";
            Text = "MainForm_Rx";
            Load += MainForm_Rx_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private Button startButton;
        private Button stopButton;
        private Label timeLabel;
    }
}

namespace DarkAndDarker
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.cordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 60;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(39, 35);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(517, 78);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dark and Darker 2D";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(231, 262);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(145, 72);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_click);
            // 
            // cordLabel
            // 
            this.cordLabel.AutoSize = true;
            this.cordLabel.BackColor = System.Drawing.Color.Transparent;
            this.cordLabel.ForeColor = System.Drawing.Color.Lime;
            this.cordLabel.Location = new System.Drawing.Point(58, 54);
            this.cordLabel.Name = "cordLabel";
            this.cordLabel.Size = new System.Drawing.Size(35, 13);
            this.cordLabel.TabIndex = 2;
            this.cordLabel.Text = "label1";
            this.cordLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.cordLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dark and Darker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label cordLabel;
    }
}


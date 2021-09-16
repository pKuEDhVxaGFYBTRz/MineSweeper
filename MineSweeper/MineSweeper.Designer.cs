namespace MineSweeper
{
    partial class MainMenu
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
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.Button();
            this.leaderboards = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.mainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Controls.Add(this.settings);
            this.mainMenuPanel.Controls.Add(this.leaderboards);
            this.mainMenuPanel.Controls.Add(this.start);
            this.mainMenuPanel.Location = new System.Drawing.Point(12, 12);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(369, 311);
            this.mainMenuPanel.TabIndex = 0;
            // 
            // gamePanel
            // 
            this.gamePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(369, 311);
            this.gamePanel.TabIndex = 6;
            this.gamePanel.Visible = false;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // settings
            // 
            this.settings.AutoSize = true;
            this.settings.Location = new System.Drawing.Point(73, 208);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(223, 90);
            this.settings.TabIndex = 5;
            this.settings.Text = "settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // leaderboards
            // 
            this.leaderboards.AutoSize = true;
            this.leaderboards.Location = new System.Drawing.Point(73, 110);
            this.leaderboards.Name = "leaderboards";
            this.leaderboards.Size = new System.Drawing.Size(223, 90);
            this.leaderboards.TabIndex = 4;
            this.leaderboards.Text = "LeaderBoards";
            this.leaderboards.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(73, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(223, 90);
            this.start.TabIndex = 3;
            this.start.Text = "play";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(395, 335);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.mainMenuPanel);
            this.Name = "MainMenu";
            this.Text = "MineSweeper";
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button leaderboards;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel gamePanel;
    }
}


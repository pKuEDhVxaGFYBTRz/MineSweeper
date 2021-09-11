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
            this.mainMenuPannel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.settings = new System.Windows.Forms.Button();
            this.leaderboards = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.mainMenuPannel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuPannel
            // 
            this.mainMenuPannel.Controls.Add(this.gamePanel);
            this.mainMenuPannel.Controls.Add(this.settings);
            this.mainMenuPannel.Controls.Add(this.leaderboards);
            this.mainMenuPannel.Controls.Add(this.start);
            this.mainMenuPannel.Location = new System.Drawing.Point(12, 12);
            this.mainMenuPannel.Name = "mainMenuPannel";
            this.mainMenuPannel.Size = new System.Drawing.Size(369, 311);
            this.mainMenuPannel.TabIndex = 0;
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.dataGridView1);
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(369, 311);
            this.gamePanel.TabIndex = 6;
            this.gamePanel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.ClientSize = new System.Drawing.Size(393, 335);
            this.Controls.Add(this.mainMenuPannel);
            this.Name = "MainMenu";
            this.Text = "MineSweeper";
            this.mainMenuPannel.ResumeLayout(false);
            this.mainMenuPannel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuPannel;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button leaderboards;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


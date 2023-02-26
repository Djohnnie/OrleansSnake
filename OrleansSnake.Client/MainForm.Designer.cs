namespace OrleansSnake.Client
{
    partial class MainForm
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
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.joinGameButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.lobbyPanel = new System.Windows.Forms.Panel();
            this.currentGameCodeLabel = new System.Windows.Forms.Label();
            this.readyButton = new System.Windows.Forms.Button();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.joinPanel = new System.Windows.Forms.Panel();
            this.gameCodeLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.gameCodeTextBox = new System.Windows.Forms.TextBox();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.lobbyButton = new System.Windows.Forms.Button();
            this.mainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.lobbyPanel.SuspendLayout();
            this.joinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainMenuPanel.BackColor = System.Drawing.Color.White;
            this.mainMenuPanel.Controls.Add(this.pictureBox1);
            this.mainMenuPanel.Controls.Add(this.label2);
            this.mainMenuPanel.Controls.Add(this.label1);
            this.mainMenuPanel.Controls.Add(this.joinGameButton);
            this.mainMenuPanel.Controls.Add(this.newGameButton);
            this.mainMenuPanel.Location = new System.Drawing.Point(249, 305);
            this.mainMenuPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(1151, 435);
            this.mainMenuPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OrleansSnake.Client.Properties.Resources.snake;
            this.pictureBox1.Location = new System.Drawing.Point(383, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(805, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 132);
            this.label2.TabIndex = 4;
            this.label2.Text = "Snake";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 132);
            this.label1.TabIndex = 3;
            this.label1.Text = "Orleans";
            // 
            // joinGameButton
            // 
            this.joinGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(50)))), ((int)(((byte)(102)))));
            this.joinGameButton.ForeColor = System.Drawing.Color.White;
            this.joinGameButton.Location = new System.Drawing.Point(605, 337);
            this.joinGameButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.joinGameButton.Name = "joinGameButton";
            this.joinGameButton.Size = new System.Drawing.Size(409, 79);
            this.joinGameButton.TabIndex = 1;
            this.joinGameButton.Text = "JOIN EXISTING GAME";
            this.joinGameButton.UseVisualStyleBackColor = false;
            this.joinGameButton.Click += new System.EventHandler(this.joinGameButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(50)))), ((int)(((byte)(102)))));
            this.newGameButton.ForeColor = System.Drawing.Color.White;
            this.newGameButton.Location = new System.Drawing.Point(124, 337);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(409, 79);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "START NEW GAME";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(11, 1090);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1623, 41);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Connecting to the game server...";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lobbyPanel
            // 
            this.lobbyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lobbyPanel.BackColor = System.Drawing.Color.White;
            this.lobbyPanel.Controls.Add(this.currentGameCodeLabel);
            this.lobbyPanel.Controls.Add(this.readyButton);
            this.lobbyPanel.Controls.Add(this.playersListBox);
            this.lobbyPanel.Location = new System.Drawing.Point(50, 53);
            this.lobbyPanel.Margin = new System.Windows.Forms.Padding(6);
            this.lobbyPanel.Name = "lobbyPanel";
            this.lobbyPanel.Size = new System.Drawing.Size(1543, 954);
            this.lobbyPanel.TabIndex = 2;
            // 
            // currentGameCodeLabel
            // 
            this.currentGameCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentGameCodeLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentGameCodeLabel.Location = new System.Drawing.Point(6, 0);
            this.currentGameCodeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentGameCodeLabel.Name = "currentGameCodeLabel";
            this.currentGameCodeLabel.Size = new System.Drawing.Size(1532, 194);
            this.currentGameCodeLabel.TabIndex = 3;
            this.currentGameCodeLabel.Text = "#";
            this.currentGameCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readyButton
            // 
            this.readyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.readyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(50)))), ((int)(((byte)(102)))));
            this.readyButton.ForeColor = System.Drawing.Color.White;
            this.readyButton.Location = new System.Drawing.Point(613, 858);
            this.readyButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(409, 79);
            this.readyButton.TabIndex = 2;
            this.readyButton.Text = "I\'M READY";
            this.readyButton.UseVisualStyleBackColor = false;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // playersListBox
            // 
            this.playersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playersListBox.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.IntegralHeight = false;
            this.playersListBox.ItemHeight = 170;
            this.playersListBox.Location = new System.Drawing.Point(78, 201);
            this.playersListBox.Margin = new System.Windows.Forms.Padding(6);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.playersListBox.Size = new System.Drawing.Size(1382, 640);
            this.playersListBox.TabIndex = 1;
            // 
            // joinPanel
            // 
            this.joinPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.joinPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.joinPanel.Controls.Add(this.gameCodeLabel);
            this.joinPanel.Controls.Add(this.playerNameLabel);
            this.joinPanel.Controls.Add(this.gameCodeTextBox);
            this.joinPanel.Controls.Add(this.playerNameTextBox);
            this.joinPanel.Controls.Add(this.lobbyButton);
            this.joinPanel.Location = new System.Drawing.Point(422, 284);
            this.joinPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.joinPanel.Name = "joinPanel";
            this.joinPanel.Size = new System.Drawing.Size(787, 435);
            this.joinPanel.TabIndex = 3;
            // 
            // gameCodeLabel
            // 
            this.gameCodeLabel.AutoSize = true;
            this.gameCodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameCodeLabel.Location = new System.Drawing.Point(308, 13);
            this.gameCodeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gameCodeLabel.Name = "gameCodeLabel";
            this.gameCodeLabel.Size = new System.Drawing.Size(187, 45);
            this.gameCodeLabel.TabIndex = 4;
            this.gameCodeLabel.Text = "Game Code";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerNameLabel.Location = new System.Drawing.Point(303, 171);
            this.playerNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(199, 45);
            this.playerNameLabel.TabIndex = 3;
            this.playerNameLabel.Text = "Player Name";
            // 
            // gameCodeTextBox
            // 
            this.gameCodeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameCodeTextBox.Location = new System.Drawing.Point(6, 64);
            this.gameCodeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.gameCodeTextBox.Name = "gameCodeTextBox";
            this.gameCodeTextBox.Size = new System.Drawing.Size(773, 86);
            this.gameCodeTextBox.TabIndex = 2;
            this.gameCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerNameTextBox.Location = new System.Drawing.Point(6, 222);
            this.playerNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(773, 86);
            this.playerNameTextBox.TabIndex = 1;
            this.playerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lobbyButton
            // 
            this.lobbyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(50)))), ((int)(((byte)(102)))));
            this.lobbyButton.ForeColor = System.Drawing.Color.White;
            this.lobbyButton.Location = new System.Drawing.Point(191, 331);
            this.lobbyButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lobbyButton.Name = "lobbyButton";
            this.lobbyButton.Size = new System.Drawing.Size(409, 79);
            this.lobbyButton.TabIndex = 0;
            this.lobbyButton.Text = "OPEN GAME LOBBY";
            this.lobbyButton.UseVisualStyleBackColor = false;
            this.lobbyButton.Click += new System.EventHandler(this.lobbyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(50)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1647, 1060);
            this.Controls.Add(this.joinPanel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.mainMenuPanel);
            this.Controls.Add(this.lobbyPanel);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.Text = "CloudSnake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.lobbyPanel.ResumeLayout(false);
            this.joinPanel.ResumeLayout(false);
            this.joinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private Panel mainMenuPanel;
        private Button joinGameButton;
        private Button newGameButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label statusLabel;
        private Panel lobbyPanel;
        private ListBox playersListBox;
        private Button readyButton;
        private Panel joinPanel;
        private Button lobbyButton;
        private TextBox playerNameTextBox;
        private TextBox gameCodeTextBox;
        private Label gameCodeLabel;
        private Label playerNameLabel;
        private Label currentGameCodeLabel;

        #endregion
    }
}
namespace ProgrammingAssignment2A
{
    partial class GameForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.countLabel = new System.Windows.Forms.Label();
            this.againstLabel = new System.Windows.Forms.TextBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.inFavourTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scoreMarkLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startGameButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.disppearingSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gameProgressBar = new ProgrammingAssignment2A.VerticalProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panelsTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.countLabel);
            this.panel1.Controls.Add(this.againstLabel);
            this.panel1.Controls.Add(this.averageLabel);
            this.panel1.Controls.Add(this.inFavourTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.scoreMarkLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.startGameButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.disppearingSpeedTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 100);
            this.panel1.TabIndex = 0;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(540, 65);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(44, 13);
            this.countLabel.TabIndex = 13;
            this.countLabel.Text = "Count 0";
            // 
            // againstLabel
            // 
            this.againstLabel.Location = new System.Drawing.Point(488, 62);
            this.againstLabel.Name = "againstLabel";
            this.againstLabel.Size = new System.Drawing.Size(46, 20);
            this.againstLabel.TabIndex = 12;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(424, 65);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(35, 13);
            this.averageLabel.TabIndex = 11;
            this.averageLabel.Text = "Avg 0";
            // 
            // inFavourTextBox
            // 
            this.inFavourTextBox.Location = new System.Drawing.Point(372, 62);
            this.inFavourTextBox.Name = "inFavourTextBox";
            this.inFavourTextBox.Size = new System.Drawing.Size(46, 20);
            this.inFavourTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(485, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "AGAINST";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(369, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "IN FAVOUR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "POINTS";
            // 
            // scoreMarkLabel
            // 
            this.scoreMarkLabel.AutoSize = true;
            this.scoreMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreMarkLabel.Location = new System.Drawing.Point(251, 40);
            this.scoreMarkLabel.Name = "scoreMarkLabel";
            this.scoreMarkLabel.Size = new System.Drawing.Size(50, 29);
            this.scoreMarkLabel.TabIndex = 6;
            this.scoreMarkLabel.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Scored Mark";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Location = new System.Drawing.Point(359, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 88);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Location = new System.Drawing.Point(174, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 88);
            this.panel2.TabIndex = 3;
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(12, 60);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(133, 23);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Go!";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ms";
            // 
            // disppearingSpeedTextBox
            // 
            this.disppearingSpeedTextBox.Location = new System.Drawing.Point(112, 18);
            this.disppearingSpeedTextBox.Name = "disppearingSpeedTextBox";
            this.disppearingSpeedTextBox.Size = new System.Drawing.Size(33, 20);
            this.disppearingSpeedTextBox.TabIndex = 1;
            this.disppearingSpeedTextBox.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disappering Speed";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(2, 397);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(599, 49);
            this.panel4.TabIndex = 2;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gamePanel.Controls.Add(this.gameProgressBar);
            this.gamePanel.Location = new System.Drawing.Point(2, 103);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(599, 294);
            this.gamePanel.TabIndex = 3;
            // 
            // gameProgressBar
            // 
            this.gameProgressBar.BackColor = System.Drawing.Color.Lime;
            this.gameProgressBar.ForeColor = System.Drawing.Color.Lime;
            this.gameProgressBar.Location = new System.Drawing.Point(576, 0);
            this.gameProgressBar.Maximum = 30;
            this.gameProgressBar.Name = "gameProgressBar";
            this.gameProgressBar.Size = new System.Drawing.Size(21, 294);
            this.gameProgressBar.TabIndex = 0;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            // 
            // panelsTimer
            // 
            this.panelsTimer.Enabled = true;
            this.panelsTimer.Interval = 30;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(602, 446);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "GameForm";
            this.Text = "Grab Your Marks";
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox againstLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.TextBox inFavourTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label scoreMarkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox disppearingSpeedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel gamePanel;
        private VerticalProgressBar gameProgressBar;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer panelsTimer;
    }
}


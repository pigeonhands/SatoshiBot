namespace Satoshi_GUI
{
    partial class gamePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputLog = new System.Windows.Forms.RichTextBox();
            this.winStats = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.satoshi_grid1 = new Satoshi_GUI.Satoshi_grid();
            this.gameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputLog
            // 
            this.outputLog.Location = new System.Drawing.Point(147, 83);
            this.outputLog.Name = "outputLog";
            this.outputLog.ReadOnly = true;
            this.outputLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.outputLog.Size = new System.Drawing.Size(307, 66);
            this.outputLog.TabIndex = 13;
            this.outputLog.Text = "";
            // 
            // winStats
            // 
            this.winStats.AutoSize = true;
            this.winStats.Location = new System.Drawing.Point(190, 45);
            this.winStats.Name = "winStats";
            this.winStats.Size = new System.Drawing.Size(118, 13);
            this.winStats.TabIndex = 12;
            this.winStats.Text = "0% | Wins: 0 | Losses: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Win %:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Controls.Add(this.satoshi_grid1);
            this.gameGroupBox.Controls.Add(this.button1);
            this.gameGroupBox.Controls.Add(this.button2);
            this.gameGroupBox.Controls.Add(this.label2);
            this.gameGroupBox.Controls.Add(this.outputLog);
            this.gameGroupBox.Controls.Add(this.winStats);
            this.gameGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gameGroupBox.Location = new System.Drawing.Point(7, 3);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(464, 160);
            this.gameGroupBox.TabIndex = 16;
            this.gameGroupBox.TabStop = false;
            // 
            // satoshi_grid1
            // 
            this.satoshi_grid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.satoshi_grid1.Location = new System.Drawing.Point(6, 19);
            this.satoshi_grid1.Name = "satoshi_grid1";
            this.satoshi_grid1.Size = new System.Drawing.Size(132, 132);
            this.satoshi_grid1.TabIndex = 9;
            // 
            // gamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gameGroupBox);
            this.Name = "gamePanel";
            this.Size = new System.Drawing.Size(474, 174);
            this.Load += new System.EventHandler(this.gamePanel_Load);
            this.gameGroupBox.ResumeLayout(false);
            this.gameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputLog;
        private System.Windows.Forms.Label winStats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Satoshi_grid satoshi_grid1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gameGroupBox;
    }
}

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
            this.components = new System.ComponentModel.Container();
            this.outputLog = new System.Windows.Forms.RichTextBox();
            this.winStats = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.liveBitsBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gameSquares = new Satoshi_GUI.Controls.SatoshiGrid();
            this.cmManualBet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputLog
            // 
            this.outputLog.Location = new System.Drawing.Point(105, 37);
            this.outputLog.Name = "outputLog";
            this.outputLog.ReadOnly = true;
            this.outputLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.outputLog.Size = new System.Drawing.Size(340, 93);
            this.outputLog.TabIndex = 13;
            this.outputLog.Text = "";
            // 
            // winStats
            // 
            this.winStats.AutoSize = true;
            this.winStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winStats.Location = new System.Drawing.Point(193, 17);
            this.winStats.Name = "winStats";
            this.winStats.Size = new System.Drawing.Size(145, 16);
            this.winStats.TabIndex = 12;
            this.winStats.Text = "0% | Wins: 0 | Losses: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Win %:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Meiryo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(105, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Meiryo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Controls.Add(this.liveBitsBox);
            this.gameGroupBox.Controls.Add(this.button4);
            this.gameGroupBox.Controls.Add(this.winStats);
            this.gameGroupBox.Controls.Add(this.button3);
            this.gameGroupBox.Controls.Add(this.label2);
            this.gameGroupBox.Controls.Add(this.gameSquares);
            this.gameGroupBox.Controls.Add(this.button1);
            this.gameGroupBox.Controls.Add(this.button2);
            this.gameGroupBox.Controls.Add(this.outputLog);
            this.gameGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gameGroupBox.Location = new System.Drawing.Point(7, 0);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(451, 179);
            this.gameGroupBox.TabIndex = 16;
            this.gameGroupBox.TabStop = false;
            // 
            // liveBitsBox
            // 
            this.liveBitsBox.Location = new System.Drawing.Point(6, 15);
            this.liveBitsBox.Name = "liveBitsBox";
            this.liveBitsBox.ReadOnly = true;
            this.liveBitsBox.Size = new System.Drawing.Size(93, 20);
            this.liveBitsBox.TabIndex = 18;
            this.liveBitsBox.Text = "Bits | Disabled";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 33);
            this.button4.TabIndex = 17;
            this.button4.Text = "Pause";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 20);
            this.button3.TabIndex = 16;
            this.button3.Text = "R";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gameSquares
            // 
            this.gameSquares.ContextMenuStrip = this.cmManualBet;
            this.gameSquares.GridBorder = true;
            this.gameSquares.Location = new System.Drawing.Point(6, 37);
            this.gameSquares.Name = "gameSquares";
            this.gameSquares.Size = new System.Drawing.Size(93, 93);
            this.gameSquares.SquareBorder = true;
            this.gameSquares.TabIndex = 15;
            this.gameSquares.Text = "satoshiGrid1";
            // 
            // cmManualBet
            // 
            this.cmManualBet.Name = "cmManualBet";
            this.cmManualBet.Size = new System.Drawing.Size(61, 4);
            // 
            // gamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gameGroupBox);
            this.Name = "gamePanel";
            this.Size = new System.Drawing.Size(461, 188);
            this.gameGroupBox.ResumeLayout(false);
            this.gameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputLog;
        private System.Windows.Forms.Label winStats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gameGroupBox;
        private Controls.SatoshiGrid gameSquares;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox liveBitsBox;
        private System.Windows.Forms.ContextMenuStrip cmManualBet;
    }
}

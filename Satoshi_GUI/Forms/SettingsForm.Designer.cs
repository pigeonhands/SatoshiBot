namespace Satoshi_GUI
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pHash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.numberofBets = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.betCostNUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.stopAfterWinCheck = new System.Windows.Forms.CheckBox();
            this.showExWindow = new System.Windows.Forms.CheckBox();
            this.precentOnLoss = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.useStratCheck = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showGBombsCheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cfgTag = new System.Windows.Forms.TextBox();
            this.stratDisplay = new Satoshi_GUI.Controls.SatoshiGrid();
            ((System.ComponentModel.ISupportInitialize)(this.numberofBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betCostNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precentOnLoss)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Hash:";
            // 
            // pHash
            // 
            this.pHash.Location = new System.Drawing.Point(92, 3);
            this.pHash.Name = "pHash";
            this.pHash.Size = new System.Drawing.Size(176, 20);
            this.pHash.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mines:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(77, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(128, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "3";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(179, 55);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "5";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(230, 55);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.Text = "24";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of bets:";
            // 
            // numberofBets
            // 
            this.numberofBets.Location = new System.Drawing.Point(92, 82);
            this.numberofBets.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numberofBets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberofBets.Name = "numberofBets";
            this.numberofBets.Size = new System.Drawing.Size(176, 20);
            this.numberofBets.TabIndex = 8;
            this.numberofBets.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // betCostNUD
            // 
            this.betCostNUD.Location = new System.Drawing.Point(93, 108);
            this.betCostNUD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.betCostNUD.Name = "betCostNUD";
            this.betCostNUD.Size = new System.Drawing.Size(176, 20);
            this.betCostNUD.TabIndex = 11;
            this.betCostNUD.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bet Cost:";
            // 
            // stopAfterWinCheck
            // 
            this.stopAfterWinCheck.AutoSize = true;
            this.stopAfterWinCheck.Location = new System.Drawing.Point(7, 158);
            this.stopAfterWinCheck.Name = "stopAfterWinCheck";
            this.stopAfterWinCheck.Size = new System.Drawing.Size(91, 17);
            this.stopAfterWinCheck.TabIndex = 13;
            this.stopAfterWinCheck.Text = "Stop after win";
            this.stopAfterWinCheck.UseVisualStyleBackColor = true;
            // 
            // showExWindow
            // 
            this.showExWindow.AutoSize = true;
            this.showExWindow.Location = new System.Drawing.Point(128, 157);
            this.showExWindow.Name = "showExWindow";
            this.showExWindow.Size = new System.Drawing.Size(141, 17);
            this.showExWindow.TabIndex = 14;
            this.showExWindow.Text = "Show exception window";
            this.showExWindow.UseVisualStyleBackColor = true;
            // 
            // precentOnLoss
            // 
            this.precentOnLoss.Location = new System.Drawing.Point(94, 132);
            this.precentOnLoss.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.precentOnLoss.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.precentOnLoss.Name = "precentOnLoss";
            this.precentOnLoss.Size = new System.Drawing.Size(174, 20);
            this.precentOnLoss.TabIndex = 15;
            this.precentOnLoss.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Percent on loss:";
            // 
            // useStratCheck
            // 
            this.useStratCheck.AutoSize = true;
            this.useStratCheck.Location = new System.Drawing.Point(5, 1);
            this.useStratCheck.Name = "useStratCheck";
            this.useStratCheck.Size = new System.Drawing.Size(87, 17);
            this.useStratCheck.TabIndex = 17;
            this.useStratCheck.Text = "Use Strategy";
            this.useStratCheck.UseVisualStyleBackColor = true;
            this.useStratCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stratDisplay);
            this.groupBox2.Controls.Add(this.useStratCheck);
            this.groupBox2.Location = new System.Drawing.Point(7, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 82);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // showGBombsCheck
            // 
            this.showGBombsCheck.AutoSize = true;
            this.showGBombsCheck.Location = new System.Drawing.Point(128, 181);
            this.showGBombsCheck.Name = "showGBombsCheck";
            this.showGBombsCheck.Size = new System.Drawing.Size(119, 17);
            this.showGBombsCheck.TabIndex = 19;
            this.showGBombsCheck.Text = "Show Game Bombs";
            this.showGBombsCheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Config Tag (opt):";
            // 
            // cfgTag
            // 
            this.cfgTag.Location = new System.Drawing.Point(92, 28);
            this.cfgTag.Name = "cfgTag";
            this.cfgTag.Size = new System.Drawing.Size(176, 20);
            this.cfgTag.TabIndex = 21;
            // 
            // stratDisplay
            // 
            this.stratDisplay.GridBorder = false;
            this.stratDisplay.Location = new System.Drawing.Point(19, 20);
            this.stratDisplay.Name = "stratDisplay";
            this.stratDisplay.Size = new System.Drawing.Size(57, 57);
            this.stratDisplay.SquareBorder = true;
            this.stratDisplay.TabIndex = 18;
            this.stratDisplay.Text = "satoshiGrid1";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 296);
            this.Controls.Add(this.cfgTag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showGBombsCheck);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.precentOnLoss);
            this.Controls.Add(this.showExWindow);
            this.Controls.Add(this.stopAfterWinCheck);
            this.Controls.Add(this.betCostNUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberofBets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pHash);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberofBets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betCostNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precentOnLoss)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pHash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberofBets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown betCostNUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox stopAfterWinCheck;
        private System.Windows.Forms.CheckBox showExWindow;
        private System.Windows.Forms.NumericUpDown precentOnLoss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox useStratCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox showGBombsCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cfgTag;
        private Controls.SatoshiGrid stratDisplay;
    }
}
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
            this.saveLog = new System.Windows.Forms.CheckBox();
            this.stopAfterLossCheck = new System.Windows.Forms.CheckBox();
            this.stopAfterGamesChecked = new System.Windows.Forms.CheckBox();
            this.stopAfterGamesNum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.balanceStopperGroup = new System.Windows.Forms.GroupBox();
            this.balanceStopUnderChecked = new System.Windows.Forms.CheckBox();
            this.BalanceStopCheck = new System.Windows.Forms.CheckBox();
            this.balanceStopUnder = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.balanceStopOver = new System.Windows.Forms.NumericUpDown();
            this.balanceStopOverChecked = new System.Windows.Forms.CheckBox();
            this.stratDisplay = new Satoshi_GUI.Controls.SatoshiGrid();
            ((System.ComponentModel.ISupportInitialize)(this.numberofBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betCostNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precentOnLoss)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopAfterGamesNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.balanceStopperGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceStopUnder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceStopOver)).BeginInit();
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
            this.pHash.Size = new System.Drawing.Size(336, 20);
            this.pHash.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mines:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(45, 25);
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
            this.radioButton2.Location = new System.Drawing.Point(96, 25);
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
            this.radioButton3.Location = new System.Drawing.Point(147, 25);
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
            this.radioButton4.Location = new System.Drawing.Point(198, 25);
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
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of bets:";
            // 
            // numberofBets
            // 
            this.numberofBets.Location = new System.Drawing.Point(96, 48);
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
            this.numberofBets.Size = new System.Drawing.Size(139, 20);
            this.numberofBets.TabIndex = 8;
            this.numberofBets.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(421, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // betCostNUD
            // 
            this.betCostNUD.Location = new System.Drawing.Point(96, 74);
            this.betCostNUD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.betCostNUD.Name = "betCostNUD";
            this.betCostNUD.Size = new System.Drawing.Size(139, 20);
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
            this.label4.Location = new System.Drawing.Point(8, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bet Cost:";
            // 
            // stopAfterWinCheck
            // 
            this.stopAfterWinCheck.AutoSize = true;
            this.stopAfterWinCheck.Location = new System.Drawing.Point(10, 27);
            this.stopAfterWinCheck.Name = "stopAfterWinCheck";
            this.stopAfterWinCheck.Size = new System.Drawing.Size(91, 17);
            this.stopAfterWinCheck.TabIndex = 13;
            this.stopAfterWinCheck.Text = "Stop after win";
            this.stopAfterWinCheck.UseVisualStyleBackColor = true;
            this.stopAfterWinCheck.CheckedChanged += new System.EventHandler(this.stopAfterWinCheck_CheckedChanged);
            // 
            // showExWindow
            // 
            this.showExWindow.AutoSize = true;
            this.showExWindow.Location = new System.Drawing.Point(6, 19);
            this.showExWindow.Name = "showExWindow";
            this.showExWindow.Size = new System.Drawing.Size(141, 17);
            this.showExWindow.TabIndex = 14;
            this.showExWindow.Text = "Show exception window";
            this.showExWindow.UseVisualStyleBackColor = true;
            // 
            // precentOnLoss
            // 
            this.precentOnLoss.Location = new System.Drawing.Point(96, 100);
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
            this.precentOnLoss.Size = new System.Drawing.Size(139, 20);
            this.precentOnLoss.TabIndex = 15;
            this.precentOnLoss.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.precentOnLoss.ValueChanged += new System.EventHandler(this.precentOnLoss_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 102);
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
            this.groupBox2.Location = new System.Drawing.Point(264, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 137);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // showGBombsCheck
            // 
            this.showGBombsCheck.AutoSize = true;
            this.showGBombsCheck.Location = new System.Drawing.Point(6, 65);
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
            this.cfgTag.Size = new System.Drawing.Size(336, 20);
            this.cfgTag.TabIndex = 21;
            // 
            // saveLog
            // 
            this.saveLog.AutoSize = true;
            this.saveLog.Location = new System.Drawing.Point(6, 42);
            this.saveLog.Name = "saveLog";
            this.saveLog.Size = new System.Drawing.Size(96, 17);
            this.saveLog.TabIndex = 22;
            this.saveLog.Text = "Save log to file";
            this.saveLog.UseVisualStyleBackColor = true;
            // 
            // stopAfterLossCheck
            // 
            this.stopAfterLossCheck.AutoSize = true;
            this.stopAfterLossCheck.Location = new System.Drawing.Point(10, 50);
            this.stopAfterLossCheck.Name = "stopAfterLossCheck";
            this.stopAfterLossCheck.Size = new System.Drawing.Size(93, 17);
            this.stopAfterLossCheck.TabIndex = 23;
            this.stopAfterLossCheck.Text = "Stop after loss";
            this.stopAfterLossCheck.UseVisualStyleBackColor = true;
            // 
            // stopAfterGamesChecked
            // 
            this.stopAfterGamesChecked.AutoSize = true;
            this.stopAfterGamesChecked.Location = new System.Drawing.Point(10, 71);
            this.stopAfterGamesChecked.Name = "stopAfterGamesChecked";
            this.stopAfterGamesChecked.Size = new System.Drawing.Size(75, 17);
            this.stopAfterGamesChecked.TabIndex = 24;
            this.stopAfterGamesChecked.Text = "Stop after:";
            this.stopAfterGamesChecked.UseVisualStyleBackColor = true;
            this.stopAfterGamesChecked.CheckedChanged += new System.EventHandler(this.stopAfterGamesChecked_CheckedChanged);
            // 
            // stopAfterGamesNum
            // 
            this.stopAfterGamesNum.Enabled = false;
            this.stopAfterGamesNum.Location = new System.Drawing.Point(91, 70);
            this.stopAfterGamesNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.stopAfterGamesNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stopAfterGamesNum.Name = "stopAfterGamesNum";
            this.stopAfterGamesNum.Size = new System.Drawing.Size(80, 20);
            this.stopAfterGamesNum.TabIndex = 25;
            this.stopAfterGamesNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Games";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopAfterWinCheck);
            this.groupBox1.Controls.Add(this.stopAfterLossCheck);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.stopAfterGamesNum);
            this.groupBox1.Controls.Add(this.stopAfterGamesChecked);
            this.groupBox1.Location = new System.Drawing.Point(7, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 104);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stops";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showExWindow);
            this.groupBox3.Controls.Add(this.saveLog);
            this.groupBox3.Controls.Add(this.showGBombsCheck);
            this.groupBox3.Location = new System.Drawing.Point(258, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 97);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extra";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.numberofBets);
            this.groupBox4.Controls.Add(this.precentOnLoss);
            this.groupBox4.Controls.Add(this.betCostNUD);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(7, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 130);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "General";
            // 
            // balanceStopperGroup
            // 
            this.balanceStopperGroup.Controls.Add(this.label9);
            this.balanceStopperGroup.Controls.Add(this.balanceStopOver);
            this.balanceStopperGroup.Controls.Add(this.balanceStopOverChecked);
            this.balanceStopperGroup.Controls.Add(this.label8);
            this.balanceStopperGroup.Controls.Add(this.balanceStopUnder);
            this.balanceStopperGroup.Controls.Add(this.balanceStopUnderChecked);
            this.balanceStopperGroup.Enabled = false;
            this.balanceStopperGroup.Location = new System.Drawing.Point(7, 300);
            this.balanceStopperGroup.Name = "balanceStopperGroup";
            this.balanceStopperGroup.Size = new System.Drawing.Size(235, 94);
            this.balanceStopperGroup.TabIndex = 30;
            this.balanceStopperGroup.TabStop = false;
            // 
            // balanceStopUnderChecked
            // 
            this.balanceStopUnderChecked.AutoSize = true;
            this.balanceStopUnderChecked.Location = new System.Drawing.Point(11, 32);
            this.balanceStopUnderChecked.Name = "balanceStopUnderChecked";
            this.balanceStopUnderChecked.Size = new System.Drawing.Size(55, 17);
            this.balanceStopUnderChecked.TabIndex = 0;
            this.balanceStopUnderChecked.Text = "Under";
            this.balanceStopUnderChecked.UseVisualStyleBackColor = true;
            this.balanceStopUnderChecked.CheckedChanged += new System.EventHandler(this.balanceStopUnderChecked_CheckedChanged);
            // 
            // BalanceStopCheck
            // 
            this.BalanceStopCheck.AutoSize = true;
            this.BalanceStopCheck.Location = new System.Drawing.Point(13, 300);
            this.BalanceStopCheck.Name = "BalanceStopCheck";
            this.BalanceStopCheck.Size = new System.Drawing.Size(105, 17);
            this.BalanceStopCheck.TabIndex = 1;
            this.BalanceStopCheck.Text = "Balance Stopper";
            this.BalanceStopCheck.UseVisualStyleBackColor = true;
            this.BalanceStopCheck.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // balanceStopUnder
            // 
            this.balanceStopUnder.Location = new System.Drawing.Point(72, 31);
            this.balanceStopUnder.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.balanceStopUnder.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.balanceStopUnder.Name = "balanceStopUnder";
            this.balanceStopUnder.Size = new System.Drawing.Size(126, 20);
            this.balanceStopUnder.TabIndex = 1;
            this.balanceStopUnder.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Bits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Bits";
            // 
            // balanceStopOver
            // 
            this.balanceStopOver.Location = new System.Drawing.Point(72, 57);
            this.balanceStopOver.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.balanceStopOver.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.balanceStopOver.Name = "balanceStopOver";
            this.balanceStopOver.Size = new System.Drawing.Size(126, 20);
            this.balanceStopOver.TabIndex = 4;
            this.balanceStopOver.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // balanceStopOverChecked
            // 
            this.balanceStopOverChecked.AutoSize = true;
            this.balanceStopOverChecked.Location = new System.Drawing.Point(11, 58);
            this.balanceStopOverChecked.Name = "balanceStopOverChecked";
            this.balanceStopOverChecked.Size = new System.Drawing.Size(49, 17);
            this.balanceStopOverChecked.TabIndex = 3;
            this.balanceStopOverChecked.Text = "Over";
            this.balanceStopOverChecked.UseVisualStyleBackColor = true;
            this.balanceStopOverChecked.CheckedChanged += new System.EventHandler(this.balanceStopOverChecked_CheckedChanged);
            // 
            // stratDisplay
            // 
            this.stratDisplay.GridBorder = false;
            this.stratDisplay.Location = new System.Drawing.Point(19, 20);
            this.stratDisplay.Name = "stratDisplay";
            this.stratDisplay.Size = new System.Drawing.Size(103, 103);
            this.stratDisplay.SquareBorder = true;
            this.stratDisplay.TabIndex = 18;
            this.stratDisplay.Text = "satoshiGrid1";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 425);
            this.Controls.Add(this.BalanceStopCheck);
            this.Controls.Add(this.balanceStopperGroup);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cfgTag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.stopAfterGamesNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.balanceStopperGroup.ResumeLayout(false);
            this.balanceStopperGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceStopUnder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceStopOver)).EndInit();
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
        private System.Windows.Forms.CheckBox saveLog;
        private System.Windows.Forms.CheckBox stopAfterLossCheck;
        private System.Windows.Forms.CheckBox stopAfterGamesChecked;
        private System.Windows.Forms.NumericUpDown stopAfterGamesNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox balanceStopperGroup;
        private System.Windows.Forms.CheckBox BalanceStopCheck;
        private System.Windows.Forms.CheckBox balanceStopUnderChecked;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown balanceStopOver;
        private System.Windows.Forms.CheckBox balanceStopOverChecked;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown balanceStopUnder;
    }
}
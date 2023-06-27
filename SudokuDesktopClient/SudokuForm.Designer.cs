namespace SudokuDektopClient
{
    partial class SudokuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SudokuForm));
            this.sudokuPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearInputButton = new System.Windows.Forms.Button();
            this.beginnerGameMode = new System.Windows.Forms.RadioButton();
            this.intermediateGameMode = new System.Windows.Forms.RadioButton();
            this.advancedGameMode = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sudokuGrid9x9RadioButton = new System.Windows.Forms.RadioButton();
            this.sudokuGrid4x4RadioButton = new System.Windows.Forms.RadioButton();
            this.cheatAnswerButton = new System.Windows.Forms.Button();
            this.gridGroupBox = new System.Windows.Forms.GroupBox();
            this.sudokuGrid25x25RadioButton = new System.Windows.Forms.RadioButton();
            this.sudokuGrid16x16RadioButton = new System.Windows.Forms.RadioButton();
            this.resetGameButton = new System.Windows.Forms.Button();
            this.gameModeGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.manualEntryGameMode = new System.Windows.Forms.RadioButton();
            this.Entry = new System.Windows.Forms.Label();
            this.checkEntryButton = new System.Windows.Forms.Button();
            this.gridGroupBox.SuspendLayout();
            this.gameModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sudokuPanel
            // 
            this.sudokuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sudokuPanel.Location = new System.Drawing.Point(32, 49);
            this.sudokuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sudokuPanel.Name = "sudokuPanel";
            this.sudokuPanel.Size = new System.Drawing.Size(500, 500);
            this.sudokuPanel.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(0, 166);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(155, 56);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.SystemColors.Control;
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.checkButton.Location = new System.Drawing.Point(413, 559);
            this.checkButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(119, 70);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // clearInputButton
            // 
            this.clearInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearInputButton.Location = new System.Drawing.Point(231, 559);
            this.clearInputButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearInputButton.Name = "clearInputButton";
            this.clearInputButton.Size = new System.Drawing.Size(114, 33);
            this.clearInputButton.TabIndex = 2;
            this.clearInputButton.Text = "Clear Input";
            this.clearInputButton.UseVisualStyleBackColor = true;
            this.clearInputButton.Click += new System.EventHandler(this.ClearInputButton_Click);
            // 
            // beginnerGameMode
            // 
            this.beginnerGameMode.AutoSize = true;
            this.beginnerGameMode.Location = new System.Drawing.Point(10, 101);
            this.beginnerGameMode.Margin = new System.Windows.Forms.Padding(2);
            this.beginnerGameMode.Name = "beginnerGameMode";
            this.beginnerGameMode.Size = new System.Drawing.Size(67, 17);
            this.beginnerGameMode.TabIndex = 3;
            this.beginnerGameMode.Text = "Beginner";
            this.beginnerGameMode.UseVisualStyleBackColor = true;
            // 
            // intermediateGameMode
            // 
            this.intermediateGameMode.AutoSize = true;
            this.intermediateGameMode.Location = new System.Drawing.Point(10, 122);
            this.intermediateGameMode.Margin = new System.Windows.Forms.Padding(2);
            this.intermediateGameMode.Name = "intermediateGameMode";
            this.intermediateGameMode.Size = new System.Drawing.Size(83, 17);
            this.intermediateGameMode.TabIndex = 3;
            this.intermediateGameMode.Text = "Intermediate";
            this.intermediateGameMode.UseVisualStyleBackColor = true;
            // 
            // advancedGameMode
            // 
            this.advancedGameMode.AutoSize = true;
            this.advancedGameMode.Location = new System.Drawing.Point(10, 143);
            this.advancedGameMode.Margin = new System.Windows.Forms.Padding(2);
            this.advancedGameMode.Name = "advancedGameMode";
            this.advancedGameMode.Size = new System.Drawing.Size(74, 17);
            this.advancedGameMode.TabIndex = 3;
            this.advancedGameMode.Text = "Advanced";
            this.advancedGameMode.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, -4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grid";
            // 
            // sudokuGrid9x9RadioButton
            // 
            this.sudokuGrid9x9RadioButton.AutoSize = true;
            this.sudokuGrid9x9RadioButton.Checked = true;
            this.sudokuGrid9x9RadioButton.Location = new System.Drawing.Point(91, 27);
            this.sudokuGrid9x9RadioButton.Name = "sudokuGrid9x9RadioButton";
            this.sudokuGrid9x9RadioButton.Size = new System.Drawing.Size(42, 17);
            this.sudokuGrid9x9RadioButton.TabIndex = 8;
            this.sudokuGrid9x9RadioButton.TabStop = true;
            this.sudokuGrid9x9RadioButton.Text = "9x9";
            this.sudokuGrid9x9RadioButton.UseVisualStyleBackColor = true;
            this.sudokuGrid9x9RadioButton.CheckedChanged += new System.EventHandler(this.SudokuGrid9x9RadioButton_CheckedChanged);
            // 
            // sudokuGrid4x4RadioButton
            // 
            this.sudokuGrid4x4RadioButton.AutoSize = true;
            this.sudokuGrid4x4RadioButton.Location = new System.Drawing.Point(23, 27);
            this.sudokuGrid4x4RadioButton.Name = "sudokuGrid4x4RadioButton";
            this.sudokuGrid4x4RadioButton.Size = new System.Drawing.Size(42, 17);
            this.sudokuGrid4x4RadioButton.TabIndex = 9;
            this.sudokuGrid4x4RadioButton.Text = "4x4";
            this.sudokuGrid4x4RadioButton.UseVisualStyleBackColor = true;
            this.sudokuGrid4x4RadioButton.CheckedChanged += new System.EventHandler(this.SudokuGrid4x4RadioButton_CheckedChanged);
            // 
            // cheatAnswerButton
            // 
            this.cheatAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatAnswerButton.ForeColor = System.Drawing.Color.Crimson;
            this.cheatAnswerButton.Location = new System.Drawing.Point(32, 559);
            this.cheatAnswerButton.Margin = new System.Windows.Forms.Padding(2);
            this.cheatAnswerButton.Name = "cheatAnswerButton";
            this.cheatAnswerButton.Size = new System.Drawing.Size(119, 70);
            this.cheatAnswerButton.TabIndex = 5;
            this.cheatAnswerButton.Text = "Cheat Answer";
            this.cheatAnswerButton.UseVisualStyleBackColor = true;
            this.cheatAnswerButton.Click += new System.EventHandler(this.CheatAnswerButton_Click);
            // 
            // gridGroupBox
            // 
            this.gridGroupBox.Controls.Add(this.sudokuGrid25x25RadioButton);
            this.gridGroupBox.Controls.Add(this.sudokuGrid16x16RadioButton);
            this.gridGroupBox.Controls.Add(this.label2);
            this.gridGroupBox.Controls.Add(this.sudokuGrid9x9RadioButton);
            this.gridGroupBox.Controls.Add(this.sudokuGrid4x4RadioButton);
            this.gridGroupBox.Location = new System.Drawing.Point(563, 110);
            this.gridGroupBox.Name = "gridGroupBox";
            this.gridGroupBox.Size = new System.Drawing.Size(156, 95);
            this.gridGroupBox.TabIndex = 11;
            this.gridGroupBox.TabStop = false;
            // 
            // sudokuGrid25x25RadioButton
            // 
            this.sudokuGrid25x25RadioButton.AutoSize = true;
            this.sudokuGrid25x25RadioButton.Location = new System.Drawing.Point(91, 59);
            this.sudokuGrid25x25RadioButton.Name = "sudokuGrid25x25RadioButton";
            this.sudokuGrid25x25RadioButton.Size = new System.Drawing.Size(54, 17);
            this.sudokuGrid25x25RadioButton.TabIndex = 11;
            this.sudokuGrid25x25RadioButton.Text = "25x25";
            this.sudokuGrid25x25RadioButton.UseVisualStyleBackColor = true;
            this.sudokuGrid25x25RadioButton.CheckedChanged += new System.EventHandler(this.SudokuGrid25x25RadioButton_CheckedChanged);
            // 
            // sudokuGrid16x16RadioButton
            // 
            this.sudokuGrid16x16RadioButton.AutoSize = true;
            this.sudokuGrid16x16RadioButton.Location = new System.Drawing.Point(23, 59);
            this.sudokuGrid16x16RadioButton.Name = "sudokuGrid16x16RadioButton";
            this.sudokuGrid16x16RadioButton.Size = new System.Drawing.Size(54, 17);
            this.sudokuGrid16x16RadioButton.TabIndex = 10;
            this.sudokuGrid16x16RadioButton.Text = "16x16";
            this.sudokuGrid16x16RadioButton.UseVisualStyleBackColor = true;
            this.sudokuGrid16x16RadioButton.CheckedChanged += new System.EventHandler(this.SudokuGrid16x16RadioButton_CheckedChanged);
            // 
            // resetGameButton
            // 
            this.resetGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetGameButton.Location = new System.Drawing.Point(231, 596);
            this.resetGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetGameButton.Name = "resetGameButton";
            this.resetGameButton.Size = new System.Drawing.Size(114, 33);
            this.resetGameButton.TabIndex = 12;
            this.resetGameButton.Text = "Reset Game";
            this.resetGameButton.UseVisualStyleBackColor = true;
            this.resetGameButton.Click += new System.EventHandler(this.ResetGameButton_Click);
            // 
            // gameModeGroupBox
            // 
            this.gameModeGroupBox.Controls.Add(this.label4);
            this.gameModeGroupBox.Controls.Add(this.label1);
            this.gameModeGroupBox.Controls.Add(this.StartButton);
            this.gameModeGroupBox.Controls.Add(this.manualEntryGameMode);
            this.gameModeGroupBox.Controls.Add(this.beginnerGameMode);
            this.gameModeGroupBox.Controls.Add(this.Entry);
            this.gameModeGroupBox.Controls.Add(this.intermediateGameMode);
            this.gameModeGroupBox.Controls.Add(this.advancedGameMode);
            this.gameModeGroupBox.Enabled = false;
            this.gameModeGroupBox.Location = new System.Drawing.Point(563, 285);
            this.gameModeGroupBox.Name = "gameModeGroupBox";
            this.gameModeGroupBox.Size = new System.Drawing.Size(156, 223);
            this.gameModeGroupBox.TabIndex = 0;
            this.gameModeGroupBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manual";
            // 
            // manualEntryGameMode
            // 
            this.manualEntryGameMode.AutoSize = true;
            this.manualEntryGameMode.Checked = true;
            this.manualEntryGameMode.Location = new System.Drawing.Point(10, 52);
            this.manualEntryGameMode.Margin = new System.Windows.Forms.Padding(2);
            this.manualEntryGameMode.Name = "manualEntryGameMode";
            this.manualEntryGameMode.Size = new System.Drawing.Size(71, 17);
            this.manualEntryGameMode.TabIndex = 5;
            this.manualEntryGameMode.TabStop = true;
            this.manualEntryGameMode.Text = "Grid Entry";
            this.manualEntryGameMode.UseVisualStyleBackColor = true;
            // 
            // Entry
            // 
            this.Entry.AutoSize = true;
            this.Entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entry.Location = new System.Drawing.Point(10, -5);
            this.Entry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(62, 25);
            this.Entry.TabIndex = 5;
            this.Entry.Text = "Entry";
            // 
            // checkEntryButton
            // 
            this.checkEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEntryButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.checkEntryButton.Location = new System.Drawing.Point(413, 559);
            this.checkEntryButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkEntryButton.Name = "checkEntryButton";
            this.checkEntryButton.Size = new System.Drawing.Size(119, 70);
            this.checkEntryButton.TabIndex = 13;
            this.checkEntryButton.Text = "Check Entry";
            this.checkEntryButton.UseVisualStyleBackColor = true;
            this.checkEntryButton.Visible = false;
            this.checkEntryButton.Click += new System.EventHandler(this.CheckEntryButton_Click);
            // 
            // SudokuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 659);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.checkEntryButton);
            this.Controls.Add(this.cheatAnswerButton);
            this.Controls.Add(this.resetGameButton);
            this.Controls.Add(this.gridGroupBox);
            this.Controls.Add(this.clearInputButton);
            this.Controls.Add(this.sudokuPanel);
            this.Controls.Add(this.gameModeGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SudokuForm";
            this.Text = "Sudoku";
            this.gridGroupBox.ResumeLayout(false);
            this.gridGroupBox.PerformLayout();
            this.gameModeGroupBox.ResumeLayout(false);
            this.gameModeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sudokuPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearInputButton;
        private System.Windows.Forms.RadioButton beginnerGameMode;
        private System.Windows.Forms.RadioButton intermediateGameMode;
        private System.Windows.Forms.RadioButton advancedGameMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton sudokuGrid9x9RadioButton;
        private System.Windows.Forms.RadioButton sudokuGrid4x4RadioButton;
        private System.Windows.Forms.GroupBox gridGroupBox;
        private System.Windows.Forms.Button resetGameButton;
        private System.Windows.Forms.Button cheatAnswerButton;
        private System.Windows.Forms.GroupBox gameModeGroupBox;
        private System.Windows.Forms.Label Entry;
        private System.Windows.Forms.RadioButton manualEntryGameMode;
        private System.Windows.Forms.Button checkEntryButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton sudokuGrid25x25RadioButton;
        private System.Windows.Forms.RadioButton sudokuGrid16x16RadioButton;
    }
}


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
            this.sudokuPanel = new System.Windows.Forms.Panel();
            this.createGameButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearInputButton = new System.Windows.Forms.Button();
            this.beginnerGameMode = new System.Windows.Forms.RadioButton();
            this.intermediateGameMode = new System.Windows.Forms.RadioButton();
            this.advancedGameMode = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sudokuGrid9x9 = new System.Windows.Forms.RadioButton();
            this.sudokuGrid4x4 = new System.Windows.Forms.RadioButton();
            this.cheatAnswerButton = new System.Windows.Forms.Button();
            this.gridGroupBox = new System.Windows.Forms.GroupBox();
            this.resetGameButton = new System.Windows.Forms.Button();
            this.gameModeGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.manualEntryGameMode = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.checkGridButton = new System.Windows.Forms.Button();
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
            this.sudokuPanel.Size = new System.Drawing.Size(360, 360);
            this.sudokuPanel.TabIndex = 0;
            // 
            // createGameButton
            // 
            this.createGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGameButton.Location = new System.Drawing.Point(0, 166);
            this.createGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.createGameButton.Name = "createGameButton";
            this.createGameButton.Size = new System.Drawing.Size(155, 56);
            this.createGameButton.TabIndex = 1;
            this.createGameButton.Text = "Create Game";
            this.createGameButton.UseVisualStyleBackColor = true;
            this.createGameButton.Click += new System.EventHandler(this.CreateGameButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.checkButton.Location = new System.Drawing.Point(273, 427);
            this.checkButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(119, 70);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Visible = false;
            this.checkButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // clearInputButton
            // 
            this.clearInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearInputButton.Location = new System.Drawing.Point(155, 427);
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
            // sudokuGrid9x9
            // 
            this.sudokuGrid9x9.AutoSize = true;
            this.sudokuGrid9x9.Checked = true;
            this.sudokuGrid9x9.Location = new System.Drawing.Point(23, 27);
            this.sudokuGrid9x9.Name = "sudokuGrid9x9";
            this.sudokuGrid9x9.Size = new System.Drawing.Size(42, 17);
            this.sudokuGrid9x9.TabIndex = 8;
            this.sudokuGrid9x9.TabStop = true;
            this.sudokuGrid9x9.Text = "9x9";
            this.sudokuGrid9x9.UseVisualStyleBackColor = true;
            this.sudokuGrid9x9.CheckedChanged += new System.EventHandler(this.SudokuGrid9x9_CheckedChanged);
            // 
            // sudokuGrid4x4
            // 
            this.sudokuGrid4x4.AutoSize = true;
            this.sudokuGrid4x4.Location = new System.Drawing.Point(99, 27);
            this.sudokuGrid4x4.Name = "sudokuGrid4x4";
            this.sudokuGrid4x4.Size = new System.Drawing.Size(42, 17);
            this.sudokuGrid4x4.TabIndex = 9;
            this.sudokuGrid4x4.Text = "4x4";
            this.sudokuGrid4x4.UseVisualStyleBackColor = true;
            this.sudokuGrid4x4.CheckedChanged += new System.EventHandler(this.SudokuGrid4x4_CheckedChanged);
            // 
            // cheatAnswerButton
            // 
            this.cheatAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatAnswerButton.ForeColor = System.Drawing.Color.Crimson;
            this.cheatAnswerButton.Location = new System.Drawing.Point(32, 427);
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
            this.gridGroupBox.Controls.Add(this.label2);
            this.gridGroupBox.Controls.Add(this.sudokuGrid9x9);
            this.gridGroupBox.Controls.Add(this.sudokuGrid4x4);
            this.gridGroupBox.Location = new System.Drawing.Point(402, 65);
            this.gridGroupBox.Name = "gridGroupBox";
            this.gridGroupBox.Size = new System.Drawing.Size(156, 64);
            this.gridGroupBox.TabIndex = 11;
            this.gridGroupBox.TabStop = false;
            // 
            // resetGameButton
            // 
            this.resetGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetGameButton.Location = new System.Drawing.Point(155, 464);
            this.resetGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetGameButton.Name = "resetGameButton";
            this.resetGameButton.Size = new System.Drawing.Size(115, 33);
            this.resetGameButton.TabIndex = 12;
            this.resetGameButton.Text = "Reset Game";
            this.resetGameButton.UseVisualStyleBackColor = true;
            this.resetGameButton.Click += new System.EventHandler(this.ResetGameButton_Click);
            // 
            // gameModeGroupBox
            // 
            this.gameModeGroupBox.Controls.Add(this.label4);
            this.gameModeGroupBox.Controls.Add(this.label1);
            this.gameModeGroupBox.Controls.Add(this.createGameButton);
            this.gameModeGroupBox.Controls.Add(this.manualEntryGameMode);
            this.gameModeGroupBox.Controls.Add(this.beginnerGameMode);
            this.gameModeGroupBox.Controls.Add(this.label3);
            this.gameModeGroupBox.Controls.Add(this.intermediateGameMode);
            this.gameModeGroupBox.Controls.Add(this.advancedGameMode);
            this.gameModeGroupBox.Enabled = false;
            this.gameModeGroupBox.Location = new System.Drawing.Point(402, 171);
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
            this.manualEntryGameMode.Size = new System.Drawing.Size(87, 17);
            this.manualEntryGameMode.TabIndex = 5;
            this.manualEntryGameMode.TabStop = true;
            this.manualEntryGameMode.Text = "Manual Entry";
            this.manualEntryGameMode.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, -5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "GameMode";
            // 
            // checkGridButton
            // 
            this.checkGridButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGridButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.checkGridButton.Location = new System.Drawing.Point(274, 427);
            this.checkGridButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkGridButton.Name = "checkGridButton";
            this.checkGridButton.Size = new System.Drawing.Size(119, 70);
            this.checkGridButton.TabIndex = 13;
            this.checkGridButton.Text = "Check Grid";
            this.checkGridButton.UseVisualStyleBackColor = true;
            this.checkGridButton.Click += new System.EventHandler(this.CheckGridButton_Click);
            // 
            // SudokuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 512);
            this.Controls.Add(this.checkGridButton);
            this.Controls.Add(this.cheatAnswerButton);
            this.Controls.Add(this.resetGameButton);
            this.Controls.Add(this.gridGroupBox);
            this.Controls.Add(this.clearInputButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.sudokuPanel);
            this.Controls.Add(this.gameModeGroupBox);
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
        private System.Windows.Forms.Button createGameButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearInputButton;
        private System.Windows.Forms.RadioButton beginnerGameMode;
        private System.Windows.Forms.RadioButton intermediateGameMode;
        private System.Windows.Forms.RadioButton advancedGameMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton sudokuGrid9x9;
        private System.Windows.Forms.RadioButton sudokuGrid4x4;
        private System.Windows.Forms.GroupBox gridGroupBox;
        private System.Windows.Forms.Button resetGameButton;
        private System.Windows.Forms.Button cheatAnswerButton;
        private System.Windows.Forms.GroupBox gameModeGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton manualEntryGameMode;
        private System.Windows.Forms.Button checkGridButton;
        private System.Windows.Forms.Label label4;
    }
}


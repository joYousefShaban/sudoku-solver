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
            this.solveButton = new System.Windows.Forms.Button();
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
            this.clearGridButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.manualGameMode = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.checkIfHintsAreValidButton = new System.Windows.Forms.Button();
            this.gridGroupBox.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sudokuPanel
            // 
            this.sudokuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sudokuPanel.Location = new System.Drawing.Point(51, 49);
            this.sudokuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sudokuPanel.Name = "sudokuPanel";
            this.sudokuPanel.Size = new System.Drawing.Size(420, 410);
            this.sudokuPanel.TabIndex = 0;
            // 
            // createGameButton
            // 
            this.createGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGameButton.Location = new System.Drawing.Point(0, 138);
            this.createGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.createGameButton.Name = "createGameButton";
            this.createGameButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createGameButton.Size = new System.Drawing.Size(117, 56);
            this.createGameButton.TabIndex = 1;
            this.createGameButton.Text = "CreateGame";
            this.createGameButton.UseVisualStyleBackColor = true;
            this.createGameButton.Click += new System.EventHandler(this.CreateGameButton_Click);
            // 
            // solveButton
            // 
            this.solveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.solveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.solveButton.Location = new System.Drawing.Point(352, 472);
            this.solveButton.Margin = new System.Windows.Forms.Padding(2);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(119, 65);
            this.solveButton.TabIndex = 2;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = false;
            this.solveButton.Visible = false;
            this.solveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // clearInputButton
            // 
            this.clearInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearInputButton.Location = new System.Drawing.Point(203, 472);
            this.clearInputButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearInputButton.Name = "clearInputButton";
            this.clearInputButton.Size = new System.Drawing.Size(119, 33);
            this.clearInputButton.TabIndex = 2;
            this.clearInputButton.Text = "Clear Input";
            this.clearInputButton.UseVisualStyleBackColor = true;
            this.clearInputButton.Click += new System.EventHandler(this.ClearInputButton_Click);
            // 
            // beginnerGameMode
            // 
            this.beginnerGameMode.AutoSize = true;
            this.beginnerGameMode.Location = new System.Drawing.Point(10, 78);
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
            this.intermediateGameMode.Location = new System.Drawing.Point(10, 97);
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
            this.advancedGameMode.Location = new System.Drawing.Point(10, 118);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, -4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grid";
            // 
            // sudokuGrid9x9
            // 
            this.sudokuGrid9x9.AutoSize = true;
            this.sudokuGrid9x9.Checked = true;
            this.sudokuGrid9x9.Location = new System.Drawing.Point(6, 25);
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
            this.sudokuGrid4x4.Location = new System.Drawing.Point(70, 25);
            this.sudokuGrid4x4.Name = "sudokuGrid4x4";
            this.sudokuGrid4x4.Size = new System.Drawing.Size(42, 17);
            this.sudokuGrid4x4.TabIndex = 9;
            this.sudokuGrid4x4.Text = "4x4";
            this.sudokuGrid4x4.UseVisualStyleBackColor = true;
            this.sudokuGrid4x4.CheckedChanged += new System.EventHandler(this.SudokuGrid4x4_CheckedChanged);
            // 
            // cheatAnswerButton
            // 
            this.cheatAnswerButton.Enabled = false;
            this.cheatAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatAnswerButton.ForeColor = System.Drawing.Color.Crimson;
            this.cheatAnswerButton.Location = new System.Drawing.Point(51, 472);
            this.cheatAnswerButton.Margin = new System.Windows.Forms.Padding(2);
            this.cheatAnswerButton.Name = "cheatAnswerButton";
            this.cheatAnswerButton.Size = new System.Drawing.Size(119, 65);
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
            this.gridGroupBox.Location = new System.Drawing.Point(476, 49);
            this.gridGroupBox.Name = "gridGroupBox";
            this.gridGroupBox.Size = new System.Drawing.Size(118, 51);
            this.gridGroupBox.TabIndex = 11;
            this.gridGroupBox.TabStop = false;
            // 
            // clearGridButton
            // 
            this.clearGridButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearGridButton.Location = new System.Drawing.Point(203, 504);
            this.clearGridButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearGridButton.Name = "clearGridButton";
            this.clearGridButton.Size = new System.Drawing.Size(119, 33);
            this.clearGridButton.TabIndex = 12;
            this.clearGridButton.Text = "Clear Grid";
            this.clearGridButton.UseVisualStyleBackColor = true;
            this.clearGridButton.Click += new System.EventHandler(this.ClearGridButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.createGameButton);
            this.groupBox.Controls.Add(this.manualGameMode);
            this.groupBox.Controls.Add(this.beginnerGameMode);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.intermediateGameMode);
            this.groupBox.Controls.Add(this.advancedGameMode);
            this.groupBox.Location = new System.Drawing.Point(476, 172);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(118, 195);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // manualGameMode
            // 
            this.manualGameMode.AutoSize = true;
            this.manualGameMode.Checked = true;
            this.manualGameMode.Location = new System.Drawing.Point(10, 29);
            this.manualGameMode.Margin = new System.Windows.Forms.Padding(2);
            this.manualGameMode.Name = "manualGameMode";
            this.manualGameMode.Size = new System.Drawing.Size(60, 17);
            this.manualGameMode.TabIndex = 5;
            this.manualGameMode.TabStop = true;
            this.manualGameMode.Text = "Manual";
            this.manualGameMode.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "GameMode";
            // 
            // checkIfHintsAreValidButton
            // 
            this.checkIfHintsAreValidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIfHintsAreValidButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkIfHintsAreValidButton.Location = new System.Drawing.Point(352, 472);
            this.checkIfHintsAreValidButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkIfHintsAreValidButton.Name = "checkIfHintsAreValidButton";
            this.checkIfHintsAreValidButton.Size = new System.Drawing.Size(119, 65);
            this.checkIfHintsAreValidButton.TabIndex = 13;
            this.checkIfHintsAreValidButton.Text = "Check If Hints Are Valid";
            this.checkIfHintsAreValidButton.UseVisualStyleBackColor = true;
            this.checkIfHintsAreValidButton.Click += new System.EventHandler(this.CheckIfHintsAreValidButton_Click);
            // 
            // SudokuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 566);
            this.Controls.Add(this.checkIfHintsAreValidButton);
            this.Controls.Add(this.cheatAnswerButton);
            this.Controls.Add(this.clearGridButton);
            this.Controls.Add(this.gridGroupBox);
            this.Controls.Add(this.clearInputButton);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.sudokuPanel);
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SudokuForm";
            this.Text = "Sudoku";
            this.gridGroupBox.ResumeLayout(false);
            this.gridGroupBox.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sudokuPanel;
        private System.Windows.Forms.Button createGameButton;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Button clearInputButton;
        private System.Windows.Forms.RadioButton beginnerGameMode;
        private System.Windows.Forms.RadioButton intermediateGameMode;
        private System.Windows.Forms.RadioButton advancedGameMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton sudokuGrid9x9;
        private System.Windows.Forms.RadioButton sudokuGrid4x4;
        private System.Windows.Forms.GroupBox gridGroupBox;
        private System.Windows.Forms.Button clearGridButton;
        private System.Windows.Forms.Button cheatAnswerButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton manualGameMode;
        private System.Windows.Forms.Button checkIfHintsAreValidButton;
    }
}


using SudokuDektopClient.Impl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SudokuDektopClient
{
    public partial class SudokuForm : Form
    {
        int gridSize;
        SudokuCell[,] gridCells;
        readonly Random random = new Random();

        public SudokuForm()
        {
            InitializeComponent();
            InitializeGame(9);
        }

        public void InitializeGame(int newGridSize)
        {
            gridSize = newGridSize;
            sudokuPanel.Controls.Clear();
            CreatePanelCells();
            StartManualGameMode();
        }

        private void CreatePanelCells()
        {
            gridCells = new SudokuCell[gridSize, gridSize];

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    // Create 81 cells for with styles and locations based on the index
                    gridCells[i, j] = new SudokuCell
                    {
                        Font = new Font(SystemFonts.DefaultFont.FontFamily, 20),
                        Size = new Size(40, 40),
                        ForeColor = SystemColors.ControlDarkDark,
                        Location = new Point(i * 40, j * 40),
                        BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray,
                        FlatStyle = FlatStyle.Flat,
                        X = i,
                        Y = j,
                    };
                    gridCells[i, j].FlatAppearance.BorderColor = Color.Black;

                    // Assign key press event for each cells
                    gridCells[i, j].KeyPress += CellInPanel_keyPressed;
                    sudokuPanel.Controls.Add(gridCells[i, j]);
                }
            }
        }

        #region ChangeGridSize
        private void SudokuGrid9x9_CheckedChanged(object sender, EventArgs e)
        {
            InitializeGame(9);
        }

        private void SudokuGrid4x4_CheckedChanged(object sender, EventArgs e)
        {
            InitializeGame(4);
        }
        #endregion

        #region ManualGameMode

        private void StartManualGameMode()
        {
            ClearGridCells();
        }

        private void LockTips()
        {
            foreach (var cell in gridCells)
            {
                if (cell.Text != string.Empty)
                {
                    cell.ForeColor = Color.Black;
                    cell.IsLocked = true;
                }
            }
        }

        #endregion

        #region LevelGameMode

        private void StartLevelGameMode()
        {
            int hintsCount;
            if (beginnerGameMode.Checked)
            {
                beginnerGameMode.Checked = false;
                hintsCount = (int)((gridSize * gridSize) / 1.5);
            }
            else if (intermediateGameMode.Checked)
            {
                intermediateGameMode.Checked = false;
                hintsCount = (int)((gridSize * gridSize) / 2.5);
            }
            else if (advancedGameMode.Checked)
            {
                advancedGameMode.Checked = false;
                hintsCount = (gridSize * gridSize) / 4;
            }
            else
            {
                MessageBox.Show("Please check your gamemode");
                return;
            }
            GenerateSolvedSudokuGrid();

            // Assign the hints count based on the 
            // level player chosen
            ShowRandomValuesHints(hintsCount);
        }

        private void GenerateSolvedSudokuGrid()
        {
            // Clear the values in each cells
            ClearGridCells();

            // This method will be called recursively 
            // until it finds suitable values for each cells
            SolveSudoku(0, -1);
        }

        private void ShowRandomValuesHints(int hintsCount)
        {
            // Show value in radom cells
            // The hints count is based on the level player choose
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(gridSize);
                var rY = random.Next(gridSize);

                // Style the hint cells differently and
                // lock the cell so that player can't edit the value
                gridCells[rX, rY].Text = gridCells[rX, rY].CorrectAnswer.ToString();
                gridCells[rX, rY].ForeColor = Color.Black;
                gridCells[rX, rY].IsLocked = true;
            }
        }
        #endregion

        private bool SolveSudoku(int i, int j)
        {
            // Increment the i and j values to move to the next cell
            // and if the columns end, move to the next row

            if (++j > gridSize - 1)
            {
                j = 0;

                // Exit if the line ends
                if (++i > gridSize - 1)
                    return true;
            }

            // Check if the cell already has a value
            if (!string.IsNullOrEmpty(gridCells[i, j].Text))
            {
                // Skip to the next cell
                return SolveSudoku(i, j);
            }

            List<char> numsLeft;
            if (gridSize == 9)
            {
                numsLeft = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            }
            else
            {
                numsLeft = new List<char> { '1', '2', '3', '4' };
            }

            while (numsLeft.Count > 0)
            {
                int randomIndex = random.Next(0, numsLeft.Count);
                char value = numsLeft[randomIndex];
                numsLeft.RemoveAt(randomIndex);

                gridCells[i, j].CorrectAnswer = value;

                if (IsCellValid(value, i, j) && SolveSudoku(i, j))
                {
                    return true;
                }
            }

            // No valid number found for the current cell, reset the cell value
            gridCells[i, j].CorrectAnswer = '0';
            return false;
        }

        private void ClearInputCells()
        {
            foreach (var cell in gridCells)
            {
                // Clear the cell only if it is not locked
                if (cell.IsLocked == false)
                    cell.Clear();
            }
        }

        private void ClearGridCells()
        {
            foreach (var cell in gridCells)
            {
                cell.CorrectAnswer = default;
                cell.Clear();
            }
        }

        #region Validations


        private bool ValidateSudoku()
        {
            bool hasNonEmptyCell = false; // Flag to track if there is at least one non-empty cell

            foreach (var cell in gridCells)
            {
                if (cell.Text != string.Empty)
                {
                    hasNonEmptyCell = true;
                    if (cell.Text[0] > gridSize.ToString()[0] || !IsCellValid(cell.Text[0], cell.X, cell.Y))
                        return false;
                }
            }
            return hasNonEmptyCell; // Return false if all cells are empty, true otherwise
        }

        private void ValidateSudokuWithCorrectAnswers()
        {
            var wrongCells = new List<SudokuCell>();

            // Find all the wrong inputs
            foreach (var cell in gridCells)
            {
                if (cell.Text == default || !string.Equals(cell.CorrectAnswer.ToString(), cell.Text))
                {
                    wrongCells.Add(cell);
                }
            }

            // Check if the inputs are wrong or the player wins 
            if (wrongCells.Any())
            {
                // Highlight the wrong inputs 
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Invalid Sudoku Board!");
            }
            else
            {
                MessageBox.Show("Correct! Congratulations");
            }
        }

        private bool IsCellValid(int value, int x, int y)
        {
            for (int i = 0; i < gridSize; i++)
            {
                // Check all the cells in vertical direction
                if (i != y && gridCells[x, i].CorrectAnswer == (char)value)
                    return false;

                // Check all the cells in horizontal direction
                if (i != x && gridCells[i, y].CorrectAnswer == (char)value)
                    return false;
            }

            // Check all the cells in the specific block
            int sqrtGridSize = (int)Math.Sqrt(gridSize);
            for (int i = (x - (x % sqrtGridSize)); i < x - (x % sqrtGridSize) + sqrtGridSize; i++)
            {
                for (int j = (y - (y % sqrtGridSize)); j < y - (y % sqrtGridSize) + sqrtGridSize; j++)
                {
                    if (i != x && j != y && gridCells[i, j].CorrectAnswer == (char)value)
                        return false;
                }
            }
            return true;
        }

        #endregion

        #region Clicks/Pressed

        private void CellInPanel_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;

            // Do nothing if the cell is locked
            if (cell.IsLocked)
                return;

            // Add the pressed key value in the cell only if it is a number
            if (int.TryParse(e.KeyChar.ToString(), out int valueEntered))
            {
                // Clear the cell value if pressed key is zero
                if (valueEntered == 0)
                {
                    cell.Clear();
                    cell.ForeColor = SystemColors.ControlDarkDark;
                }
                else
                {
                    cell.Text = valueEntered.ToString();
                    cell.ForeColor = SystemColors.ControlDarkDark;
                    if (checkIfHintsAreValidButton.Visible)
                    {
                        cell.CorrectAnswer = valueEntered.ToString()[0];
                    }
                }
            }
        }

        private void CheckIfHintsAreValidButton_Click(object sender, EventArgs e)
        {
            bool validSudoku = false;
            if (ValidateSudoku())
            {
                validSudoku = SolveSudoku(0, -1);
                LockTips();
            }
            //TODO: Check if input is valid 

            if (validSudoku)
            {
                checkIfHintsAreValidButton.Hide();
                solveButton.Show();
                cheatAnswerButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please fix your hints since they are invalid.");
            }
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            ValidateSudokuWithCorrectAnswers();
        }

        private void ClearInputButton_Click(object sender, EventArgs e)
        {
            if (checkIfHintsAreValidButton.Visible)
                ClearGridButton_Click(sender, e);
            else
                ClearInputCells();
        }

        private void ClearGridButton_Click(object sender, EventArgs e)
        {
            ClearGridCells();
            if (checkIfHintsAreValidButton.Visible)
                CreateGameButton_Click(sender, e);
        }

        private void CreateGameButton_Click(object sender, EventArgs e)
        {
            //CALL API
            if (manualGameMode.Checked)
            {
                checkIfHintsAreValidButton.Show();
                solveButton.Hide();
                cheatAnswerButton.Enabled = false;
                StartManualGameMode();
                manualGameMode.Checked = false;
            }
            else
            {                checkIfHintsAreValidButton.Hide();
                solveButton.Show();
                cheatAnswerButton.Enabled = true;
                StartLevelGameMode();
            }
        }

        private void CheatAnswerButton_Click(object sender, EventArgs e)
        {
            foreach (var cell in gridCells)
            {
                if (!string.Equals(cell.CorrectAnswer.ToString(), cell.Text))
                {
                    cell.Text = cell.CorrectAnswer.ToString();
                    cell.ForeColor = Color.Blue;
                }
            }
        }

        #endregion
    }
}

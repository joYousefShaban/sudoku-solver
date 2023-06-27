using SudokuDektopClient.Impl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuDektopClient
{
    public partial class SudokuForm : Form
    {
        int gridSize;
        SudokuCell[,] gridCells;
        List<char> possibleGridEntries;
        readonly Random random;

        public SudokuForm()
        {
            random = new Random();
            InitializeComponent();
            InitializeSudokuGame(9);
        }

        private void InitializeSudokuGame(int newGridSize)
        {
            UIDefaultState();
            gridSize = newGridSize;
            ApplyNewGridSize();
            sudokuPanel.Controls.Clear();
            CreatePanelCells();
        }

        private void ApplyNewGridSize()
        {
            if (gridSize == 4)
            {
                possibleGridEntries = new List<char> { '1', '2', '3', '4' };
                sudokuPanel.Size = new Size(200, 200);
                sudokuPanel.Location = new Point(192, 209);
            }
            else if (gridSize == 9)
            {
                possibleGridEntries = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                sudokuPanel.Size = new Size(360, 360);
                sudokuPanel.Location = new Point(112, 129);
            }
            else if (gridSize == 16)
            {
                possibleGridEntries = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
                sudokuPanel.Size = new Size(500, 500);
                sudokuPanel.Location = new Point(32, 49);
            }
            else
            {
                possibleGridEntries = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P' };
                sudokuPanel.Size = new Size(500, 500);
                sudokuPanel.Location = new Point(32, 49);
            }
        }

        private void CreatePanelCells()
        {
            gridCells = new SudokuCell[gridSize, gridSize];

            int cellSize;
            int cellFontSize;
            if (gridSize == 4 || gridSize == 9)
            {
                cellSize = 40;
                cellFontSize = cellSize / 2;
            }
            else if (gridSize == 16)
            {
                cellSize = 31;
                cellFontSize = cellSize / 2;
            }
            else
            {
                cellSize = 20;
                cellFontSize = 7;
            }

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    // Create 81 cells for with styles and locations based on the index
                    gridCells[i, j] = new SudokuCell
                    {
                        Font = new Font(SystemFonts.DefaultFont.FontFamily, cellFontSize),
                        Size = new Size(cellSize, cellSize),
                        ForeColor = SystemColors.ControlDarkDark,
                        BackColor = ((i / (int)Math.Sqrt(gridSize)) + (j / (int)Math.Sqrt(gridSize))) % 2 == 0 ? SystemColors.Control : Color.LightGray,
                        Location = new Point(i * cellSize, j * cellSize),
                        FlatStyle = FlatStyle.Flat,
                        X = i,
                        Y = j,
                    };
                    gridCells[i, j].FlatAppearance.BorderColor = Color.Black;

                    // Assign key press event for each cells
                    gridCells[i, j].KeyPress += CellInPanel_keyPressed;
                    gridCells[i, j].Click += CellInPanel_click;
                    sudokuPanel.Controls.Add(gridCells[i, j]);
                }
            }
        }

        #region ChangeGridSize

        private void SudokuGrid4x4RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sudokuGrid4x4RadioButton.Checked)
            {
                InitializeSudokuGame(4);
            }
        }

        private void SudokuGrid9x9RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sudokuGrid9x9RadioButton.Checked)
            {
                InitializeSudokuGame(9);
            }
        }

        private void SudokuGrid16x16RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sudokuGrid16x16RadioButton.Checked)
            {
                InitializeSudokuGame(16);
            }
        }

        private void SudokuGrid25x25RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sudokuGrid25x25RadioButton.Checked)
            {
                InitializeSudokuGame(25);
                MessageBox.Show("Due to the large grid size of the puzzle, the computational power will be high; hence, this size option is turned off!", "25x25 Grid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //delete the following line to enable 25x25 grid
                sudokuGrid16x16RadioButton.Checked = true;
            }
        }

        #endregion

        #region ManualGameMode

        private void StartManualGameMode()
        {
            UIGameState();
            LockUserDefinedGrid();
        }

        private void LockUserDefinedGrid()
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

        private Task StartLevelGameModeAsync()
        {
            int hintsCount;
            if (beginnerGameMode.Checked)
            {
                hintsCount = (int)(gridSize * gridSize / 1.5);
            }
            else if (intermediateGameMode.Checked)
            {
                hintsCount = (int)(gridSize * gridSize / 2.5);
            }
            else
            {
                hintsCount = gridSize * gridSize / 4;
            }

           SolveSudoku(0, -1);

            UIGameState();

            // Assign the hints count based on the 
            // level player chosen
            ShowRandomHints(hintsCount);
            return Task.CompletedTask;
        }

        private void ShowRandomHints(int hintsCount)
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

            List<char> numsLeft = new List<char>(possibleGridEntries);
            //Add the set of gridSize if there's any other grids than 9 and 4
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




        #region Validations


        private bool ValidateSudoku()
        {
            bool hasNonEmptyCell = false; // Flag to track if there is at least one non-empty cell
            var wrongCells = new List<SudokuCell>();

            foreach (var cell in gridCells)
            {
                if (cell.Text != string.Empty)
                {
                    hasNonEmptyCell = true;
                    if (!possibleGridEntries.Contains(cell.Text[0]) || !IsCellValid(cell.Text[0], cell.X, cell.Y))
                        wrongCells.Add(cell);
                }
            }

            if (wrongCells.Any())
            {
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                return false;
            }

            return hasNonEmptyCell; // Return false if all cells are empty, true otherwise
        }

        private void CheckFinalAnswer()
        {
            if (!ValidateSudoku())
            {
                MessageBox.Show("Invalid Sudoku Board!", "Sudoku Solver", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Congratulations! You solved the Sudoku puzzle!", "Sudoku Solver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool IsCellValid(char value, int x, int y)
        {
            for (int i = 0; i < gridSize; i++)
            {
                // Check all the cells in vertical direction
                if (i != y && gridCells[x, i].CorrectAnswer == value)
                    return false;

                // Check all the cells in horizontal direction
                if (i != x && gridCells[i, y].CorrectAnswer == value)
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

        private void ClearInputCells()
        {
            foreach (var cell in gridCells)
            {
                // Clear the cell only if it is not locked
                if (cell.IsLocked == false)
                    cell.Clear();
            }
        }

        #region UIElementsHandling

        private void UIDefaultState()
        {
            checkEntryButton.Enabled = false;
            checkButton.Enabled = false;

            sudokuPanel.Enabled = false;
            gameModeGroupBox.Enabled = true;
            cheatAnswerButton.Enabled = false;
            resetGameButton.Enabled = false;
            clearInputButton.Enabled = false;
        }

        private void UIPreGameState()
        {
            checkEntryButton.Show();
            checkEntryButton.Enabled = true;
            checkButton.Hide();
            checkButton.Enabled = false;

            sudokuPanel.Enabled = true;
            gameModeGroupBox.Enabled = false;
            cheatAnswerButton.Enabled = false;
            resetGameButton.Enabled = true;
            clearInputButton.Enabled = false;
        }

        private void UIGameState()
        {
            checkEntryButton.Hide();
            checkEntryButton.Enabled = false;
            checkButton.Show();
            checkButton.Enabled = true;


            sudokuPanel.Enabled = true;
            gameModeGroupBox.Enabled = false;
            cheatAnswerButton.Enabled = true;
            resetGameButton.Enabled = true;
            clearInputButton.Enabled = true;
        }


        private void ColourCellsAffected(SudokuCell cell)
        {
            int x = cell.X;
            int y = cell.Y;
            for (int i = 0; i < gridSize; i++)
            {
                if (gridCells[x, i].BackColor == SystemColors.Control)
                {
                    gridCells[x, i].BackColor = ColorTranslator.FromHtml("#e0e7ee");
                }
                else
                {
                    gridCells[x, i].BackColor = ColorTranslator.FromHtml("#d0dfec");
                }
                if (gridCells[i, y].BackColor == SystemColors.Control)
                {
                    gridCells[i, y].BackColor = ColorTranslator.FromHtml("#e0e7ee");
                }
                else
                {
                    gridCells[i, y].BackColor = ColorTranslator.FromHtml("#d0dfec");
                }
            }


            int sqrtGridSize = (int)Math.Sqrt(gridSize);
            for (int i = (x - (x % sqrtGridSize)); i < x - (x % sqrtGridSize) + sqrtGridSize; i++)
            {
                for (int j = (y - (y % sqrtGridSize)); j < y - (y % sqrtGridSize) + sqrtGridSize; j++)
                {
                    if (gridCells[i, j].BackColor == SystemColors.Control)
                    {
                        gridCells[i, j].BackColor = ColorTranslator.FromHtml("#e0e7ee");
                    }
                    else
                    {
                        gridCells[i, j].BackColor = ColorTranslator.FromHtml("#d0dfec");
                    }
                }
            }

        }

        private void ApplyEmptyGridBackColour()
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                    gridCells[i, j].BackColor = ((i / (int)Math.Sqrt(gridSize)) + (j / (int)Math.Sqrt(gridSize))) % 2 == 0 ? SystemColors.Control : Color.LightGray;
            }
        }
        #endregion

        #region Clicks/Presses

        private void CellInPanel_click(object sender, EventArgs e)
        {
            var cell = sender as SudokuCell;
            ApplyEmptyGridBackColour();
            ColourCellsAffected(cell);
            cell.BackColor = ColorTranslator.FromHtml("#a8c7e1");
        }

        private void CellInPanel_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;

            // Do nothing if the cell is locked
            if (cell.IsLocked)
                return;

            // Add the pressed key value in the cell only if it is a number
            char valueEntered = char.ToUpper(e.KeyChar.ToString()[0]);
            if (valueEntered == '0')
            {
                cell.Clear();
                cell.ForeColor = SystemColors.ControlDarkDark;
            }
            else if (possibleGridEntries.Contains(valueEntered))
            {
                cell.Text = valueEntered.ToString();
                cell.ForeColor = SystemColors.ControlDarkDark;
            }
            if (checkEntryButton.Visible)
                cell.CorrectAnswer = valueEntered.ToString()[0];
        }

        private void CheckEntryButton_Click(object sender, EventArgs e)
        {
            if (ValidateSudoku() && SolveSudoku(0, -1))
            {
                StartManualGameMode();
                MessageBox.Show("Game started! Good luck", "Sudoku Solver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fix your entries since they are invalid. \nBe sure that the grid is not empty and applies sudoku rules!", "Sudoku Solver", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            CheckFinalAnswer();
        }

        private void ClearInputButton_Click(object sender, EventArgs e)
        {
            if (checkEntryButton.Visible)
                ResetGameButton_Click(sender, e);
            else
                ClearInputCells();
        }

        private void ResetGameButton_Click(object sender, EventArgs e)
        {
            InitializeSudokuGame(gridSize);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (manualEntryGameMode.Checked)
            {
                UIPreGameState();
                MessageBox.Show("Please fill the question hint cells", "Sudoku Solver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                StartLevelGameModeAsync();
                MessageBox.Show("Game started! Good luck", "Sudoku Solver", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
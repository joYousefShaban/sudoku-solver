using System.Windows.Forms;

namespace SudokuDektopClient.Impl
{
    class SudokuCell : Button
    {
        public char CorrectAnswer { get; set; }
        public bool IsLocked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Clear()
        {
            this.Text = string.Empty;
            this.IsLocked = false;
        }
    }
}
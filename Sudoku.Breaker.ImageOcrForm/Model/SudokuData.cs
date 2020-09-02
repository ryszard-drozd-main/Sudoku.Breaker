namespace Sudoku.Breaker.ImageOcrForm.Model
{
    public class SudokuData
    {
        private int[,] data;

        public SudokuData()
        {
            data = new int[9,9];

            ResetAll();
        }

        private void ResetAll()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    data[i, j] = -1;
        }

        public void Set(int i, int j, int x)
        {
            data[i, j] = x;
        }
        public void Reset(int i, int j)
        {
            data[i, j] = -1;
        }
        public int Get(int i, int j)
        {
            return data[i, j];
        }
    }
}

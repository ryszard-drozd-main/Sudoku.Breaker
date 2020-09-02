using Sudoku.Model.Dto;
using Sudoku.Model.Services;
using System;

namespace Sudoku.Model.Impl.Services
{
    public class BoardRefresh : IBoardRefresh
    {
        private readonly IBoardAccessor _squareAccessor;

        public BoardRefresh(IBoardAccessor squareAccessor)
        {
            _squareAccessor = squareAccessor;
        }

        public void Refresh(IBoard board)
        {
            var availableValues = new bool[board.Squares.Length + 1];

            Action setAvailableValues = () => {
                for (int i = 1; i <= board.Squares.Length; i++)
                    availableValues[i] = true;
            };
            Action<ISquare> resetOtherFromSquare = (square) => {
                for (int i = 0; i < square.Fields.Length; i++)
                {
                    if (square.Fields[i].RealValue != EmptyField.Empty)
                        availableValues[square.Fields[i].RealValue] = false;
                }
            };
            Action<int,int> resetFromRow = (row,except) => {
                for(int c = 0; c < board.Squares.Length; c++)
                {
                    if (c == except)
                        continue;
                    var fld = _squareAccessor.GetField(board, row, c);
                    if (fld.RealValue != EmptyField.Empty)
                        availableValues[fld.RealValue] = false;
                }
            };
            Action<int,int> resetFromCol = (col,except) => {
                for (int r = 0; r < board.Squares.Length; r++)
                {
                    if (r == except)
                        continue;
                    var fld = _squareAccessor.GetField(board, r, col);
                    if(fld.RealValue != EmptyField.Empty)
                        availableValues[fld.RealValue] = false;
                }
            };
            Action<IField> copy = (fld) => {
                for (int i = 1; i <= board.Squares.Length; i++)
                    fld.CouldBe[i] = availableValues[i];
            };

            for (int s = 0; s < board.Squares.Length; s++)
            {
                var ss = board.Squares[s];

                for(int f = 0; f < ss.Fields.Length; f++)
                {
                    var fld = ss.Fields[f];
                    if (fld.RealValue != EmptyField.Empty)
                        continue;
                    setAvailableValues();
                    resetOtherFromSquare(ss);
                    int row = (3 * (s / 3)) + (f / 3);
                    int col = (3 * (s % 3)) + (f % 3);
                    resetFromRow(row,col);
                    resetFromCol(col,row);
                    copy(fld);
                }
            }
        }
    }
}

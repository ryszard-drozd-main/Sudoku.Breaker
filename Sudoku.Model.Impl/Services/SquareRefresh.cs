using Sudoku.Model.Dto;
using Sudoku.Model.Impl.Dto;
using Sudoku.Model.Services;
using System;

namespace Sudoku.Model.Impl.Services
{
    public class SquareRefresh : ISquareRefresh
    {
        private readonly ISquareAccessor _squareAccessor;

        public SquareRefresh(ISquareAccessor squareAccessor)
        {
            _squareAccessor = squareAccessor;
        }

        public void Refresh(IBoard square)
        {
            var availableValues = new bool[square.Squares.Length + 1];

            Action setAvailableValues = () => {
                for (int i = 1; i <= square.Squares.Length; i++)
                    availableValues[i] = true;
            };
            Action<ISquare> resetOtherFromSmallSquare = (smallSquare) => {
                for (int i = 0; i < smallSquare.Fields.Length; i++)
                {
                    if (smallSquare.Fields[i].RealValue != EmptyField.Empty)
                        availableValues[smallSquare.Fields[i].RealValue] = false;
                }
            };
            Action<int,int> resetFromRow = (row,except) => {
                for(int c = 0; c < square.Squares.Length; c++)
                {
                    if (c == except)
                        continue;
                    var fld = _squareAccessor.GetField(square, row, c);
                    if (fld.RealValue != EmptyField.Empty)
                        availableValues[fld.RealValue] = false;
                }
            };
            Action<int,int> resetFromCol = (col,except) => {
                for (int r = 0; r < square.Squares.Length; r++)
                {
                    if (r == except)
                        continue;
                    var fld = _squareAccessor.GetField(square, r, col);
                    if(fld.RealValue != EmptyField.Empty)
                        availableValues[fld.RealValue] = false;
                }
            };
            Action<IField> copy = (fld) => {
                for (int i = 1; i <= square.Squares.Length; i++)
                    fld.CouldBe[i] = availableValues[i];
            };

            for (int s = 0; s < square.Squares.Length; s++)
            {
                var ss = square.Squares[s];

                for(int f = 0; f < ss.Fields.Length; f++)
                {
                    var fld = ss.Fields[f];
                    if (fld.RealValue != EmptyField.Empty)
                        continue;
                    setAvailableValues();
                    resetOtherFromSmallSquare(ss);
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

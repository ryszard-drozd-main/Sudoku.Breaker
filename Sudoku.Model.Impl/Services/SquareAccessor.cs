using Sudoku.Model.Dto;
using Sudoku.Model.Services;

namespace Sudoku.Model.Impl.Services
{
    public class SquareAccessor : ISquareAccessor
    {
        public IField GetField(IBoard square, int row, int col)
        {
            var ROW = row / 3;
            var COL = col / 3;
            var index = (3 * ROW) + COL;
            var sq = square.Squares[index];
            var r = row - (3 * ROW);
            var c = col - (3 * COL);
            return sq.Fields[(3 * r) + c];
        }
    }
}

using Sudoku.Model.Dto;

namespace Sudoku.Model.Services
{
    public interface ISquareAccessor
    {
        IField GetField(IBoard square, int row, int col);
    }
}

using Sudoku.Model.Dto;

namespace Sudoku.Model.Services
{
    public interface IBoardAccessor
    {
        IField GetField(IBoard square, int row, int col);
    }
}

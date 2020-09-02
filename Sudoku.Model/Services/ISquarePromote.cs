using Sudoku.Model.Dto;

namespace Sudoku.Model.Services
{
    public interface ISquarePromote
    {
        bool Promote(IBoard square);
    }
}

using Sudoku.Model.Dto;

namespace Sudoku.Model.Services
{
    public interface IBoardPromote
    {
        bool Promote(IBoard square);
    }
}

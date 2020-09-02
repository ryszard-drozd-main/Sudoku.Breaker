using Sudoku.Model.Dto;

namespace Sudoku.Model.Services
{
    public interface ISquareRefresh
    {
        void Refresh(IBoard square);
    }
}

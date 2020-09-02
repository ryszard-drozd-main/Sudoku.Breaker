using Sudoku.Model.Dto;

namespace Sudoku.Model.Services
{
    public interface IBoardRefresh
    {
        void Refresh(IBoard square);
    }
}

using Sudoku.Model.Dto;

namespace Sudoku.Model.Services
{
    public interface IBoardFactory
    {
        IBoard FromString(string str);
    }
}

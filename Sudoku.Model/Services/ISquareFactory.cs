using Sudoku.Model.Dto;

namespace Sudoku.Model.Services
{
    public interface ISquareFactory
    {
        IBoard FromString(string str);
    }
}

using Sudoku.Model.Dto;

namespace Sudoku.Model.Services
{
    public interface ISquareValidator
    {
        ISquareValidatorResult Validate(IBoard square);
    }
}

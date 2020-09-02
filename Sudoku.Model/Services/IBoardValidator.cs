using Sudoku.Model.Dto;

namespace Sudoku.Model.Services
{
    public interface IBoardValidator
    {
        IBoardValidatorResult Validate(IBoard square);
    }
}

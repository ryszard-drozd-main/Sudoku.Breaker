namespace Sudoku.Model.Dto
{
    public interface ISquareValidatorResult
    {
        bool Ok { get; }
        IConflict Conflict { get; }
    }
}

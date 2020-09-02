namespace Sudoku.Model.Dto
{
    public interface IBoardValidatorResult
    {
        bool Ok { get; }
        IConflict Conflict { get; }
    }
}

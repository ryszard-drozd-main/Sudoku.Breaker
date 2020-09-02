namespace Sudoku.Model.Dto
{
    public interface IConflict
    {
        byte RealValue { get; }
        int FirstRow { get; }
        int FirstCol { get; }
        int SecondRow { get; }
        int SecondCol { get; }
    }
}

namespace Sudoku.Model.Dto
{
    public interface IField
    {
        byte RealValue { get; set; }
        bool[] CouldBe { get; } // at index 0 - not use
    }
}

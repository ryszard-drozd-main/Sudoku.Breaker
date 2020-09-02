using Sudoku.Model.Dto;

namespace Sudoku.Model.Impl.Dto
{
    internal class Field : IField
    {
        public byte RealValue { get; set; } = EmptyField.Empty;


        public bool[] CouldBe { get; } = new bool[10]; // at index 0 - not use
    }
}

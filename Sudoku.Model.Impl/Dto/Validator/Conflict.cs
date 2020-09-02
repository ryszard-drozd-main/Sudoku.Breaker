using Sudoku.Model.Dto;

namespace Sudoku.Model.Impl.Dto.Validator
{
    internal class Conflict : IConflict
    {
        public Conflict(byte realValue, int firstRow, int firstCol, int secondRow, int secondCol)
        {
            RealValue = realValue;
            FirstRow = firstRow;
            FirstCol = firstCol;
            SecondRow = secondRow;
            SecondCol = secondCol;
        }
        public byte RealValue { get; set; }

        public int FirstRow { get; set; }

        public int FirstCol { get; set; }

        public int SecondRow { get; set; }

        public int SecondCol { get; set; }
    }
}

using Sudoku.Model.Dto;

namespace Sudoku.Model.Impl.Dto.Validator
{
    internal class SquareValidatorResult : ISquareValidatorResult
    {
        public SquareValidatorResult()
        {
            Ok = true;
            Conflict = null;
        }
        public SquareValidatorResult(byte realValue, int firstRow, int fistCol, int secondRow, int secondCol)
        {
            Ok = false;
            Conflict = new Conflict(realValue, firstRow, fistCol, secondRow, secondCol);
        }
        public bool Ok { get; }

        public IConflict Conflict { get; }
    }
}

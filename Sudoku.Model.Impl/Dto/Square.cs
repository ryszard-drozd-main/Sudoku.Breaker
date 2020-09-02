using Sudoku.Model.Dto;

namespace Sudoku.Model.Impl.Dto
{
    internal class Square : ISquare
    {
        public IField[] Fields { get; } = new Field[9];
    }
}

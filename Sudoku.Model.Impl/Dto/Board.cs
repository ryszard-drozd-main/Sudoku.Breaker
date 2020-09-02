using Sudoku.Model.Dto;

namespace Sudoku.Model.Impl.Dto
{
    internal class Board : IBoard
    {
        public ISquare[] Squares { get; } = new Square[9];
    }
}

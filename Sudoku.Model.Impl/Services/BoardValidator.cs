using Sudoku.Model.Dto;
using Sudoku.Model.Impl.Dto.Validator;
using Sudoku.Model.Services;
using System;

namespace Sudoku.Model.Impl.Services
{
    public class BoardValidator : IBoardValidator
    {
        private readonly IBoardAccessor _squareAccessor;

        public BoardValidator(IBoardAccessor squareAccessor)
        {
            _squareAccessor = squareAccessor;
        }
        public IBoardValidatorResult Validate(IBoard board)
        {
            IBoardValidatorResult result=null;
            int s=0;
            int row=0;
            int col=0;
            ISquare ss=null;

            Func<byte,int,bool> existInSquare = (fvalue,findex) => {
                for (int f = 0; f < ss.Fields.Length; f++)
                {
                    var field = ss.Fields[f];
                    if(f != findex && field.RealValue != EmptyField.Empty && field.RealValue == fvalue)
                    {
                        var r = (3 * (s / 3)) + (f / 3);
                        var c = (3 * (s % 3)) + (f % 3);
                        result = new BoardValidatorResult(fvalue, row, col, r, c);
                        return true;
                    }
                }
                return false;
            };

            Func<byte,bool> existInRow = (fvalue) => {
                for (int c = 0; c < board.Squares.Length; c++)
                {
                    if (c == col)
                        continue;
                    var field = _squareAccessor.GetField(board, row, c);
                    if (field.RealValue != EmptyField.Empty && field.RealValue == fvalue)
                    {
                        result = new BoardValidatorResult(fvalue, row, col, row, c);
                        return true;
                    }
                }
                return false;
            };

            Func<byte, bool> existInCol = (fvalue) => {
                for (int r = 0; r < board.Squares.Length; r++)
                {
                    if (r == row)
                        continue;
                    var field = _squareAccessor.GetField(board, r, col);
                    if (field.RealValue != EmptyField.Empty && field.RealValue == fvalue)
                    {
                        result = new BoardValidatorResult(fvalue, row, col, r, col);
                        return true;
                    }
                }
                return false;
            };

            for (s = 0; s < board.Squares.Length; s++)
            {
                ss = board.Squares[s];

                for (int f = 0; f < ss.Fields.Length; f++)
                {
                    var fld = ss.Fields[f];
                    if (fld.RealValue == EmptyField.Empty)
                        continue;
                    row = (3 * (s / 3)) + (f / 3);
                    col = (3 * (s % 3)) + (f % 3);
                    if(existInSquare(fld.RealValue,f))
                    {
                        return result;
                    }
                    if(existInRow(fld.RealValue))
                    {
                        return result;
                    }
                    if(existInCol(fld.RealValue))
                    {
                        return result;
                    }
                }
            }

            return new BoardValidatorResult();
        }
    }
}

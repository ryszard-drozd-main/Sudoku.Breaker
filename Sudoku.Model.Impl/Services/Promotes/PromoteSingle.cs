using Sudoku.Model.Dto;
using Sudoku.Model.Impl.Dto;
using Sudoku.Model.Services;

namespace Sudoku.Model.Impl.Services.Promotes
{
    internal class PromoteSingle : IBoardPromote
    {
        public bool Promote(IBoard square)
        {
            for (int s = 0; s < square.Squares.Length; s++)
            {
                var ss = square.Squares[s];
                for (int f = 0; f < ss.Fields.Length; f++)
                {
                    var fld = ss.Fields[f];
                    if (fld.RealValue == EmptyField.Empty && HasValue(fld))
                    {
                        fld.RealValue = Value(fld);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool HasValue(IField field)
        {
            int cnt = 0;
            for (int i = 1; i < field.CouldBe.Length; i++)
                if (field.CouldBe[i])
                    cnt++;
            return cnt == 1;
        }

        public byte Value(IField field)
        {
            for (int i = 1; i < field.CouldBe.Length; i++)
                if (field.CouldBe[i])
                    return (byte)i;
            return 0;
        }
    }
}

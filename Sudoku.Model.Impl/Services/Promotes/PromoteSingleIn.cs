using Sudoku.Model.Dto;
using Sudoku.Model.Impl.Dto;
using Sudoku.Model.Services;

namespace Sudoku.Model.Impl.Services.Promotes
{
    internal class PromoteSingleIn : IBoardPromote
    {
        public bool Promote(IBoard square)
        {
            for (int s = 0; s < square.Squares.Length; s++)
            {
                var ss = square.Squares[s];
                var cnt = new int[ss.Fields.Length + 1];
                for (int f = 0; f < ss.Fields.Length; f++)
                {
                    var fld = ss.Fields[f];
                    if (fld.RealValue == EmptyField.Empty)
                    {
                        for (int i = 1; i < fld.CouldBe.Length; i++)
                            if (fld.CouldBe[i])
                                cnt[i]++;
                    }
                }

                var theOne = TheOne(cnt);
                if(theOne > 0)
                {
                    for (int f = 0; f < ss.Fields.Length; f++)
                    {
                        var fld = ss.Fields[f];
                        if (fld.RealValue == EmptyField.Empty)
                        {
                            if(fld.CouldBe[theOne])
                            {
                                fld.RealValue = theOne;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private byte TheOne(int[] cnt)
        {
            for (int i = 1; i < cnt.Length; i++)
                if (cnt[i] == 1)
                    return (byte)i;
            return 0;
        }
    }
}

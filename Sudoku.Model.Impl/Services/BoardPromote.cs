using Sudoku.Model.Dto;
using Sudoku.Model.Impl.Services.Promotes;
using Sudoku.Model.Services;

namespace Sudoku.Model.Impl.Services
{
    public class BoardPromote : IBoardPromote
    {
        private readonly IBoardPromote[] _promotes = new IBoardPromote[] {
            new PromoteSingle()
            , new PromoteSingleIn()
        };

        public bool Promote(IBoard square)
        {
            for(int i = 0; i < _promotes.Length; i++)
            {
                var promote = _promotes[i];
                if (promote.Promote(square))
                    return true;
            }
            return false;
        }
    }
}

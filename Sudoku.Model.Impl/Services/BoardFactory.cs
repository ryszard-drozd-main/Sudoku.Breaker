using Sudoku.Model.Dto;
using Sudoku.Model.Impl.Dto;
using Sudoku.Model.Services;
using System.Linq;

namespace Sudoku.Model.Impl.Services
{
    public class BoardFactory : IBoardFactory
    {
        private readonly IBoardAccessor _squareAccessor;
        private readonly IBoardRefresh _fieldRefreshCouldBe;

        public BoardFactory(IBoardAccessor squareAccessor, IBoardRefresh fieldRefreshCouldBe)
        {
            _squareAccessor = squareAccessor;
            _fieldRefreshCouldBe = fieldRefreshCouldBe;
        }

        public IBoard FromString(string str)
        {
            var ret = Build();
            if(!string.IsNullOrEmpty(str))
                Initialize(ret, str);
            return ret;
        }

        private Board Build()
        {
            var ret = new Board();
            for (int i = 0; i < ret.Squares.Length; i++)
            {
                ret.Squares[i] = new Square();
                for (int j = 0; j < ret.Squares[i].Fields.Length; j++)
                    ret.Squares[i].Fields[j] = new Field();
            }
            return ret;
        }

        private void Initialize(Board ret, string str)
        {
            var groupSeparator = new char[] { ' ' };
            var equalSeparator = new char[] { '=' };
            var commaSeparator = new char[] { ',' };
            var items = str.Split(groupSeparator);
            items.ToList().ForEach(item=> {
                var elems = item.Split(equalSeparator);
                var args = elems[0].Split(commaSeparator);
                var row = int.Parse(args[0]);
                var col = int.Parse(args[1]);
                var val = byte.Parse(elems[1]);
                _squareAccessor.GetField(ret, row, col).RealValue = val;
            });
            _fieldRefreshCouldBe.Refresh(ret);
        }
    }
}

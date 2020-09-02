using System.Drawing;
using System.Text;

namespace Sudoku.Breaker.ImageOcrForm.Model
{
    public class SudokuPanel
    {
        private Rectangle _client;
        private int _sw;
        private int _sh;
        private Pen _smallRect;
        private Pen _bigRect;
        private Color _background;
        private Color _foreground;
        private Font _font;
        private Pen _focus;
        private int _clickR;
        private int _clickC;
        private SudokuData _data;
        private int _errR0;
        private int _errC0;
        private int _errR1;
        private int _errC1;

        public SudokuPanel(Pen smallRect, Pen bigRect, Color background, Pen focus, Color foreground, Font font)
        {
            _smallRect = smallRect;
            _bigRect = bigRect;
            _background = background;
            _foreground = foreground;
            _font = font;
            _focus = focus;
            _data = new SudokuData();
            ResetClick();
            //SampleData();
        }

        public SudokuData GetSudokuData()
        {
            return _data;
        }
        private void SampleData()
        {
            _data.Set(0, 1, 2);
            _data.Set(0, 5, 5);
            _data.Set(3, 1, 1);
            _data.Set(7, 3, 9);
        }

        public void OnLayout(Rectangle client)
        {
            _client = client;
            _sw = _client.Width / 9;
            _sh = _client.Height / 9;
        }
        private void DrawValues(Graphics g, int cnt, int s, int w)
        {
            using (var br = new SolidBrush(_foreground))
            {
            for (int i = 0; i < cnt; i++)
                for (int j = 0; j < cnt; j++)
                {
                    var y = i * s;
                    var x = j * w;
                    var v = _data.Get(i, j);
                    if(v > 0)
                    {
                            var ms = g.MeasureString("" + v, _font);
                            g.DrawString("" + v, _font, br, x + ((s - ms.Width) / 2), y + ((w - ms.Height) / 2));
                    }
                }
            }
        }
        private void DrawValueAt(Graphics g, int i, int j)
        {
            var y = i * _sh;
            var x = j * _sw;
            var v = _data.Get(i, j);
            if (v > 0)
            {
                using (var br = new SolidBrush(_foreground))
                {
                    var ms = g.MeasureString("" + v, _font);
                    g.DrawString("" + v, _font, br, x + ((_sw - ms.Width) / 2), y + ((_sh - ms.Height) / 2));
                }
            }
        }
        private void DrawCells(Graphics g, Pen pen, int cnt, int s, int w)
        {
            for(int i = 0; i < cnt; i++)
                for(int j = 0; j < cnt; j++)
                {
                    var y = i * s;
                    var x = j * w;
                    g.DrawRectangle(pen, x, y, s, w);
                }
        }
        public void Draw(Graphics g)
        {
            DrawCells(g, _smallRect, 9, _sw, _sh);
            DrawCells(g, _bigRect, 3, _sw*3, _sh*3);
            g.DrawRectangle(_bigRect, _client.X, _client.Y, _client.Width - 1, _client.Height - 1);
            DrawValues(g, 9, _sw, _sh);
        }
        public void Set(Graphics g, int v)
        {
            if (HasFocus())
            {
                Del(g);
                _data.Set(_clickR, _clickC, v);
                DrawValueAt(g, _clickR, _clickC);
            }
        }
        public void Del(Graphics g)
        {
            if(HasFocus())
            {
                _data.Reset(_clickR, _clickC);
                int d = 2;
                var x = _clickC * _sw + d + 1;
                var y = _clickR * _sh + d + 1;
                using (var br = new SolidBrush(_background))
                {
                    g.FillRectangle(br, x, y, _sw - 2 * d - 2, _sh - 2 * d - 2);
                }
            }
        }
        public void Click(int x, int y)
        {
            _clickR = y / _sh;
            _clickC = x / _sw;
        }
        public void ResetClick()
        {
            _clickR = -1;
            _clickC = -1;
        }
        public bool HasFocus()
        {
            return _clickR != -1;
        }
        public void Unfocus(Graphics g)
        {
            if (!HasFocus())
                return;
            int d = 2;
            var x = _clickC * _sw + d;
            var y = _clickR * _sh + d;
            using (var pen = new Pen(_background))
            {
                g.DrawRectangle(pen, x, y, _sw - 2 * d, _sh - 2 * d);
            }
        }
        public void Error(Graphics g, int r0, int c0, int r1, int c1)
        {
            _errR0 = r0;
            _errC0 = c0;
            _errR1 = r1;
            _errC1 = c1;
            int d = 2;
            var x = _errC0 * _sw + d;
            var y = _errR0 * _sh + d;
            g.DrawRectangle(_focus, x, y, _sw - 2 * d, _sh - 2 * d);
            x = _errC1 * _sw + d;
            y = _errR1 * _sh + d;
            g.DrawRectangle(_focus, x, y, _sw - 2 * d, _sh - 2 * d);
        }
        public void Focus(Graphics g)
        {
            if (_clickR == -1)
                return;
            int d = 2;
            var x = _clickC * _sw + d;
            var y = _clickR * _sh + d;
            g.DrawRectangle(_focus, x, y, _sw - 2 * d, _sh - 2 * d);
        }
        public string GetData()
        {
            var buffer = new StringBuilder();
            bool first = true;
            int cnt = 9;
            for (int i = 0; i < cnt; i++)
                for (int j = 0; j < cnt; j++)
                {
                    int v = _data.Get(i,j);
                    if(v>0)
                    {
                        if(first)
                        {
                            first = false;
                        }
                        else
                        {
                            buffer.Append(" ");
                        }
                        buffer.Append($"{i},{j}={v}");
                    }
                }
            return buffer.ToString();
        }
    }
}

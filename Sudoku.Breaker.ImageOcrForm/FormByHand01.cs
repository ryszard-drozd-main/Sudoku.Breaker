using Sudoku.Breaker.ImageOcrForm.Model;
using Sudoku.Model.Dto;
using Sudoku.Model.Impl.Services;
using Sudoku.Model.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sudoku.Breaker.ImageOcrForm
{
    public partial class FormByHand01 : Form
    {
        private SudokuPanel _sudokuPanel;
        public FormByHand01()
        {
            InitializeComponent();

            InitSudoku();
        }

        private void InitSudoku()
        {
            _sudokuPanel = new SudokuPanel(Pens.Red, Pens.DarkBlue, panelMain.BackColor, Pens.Maroon, panelMain.ForeColor, panelMain.Font);
        }

        private void button01_Click(object sender, EventArgs e)
        {
            using (var g = panelMain.CreateGraphics())
                _sudokuPanel.Set(g, 1);
        }

        private void button02_Click(object sender, EventArgs e)
        {
            using (var g = panelMain.CreateGraphics())
                _sudokuPanel.Set(g, 2);
        }

        private void button03_Click(object sender, EventArgs e)
        {
            using (var g = panelMain.CreateGraphics())
                _sudokuPanel.Set(g, 3);
        }

        private void button04_Click(object sender, EventArgs e)
        {
            using (var g = panelMain.CreateGraphics())
                _sudokuPanel.Set(g, 4);
        }

        private void button05_Click(object sender, EventArgs e)
        {
            using (var g = panelMain.CreateGraphics())
                _sudokuPanel.Set(g, 5);
        }

        private void button06_Click(object sender, EventArgs e)
        {
            using (var g = panelMain.CreateGraphics())
                _sudokuPanel.Set(g, 6);
        }

        private void button07_Click(object sender, EventArgs e)
        {
            using (var g = panelMain.CreateGraphics())
                _sudokuPanel.Set(g, 7);
        }

        private void button08_Click(object sender, EventArgs e)
        {
            using (var g = panelMain.CreateGraphics())
                _sudokuPanel.Set(g, 8);
        }

        private void button09_Click(object sender, EventArgs e)
        {
            using (var g = panelMain.CreateGraphics())
                _sudokuPanel.Set(g, 9);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            using (var g = panelMain.CreateGraphics())
                _sudokuPanel.Del(g);
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            var result = _sudokuPanel.GetData();
            textBoxMessages.Text = result;
            var accessor = new SquareAccessor();
            var fieldRefresh = new SquareRefresh(accessor);
            var promote = new SquarePromote();
            var squareFactory = new SquareFactory(accessor, fieldRefresh);
            var validator = new SquareValidator(accessor);
            var square = squareFactory.FromString(result);

            var vr = validator.Validate(square);
            if (!vr.Ok)
            {
                textBoxMessages.Text = $"{vr.Conflict.RealValue} występuje w ({vr.Conflict.FirstRow},{vr.Conflict.FirstCol}) i ({vr.Conflict.SecondRow},{vr.Conflict.SecondCol})";
                using (var g = panelMain.CreateGraphics())
                    _sudokuPanel.Error(g, vr.Conflict.FirstRow, vr.Conflict.FirstCol, vr.Conflict.SecondRow, vr.Conflict.SecondCol);
            }
            else
            {
                int promotes = 0;
                while (promote.Promote(square))
                {
                    promotes++;
                    fieldRefresh.Refresh(square);
                }
                var cnt = Print(square, accessor);
                if(cnt == 0)
                {
                    textBoxMessages.Text = $"Gotowe!";
                }
                else
                {
                    textBoxMessages.Text = $"Brakuje {cnt} liczb.";
                }
                panelMain.Invalidate();
            }
        }

        private int Print(IBoard square, ISquareAccessor accessor)
        {
            int cnt = 9 * 9;
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    var fld = accessor.GetField(square, i, j);
                    var v = fld.RealValue;
                    if (v != EmptyField.Empty)
                    {
                        cnt--;
                        _sudokuPanel.GetSudokuData().Set(i, j, v);
                    }
                }
            return cnt;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            _sudokuPanel.Draw(e.Graphics);
        }
        private void panelMain_Layout(object sender, LayoutEventArgs e)
        {
            _sudokuPanel.OnLayout(panelMain.ClientRectangle);
        }

        private void panelMain_MouseClick(object sender, MouseEventArgs e)
        {
            using (var g = panelMain.CreateGraphics())
            {
                _sudokuPanel.Unfocus(g);
                _sudokuPanel.Click(e.X, e.Y);
                _sudokuPanel.Focus(g);
            }
        }
    }
}

using System.Drawing;

namespace Sudoku.Breaker.ImageOcrForm.Model
{
    public class ImageContext
    {
        public string FileName { get; set; }
        public Rectangle Bounds { get; set; }
        public int X0 { get; set; }
        public int Y0 { get; set; }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public bool Drag { get; set; }
    }
}

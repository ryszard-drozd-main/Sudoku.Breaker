using System.Drawing;

namespace Sudoku.Breaker.ImageOcr.Services
{
    public interface IProcessImage
    {
        string Process(string path, Rectangle rect, Graphics g); // Tesseract
    }
}

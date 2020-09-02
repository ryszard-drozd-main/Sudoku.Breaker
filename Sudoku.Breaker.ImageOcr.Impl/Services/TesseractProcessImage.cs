using Sudoku.Breaker.ImageOcr.Services;
using Patagames.Ocr;
using Patagames.Ocr.Enums;
using System.Drawing;
using System.Text;
using Sudoku.Breaker.ImageOcr.Impl.Extensions;

namespace Sudoku.Breaker.ImageOcr.Impl.Services
{
    public class TesseractProcessImage : IProcessImage
    {
        public string Process(string path, Rectangle rect, Graphics g)
        {
            //see
            // https://www.codeguru.com/csharp/csharp/cs_graphics/screencaptures/extracting-text-from-an-image-using-tesseract-in-c.html
            var bitmap = new System.Drawing.Bitmap(path);
            var units = GraphicsUnit.Pixel;
            var bounds = bitmap.GetBounds(ref units);
            using (var api = OcrApi.Create())
            {
                api.Init(Languages.English);
                int w = rect.Width / 9;
                int h = rect.Height / 9;
                var builder = new StringBuilder();
                OcrBoxa ob;
                OcrPixa op;
                api.GetRegions(out ob, out op);
                for(int i = 0; i < op.Boxes.Length; i++)
                {
                    g.DrawRectangle(Pens.Red, op.Boxes[i]);
                }
                ob.Dispose();
                op.Dispose();
                //for(int r = 0; r < 9; r++)
                //    for(int c = 0; c < 9; c++)
                //    {
                //        int x = c * w + rect.X;
                //        int y = r * h + rect.Y;
                //        var rr = new Rectangle(x, y, w, h);
                //        var s = api.GetTextFromImage(bitmap, rr).ToInt();
                //        if(s.Length>0)
                //            builder.Append(s);
                //        g.DrawRectangle(Pens.Red, rr);
                //    }
                return builder.ToString();
            }
        }
    }
}

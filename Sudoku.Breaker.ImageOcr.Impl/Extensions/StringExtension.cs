using System.Text;

namespace Sudoku.Breaker.ImageOcr.Impl.Extensions
{
    public static class StringExtension
    {
        public static string ToInt(this string str)
        {
            var chars = str.ToCharArray();
            var builder = new StringBuilder();
            for (int i = 0; i < chars.Length; i++)
                if(char.IsDigit(chars[i]))
                    builder.Append(chars[i]);
            return builder.ToString();
        }
    }
}

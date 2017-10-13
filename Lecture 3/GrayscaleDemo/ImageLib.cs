using System;
using System.Drawing;
using System.Threading;

namespace GrayscaleDemo
{
    static class ImageLib
    {
        public delegate void ReportProgress(int percent);

        public static Bitmap ToGrayscale(
            Bitmap source,
            CancellationToken token,
            ReportProgress onProgress = null)
        {
            Bitmap result = new Bitmap(source);
            for (int y = 0; y < source.Height; y++)
            {
                int currentProgress = (int)(((double)y / source.Height) * 100);
                onProgress?.Invoke(currentProgress);

                for (int x = 0; x < source.Width; x++)
                {
                    if (token.IsCancellationRequested)
                    {
                        return result;
                    }

                    Color c = source.GetPixel(x, y);
                    var gray = (int)
                        (c.R * 0.299 +
                         c.G * 0.587 +
                         c.B * 0.114);
                    var grayColor = Color.FromArgb(gray, gray, gray);
                    result.SetPixel(x, y, grayColor);
                }
            }
            return result;
            

        }
    }
}

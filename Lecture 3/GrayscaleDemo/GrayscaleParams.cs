using System.Threading;

namespace GrayscaleDemo
{
    class GrayscaleParams
    {
        public string FileName { get; set; }
        public CancellationToken Token { get; set; }
    }
}

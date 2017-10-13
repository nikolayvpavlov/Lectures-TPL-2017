using System.Threading;

namespace GuiThreads
{
    class ServiceWisdom
    {
        public string GetTheUltimateAnswer()
        {
            Thread.Sleep(6000);
            return "42";
        }
    }
}

using LibLogSample.Logging;

namespace LibLogSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = LogProvider.For<Program>();
            if (logger.IsDebugEnabled())
            {
                logger.Debug("hello world");
            }
        }
    }
}

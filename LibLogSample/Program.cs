using LibLogSample.Logging;

namespace LibLogSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            var logger = LogProvider.For<Program>();
            if (logger.IsDebugEnabled())
            {
                logger.Debug("hello world");
            }

            logger.Debug(() => "hello world deferred");
        }
    }
}

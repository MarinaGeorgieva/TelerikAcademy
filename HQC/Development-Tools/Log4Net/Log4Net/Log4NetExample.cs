namespace Log4Net
{
    using System;

    using log4net;
    using log4net.Config;    

    public class Log4NetExample
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Log4NetExample));

        public static void Main()
        {
            BasicConfigurator.Configure();
            log.Error("This is a very important error!");
        }
    }
}

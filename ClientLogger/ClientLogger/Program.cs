using System;

using ClientLogger.Input;
using ClientLogger.Logging;


namespace ClientLogger
{
    public class Program
    {
        private static Logger logger;
        private static ConsoleInputManager consoleInputManager;

        public static void Main(string[] args)
        {
            logger = new Logger();

            logger.Debug("This is a Debug message!");
            logger.Default("This is a Default message!");
            logger.Error("This is an Error message!");
            logger.Fatal("This is a Fatal message!");
            logger.Info("This is an Info message!");
            logger.Trace("This is a Trace message!");
            logger.Warning("This is a Warning message!");

            consoleInputManager = new ConsoleInputManager();
        }
    }
}

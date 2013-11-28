using System;

using ClientLogger.Input;
using ClientLogger.Logging;


namespace ClientLogger
{
    /// <summary>
    /// Entry class of the application.
    /// </summary>
    public class Program
    {
        private static Logger logger;
        private static ConsoleInputManager consoleInputManager;


        /// <summary>
        /// Entry point of the application.
        /// </summary>
        /// <param name="args">Optional console-startup arguments.</param>
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

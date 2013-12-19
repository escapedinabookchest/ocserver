//using ClientLogger.Logging;


namespace ClientLogger
{
    /// <summary>
    /// Entry class of the application.
    /// </summary>
    public class Program
    {
        private static Client client;
        //private static Logger logger;

        private static ConsoleInputHandler consoleInputHandler;


        /// <summary>
        /// Entry point of the application.
        /// </summary>
        /// <param name="args">Optional console-startup arguments.</param>
        public static void Main(string[] args)
        {
            //logger = new Logger();
            consoleInputHandler = new ConsoleInputHandler();

            client = Client.Instance;
            client.Connect();

            client.Send(@"Hello from C# client!");


            #region Logger Testcode

            /* logger.Debug("This is a Debug message!");
            logger.Default("This is a Default message!");
            logger.Error("This is an Error message!");
            logger.Fatal("This is a Fatal message!");
            logger.Info("This is an Info message!");
            logger.Trace("This is a Trace message!");
            logger.Warning("This is a Warning message!"); */

            #endregion
        }
    }
}

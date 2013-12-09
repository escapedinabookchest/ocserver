using ClientLogger.Input;
using ClientLogger.Input.Events;


namespace ClientLogger
{
    /// <summary>
    /// Entry class of the application.
    /// </summary>
    public class Program
    {
        //private static Logger logger;


        /// <summary>
        /// Entry point of the application.
        /// </summary>
        /// <param name="args">Optional console-startup arguments.</param>
        public static void Main(string[] args)
        {
            /*logger = new Logger();

            logger.Debug("This is a Debug message!");
            logger.Default("This is a Default message!");
            logger.Error("This is an Error message!");
            logger.Fatal("This is a Fatal message!");
            logger.Info("This is an Info message!");
            logger.Trace("This is a Trace message!");
            logger.Warning("This is a Warning message!");*/

            ConsoleInputManager.Start();

            ConsoleInputManager.OnDelete += OnDelete;
            ConsoleInputManager.OnDirectory += OnDirectory;
            ConsoleInputManager.OnGet += OnGet;
            ConsoleInputManager.OnInformation += OnInformation;
            ConsoleInputManager.OnPut += OnPut;
            ConsoleInputManager.OnQuit += OnQuit;
            ConsoleInputManager.OnRename += OnRename;
            ConsoleInputManager.OnSynchronize += OnSynchronize;
        }

        protected static void OnDelete(DeleteEventArgs deleteEventArgs) { }

        protected static void OnDirectory(DirectoryEventArgs directoryEventArgs) { }

        protected static void OnGet(GetEventArgs getEventArgs) { }

        protected static void OnInformation(InfoEventArgs infoEventArgs) { }

        protected static void OnPut(PutEventArgs putEventArgs) { }

        protected static void OnQuit(QuitEventArgs quitEventArgs) { }

        protected static void OnRename(RenameEventArgs renameEventArgs) { }

        protected static void OnSynchronize(SynchronizeEventArgs syntSynchronizeEventArgs) { }
    }
}

using System;
using System.Text;
using System.Threading;

using ClientLogger.Input.Events;
using ClientLogger.Logging;


namespace ClientLogger.Input
{
    /// <summary>
    /// Reads messages from the console.
    /// </summary>
    /// <remarks>
    /// Handles the console input.
    /// </remarks>
    internal abstract class ConsoleInputManager
    {
        private static Thread mainThread;
        private static Logger logger;


        /// <summary>
        /// Starts the input manager for reading the console for task-messages.
        /// </summary>
        internal static void Start()
        {
            logger = new Logger();

            mainThread = new Thread(ReadConsole) {Name = "_mThread_ConInputManager"};
            mainThread.Start();
        }


        /// <summary>
        /// Reads the console contineously in a new thread.
        /// </summary>
        protected static void ReadConsole()
        {
            while (true)
            {
                var line = Console.ReadLine();
                if (line == null)
                    continue;

                var message = line.ToLower();
                switch (message)
                {
                    #region Supported Commands

                    case ConsoleCommand.INFO:
                        if (OnInformation != null)
                            OnInformation(InfoEventArgs.Empty);
                        break;

                    case ConsoleCommand.DIRECTORY:
                        if (OnDirectory != null)
                            OnDirectory(DirectoryEventArgs.Empty);
                        break;

                    case ConsoleCommand.GET:
                        if (OnGet != null)
                            OnGet(GetEventArgs.Empty);
                        break;

                    case ConsoleCommand.PUT:
                        if (OnPut != null)
                            OnPut(PutEventArgs.Empty);
                        break;

                    case ConsoleCommand.DELETE:
                        if (OnDelete != null)
                            OnDelete(DeleteEventArgs.Empty);
                        break;

                    case ConsoleCommand.RENAME:
                        if (OnRename != null)
                            OnRename(RenameEventArgs.Empty);
                        break;

                    case ConsoleCommand.QUIT:
                        if (OnQuit != null)
                            OnQuit(QuitEventArgs.Empty);
                        break;

                    case ConsoleCommand.SYNCHRONIZE:
                        if (OnSynchronize != null)
                            OnSynchronize(SynchronizeEventArgs.Empty);
                        break;

                    #endregion

                    default:
                        UndefinedMessage(message);
                        break;
                }
            }
// ReSharper disable once FunctionNeverReturns
        }


        private static void UndefinedMessage(string message)
        {
            logger.Warning("'" + message + "' is not recognized as internal or external task.");

            var stringBuilder = new StringBuilder();

            stringBuilder.Append("\nAvailable tasks are:");

            stringBuilder.Append("\n\ndel\t\tRemoves a file from the server.");
            stringBuilder.Append("\n\ndir\t\tReturns a list of filenames in a specific directory.");
            stringBuilder.Append("\n\nget\t\tGets a file from the server.");
            stringBuilder.Append("\n\ninfo\t\tReturns the name and version of the server.");
            stringBuilder.Append("\n\nput\t\tSends a file to the server.");
            stringBuilder.Append("\n\nquit\t\tCloses the connection with the server.");
            stringBuilder.Append("\n\nren\t\tRenames a file on the server.");
            stringBuilder.Append("\n\nsync\t\tCopies a local directory to a remote directory.");

            logger.Info(stringBuilder.ToString());
        }


        #region Command Events

        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommand.INFO"/> commands.
        /// </summary>
        internal static event OnInformationEventHandler OnInformation;
        
        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommand.DIRECTORY"/> commands.
        /// </summary>
        internal static event OnDirectoryEventHandler OnDirectory;
        
        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommand.GET"/> commands.
        /// </summary>
        internal static event OnGetEventHandler OnGet;
        
        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommand.PUT"/> commands.
        /// </summary>
        internal static event OnPutEventHandler OnPut;
        
        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommand.DELETE"/> commands.
        /// </summary>
        internal static event OnDeleteEventHandler OnDelete;
        
        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommand.RENAME"/> commands.
        /// </summary>
        internal static event OnRenameEventHandler OnRename;
        
        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommand.QUIT"/> commands.
        /// </summary>
        internal static event OnQuitEventHandler OnQuit;
        
        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommand.SYNCHRONIZE"/> commands.
        /// </summary>
        internal static event OnSynchronizeEventHandler OnSynchronize;

        #endregion
    }


    #region Command Event Handlers

    /// <summary>
    /// Event handler to handle incoming <see cref="ConsoleCommand.INFO"/> commands.
    /// </summary>
    /// <param name="infoEventArgs">Event arguments containing data to handle the event.</param>
    internal delegate void OnInformationEventHandler(InfoEventArgs infoEventArgs);
    
    /// <summary>
    /// Event handler to handle incoming <see cref="ConsoleCommand.DIRECTORY"/> commands.
    /// </summary>
    /// <param name="directoryEventArgs">Event arguments containing data to handle the event.</param>
    internal delegate void OnDirectoryEventHandler(DirectoryEventArgs directoryEventArgs);
    
    /// <summary>
    /// Event handler to handle incoming <see cref="ConsoleCommand.GET"/> commands.
    /// </summary>
    /// <param name="getEventArgs">Event arguments containing data to handle the event.</param>
    internal delegate void OnGetEventHandler(GetEventArgs getEventArgs);
    
    /// <summary>
    /// Event handler to handle incoming <see cref="ConsoleCommand.PUT"/> commands.
    /// </summary>
    /// <param name="putEventArgs">Event arguments containing data to handle the event.</param>
    internal delegate void OnPutEventHandler(PutEventArgs putEventArgs);
    
    /// <summary>
    /// Event handler to handle incoming <see cref="ConsoleCommand.DELETE"/> commands.
    /// </summary>
    /// <param name="deleteEventArgs">Event arguments containing data to handle the event.</param>
    internal delegate void OnDeleteEventHandler(DeleteEventArgs deleteEventArgs);
    
    /// <summary>
    /// Event handler to handle incoming <see cref="ConsoleCommand.RENAME"/> commands.
    /// </summary>
    /// <param name="renameEventArgs">Event arguments containing data to handle the event.</param>
    internal delegate void OnRenameEventHandler(RenameEventArgs renameEventArgs);
    
    /// <summary>
    /// Event handler to handle incoming <see cref="ConsoleCommand.QUIT"/> commands.
    /// </summary>
    /// <param name="quitEventArgs">Event arguments containing data to handle the event.</param>
    internal delegate void OnQuitEventHandler(QuitEventArgs quitEventArgs);
    
    /// <summary>
    /// Event handler to handle incoming <see cref="ConsoleCommand.SYNCHRONIZE"/> commands.
    /// </summary>
    /// <param name="synchrozinEventArgs">Event arguments containing data to handle the event.</param>
    internal delegate void OnSynchronizeEventHandler(SynchronizeEventArgs synchrozinEventArgs);

    #endregion
}

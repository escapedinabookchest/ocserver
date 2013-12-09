using System;
using System.Text;
using System.Threading;

using ClientLogger.Logging;


namespace ClientLogger.Input
{
    /// <summary>
    /// Reads messages from the console.
    /// </summary>
    /// <remarks>
    /// Handles the console input.
    /// </remarks>
    public abstract class ConsoleInputManager
    {
        private static Thread mainThread;
        private static Logger logger;

        
        /// <summary>
        /// Starts the input manager for reading the console for task-messages.
        /// </summary>
        public static void Start()
        {
            logger = new Logger();

            mainThread = new Thread(ReadConsole);
            mainThread.Name = "_mThread_ConInputManager";
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
                
                var message = Console.ReadLine().ToString().ToLower();
                switch (message)
                {
                    case "commit":
                        if (OnCommit != null)
                            OnCommit(CommitEventArgs.Empty);
                        break;

                    case "update":
                        if (OnUpdate != null)
                            OnUpdate(UpdateEventArgs.Empty);
                        break;

                    default:
                        UndefinedMessage(message);
                        break;
                }
            }
        }


        private static void UndefinedMessage(string message)
        {
            logger.Warning("'" + message + "' is not recognized as internal or external task.");
            
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("\nAvailable tasks are:");
            stringBuilder.Append("\n\ncommit\t\tUsed for committing a new file.");
            stringBuilder.Append("\n\nupdate\t\tUsed for updating the newest files from the server.");

            logger.Info(stringBuilder.ToString());
        }


        /// <summary>
        /// Handler for incoming 'commit' tasks.
        /// </summary>
        public static event OnCommitHandler OnCommit;

        /// <summary>
        /// Handler for incoming 'update' tasks.
        /// </summary>
        public static event OnUpdateHandler OnUpdate;
    }

    /// <summary>
    /// Delegate handler for incoming 'commit' events.
    /// </summary>
    /// <param name="commitEventArgs">Additional information for handling the event.</param>
    public delegate void OnCommitHandler(CommitEventArgs commitEventArgs);

    /// <summary>
    /// Delegate handler for incoming 'update' events.
    /// </summary>
    /// <param name="updateEventArgs">Additional information for handling the event.</param>
    public delegate void OnUpdateHandler(UpdateEventArgs updateEventArgs);
}

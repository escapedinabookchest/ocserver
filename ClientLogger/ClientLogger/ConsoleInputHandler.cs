using ClientLogger.Input;
using ClientLogger.Input.Events;


namespace ClientLogger
{
    /// <summary>
    /// Handles the events fired by the <see cref="ConsoleInputManager"/> class.
    /// </summary>
    public class ConsoleInputHandler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleInputHandler"/> class.
        /// </summary>
        public ConsoleInputHandler()
        {
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


        #region Event Handler Implementations

        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommands.DELETE"/> commands.
        /// </summary>
        /// <param name="deleteEventArgs">Event arguments containing data to handle the event.</param>
        protected void OnDelete(DeleteEventArgs deleteEventArgs) { }

        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommands.DIRECTORY"/> commands.
        /// </summary>
        /// <param name="directoryEventArgs">Event arguments containing data to handle the event.</param>
        protected void OnDirectory(DirectoryEventArgs directoryEventArgs) { }

        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommands.GET"/> commands.
        /// </summary>
        /// <param name="getEventArgs">Event arguments containing data to handle the event.</param>
        protected void OnGet(GetEventArgs getEventArgs) { }

        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommands.INFO"/> commands.
        /// </summary>
        /// <param name="infoEventArgs">Event arguments containing data to handle the event.</param>
        protected void OnInformation(InfoEventArgs infoEventArgs) { }

        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommands.PUT"/> commands.
        /// </summary>
        /// <param name="putEventArgs">Event arguments containing data to handle the event.</param>
        protected void OnPut(PutEventArgs putEventArgs) { }

        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommands.QUIT"/> commands.
        /// </summary>
        /// <param name="quitEventArgs">Event arguments containing data to handle the event.</param>
        protected void OnQuit(QuitEventArgs quitEventArgs) { }

        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommands.RENAME"/> commands.
        /// </summary>
        /// <param name="renameEventArgs">Event arguments containing data to handle the event.</param>
        protected void OnRename(RenameEventArgs renameEventArgs) { }

        /// <summary>
        /// Event handler to handle incoming <see cref="ConsoleCommands.SYNCHRONIZE"/> commands.
        /// </summary>
        /// <param name="synchronizeEventArgs">Event arguments containing data to handle the event.</param>
        protected void OnSynchronize(SynchronizeEventArgs synchronizeEventArgs) { }

        #endregion
    }
}

namespace ClientLogger.Input
{
    /// <summary>
    /// All supported commands by the console are stored here.
    /// </summary>
    /// <remarks>
    /// These commands are used by the <see cref="ConsoleInputManager"/> class.
    /// </remarks>
    internal struct ConsoleCommands
    {
        /// <summary>
        /// Gives the name and current version of the server.
        /// </summary>
        internal const string INFO = "info";
        
        /// <summary>
        /// Gives a list of filenames in a specific directory.
        /// <example>
        /// DIR C:\Test
        /// </example>
        /// </summary>
        internal const string DIRECTORY = "dir";

        /// <summary>
        /// Gets a file from the server.
        /// </summary>
        internal const string GET = "get";

        /// <summary>
        /// Sends a file to the server.
        /// </summary>
        internal const string PUT = "put";

        /// <summary>
        /// Removes a file from the server.
        /// </summary>
        internal const string DELETE = "del";

        /// <summary>
        /// Renames a file on the server.
        /// </summary>
        internal const string RENAME = "ren";

        /// <summary>
        /// Closes the connection with the server.
        /// </summary>
        internal const string QUIT = "quit";

        /// <summary>
        /// Merges two folders.
        /// <example>
        /// SYNC 'local directory' 'remote directory'
        /// </example>
        /// </summary>
        internal const string SYNCHRONIZE = "sync";
    }
}

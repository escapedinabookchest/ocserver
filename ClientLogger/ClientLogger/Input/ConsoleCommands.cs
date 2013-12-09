namespace ClientLogger.Input
{
    public struct ConsoleCommands
    {
        /// <summary>
        /// Gives the name and current version of the server.
        /// </summary>
        public const string INFO = "info";
        
        /// <summary>
        /// Gives a list of filenames in a specific directory.
        /// <example>
        /// DIR C:\Test
        /// </example>
        /// </summary>
        public const string DIRECTORY = "dir";

        /// <summary>
        /// Gets a file from the server.
        /// </summary>
        public const string GET = "get";

        /// <summary>
        /// Sends a file to the server.
        /// </summary>
        public const string PUT = "put";

        /// <summary>
        /// Removes a file from the server.
        /// </summary>
        public const string DELETE = "del";

        /// <summary>
        /// Renames a file on the server.
        /// </summary>
        public const string RENAME = "ren";

        /// <summary>
        /// Closes the connection with the server.
        /// </summary>
        public const string QUIT = "quit";

        /// <summary>
        /// Merges two folders.
        /// <example>
        /// SYNC 'local directory' 'remote directory'
        /// </example>
        /// </summary>
        public const string SYNCHRONIZE = "sync";
    }
}

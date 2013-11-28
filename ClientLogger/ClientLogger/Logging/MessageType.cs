namespace ClientLogger.Logging
{
    /// <summary>
    /// Message-types supported by the logger.
    /// </summary>
    /// <seealso cref="ILogger"/>
    public enum MessageType
    {
        /// <summary>
        /// The message shows debug information.
        /// </summary>
        DEBUG,

        /// <summary>
        /// The message shows nothing special.
        /// </summary>
        DEFAULT,

        /// <summary>
        /// The message shows something has failed, but the application can continue running.
        /// </summary>
        ERROR,

        /// <summary>
        /// The message shows something failed, what couldn't be handled properly.
        /// </summary>
        FATAL,

        /// <summary>
        /// The message shows information to keep track of state-changes etc.
        /// </summary>
        INFO,

        /// <summary>
        /// The message shows detailed information which make it able for the user to follow the flow
        /// of the program.
        /// </summary>
        TRACE,

        /// <summary>
        /// The message shows information something didn't went as expected, but the application can 
        /// continue running.
        /// </summary>
        WARNING
    }
}

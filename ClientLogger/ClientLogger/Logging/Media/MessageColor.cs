using System;


namespace ClientLogger.Logging.Media
{
    /// <summary>
    /// Supported <see cref="ConsoleColor"/> colors, used for each 
    /// <see cref="MessageType"/>.
    /// </summary>
    /// <seealso cref="MessageType"/>
    internal struct MessageColor
    {
        /// <summary>
        /// The <see cref="ConsoleColor"/> color, used for Debug-messages.
        /// </summary>
        internal const ConsoleColor DEBUG = ConsoleColor.Gray;

        /// <summary>
        /// The <see cref="ConsoleColor"/> color, used for default logging.
        /// </summary>
        internal const ConsoleColor DEFAULT = ConsoleColor.White;

        /// <summary>
        /// The <see cref="ConsoleColor"/> color, used for Error-messages.
        /// </summary>
        internal const ConsoleColor ERROR = ConsoleColor.Magenta;

        /// <summary>
        /// The <see cref="ConsoleColor"/> color, used for Fatal-messages.
        /// </summary>
        internal const ConsoleColor FATAL = ConsoleColor.Red;

        /// <summary>
        /// The <see cref="ConsoleColor"/> color, used for Info-messages.
        /// </summary>
        internal const ConsoleColor INFO = ConsoleColor.Green;

        /// <summary>
        /// The <see cref="ConsoleColor"/> color, used for Trace-messages.
        /// </summary>
        internal const ConsoleColor TRACE = ConsoleColor.DarkGray;

        /// <summary>
        /// The <see cref="ConsoleColor"/> color, used for Warning-messages.
        /// </summary>
        internal const ConsoleColor WARNING = ConsoleColor.Yellow;
    }
}

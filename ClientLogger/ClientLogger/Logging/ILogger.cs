using System;


namespace ClientLogger.Logging
{
    /// <summary>
    /// Interface used to write to log files.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Write a Debug message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        void Debug(string message);

        /// <summary>
        /// Write a Debug message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        /// <param name="exception">The exception occured with the message to log.</param>
        void Debug(string message, Exception exception);

        /// <summary>
        /// Write a Default message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        void Default(string message);

        /// <summary>
        /// Write a Default message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        /// <param name="exception">The exception occured with the message to log.</param>
        void Default(string message, Exception exception);

        /// <summary>
        /// Write an Error message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        void Error(string message);

        /// <summary>
        /// Write an Error message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        /// <param name="exception">The exception occured with the message to log.</param>
        void Error(string message, Exception exception);

        /// <summary>
        /// Write a Fatal message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        void Fatal(string message);

        /// <summary>
        /// Write a Fatal message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        /// <param name="exception">The exception occured with the message to log.</param>
        void Fatal(string message, Exception exception);

        /// <summary>
        /// Write an Info message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        void Info(string message);

        /// <summary>
        /// Write an Info message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        /// <param name="exception">The exception occured with the message to log.</param>
        void Info(string message, Exception exception);

        /// <summary>
        /// Write a Trace message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        void Trace(string message);

        /// <summary>
        /// Write a Trace message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        /// <param name="exception">The exception occured with the message to log.</param>
        void Trace(string message, Exception exception);

        /// <summary>
        /// Write a Warning message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        void Warning(string message);

        /// <summary>
        /// Write an Warning message to the console.
        /// </summary>
        /// <param name="message">The text of the message to log.</param>
        /// <param name="exception">The exception occured with the message to log.</param>
        void Warning(string message, Exception exception);
    }
}

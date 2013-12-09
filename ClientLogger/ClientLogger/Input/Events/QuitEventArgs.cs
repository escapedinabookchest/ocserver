using System;


namespace ClientLogger.Input.Events
{
    /// <summary>
    /// Additional information for handling incoming 'update' events.
    /// </summary>
    public class QuitEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuitEventArgs"/> class.
        /// </summary>
        public QuitEventArgs()
        {
            Console.WriteLine("Quit command!");
        }


        /// <summary>
        /// Gets an empty instance of the <see cref="QuitEventArgs"/> class.
        /// </summary>
        public static QuitEventArgs Empty
        {
            get { return new QuitEventArgs(); }
        }
    }
}

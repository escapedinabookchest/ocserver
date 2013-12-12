using System;


namespace ClientLogger.Input.Events
{
    /// <summary>
    /// Additional information for handling incoming 'update' events.
    /// </summary>
    public class InfoEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoEventArgs"/> class.
        /// </summary>
        public InfoEventArgs()
        {
            Console.WriteLine("Information command triggered!");
        }


        /// <summary>
        /// Gets an empty instance of the <see cref="InfoEventArgs"/> class.
        /// </summary>
        public static InfoEventArgs Empty
        {
            get { return new InfoEventArgs(); }
        }
    }
}

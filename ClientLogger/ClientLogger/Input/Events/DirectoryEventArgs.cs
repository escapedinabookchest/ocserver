using System;


namespace ClientLogger.Input.Events
{
    /// <summary>
    /// Additional information for handling incoming 'commit' events.
    /// </summary>
    public class DirectoryEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryEventArgs"/> class.
        /// </summary>
        public DirectoryEventArgs()
        {
            Console.WriteLine("Directory command!");
        }


        /// <summary>
        /// Gets an empty instance of the <see cref="DirectoryEventArgs"/> class.
        /// </summary>
        public static DirectoryEventArgs Empty
        {
            get { return new DirectoryEventArgs(); }
        }
    }
}

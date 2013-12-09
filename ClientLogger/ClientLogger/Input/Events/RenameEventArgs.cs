using System;


namespace ClientLogger.Input.Events
{
    /// <summary>
    /// Additional information for handling incoming 'update' events.
    /// </summary>
    public class RenameEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenameEventArgs"/> class.
        /// </summary>
        public RenameEventArgs()
        {
            Console.WriteLine("Rename command!");
        }


        /// <summary>
        /// Gets an empty instance of the <see cref="RenameEventArgs"/> class.
        /// </summary>
        public static RenameEventArgs Empty
        {
            get { return new RenameEventArgs(); }
        }
    }
}

using System;


namespace ClientLogger.Input.Events
{
    /// <summary>
    /// Additional information for handling incoming 'update' events.
    /// </summary>
    public class PutEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutEventArgs"/> class.
        /// </summary>
        public PutEventArgs()
        {
            Console.WriteLine("Put command!");
        }


        /// <summary>
        /// Gets an empty instance of the <see cref="PutEventArgs"/> class.
        /// </summary>
        public static PutEventArgs Empty
        {
            get { return new PutEventArgs(); }
        }
    }
}

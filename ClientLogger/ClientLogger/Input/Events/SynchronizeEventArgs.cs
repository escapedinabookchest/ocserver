using System;


namespace ClientLogger.Input.Events
{
    /// <summary>
    /// Additional information for handling incoming 'update' events.
    /// </summary>
    public class SynchronizeEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SynchronizeEventArgs"/> class.
        /// </summary>
        public SynchronizeEventArgs()
        {
            Console.WriteLine("Synchronize command triggered!");
        }


        /// <summary>
        /// Gets an empty instance of the <see cref="SynchronizeEventArgs"/> class.
        /// </summary>
        public static SynchronizeEventArgs Empty
        {
            get { return new SynchronizeEventArgs(); }
        }
    }
}

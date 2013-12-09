using System;


namespace ClientLogger.Input.Events
{
    /// <summary>
    /// Additional information for handling incoming 'update' events.
    /// </summary>
    public class GetEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEventArgs"/> class.
        /// </summary>
        public GetEventArgs()
        {
            Console.WriteLine("Get command!");
        }


        /// <summary>
        /// Gets an empty instance of the <see cref="GetEventArgs"/> class.
        /// </summary>
        public static GetEventArgs Empty
        {
            get { return new GetEventArgs(); }
        }
    }
}

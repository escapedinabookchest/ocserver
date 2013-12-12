using System;


namespace ClientLogger.Input.Events
{
    /// <summary>
    /// Additional information for handling incoming 'update' events.
    /// </summary>
    public class DeleteEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEventArgs"/> class.
        /// </summary>
        public DeleteEventArgs()
        {
            Console.WriteLine("Delete command triggered!");
        }


        /// <summary>
        /// Gets an empty instance of the <see cref="DeleteEventArgs"/> class.
        /// </summary>
        public static DeleteEventArgs Empty
        {
            get { return new DeleteEventArgs(); }
        }
    }
}

namespace ClientLogger
{
    /// <summary>
    /// Additional information for handling incoming 'update' events.
    /// </summary>
    public class UpdateEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEventArgs"/> class.
        /// </summary>
        public UpdateEventArgs()
        {
            //TODO: Add usefull code...
        }


        /// <summary>
        /// Gets an empty instance of the <see cref="UpdateEventArgs"/> class.
        /// </summary>
        public static UpdateEventArgs Empty
        {
            get { return new UpdateEventArgs(); }
        }
    }
}

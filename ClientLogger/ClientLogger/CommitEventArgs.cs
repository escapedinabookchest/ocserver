namespace ClientLogger
{
    /// <summary>
    /// Additional information for handling incoming 'commit' events.
    /// </summary>
    public class CommitEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommitEventArgs"/> class.
        /// </summary>
        public CommitEventArgs()
        {
            //TODO: Add usefull code...
        }


        /// <summary>
        /// Gets an empty instance of the <see cref="CommitEventArgs"/> class.
        /// </summary>
        public static CommitEventArgs Empty
        {
            get { return new CommitEventArgs(); }
        }
    }
}

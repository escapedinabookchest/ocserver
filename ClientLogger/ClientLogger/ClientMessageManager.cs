using System.Text;


namespace ClientLogger
{
    /// <summary>
    /// Manages the messages that will be sent from the client to the server.
    /// </summary>
    public abstract class ClientMessageManager
    {
        /// <summary>
        /// The header used for each message type.
        /// </summary>
        /// <remarks>
        /// SUPERSECRETPROTOCOL-1.0 'command_in_uppercase'
        /// </remarks>
        private const string MESSAGE_HEADER = "SUPERSECRETPROTOCOL-1.0";

        /// <summary>
        /// The optional source directory.
        /// </summary>
        /// <remarks>
        /// directory: 'full_path_to_source_directory'
        /// </remarks>
        private const string DIRECTORY = "directory:";

        /// <summary>
        /// The optional length of the source file.
        /// </summary>
        /// <remarks>
        /// length: 'source_file_length_in_bytes'
        /// </remarks>
        private const string LENGTH = "length:";

        /// <summary>
        /// The optional location of the source file.
        /// </summary>
        /// <remarks>
        /// file_location: 'full_path_to_source_file'
        /// </remarks>
        private const string FILE_LOCATION = "file_location:";


        /// <summary>
        /// Creates a message for the server.
        /// </summary>
        /// <param name="command">The command called from the client's side.</param>
        /// <param name="directory">The source directory required for the command.</param>
        /// <param name="length">The length of the source file required for the command.</param>
        /// <param name="fileLocation">The location of the source file required for the command.</param>
        /// <param name="fileInBytes">The source file in bytes required for the command.</param>
        public static void CreateMessage(string command, string directory = "", string length = "",
            string fileLocation = "", byte[] fileInBytes = null)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append(MESSAGE_HEADER + " " + command.ToUpper());

            if (!string.IsNullOrEmpty(directory))
                stringBuilder.Append("\n" + DIRECTORY + " " + directory);

            if (!string.IsNullOrEmpty(length))
                stringBuilder.Append("\n" + LENGTH + " " + length);

            if (string.IsNullOrEmpty(fileLocation) || fileInBytes == null) 
                return;
            
            stringBuilder.Append("\n" + FILE_LOCATION + " " + fileLocation);
            stringBuilder.Append("\n\n");

            foreach (var fileByte in fileInBytes)
                stringBuilder.Append(fileByte);
        }
    }
}

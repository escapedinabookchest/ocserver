using System;
using System.Text;
using System.Threading;

using ClientLogger.Logging;


namespace ClientLogger.Input
{
    public class ConsoleInputManager
    {
        private Thread mainThread;
        private Logger logger;

        public ConsoleInputManager()
        {
            logger = new Logger();

            mainThread = new Thread(ReadConsole);
            mainThread.Name = "_mThread_ConInputManager";
            mainThread.Start();
        }

        protected void ReadConsole()
        {
            while (true)
            {
                var message = Console.ReadLine().ToString().ToLower();
                switch (message)
                {
                    case "commit":
                        break;

                    case "update":
                        break;

                    default:
                        UndefinedMessage(message);
                        break;
                }
            }
        }


        private void UndefinedMessage(string message)
        {
            logger.Warning("'" + message + "' is not recognized as internal or external task.");
            
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("\nAvailable tasks are:");
            stringBuilder.Append("\n\ncommit\t\tUsed for committing a new file.");
            stringBuilder.Append("\n\nupdate\t\tUsed for updating the newest files from the server.");

            logger.Info(stringBuilder.ToString());
        }
    }
}

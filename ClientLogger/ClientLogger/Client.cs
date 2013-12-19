using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

using ClientLogger.Logging;


namespace ClientLogger
{
    public class Client
    {
        public const string HOSTNAME = "localhost"; // 127.0.0.1
        public const int PORT = 8080;

        private static Client client;

        private BinaryWriter binaryWriter;
        private BinaryReader binaryReader;

        private readonly Logger logger;
        private readonly TcpClient tcpClient;


        private Client()
        {
            logger = new Logger();
            tcpClient = new TcpClient();
        }

        public static Client Instance
        {
            get 
            {
                if (client != null) 
                    return client;

                client = new Client
                {
                    Hostname = HOSTNAME,
                    Port = PORT
                };

                return client;
            }
        }

        public string Hostname { get; private set; }

        public int Port { get; private set; }


        public void Connect()
        {
            try
            {
                tcpClient.Connect(Hostname, Port);

                binaryWriter = new BinaryWriter(tcpClient.GetStream());
                binaryReader = new BinaryReader(tcpClient.GetStream());
            }
            catch (Exception exception)
            {
                logger.Error(exception.ToString());
            }
        }

        public void Disconnect()
        {
            try
            {
                if (!tcpClient.Connected) 
                    return;

                binaryWriter.Close();
                binaryReader.Close();

                tcpClient.Close();
            }
            catch (Exception exception)
            {
                logger.Error(exception.ToString());
            }
        }

        public bool Send(string input)
        {
            if (!tcpClient.Connected) 
                return false;

            binaryWriter.Write(input);
            binaryWriter.Flush();

            return true;
        }

        public string Receive()
        {
            var output = "";

            if (!tcpClient.Connected) 
                return output;

            output = binaryReader.ReadString();
            binaryReader.Dispose();

            return output;
        }
    }
}
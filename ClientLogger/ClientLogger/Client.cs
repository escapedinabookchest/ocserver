using System;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace ClientLogger
{
    public class Client
    {
        public const int IP_ADDRESS = 2130706432; // 127.0.0.0
        public const int PORT = 50000;

        private static Client client;

        private readonly TcpClient tcpClient;

        private readonly BinaryWriter binaryWriter;
        private readonly BinaryReader binaryReader;


        private Client() 
        {
            tcpClient = new TcpClient();
            binaryWriter = new BinaryWriter(tcpClient.GetStream());
            binaryReader = new BinaryReader(tcpClient.GetStream());
        }

        public static Client Instance
        {
            get 
            {
                if (client != null) 
                    return client;

                client = new Client {IPAddress = new IPAddress(IP_ADDRESS), Port = PORT};

                return client;
            }
        }

        public IPAddress IPAddress { get; private set; }

        public int Port { get; private set; }


        public void Connect()
        {
            try
            {
                tcpClient.Connect(IPAddress, Port);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
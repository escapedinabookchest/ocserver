using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ClientLogger
{
    public class Client
    {
        public static readonly int IP_ADDRESS = 2130706432; // 127.0.0.0
        public static readonly int PORT = 50000;

        private static Client client;
        private TcpClient tcp;
        private IPAddress ip;
        private int port;

        private BinaryWriter writer;
        private BinaryReader reader;

        private Client() 
        {
            tcp = new TcpClient();
            writer = new BinaryWriter(tcp.GetStream());
            reader = new BinaryReader(tcp.GetStream());
        }

        public static Client Instance
        {
            get 
            {
                if (client == null)
                {
                    client = new Client();
                    client.IP = new IPAddress(IP_ADDRESS);
                    client.Port = PORT;
                }

                return client;
            }
        }

        public IPAddress IP
        {
            get { return this.ip; }
            private set { this.ip = value; }
        }

        public int Port
        {
            get { return this.port; }
            private set { port = value; }
        }

        public void Connect()
        {
            try
            {
                tcp.Connect(IP, Port);
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
                if (tcp.Connected)
                {
                    writer.Close();
                    reader.Close();
                    tcp.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public bool Send(string input)
        {
            if (tcp.Connected)
            {
                writer.Write(input);
                writer.Flush();
                return true;
            }
            else
                return false;
        }

        public string Receive()
        {
            string output = "";

            if (tcp.Connected)
            {
                output = reader.ReadString();
                reader.Dispose();
            }

            return output;
        }
    }
}
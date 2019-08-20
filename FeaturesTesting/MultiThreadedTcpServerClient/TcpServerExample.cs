using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace FeaturesTesting.MultiThreadedTcpServerClient
{
    class TcpServerExample
    {
        public static void Run()
        {
            TcpListener listener = null;
            try
            {
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
                listener.Start();
                Console.WriteLine("Server started");

                while (true)
                {
                    Console.WriteLine("Waiting for incoming client connections...");
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("Qccepted new client connection...");
                    Thread t = new Thread(ProcessClientRequests);
                    t.Start(client);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (listener != null)
                    listener.Stop();
            }
        }

        private static void ProcessClientRequests(object arg)
        {
            TcpClient client = arg as TcpClient;
            if (client != null)
            {
                try
                {
                    StreamReader reader = new StreamReader(client.GetStream());
                    StreamWriter writer = new StreamWriter(client.GetStream());

                    string s = String.Empty;

                    while (!(s = reader.ReadLine()).Equals("Exit") || (s == null))
                    {
                        Console.WriteLine("From client -> {0}", s);
                        writer.WriteLine("From Server -> {0}", s);
                        writer.Flush();
                    }

                    reader.Close();
                    writer.Close();
                    client.Close();
                    Console.WriteLine("Closing client connection");
                }
                catch (IOException)
                {
                    Console.WriteLine("Problem with client communication. Exiting Thread.");
                }
                finally
                {
                    if (client != null)
                        client.Close();
                }
            }
        }
    }
}

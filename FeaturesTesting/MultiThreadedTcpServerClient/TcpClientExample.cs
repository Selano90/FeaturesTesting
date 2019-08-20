using System;
using System.IO;
using System.Net.Sockets;

namespace FeaturesTesting.MultiThreadedTcpServerClient
{
    class TcpClientExample
    {
        public static void Run()
        {
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 8080);
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                string s = String.Empty;

                while (!s.Equals("Exit"))
                {
                    Console.WriteLine("Enter string to send to the server");
                    s = Console.ReadLine();
                    Console.WriteLine();
                    writer.WriteLine(s);
                    writer.Flush();
                    string server_string = reader.ReadLine();
                    Console.WriteLine(server_string);
                }

                reader.Close();
                writer.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}

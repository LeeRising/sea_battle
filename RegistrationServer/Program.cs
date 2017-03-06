using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using RegistrationServer.Tools;
using System.Runtime.InteropServices;

namespace RegistrationServer
{
    class Program
    {
        static void Main()
        {
            bool loopState = true;
            TcpListener serverSocket = new TcpListener(IPAddress.Parse("192.168.1.101"), 9858);
            TcpClient clientSocket = default(TcpClient);
            int counter = 0;
            serverSocket.Start();
            var conwriter = new ConsoleWriter(Console.Out);
            Console.SetOut(conwriter);
            Console.WriteLine(DateTime.Now.ToString("[HH:mm:ss]") + " Registration Server Started");
            try
            {
                while ((loopState))
                {
                    counter += 1;
                    clientSocket = serverSocket.AcceptTcpClient();

                    byte[] bytesFrom = new byte[99999];
                    string dataFromClient = null;

                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    dataFromClient = Encoding.UTF8.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                    Console.WriteLine(DateTime.Now.ToString("[hh:mm:ss]")+" "+dataFromClient);

                    Logger.LoggerMthod(conwriter.GetLines(), DateTime.Now);
                    clientSocket = null;
                    continue;
                }
            }
            catch (Exception)
            {
                loopState = false;
                clientSocket.Close();
                serverSocket.Stop();
                Console.WriteLine("Server Stoped!");
                Logger.LoggerMthod(conwriter.GetLines(), DateTime.Now);
            }
            finally
            {
                clientSocket.Close();
                serverSocket.Stop();
                Console.WriteLine("Server Stoped!");
                Logger.LoggerMthod(conwriter.GetLines(), DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}

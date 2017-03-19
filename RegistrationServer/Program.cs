using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Log;
using RegistrationServer.Tools;
using System.Runtime.InteropServices;

namespace RegistrationServer
{
    class Program
    {
        private static TcpListener serverSocket;
        private static TcpClient clientSocket;
        private static ConsoleWriter conwriter;
        private static bool isclosing = false;
        private static int counter;
        static void Main()
        {
            Console.Title = "Sea Battle Registration Server";
            SetConsoleCtrlHandler(new HandlerRoutine(ConsoleCtrlCheck), true);
            serverSocket = new TcpListener(IPAddress.Parse("192.168.1.101"), 9858);
            clientSocket = default(TcpClient);
            counter = 0;
            serverSocket.Start();
            conwriter = new ConsoleWriter(Console.Out);
            Console.SetOut(conwriter);
            Console.WriteLine(DateTime.Now.ToString("[HH:mm:ss]") + " Registration Server Started");
            while (!isclosing)
            {
                while ((true))
                {
                    clientSocket = serverSocket.AcceptTcpClient();

                    byte[] bytesFrom = new byte[1024];
                    string dataFromClient = null;

                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                    dataFromClient = Encoding.UTF8.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    Console.WriteLine(DateTime.Now.ToString("[HH:mm:ss]") + " " + dataFromClient);
                    counter++;
                }
            }
        }
        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);
        private static bool ConsoleCtrlCheck(CtrlTypes ctrlType)
        {
            switch (ctrlType)
            {
                case CtrlTypes.CTRL_CLOSE_EVENT:
                    isclosing = true;
                    clientSocket.Close();
                    serverSocket.Stop();
                    Console.WriteLine(DateTime.Now.ToString("[HH:mm:ss]") + " Server Stoped!");
                    Console.WriteLine(DateTime.Now.ToString("[HH:mm:ss]") + " Count of registration members:" + counter);
                    Logger.LoggerMethod("reg",conwriter.GetLines(), DateTime.Now);
                    break;
                case CtrlTypes.CTRL_C_EVENT:
                    isclosing = true;
                    break;
                case CtrlTypes.CTRL_BREAK_EVENT:
                    isclosing = true;
                    break;
                case CtrlTypes.CTRL_LOGOFF_EVENT:
                case CtrlTypes.CTRL_SHUTDOWN_EVENT:
                    isclosing = true;
                    break;

            }
            return true;
        }
        #region CloseConsoleHoock
        [DllImport("Kernel32")]
        public static extern bool SetConsoleCtrlHandler(HandlerRoutine Handler, bool Add);
        public delegate bool HandlerRoutine(CtrlTypes CtrlType);
        public enum CtrlTypes
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT,
            CTRL_CLOSE_EVENT,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT
        }

        #endregion
    }
}

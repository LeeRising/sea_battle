﻿using ChatServer.Tools;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using Log;

namespace ChatServer
{
    class Program
    {
        private static TcpListener serverSocket;
        private static TcpClient clientSocket;
        private static ConsoleWriter conwriter;
        private static bool isclosing = false;
        static void Main()
        {
            Console.Title = "Sea Battle Chat Server";
            SetConsoleCtrlHandler(new HandlerRoutine(ConsoleCtrlCheck), true);
            serverSocket = new TcpListener(IPAddress.Parse("192.168.1.101"), 8858);
            clientSocket = default(TcpClient);
            serverSocket.Start();
            conwriter = new ConsoleWriter(Console.Out);
            Console.SetOut(conwriter);
            Console.WriteLine(DateTime.Now.ToString("[HH:mm:ss]") + " Chat Server Started");
            while (!isclosing)
            {
                while ((true))
                {
                    clientSocket = serverSocket.AcceptTcpClient();

                    byte[] bytesFrom = new byte[99999];
                    string dataFromClient = null;

                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                    dataFromClient = Encoding.UTF8.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    Console.WriteLine(DateTime.Now.ToString("[HH:mm:ss]") + " " + dataFromClient);
                }
            }
        }
        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);
        private static bool ConsoleCtrlCheck(CtrlTypes ctrlType)
        {
            try
            {

                switch (ctrlType)
                {
                    case CtrlTypes.CTRL_CLOSE_EVENT:
                        isclosing = true;
                        clientSocket.Close();
                        serverSocket.Stop();
                        Console.WriteLine(DateTime.Now.ToString("[HH:mm:ss]") + " Server Stoped!");
                        Logger.LoggerMethod("chat",conwriter.GetLines(), DateTime.Now);
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
            catch (Exception)
            {
                Logger.LoggerMethod("chat", conwriter.GetLines(), DateTime.Now);
                return false;
            }
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

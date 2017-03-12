using System;
using System.IO;

namespace Log
{
    public class Logger
    {
        public static void LoggerMethod(string _log_name, string[] lines, DateTime dt)
        {
            string log_name = @"log\" + _log_name + @"\log_" + dt.ToString("HHmmss_ddMMyyyy") + ".log";
            using (StreamWriter file = new StreamWriter(log_name, true))
            {
                foreach (var l in lines)
                {
                    file.WriteLine(l);
                }
                file.Close();
            }
        }
    }
}

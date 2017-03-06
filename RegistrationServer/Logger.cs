using System;
using System.IO;

namespace RegistrationServer
{
    class Logger
    {
        internal static void LoggerMthod(string[] lines,DateTime dt)
        {
            string log_name = @"log\log_" + dt.ToString("hhmmss_ddMMyyyy") + ".txt";
            if (!File.Exists(log_name))
            {
                var fc = File.Create(log_name);
                fc.Close();
            }
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

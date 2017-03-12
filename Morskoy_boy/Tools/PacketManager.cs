using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morskoy_boy.Tools
{
    class PacketManager
    {

        public static string _packetByte(string input)
        {
            string hexOutput = String.Empty;
            foreach (char letter in input)
            {
                int value = Convert.ToInt32(letter);
                hexOutput += String.Format("{0:X} ", value);
            }
            return hexOutput;
        }
    }
}

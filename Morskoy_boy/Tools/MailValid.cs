using System;
using System.Net.Mail;

namespace Morskoy_boy.Tools
{
    class MailValid
    {
        public static bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}

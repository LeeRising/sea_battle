using System.IO;
using System.Net;

namespace Morskoy_boy.Tools
{
    class GetWebRequest
    {
        internal static string _getRequest(string url)
        {
            var request = WebRequest.Create(url);
            string reqtext;
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    reqtext = sr.ReadToEnd();
                }
            }
            return reqtext;
        }
    }
}

using System;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace Morskoy_boy
{
    class JsonParser
    {
        public static JArray ArrayParse(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
                string reqtext=string.Empty;
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var sr = new StreamReader(response.GetResponseStream()))
                    {
                        reqtext = sr.ReadToEnd();
                    }
                }
                JArray array = JArray.Parse(reqtext);
                return array;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static string OneResult(string url)
        {
            try
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
                JObject joResponse = JObject.Parse(reqtext);
                return joResponse.GetValue("result").ToString();
            }
            catch (Exception)
            {
                return "null";
            }
        }
    }
}

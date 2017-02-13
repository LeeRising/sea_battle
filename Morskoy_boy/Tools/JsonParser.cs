using System;
using Newtonsoft.Json.Linq;

namespace Morskoy_boy
{
    class JsonParser
    {
        public static string ArrayParse(string request)
        {
            try
            {
                string response = null;
                JObject joResponse = JObject.Parse(request);
                JArray array = (JArray)joResponse["result"];
                foreach (var s1 in array)
                {
                    response += s1;
                }
                return response;
            }
            catch (Exception ex)
            {
                return "null";
            }
        }
        public static string OneResult(string request)
        {
            try
            {
                JObject joResponse = JObject.Parse(request);
                return joResponse.GetValue("result").ToString();
            }
            catch (Exception ex)
            {
                return "null";
            }
        }
    }
}

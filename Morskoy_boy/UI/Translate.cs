using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Morskoy_boy.UI
{
    class Translate
    {
        static Dictionary<string, string> elements;
        static JArray jarr;
        static JObject mainobj;
        public static void translate(Form f, string lang)
        {
            using (StreamReader sr = new StreamReader("lang/" + lang + ".json"))
            {
                mainobj = JObject.Parse(sr.ReadToEnd());
                elements = new Dictionary<string, string>();
                jarr = (JArray)mainobj[f.Name];
                foreach (var ja in jarr.Children<JObject>())
                {
                    foreach (JProperty singleProp in ja.Properties())
                    {
                        if (!singleProp.Name.Contains("ToolStripMenuItem"))
                            elements.Add(singleProp.Name, (string)singleProp.Value);
                    }
                }
                foreach (var v in elements)
                {
                    if (v.Key != "name" && !v.Key.Contains("/"))
                        f.Controls[v.Key].Text = v.Value;
                    if (v.Key == "name")
                        f.Text = v.Value;
                }
            }
        }
    }
}
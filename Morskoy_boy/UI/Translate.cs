using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Morskoy_boy.UI
{
    class Translate
    {
        static Dictionary<string, string> elements,menuelements;
        static JArray jarr;
        static JObject mainobj;
        public static void translate(Form f, string lang)
        {
            using (StreamReader sr = new StreamReader("lang/" + lang + ".json"))
            {
                mainobj = JObject.Parse(sr.ReadToEnd());
                switch (f.Name)
                {
                    case "MainF":
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
                        break;
                    case "LoginF":
                        break;
                }
                foreach (var v in elements)
                {
                    if (v.Key != "name")
                        f.Controls[v.Key].Text = v.Value;
                    else
                        f.Text = v.Value;
                }
            }
        }
        //Test
        public static void translate(Form f, string lang,MenuStrip ms)
        {
            using (StreamReader sr = new StreamReader("lang/" + lang + ".json"))
            {
                mainobj = JObject.Parse(sr.ReadToEnd());
                switch (f.Name)
                {
                    case "MainF":
                        elements = new Dictionary<string, string>();
                        menuelements = new Dictionary<string, string>();
                        jarr = (JArray)mainobj[f.Name];
                        foreach (var ja in jarr.Children<JObject>())
                        {
                            foreach (JProperty singleProp in ja.Properties())
                            {
                                if (!singleProp.Name.Contains("ToolStripMenuItem"))
                                    elements.Add(singleProp.Name, (string)singleProp.Value);
                                else
                                    menuelements.Add(singleProp.Name, (string)singleProp.Value);
                            }
                        }
                        break;
                    case "LoginF":
                        break;
                }
                foreach (var v in elements)
                {
                    if (v.Key != "name")
                        f.Controls[v.Key].Text = v.Value;
                    else
                        f.Text = v.Value;
                }
            }
        }
    }
}
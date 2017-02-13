using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Morskoy_boy.UI
{
    class Translate
    {
        public static void translate(string lang,string formname)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Path.Combine(Application.StartupPath + "/lang/") + lang + ".xml");
            switch (formname)
            {
                case "MainF":
                    break;
                case "LoginF":
                    break;
            }
        }
    }
}

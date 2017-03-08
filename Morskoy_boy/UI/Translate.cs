using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Morskoy_boy.UI
{
    class Translate
    {
        public static void translate(Form f,string lang)
        {
            XmlDocument doc = new XmlDocument();
            //XmlNodeList nodeList;
            doc.Load(Application.StartupPath + "/lang/" + lang + ".xml");
            switch (f.Name)
            {
                case "MainF":
                    //nodeList = doc.DocumentElement.SelectSingleNode("mainf");
                    //f.Text = nodeList[0].InnerText;
                    //MessageBox.Show(nodeList.Count.ToString());
                    break;
                case "LoginF":
                    break;
            }
        }
    }
}

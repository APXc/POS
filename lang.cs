using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Configuration;

namespace Pos_PointOfSales
{
    public enum LANG
    {
        IT, 
        EN,
    }
    class lang
    {

        private const string filename = @"D:/Project/Pos_PointOfSales/lang.xml";
        private FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
        private XmlDataDocument xmldoc = new XmlDataDocument();
        private XmlNodeList xmlnode;

        public void init(getSettings settings)
        {
            string str = null;
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName(settings.lang);
            for (int i = 0; i <= xmlnode.Count - 1; i++)
            {
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                MessageBox.Show(str);
            }

        }

    }
}

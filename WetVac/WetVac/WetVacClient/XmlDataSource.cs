using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace WetVacClient
{
    public static class XmlDataSource
    {
        public static DataSet DataSet { get; set; }

        public static void XmlToDataSet(string XmlPath)
        {
            string path = XmlPath;
            DataSet blowerData = new DataSet();

            blowerData.ReadXml(path);
            DataSet = blowerData;
        }
    }
}

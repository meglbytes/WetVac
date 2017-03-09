using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogFile;
using System.Threading;
using System.IO;
using System.Data;
using System.Xml;
using WetVacClient;

namespace Globals
{
  
  
    public static class Global
    {
        public static Blower[] _Blower = new Blower[4];

        public static void InstantiateBlowerObj()
        {
            for (int i = 1; i < 4; i++)
                _Blower[i] = new Blower();
        }
    }
}

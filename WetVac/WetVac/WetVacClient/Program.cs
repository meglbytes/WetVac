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

namespace WetVacClient
{
    static class Program
    {
        [STAThread]
        static public void Main()
        {
            try
            {
                                  
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //InitializeSplash();
                XmlDataSource.XmlToDataSet(WetVacClient.Properties.Resources.XmlPath.ToString());
                Application.Run(new frmMain());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());  //Debug only, take out for release
                
                LogFile.LogFile.WriteLog(ex.Message.ToString()
                                            , ex.StackTrace.ToString()
                                            , ex.Source.ToString()
                                            , ex.TargetSite.ToString()
                                        );
            }
        }

        #region SplashScreen

        public static void InitializeSplash()
        {
            Thread t = new Thread(new ThreadStart(StartSplash));
            t.Start();
            Thread.Sleep(2500);
            t.Abort();

        }
        public static void StartSplash()
        {
            Application.Run(new frmSplashScreen());
        }

        #endregion

    }
}


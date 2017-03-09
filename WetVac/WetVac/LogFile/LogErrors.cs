using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogFile
{
    public class LogFile
    {
        public static void WriteLog(string Message, string StackTrace, string Source, string TargetSite)
        {
            string message = Message;
            string stackTrace = StackTrace;
            string source = Source;
            string targetSite = TargetSite;

            string path = CreateLogDirectory();
            string fileName = "\\ErrorLog.txt";
            StringBuilder stringBuilder = new StringBuilder(path);
            stringBuilder.Append(fileName);
            string filePath = stringBuilder.ToString();
            
            try
            {
                if (!File.Exists(filePath))
                {
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine(DateTime.Now + ": WetVac Error Log");
                        WriteLogText(message, stackTrace, source, targetSite, sw);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        WriteLogText(message, stackTrace, source, targetSite, sw);
                    }
                }
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine("Log class throwing exception: {0}", ex.ToString());
            }
        }

        private static void WriteLogText(string message, string stackTrace, string source, string targetSite, StreamWriter sw)
        {
            sw.WriteLine(DateTime.Now + ": " + message);
            sw.WriteLine(DateTime.Now + ": " + stackTrace);
            sw.WriteLine(DateTime.Now + ": " + source);
            sw.WriteLine(DateTime.Now + ": " + targetSite);
        }
        
        private static string CreateLogDirectory()
        {            
            string directoryPath = (Environment.CurrentDirectory + "\\LogFiles");
            
            try
            {
                if (Directory.Exists(directoryPath))
                {
                    return directoryPath;
                }
                else
                {
                    Directory.CreateDirectory(directoryPath);
                    return directoryPath;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Logfile directory cannot be created {0}", ex.ToString());
                return directoryPath;
            }            
        }       
    }
}

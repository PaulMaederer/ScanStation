using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ScanSolution
{
    class C_LogDatei
    {
        string s_logDateiName = "ScanSolutionLog_";
        string s_logMessage = "";
        
        public string S_LogDateiName
        {
            get
            {
                return s_logDateiName;
            }
            set
            {
                s_logDateiName = value;
            }
        }
        public string S_LogMessage
        {
            get
            {
                return s_logMessage;
            }
            set
            {
                s_logMessage = value;
            }
        }

        public void WriteLog(string s_logMessage)
        {
            if (File.Exists(s_logDateiName))
            {
                FileStream fs = new FileStream(s_logDateiName, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(s_logMessage);
                sw.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show(new Form() { TopMost = true }, "Fehler beim Zugriff auf die LogDatei.");
            }
        }

        public void StartLog()
        {
            s_logMessage = (DateTime.Now + ": Starte Programm...");
            WriteLog(s_logMessage);
        }

        public void MoveLog(string s_quellDateiName, string s_zielDateiName)
        {
            s_logMessage = (DateTime.Now + ": Datei " + s_quellDateiName + " verschoben nach " + s_zielDateiName + ".");
            WriteLog(s_logMessage);
        }
        public void DeleteLog(string s_quellDateiName, string s_zielDateiName)
        {
            s_logMessage = (DateTime.Now + ": Datei " + s_quellDateiName + " wurde gelöscht, da die gleichnamige Datei " + s_zielDateiName + " bereits vorhanden war.");
            WriteLog(s_logMessage);
        }
        public void ShutdownLog()
        {
            s_logMessage = (DateTime.Now + ": Beende Programm...");
            WriteLog(s_logMessage);
        }

        public C_LogDatei()
        {
            s_logDateiName = "ScanSolutionLog_" + DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day + ".txt";
            FileStream fs = new FileStream(s_logDateiName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fs.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ScanSolution
{
    class C_ConfigFile
    {
        string s_configFile = "Config.txt";

        public string S_ConfigFile
        {
            get
            {
                return s_configFile;
            }
            /*set
            {
                s_configFile = value;
            }*/
        }

        public void CreateConfigFile()
        {
            if (!File.Exists(s_configFile) || new FileInfo(s_configFile).Length == 0)
            {
                FileStream fs = new FileStream(s_configFile, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                string s_path = ReadQuellOrdner();
                if (s_path != "")
                {
                    sw.WriteLine(s_path);
                    s_path = ReadZielOrdner();
                    if (s_path != "")
                    {
                        sw.WriteLine(s_path);
                    }
                    else
                    {
                        sw.Close();
                        fs.Close();
                        File.Delete(s_configFile);
                        Environment.Exit(0);        //Beendet NICHT die Anwendung in diesem Fall.
                    }
                }
                else
                {
                    sw.Close();
                    fs.Close();
                    File.Delete(s_configFile);
                    Environment.Exit(0);         //Beendet NICHT die Anwendung in diesem Fall.
                }
                sw.Close();
                fs.Close();
            }
        }

        protected string ReadQuellOrdner()
        {
            MessageBox.Show(new Form() { TopMost = true }, "Die Konfigurationsdatei wurde nicht gefunden.\nDiese wird im nächsten Schritt angelegt.\nBitte wählen Sie im folgenden Menü den Quellordner.");
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            else
            {
                return "";
            }
        }

        protected string ReadZielOrdner()
        {
            MessageBox.Show(new Form() { TopMost = true }, "Bitte wählenlen Sie im folgenden Menü den Zielordner.");
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            else
            {
                return "";
            }
        }

        public string GetQuellOrdnerPfad()
        {
            //CreateConfigFile();
            string s_quellPfad;
            FileStream fs = new FileStream(s_configFile, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            s_quellPfad = sr.ReadLine();
            sr.Close();
            fs.Close();
            return s_quellPfad;
        }
        public string GetZielOrdnerPfad()
        {
            string s_zielPfad;
            FileStream fs = new FileStream(s_configFile, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
            s_zielPfad = sr.ReadLine();
            sr.Close();
            fs.Close();
            return s_zielPfad;
        }

        public C_ConfigFile()
        {
        }
    }
}

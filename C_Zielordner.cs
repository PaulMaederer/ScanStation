using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ScanSolution
{
    class C_Zielordner
    {
        string s_zielPfad = "";
        string[] mandantenUnterOrdner;

        public string S_ZielPfad
        {
            get
            {
                return s_zielPfad;
            }
            /*set
            {
                s_zielPfad = value;
            }*/
        }

        public string[] MandantenUnterOrdner
        {
            get
            {
                return mandantenUnterOrdner;
            }
            /*set
            {
                mandantenUnterOrdner = value;
            }*/
        }

        public string[] GetAllDirectories(string s_mandantenNr)
        {
            mandantenUnterOrdner = Directory.GetDirectories(s_zielPfad + @"\" + s_mandantenNr);
            return MandantenUnterOrdner;  
        }

        public string[] GetAllDirectoryNames(string s_mandantenNr)
        {
            string[] allDirectoryPaths = GetAllDirectories(s_mandantenNr);
            string[] allDirectoryNames = new string[allDirectoryPaths.Length];
            for (int i = 0; i < allDirectoryPaths.Length; i++)
            {
                allDirectoryNames[i] = Path.GetFileName(allDirectoryPaths[i]);
            }
            return allDirectoryNames;
        }

        public C_Zielordner()
        {
            C_ConfigFile cf = new C_ConfigFile();
            s_zielPfad = cf.GetZielOrdnerPfad();
        }
    }
}

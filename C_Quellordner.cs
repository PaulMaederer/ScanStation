using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ScanSolution
{
    class C_Quellordner
    {
        string s_quellPfad = "";
        string[] pdfFiles;
        string[] tifFiles;
        //string[] dateiEndungen = new string[2] { "pdf", "tif" };


        public string S_QuellPfad
        {
            get
            {
                return s_quellPfad;
            }
        }

        public string[] PdfFiles
        {
            get
            {
                return pdfFiles;
            }
            /*set
            {
                pdfFiles = value;
            }*/
        }
        public string[] TifFiles
        {
            get
            {
                return tifFiles;
            }
            /*set
            {
                tifFiles = value;
            }*/
        }

        public string[] GetAllFilePaths()
        {
            pdfFiles = Directory.GetFiles(s_quellPfad, "*.pdf", SearchOption.TopDirectoryOnly);
            
            tifFiles = Directory.GetFiles(s_quellPfad, "*.tif", SearchOption.TopDirectoryOnly);

            string[] allFiles = new string[pdfFiles.Length + tifFiles.Length];
            Array.Copy(pdfFiles, allFiles, pdfFiles.Length);
            Array.Copy(tifFiles, 0, allFiles, pdfFiles.Length, tifFiles.Length);
            return allFiles;
        }
        public string[] GetAllFileNames()
        {
            string[] allFilePaths = GetAllFilePaths();
            string[] allFileNames = new string[allFilePaths.Length];
            for (int i= 0; i < allFilePaths.Length; i++)
            {
                allFileNames[i] = Path.GetFileName(allFilePaths[i]);
            }
            return allFileNames;
        }
        
        public C_Quellordner()
        {
            C_ConfigFile configFile = new C_ConfigFile();
            s_quellPfad = configFile.GetQuellOrdnerPfad();
        }

    }
}

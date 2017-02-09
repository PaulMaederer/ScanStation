using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ScanSolution
{
    public partial class ScanStation : Form
    {
        C_Quellordner QuellOrdner;
        C_Zielordner ZielOrdner;
        C_ConfigFile ConfigFile = new C_ConfigFile();
        C_LogDatei Log = new C_LogDatei();
        bool b_moveIsSelected = false;
        string s_mandantenNr = "0";
        //FileSystemWatcher quellWatcher;
        //FileSystemWatcher zielWatcher;


        public ScanStation()
        {
            ConfigFile.CreateConfigFile();
            QuellOrdner = new C_Quellordner();
            ZielOrdner = new C_Zielordner();
            /*quellWatcher = new FileSystemWatcher(QuellOrdner.S_QuellPfad);
            zielWatcher = new FileSystemWatcher(ZielOrdner.S_ZielPfad);

            quellWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess | NotifyFilters.Size | NotifyFilters.DirectoryName | NotifyFilters.FileName;
            zielWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess | NotifyFilters.Size | NotifyFilters.DirectoryName | NotifyFilters.FileName ;
            quellWatcher.Filter = "*.*";
            quellWatcher.Changed += new FileSystemEventHandler(OnChangedQuellOrdner);
            quellWatcher.Created += new FileSystemEventHandler(OnChangedQuellOrdner);
            quellWatcher.Deleted += new FileSystemEventHandler(OnChangedQuellOrdner);
            quellWatcher.Renamed += new RenamedEventHandler(OnRenamedQuellOrdner);
            quellWatcher.EnableRaisingEvents = true;
            zielWatcher.Changed += new FileSystemEventHandler(OnChangedZielOrdner);
            zielWatcher.Created += new FileSystemEventHandler(OnChangedZielOrdner);
            zielWatcher.Deleted += new FileSystemEventHandler(OnChangedZielOrdner);
            zielWatcher.Renamed += new RenamedEventHandler(OnRenamedZielOrdner);
            zielWatcher.EnableRaisingEvents = true; */

            Timer timer = new Timer();
            timer.Interval = (3 * 1000); // 3 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            /*Timer timer2 = new Timer();
            timer2.Interval = (12 * 1000); // 12 secs
            timer2.Tick += new EventHandler(timer_Tick2);
            timer2.Start(); */


            this.FormClosing += new FormClosingEventHandler(ScanStation_Closing);

            InitializeComponent();
            Log.StartLog();

        }

        private void btn_mandantenNrSuchen_Click(object sender, EventArgs e)
        {
            grpbox_ziffernFeld.Visible = false;
            grpbox_ziffernFeld.Enabled = false;

            if (txtbox_mandantenNr.Text != "" || txtbox_mandantenNr.Text.Trim() != "")
            RefreshMandantenOrdner();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RefreshDokumente();
        }
        /*private void timer_Tick2(object sender, EventArgs e)
        {
            RefreshMandantenOrdner();
        } */

        private void btn_moveToSelectedOrdnerStart_Click(object sender, EventArgs e)
        {

            btn_moveToSelectedOrdnerStop.ForeColor = Color.Red;
            btn_moveToSelectedOrdnerStart.ForeColor = Color.Gray;
            btn_moveToSelectedOrdnerStop.Enabled = true;
            btn_moveToSelectedOrdnerStop.Focus();
            btn_moveToSelectedOrdnerStart.Enabled = false;
            b_moveIsSelected = true;

            while (b_moveIsSelected == true)
            {
                MoveOrDeleteDocument();
    
                DateTime dt_desired = DateTime.Now.AddSeconds(2);
                while (DateTime.Now < dt_desired)
                {
                    Application.DoEvents();
                }
                //RefreshMandantenOrdner();
            }
        }
        private void ScanStation_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Log.ShutdownLog();
        }

        private void btn_moveToSelectedOrdnerStop_Click(object sender, EventArgs e)
        {
            b_moveIsSelected = false;
            btn_moveToSelectedOrdnerStart.ForeColor = Color.Lime;
            btn_moveToSelectedOrdnerStop.ForeColor = Color.Gray;
            btn_moveToSelectedOrdnerStart.Enabled = true;
            btn_moveToSelectedOrdnerStart.Focus();
            btn_moveToSelectedOrdnerStop.Enabled = false;
        }

        /*private void OnApplicationExit(object sender, EventArgs e)
        {
            Log.ShutdownLog();
        }*/

        private void RefreshDokumente()
        {
            ConfigFile.CreateConfigFile();
            if (Directory.Exists(QuellOrdner.S_QuellPfad))
            {
                string[] AllDateien = QuellOrdner.GetAllFileNames();
                rtxtbox_dateien.Clear();
                foreach (string s in AllDateien)
                {
                    rtxtbox_dateien.Text = rtxtbox_dateien.Text + s + "\n";
                }
            }
            else
            {
                MessageBox.Show(this, "Quellordner wurde nicht gefunden. Anwendung wird geschlossen.");
                Environment.Exit(0);
            }
        }

        private void RefreshMandantenOrdner()
        {
            try
            {
                ConfigFile.CreateConfigFile();
                cmbbox_mandantenUnterOrdner.Items.Clear();
                s_mandantenNr = txtbox_mandantenNr.Text;
                string[] AllMandantenUnterordner = ZielOrdner.GetAllDirectoryNames(txtbox_mandantenNr.Text);
                foreach (string s in AllMandantenUnterordner)
                {
                    cmbbox_mandantenUnterOrdner.Items.Add(s);
                }
            }
            catch
            {
                MessageBox.Show(this, "Unterordner wurde nicht gefunden.");
            }
        }

        void MoveOrDeleteDocument()
        {

            try
            {
                if (cmbbox_mandantenUnterOrdner.SelectedItem != null)
                {
                    int i = 0;
                    ConfigFile.CreateConfigFile();
                    string s_zielPfad = ZielOrdner.S_ZielPfad + "\\" + s_mandantenNr;
                    string[] DateiNamen = QuellOrdner.GetAllFileNames();
                    string s_aktuelleDatei;
                    //MessageBox.Show(cmbbox_mandantenUnterOrdner.SelectedItem + "\\" + DateiNamen[0]);
                    foreach (string s in QuellOrdner.GetAllFilePaths())
                    {
                        s_aktuelleDatei = s_zielPfad + "\\" + cmbbox_mandantenUnterOrdner.SelectedItem + "\\" + DateiNamen[i];

                        if (File.Exists(s_aktuelleDatei) && new FileInfo(s_aktuelleDatei).Length == new FileInfo(s).Length)
                        {
                            //MessageBox.Show(this, "Eine Datei mit gleichem Namen und Länge existiert bereits im Zielordner.\nDatei wird gelöscht anstatt verschoben.");
                            File.Delete(s);
                            Log.DeleteLog(s, s_aktuelleDatei);
                        }
                        else
                        {
                            File.Move(s, s_aktuelleDatei);
                            Log.MoveLog(s, s_aktuelleDatei);
                            i++;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show(this, "Ein Fehler ist aufgetreten.");
            }
        }

        private void lbl_tipDateien_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_mandantenNr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_mandantenNr_MouseClick(object sender, MouseEventArgs e)
        {
            grpbox_ziffernFeld.Visible = true;
            grpbox_ziffernFeld.Enabled = true;
        }

        private void txtbox_mandantenNr_Leave(object sender, EventArgs e)
        {
            //grpbox_ziffernFeld.Visible = false;
            //grpbox_ziffernFeld.Enabled = false;
        }

        private void txtbox_mandantenNr_Enter(object sender, EventArgs e) //this one
        {
            grpbox_ziffernFeld.Visible = true;
            grpbox_ziffernFeld.Enabled = true;
        }

        private void txtbox_mandantenNr_Click(object sender, EventArgs e)
        {
            grpbox_ziffernFeld.Visible = true;
            grpbox_ziffernFeld.Enabled = true;
        }
        private void btn_ziffer1_Click(object sender, EventArgs e)
        {
            //txtbox_mandantenNr.Text = txtbox_mandantenNr.Text + "1";
            SendKeys.Send("1");
            txtbox_mandantenNr.Focus();
        }

        private void btn_ziffer2_Click(object sender, EventArgs e)
        {
            //txtbox_mandantenNr.Text = txtbox_mandantenNr.Text + "2";
            SendKeys.Send("2");
            txtbox_mandantenNr.Focus();
        }

        private void btn_ziffer3_Click(object sender, EventArgs e)
        {
            //txtbox_mandantenNr.Text = txtbox_mandantenNr.Text + "3";
            SendKeys.Send("3");
            txtbox_mandantenNr.Focus();
        }

        private void btn_ziffer4_Click(object sender, EventArgs e)
        {
            //txtbox_mandantenNr.Text = txtbox_mandantenNr.Text + "4";
            SendKeys.Send("4");
            txtbox_mandantenNr.Focus();
        }

        private void btn_ziffer5_Click(object sender, EventArgs e)
        {
            //txtbox_mandantenNr.Text = txtbox_mandantenNr.Text + "5";
            SendKeys.Send("5");
            txtbox_mandantenNr.Focus();
        }

        private void btn_ziffer6_Click(object sender, EventArgs e)
        {
            //txtbox_mandantenNr.Text = txtbox_mandantenNr.Text + "6";
            SendKeys.Send("6");
            txtbox_mandantenNr.Focus();
        }

        private void btn_ziffer7_Click(object sender, EventArgs e)
        {
            //txtbox_mandantenNr.Text = txtbox_mandantenNr.Text + "7";
            SendKeys.Send("7");
            txtbox_mandantenNr.Focus();
        }

        private void btn_ziffer8_Click(object sender, EventArgs e)
        {
            //txtbox_mandantenNr.Text = txtbox_mandantenNr.Text + "8";
            SendKeys.Send("8");
            txtbox_mandantenNr.Focus();
        }

        private void btn_ziffer9_Click(object sender, EventArgs e)
        {
            //txtbox_mandantenNr.Text = txtbox_mandantenNr.Text + "9";
            SendKeys.Send("9");
            txtbox_mandantenNr.Focus();
        }

        private void btn_ziffer0_Click(object sender, EventArgs e)
        {
            //txtbox_mandantenNr.Text = txtbox_mandantenNr.Text + "0";
            SendKeys.Send("0");
            txtbox_mandantenNr.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //int length = txtbox_mandantenNr.Text.Length > 0 ? txtbox_mandantenNr.Text.Length - 1 : 0;
            //txtbox_mandantenNr.Text = txtbox_mandantenNr.Text.Substring(0, length);
            SendKeys.Send("{BACKSPACE}");
            txtbox_mandantenNr.Focus();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            btn_mandantenNrSuchen.Focus();
            grpbox_ziffernFeld.Visible = false;
            grpbox_ziffernFeld.Enabled = false;
            //SendKeys.Send("{ENTER}");
        }

        private void txtbox_mandantenNr_DoubleClick(object sender, EventArgs e)
        {

        }

        private void ScanStation_Load(object sender, EventArgs e)
        {

        }

        private void ScanStation_Click(object sender, EventArgs e)
        {
            grpbox_ziffernFeld.Visible = false;
            grpbox_ziffernFeld.Enabled = false;
        }

        private void txtbox_mandantenNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                grpbox_ziffernFeld.Visible = false;
                grpbox_ziffernFeld.Enabled = false;
                RefreshMandantenOrdner();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                grpbox_ziffernFeld.Visible = false;
                grpbox_ziffernFeld.Enabled = false;
                btn_mandantenNrSuchen.Focus();
            }
            //if (e.KeyChar == '.' || )
        }

        private void picbox_pageOneLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.page-one.de");
        }

        private void picbox_pageOneLogo_MouseMove(object sender, MouseEventArgs e)
        {
            //
        }
        /*private void OnChangedQuellOrdner(object source, FileSystemEventArgs e)
        {

        } 
        private void OnChangedZielOrdner(object source, FileSystemEventArgs e)
        {

        }
        private void OnRenamedQuellOrdner(object source, RenamedEventArgs e)
        {

        }
        private  void OnRenamedZielOrdner(object source, RenamedEventArgs e)
        {

        }*/

    }
}

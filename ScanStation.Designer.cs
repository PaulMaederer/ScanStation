namespace ScanSolution
{
    partial class ScanStation
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanStation));
            this.lbl_tipMandatenNr = new System.Windows.Forms.Label();
            this.txtbox_mandantenNr = new System.Windows.Forms.TextBox();
            this.lbl_tipDateien = new System.Windows.Forms.Label();
            this.rtxtbox_dateien = new System.Windows.Forms.RichTextBox();
            this.lbl_tipMandantenUnterordner = new System.Windows.Forms.Label();
            this.cmbbox_mandantenUnterOrdner = new System.Windows.Forms.ComboBox();
            this.btn_mandantenNrSuchen = new System.Windows.Forms.Button();
            this.btn_moveToSelectedOrdnerStart = new System.Windows.Forms.Button();
            this.btn_moveToSelectedOrdnerStop = new System.Windows.Forms.Button();
            this.btn_ziffer1 = new System.Windows.Forms.Button();
            this.btn_ziffer2 = new System.Windows.Forms.Button();
            this.btn_ziffer3 = new System.Windows.Forms.Button();
            this.btn_ziffer4 = new System.Windows.Forms.Button();
            this.btn_ziffer5 = new System.Windows.Forms.Button();
            this.btn_ziffer6 = new System.Windows.Forms.Button();
            this.btn_ziffer7 = new System.Windows.Forms.Button();
            this.btn_ziffer8 = new System.Windows.Forms.Button();
            this.btn_ziffer9 = new System.Windows.Forms.Button();
            this.btn_ziffer0 = new System.Windows.Forms.Button();
            this.grpbox_ziffernFeld = new System.Windows.Forms.GroupBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pnl_topLine = new System.Windows.Forms.Panel();
            this.lbl_pageOneLogo = new System.Windows.Forms.Label();
            this.pnl_downLine = new System.Windows.Forms.Panel();
            this.lbl_copyRightA = new System.Windows.Forms.Label();
            this.lbl_copyRightB = new System.Windows.Forms.Label();
            this.picbox_pageOneLogo = new System.Windows.Forms.PictureBox();
            this.grpbox_ziffernFeld.SuspendLayout();
            this.pnl_topLine.SuspendLayout();
            this.pnl_downLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_pageOneLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tipMandatenNr
            // 
            this.lbl_tipMandatenNr.AutoSize = true;
            this.lbl_tipMandatenNr.BackColor = System.Drawing.Color.DimGray;
            this.lbl_tipMandatenNr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipMandatenNr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tipMandatenNr.Location = new System.Drawing.Point(516, 101);
            this.lbl_tipMandatenNr.Name = "lbl_tipMandatenNr";
            this.lbl_tipMandatenNr.Size = new System.Drawing.Size(421, 18);
            this.lbl_tipMandatenNr.TabIndex = 0;
            this.lbl_tipMandatenNr.Text = "Mandantennr.:                                                                    " +
    "           ";
            // 
            // txtbox_mandantenNr
            // 
            this.txtbox_mandantenNr.BackColor = System.Drawing.SystemColors.Control;
            this.txtbox_mandantenNr.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_mandantenNr.Location = new System.Drawing.Point(518, 122);
            this.txtbox_mandantenNr.Name = "txtbox_mandantenNr";
            this.txtbox_mandantenNr.Size = new System.Drawing.Size(237, 39);
            this.txtbox_mandantenNr.TabIndex = 1;
            this.txtbox_mandantenNr.Click += new System.EventHandler(this.txtbox_mandantenNr_Click);
            this.txtbox_mandantenNr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbox_mandantenNr_MouseClick);
            this.txtbox_mandantenNr.TextChanged += new System.EventHandler(this.txtbox_mandantenNr_TextChanged);
            this.txtbox_mandantenNr.DoubleClick += new System.EventHandler(this.txtbox_mandantenNr_DoubleClick);
            this.txtbox_mandantenNr.Enter += new System.EventHandler(this.txtbox_mandantenNr_Enter);
            this.txtbox_mandantenNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_mandantenNr_KeyPress);
            this.txtbox_mandantenNr.Leave += new System.EventHandler(this.txtbox_mandantenNr_Leave);
            // 
            // lbl_tipDateien
            // 
            this.lbl_tipDateien.AutoSize = true;
            this.lbl_tipDateien.BackColor = System.Drawing.Color.DimGray;
            this.lbl_tipDateien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipDateien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tipDateien.Location = new System.Drawing.Point(51, 101);
            this.lbl_tipDateien.Name = "lbl_tipDateien";
            this.lbl_tipDateien.Size = new System.Drawing.Size(307, 18);
            this.lbl_tipDateien.TabIndex = 2;
            this.lbl_tipDateien.Text = "Scandaten:                                                       ";
            this.lbl_tipDateien.Click += new System.EventHandler(this.lbl_tipDateien_Click);
            // 
            // rtxtbox_dateien
            // 
            this.rtxtbox_dateien.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtbox_dateien.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtbox_dateien.Location = new System.Drawing.Point(49, 122);
            this.rtxtbox_dateien.Name = "rtxtbox_dateien";
            this.rtxtbox_dateien.ReadOnly = true;
            this.rtxtbox_dateien.Size = new System.Drawing.Size(308, 497);
            this.rtxtbox_dateien.TabIndex = 3;
            this.rtxtbox_dateien.Text = "";
            // 
            // lbl_tipMandantenUnterordner
            // 
            this.lbl_tipMandantenUnterordner.AutoSize = true;
            this.lbl_tipMandantenUnterordner.BackColor = System.Drawing.Color.DimGray;
            this.lbl_tipMandantenUnterordner.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipMandantenUnterordner.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tipMandantenUnterordner.Location = new System.Drawing.Point(522, 228);
            this.lbl_tipMandantenUnterordner.Name = "lbl_tipMandantenUnterordner";
            this.lbl_tipMandantenUnterordner.Size = new System.Drawing.Size(415, 18);
            this.lbl_tipMandantenUnterordner.TabIndex = 4;
            this.lbl_tipMandantenUnterordner.Text = "Mandanten Unterordner:                                                           " +
    " ";
            // 
            // cmbbox_mandantenUnterOrdner
            // 
            this.cmbbox_mandantenUnterOrdner.BackColor = System.Drawing.SystemColors.Control;
            this.cmbbox_mandantenUnterOrdner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbbox_mandantenUnterOrdner.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbox_mandantenUnterOrdner.FormattingEnabled = true;
            this.cmbbox_mandantenUnterOrdner.Location = new System.Drawing.Point(519, 250);
            this.cmbbox_mandantenUnterOrdner.Name = "cmbbox_mandantenUnterOrdner";
            this.cmbbox_mandantenUnterOrdner.Size = new System.Drawing.Size(420, 385);
            this.cmbbox_mandantenUnterOrdner.TabIndex = 5;
            // 
            // btn_mandantenNrSuchen
            // 
            this.btn_mandantenNrSuchen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mandantenNrSuchen.Location = new System.Drawing.Point(777, 120);
            this.btn_mandantenNrSuchen.Name = "btn_mandantenNrSuchen";
            this.btn_mandantenNrSuchen.Size = new System.Drawing.Size(162, 41);
            this.btn_mandantenNrSuchen.TabIndex = 6;
            this.btn_mandantenNrSuchen.Text = "Suchen";
            this.btn_mandantenNrSuchen.UseVisualStyleBackColor = true;
            this.btn_mandantenNrSuchen.Click += new System.EventHandler(this.btn_mandantenNrSuchen_Click);
            // 
            // btn_moveToSelectedOrdnerStart
            // 
            this.btn_moveToSelectedOrdnerStart.BackColor = System.Drawing.Color.Gray;
            this.btn_moveToSelectedOrdnerStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moveToSelectedOrdnerStart.ForeColor = System.Drawing.Color.Lime;
            this.btn_moveToSelectedOrdnerStart.Location = new System.Drawing.Point(383, 318);
            this.btn_moveToSelectedOrdnerStart.Name = "btn_moveToSelectedOrdnerStart";
            this.btn_moveToSelectedOrdnerStart.Size = new System.Drawing.Size(117, 41);
            this.btn_moveToSelectedOrdnerStart.TabIndex = 7;
            this.btn_moveToSelectedOrdnerStart.Text = "Start";
            this.btn_moveToSelectedOrdnerStart.UseVisualStyleBackColor = false;
            this.btn_moveToSelectedOrdnerStart.Click += new System.EventHandler(this.btn_moveToSelectedOrdnerStart_Click);
            // 
            // btn_moveToSelectedOrdnerStop
            // 
            this.btn_moveToSelectedOrdnerStop.BackColor = System.Drawing.Color.Gray;
            this.btn_moveToSelectedOrdnerStop.Enabled = false;
            this.btn_moveToSelectedOrdnerStop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moveToSelectedOrdnerStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_moveToSelectedOrdnerStop.Location = new System.Drawing.Point(383, 482);
            this.btn_moveToSelectedOrdnerStop.Name = "btn_moveToSelectedOrdnerStop";
            this.btn_moveToSelectedOrdnerStop.Size = new System.Drawing.Size(117, 41);
            this.btn_moveToSelectedOrdnerStop.TabIndex = 8;
            this.btn_moveToSelectedOrdnerStop.Text = "Stop";
            this.btn_moveToSelectedOrdnerStop.UseVisualStyleBackColor = false;
            this.btn_moveToSelectedOrdnerStop.Click += new System.EventHandler(this.btn_moveToSelectedOrdnerStop_Click);
            // 
            // btn_ziffer1
            // 
            this.btn_ziffer1.BackColor = System.Drawing.Color.DimGray;
            this.btn_ziffer1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ziffer1.Location = new System.Drawing.Point(6, 13);
            this.btn_ziffer1.Name = "btn_ziffer1";
            this.btn_ziffer1.Size = new System.Drawing.Size(55, 55);
            this.btn_ziffer1.TabIndex = 12;
            this.btn_ziffer1.Text = "1";
            this.btn_ziffer1.UseVisualStyleBackColor = false;
            this.btn_ziffer1.Click += new System.EventHandler(this.btn_ziffer1_Click);
            // 
            // btn_ziffer2
            // 
            this.btn_ziffer2.BackColor = System.Drawing.Color.DimGray;
            this.btn_ziffer2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ziffer2.Location = new System.Drawing.Point(67, 13);
            this.btn_ziffer2.Name = "btn_ziffer2";
            this.btn_ziffer2.Size = new System.Drawing.Size(55, 55);
            this.btn_ziffer2.TabIndex = 13;
            this.btn_ziffer2.Text = "2";
            this.btn_ziffer2.UseVisualStyleBackColor = false;
            this.btn_ziffer2.Click += new System.EventHandler(this.btn_ziffer2_Click);
            // 
            // btn_ziffer3
            // 
            this.btn_ziffer3.BackColor = System.Drawing.Color.DimGray;
            this.btn_ziffer3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ziffer3.Location = new System.Drawing.Point(128, 13);
            this.btn_ziffer3.Name = "btn_ziffer3";
            this.btn_ziffer3.Size = new System.Drawing.Size(55, 55);
            this.btn_ziffer3.TabIndex = 14;
            this.btn_ziffer3.Text = "3";
            this.btn_ziffer3.UseVisualStyleBackColor = false;
            this.btn_ziffer3.Click += new System.EventHandler(this.btn_ziffer3_Click);
            // 
            // btn_ziffer4
            // 
            this.btn_ziffer4.BackColor = System.Drawing.Color.DimGray;
            this.btn_ziffer4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ziffer4.Location = new System.Drawing.Point(6, 71);
            this.btn_ziffer4.Name = "btn_ziffer4";
            this.btn_ziffer4.Size = new System.Drawing.Size(55, 55);
            this.btn_ziffer4.TabIndex = 15;
            this.btn_ziffer4.Text = "4";
            this.btn_ziffer4.UseVisualStyleBackColor = false;
            this.btn_ziffer4.Click += new System.EventHandler(this.btn_ziffer4_Click);
            // 
            // btn_ziffer5
            // 
            this.btn_ziffer5.BackColor = System.Drawing.Color.DimGray;
            this.btn_ziffer5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ziffer5.Location = new System.Drawing.Point(67, 71);
            this.btn_ziffer5.Name = "btn_ziffer5";
            this.btn_ziffer5.Size = new System.Drawing.Size(55, 55);
            this.btn_ziffer5.TabIndex = 16;
            this.btn_ziffer5.Text = "5";
            this.btn_ziffer5.UseVisualStyleBackColor = false;
            this.btn_ziffer5.Click += new System.EventHandler(this.btn_ziffer5_Click);
            // 
            // btn_ziffer6
            // 
            this.btn_ziffer6.BackColor = System.Drawing.Color.DimGray;
            this.btn_ziffer6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ziffer6.Location = new System.Drawing.Point(128, 71);
            this.btn_ziffer6.Name = "btn_ziffer6";
            this.btn_ziffer6.Size = new System.Drawing.Size(55, 55);
            this.btn_ziffer6.TabIndex = 17;
            this.btn_ziffer6.Text = "6";
            this.btn_ziffer6.UseVisualStyleBackColor = false;
            this.btn_ziffer6.Click += new System.EventHandler(this.btn_ziffer6_Click);
            // 
            // btn_ziffer7
            // 
            this.btn_ziffer7.BackColor = System.Drawing.Color.DimGray;
            this.btn_ziffer7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ziffer7.Location = new System.Drawing.Point(6, 132);
            this.btn_ziffer7.Name = "btn_ziffer7";
            this.btn_ziffer7.Size = new System.Drawing.Size(55, 55);
            this.btn_ziffer7.TabIndex = 18;
            this.btn_ziffer7.Text = "7";
            this.btn_ziffer7.UseVisualStyleBackColor = false;
            this.btn_ziffer7.Click += new System.EventHandler(this.btn_ziffer7_Click);
            // 
            // btn_ziffer8
            // 
            this.btn_ziffer8.BackColor = System.Drawing.Color.DimGray;
            this.btn_ziffer8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ziffer8.Location = new System.Drawing.Point(67, 132);
            this.btn_ziffer8.Name = "btn_ziffer8";
            this.btn_ziffer8.Size = new System.Drawing.Size(55, 55);
            this.btn_ziffer8.TabIndex = 19;
            this.btn_ziffer8.Text = "8";
            this.btn_ziffer8.UseVisualStyleBackColor = false;
            this.btn_ziffer8.Click += new System.EventHandler(this.btn_ziffer8_Click);
            // 
            // btn_ziffer9
            // 
            this.btn_ziffer9.BackColor = System.Drawing.Color.DimGray;
            this.btn_ziffer9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ziffer9.Location = new System.Drawing.Point(128, 132);
            this.btn_ziffer9.Name = "btn_ziffer9";
            this.btn_ziffer9.Size = new System.Drawing.Size(55, 55);
            this.btn_ziffer9.TabIndex = 20;
            this.btn_ziffer9.Text = "9";
            this.btn_ziffer9.UseVisualStyleBackColor = false;
            this.btn_ziffer9.Click += new System.EventHandler(this.btn_ziffer9_Click);
            // 
            // btn_ziffer0
            // 
            this.btn_ziffer0.BackColor = System.Drawing.Color.DimGray;
            this.btn_ziffer0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ziffer0.Location = new System.Drawing.Point(67, 189);
            this.btn_ziffer0.Name = "btn_ziffer0";
            this.btn_ziffer0.Size = new System.Drawing.Size(55, 55);
            this.btn_ziffer0.TabIndex = 22;
            this.btn_ziffer0.Text = "0";
            this.btn_ziffer0.UseVisualStyleBackColor = false;
            this.btn_ziffer0.Click += new System.EventHandler(this.btn_ziffer0_Click);
            // 
            // grpbox_ziffernFeld
            // 
            this.grpbox_ziffernFeld.BackColor = System.Drawing.Color.LightGray;
            this.grpbox_ziffernFeld.Controls.Add(this.btn_enter);
            this.grpbox_ziffernFeld.Controls.Add(this.btn_ziffer2);
            this.grpbox_ziffernFeld.Controls.Add(this.btn_ziffer1);
            this.grpbox_ziffernFeld.Controls.Add(this.btn_ziffer0);
            this.grpbox_ziffernFeld.Controls.Add(this.btn_ziffer3);
            this.grpbox_ziffernFeld.Controls.Add(this.btn_delete);
            this.grpbox_ziffernFeld.Controls.Add(this.btn_ziffer4);
            this.grpbox_ziffernFeld.Controls.Add(this.btn_ziffer9);
            this.grpbox_ziffernFeld.Controls.Add(this.btn_ziffer5);
            this.grpbox_ziffernFeld.Controls.Add(this.btn_ziffer8);
            this.grpbox_ziffernFeld.Controls.Add(this.btn_ziffer6);
            this.grpbox_ziffernFeld.Controls.Add(this.btn_ziffer7);
            this.grpbox_ziffernFeld.Enabled = false;
            this.grpbox_ziffernFeld.Location = new System.Drawing.Point(568, 167);
            this.grpbox_ziffernFeld.Name = "grpbox_ziffernFeld";
            this.grpbox_ziffernFeld.Size = new System.Drawing.Size(187, 251);
            this.grpbox_ziffernFeld.TabIndex = 24;
            this.grpbox_ziffernFeld.TabStop = false;
            this.grpbox_ziffernFeld.Visible = false;
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.LightGray;
            this.btn_enter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_enter.Image = global::ScanSolution.Properties.Resources.check_sign_in_a_rounded_black_square3;
            this.btn_enter.Location = new System.Drawing.Point(126, 189);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(55, 55);
            this.btn_enter.TabIndex = 23;
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightGray;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Image = global::ScanSolution.Properties.Resources.arrow_pointing_to_left_black_square1;
            this.btn_delete.Location = new System.Drawing.Point(6, 189);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(55, 55);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pnl_topLine
            // 
            this.pnl_topLine.BackColor = System.Drawing.Color.White;
            this.pnl_topLine.Controls.Add(this.lbl_pageOneLogo);
            this.pnl_topLine.Location = new System.Drawing.Point(-10, -1);
            this.pnl_topLine.Name = "pnl_topLine";
            this.pnl_topLine.Size = new System.Drawing.Size(1005, 93);
            this.pnl_topLine.TabIndex = 25;
            // 
            // lbl_pageOneLogo
            // 
            this.lbl_pageOneLogo.AutoSize = true;
            this.lbl_pageOneLogo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pageOneLogo.Location = new System.Drawing.Point(59, 28);
            this.lbl_pageOneLogo.Name = "lbl_pageOneLogo";
            this.lbl_pageOneLogo.Size = new System.Drawing.Size(152, 29);
            this.lbl_pageOneLogo.TabIndex = 0;
            this.lbl_pageOneLogo.Text = "ScanStation";
            // 
            // pnl_downLine
            // 
            this.pnl_downLine.BackColor = System.Drawing.Color.White;
            this.pnl_downLine.Controls.Add(this.lbl_copyRightA);
            this.pnl_downLine.Controls.Add(this.lbl_copyRightB);
            this.pnl_downLine.Location = new System.Drawing.Point(-10, 654);
            this.pnl_downLine.Name = "pnl_downLine";
            this.pnl_downLine.Size = new System.Drawing.Size(1090, 38);
            this.pnl_downLine.TabIndex = 26;
            // 
            // lbl_copyRightA
            // 
            this.lbl_copyRightA.AutoSize = true;
            this.lbl_copyRightA.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copyRightA.Location = new System.Drawing.Point(22, 9);
            this.lbl_copyRightA.Name = "lbl_copyRightA";
            this.lbl_copyRightA.Size = new System.Drawing.Size(77, 12);
            this.lbl_copyRightA.TabIndex = 1;
            this.lbl_copyRightA.Text = "ScanStation ©";
            // 
            // lbl_copyRightB
            // 
            this.lbl_copyRightB.AutoSize = true;
            this.lbl_copyRightB.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copyRightB.Location = new System.Drawing.Point(104, 9);
            this.lbl_copyRightB.Name = "lbl_copyRightB";
            this.lbl_copyRightB.Size = new System.Drawing.Size(534, 12);
            this.lbl_copyRightB.TabIndex = 0;
            this.lbl_copyRightB.Text = "Copyright by page one GmbH | Schwabacher Str. 3 | 90439 Nürnberg | Tel.: 0911 926" +
    "4-400 | www.page-one.de | info@page-one.de";
            // 
            // picbox_pageOneLogo
            // 
            this.picbox_pageOneLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_pageOneLogo.Image = global::ScanSolution.Properties.Resources.verkleinert;
            this.picbox_pageOneLogo.Location = new System.Drawing.Point(992, -1);
            this.picbox_pageOneLogo.Name = "picbox_pageOneLogo";
            this.picbox_pageOneLogo.Size = new System.Drawing.Size(88, 93);
            this.picbox_pageOneLogo.TabIndex = 9;
            this.picbox_pageOneLogo.TabStop = false;
            this.picbox_pageOneLogo.Click += new System.EventHandler(this.picbox_pageOneLogo_Click);
            this.picbox_pageOneLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbox_pageOneLogo_MouseMove);
            // 
            // ScanStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1080, 684);
            this.Controls.Add(this.pnl_downLine);
            this.Controls.Add(this.pnl_topLine);
            this.Controls.Add(this.grpbox_ziffernFeld);
            this.Controls.Add(this.picbox_pageOneLogo);
            this.Controls.Add(this.btn_moveToSelectedOrdnerStop);
            this.Controls.Add(this.btn_moveToSelectedOrdnerStart);
            this.Controls.Add(this.btn_mandantenNrSuchen);
            this.Controls.Add(this.cmbbox_mandantenUnterOrdner);
            this.Controls.Add(this.lbl_tipMandantenUnterordner);
            this.Controls.Add(this.rtxtbox_dateien);
            this.Controls.Add(this.lbl_tipDateien);
            this.Controls.Add(this.txtbox_mandantenNr);
            this.Controls.Add(this.lbl_tipMandatenNr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ScanStation";
            this.Text = "ScanStation";
            this.Load += new System.EventHandler(this.ScanStation_Load);
            this.Click += new System.EventHandler(this.ScanStation_Click);
            this.grpbox_ziffernFeld.ResumeLayout(false);
            this.pnl_topLine.ResumeLayout(false);
            this.pnl_topLine.PerformLayout();
            this.pnl_downLine.ResumeLayout(false);
            this.pnl_downLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_pageOneLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tipMandatenNr;
        private System.Windows.Forms.TextBox txtbox_mandantenNr;
        private System.Windows.Forms.Label lbl_tipDateien;
        private System.Windows.Forms.RichTextBox rtxtbox_dateien;
        private System.Windows.Forms.Label lbl_tipMandantenUnterordner;
        private System.Windows.Forms.ComboBox cmbbox_mandantenUnterOrdner;
        private System.Windows.Forms.Button btn_mandantenNrSuchen;
        private System.Windows.Forms.Button btn_moveToSelectedOrdnerStart;
        private System.Windows.Forms.Button btn_moveToSelectedOrdnerStop;
        private System.Windows.Forms.PictureBox picbox_pageOneLogo;
        private System.Windows.Forms.Button btn_ziffer1;
        private System.Windows.Forms.Button btn_ziffer2;
        private System.Windows.Forms.Button btn_ziffer3;
        private System.Windows.Forms.Button btn_ziffer4;
        private System.Windows.Forms.Button btn_ziffer5;
        private System.Windows.Forms.Button btn_ziffer6;
        private System.Windows.Forms.Button btn_ziffer7;
        private System.Windows.Forms.Button btn_ziffer8;
        private System.Windows.Forms.Button btn_ziffer9;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_ziffer0;
        private System.Windows.Forms.GroupBox grpbox_ziffernFeld;
        private System.Windows.Forms.Panel pnl_topLine;
        private System.Windows.Forms.Panel pnl_downLine;
        private System.Windows.Forms.Label lbl_copyRightB;
        private System.Windows.Forms.Label lbl_pageOneLogo;
        private System.Windows.Forms.Label lbl_copyRightA;
        private System.Windows.Forms.Button btn_enter;
    }
}


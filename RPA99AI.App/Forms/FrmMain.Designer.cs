namespace RPA99AI.App.Forms
{
	public partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileSaveText = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileSaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuFileOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelpAide = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelpRpa = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TabMain = new System.Windows.Forms.TabControl();
            this.TabSpectre = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtSpectreResults = new System.Windows.Forms.TextBox();
            this.TabStatique = new System.Windows.Forms.TabPage();
            this.TblStatiqueValeur = new System.Windows.Forms.TableLayoutPanel();
            this.PnlStatique = new System.Windows.Forms.Panel();
            this.GrpPeriodeFondalentale = new System.Windows.Forms.GroupBox();
            this.TxtDelta = new System.Windows.Forms.TextBox();
            this.LblDelta = new System.Windows.Forms.Label();
            this.LblFormuleEmpirique = new System.Windows.Forms.Label();
            this.CmbFormuleEmpirique = new System.Windows.Forms.ComboBox();
            this.LblSysContreventementStat = new System.Windows.Forms.Label();
            this.CmbSysContreventementStat = new System.Windows.Forms.ComboBox();
            this.LblFormuleFond = new System.Windows.Forms.Label();
            this.CmbFormuleFond = new System.Windows.Forms.ComboBox();
            this.GrbDimensions = new System.Windows.Forms.GroupBox();
            this.TxtLy = new System.Windows.Forms.TextBox();
            this.LblLy = new System.Windows.Forms.Label();
            this.TxtLx = new System.Windows.Forms.TextBox();
            this.LblLx = new System.Windows.Forms.Label();
            this.TxtHn = new System.Windows.Forms.TextBox();
            this.LblHn = new System.Windows.Forms.Label();
            this.GrbPoids = new System.Windows.Forms.GroupBox();
            this.TxtBetaValeur = new System.Windows.Forms.TextBox();
            this.TxtWq = new System.Windows.Forms.TextBox();
            this.LblWq = new System.Windows.Forms.Label();
            this.LblTypeOuvrageBetaValeur = new System.Windows.Forms.Label();
            this.CmbTypeOuvrage = new System.Windows.Forms.ComboBox();
            this.TxtWg = new System.Windows.Forms.TextBox();
            this.LblWg = new System.Windows.Forms.Label();
            this.TxtStatiqueResults = new System.Windows.Forms.TextBox();
            this.StsValues = new System.Windows.Forms.StatusStrip();
            this.StsA = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsQ = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsT1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsT2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsR = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsXi = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsEta = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsBeta = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsCt = new System.Windows.Forms.ToolStripStatusLabel();
            this.GrbZone = new System.Windows.Forms.GroupBox();
            this.CmbWilaya = new System.Windows.Forms.ComboBox();
            this.CmbZone = new System.Windows.Forms.ComboBox();
            this.GrbImportance = new System.Windows.Forms.GroupBox();
            this.TxtAValeur = new System.Windows.Forms.TextBox();
            this.LblAValeur = new System.Windows.Forms.Label();
            this.CmbImportance = new System.Windows.Forms.ComboBox();
            this.GrbSite = new System.Windows.Forms.GroupBox();
            this.LblT2Valeur = new System.Windows.Forms.Label();
            this.LblT1Valeur = new System.Windows.Forms.Label();
            this.TxtT1Valeur = new System.Windows.Forms.TextBox();
            this.TxtT2Valeur = new System.Windows.Forms.TextBox();
            this.CmbSite = new System.Windows.Forms.ComboBox();
            this.GrbMateriau = new System.Windows.Forms.GroupBox();
            this.TxtXiValeur = new System.Windows.Forms.TextBox();
            this.LblXiValeur = new System.Windows.Forms.Label();
            this.CmbMateriau = new System.Windows.Forms.ComboBox();
            this.GrbQualite = new System.Windows.Forms.GroupBox();
            this.LblQValeur = new System.Windows.Forms.Label();
            this.BtnChangerQualite = new System.Windows.Forms.Button();
            this.TxtQValeur = new System.Windows.Forms.TextBox();
            this.GrbSysContreventement = new System.Windows.Forms.GroupBox();
            this.LblRValeur = new System.Windows.Forms.Label();
            this.TxtRValeur = new System.Windows.Forms.TextBox();
            this.CmbSysContreventement = new System.Windows.Forms.ComboBox();
            this.BtnCalculer = new System.Windows.Forms.Button();
            this.DlgSaveFileTxt = new System.Windows.Forms.SaveFileDialog();
            this.DlgSaveFileJpg = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MnuMain.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.TabSpectre.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TabStatique.SuspendLayout();
            this.TblStatiqueValeur.SuspendLayout();
            this.PnlStatique.SuspendLayout();
            this.GrpPeriodeFondalentale.SuspendLayout();
            this.GrbDimensions.SuspendLayout();
            this.GrbPoids.SuspendLayout();
            this.StsValues.SuspendLayout();
            this.GrbZone.SuspendLayout();
            this.GrbImportance.SuspendLayout();
            this.GrbSite.SuspendLayout();
            this.GrbMateriau.SuspendLayout();
            this.GrbQualite.SuspendLayout();
            this.GrbSysContreventement.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMain
            // 
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile,
            this.MnuHelp});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MnuMain.Size = new System.Drawing.Size(582, 24);
            this.MnuMain.TabIndex = 0;
            this.MnuMain.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFileSaveText,
            this.MnuFileSaveImage,
            this.MnuFileSeparator1,
            this.MnuFileOptions,
            this.MnuFileSeparator2,
            this.MnuFileExit});
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(54, 20);
            this.MnuFile.Text = "&Fichier";
            // 
            // MnuFileSaveText
            // 
            this.MnuFileSaveText.Name = "MnuFileSaveText";
            this.MnuFileSaveText.Size = new System.Drawing.Size(196, 22);
            this.MnuFileSaveText.Text = "Sauvegarder les &valeurs";
            this.MnuFileSaveText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MnuFileSaveText.Click += new System.EventHandler(this.MnuFileSaveText_Click);
            // 
            // MnuFileSaveImage
            // 
            this.MnuFileSaveImage.Name = "MnuFileSaveImage";
            this.MnuFileSaveImage.Size = new System.Drawing.Size(196, 22);
            this.MnuFileSaveImage.Text = "Enregistrer le &spectre";
            this.MnuFileSaveImage.Click += new System.EventHandler(this.MnuFileSaveImage_Click);
            // 
            // MnuFileSeparator1
            // 
            this.MnuFileSeparator1.Name = "MnuFileSeparator1";
            this.MnuFileSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // MnuFileOptions
            // 
            this.MnuFileOptions.Name = "MnuFileOptions";
            this.MnuFileOptions.Size = new System.Drawing.Size(196, 22);
            this.MnuFileOptions.Text = "O&ptions";
            this.MnuFileOptions.Click += new System.EventHandler(this.MnuFileOptions_Click);
            // 
            // MnuFileSeparator2
            // 
            this.MnuFileSeparator2.Name = "MnuFileSeparator2";
            this.MnuFileSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // MnuFileExit
            // 
            this.MnuFileExit.Name = "MnuFileExit";
            this.MnuFileExit.Size = new System.Drawing.Size(196, 22);
            this.MnuFileExit.Text = "&Quitter";
            this.MnuFileExit.Click += new System.EventHandler(this.MnuFileExit_Click);
            // 
            // MnuHelp
            // 
            this.MnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuHelpAide,
            this.MnuHelpRpa,
            this.MnuSeparator1,
            this.MnuHelpAbout});
            this.MnuHelp.Name = "MnuHelp";
            this.MnuHelp.Size = new System.Drawing.Size(43, 20);
            this.MnuHelp.Text = "Ai&de";
            // 
            // MnuHelpAide
            // 
            this.MnuHelpAide.Name = "MnuHelpAide";
            this.MnuHelpAide.Size = new System.Drawing.Size(200, 22);
            this.MnuHelpAide.Text = "Voir aide";
            this.MnuHelpAide.Click += new System.EventHandler(this.MnuHelpAide_Click);
            // 
            // MnuHelpRpa
            // 
            this.MnuHelpRpa.Name = "MnuHelpRpa";
            this.MnuHelpRpa.Size = new System.Drawing.Size(200, 22);
            this.MnuHelpRpa.Text = "Lire RPA 99 version 2003";
            this.MnuHelpRpa.Click += new System.EventHandler(this.MnuHelpRpa_Click);
            // 
            // MnuSeparator1
            // 
            this.MnuSeparator1.Name = "MnuSeparator1";
            this.MnuSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // MnuHelpAbout
            // 
            this.MnuHelpAbout.Name = "MnuHelpAbout";
            this.MnuHelpAbout.Size = new System.Drawing.Size(200, 22);
            this.MnuHelpAbout.Text = "A &propos";
            this.MnuHelpAbout.Click += new System.EventHandler(this.MnuHelpAbout_Click);
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.TabSpectre);
            this.TabMain.Controls.Add(this.TabStatique);
            this.TabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabMain.Location = new System.Drawing.Point(0, 24);
            this.TabMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(582, 384);
            this.TabMain.TabIndex = 1;
            // 
            // TabSpectre
            // 
            this.TabSpectre.Controls.Add(this.tableLayoutPanel1);
            this.TabSpectre.Location = new System.Drawing.Point(4, 24);
            this.TabSpectre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSpectre.Name = "TabSpectre";
            this.TabSpectre.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabSpectre.Size = new System.Drawing.Size(574, 356);
            this.TabSpectre.TabIndex = 0;
            this.TabSpectre.Text = "Méthode d’Analyse Modale Spectrale";
            this.TabSpectre.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.TxtSpectreResults, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtSpectreResults
            // 
            this.TxtSpectreResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSpectreResults.Location = new System.Drawing.Point(428, 3);
            this.TxtSpectreResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSpectreResults.Multiline = true;
            this.TxtSpectreResults.Name = "TxtSpectreResults";
            this.TxtSpectreResults.ReadOnly = true;
            this.TxtSpectreResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSpectreResults.Size = new System.Drawing.Size(134, 346);
            this.TxtSpectreResults.TabIndex = 1;
            // 
            // TabStatique
            // 
            this.TabStatique.Controls.Add(this.TblStatiqueValeur);
            this.TabStatique.Location = new System.Drawing.Point(4, 24);
            this.TabStatique.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabStatique.Name = "TabStatique";
            this.TabStatique.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabStatique.Size = new System.Drawing.Size(574, 356);
            this.TabStatique.TabIndex = 1;
            this.TabStatique.Text = "Méthode Statique Equivalente";
            this.TabStatique.UseVisualStyleBackColor = true;
            // 
            // TblStatiqueValeur
            // 
            this.TblStatiqueValeur.ColumnCount = 2;
            this.TblStatiqueValeur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.TblStatiqueValeur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblStatiqueValeur.Controls.Add(this.PnlStatique, 0, 0);
            this.TblStatiqueValeur.Controls.Add(this.TxtStatiqueResults, 1, 0);
            this.TblStatiqueValeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblStatiqueValeur.Location = new System.Drawing.Point(4, 3);
            this.TblStatiqueValeur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TblStatiqueValeur.Name = "TblStatiqueValeur";
            this.TblStatiqueValeur.RowCount = 1;
            this.TblStatiqueValeur.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblStatiqueValeur.Size = new System.Drawing.Size(566, 350);
            this.TblStatiqueValeur.TabIndex = 0;
            // 
            // PnlStatique
            // 
            this.PnlStatique.Controls.Add(this.GrpPeriodeFondalentale);
            this.PnlStatique.Controls.Add(this.GrbDimensions);
            this.PnlStatique.Controls.Add(this.GrbPoids);
            this.PnlStatique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlStatique.Location = new System.Drawing.Point(4, 3);
            this.PnlStatique.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlStatique.Name = "PnlStatique";
            this.PnlStatique.Size = new System.Drawing.Size(416, 344);
            this.PnlStatique.TabIndex = 0;
            // 
            // GrpPeriodeFondalentale
            // 
            this.GrpPeriodeFondalentale.Controls.Add(this.TxtDelta);
            this.GrpPeriodeFondalentale.Controls.Add(this.LblDelta);
            this.GrpPeriodeFondalentale.Controls.Add(this.LblFormuleEmpirique);
            this.GrpPeriodeFondalentale.Controls.Add(this.CmbFormuleEmpirique);
            this.GrpPeriodeFondalentale.Controls.Add(this.LblSysContreventementStat);
            this.GrpPeriodeFondalentale.Controls.Add(this.CmbSysContreventementStat);
            this.GrpPeriodeFondalentale.Controls.Add(this.LblFormuleFond);
            this.GrpPeriodeFondalentale.Controls.Add(this.CmbFormuleFond);
            this.GrpPeriodeFondalentale.Location = new System.Drawing.Point(4, 163);
            this.GrpPeriodeFondalentale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpPeriodeFondalentale.Name = "GrpPeriodeFondalentale";
            this.GrpPeriodeFondalentale.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpPeriodeFondalentale.Size = new System.Drawing.Size(408, 174);
            this.GrpPeriodeFondalentale.TabIndex = 2;
            this.GrpPeriodeFondalentale.TabStop = false;
            this.GrpPeriodeFondalentale.Text = "Période fondamentale de la structure :";
            // 
            // TxtDelta
            // 
            this.TxtDelta.Location = new System.Drawing.Point(188, 143);
            this.TxtDelta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtDelta.Name = "TxtDelta";
            this.TxtDelta.Size = new System.Drawing.Size(98, 23);
            this.TxtDelta.TabIndex = 15;
            this.TxtDelta.Text = "1.0";
            this.TxtDelta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSegma_KeyPress);
            // 
            // LblDelta
            // 
            this.LblDelta.AutoSize = true;
            this.LblDelta.Location = new System.Drawing.Point(24, 144);
            this.LblDelta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDelta.Name = "LblDelta";
            this.LblDelta.Size = new System.Drawing.Size(145, 15);
            this.LblDelta.TabIndex = 11;
            this.LblDelta.Text = "(Flèches horizontales) δ = ";
            // 
            // LblFormuleEmpirique
            // 
            this.LblFormuleEmpirique.AutoSize = true;
            this.LblFormuleEmpirique.Location = new System.Drawing.Point(10, 105);
            this.LblFormuleEmpirique.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFormuleEmpirique.Name = "LblFormuleEmpirique";
            this.LblFormuleEmpirique.Size = new System.Drawing.Size(165, 15);
            this.LblFormuleEmpirique.TabIndex = 9;
            this.LblFormuleEmpirique.Text = "Choix de formule empirique : ";
            // 
            // CmbFormuleEmpirique
            // 
            this.CmbFormuleEmpirique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFormuleEmpirique.Items.AddRange(new object[] {
            "Formule 4.6",
            "Formule 4.7",
            "Min (Formule 4.6, Formule 4.7)"});
            this.CmbFormuleEmpirique.Location = new System.Drawing.Point(188, 103);
            this.CmbFormuleEmpirique.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbFormuleEmpirique.Name = "CmbFormuleEmpirique";
            this.CmbFormuleEmpirique.Size = new System.Drawing.Size(212, 23);
            this.CmbFormuleEmpirique.TabIndex = 14;
            this.CmbFormuleEmpirique.SelectionChangeCommitted += new System.EventHandler(this.CmbFormuleEmpirique_SelectionChangeCommitted);
            // 
            // LblSysContreventementStat
            // 
            this.LblSysContreventementStat.AutoSize = true;
            this.LblSysContreventementStat.Location = new System.Drawing.Point(26, 66);
            this.LblSysContreventementStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSysContreventementStat.Name = "LblSysContreventementStat";
            this.LblSysContreventementStat.Size = new System.Drawing.Size(144, 15);
            this.LblSysContreventementStat.TabIndex = 7;
            this.LblSysContreventementStat.Text = "Valeurs du coefficient Ct : ";
            // 
            // CmbSysContreventementStat
            // 
            this.CmbSysContreventementStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSysContreventementStat.DropDownWidth = 600;
            this.CmbSysContreventementStat.Items.AddRange(new object[] {
            "Cas 1: Portiques autostables en béton armé sans remplissage en maçonnerie",
            "Cas 2: Portiques autostables en acier sans remplissage en maçonnerie",
            "Cas 3: Portiques autostables en béton armé ou en acier avec remplissage en maçonn" +
                "erie",
            "Cas 4: Contreventement assuré partiellement ou totalement par des voiles en béton" +
                " armé, des palées triangulées et des murs en maçonnerie"});
            this.CmbSysContreventementStat.Location = new System.Drawing.Point(188, 62);
            this.CmbSysContreventementStat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbSysContreventementStat.Name = "CmbSysContreventementStat";
            this.CmbSysContreventementStat.Size = new System.Drawing.Size(212, 23);
            this.CmbSysContreventementStat.TabIndex = 13;
            this.CmbSysContreventementStat.SelectionChangeCommitted += new System.EventHandler(this.CmbSysContreventementStat_SelectionChangeCommitted);
            // 
            // LblFormuleFond
            // 
            this.LblFormuleFond.AutoSize = true;
            this.LblFormuleFond.Location = new System.Drawing.Point(7, 27);
            this.LblFormuleFond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFormuleFond.Name = "LblFormuleFond";
            this.LblFormuleFond.Size = new System.Drawing.Size(163, 15);
            this.LblFormuleFond.TabIndex = 5;
            this.LblFormuleFond.Text = "Estimation de la période par : ";
            // 
            // CmbFormuleFond
            // 
            this.CmbFormuleFond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFormuleFond.Items.AddRange(new object[] {
            "Formule Empirique",
            "Formule Reylagh"});
            this.CmbFormuleFond.Location = new System.Drawing.Point(188, 22);
            this.CmbFormuleFond.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbFormuleFond.Name = "CmbFormuleFond";
            this.CmbFormuleFond.Size = new System.Drawing.Size(212, 23);
            this.CmbFormuleFond.TabIndex = 12;
            this.CmbFormuleFond.SelectionChangeCommitted += new System.EventHandler(this.CmbFormuleFond_SelectionChangeCommitted);
            // 
            // GrbDimensions
            // 
            this.GrbDimensions.Controls.Add(this.TxtLy);
            this.GrbDimensions.Controls.Add(this.LblLy);
            this.GrbDimensions.Controls.Add(this.TxtLx);
            this.GrbDimensions.Controls.Add(this.LblLx);
            this.GrbDimensions.Controls.Add(this.TxtHn);
            this.GrbDimensions.Controls.Add(this.LblHn);
            this.GrbDimensions.Location = new System.Drawing.Point(4, 99);
            this.GrbDimensions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbDimensions.Name = "GrbDimensions";
            this.GrbDimensions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbDimensions.Size = new System.Drawing.Size(408, 57);
            this.GrbDimensions.TabIndex = 1;
            this.GrbDimensions.TabStop = false;
            this.GrbDimensions.Text = "Dimensions d’ouvrage :";
            // 
            // TxtLy
            // 
            this.TxtLy.Location = new System.Drawing.Point(324, 22);
            this.TxtLy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtLy.Name = "TxtLy";
            this.TxtLy.ShortcutsEnabled = false;
            this.TxtLy.Size = new System.Drawing.Size(74, 23);
            this.TxtLy.TabIndex = 11;
            this.TxtLy.Text = "1.0";
            this.toolTip1.SetToolTip(this.TxtLy, "Largeur et longueur de bâtiment dans la direction y (m).");
            this.TxtLy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLy_KeyPress);
            // 
            // LblLy
            // 
            this.LblLy.AutoSize = true;
            this.LblLy.Location = new System.Drawing.Point(278, 27);
            this.LblLy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLy.Name = "LblLy";
            this.LblLy.Size = new System.Drawing.Size(32, 15);
            this.LblLy.TabIndex = 6;
            this.LblLy.Text = "Ly = ";
            // 
            // TxtLx
            // 
            this.TxtLx.Location = new System.Drawing.Point(194, 22);
            this.TxtLx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtLx.Name = "TxtLx";
            this.TxtLx.ShortcutsEnabled = false;
            this.TxtLx.Size = new System.Drawing.Size(74, 23);
            this.TxtLx.TabIndex = 10;
            this.TxtLx.Text = "1.0";
            this.toolTip1.SetToolTip(this.TxtLx, "Largeur et longueur de bâtiment dans la direction x (m)");
            this.TxtLx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLx_KeyPress);
            // 
            // LblLx
            // 
            this.LblLx.AutoSize = true;
            this.LblLx.Location = new System.Drawing.Point(147, 25);
            this.LblLx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLx.Name = "LblLx";
            this.LblLx.Size = new System.Drawing.Size(33, 15);
            this.LblLx.TabIndex = 4;
            this.LblLx.Text = "Lx = ";
            // 
            // TxtHn
            // 
            this.TxtHn.Location = new System.Drawing.Point(63, 22);
            this.TxtHn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtHn.Name = "TxtHn";
            this.TxtHn.ShortcutsEnabled = false;
            this.TxtHn.Size = new System.Drawing.Size(74, 23);
            this.TxtHn.TabIndex = 9;
            this.TxtHn.Text = "1.0";
            this.TxtHn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHn_KeyPress);
            // 
            // LblHn
            // 
            this.LblHn.AutoSize = true;
            this.LblHn.Location = new System.Drawing.Point(14, 27);
            this.LblHn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHn.Name = "LblHn";
            this.LblHn.Size = new System.Drawing.Size(37, 15);
            this.LblHn.TabIndex = 2;
            this.LblHn.Text = "Hn = ";
            // 
            // GrbPoids
            // 
            this.GrbPoids.Controls.Add(this.TxtBetaValeur);
            this.GrbPoids.Controls.Add(this.TxtWq);
            this.GrbPoids.Controls.Add(this.LblWq);
            this.GrbPoids.Controls.Add(this.LblTypeOuvrageBetaValeur);
            this.GrbPoids.Controls.Add(this.CmbTypeOuvrage);
            this.GrbPoids.Controls.Add(this.TxtWg);
            this.GrbPoids.Controls.Add(this.LblWg);
            this.GrbPoids.Location = new System.Drawing.Point(4, 5);
            this.GrbPoids.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbPoids.Name = "GrbPoids";
            this.GrbPoids.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbPoids.Size = new System.Drawing.Size(410, 88);
            this.GrbPoids.TabIndex = 0;
            this.GrbPoids.TabStop = false;
            this.GrbPoids.Text = "Poids d\'ouvrage :";
            // 
            // TxtBetaValeur
            // 
            this.TxtBetaValeur.Location = new System.Drawing.Point(55, 53);
            this.TxtBetaValeur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtBetaValeur.Name = "TxtBetaValeur";
            this.TxtBetaValeur.Size = new System.Drawing.Size(116, 23);
            this.TxtBetaValeur.TabIndex = 9;
            this.TxtBetaValeur.Text = "1.0";
            this.TxtBetaValeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBetaValeur_KeyPress);
            // 
            // TxtWq
            // 
            this.TxtWq.Location = new System.Drawing.Point(237, 20);
            this.TxtWq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtWq.Name = "TxtWq";
            this.TxtWq.ShortcutsEnabled = false;
            this.TxtWq.Size = new System.Drawing.Size(119, 23);
            this.TxtWq.TabIndex = 7;
            this.TxtWq.Text = "1.0";
            this.TxtWq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtWq_KeyPress);
            // 
            // LblWq
            // 
            this.LblWq.AutoSize = true;
            this.LblWq.Location = new System.Drawing.Point(188, 23);
            this.LblWq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblWq.Name = "LblWq";
            this.LblWq.Size = new System.Drawing.Size(39, 15);
            this.LblWq.TabIndex = 4;
            this.LblWq.Text = "Wq = ";
            // 
            // LblTypeOuvrageBetaValeur
            // 
            this.LblTypeOuvrageBetaValeur.AutoSize = true;
            this.LblTypeOuvrageBetaValeur.Location = new System.Drawing.Point(7, 55);
            this.LblTypeOuvrageBetaValeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTypeOuvrageBetaValeur.Name = "LblTypeOuvrageBetaValeur";
            this.LblTypeOuvrageBetaValeur.Size = new System.Drawing.Size(93, 15);
            this.LblTypeOuvrageBetaValeur.TabIndex = 3;
            this.LblTypeOuvrageBetaValeur.Text = "Type d’ouvrage :";
            // 
            // CmbTypeOuvrage
            // 
            this.CmbTypeOuvrage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTypeOuvrage.DropDownWidth = 400;
            this.CmbTypeOuvrage.Items.AddRange(new object[] {
            "Bâtiments d’habitation, bureaux ou assimilés",
            "Salles d’exposition, de sport, lieux de culte, salles de réunions avec places deb" +
                "out.",
            "Salles de classes, restaurants, dortoirs, salles de réunions avec places assises",
            "Entrepôts, hangars",
            "Archives, bibliothèques, réservoirs et ouvrages assimilés",
            "Autres locaux non visés ci-dessus"});
            this.CmbTypeOuvrage.Location = new System.Drawing.Point(118, 52);
            this.CmbTypeOuvrage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbTypeOuvrage.Name = "CmbTypeOuvrage";
            this.CmbTypeOuvrage.Size = new System.Drawing.Size(284, 23);
            this.CmbTypeOuvrage.TabIndex = 8;
            this.CmbTypeOuvrage.SelectionChangeCommitted += new System.EventHandler(this.CmbTypeOuvrage_SelectionChangeCommitted);
            // 
            // TxtWg
            // 
            this.TxtWg.Location = new System.Drawing.Point(56, 20);
            this.TxtWg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtWg.Name = "TxtWg";
            this.TxtWg.ShortcutsEnabled = false;
            this.TxtWg.Size = new System.Drawing.Size(119, 23);
            this.TxtWg.TabIndex = 6;
            this.TxtWg.Text = "1.0";
            this.TxtWg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtWg_KeyPress);
            // 
            // LblWg
            // 
            this.LblWg.AutoSize = true;
            this.LblWg.Location = new System.Drawing.Point(8, 23);
            this.LblWg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblWg.Name = "LblWg";
            this.LblWg.Size = new System.Drawing.Size(39, 15);
            this.LblWg.TabIndex = 0;
            this.LblWg.Text = "Wg = ";
            // 
            // TxtStatiqueResults
            // 
            this.TxtStatiqueResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtStatiqueResults.Location = new System.Drawing.Point(428, 3);
            this.TxtStatiqueResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtStatiqueResults.Multiline = true;
            this.TxtStatiqueResults.Name = "TxtStatiqueResults";
            this.TxtStatiqueResults.ReadOnly = true;
            this.TxtStatiqueResults.Size = new System.Drawing.Size(134, 344);
            this.TxtStatiqueResults.TabIndex = 1;
            // 
            // StsValues
            // 
            this.StsValues.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StsA,
            this.StsQ,
            this.StsT1,
            this.StsT2,
            this.StsR,
            this.StsXi,
            this.StsEta,
            this.StsBeta,
            this.StsCt});
            this.StsValues.Location = new System.Drawing.Point(0, 654);
            this.StsValues.Name = "StsValues";
            this.StsValues.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StsValues.ShowItemToolTips = true;
            this.StsValues.Size = new System.Drawing.Size(582, 22);
            this.StsValues.TabIndex = 2;
            this.StsValues.Text = "statusStrip1";
            // 
            // StsA
            // 
            this.StsA.Name = "StsA";
            this.StsA.Size = new System.Drawing.Size(29, 17);
            this.StsA.Text = "A = ";
            this.StsA.ToolTipText = "A: Coefficient d’accélération de zone.\r\nRPA article: 4-1, 6-2, 6-3\r\nUnite: %";
            // 
            // StsQ
            // 
            this.StsQ.Name = "StsQ";
            this.StsQ.Size = new System.Drawing.Size(30, 17);
            this.StsQ.Text = "Q = ";
            this.StsQ.ToolTipText = "Q: Facteur de qualité.\r\nRPA article: 4-4";
            // 
            // StsT1
            // 
            this.StsT1.Name = "StsT1";
            this.StsT1.Size = new System.Drawing.Size(33, 17);
            this.StsT1.Text = "T1 = ";
            this.StsT1.ToolTipText = "T1: Période caractéristiques associées à la catégorie de site.\r\nRPA article: 4-13" +
    ".\r\nUnite: sec.";
            // 
            // StsT2
            // 
            this.StsT2.Name = "StsT2";
            this.StsT2.Size = new System.Drawing.Size(33, 17);
            this.StsT2.Text = "T2 = ";
            this.StsT2.ToolTipText = "T2: Période caractéristiques associées à la catégorie de site.\r\nRPA article: 4-13" +
    ".\r\nUnite: sec.";
            // 
            // StsR
            // 
            this.StsR.Name = "StsR";
            this.StsR.Size = new System.Drawing.Size(28, 17);
            this.StsR.Text = "R = ";
            this.StsR.ToolTipText = "R: Coefficient de comportement global de la structure.\r\n";
            // 
            // StsXi
            // 
            this.StsXi.Name = "StsXi";
            this.StsXi.Size = new System.Drawing.Size(26, 17);
            this.StsXi.Text = "ξ = ";
            this.StsXi.ToolTipText = "ξ (Xi): Pourcentage d’amortissement critique global.\r\nRPA article: 4-3, 4-15";
            // 
            // StsEta
            // 
            this.StsEta.Name = "StsEta";
            this.StsEta.Size = new System.Drawing.Size(28, 17);
            this.StsEta.Text = "η = ";
            this.StsEta.ToolTipText = "η (Eta): Facteur de correction d’amortissement.\r\nRPA article: RPA: 4-3.";
            // 
            // StsBeta
            // 
            this.StsBeta.Name = "StsBeta";
            this.StsBeta.Size = new System.Drawing.Size(28, 17);
            this.StsBeta.Text = "β = ";
            this.StsBeta.ToolTipText = "β (Beta): coefficient de pondération, fonction de la nature et de la durée de la " +
    "charge d’exploitation et donné par le tableau 4.5.";
            // 
            // StsCt
            // 
            this.StsCt.Name = "StsCt";
            this.StsCt.Size = new System.Drawing.Size(33, 17);
            this.StsCt.Text = "Ct = ";
            this.StsCt.ToolTipText = "Ct: Coefficient de période.\r\nRPA tableau : 4-6";
            // 
            // GrbZone
            // 
            this.GrbZone.Controls.Add(this.CmbWilaya);
            this.GrbZone.Controls.Add(this.CmbZone);
            this.GrbZone.Location = new System.Drawing.Point(4, 417);
            this.GrbZone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbZone.Name = "GrbZone";
            this.GrbZone.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbZone.Size = new System.Drawing.Size(233, 63);
            this.GrbZone.TabIndex = 3;
            this.GrbZone.TabStop = false;
            this.GrbZone.Text = "Zone :";
            // 
            // CmbWilaya
            // 
            this.CmbWilaya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbWilaya.Items.AddRange(new object[] {
            "Chlef : Groupe de communes A",
            "Chlef : Groupe de communes B",
            "Chlef : Groupe de communes C",
            "Laghouat",
            "Oum El Bouaghi",
            "Batna",
            "Bejaia",
            "Biskra",
            "Blida: Groupe de communes A",
            "Blida: Groupe de communes B",
            "Bouira",
            "Tebessa",
            "Tlemcen",
            "Tiaret",
            "Tizi Ouzou: Groupe de communes A",
            "Tizi Ouzou: Groupe de communes B",
            "Alger",
            "Djelfa",
            "Jijel",
            "Setif",
            "Saida",
            "Skikda",
            "Sidi Bel Abbes",
            "Annaba",
            "Guelma",
            "Constantine",
            "Medea: Groupe de communes A",
            "Medea: Groupe de communes B",
            "Medea: Groupe de communes C",
            "Mostganem: Groupe de communes A",
            "Mostganem: Groupe de communes B",
            "Mostganem: Groupe de communes C",
            "Msila: Groupe de communes A",
            "Msila: Groupe de communes B",
            "Mascara: Groupe de communes A",
            "Mascare: Groupe de communes B",
            "Oran",
            "El Bayadh",
            "Bordj Bou Arreridj",
            "Boumerdes: Groupe de communes A",
            "Boumerdes: Groupe de communes B",
            "Boumerdes: Groupe de communes C",
            "El Taref",
            "Tissemsilt",
            "Khenchela",
            "Souk Ahras",
            "Tipaza",
            "Mila",
            "Ain Defla: Groupe de communes A",
            "Ain Defla: Groupe de communes B",
            "Ain Defla: Groupe de communes C",
            "Naama",
            "Ain Temouchent",
            "Relizane: Groupe de communes A",
            "Relizane: Groupe de communes B",
            "Relizane: Groupe de communes C"});
            this.CmbWilaya.Location = new System.Drawing.Point(8, 22);
            this.CmbWilaya.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbWilaya.Name = "CmbWilaya";
            this.CmbWilaya.Size = new System.Drawing.Size(218, 23);
            this.CmbWilaya.TabIndex = 1;
            this.CmbWilaya.SelectionChangeCommitted += new System.EventHandler(this.CmbWilaya_SelectionChangeCommitted_1);
            // 
            // CmbZone
            // 
            this.CmbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbZone.Items.AddRange(new object[] {
            "Zone I : Sismicité négligeable",
            "Zone IIa : Sismicité faible",
            "Zone IIb : Sismicité moyenne",
            "Zone III : Sismicité élevée"});
            this.CmbZone.Location = new System.Drawing.Point(8, 23);
            this.CmbZone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbZone.Name = "CmbZone";
            this.CmbZone.Size = new System.Drawing.Size(218, 23);
            this.CmbZone.TabIndex = 0;
            this.CmbZone.SelectionChangeCommitted += new System.EventHandler(this.CmbZone_SelectionChangeCommitted);
            // 
            // GrbImportance
            // 
            this.GrbImportance.Controls.Add(this.TxtAValeur);
            this.GrbImportance.Controls.Add(this.LblAValeur);
            this.GrbImportance.Controls.Add(this.CmbImportance);
            this.GrbImportance.Location = new System.Drawing.Point(244, 417);
            this.GrbImportance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbImportance.Name = "GrbImportance";
            this.GrbImportance.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbImportance.Size = new System.Drawing.Size(334, 63);
            this.GrbImportance.TabIndex = 4;
            this.GrbImportance.TabStop = false;
            this.GrbImportance.Text = "Importance :";
            // 
            // TxtAValeur
            // 
            this.TxtAValeur.Location = new System.Drawing.Point(61, 24);
            this.TxtAValeur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAValeur.Name = "TxtAValeur";
            this.TxtAValeur.Size = new System.Drawing.Size(73, 23);
            this.TxtAValeur.TabIndex = 3;
            this.TxtAValeur.Text = "0.40";
            this.TxtAValeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAValeur_KeyPress);
            // 
            // LblAValeur
            // 
            this.LblAValeur.AutoSize = true;
            this.LblAValeur.Location = new System.Drawing.Point(12, 28);
            this.LblAValeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAValeur.Name = "LblAValeur";
            this.LblAValeur.Size = new System.Drawing.Size(29, 15);
            this.LblAValeur.TabIndex = 2;
            this.LblAValeur.Text = "A = ";
            // 
            // CmbImportance
            // 
            this.CmbImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbImportance.DropDownWidth = 285;
            this.CmbImportance.Items.AddRange(new object[] {
            "Groupe 1A: Ouvrages d’importance vitale",
            "Groupe 1B: Ouvrages de grande importance",
            "Groupe 2: Ouvrages courants ou d’importance moyenne",
            "Groupe 3: Ouvrages de faible importance"});
            this.CmbImportance.Location = new System.Drawing.Point(8, 23);
            this.CmbImportance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbImportance.Name = "CmbImportance";
            this.CmbImportance.Size = new System.Drawing.Size(316, 23);
            this.CmbImportance.TabIndex = 1;
            this.CmbImportance.SelectionChangeCommitted += new System.EventHandler(this.CmbImportance_SelectionChangeCommitted);
            // 
            // GrbSite
            // 
            this.GrbSite.Controls.Add(this.LblT2Valeur);
            this.GrbSite.Controls.Add(this.LblT1Valeur);
            this.GrbSite.Controls.Add(this.TxtT1Valeur);
            this.GrbSite.Controls.Add(this.TxtT2Valeur);
            this.GrbSite.Controls.Add(this.CmbSite);
            this.GrbSite.Location = new System.Drawing.Point(4, 485);
            this.GrbSite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbSite.Name = "GrbSite";
            this.GrbSite.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbSite.Size = new System.Drawing.Size(233, 63);
            this.GrbSite.TabIndex = 5;
            this.GrbSite.TabStop = false;
            this.GrbSite.Text = "Site :";
            // 
            // LblT2Valeur
            // 
            this.LblT2Valeur.AutoSize = true;
            this.LblT2Valeur.Location = new System.Drawing.Point(121, 28);
            this.LblT2Valeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblT2Valeur.Name = "LblT2Valeur";
            this.LblT2Valeur.Size = new System.Drawing.Size(33, 15);
            this.LblT2Valeur.TabIndex = 7;
            this.LblT2Valeur.Text = "T2 = ";
            // 
            // LblT1Valeur
            // 
            this.LblT1Valeur.AutoSize = true;
            this.LblT1Valeur.Location = new System.Drawing.Point(8, 28);
            this.LblT1Valeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblT1Valeur.Name = "LblT1Valeur";
            this.LblT1Valeur.Size = new System.Drawing.Size(33, 15);
            this.LblT1Valeur.TabIndex = 6;
            this.LblT1Valeur.Text = "T1 = ";
            // 
            // TxtT1Valeur
            // 
            this.TxtT1Valeur.Location = new System.Drawing.Point(58, 24);
            this.TxtT1Valeur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtT1Valeur.Name = "TxtT1Valeur";
            this.TxtT1Valeur.Size = new System.Drawing.Size(51, 23);
            this.TxtT1Valeur.TabIndex = 5;
            this.TxtT1Valeur.Text = "0.15";
            // 
            // TxtT2Valeur
            // 
            this.TxtT2Valeur.Location = new System.Drawing.Point(172, 24);
            this.TxtT2Valeur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtT2Valeur.Name = "TxtT2Valeur";
            this.TxtT2Valeur.Size = new System.Drawing.Size(51, 23);
            this.TxtT2Valeur.TabIndex = 4;
            this.TxtT2Valeur.Text = "0.70";
            // 
            // CmbSite
            // 
            this.CmbSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSite.Items.AddRange(new object[] {
            "S1: Site rocheux",
            "S2: Site ferme",
            "S3: Site meuble",
            "S4: Site trés meuble"});
            this.CmbSite.Location = new System.Drawing.Point(8, 23);
            this.CmbSite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbSite.Name = "CmbSite";
            this.CmbSite.Size = new System.Drawing.Size(218, 23);
            this.CmbSite.TabIndex = 2;
            this.CmbSite.SelectionChangeCommitted += new System.EventHandler(this.CmbSite_SelectionChangeCommitted);
            // 
            // GrbMateriau
            // 
            this.GrbMateriau.Controls.Add(this.TxtXiValeur);
            this.GrbMateriau.Controls.Add(this.LblXiValeur);
            this.GrbMateriau.Controls.Add(this.CmbMateriau);
            this.GrbMateriau.Location = new System.Drawing.Point(244, 485);
            this.GrbMateriau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbMateriau.Name = "GrbMateriau";
            this.GrbMateriau.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbMateriau.Size = new System.Drawing.Size(334, 63);
            this.GrbMateriau.TabIndex = 6;
            this.GrbMateriau.TabStop = false;
            this.GrbMateriau.Text = "Matériau constitutif :";
            // 
            // TxtXiValeur
            // 
            this.TxtXiValeur.Location = new System.Drawing.Point(61, 24);
            this.TxtXiValeur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtXiValeur.Name = "TxtXiValeur";
            this.TxtXiValeur.ShortcutsEnabled = false;
            this.TxtXiValeur.Size = new System.Drawing.Size(73, 23);
            this.TxtXiValeur.TabIndex = 5;
            this.TxtXiValeur.Text = "4.0";
            // 
            // LblXiValeur
            // 
            this.LblXiValeur.AutoSize = true;
            this.LblXiValeur.Location = new System.Drawing.Point(10, 28);
            this.LblXiValeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblXiValeur.Name = "LblXiValeur";
            this.LblXiValeur.Size = new System.Drawing.Size(26, 15);
            this.LblXiValeur.TabIndex = 4;
            this.LblXiValeur.Text = "ξ = ";
            // 
            // CmbMateriau
            // 
            this.CmbMateriau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMateriau.Items.AddRange(new object[] {
            "Portiques: Béton armé (Léger)",
            "Portiques: Béton armé (Dense)",
            "Portiques: Acier (Léger)",
            "Portiques: Acier (Dense)",
            "Voiles ou murs: Béton armé/maçonnerie"});
            this.CmbMateriau.Location = new System.Drawing.Point(8, 23);
            this.CmbMateriau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbMateriau.Name = "CmbMateriau";
            this.CmbMateriau.Size = new System.Drawing.Size(316, 23);
            this.CmbMateriau.TabIndex = 3;
            this.CmbMateriau.SelectionChangeCommitted += new System.EventHandler(this.CmbMateriau_SelectionChangeCommitted);
            // 
            // GrbQualite
            // 
            this.GrbQualite.Controls.Add(this.LblQValeur);
            this.GrbQualite.Controls.Add(this.BtnChangerQualite);
            this.GrbQualite.Controls.Add(this.TxtQValeur);
            this.GrbQualite.Location = new System.Drawing.Point(5, 553);
            this.GrbQualite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbQualite.Name = "GrbQualite";
            this.GrbQualite.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbQualite.Size = new System.Drawing.Size(232, 63);
            this.GrbQualite.TabIndex = 7;
            this.GrbQualite.TabStop = false;
            this.GrbQualite.Text = "Facteur de qualité :";
            // 
            // LblQValeur
            // 
            this.LblQValeur.AutoSize = true;
            this.LblQValeur.Location = new System.Drawing.Point(7, 28);
            this.LblQValeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblQValeur.Name = "LblQValeur";
            this.LblQValeur.Size = new System.Drawing.Size(30, 15);
            this.LblQValeur.TabIndex = 2;
            this.LblQValeur.Text = "Q = ";
            // 
            // BtnChangerQualite
            // 
            this.BtnChangerQualite.Location = new System.Drawing.Point(46, 24);
            this.BtnChangerQualite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnChangerQualite.Name = "BtnChangerQualite";
            this.BtnChangerQualite.Size = new System.Drawing.Size(88, 27);
            this.BtnChangerQualite.TabIndex = 4;
            this.BtnChangerQualite.Text = "Chan&ger";
            this.toolTip1.SetToolTip(this.BtnChangerQualite, "Changer les qualites");
            this.BtnChangerQualite.UseVisualStyleBackColor = true;
            this.BtnChangerQualite.Click += new System.EventHandler(this.BtnChangerQualite_Click);
            // 
            // TxtQValeur
            // 
            this.TxtQValeur.BackColor = System.Drawing.SystemColors.Window;
            this.TxtQValeur.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtQValeur.Location = new System.Drawing.Point(57, 25);
            this.TxtQValeur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtQValeur.Name = "TxtQValeur";
            this.TxtQValeur.Size = new System.Drawing.Size(62, 23);
            this.TxtQValeur.TabIndex = 0;
            this.TxtQValeur.Text = "1.00";
            this.TxtQValeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQValeur_KeyPress);
            // 
            // GrbSysContreventement
            // 
            this.GrbSysContreventement.Controls.Add(this.LblRValeur);
            this.GrbSysContreventement.Controls.Add(this.TxtRValeur);
            this.GrbSysContreventement.Controls.Add(this.CmbSysContreventement);
            this.GrbSysContreventement.Location = new System.Drawing.Point(244, 553);
            this.GrbSysContreventement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbSysContreventement.Name = "GrbSysContreventement";
            this.GrbSysContreventement.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbSysContreventement.Size = new System.Drawing.Size(334, 63);
            this.GrbSysContreventement.TabIndex = 8;
            this.GrbSysContreventement.TabStop = false;
            this.GrbSysContreventement.Text = "Système de contreventement :";
            // 
            // LblRValeur
            // 
            this.LblRValeur.AutoSize = true;
            this.LblRValeur.Location = new System.Drawing.Point(12, 29);
            this.LblRValeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRValeur.Name = "LblRValeur";
            this.LblRValeur.Size = new System.Drawing.Size(28, 15);
            this.LblRValeur.TabIndex = 7;
            this.LblRValeur.Text = "R = ";
            // 
            // TxtRValeur
            // 
            this.TxtRValeur.Location = new System.Drawing.Point(61, 24);
            this.TxtRValeur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtRValeur.Name = "TxtRValeur";
            this.TxtRValeur.ShortcutsEnabled = false;
            this.TxtRValeur.Size = new System.Drawing.Size(73, 23);
            this.TxtRValeur.TabIndex = 6;
            this.TxtRValeur.Text = "4.0";
            // 
            // CmbSysContreventement
            // 
            this.CmbSysContreventement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSysContreventement.DropDownWidth = 400;
            this.CmbSysContreventement.Items.AddRange(new object[] {
            "Béton armé: Portiques autostables sans remplissages en maçonnerie rigide",
            "Béton armé: Portiques autostables avec remplissages en maçonnerie rigide",
            "Béton armé: Voiles porteurs",
            "Béton armé: Noyau",
            "Béton armé: Mixte portiques/voiles avec interaction",
            "Béton armé: Portiques contreventés par des voiles",
            "Béton armé: Console verticale à masses réparties",
            "Béton armé: Pendule inverse",
            "Acier: Portiques autostables ductiles",
            "Acier: Portiques autostables ordinaires",
            "Acier: Ossature contreventée par palées triangulées en X",
            "Acier: Ossature contreventée par palées triangulées en V",
            "Acier: Mixte portiques/palées triangulées en X",
            "Acier: Mixte portiques/palées triangulées en V",
            "Acier: Portiques en console verticale",
            "Maçonnerie: Maçonnerie porteuse chaînée",
            "Autres systèmes: Ossature métallique contreventée par diaphragme",
            "Autres systèmes: Ossature métallique contreventée par noyau en béton armé",
            "Autres systèmes: Ossature métallique contreventée par voiles en béton armé",
            "Autres systèmes: Ossature métallique avec contreventement mixte comportant un noy" +
                "au en béton armé et palées ou portiques métalliques en façades",
            "Autres systèmes: Systèmes comportant des transparences (étages souples)"});
            this.CmbSysContreventement.Location = new System.Drawing.Point(8, 23);
            this.CmbSysContreventement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbSysContreventement.Name = "CmbSysContreventement";
            this.CmbSysContreventement.Size = new System.Drawing.Size(316, 23);
            this.CmbSysContreventement.TabIndex = 5;
            this.CmbSysContreventement.SelectionChangeCommitted += new System.EventHandler(this.CmbSysContreventement_SelectionChangeCommitted);
            // 
            // BtnCalculer
            // 
            this.BtnCalculer.Location = new System.Drawing.Point(490, 621);
            this.BtnCalculer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCalculer.Name = "BtnCalculer";
            this.BtnCalculer.Size = new System.Drawing.Size(88, 27);
            this.BtnCalculer.TabIndex = 9;
            this.BtnCalculer.Text = "&Calculer";
            this.BtnCalculer.UseVisualStyleBackColor = true;
            this.BtnCalculer.Click += new System.EventHandler(this.BtnCalculer_Click);
            // 
            // DlgSaveFileTxt
            // 
            this.DlgSaveFileTxt.Filter = "Fichier texte (*.txt)|*.txt";
            this.DlgSaveFileTxt.Title = "Enregistrez les valeurs dans un fichier texte";
            // 
            // DlgSaveFileJpg
            // 
            this.DlgSaveFileJpg.Filter = "Fichier jpg (*.jpg)|*.jpg";
            this.DlgSaveFileJpg.Title = "Enregistrer le graphique dans un fichier image";
            // 
            // toolTip1
            // 
            this.toolTip1.UseAnimation = false;
            this.toolTip1.UseFading = false;
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnCalculer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 676);
            this.Controls.Add(this.GrbZone);
            this.Controls.Add(this.BtnCalculer);
            this.Controls.Add(this.GrbQualite);
            this.Controls.Add(this.GrbImportance);
            this.Controls.Add(this.StsValues);
            this.Controls.Add(this.TabMain);
            this.Controls.Add(this.MnuMain);
            this.Controls.Add(this.GrbMateriau);
            this.Controls.Add(this.GrbSysContreventement);
            this.Controls.Add(this.GrbSite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPA99 Version 2003";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            this.TabMain.ResumeLayout(false);
            this.TabSpectre.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TabStatique.ResumeLayout(false);
            this.TblStatiqueValeur.ResumeLayout(false);
            this.TblStatiqueValeur.PerformLayout();
            this.PnlStatique.ResumeLayout(false);
            this.GrpPeriodeFondalentale.ResumeLayout(false);
            this.GrpPeriodeFondalentale.PerformLayout();
            this.GrbDimensions.ResumeLayout(false);
            this.GrbDimensions.PerformLayout();
            this.GrbPoids.ResumeLayout(false);
            this.GrbPoids.PerformLayout();
            this.StsValues.ResumeLayout(false);
            this.StsValues.PerformLayout();
            this.GrbZone.ResumeLayout(false);
            this.GrbImportance.ResumeLayout(false);
            this.GrbImportance.PerformLayout();
            this.GrbSite.ResumeLayout(false);
            this.GrbSite.PerformLayout();
            this.GrbMateriau.ResumeLayout(false);
            this.GrbMateriau.PerformLayout();
            this.GrbQualite.ResumeLayout(false);
            this.GrbQualite.PerformLayout();
            this.GrbSysContreventement.ResumeLayout(false);
            this.GrbSysContreventement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.StatusStrip StsValues;
        internal System.Windows.Forms.ComboBox CmbZone;
        internal System.Windows.Forms.ComboBox CmbImportance;
        internal System.Windows.Forms.ComboBox CmbSite;
        internal System.Windows.Forms.ComboBox CmbMateriau;
        internal System.Windows.Forms.ComboBox CmbSysContreventement;
        internal System.Windows.Forms.TextBox TxtQValeur;
        internal System.Windows.Forms.TextBox TxtStatiqueResults;
        internal System.Windows.Forms.TextBox TxtSpectreResults;
        internal System.Windows.Forms.TextBox TxtWg;
        internal System.Windows.Forms.TextBox TxtLy;
        internal System.Windows.Forms.TextBox TxtLx;
        internal System.Windows.Forms.TextBox TxtHn;
        internal System.Windows.Forms.TextBox TxtWq;
        internal System.Windows.Forms.TextBox TxtDelta;
        internal System.Windows.Forms.MenuStrip MnuMain;
        internal System.Windows.Forms.TabControl TabMain;
        internal System.Windows.Forms.TabPage TabSpectre;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.TabPage TabStatique;
        internal System.Windows.Forms.GroupBox GrbZone;
        internal System.Windows.Forms.GroupBox GrbImportance;
        internal System.Windows.Forms.GroupBox GrbSite;
        internal System.Windows.Forms.GroupBox GrbMateriau;
        internal System.Windows.Forms.GroupBox GrbQualite;
        internal System.Windows.Forms.GroupBox GrbSysContreventement;
        internal System.Windows.Forms.Button BtnCalculer;
        internal System.Windows.Forms.TableLayoutPanel TblStatiqueValeur;
        internal System.Windows.Forms.Panel PnlStatique;
        internal System.Windows.Forms.GroupBox GrpPeriodeFondalentale;
        internal System.Windows.Forms.GroupBox GrbDimensions;
        internal System.Windows.Forms.GroupBox GrbPoids;
        internal System.Windows.Forms.SaveFileDialog DlgSaveFileTxt;
        internal System.Windows.Forms.SaveFileDialog DlgSaveFileJpg;
        internal System.Windows.Forms.Button BtnChangerQualite;
        internal System.Windows.Forms.ToolStripMenuItem MnuFile;
        internal System.Windows.Forms.Label LblQValeur;
        internal System.Windows.Forms.ComboBox CmbTypeOuvrage;
        internal System.Windows.Forms.Label LblWg;
        internal System.Windows.Forms.Label LblLy;
        internal System.Windows.Forms.Label LblLx;
        internal System.Windows.Forms.Label LblHn;
        internal System.Windows.Forms.Label LblWq;
        internal System.Windows.Forms.Label LblTypeOuvrageBetaValeur;
        internal System.Windows.Forms.ToolStripMenuItem MnuFileSaveText;
        internal System.Windows.Forms.ToolStripMenuItem MnuFileSaveImage;
        internal System.Windows.Forms.ToolStripSeparator MnuFileSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem MnuFileOptions;
        internal System.Windows.Forms.ToolStripSeparator MnuFileSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem MnuFileExit;
        internal System.Windows.Forms.ToolStripMenuItem MnuHelp;
        internal System.Windows.Forms.Label LblDelta;
        internal System.Windows.Forms.Label LblFormuleEmpirique;
        internal System.Windows.Forms.ComboBox CmbFormuleEmpirique;
        internal System.Windows.Forms.Label LblSysContreventementStat;
        internal System.Windows.Forms.ComboBox CmbSysContreventementStat;
        internal System.Windows.Forms.Label LblFormuleFond;
        internal System.Windows.Forms.ComboBox CmbFormuleFond;
        internal System.Windows.Forms.ToolStripMenuItem MnuHelpAide;
        internal System.Windows.Forms.ToolStripMenuItem MnuHelpRpa;
        internal System.Windows.Forms.ToolStripSeparator MnuSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem MnuHelpAbout;
        internal System.Windows.Forms.ToolStripStatusLabel StsA;
        internal System.Windows.Forms.ToolStripStatusLabel StsQ;
        internal System.Windows.Forms.ToolStripStatusLabel StsT1;
        internal System.Windows.Forms.ToolStripStatusLabel StsT2;
        internal System.Windows.Forms.ToolStripStatusLabel StsR;
        internal System.Windows.Forms.ToolStripStatusLabel StsXi;
        internal System.Windows.Forms.ToolStripStatusLabel StsEta;
        internal System.Windows.Forms.ToolStripStatusLabel StsBeta;
        internal System.Windows.Forms.ToolStripStatusLabel StsCt;
		internal System.Windows.Forms.ToolTip toolTip1;
		internal System.Windows.Forms.ComboBox CmbWilaya;
		internal System.Windows.Forms.Label LblT2Valeur;
		internal System.Windows.Forms.Label LblT1Valeur;
		internal System.Windows.Forms.TextBox TxtT1Valeur;
		internal System.Windows.Forms.TextBox TxtT2Valeur;
		internal System.Windows.Forms.TextBox TxtXiValeur;
		internal System.Windows.Forms.Label LblXiValeur;
		internal System.Windows.Forms.Label LblRValeur;
		internal System.Windows.Forms.TextBox TxtRValeur;
		internal System.Windows.Forms.TextBox TxtBetaValeur;
		internal System.Windows.Forms.TextBox TxtAValeur;
		internal System.Windows.Forms.Label LblAValeur;
	}
}
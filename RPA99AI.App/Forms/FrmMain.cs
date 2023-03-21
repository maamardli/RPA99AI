using RPA99AI.Library;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static RPA99AI.App.Forms.ReadWriteFunctions;

namespace RPA99AI.App.Forms
{
    public partial class FrmMain : Form
    {
        internal FrmMain()
        {
            InitializeComponent();
            FrmMainInitializeComponentChart(this);

            _frmOption = new FrmOptions(this);
            _frmQualites = new FrmQualities(this);

            Text = _frmAboutBox.AssemblyTitle;

            FrmMainResettingControlsToDefault(this);
            DoTheWork(this);
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        internal Chart ChartSpectre { get; set; } = new Chart();
        internal ChartArea ChartAreaSpectre { get; set; } = new ChartArea();
        internal Series SeriesSpectre { get; set; } = new Series();

        internal Ouvrage MyOuvrage { get; } = new Ouvrage();

        private FrmOptions _frmOption { get; set; }
        private FrmQualities _frmQualites { get; set; }
        private FrmAboutBox _frmAboutBox { get; set; } = new FrmAboutBox();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmMainLoad(this);
            DoTheWork(this);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMainClose(this);
        }

        private void BtnCalculer_Click(object sender, EventArgs e)
        {
            DoTheWork(this);
        }

        private void ChrtSpectre_MouseMove(object sender, MouseEventArgs e)
        {
            FrmMainShowChartHint(this);
        }

        private void BtnChangerQualite_Click(object sender, EventArgs e)
        {
            _frmQualites.ShowDialog();
        }

        private void MnuFileSaveText_Click(object sender, EventArgs e)
        {
            FrmMainSaveSpectreResultsAsText(this);
        }

        private void MnuFileSaveImage_Click(object sender, EventArgs e)
        {
            FrmMainSaveSpectreResultsAsChartImage(this);
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            _frmAboutBox.ShowDialog();
        }

        private void MnuHelpRpa_Click(object sender, EventArgs e)
        {
            OpenWebPage("https://drive.google.com/file/d/0B7q_ce6Oj_RocWdKM1ZMMUxmVjg/view");
        }

        private void MnuFileOptions_Click(object sender, EventArgs e)
        {
            _frmOption.ShowDialog();
        }

        private void TxtWg_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyDigitsOnKeyPress(sender, e);
        }

        private void TxtWq_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyDigitsOnKeyPress(sender, e);
        }

        private void TxtHn_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyDigitsOnKeyPress(sender, e);
        }

        private void TxtLx_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyDigitsOnKeyPress(sender, e);
        }

        private void TxtLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyDigitsOnKeyPress(sender, e);
        }

        private void TxtSegma_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyDigitsOnKeyPress(sender, e);
        }

        private void TxtXiValeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyDigitsOnKeyPress(sender, e);
        }

        private void MnuHelpAide_Click(object sender, EventArgs e)
        {
            OpenWebPage("https://sites.google.com/view/maamardli/home");
        }

        private void CmbWilaya_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DoTheWork(this);
        }

        private void CmbImportance_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DoTheWork(this);
        }

        private void CmbSite_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DoTheWork(this);
        }

        private void CmbMateriau_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DoTheWork(this);
        }

        private void CmbSysContreventement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DoTheWork(this);
        }

        private void CmbFormuleEmpirique_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DoTheWork(this);
        }

        private void CmbFormuleFond_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DoTheWork(this);
        }

        private void CmbSysContreventementStat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DoTheWork(this);
        }

        private void CmbTypeOuvrage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DoTheWork(this);
        }

        private void CmbZone_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DoTheWork(this);
        }

        private void TxtRValeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyDigitsOnKeyPress(sender, e);
        }

        private void TxtBetaValeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyDigitsOnKeyPress(sender, e);
        }

        private void TxtAValeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyDigitsOnKeyPress(sender, e);
        }

        private void TxtQValeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyDigitsOnKeyPress(sender, e);
        }

        private void CmbWilaya_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            DoTheWork(this);
        }
    }
}
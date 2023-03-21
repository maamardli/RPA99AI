using System;
using System.Windows.Forms;
using static RPA99AI.App.Forms.ReadWriteFunctions;

namespace RPA99AI.App.Forms
{
    internal partial class FrmQualities : Form
    {
        private readonly FrmMain _frmMain;

        internal FrmQualities(FrmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            FrmQualitiesWriteToSettings(this);
            DoTheWork(_frmMain);
            Close();
        }

        private void FrmQualities_Load(object sender, EventArgs e)
        {
            FrmQualitiesReadFromSettings(this);
        }
    }
}
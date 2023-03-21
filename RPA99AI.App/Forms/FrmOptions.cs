using System.Windows.Forms;
using static RPA99AI.App.Forms.ReadWriteFunctions;

namespace RPA99AI.App.Forms
{
    internal partial class FrmOptions : Form
    {
        private readonly FrmMain _frmMain;

        internal FrmOptions(FrmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            FrmOptionsResetControlsToDefault(this);
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void BtnDefault_Click(object sender, System.EventArgs e)
        {
            FrmOptionsResetControlsToDefault(this);
        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            FrmOptionsSaveOptionsToSettings(this);
            DoTheWork(_frmMain);
            Close();
        }

        private void FrmOptions_Load(object sender, System.EventArgs e)
        {
            FrmOptionsLoad(this);
        }
    }
}
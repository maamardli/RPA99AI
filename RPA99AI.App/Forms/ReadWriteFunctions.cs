using RPA99AI.App.Properties;
using RPA99AI.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RPA99AI.App.Forms
{
    internal static class ReadWriteFunctions
    {
        private static int CheckSelectedIndex(int selectedIndex)
        {
            return selectedIndex >= 0 ? selectedIndex : 0;
        }

        private static double ReadFromTextBox(Control textBox)
        {
            if (double.TryParse(textBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out double d))
            {
                return d;
            }
            else
            {
                MessageBox.Show(Resources.FrmMain_Message_One_Of_The_Used_Values_Is_Not_Correct,
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox.Text = Settings.Default[$"FrmMain_{textBox.Name}_Text"].ToString();
                return double.Parse(textBox.Text, CultureInfo.CurrentCulture);
            }
        }

        internal static void WriteOnlyDigitsOnKeyPress(object sender, KeyPressEventArgs e)
        {
            var decSymb = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator, CultureInfo.CurrentCulture);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != decSymb)
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (sender is TextBox textBox && e.KeyChar == decSymb && textBox.Text.IndexOf(decSymb, StringComparison.CurrentCulture) > -1)
            {
                e.Handled = true;
            }
        }

        //internal static void PopulateComboBoxFromEnumsWithAttributes(Enum theEnum, ComboBox combobox)
        //{
        //    var dictionary = new Dictionary<string, int>();

        //    foreach (var enumValue in Enum.GetValues(theEnum.GetType()))
        //    {
        //        var fi = theEnum.GetType().GetField(enumValue.ToString());
        //        var da = (DescriptionAttribute)Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute));
        //        dictionary.Add(da != null ? da.Description : enumValue.ToString(), (int)enumValue);
        //    }

        //    // Bind the customer type combo box
        //    combobox.DisplayMember = "Key";
        //    combobox.ValueMember = "Value";
        //    combobox.DataSource = new BindingSource(dictionary, null);
        //}

        internal static void OpenWebPage(string url)
        {
            var myURI = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            try
            {
                Process.Start(myURI);
            }
            catch (Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        #region FrmMain
        internal static void FrmMainInitializeComponentChart(FrmMain frmMain)
        {
            frmMain.ChartSpectre.AntiAliasing = AntiAliasingStyles.None;
            frmMain.ChartAreaSpectre.AxisX.Interval = 1D;
            frmMain.ChartAreaSpectre.AxisX.IntervalType = DateTimeIntervalType.Number;
            frmMain.ChartAreaSpectre.AxisX.IsMarginVisible = false;
            frmMain.ChartAreaSpectre.AxisX.MajorGrid.Interval = 0D;
            frmMain.ChartAreaSpectre.AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Number;
            frmMain.ChartAreaSpectre.AxisX.MajorGrid.LineColor = System.Drawing.Color.Red;
            frmMain.ChartAreaSpectre.AxisX.Minimum = 0D;
            frmMain.ChartAreaSpectre.AxisX.MinorGrid.Enabled = true;
            frmMain.ChartAreaSpectre.AxisX.MinorGrid.LineColor = System.Drawing.Color.PeachPuff;
            frmMain.ChartAreaSpectre.AxisX.Title = "Temps (s)";
            frmMain.ChartAreaSpectre.AxisX2.Interval = 1D;
            frmMain.ChartAreaSpectre.AxisX2.IntervalType = DateTimeIntervalType.Number;
            frmMain.ChartAreaSpectre.AxisX2.LineColor = System.Drawing.Color.BlanchedAlmond;
            frmMain.ChartAreaSpectre.AxisY.MajorGrid.Interval = 0D;
            frmMain.ChartAreaSpectre.AxisY.MajorGrid.IntervalOffsetType = DateTimeIntervalType.Number;
            frmMain.ChartAreaSpectre.AxisY.MajorGrid.IntervalType = DateTimeIntervalType.Auto;
            frmMain.ChartAreaSpectre.AxisY.MajorGrid.LineColor = System.Drawing.Color.Red;
            frmMain.ChartAreaSpectre.AxisY.MinorGrid.Enabled = true;
            frmMain.ChartAreaSpectre.AxisY.MinorGrid.LineColor = System.Drawing.Color.PeachPuff;
            frmMain.ChartAreaSpectre.AxisY.TextOrientation = TextOrientation.Rotated270;
            frmMain.ChartAreaSpectre.AxisY.Title = "Sa/g";
            frmMain.ChartAreaSpectre.Name = "ChartAreaSpectre";
            frmMain.ChartSpectre.ChartAreas.Add(frmMain.ChartAreaSpectre);
            frmMain.ChartSpectre.Dock = DockStyle.Fill;
            frmMain.ChartSpectre.IsSoftShadows = false;
            frmMain.ChartSpectre.Location = new System.Drawing.Point(3, 3);
            frmMain.ChartSpectre.Name = "ChrtSpectre";
            frmMain.SeriesSpectre.ChartArea = "ChartAreaSpectre";
            frmMain.SeriesSpectre.ChartType = SeriesChartType.Line;
            frmMain.SeriesSpectre.IsVisibleInLegend = false;
            frmMain.SeriesSpectre.Name = "SerieSpectre";
            frmMain.ChartSpectre.Series.Add(frmMain.SeriesSpectre);
            frmMain.ChartSpectre.Size = new System.Drawing.Size(357, 300);
            frmMain.ChartSpectre.TabIndex = 0;
            frmMain.ChartSpectre.Text = "Spectre";
            frmMain.ChartSpectre.TextAntiAliasingQuality = TextAntiAliasingQuality.SystemDefault;
            frmMain.ChartSpectre.Parent = frmMain.tableLayoutPanel1;
            frmMain.Controls.Add(frmMain.ChartSpectre);
            frmMain.tableLayoutPanel1.Controls.Add(frmMain.ChartSpectre);
        }

        internal static void FrmMainResettingControlsToDefault(FrmMain frmMain)
        {
            frmMain.CmbSite.SelectedIndex = 0;
            frmMain.CmbZone.SelectedIndex = 0;
            frmMain.CmbWilaya.SelectedIndex = 0;
            frmMain.CmbMateriau.SelectedIndex = 0;
            frmMain.CmbImportance.SelectedIndex = 0;
            frmMain.CmbFormuleFond.SelectedIndex = 0;
            frmMain.CmbTypeOuvrage.SelectedIndex = 0;
            frmMain.CmbFormuleEmpirique.SelectedIndex = 0;
            frmMain.CmbSysContreventement.SelectedIndex = 0;
            frmMain.CmbSysContreventementStat.SelectedIndex = 0;

            frmMain.TxtHn.Text = Convert.ToString(1.00, CultureInfo.CurrentCulture);
            frmMain.TxtLx.Text = Convert.ToString(1.00, CultureInfo.CurrentCulture);
            frmMain.TxtLy.Text = Convert.ToString(1.00, CultureInfo.CurrentCulture);
            frmMain.TxtWg.Text = Convert.ToString(1.00, CultureInfo.CurrentCulture);
            frmMain.TxtWq.Text = Convert.ToString(1.00, CultureInfo.CurrentCulture);
            frmMain.TxtDelta.Text = Convert.ToString(1.00, CultureInfo.CurrentCulture);
            frmMain.TxtXiValeur.Text = Convert.ToString(4.00, CultureInfo.CurrentCulture);
            frmMain.TxtRValeur.Text = Convert.ToString(2.00, CultureInfo.CurrentCulture);
            frmMain.TxtT1Valeur.Text = Convert.ToString(0.15, CultureInfo.CurrentCulture);
            frmMain.TxtT2Valeur.Text = Convert.ToString(0.70, CultureInfo.CurrentCulture);
            frmMain.TxtAValeur.Text = Convert.ToString(0.40, CultureInfo.CurrentCulture);
            frmMain.TxtBetaValeur.Text = Convert.ToString(1.00, CultureInfo.CurrentCulture);
        }

        internal static void FrmMainLoad(FrmMain frmMain)
        {
            frmMain.CmbSite.SelectedIndex = CheckSelectedIndex(Settings.Default.FrmMain_CmbSite_SelectedIndex);
            frmMain.CmbZone.SelectedIndex = CheckSelectedIndex(Settings.Default.FrmMain_CmbZone_SelectedIndex);
            frmMain.CmbWilaya.SelectedIndex = CheckSelectedIndex(Settings.Default.FrmMain_CmbWilaya_SelectedIndex);
            frmMain.CmbMateriau.SelectedIndex = CheckSelectedIndex(Settings.Default.FrmMain_CmbMateriau_SelectedIndex);
            frmMain.CmbImportance.SelectedIndex = CheckSelectedIndex(Settings.Default.FrmMain_CmbImportance_SelectedIndex);
            frmMain.CmbTypeOuvrage.SelectedIndex = CheckSelectedIndex(Settings.Default.FrmMain_CmbTypeOuvrage_SelectedIndex);
            frmMain.CmbFormuleFond.SelectedIndex = CheckSelectedIndex(Settings.Default.FrmMain_CmbFormuleFond_SelectedIndex);
            frmMain.CmbFormuleEmpirique.SelectedIndex = CheckSelectedIndex(Settings.Default.FrmMain_CmbFormuleEmpirique_SelectedIndex);
            frmMain.CmbSysContreventement.SelectedIndex = CheckSelectedIndex(Settings.Default.FrmMain_CmbSysContreventement_SelectedIndex);
            frmMain.CmbSysContreventementStat.SelectedIndex = CheckSelectedIndex(Settings.Default.FrmMain_CmbSysContreventementStat_SelectedIndex);

            frmMain.TxtWg.Text = Settings.Default.FrmMain_TxtWg_Text.ToString(CultureInfo.CurrentCulture);
            frmMain.TxtWq.Text = Settings.Default.FrmMain_TxtWq_Text.ToString(CultureInfo.CurrentCulture);
            frmMain.TxtHn.Text = Settings.Default.FrmMain_TxtHn_Text.ToString(CultureInfo.CurrentCulture);
            frmMain.TxtLx.Text = Settings.Default.FrmMain_TxtLx_Text.ToString(CultureInfo.CurrentCulture);
            frmMain.TxtLy.Text = Settings.Default.FrmMain_TxtLy_Text.ToString(CultureInfo.CurrentCulture);
            frmMain.TxtDelta.Text = Settings.Default.FrmMain_TxtSegma_Text.ToString(CultureInfo.CurrentCulture);
            frmMain.TxtXiValeur.Text = Settings.Default.FrmMain_TxtXiValeur_Text.ToString(CultureInfo.CurrentCulture);
            frmMain.TxtRValeur.Text = Settings.Default.FrmMain_TxtRValeur_Text.ToString(CultureInfo.CurrentCulture);
            frmMain.TxtT1Valeur.Text = Settings.Default.FrmMain_TxtT1Valeur_Text.ToString(CultureInfo.CurrentCulture);
            frmMain.TxtT2Valeur.Text = Settings.Default.FrmMain_TxtT2Valeur_Text.ToString(CultureInfo.CurrentCulture);
            frmMain.TxtQValeur.Text = Settings.Default.FrmMain_TxtQValeur_Text.ToString(CultureInfo.CurrentCulture);
            frmMain.TxtAValeur.Text = Settings.Default.FrmMain_TxtAValeur_Text.ToString(CultureInfo.CurrentCulture);
            frmMain.TxtBetaValeur.Text = Settings.Default.FrmMain_TxtBetaValeur_Text.ToString(CultureInfo.CurrentCulture);
        }

        internal static void DoTheWork(FrmMain frmMain)
        {
            FrmMainReadOptionsFromSettings(frmMain);
            FrmMainReadQualitiesFromSettings(frmMain);
            FrmMainReadDataFromControlsToOuvrage(frmMain);
            FrmMainOrgnizeComboBoxes(frmMain);
            FrmMainPresentTheSpectreResultsAsChartAndText(frmMain);
            FrmMainPresentStatiqueResultsAsText(frmMain);
            FrmMainPresentOtherValuesInStatusLabel(frmMain);
        }

        private static void FrmMainReadOptionsFromSettings(FrmMain frmMain)
        {
            frmMain.MyOuvrage.DeclarationduZone = (DeclarationduZone)Settings.Default.FrmOptions_CmbDeclarationduZone_SelectedIndex;
            switch (frmMain.MyOuvrage.DeclarationduZone)
            {
                case DeclarationduZone.ParZone:
                    frmMain.CmbZone.Visible = true;
                    frmMain.CmbWilaya.Visible = false;
                    break;

                case DeclarationduZone.ParWilaya:
                    frmMain.CmbZone.Visible = false;
                    frmMain.CmbWilaya.Visible = true;
                    break;

                default: throw new IndexOutOfRangeException();
            }

            frmMain.MyOuvrage.IsXiCustomValue = Settings.Default.FrmOptions_ChkIsXiCustomValue_Checked;
            if (frmMain.MyOuvrage.IsXiCustomValue)
            {
                frmMain.CmbMateriau.Visible = false;
                frmMain.TxtXiValeur.Visible = true;
                frmMain.LblXiValeur.Visible = true;
            }
            else
            {
                frmMain.CmbMateriau.Visible = true;
                frmMain.TxtXiValeur.Visible = false;
                frmMain.LblXiValeur.Visible = false;
            }

            frmMain.MyOuvrage.IsRCustomValue = Settings.Default.FrmOptions_ChkIsRCustomValue_Checked;
            if (frmMain.MyOuvrage.IsRCustomValue)
            {
                frmMain.CmbSysContreventement.Visible = false;
                frmMain.TxtRValeur.Visible = true;
                frmMain.LblRValeur.Visible = true;
            }
            else
            {
                frmMain.CmbSysContreventement.Visible = true;
                frmMain.TxtRValeur.Visible = false;
                frmMain.LblRValeur.Visible = false;
            }

            frmMain.MyOuvrage.IsT1T2CustomValue = Settings.Default.FrmOptions_ChkIsT1T2CustomValue_Checked;
            if (frmMain.MyOuvrage.IsT1T2CustomValue)
            {
                frmMain.CmbSite.Visible = false;
                frmMain.TxtT1Valeur.Visible = true;
                frmMain.TxtT2Valeur.Visible = true;
                frmMain.LblT1Valeur.Visible = true;
                frmMain.LblT2Valeur.Visible = true;
            }
            else
            {
                frmMain.CmbSite.Visible = true;
                frmMain.TxtT1Valeur.Visible = false;
                frmMain.TxtT2Valeur.Visible = false;
                frmMain.LblT1Valeur.Visible = false;
                frmMain.LblT2Valeur.Visible = false;
            }

            frmMain.MyOuvrage.IsQCustomValue = Settings.Default.FrmOptions_ChkIsQCustomValue_Checked;
            if (frmMain.MyOuvrage.IsQCustomValue)
            {
                frmMain.TxtQValeur.Visible = true;
                frmMain.BtnChangerQualite.Visible = false;
            }
            else
            {
                frmMain.TxtQValeur.Visible = false;
                frmMain.BtnChangerQualite.Visible = true;
            }

            frmMain.MyOuvrage.IsACustomValue = Settings.Default.FrmOptions_ChkIsACustomValue_Checked;
            if (frmMain.MyOuvrage.IsACustomValue)
            {
                frmMain.GrbZone.Enabled = false;
                frmMain.CmbImportance.Visible = false;
                frmMain.TxtAValeur.Visible = true;
                frmMain.LblAValeur.Visible = true;
            }
            else
            {
                frmMain.GrbZone.Enabled = true;
                frmMain.CmbImportance.Visible = true;
                frmMain.TxtAValeur.Visible = false;
                frmMain.LblAValeur.Visible = false;
            }

            frmMain.MyOuvrage.IsBetaCustomValue = Settings.Default.FrmOptions_ChkIsBetaCustomValue_Checked;
            if (frmMain.MyOuvrage.IsBetaCustomValue)
            {
                frmMain.CmbTypeOuvrage.Visible = false;
                frmMain.TxtBetaValeur.Visible = true;
                frmMain.LblTypeOuvrageBetaValeur.Text = Resources.FrmMain_Value_Beta_Equals;
            }
            else
            {
                frmMain.CmbTypeOuvrage.Visible = true;
                frmMain.TxtBetaValeur.Visible = false;
                frmMain.LblTypeOuvrageBetaValeur.Text = Resources.FrmMain_Type_d_ouvrage;
            }
        }

        private static void FrmMainReadQualitiesFromSettings(FrmMain frmMain)
        {
            for (var i = 0; i < frmMain.MyOuvrage.Qualites.Count; i++)
            {
                frmMain.MyOuvrage.Qualites[i].NonObserve = (bool)Settings.Default[$"FrmQualite_ChkLstQualite_Item{i}"];
            }
        }

        private static void FrmMainReadDataFromControlsToOuvrage(FrmMain frmMain)
        {
            frmMain.MyOuvrage.Zone = (Zone)CheckSelectedIndex(frmMain.CmbZone.SelectedIndex);
            frmMain.MyOuvrage.Site = (Site)CheckSelectedIndex(frmMain.CmbSite.SelectedIndex);
            frmMain.MyOuvrage.Wilaya = (Wilaya)CheckSelectedIndex(frmMain.CmbWilaya.SelectedIndex);
            frmMain.MyOuvrage.Materiau = (Materiau)CheckSelectedIndex(frmMain.CmbMateriau.SelectedIndex);
            frmMain.MyOuvrage.Importance = (Importance)CheckSelectedIndex(frmMain.CmbImportance.SelectedIndex);
            frmMain.MyOuvrage.SysContreventement = (SystemeContreventement)CheckSelectedIndex(frmMain.CmbSysContreventement.SelectedIndex);

            frmMain.MyOuvrage.Spectre.Duration = Settings.Default.FrmOptions_NumDuration_Value;
            frmMain.MyOuvrage.Spectre.Steps = (int)Math.Pow(10, Settings.Default.FrmOptions_NumPrecesion_Value);

            frmMain.MyOuvrage.TypeOuvrage = (TypeOuvrage)CheckSelectedIndex(frmMain.CmbTypeOuvrage.SelectedIndex);
            frmMain.MyOuvrage.Statique.SystemeContreventementStat = (SystemeContreventementStat)CheckSelectedIndex(frmMain.CmbSysContreventementStat.SelectedIndex);
            frmMain.MyOuvrage.Statique.Empirique = (CalculeTEmpirique)CheckSelectedIndex(frmMain.CmbFormuleEmpirique.SelectedIndex);
            frmMain.MyOuvrage.Statique.FormuleCalculeTStatique = (FormuleCalculeTStatique)CheckSelectedIndex(frmMain.CmbFormuleFond.SelectedIndex);

            frmMain.MyOuvrage.Xi = ReadFromTextBox(frmMain.TxtXiValeur);
            frmMain.MyOuvrage.R = ReadFromTextBox(frmMain.TxtRValeur);
            frmMain.MyOuvrage.T1 = ReadFromTextBox(frmMain.TxtT1Valeur);
            frmMain.MyOuvrage.T2 = ReadFromTextBox(frmMain.TxtT2Valeur);
            frmMain.MyOuvrage.Q = ReadFromTextBox(frmMain.TxtQValeur);
            frmMain.MyOuvrage.A = ReadFromTextBox(frmMain.TxtAValeur);
            frmMain.MyOuvrage.Beta = ReadFromTextBox(frmMain.TxtBetaValeur);

            frmMain.MyOuvrage.Wg = ReadFromTextBox(frmMain.TxtWg);
            frmMain.MyOuvrage.Wq = ReadFromTextBox(frmMain.TxtWq);

            frmMain.MyOuvrage.Hn = ReadFromTextBox(frmMain.TxtHn);
            frmMain.MyOuvrage.Lx = ReadFromTextBox(frmMain.TxtLx);
            frmMain.MyOuvrage.Ly = ReadFromTextBox(frmMain.TxtLy);

            frmMain.MyOuvrage.Statique.Delta = ReadFromTextBox(frmMain.TxtDelta);
        }

        private static void FrmMainOrgnizeComboBoxes(FrmMain frmMain)
        {
            switch (frmMain.CmbFormuleFond.SelectedIndex)
            {
                case 0:
                    frmMain.TxtDelta.Enabled = false;
                    frmMain.CmbSysContreventementStat.Enabled = true;
                    switch (frmMain.CmbSysContreventementStat.SelectedIndex)
                    {
                        case 0:
                        case 1:
                            frmMain.CmbFormuleEmpirique.Enabled = false;
                            break;

                        case 2:
                        case 3:
                            frmMain.CmbFormuleEmpirique.Enabled = true;
                            break;

                        default:
                            goto case 0;
                    }
                    break;

                case 1:
                    frmMain.TxtDelta.Enabled = true;
                    frmMain.CmbSysContreventementStat.Enabled = false;
                    frmMain.CmbFormuleEmpirique.Enabled = false;
                    break;

                default:
                    goto case 0;
            }
        }

        private static void FrmMainPresentTheSpectreResultsAsChartAndText(FrmMain frmMain)
        {
            var T = frmMain.MyOuvrage.Spectre.T;
            var sg = frmMain.MyOuvrage.Spectre.Sg;
            var myLines = T.Zip(sg, (t, s) => $"{t:F3}{'\t'}{s:F3}").ToArray();

            frmMain.TxtSpectreResults.Clear();
            frmMain.TxtSpectreResults.Lines = myLines;

            frmMain.ChartSpectre.Series[0].Points.Clear();
            frmMain.ChartSpectre.Series[0].Points.DataBindXY(T, sg);
        }

        private static void FrmMainPresentStatiqueResultsAsText(FrmMain frmMain)
        {
            var staticResultsText =
                Resources.FrmMain_Value_W_Rquals + frmMain.MyOuvrage.W.ToString("F3", CultureInfo.CurrentCulture) + Environment.NewLine +
                Resources.FrmMain_Value_Tx_Equals + frmMain.MyOuvrage.Statique.Tx.ToString("F3", CultureInfo.CurrentCulture) + Environment.NewLine +
                Resources.FrmMain_Value_Ty_Equals + frmMain.MyOuvrage.Statique.Ty.ToString("F3", CultureInfo.CurrentCulture) + Environment.NewLine +
                Resources.FrmMain_Value_Dx_Equals + frmMain.MyOuvrage.Statique.Dx.ToString("F3", CultureInfo.CurrentCulture) + Environment.NewLine +
                Resources.FrmMain_Value_Dy_Equals + frmMain.MyOuvrage.Statique.Dy.ToString("F3", CultureInfo.CurrentCulture) + Environment.NewLine +
                Resources.FrmMain_Value_Vx_Equals + frmMain.MyOuvrage.Statique.Vx.ToString("F3", CultureInfo.CurrentCulture) + Environment.NewLine +
                Resources.FrmMain_Value_Vy_Equals + frmMain.MyOuvrage.Statique.Vy.ToString("F3", CultureInfo.CurrentCulture) + Environment.NewLine +
                Resources.FrmMain_Value_Vx08_Equals + frmMain.MyOuvrage.Statique.Vx08.ToString("F3", CultureInfo.CurrentCulture) + Environment.NewLine +
                Resources.FrmMain_Value_Vy08_Equals + frmMain.MyOuvrage.Statique.Vy08.ToString("F3", CultureInfo.CurrentCulture) + Environment.NewLine;

            frmMain.TxtStatiqueResults.Clear();

            frmMain.TxtStatiqueResults.Text = frmMain.MyOuvrage.Statique.IsStatiqueApplicable
                ? staticResultsText
                : staticResultsText + Resources.FrmMain_Message_Statique_Equivalente_Methode_Cannot_Be_Used_Fr;
        }

        private static void FrmMainPresentOtherValuesInStatusLabel(FrmMain frmMain)
        {
            frmMain.StsA.Text = Resources.FrmMain_Value_A_Equals + frmMain.MyOuvrage.A.ToString("F2", CultureInfo.CurrentCulture);
            frmMain.StsQ.Text = Resources.FrmMain_Value_Q_Equals + frmMain.MyOuvrage.Q.ToString("F2", CultureInfo.CurrentCulture);
            frmMain.StsT1.Text = Resources.FrmMain_Value_T1_Equals + frmMain.MyOuvrage.T1.ToString("F2", CultureInfo.CurrentCulture);
            frmMain.StsT2.Text = Resources.FrmMain_Value_T2_Equals + frmMain.MyOuvrage.T2.ToString("F2", CultureInfo.CurrentCulture);
            frmMain.StsR.Text = Resources.FrmMain_Value_R_Equals + frmMain.MyOuvrage.R.ToString("F2", CultureInfo.CurrentCulture);
            frmMain.StsXi.Text = Resources.FrmMain_Value_Xi_Equals + frmMain.MyOuvrage.Xi.ToString("F2", CultureInfo.CurrentCulture);
            frmMain.StsEta.Text = Resources.FrmMain_Value_Eta_Equals + frmMain.MyOuvrage.Eta.ToString("F3", CultureInfo.CurrentCulture);
            frmMain.StsBeta.Text = Resources.FrmMain_Value_Beta_Equals + frmMain.MyOuvrage.Beta.ToString("F2", CultureInfo.CurrentCulture);
            frmMain.StsCt.Text = Resources.FrmMain_Value_Ct_Equals + frmMain.MyOuvrage.Statique.Ct.ToString("F3", CultureInfo.CurrentCulture);
        }

        internal static void FrmMainShowChartHint(FrmMain frmMain)
        {
            frmMain.ChartSpectre.Series[0].ToolTip = Settings.Default.FrmOptions_ChkIsShowHint_Checked ? "#VALX{F3}, #VALY{F3}" : "";
        }

        internal static void FrmMainSaveSpectreResultsAsChartImage(FrmMain frmMain)
        {
            if (frmMain.DlgSaveFileJpg.ShowDialog() == DialogResult.OK && frmMain.DlgSaveFileJpg.FileName.Length > 0)
            {
                frmMain.ChartSpectre.SaveImage(frmMain.DlgSaveFileJpg.FileName, ChartImageFormat.Jpeg);
            }
        }

        internal static void FrmMainSaveSpectreResultsAsText(FrmMain frmMain)
        {
            if (frmMain.DlgSaveFileTxt.ShowDialog() == DialogResult.OK && frmMain.DlgSaveFileTxt.FileName.Length > 0)
            {
                System.IO.File.WriteAllText(frmMain.DlgSaveFileTxt.FileName, frmMain.TxtSpectreResults.Text);
            }
        }

        internal static void FrmMainClose(FrmMain frmMain)
        {
            Settings.Default.FrmMain_CmbSite_SelectedIndex = frmMain.CmbSite.SelectedIndex;
            Settings.Default.FrmMain_CmbZone_SelectedIndex = frmMain.CmbZone.SelectedIndex;
            Settings.Default.FrmMain_CmbWilaya_SelectedIndex = frmMain.CmbWilaya.SelectedIndex;
            Settings.Default.FrmMain_CmbMateriau_SelectedIndex = frmMain.CmbMateriau.SelectedIndex;
            Settings.Default.FrmMain_CmbImportance_SelectedIndex = frmMain.CmbImportance.SelectedIndex;
            Settings.Default.FrmMain_CmbTypeOuvrage_SelectedIndex = frmMain.CmbTypeOuvrage.SelectedIndex;
            Settings.Default.FrmMain_CmbSysContreventement_SelectedIndex = frmMain.CmbSysContreventement.SelectedIndex;
            Settings.Default.FrmMain_CmbSysContreventementStat_SelectedIndex = frmMain.CmbSysContreventementStat.SelectedIndex;
            Settings.Default.FrmMain_CmbFormuleFond_SelectedIndex = frmMain.CmbFormuleFond.SelectedIndex;
            Settings.Default.FrmMain_CmbFormuleEmpirique_SelectedIndex = frmMain.CmbFormuleEmpirique.SelectedIndex;

            Settings.Default.FrmMain_TxtWg_Text = ReadFromTextBox(frmMain.TxtWg);
            Settings.Default.FrmMain_TxtWq_Text = ReadFromTextBox(frmMain.TxtWq);
            Settings.Default.FrmMain_TxtHn_Text = ReadFromTextBox(frmMain.TxtHn);
            Settings.Default.FrmMain_TxtLx_Text = ReadFromTextBox(frmMain.TxtLx);
            Settings.Default.FrmMain_TxtLy_Text = ReadFromTextBox(frmMain.TxtLy);
            Settings.Default.FrmMain_TxtSegma_Text = ReadFromTextBox(frmMain.TxtDelta);
            Settings.Default.FrmMain_TxtXiValeur_Text = ReadFromTextBox(frmMain.TxtXiValeur);
            Settings.Default.FrmMain_TxtRValeur_Text = ReadFromTextBox(frmMain.TxtRValeur);
            Settings.Default.FrmMain_TxtT1Valeur_Text = ReadFromTextBox(frmMain.TxtT1Valeur);
            Settings.Default.FrmMain_TxtT2Valeur_Text = ReadFromTextBox(frmMain.TxtT2Valeur);
            Settings.Default.FrmMain_TxtQValeur_Text = ReadFromTextBox(frmMain.TxtQValeur);
            Settings.Default.FrmMain_TxtAValeur_Text = ReadFromTextBox(frmMain.TxtAValeur);
            Settings.Default.FrmMain_TxtBetaValeur_Text = ReadFromTextBox(frmMain.TxtBetaValeur);

            Settings.Default.Save();
        }
        #endregion

        #region FrmOptions
        internal static void FrmOptionsLoad(FrmOptions frmOptions)
        {
            frmOptions.CmbDeclerationZone.SelectedIndex = Settings.Default.FrmOptions_CmbDeclarationduZone_SelectedIndex;

            frmOptions.ChkIsACustomValue.Checked = Settings.Default.FrmOptions_ChkIsACustomValue_Checked;
            frmOptions.ChkIsBetaCustomValue.Checked = Settings.Default.FrmOptions_ChkIsBetaCustomValue_Checked;
            frmOptions.ChkIsQCustomValue.Checked = Settings.Default.FrmOptions_ChkIsQCustomValue_Checked;
            frmOptions.ChkIsRCustomValue.Checked = Settings.Default.FrmOptions_ChkIsRCustomValue_Checked;
            frmOptions.ChkIsT1T2CustomValue.Checked = Settings.Default.FrmOptions_ChkIsT1T2CustomValue_Checked;
            frmOptions.ChkIsXiCustomValue.Checked = Settings.Default.FrmOptions_ChkIsXiCustomValue_Checked;

            frmOptions.NumDuration.Value = Settings.Default.FrmOptions_NumDuration_Value;
            frmOptions.NumPrecesion.Value = Settings.Default.FrmOptions_NumPrecesion_Value;

            frmOptions.ChkShowHint.Checked = Settings.Default.FrmOptions_ChkIsShowHint_Checked;
        }

        internal static void FrmOptionsResetControlsToDefault(FrmOptions frmOptions)
        {
            frmOptions.CmbDeclerationZone.SelectedIndex = 0;

            frmOptions.ChkIsACustomValue.Checked = false;
            frmOptions.ChkIsBetaCustomValue.Checked = false;
            frmOptions.ChkIsQCustomValue.Checked = false;
            frmOptions.ChkIsRCustomValue.Checked = false;
            frmOptions.ChkIsT1T2CustomValue.Checked = false;
            frmOptions.ChkIsXiCustomValue.Checked = false;

            frmOptions.NumDuration.Value = 5;
            frmOptions.NumPrecesion.Value = 3;

            frmOptions.ChkShowHint.Checked = false;
        }

        internal static void FrmOptionsSaveOptionsToSettings(FrmOptions frmOptions)
        {
            Settings.Default.FrmOptions_CmbDeclarationduZone_SelectedIndex = frmOptions.CmbDeclerationZone.SelectedIndex;

            Settings.Default.FrmOptions_ChkIsACustomValue_Checked = frmOptions.ChkIsACustomValue.Checked;
            Settings.Default.FrmOptions_ChkIsBetaCustomValue_Checked = frmOptions.ChkIsBetaCustomValue.Checked;
            Settings.Default.FrmOptions_ChkIsQCustomValue_Checked = frmOptions.ChkIsQCustomValue.Checked;
            Settings.Default.FrmOptions_ChkIsRCustomValue_Checked = frmOptions.ChkIsRCustomValue.Checked;
            Settings.Default.FrmOptions_ChkIsT1T2CustomValue_Checked = frmOptions.ChkIsT1T2CustomValue.Checked;
            Settings.Default.FrmOptions_ChkIsXiCustomValue_Checked = frmOptions.ChkIsXiCustomValue.Checked;

            Settings.Default.FrmOptions_NumDuration_Value = (int)frmOptions.NumDuration.Value;
            Settings.Default.FrmOptions_NumPrecesion_Value = (int)frmOptions.NumPrecesion.Value;

            Settings.Default.FrmOptions_ChkIsShowHint_Checked = frmOptions.ChkShowHint.Checked;
        }
        #endregion

        #region FrmQualities
        internal static void FrmQualitiesReadFromSettings(FrmQualities frmQualities)
        {
            for (var i = 0; i < frmQualities.ChkLstQualite.Items.Count; i++)
            {
                frmQualities.ChkLstQualite.SetItemChecked(i, (bool)Settings.Default[$"FrmQualite_ChkLstQualite_Item{i}"]);
            }
        }

        internal static void FrmQualitiesWriteToSettings(FrmQualities frmQualities)
        {
            for (var i = 0; i < frmQualities.ChkLstQualite.Items.Count; i++)
            {
                Settings.Default[$"FrmQualite_ChkLstQualite_Item{i}"] = frmQualities.ChkLstQualite.GetItemChecked(i);
            }
        }
        #endregion
    }
}
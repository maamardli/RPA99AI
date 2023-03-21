namespace RPA2003II.App.Forms
{
    partial class FrmOptions
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.GrbDeclerationParametres = new System.Windows.Forms.GroupBox();
            this.ChkIsBetaCustomValue = new System.Windows.Forms.CheckBox();
            this.ChkIsXiCustomValue = new System.Windows.Forms.CheckBox();
            this.ChkIsRCustomValue = new System.Windows.Forms.CheckBox();
            this.ChkIsQCustomValue = new System.Windows.Forms.CheckBox();
            this.ChkIsT1T2CustomValue = new System.Windows.Forms.CheckBox();
            this.ChkIsACustomValue = new System.Windows.Forms.CheckBox();
            this.LbDeclerationZone = new System.Windows.Forms.Label();
            this.CmbDeclerationZone = new System.Windows.Forms.ComboBox();
            this.GrbSpectreOptions = new System.Windows.Forms.GroupBox();
            this.LblPrecesion = new System.Windows.Forms.Label();
            this.LblDuration = new System.Windows.Forms.Label();
            this.ChkShowHint = new System.Windows.Forms.CheckBox();
            this.NumPrecesion = new System.Windows.Forms.NumericUpDown();
            this.NumDuration = new System.Windows.Forms.NumericUpDown();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDefault = new System.Windows.Forms.Button();
            this.GrbDeclerationParametres.SuspendLayout();
            this.GrbSpectreOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.Location = new System.Drawing.Point(385, 278);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(90, 27);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // GrbDeclerationParametres
            // 
            this.GrbDeclerationParametres.Controls.Add(this.ChkIsBetaCustomValue);
            this.GrbDeclerationParametres.Controls.Add(this.ChkIsXiCustomValue);
            this.GrbDeclerationParametres.Controls.Add(this.ChkIsRCustomValue);
            this.GrbDeclerationParametres.Controls.Add(this.ChkIsQCustomValue);
            this.GrbDeclerationParametres.Controls.Add(this.ChkIsT1T2CustomValue);
            this.GrbDeclerationParametres.Controls.Add(this.ChkIsACustomValue);
            this.GrbDeclerationParametres.Controls.Add(this.LbDeclerationZone);
            this.GrbDeclerationParametres.Controls.Add(this.CmbDeclerationZone);
            this.GrbDeclerationParametres.Location = new System.Drawing.Point(8, 15);
            this.GrbDeclerationParametres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbDeclerationParametres.Name = "GrbDeclerationParametres";
            this.GrbDeclerationParametres.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbDeclerationParametres.Size = new System.Drawing.Size(467, 243);
            this.GrbDeclerationParametres.TabIndex = 1;
            this.GrbDeclerationParametres.TabStop = false;
            this.GrbDeclerationParametres.Text = "Définir les paramètres du bâtiment : ";
            // 
            // ChkIsBetaCustomValue
            // 
            this.ChkIsBetaCustomValue.AutoSize = true;
            this.ChkIsBetaCustomValue.Location = new System.Drawing.Point(10, 205);
            this.ChkIsBetaCustomValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkIsBetaCustomValue.Name = "ChkIsBetaCustomValue";
            this.ChkIsBetaCustomValue.Size = new System.Drawing.Size(234, 19);
            this.ChkIsBetaCustomValue.TabIndex = 7;
            this.ChkIsBetaCustomValue.Text = "Utilisez une valeur personnalisée pour β";
            this.ChkIsBetaCustomValue.UseVisualStyleBackColor = true;
            // 
            // ChkIsXiCustomValue
            // 
            this.ChkIsXiCustomValue.AutoSize = true;
            this.ChkIsXiCustomValue.Location = new System.Drawing.Point(10, 179);
            this.ChkIsXiCustomValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkIsXiCustomValue.Name = "ChkIsXiCustomValue";
            this.ChkIsXiCustomValue.Size = new System.Drawing.Size(253, 19);
            this.ChkIsXiCustomValue.TabIndex = 6;
            this.ChkIsXiCustomValue.Text = "Utilisez une valeur personnalisée pour ξ (Xi)";
            this.ChkIsXiCustomValue.UseVisualStyleBackColor = true;
            // 
            // ChkIsRCustomValue
            // 
            this.ChkIsRCustomValue.AutoSize = true;
            this.ChkIsRCustomValue.Location = new System.Drawing.Point(10, 152);
            this.ChkIsRCustomValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkIsRCustomValue.Name = "ChkIsRCustomValue";
            this.ChkIsRCustomValue.Size = new System.Drawing.Size(234, 19);
            this.ChkIsRCustomValue.TabIndex = 5;
            this.ChkIsRCustomValue.Text = "Utilisez une valeur personnalisée pour R";
            this.ChkIsRCustomValue.UseVisualStyleBackColor = true;
            // 
            // ChkIsQCustomValue
            // 
            this.ChkIsQCustomValue.AutoSize = true;
            this.ChkIsQCustomValue.Location = new System.Drawing.Point(10, 126);
            this.ChkIsQCustomValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkIsQCustomValue.Name = "ChkIsQCustomValue";
            this.ChkIsQCustomValue.Size = new System.Drawing.Size(236, 19);
            this.ChkIsQCustomValue.TabIndex = 4;
            this.ChkIsQCustomValue.Text = "Utilisez une valeur personnalisée pour Q";
            this.ChkIsQCustomValue.UseVisualStyleBackColor = true;
            // 
            // ChkIsT1T2CustomValue
            // 
            this.ChkIsT1T2CustomValue.AutoSize = true;
            this.ChkIsT1T2CustomValue.Location = new System.Drawing.Point(10, 99);
            this.ChkIsT1T2CustomValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkIsT1T2CustomValue.Name = "ChkIsT1T2CustomValue";
            this.ChkIsT1T2CustomValue.Size = new System.Drawing.Size(267, 19);
            this.ChkIsT1T2CustomValue.TabIndex = 3;
            this.ChkIsT1T2CustomValue.Text = "Utilisez une valeur personnalisée pour T1 et T2";
            this.ChkIsT1T2CustomValue.UseVisualStyleBackColor = true;
            // 
            // ChkIsACustomValue
            // 
            this.ChkIsACustomValue.AutoSize = true;
            this.ChkIsACustomValue.Location = new System.Drawing.Point(10, 73);
            this.ChkIsACustomValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkIsACustomValue.Name = "ChkIsACustomValue";
            this.ChkIsACustomValue.Size = new System.Drawing.Size(235, 19);
            this.ChkIsACustomValue.TabIndex = 2;
            this.ChkIsACustomValue.Text = "Utilisez une valeur personnalisée pour A";
            this.ChkIsACustomValue.UseVisualStyleBackColor = true;
            // 
            // LbDeclerationZone
            // 
            this.LbDeclerationZone.AutoSize = true;
            this.LbDeclerationZone.Location = new System.Drawing.Point(10, 20);
            this.LbDeclerationZone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbDeclerationZone.Name = "LbDeclerationZone";
            this.LbDeclerationZone.Size = new System.Drawing.Size(218, 15);
            this.LbDeclerationZone.TabIndex = 1;
            this.LbDeclerationZone.Text = "Comment voulez-vous déclarer la zone?";
            // 
            // CmbDeclerationZone
            // 
            this.CmbDeclerationZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDeclerationZone.FormattingEnabled = true;
            this.CmbDeclerationZone.Items.AddRange(new object[] {
            "Par Zone",
            "Par Wilaya"});
            this.CmbDeclerationZone.Location = new System.Drawing.Point(10, 42);
            this.CmbDeclerationZone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbDeclerationZone.Name = "CmbDeclerationZone";
            this.CmbDeclerationZone.Size = new System.Drawing.Size(165, 23);
            this.CmbDeclerationZone.TabIndex = 0;
            // 
            // GrbSpectreOptions
            // 
            this.GrbSpectreOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GrbSpectreOptions.Controls.Add(this.LblPrecesion);
            this.GrbSpectreOptions.Controls.Add(this.LblDuration);
            this.GrbSpectreOptions.Controls.Add(this.ChkShowHint);
            this.GrbSpectreOptions.Controls.Add(this.NumPrecesion);
            this.GrbSpectreOptions.Controls.Add(this.NumDuration);
            this.GrbSpectreOptions.Location = new System.Drawing.Point(8, 269);
            this.GrbSpectreOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbSpectreOptions.Name = "GrbSpectreOptions";
            this.GrbSpectreOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrbSpectreOptions.Size = new System.Drawing.Size(370, 104);
            this.GrbSpectreOptions.TabIndex = 3;
            this.GrbSpectreOptions.TabStop = false;
            this.GrbSpectreOptions.Text = "Définir les paramètres du spectre de réponse : ";
            // 
            // LblPrecesion
            // 
            this.LblPrecesion.AutoSize = true;
            this.LblPrecesion.Location = new System.Drawing.Point(7, 54);
            this.LblPrecesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecesion.Name = "LblPrecesion";
            this.LblPrecesion.Size = new System.Drawing.Size(233, 15);
            this.LblPrecesion.TabIndex = 4;
            this.LblPrecesion.Text = "Définir la précision du spectre de réponse : ";
            // 
            // LblDuration
            // 
            this.LblDuration.AutoSize = true;
            this.LblDuration.Location = new System.Drawing.Point(7, 24);
            this.LblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDuration.Name = "LblDuration";
            this.LblDuration.Size = new System.Drawing.Size(215, 15);
            this.LblDuration.TabIndex = 3;
            this.LblDuration.Text = "Définir la durée du spectre de réponse : ";
            // 
            // ChkShowHint
            // 
            this.ChkShowHint.AutoSize = true;
            this.ChkShowHint.Location = new System.Drawing.Point(7, 77);
            this.ChkShowHint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkShowHint.Name = "ChkShowHint";
            this.ChkShowHint.Size = new System.Drawing.Size(328, 19);
            this.ChkShowHint.TabIndex = 2;
            this.ChkShowHint.Text = "Afficher les valeurs du spectre en tant que bulles d\'indice.";
            this.ChkShowHint.UseVisualStyleBackColor = true;
            // 
            // NumPrecesion
            // 
            this.NumPrecesion.Location = new System.Drawing.Point(261, 52);
            this.NumPrecesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumPrecesion.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumPrecesion.Name = "NumPrecesion";
            this.NumPrecesion.Size = new System.Drawing.Size(57, 23);
            this.NumPrecesion.TabIndex = 1;
            this.NumPrecesion.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NumDuration
            // 
            this.NumDuration.Location = new System.Drawing.Point(248, 22);
            this.NumDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumDuration.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumDuration.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumDuration.Name = "NumDuration";
            this.NumDuration.Size = new System.Drawing.Size(57, 23);
            this.NumDuration.TabIndex = 0;
            this.NumDuration.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(385, 312);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 27);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDefault
            // 
            this.BtnDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDefault.Location = new System.Drawing.Point(385, 346);
            this.BtnDefault.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDefault.Name = "BtnDefault";
            this.BtnDefault.Size = new System.Drawing.Size(90, 27);
            this.BtnDefault.TabIndex = 5;
            this.BtnDefault.Text = "Réinitialiser";
            this.BtnDefault.UseVisualStyleBackColor = true;
            this.BtnDefault.Click += new System.EventHandler(this.BtnDefault_Click);
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 387);
            this.Controls.Add(this.BtnDefault);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.GrbSpectreOptions);
            this.Controls.Add(this.GrbDeclerationParametres);
            this.Controls.Add(this.BtnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            this.GrbDeclerationParametres.ResumeLayout(false);
            this.GrbDeclerationParametres.PerformLayout();
            this.GrbSpectreOptions.ResumeLayout(false);
            this.GrbSpectreOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnOk;
        internal System.Windows.Forms.GroupBox GrbDeclerationParametres;
        internal System.Windows.Forms.Label LbDeclerationZone;
        internal System.Windows.Forms.ComboBox CmbDeclerationZone;
        internal System.Windows.Forms.GroupBox GrbSpectreOptions;
        internal System.Windows.Forms.Label LblPrecesion;
        internal System.Windows.Forms.Label LblDuration;
        internal System.Windows.Forms.CheckBox ChkShowHint;
        internal System.Windows.Forms.NumericUpDown NumPrecesion;
        internal System.Windows.Forms.NumericUpDown NumDuration;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnDefault;
        internal System.Windows.Forms.CheckBox ChkIsXiCustomValue;
        internal System.Windows.Forms.CheckBox ChkIsRCustomValue;
        internal System.Windows.Forms.CheckBox ChkIsQCustomValue;
        internal System.Windows.Forms.CheckBox ChkIsT1T2CustomValue;
        internal System.Windows.Forms.CheckBox ChkIsACustomValue;
        internal System.Windows.Forms.CheckBox ChkIsBetaCustomValue;
    }
}
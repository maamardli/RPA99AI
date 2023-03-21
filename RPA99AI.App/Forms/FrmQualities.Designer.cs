namespace RPA99AI.App.Forms
{
    partial class FrmQualities
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
            this.ChkLstQualite = new System.Windows.Forms.CheckedListBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.LblChooseQualite = new System.Windows.Forms.Label();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChkLstQualite
            // 
            this.ChkLstQualite.CheckOnClick = true;
            this.ChkLstQualite.FormattingEnabled = true;
            this.ChkLstQualite.Items.AddRange(new object[] {
            "Conditions minimales sur les files de contreventement. (0.05)",
            "Redondance en plan. (0.05)",
            "Régularité en plan. (0.05)",
            "Régularité en élévation. (0.05)",
            "Contrôle de la qualité des matériaux. (0.05)",
            "Contrôle de la qualité de l’exécution. (0.10)"});
            this.ChkLstQualite.Location = new System.Drawing.Point(14, 27);
            this.ChkLstQualite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkLstQualite.Name = "ChkLstQualite";
            this.ChkLstQualite.Size = new System.Drawing.Size(433, 112);
            this.ChkLstQualite.TabIndex = 0;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(265, 146);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(88, 27);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "O&K";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblChooseQualite
            // 
            this.LblChooseQualite.AutoSize = true;
            this.LblChooseQualite.Location = new System.Drawing.Point(14, 5);
            this.LblChooseQualite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblChooseQualite.Name = "LblChooseQualite";
            this.LblChooseQualite.Size = new System.Drawing.Size(181, 15);
            this.LblChooseQualite.TabIndex = 3;
            this.LblChooseQualite.Text = "Choisir les critères non observés :";
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(359, 145);
            this.BtnAnnuler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(88, 27);
            this.BtnAnnuler.TabIndex = 4;
            this.BtnAnnuler.Text = "&Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // FrmQualities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 179);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.LblChooseQualite);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.ChkLstQualite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQualities";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmQualities";
            this.Load += new System.EventHandler(this.FrmQualities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckedListBox ChkLstQualite;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label LblChooseQualite;
        private System.Windows.Forms.Button BtnAnnuler;
    }
}
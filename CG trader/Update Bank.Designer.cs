namespace CG_trader
{
    partial class Update_Bank
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Bank));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.cmbBanks = new MetroFramework.Controls.MetroComboBox();
            this.txtbankaddress = new MetroFramework.Controls.MetroTextBox();
            this.txtbankname = new MetroFramework.Controls.MetroTextBox();
            this.txtbankid = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnupdate = new MetroFramework.Controls.MetroButton();
            this.btndelete = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Gray;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btncancel);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1013, 100);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // btncancel
            // 
            this.btncancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncancel.Location = new System.Drawing.Point(921, 0);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(90, 98);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel2.BackgroundImage")));
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.cmbBanks);
            this.metroPanel2.Controls.Add(this.txtbankaddress);
            this.metroPanel2.Controls.Add(this.txtbankname);
            this.metroPanel2.Controls.Add(this.txtbankid);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 100);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1013, 388);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // cmbBanks
            // 
            this.cmbBanks.FormattingEnabled = true;
            this.cmbBanks.ItemHeight = 24;
            this.cmbBanks.Location = new System.Drawing.Point(125, 24);
            this.cmbBanks.Name = "cmbBanks";
            this.cmbBanks.Size = new System.Drawing.Size(191, 30);
            this.cmbBanks.TabIndex = 5;
            this.cmbBanks.UseSelectable = true;
            this.cmbBanks.SelectedIndexChanged += new System.EventHandler(this.cmbBanks_SelectedIndexChanged);
            // 
            // txtbankaddress
            // 
            this.txtbankaddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.txtbankaddress.CustomButton.Image = null;
            this.txtbankaddress.CustomButton.Location = new System.Drawing.Point(481, 2);
            this.txtbankaddress.CustomButton.Name = "";
            this.txtbankaddress.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.txtbankaddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbankaddress.CustomButton.TabIndex = 1;
            this.txtbankaddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbankaddress.CustomButton.UseSelectable = true;
            this.txtbankaddress.CustomButton.Visible = false;
            this.txtbankaddress.Lines = new string[0];
            this.txtbankaddress.Location = new System.Drawing.Point(454, 187);
            this.txtbankaddress.MaxLength = 32767;
            this.txtbankaddress.Name = "txtbankaddress";
            this.txtbankaddress.PasswordChar = '\0';
            this.txtbankaddress.PromptText = "Bank Address :";
            this.txtbankaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbankaddress.SelectedText = "";
            this.txtbankaddress.SelectionLength = 0;
            this.txtbankaddress.SelectionStart = 0;
            this.txtbankaddress.ShortcutsEnabled = true;
            this.txtbankaddress.Size = new System.Drawing.Size(539, 60);
            this.txtbankaddress.TabIndex = 4;
            this.txtbankaddress.UseCustomBackColor = true;
            this.txtbankaddress.UseSelectable = true;
            this.txtbankaddress.WaterMark = "Bank Address :";
            this.txtbankaddress.WaterMarkColor = System.Drawing.Color.Green;
            this.txtbankaddress.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbankaddress.WithError = true;
            // 
            // txtbankname
            // 
            this.txtbankname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.txtbankname.CustomButton.Image = null;
            this.txtbankname.CustomButton.Location = new System.Drawing.Point(481, 2);
            this.txtbankname.CustomButton.Name = "";
            this.txtbankname.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.txtbankname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbankname.CustomButton.TabIndex = 1;
            this.txtbankname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbankname.CustomButton.UseSelectable = true;
            this.txtbankname.CustomButton.Visible = false;
            this.txtbankname.Lines = new string[0];
            this.txtbankname.Location = new System.Drawing.Point(454, 109);
            this.txtbankname.MaxLength = 32767;
            this.txtbankname.Name = "txtbankname";
            this.txtbankname.PasswordChar = '\0';
            this.txtbankname.PromptText = "Bank Name :";
            this.txtbankname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbankname.SelectedText = "";
            this.txtbankname.SelectionLength = 0;
            this.txtbankname.SelectionStart = 0;
            this.txtbankname.ShortcutsEnabled = true;
            this.txtbankname.Size = new System.Drawing.Size(539, 60);
            this.txtbankname.TabIndex = 3;
            this.txtbankname.UseCustomBackColor = true;
            this.txtbankname.UseSelectable = true;
            this.txtbankname.WaterMark = "Bank Name :";
            this.txtbankname.WaterMarkColor = System.Drawing.Color.Green;
            this.txtbankname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtbankid
            // 
            this.txtbankid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.txtbankid.CustomButton.Image = null;
            this.txtbankid.CustomButton.Location = new System.Drawing.Point(481, 2);
            this.txtbankid.CustomButton.Name = "";
            this.txtbankid.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.txtbankid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbankid.CustomButton.TabIndex = 1;
            this.txtbankid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbankid.CustomButton.UseSelectable = true;
            this.txtbankid.CustomButton.Visible = false;
            this.txtbankid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbankid.Lines = new string[0];
            this.txtbankid.Location = new System.Drawing.Point(454, 33);
            this.txtbankid.MaxLength = 32767;
            this.txtbankid.Name = "txtbankid";
            this.txtbankid.PasswordChar = '\0';
            this.txtbankid.PromptText = "Bank ID :";
            this.txtbankid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbankid.SelectedText = "";
            this.txtbankid.SelectionLength = 0;
            this.txtbankid.SelectionStart = 0;
            this.txtbankid.ShortcutsEnabled = true;
            this.txtbankid.Size = new System.Drawing.Size(539, 60);
            this.txtbankid.TabIndex = 2;
            this.txtbankid.UseCustomBackColor = true;
            this.txtbankid.UseSelectable = true;
            this.txtbankid.WaterMark = "Bank ID :";
            this.txtbankid.WaterMarkColor = System.Drawing.Color.ForestGreen;
            this.txtbankid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbankid.WithError = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.btnupdate);
            this.metroPanel3.Controls.Add(this.btndelete);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 488);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1013, 100);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(822, 26);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(90, 60);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseSelectable = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(918, 26);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(90, 60);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseSelectable = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Update_Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Update_Bank";
            this.Size = new System.Drawing.Size(1013, 588);
            this.Load += new System.EventHandler(this.Update_Bank_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtbankid;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton btncancel;
        private MetroFramework.Controls.MetroTextBox txtbankaddress;
        private MetroFramework.Controls.MetroTextBox txtbankname;
        private MetroFramework.Controls.MetroButton btnupdate;
        private MetroFramework.Controls.MetroButton btndelete;
        private MetroFramework.Controls.MetroComboBox cmbBanks;
    }
}

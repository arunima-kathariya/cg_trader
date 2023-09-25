namespace CG_trader
{
    partial class Paryentry
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtuserid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txttelephone = new MetroFramework.Controls.MetroTextBox();
            this.txtpartyaddress = new MetroFramework.Controls.MetroTextBox();
            this.txtpartyname = new MetroFramework.Controls.MetroTextBox();
            this.txtpartyid = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroPanel1.Controls.Add(this.txtuserid);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.txttelephone);
            this.metroPanel1.Controls.Add(this.txtpartyaddress);
            this.metroPanel1.Controls.Add(this.txtpartyname);
            this.metroPanel1.Controls.Add(this.txtpartyid);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(123, 40);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(537, 339);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtuserid
            // 
            // 
            // 
            // 
            this.txtuserid.CustomButton.Image = null;
            this.txtuserid.CustomButton.Location = new System.Drawing.Point(122, 2);
            this.txtuserid.CustomButton.Name = "";
            this.txtuserid.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtuserid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtuserid.CustomButton.TabIndex = 1;
            this.txtuserid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtuserid.CustomButton.UseSelectable = true;
            this.txtuserid.CustomButton.Visible = false;
            this.txtuserid.Lines = new string[0];
            this.txtuserid.Location = new System.Drawing.Point(195, 64);
            this.txtuserid.MaxLength = 32767;
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.PasswordChar = '\0';
            this.txtuserid.PromptText = "User_id";
            this.txtuserid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtuserid.SelectedText = "";
            this.txtuserid.SelectionLength = 0;
            this.txtuserid.SelectionStart = 0;
            this.txtuserid.ShortcutsEnabled = true;
            this.txtuserid.Size = new System.Drawing.Size(150, 30);
            this.txtuserid.TabIndex = 9;
            this.txtuserid.UseSelectable = true;
            this.txtuserid.WaterMark = "User_id";
            this.txtuserid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtuserid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(531, 60);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Party Entry";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(336, 270);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(90, 47);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(74, 270);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(85, 47);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txttelephone
            // 
            // 
            // 
            // 
            this.txttelephone.CustomButton.Image = null;
            this.txttelephone.CustomButton.Location = new System.Drawing.Point(122, 2);
            this.txttelephone.CustomButton.Name = "";
            this.txttelephone.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txttelephone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttelephone.CustomButton.TabIndex = 1;
            this.txttelephone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttelephone.CustomButton.UseSelectable = true;
            this.txttelephone.CustomButton.Visible = false;
            this.txttelephone.Lines = new string[0];
            this.txttelephone.Location = new System.Drawing.Point(276, 184);
            this.txttelephone.MaxLength = 32767;
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.PasswordChar = '\0';
            this.txttelephone.PromptText = "Telephone:";
            this.txttelephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttelephone.SelectedText = "";
            this.txttelephone.SelectionLength = 0;
            this.txttelephone.SelectionStart = 0;
            this.txttelephone.ShortcutsEnabled = true;
            this.txttelephone.Size = new System.Drawing.Size(150, 30);
            this.txttelephone.TabIndex = 5;
            this.txttelephone.UseSelectable = true;
            this.txttelephone.WaterMark = "Telephone:";
            this.txttelephone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttelephone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtpartyaddress
            // 
            // 
            // 
            // 
            this.txtpartyaddress.CustomButton.Image = null;
            this.txtpartyaddress.CustomButton.Location = new System.Drawing.Point(122, 2);
            this.txtpartyaddress.CustomButton.Name = "";
            this.txtpartyaddress.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtpartyaddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpartyaddress.CustomButton.TabIndex = 1;
            this.txtpartyaddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpartyaddress.CustomButton.UseSelectable = true;
            this.txtpartyaddress.CustomButton.Visible = false;
            this.txtpartyaddress.Lines = new string[0];
            this.txtpartyaddress.Location = new System.Drawing.Point(19, 184);
            this.txtpartyaddress.MaxLength = 32767;
            this.txtpartyaddress.Name = "txtpartyaddress";
            this.txtpartyaddress.PasswordChar = '\0';
            this.txtpartyaddress.PromptText = "Party Address:";
            this.txtpartyaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpartyaddress.SelectedText = "";
            this.txtpartyaddress.SelectionLength = 0;
            this.txtpartyaddress.SelectionStart = 0;
            this.txtpartyaddress.ShortcutsEnabled = true;
            this.txtpartyaddress.Size = new System.Drawing.Size(150, 30);
            this.txtpartyaddress.TabIndex = 4;
            this.txtpartyaddress.UseSelectable = true;
            this.txtpartyaddress.WaterMark = "Party Address:";
            this.txtpartyaddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpartyaddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtpartyname
            // 
            // 
            // 
            // 
            this.txtpartyname.CustomButton.Image = null;
            this.txtpartyname.CustomButton.Location = new System.Drawing.Point(122, 2);
            this.txtpartyname.CustomButton.Name = "";
            this.txtpartyname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtpartyname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpartyname.CustomButton.TabIndex = 1;
            this.txtpartyname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpartyname.CustomButton.UseSelectable = true;
            this.txtpartyname.CustomButton.Visible = false;
            this.txtpartyname.Lines = new string[0];
            this.txtpartyname.Location = new System.Drawing.Point(276, 115);
            this.txtpartyname.MaxLength = 32767;
            this.txtpartyname.Name = "txtpartyname";
            this.txtpartyname.PasswordChar = '\0';
            this.txtpartyname.PromptText = "Party Name:";
            this.txtpartyname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpartyname.SelectedText = "";
            this.txtpartyname.SelectionLength = 0;
            this.txtpartyname.SelectionStart = 0;
            this.txtpartyname.ShortcutsEnabled = true;
            this.txtpartyname.Size = new System.Drawing.Size(150, 30);
            this.txtpartyname.TabIndex = 3;
            this.txtpartyname.UseSelectable = true;
            this.txtpartyname.WaterMark = "Party Name:";
            this.txtpartyname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpartyname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtpartyid
            // 
            // 
            // 
            // 
            this.txtpartyid.CustomButton.Image = null;
            this.txtpartyid.CustomButton.Location = new System.Drawing.Point(122, 2);
            this.txtpartyid.CustomButton.Name = "";
            this.txtpartyid.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtpartyid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpartyid.CustomButton.TabIndex = 1;
            this.txtpartyid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpartyid.CustomButton.UseSelectable = true;
            this.txtpartyid.CustomButton.Visible = false;
            this.txtpartyid.Lines = new string[0];
            this.txtpartyid.Location = new System.Drawing.Point(19, 115);
            this.txtpartyid.MaxLength = 32767;
            this.txtpartyid.Name = "txtpartyid";
            this.txtpartyid.PasswordChar = '\0';
            this.txtpartyid.PromptText = "Party ID:";
            this.txtpartyid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpartyid.SelectedText = "";
            this.txtpartyid.SelectionLength = 0;
            this.txtpartyid.SelectionStart = 0;
            this.txtpartyid.ShortcutsEnabled = true;
            this.txtpartyid.Size = new System.Drawing.Size(150, 30);
            this.txtpartyid.TabIndex = 2;
            this.txtpartyid.UseSelectable = true;
            this.txtpartyid.WaterMark = "Party ID:";
            this.txtpartyid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpartyid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtpartyid.Click += new System.EventHandler(this.txtpartyid_Click);
            // 
            // Paryentry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "Paryentry";
            this.Size = new System.Drawing.Size(1044, 570);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtpartyid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txttelephone;
        private MetroFramework.Controls.MetroTextBox txtpartyaddress;
        private MetroFramework.Controls.MetroTextBox txtpartyname;
        private MetroFramework.Controls.MetroTextBox txtuserid;
    }
}

namespace CG_trader
{
    partial class UserControl4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl4));
            this.txtchequeno = new MetroFramework.Controls.MetroTextBox();
            this.txtdateofcash = new MetroFramework.Controls.MetroTextBox();
            this.CMB = new MetroFramework.Controls.MetroComboBox();
            this.CDO = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.CMB1 = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtamount = new MetroFramework.Controls.MetroTextBox();
            this.txtentrydate = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtchequeno
            // 
            // 
            // 
            // 
            this.txtchequeno.CustomButton.Image = null;
            this.txtchequeno.CustomButton.Location = new System.Drawing.Point(225, 2);
            this.txtchequeno.CustomButton.Name = "";
            this.txtchequeno.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtchequeno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtchequeno.CustomButton.TabIndex = 1;
            this.txtchequeno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtchequeno.CustomButton.UseSelectable = true;
            this.txtchequeno.CustomButton.Visible = false;
            this.txtchequeno.Lines = new string[0];
            this.txtchequeno.Location = new System.Drawing.Point(65, 169);
            this.txtchequeno.MaxLength = 32767;
            this.txtchequeno.Name = "txtchequeno";
            this.txtchequeno.PasswordChar = '\0';
            this.txtchequeno.PromptText = "Cheque No. :";
            this.txtchequeno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtchequeno.SelectedText = "";
            this.txtchequeno.SelectionLength = 0;
            this.txtchequeno.SelectionStart = 0;
            this.txtchequeno.ShortcutsEnabled = true;
            this.txtchequeno.Size = new System.Drawing.Size(263, 40);
            this.txtchequeno.TabIndex = 0;
            this.txtchequeno.UseSelectable = true;
            this.txtchequeno.WaterMark = "Cheque No. :";
            this.txtchequeno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtchequeno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtdateofcash
            // 
            // 
            // 
            // 
            this.txtdateofcash.CustomButton.Image = null;
            this.txtdateofcash.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.txtdateofcash.CustomButton.Name = "";
            this.txtdateofcash.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtdateofcash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdateofcash.CustomButton.TabIndex = 1;
            this.txtdateofcash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdateofcash.CustomButton.UseSelectable = true;
            this.txtdateofcash.CustomButton.Visible = false;
            this.txtdateofcash.Lines = new string[0];
            this.txtdateofcash.Location = new System.Drawing.Point(754, 106);
            this.txtdateofcash.MaxLength = 32767;
            this.txtdateofcash.Name = "txtdateofcash";
            this.txtdateofcash.PasswordChar = '\0';
            this.txtdateofcash.PromptText = "Date of cash:";
            this.txtdateofcash.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdateofcash.SelectedText = "";
            this.txtdateofcash.SelectionLength = 0;
            this.txtdateofcash.SelectionStart = 0;
            this.txtdateofcash.ShortcutsEnabled = true;
            this.txtdateofcash.Size = new System.Drawing.Size(131, 40);
            this.txtdateofcash.TabIndex = 1;
            this.txtdateofcash.UseSelectable = true;
            this.txtdateofcash.WaterMark = "Date of cash:";
            this.txtdateofcash.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdateofcash.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CMB
            // 
            this.CMB.DisplayMember = "Bank id";
            this.CMB.FormattingEnabled = true;
            this.CMB.ItemHeight = 24;
            this.CMB.Location = new System.Drawing.Point(230, 106);
            this.CMB.Name = "CMB";
            this.CMB.PromptText = "Party Name";
            this.CMB.Size = new System.Drawing.Size(121, 30);
            this.CMB.TabIndex = 4;
            this.CMB.UseSelectable = true;
            this.CMB.SelectedIndexChanged += new System.EventHandler(this.CMB_SelectedIndexChanged);
            // 
            // CDO
            // 
            this.CDO.FormattingEnabled = true;
            this.CDO.ItemHeight = 24;
            this.CDO.Location = new System.Drawing.Point(477, 106);
            this.CDO.Name = "CDO";
            this.CDO.PromptText = "Bank Name";
            this.CDO.Size = new System.Drawing.Size(121, 30);
            this.CDO.TabIndex = 5;
            this.CDO.UseSelectable = true;
            this.CDO.SelectedIndexChanged += new System.EventHandler(this.CDO_SelectedIndexChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoSize = true;
            this.metroPanel1.BackColor = System.Drawing.Color.Silver;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.CMB1);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.txtamount);
            this.metroPanel1.Controls.Add(this.txtdateofcash);
            this.metroPanel1.Controls.Add(this.txtentrydate);
            this.metroPanel1.Controls.Add(this.CDO);
            this.metroPanel1.Controls.Add(this.CMB);
            this.metroPanel1.Controls.Add(this.txtchequeno);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(888, 479);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // CMB1
            // 
            this.CMB1.FormattingEnabled = true;
            this.CMB1.ItemHeight = 24;
            this.CMB1.Location = new System.Drawing.Point(74, 106);
            this.CMB1.Name = "CMB1";
            this.CMB1.Size = new System.Drawing.Size(121, 30);
            this.CMB1.TabIndex = 16;
            this.CMB1.UseSelectable = true;
            this.CMB1.SelectedIndexChanged += new System.EventHandler(this.CMB1_SelectedIndexChanged);
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.DimGray;
            this.metroPanel3.Controls.Add(this.metroButton1);
            this.metroPanel3.Controls.Add(this.metroButton2);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 377);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(886, 100);
            this.metroPanel3.TabIndex = 15;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroButton1.Location = new System.Drawing.Point(712, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(87, 100);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroButton2.Location = new System.Drawing.Point(799, 0);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(87, 100);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.DimGray;
            this.metroPanel2.Controls.Add(this.metroButton3);
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(886, 100);
            this.metroPanel2.TabIndex = 14;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel2_Paint);
            // 
            // metroButton3
            // 
            this.metroButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroButton3.Location = new System.Drawing.Point(767, 0);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(119, 100);
            this.metroButton3.TabIndex = 18;
            this.metroButton3.Text = "Close";
            this.metroButton3.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 70);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "CHEQUE ENTRY";
            // 
            // txtamount
            // 
            // 
            // 
            // 
            this.txtamount.CustomButton.Image = null;
            this.txtamount.CustomButton.Location = new System.Drawing.Point(476, 2);
            this.txtamount.CustomButton.Name = "";
            this.txtamount.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtamount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtamount.CustomButton.TabIndex = 1;
            this.txtamount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtamount.CustomButton.UseSelectable = true;
            this.txtamount.CustomButton.Visible = false;
            this.txtamount.Lines = new string[0];
            this.txtamount.Location = new System.Drawing.Point(158, 237);
            this.txtamount.MaxLength = 32767;
            this.txtamount.Name = "txtamount";
            this.txtamount.PasswordChar = '\0';
            this.txtamount.PromptText = "Amount :";
            this.txtamount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtamount.SelectedText = "";
            this.txtamount.SelectionLength = 0;
            this.txtamount.SelectionStart = 0;
            this.txtamount.ShortcutsEnabled = true;
            this.txtamount.Size = new System.Drawing.Size(514, 40);
            this.txtamount.TabIndex = 11;
            this.txtamount.UseSelectable = true;
            this.txtamount.WaterMark = "Amount :";
            this.txtamount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtamount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtentrydate
            // 
            // 
            // 
            // 
            this.txtentrydate.CustomButton.Image = null;
            this.txtentrydate.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.txtentrydate.CustomButton.Name = "";
            this.txtentrydate.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtentrydate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtentrydate.CustomButton.TabIndex = 1;
            this.txtentrydate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtentrydate.CustomButton.UseSelectable = true;
            this.txtentrydate.CustomButton.Visible = false;
            this.txtentrydate.Lines = new string[0];
            this.txtentrydate.Location = new System.Drawing.Point(524, 169);
            this.txtentrydate.MaxLength = 32767;
            this.txtentrydate.Name = "txtentrydate";
            this.txtentrydate.PasswordChar = '\0';
            this.txtentrydate.PromptText = "Entry Date :";
            this.txtentrydate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtentrydate.SelectedText = "";
            this.txtentrydate.SelectionLength = 0;
            this.txtentrydate.SelectionStart = 0;
            this.txtentrydate.ShortcutsEnabled = true;
            this.txtentrydate.Size = new System.Drawing.Size(240, 40);
            this.txtentrydate.TabIndex = 2;
            this.txtentrydate.UseSelectable = true;
            this.txtentrydate.WaterMark = "Entry Date :";
            this.txtentrydate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtentrydate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(888, 479);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtchequeno;
        private MetroFramework.Controls.MetroTextBox txtdateofcash;
        private MetroFramework.Controls.MetroComboBox CMB;
        private MetroFramework.Controls.MetroComboBox CDO;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtamount;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroComboBox CMB1;
        private MetroFramework.Controls.MetroTextBox txtentrydate;
    }
}

namespace CG_trader
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txttelephone = new System.Windows.Forms.TextBox();
            this.txtpartyaddress = new System.Windows.Forms.TextBox();
            this.txtpartyname = new System.Windows.Forms.TextBox();
            this.txtpartyid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnlogout);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.txtuserid);
            this.groupBox1.Controls.Add(this.txttelephone);
            this.groupBox1.Controls.Add(this.txtpartyaddress);
            this.groupBox1.Controls.Add(this.txtpartyname);
            this.groupBox1.Controls.Add(this.txtpartyid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "Party Entry";
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.LightSalmon;
            this.btnlogout.ForeColor = System.Drawing.Color.Green;
            this.btnlogout.Location = new System.Drawing.Point(368, 0);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 43);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(54, 321);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 38);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(113, 273);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(100, 22);
            this.txtuserid.TabIndex = 1;
            // 
            // txttelephone
            // 
            this.txttelephone.Location = new System.Drawing.Point(113, 224);
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(100, 22);
            this.txttelephone.TabIndex = 1;
            // 
            // txtpartyaddress
            // 
            this.txtpartyaddress.Location = new System.Drawing.Point(113, 178);
            this.txtpartyaddress.Name = "txtpartyaddress";
            this.txtpartyaddress.Size = new System.Drawing.Size(100, 22);
            this.txtpartyaddress.TabIndex = 1;
            // 
            // txtpartyname
            // 
            this.txtpartyname.Location = new System.Drawing.Point(113, 126);
            this.txtpartyname.Name = "txtpartyname";
            this.txtpartyname.Size = new System.Drawing.Size(100, 22);
            this.txtpartyname.TabIndex = 1;
            // 
            // txtpartyid
            // 
            this.txtpartyid.Location = new System.Drawing.Point(113, 76);
            this.txtpartyid.Name = "txtpartyid";
            this.txtpartyid.Size = new System.Drawing.Size(100, 22);
            this.txtpartyid.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "user_id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "telephone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "party_address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "party_name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "party_id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 380);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txttelephone;
        private System.Windows.Forms.TextBox txtpartyaddress;
        private System.Windows.Forms.TextBox txtpartyname;
        private System.Windows.Forms.TextBox txtpartyid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}
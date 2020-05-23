namespace Multi_SSH
{
    partial class UeberUns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UeberUns));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkHomepage = new System.Windows.Forms.LinkLabel();
            this.programmName = new System.Windows.Forms.Label();
            this.ueberProgramm = new System.Windows.Forms.Label();
            this.homepage = new System.Windows.Forms.Label();
            this.xing = new System.Windows.Forms.Label();
            this.linkXing = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Multi_SSH.Properties.Resources.ProfileBild;
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkHomepage
            // 
            this.linkHomepage.AutoSize = true;
            this.linkHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHomepage.Location = new System.Drawing.Point(341, 186);
            this.linkHomepage.Name = "linkHomepage";
            this.linkHomepage.Size = new System.Drawing.Size(168, 17);
            this.linkHomepage.TabIndex = 1;
            this.linkHomepage.TabStop = true;
            this.linkHomepage.Text = "https://michael-bedros.de";
            this.linkHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // programmName
            // 
            this.programmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmName.Location = new System.Drawing.Point(254, 10);
            this.programmName.Name = "programmName";
            this.programmName.Size = new System.Drawing.Size(329, 29);
            this.programmName.TabIndex = 2;
            this.programmName.Text = "Programs Name";
            // 
            // ueberProgramm
            // 
            this.ueberProgramm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ueberProgramm.Location = new System.Drawing.Point(254, 72);
            this.ueberProgramm.Name = "ueberProgramm";
            this.ueberProgramm.Size = new System.Drawing.Size(329, 94);
            this.ueberProgramm.TabIndex = 3;
            this.ueberProgramm.Text = "Über das Programm";
            // 
            // homepage
            // 
            this.homepage.AutoSize = true;
            this.homepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepage.Location = new System.Drawing.Point(254, 186);
            this.homepage.Name = "homepage";
            this.homepage.Size = new System.Drawing.Size(81, 17);
            this.homepage.TabIndex = 4;
            this.homepage.Text = "Homepage:";
            // 
            // xing
            // 
            this.xing.AutoSize = true;
            this.xing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xing.Location = new System.Drawing.Point(295, 213);
            this.xing.Name = "xing";
            this.xing.Size = new System.Drawing.Size(40, 17);
            this.xing.TabIndex = 5;
            this.xing.Text = "Xing:";
            // 
            // linkXing
            // 
            this.linkXing.AutoSize = true;
            this.linkXing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkXing.Location = new System.Drawing.Point(341, 213);
            this.linkXing.Name = "linkXing";
            this.linkXing.Size = new System.Drawing.Size(289, 17);
            this.linkXing.TabIndex = 6;
            this.linkXing.TabStop = true;
            this.linkXing.Text = "https://www.xing.com/profile/Michael_Bedros/";
            this.linkXing.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // UeberUns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(638, 261);
            this.Controls.Add(this.linkXing);
            this.Controls.Add(this.xing);
            this.Controls.Add(this.homepage);
            this.Controls.Add(this.ueberProgramm);
            this.Controls.Add(this.programmName);
            this.Controls.Add(this.linkHomepage);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UeberUns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Über uns";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkHomepage;
        private System.Windows.Forms.Label programmName;
        private System.Windows.Forms.Label ueberProgramm;
        private System.Windows.Forms.Label homepage;
        private System.Windows.Forms.Label xing;
        private System.Windows.Forms.LinkLabel linkXing;
    }
}
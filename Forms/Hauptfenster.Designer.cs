namespace Multi_SSH
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hauptfenster));
            this.dataGridViewCsv = new System.Windows.Forms.DataGridView();
            this.Hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.befehleListBox = new System.Windows.Forms.ListBox();
            this.ergebnisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.importHostsButton = new System.Windows.Forms.Button();
            this.importBefehleButton = new System.Windows.Forms.Button();
            this.ausfuehrenButton = new System.Windows.Forms.Button();
            this.speichernButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überUnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entleerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCsv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCsv
            // 
            this.dataGridViewCsv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hostname,
            this.Username,
            this.Password});
            this.dataGridViewCsv.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewCsv.Name = "dataGridViewCsv";
            this.dataGridViewCsv.Size = new System.Drawing.Size(470, 249);
            this.dataGridViewCsv.TabIndex = 1;
            // 
            // Hostname
            // 
            this.Hostname.Frozen = true;
            this.Hostname.HeaderText = "Hostname";
            this.Hostname.Name = "Hostname";
            // 
            // Username
            // 
            this.Username.Frozen = true;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.Frozen = true;
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // befehleListBox
            // 
            this.befehleListBox.FormattingEnabled = true;
            this.befehleListBox.Location = new System.Drawing.Point(500, 27);
            this.befehleListBox.Name = "befehleListBox";
            this.befehleListBox.Size = new System.Drawing.Size(470, 251);
            this.befehleListBox.TabIndex = 2;
            // 
            // ergebnisRichTextBox
            // 
            this.ergebnisRichTextBox.Location = new System.Drawing.Point(12, 313);
            this.ergebnisRichTextBox.Name = "ergebnisRichTextBox";
            this.ergebnisRichTextBox.Size = new System.Drawing.Size(958, 224);
            this.ergebnisRichTextBox.TabIndex = 3;
            this.ergebnisRichTextBox.Text = "";
            // 
            // importHostsButton
            // 
            this.importHostsButton.Location = new System.Drawing.Point(12, 284);
            this.importHostsButton.Name = "importHostsButton";
            this.importHostsButton.Size = new System.Drawing.Size(470, 23);
            this.importHostsButton.TabIndex = 4;
            this.importHostsButton.Text = "Import Hosts (.csv)";
            this.importHostsButton.UseVisualStyleBackColor = true;
            this.importHostsButton.Click += new System.EventHandler(this.importHostsButton_Click);
            // 
            // importBefehleButton
            // 
            this.importBefehleButton.Location = new System.Drawing.Point(500, 284);
            this.importBefehleButton.Name = "importBefehleButton";
            this.importBefehleButton.Size = new System.Drawing.Size(470, 23);
            this.importBefehleButton.TabIndex = 5;
            this.importBefehleButton.Text = "Import Befehle (.txt)";
            this.importBefehleButton.UseVisualStyleBackColor = true;
            this.importBefehleButton.Click += new System.EventHandler(this.importBefehleButton_Click);
            // 
            // ausfuehrenButton
            // 
            this.ausfuehrenButton.Location = new System.Drawing.Point(12, 572);
            this.ausfuehrenButton.Name = "ausfuehrenButton";
            this.ausfuehrenButton.Size = new System.Drawing.Size(470, 23);
            this.ausfuehrenButton.TabIndex = 6;
            this.ausfuehrenButton.Text = "Ausführen";
            this.ausfuehrenButton.UseVisualStyleBackColor = true;
            this.ausfuehrenButton.Click += new System.EventHandler(this.ausfuehrenButton_Click);
            // 
            // speichernButton
            // 
            this.speichernButton.Location = new System.Drawing.Point(500, 572);
            this.speichernButton.Name = "speichernButton";
            this.speichernButton.Size = new System.Drawing.Size(467, 23);
            this.speichernButton.TabIndex = 7;
            this.speichernButton.Text = "Ergebnis speichern";
            this.speichernButton.UseVisualStyleBackColor = true;
            this.speichernButton.Click += new System.EventHandler(this.speichernButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 543);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(955, 23);
            this.progressBar.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entleerenToolStripMenuItem,
            this.überUnsToolStripMenuItem,
            this.schließenToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // überUnsToolStripMenuItem
            // 
            this.überUnsToolStripMenuItem.Name = "überUnsToolStripMenuItem";
            this.überUnsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.überUnsToolStripMenuItem.Text = "Über uns";
            this.überUnsToolStripMenuItem.Click += new System.EventHandler(this.UeberUnsToolStripMenuItem_Click);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.SchliessenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.HilfeToolStripMenuItem_Click);
            // 
            // entleerenToolStripMenuItem
            // 
            this.entleerenToolStripMenuItem.Name = "entleerenToolStripMenuItem";
            this.entleerenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entleerenToolStripMenuItem.Text = "Entleeren";
            this.entleerenToolStripMenuItem.Click += new System.EventHandler(this.EntleerenToolStripMenuItem_Click);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(979, 601);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.speichernButton);
            this.Controls.Add(this.ausfuehrenButton);
            this.Controls.Add(this.importBefehleButton);
            this.Controls.Add(this.importHostsButton);
            this.Controls.Add(this.ergebnisRichTextBox);
            this.Controls.Add(this.befehleListBox);
            this.Controls.Add(this.dataGridViewCsv);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Hauptfenster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSH Multi Server";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCsv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCsv;
        private System.Windows.Forms.ListBox befehleListBox;
        private System.Windows.Forms.RichTextBox ergebnisRichTextBox;
        private System.Windows.Forms.Button importHostsButton;
        private System.Windows.Forms.Button importBefehleButton;
        private System.Windows.Forms.Button ausfuehrenButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überUnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entleerenToolStripMenuItem;
    }
}


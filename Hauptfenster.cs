using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Renci.SshNet;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace Multi_SSH
{
    #region Hauptfenster
    public partial class Hauptfenster : Form
    {
        #region Forms
        public Hauptfenster()
        {
            InitializeComponent();

        }
        #endregion

        #region Menu
        private void UeberUnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UeberUns ueberUns = new UeberUns();
            ueberUns.Show();
        }
        private void SchliessenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\OneDrive - Stadt Köln\Abschlussprojekt\Multi-SSH\Multi-SSH\Resources\User-Manual.pdf");
        }
        private void EntleerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int counterDataView = dataGridViewCsv.RowCount - 2;
            for (int i = counterDataView; i >= 0; i--)
            {
                dataGridViewCsv.Rows.RemoveAt(i);
            }
            befehleListBox.Items.Clear();
            ergebnisRichTextBox.Clear();
            progressBar.Value = 1;

        }
        #endregion

        #region Buttons
        private void importHostsButton_Click(object sender, EventArgs e)
        {
            ImportHostToData();
        }
        private void importBefehleButton_Click(object sender, EventArgs e)
        {
            ImportCommandsToList();
        }
        private void ausfuehrenButton_Click(object sender, EventArgs e)
        {
            RunTheCommands();
        }
        private void speichernButton_Click(object sender, EventArgs e)
        {
            ExportResultToFile();
        }

        #endregion

        #region Import Hosts
        private void ImportHostToData()
        {
            try
            {
                #region variables
                OpenFileDialog openFile;
                ImportCsv csv;
                #endregion

                #region Open File
                openFile = new OpenFileDialog();
                openFile.Filter = "CSV files (*.csv)|*.csv";
                openFile.Title = "Import der Hosts";
                #endregion

                #region Import CSV To DataView
                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile.FileName.Length > 0)
                {
                    dataGridViewCsv.Columns.Clear();
                    csv = new ImportCsv(openFile.FileName);
                    dataGridViewCsv.DataSource = csv.importCsv;
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Import Commands
        private void ImportCommandsToList()
        {
            try
            {
                #region variables
                OpenFileDialog openFile;
                #endregion

                #region Open File
                openFile = new OpenFileDialog();
                openFile.Filter = "TXT files (*.txt)|*.txt";
                openFile.Title = "Import der Befehlen";
                #endregion

                #region Import
                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile.FileName.Length > 0)
                {
                    string[] lines = File.ReadAllLines(openFile.FileName);

                    foreach (string line in lines)
                    {
                        befehleListBox.Items.Add(line);
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Run The Commands
        private void RunTheCommands()
        {
            try
            {

                #region Progress Bar
                progressBar.Value = 1;
                progressBar.Minimum = 1;
                progressBar.Maximum = dataGridViewCsv.Rows.Count;
                progressBar.Step = 1;
                #endregion
                #region Import To DataView
                dataGridViewCsv.Rows[0].Selected = true;
                if (dataGridViewCsv.SelectedCells.Count > 0)
                {

                    for (int i = 0; i < dataGridViewCsv.Rows.Count - 1; i++)
                    {
                        dataGridViewCsv.Rows[i].Selected = true;
                        dataGridViewCsv.Refresh();
                        Ping ping = new Ping();

                        string hostname = dataGridViewCsv.SelectedCells[0].Value.ToString();
                        string username = dataGridViewCsv.SelectedCells[1].Value.ToString();
                        string password = dataGridViewCsv.SelectedCells[2].Value.ToString();

                        PingReply pingHost = ping.Send(hostname);
                        if (pingHost.Status.ToString().Equals("Success"))
                        {
                            var client = new SshClient(hostname, username, password);

                            client.Connect();
                            ergebnisRichTextBox.SelectionColor = Color.Blue;
                            ergebnisRichTextBox.SelectionFont = new Font("Tahoma", 18, FontStyle.Regular);
                            ergebnisRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                            ergebnisRichTextBox.AppendText($"------------------------------ {hostname}------------------------------\n");

                            for (int w = 0; w < befehleListBox.Items.Count; w++)
                            {

                                var comando = client.RunCommand(befehleListBox.Items[w].ToString());
                                ergebnisRichTextBox.SelectionColor = Color.Blue;
                                ergebnisRichTextBox.SelectionFont = new Font("Tahoma", 10, FontStyle.Regular);
                                ergebnisRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
                                ergebnisRichTextBox.AppendText($"Command: " + comando.CommandText+"\n");
                                ergebnisRichTextBox.SelectionColor = Color.Green;
                                ergebnisRichTextBox.SelectionFont = new Font("Tahoma", 10, FontStyle.Regular);
                                ergebnisRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
                                ergebnisRichTextBox.AppendText(comando.Result);
                            }


                            //richTextBox1.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);


                            client.Disconnect();
                        }
                        else
                        {
                            ergebnisRichTextBox.SelectionColor = Color.Red;
                            ergebnisRichTextBox.SelectionFont = new Font("Tahoma", 18, FontStyle.Regular);
                            ergebnisRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                            ergebnisRichTextBox.AppendText($"------------------------------ {hostname}------------------------------\n");
                            ergebnisRichTextBox.SelectionFont = new Font("Tahoma", 10, FontStyle.Regular);
                            ergebnisRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
                            ergebnisRichTextBox.SelectionColor = Color.Red;
                            ergebnisRichTextBox.AppendText($"Der Host ist gerade nicht erreichbar\n");
                            MessageBox.Show($"Der Host {hostname} ist nicht erreichbar!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        dataGridViewCsv.Rows[i].Selected = false;
                        progressBar.PerformStep();
                    }

                }
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Export Result
        private void ExportResultToFile()
        {
            try
            {
                #region variables
                SaveFileDialog saveFile;
                #endregion
                #region Save File
                saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "*.rtf";
                saveFile.Filter = "RTF Files|*.rtf";
                saveFile.Title = "Export des Ergebnis";
                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile.FileName.Length > 0)
                {
                    ergebnisRichTextBox.SaveFile(saveFile.FileName);
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        
    }
    #endregion
}

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
            // Intializing the Components
            InitializeComponent();

        }
        #endregion

        #region Menu
        private void EntleerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear DataView rows
            int counterDataView = dataGridViewCsv.RowCount - 2;
            for (int i = counterDataView; i >= 0; i--)
            {
                dataGridViewCsv.Rows.RemoveAt(i);
            }
            //Clear Befehl ListBox items
            befehleListBox.Items.Clear();
            //Clear 
            ergebnisRichTextBox.Clear();
            //Reset the Progress Bar
            progressBar.Value = 1;

        }
        private void UeberUnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Go to "Über uns" windows form
            UeberUns ueberUns = new UeberUns();
            ueberUns.Show();
        }
        private void SchliessenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit the programm
            Application.Exit();
        }
        private void HilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Go to user manual file
            Process.Start(@"D:\OneDrive - Stadt Köln\Abschlussprojekt\Multi-SSH\Multi-SSH\Resources\User-Manual.pdf");
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
                //Object variable for open the file explorer
                OpenFileDialog openFile;
                //Ojekt variable for the import the hosts
                ImportCsv csv;
                #endregion

                #region Open File
                // Create a new objekt from "OpenFileDialog" class
                openFile = new OpenFileDialog();
                //Filter for impprting just csv files
                openFile.Filter = "CSV files (*.csv)|*.csv";
                //Title the file explorer
                openFile.Title = "Import der Hosts";
                #endregion

                #region Import CSV To DataView
                //Check if the user has selected a file
                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile.FileName.Length > 0)
                {
                    //Clear the list of hosts
                    dataGridViewCsv.Columns.Clear();
                    //Create a new objekt form "ImportCSV" class
                    csv = new ImportCsv(openFile.FileName);
                    //Return the import value to the list of hosts
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
                            var host = new SshClient(hostname, username, password);

                            host.Connect();
                            WriteInResult(hostname, "Hostname");

                            for (int w = 0; w < befehleListBox.Items.Count; w++)
                            {
                                var command = host.RunCommand(befehleListBox.Items[w].ToString());
                                WriteInResult(command.CommandText, "Command");
                                WriteInResult(command.Result, "Result");
                            }
                            host.Disconnect();
                        }
                        else
                        {
                            WriteInResult(hostname, "Error");
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
                //FileDialog object
                SaveFileDialog saveFile;
                #endregion
                #region Save File
                //Open filedialog to save the result
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

        #region Write in Result
        private void WriteInResult(string ausgabe, string ausgabeArt)
        {

            switch (ausgabeArt)
            {
                case "Hostname":
                    //Write the hostname into Ergebnisbox
                    ergebnisRichTextBox.SelectionColor = Color.Blue;
                    ergebnisRichTextBox.SelectionFont = new Font("Tahoma", 18, FontStyle.Regular);
                    ergebnisRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                    ergebnisRichTextBox.AppendText($"------------------------------ {ausgabe}------------------------------\n");
                    break;

                case "Command":
                    //Write the command into Ergebnisbox
                    ergebnisRichTextBox.SelectionColor = Color.Blue;
                    ergebnisRichTextBox.SelectionFont = new Font("Tahoma", 10, FontStyle.Regular);
                    ergebnisRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
                    ergebnisRichTextBox.AppendText($"Command: " + ausgabe + "\n");

                    break;
                case "Result":
                    //Write the result into Ergebnisbox
                    ergebnisRichTextBox.SelectionColor = Color.Green;
                    ergebnisRichTextBox.SelectionFont = new Font("Tahoma", 10, FontStyle.Regular);
                    ergebnisRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
                    ergebnisRichTextBox.AppendText(ausgabe);
                    break;
                case "Error":
                    //Write the error into Ergebnisbox
                    ergebnisRichTextBox.SelectionColor = Color.Red;
                    ergebnisRichTextBox.SelectionFont = new Font("Tahoma", 18, FontStyle.Regular);
                    ergebnisRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                    ergebnisRichTextBox.AppendText($"------------------------------ {ausgabe}------------------------------\n");
                    ergebnisRichTextBox.SelectionFont = new Font("Tahoma", 10, FontStyle.Regular);
                    ergebnisRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
                    ergebnisRichTextBox.SelectionColor = Color.Red;
                    ergebnisRichTextBox.AppendText($"Der Host ist gerade nicht erreichbar\n");
                    break;

            }

        }
        #endregion
    }
    #endregion
}

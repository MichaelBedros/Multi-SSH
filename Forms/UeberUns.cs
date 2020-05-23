using System.Windows.Forms;

namespace Multi_SSH
{
    public partial class UeberUns : Form
    {
        #region Forms
        public UeberUns()
        {
            InitializeComponent();

            programmName.Text = "Multi SSH v1.0";
            ueberProgramm.Text = "Dieses Programm wurde von Michael Bedros als Abschlussprojekt entweckelt.\n\n" +
                          "Für weitere Information über den Entwekler gehen Sie auf die folgende Webseite:";
            
        }
#endregion
        #region Links
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://michael-bedros.de");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.xing.com/profile/Michael_Bedros/");
        }
#endregion
    }
}

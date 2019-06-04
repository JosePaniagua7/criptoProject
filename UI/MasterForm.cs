using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Diagnostics;
using BusinessProcess;
namespace UI
{
    public partial class MasterForm : Form
    {

        private FlowProcess userWorkFlow;
        OpenFileDialog fileBrowser;
        public MasterForm()
        {
            InitializeComponent();
            this.userWorkFlow = new FlowProcess();
            fileBrowser = new OpenFileDialog();
            fileBrowser.Filter = "XML Files (*.xml)|*.xml";
            fileBrowser.FilterIndex = 0;
            fileBrowser.DefaultExt = "xml";
        }

        private void MasterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {            
            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Path is: " + fileBrowser.FileName);
                string publicKeyFromSlave=userWorkFlow.importRsaPublicKey(fileBrowser.FileName);                
                this.LabelPublicKeySlave.Text = publicKeyFromSlave;
            }            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] RsaKeys=userWorkFlow.generateRSAKeys();
            if (RsaKeys[0] == RsaKeys[1])
            {
                MessageBox.Show("They are the samee!!!!!");
            }
            this.TextBoxRsaPrivateKey.Text = RsaKeys[0];
            this.TextBoxRsaPublicKey.Text = RsaKeys[0];            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.userWorkFlow.generateTdesKeys();
        }
    }
}

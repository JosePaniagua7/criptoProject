using System;
using System.Windows.Forms;
using BusinessProcess;
namespace UI
{
    public partial class MasterForm : Form
    {

        private MasterWorkFlow userWorkFlow;
        OpenFileDialog fileBrowser;
        public MasterForm()
        {
            InitializeComponent();
            this.userWorkFlow = new MasterWorkFlow();
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
                string publicKeyFromSlave=userWorkFlow.importRsaPublicKey(fileBrowser.FileName);                
                this.LabelPublicKeySlave.Text = publicKeyFromSlave;
                this.button3.Enabled = true;
                this.button3.Focus();
            }            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] RsaKeys=userWorkFlow.generateRSAKeys();            
            this.TextBoxRsaPrivateKey.Text = RsaKeys[0];
            this.TextBoxRsaPublicKey.Text = RsaKeys[0];
            this.button2.Enabled = true;
            this.button2.Focus();
        }

        private void Button3_Click(object sender, EventArgs e)
        {    
            string tdesKey= this.userWorkFlow.generateTdesKeys();            
            this.LabelTdesKey.Text = tdesKey;
            this.button4.Enabled = true;
            this.button4.Focus();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string[] tdesEncryptedKeys = this.userWorkFlow.encryptTdesKeys();
            LabelTdes1Encrypted.Text = tdesEncryptedKeys[0];
            LabelTdes2Encrypted.Text = tdesEncryptedKeys[1];
            LabelTdes3Encrypted.Text = tdesEncryptedKeys[2];
            this.button7.Enabled = true;
            this.button7.Focus();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {                
                this.LabelEncryptedText.Text = this.userWorkFlow.importEncryptedMessage(fileBrowser.FileName);
                this.button6.Enabled = true;
                this.button6.Focus();
            }            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //Let's disable all the setting from the file selector
            //So that, we can choose the path to export our file
            fileBrowser.ValidateNames = false;
            fileBrowser.CheckFileExists = false;
            fileBrowser.CheckPathExists = true;            
            fileBrowser.FileName = "tdesencriptado.xml";

            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {                
                this.userWorkFlow.exportTdesKeysToXml(fileBrowser.FileName);
                this.button5.Enabled = true;
                this.button5.Focus();
            }            
            //Finally, let's able all the functionality again
            fileBrowser.ValidateNames = true;
            fileBrowser.CheckFileExists = true;                        
            fileBrowser.FileName = "";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            LabelDecryptedText.Text = this.userWorkFlow.decryptMessage();            
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido Maestro, los botones se iran desbloqueando a medida que avances en el proceso");
        }
    }
}

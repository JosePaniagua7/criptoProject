using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessProcess;

namespace UI
{
    public partial class SlaveForm : Form
    {
        private OpenFileDialog fileBrowser;
        private SlaveWorkFlow userWorkFlow;
        public SlaveForm()
        {
            InitializeComponent();
            this.userWorkFlow = new SlaveWorkFlow();

            fileBrowser = new OpenFileDialog();
            fileBrowser.Filter = "XML Files (*.xml)|*.xml";
            fileBrowser.FilterIndex = 0;
            fileBrowser.DefaultExt = "xml";
            
        }

        private void SlaveForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {                       
            this.fileBrowser.ValidateNames = false;
            this.fileBrowser.CheckFileExists = false;
            this.fileBrowser.CheckPathExists = true;
            this.fileBrowser.FileName = "cp_esclavo.xml";
            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                this.userWorkFlow.exportRsaPublicKey(fileBrowser.FileName);
                this.button3.Enabled = true;
                this.button3.Focus();
            }
            this.fileBrowser.ValidateNames = true;
            this.fileBrowser.CheckFileExists = true;
            this.fileBrowser.CheckPathExists = true;
            this.fileBrowser.FileName = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                string [] tdesKeys=this.userWorkFlow.importTdesKeys(fileBrowser.FileName);                
                this.LabelEncryptedTdes1.Text = tdesKeys[0];
                this.LabelEncryptedTdes2.Text = tdesKeys[1];
                this.LabelEncryptedTdes3.Text = tdesKeys[2];
                this.userWorkFlow.importInitializationVector(fileBrowser.FileName);
                this.button4.Enabled = true;
                this.button4.Focus();
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] rsaKeys = this.userWorkFlow.generateRSAKeys();
            this.TextBoxRsaPrivateKey.Text = rsaKeys[0];
            this.TextBoxRsaPublicKey.Text = rsaKeys[1];
            this.button2.Enabled = true;
            this.button2.Focus();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.LabelDecryptedText.Text = this.userWorkFlow.decryptTdesKey();
            this.button5.Enabled = true;
            this.button5.Focus();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string text = this.MessageTextBox.Text;
            if (text.Trim().Length>0)
            {
                string encrytpedText = this.userWorkFlow.encryptMessage(this.MessageTextBox.Text);
                this.LabelEncryptedText.Text = encrytpedText;
                this.button6.Enabled = true;
                this.button6.Focus();
            }else {
                MessageBox.Show("There is no text to encrypt");
            }
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.fileBrowser.ValidateNames = false;
            this.fileBrowser.CheckFileExists = false;
            this.fileBrowser.CheckPathExists = true;
            this.fileBrowser.FileName = "textoencriptado.xml";
            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                this.userWorkFlow.exportEncryptedMessage(fileBrowser.FileName);
            }
            this.fileBrowser.ValidateNames = true;
            this.fileBrowser.CheckFileExists = true;
            this.fileBrowser.CheckPathExists = true;
            this.fileBrowser.FileName = "";
        }

        private void SlaveForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido Esclavo, los botones se iran desbloqueando a medida que avances en el proceso");
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class SlaveForm : Form
    {
        OpenFileDialog fileBrowser;
        public SlaveForm()
        {
            InitializeComponent();
            fileBrowser = new OpenFileDialog();
        }

        private void SlaveForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {            
            OpenFileDialog folderBrowser = new OpenFileDialog();
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                //string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                MessageBox.Show("The path is: " + folderBrowser.FileName);
                // ...
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}


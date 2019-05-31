using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Diagnostics;

namespace UI
{
    public partial class MasterForm : Form
    {        
                
        
        public MasterForm()
        {
            InitializeComponent();
        }

        private void MasterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("El path es: " + openFileDialog1.FileName);                
            }
            else
            {
                MessageBox.Show("No file has been selected: ");
            }
        }
        
    }
}

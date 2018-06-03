using System;
using System.Windows.Forms;
using CopyDirectory.BL;

namespace CopyDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCopyFiles_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateDirectories();
                
                FileManipulation.CopyDirectory(txtSource.Text, txtTarget.Text, OnProgressListener);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidateDirectories()
        {
            if (string.IsNullOrWhiteSpace(txtSource.Text) || string.IsNullOrWhiteSpace(txtTarget.Text))
                throw new Exception("Please select source and target directories.");
        }
        
        private void btnSource_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtTarget.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void OnProgressListener(string strLog)
        {
            log.Items.Insert(0, strLog);
        }
    }
}

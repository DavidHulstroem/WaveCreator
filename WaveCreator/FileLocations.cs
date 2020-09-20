using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaveCreator
{
    public partial class FileLocations : Form
    {

        public FileLocations()
        {
            InitializeComponent();


            if (Form1.saveLocation != "")
            {
                SaveLoc.Text = Form1.saveLocation;
                folderBrowserDialog2.SelectedPath = Form1.saveLocation;
            }
            if (Form1.streamingAssetsDirectory != "")
            {
                StreamLoc.Text = Form1.streamingAssetsDirectory;
                folderBrowserDialog1.SelectedPath = Form1.streamingAssetsDirectory;
            }

            Save.DialogResult = DialogResult.OK;
        }

        private void FindStreamLoc_Click(object sender, EventArgs e)
        {
            

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamLoc.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void FindSaveLoc_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                SaveLoc.Text = folderBrowserDialog2.SelectedPath;
            }
        }
    }
}

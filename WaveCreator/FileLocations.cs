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
        public string StreamLocSt;
        public string SaveLocSt;

        public FileLocations()
        {
            InitializeComponent();

            Save.DialogResult = DialogResult.OK;
        }

        private void FindStreamLoc_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamLocSt = folderBrowserDialog1.SelectedPath;
                StreamLoc.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void FindSaveLoc_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                SaveLocSt = folderBrowserDialog2.SelectedPath;
                SaveLoc.Text = folderBrowserDialog2.SelectedPath;
            }
        }
    }
}

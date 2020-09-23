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
        }

        private void FindStreamLoc_Click(object sender, EventArgs e)
        {
            

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!folderBrowserDialog1.SelectedPath.Contains("StreamingAssets"))
                {
                    DialogResult dialogResult = MessageBox.Show("Selected location might not be your streaming assets, would you like to continue?", "Warining", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        StreamLoc.Text = folderBrowserDialog1.SelectedPath;
                    } else
                    {
                        return;
                    }

                } else
                {
                    StreamLoc.Text = folderBrowserDialog1.SelectedPath;
                }

                
            }
        }

        private void FindSaveLoc_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                SaveLoc.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveLoc.Text != "")
            {
                if (!System.IO.Directory.Exists(SaveLoc.Text))
                {
                    MessageBox.Show("The selected save location is not valid. Maybe it isn't an existing location?");
                    return;
                }

                if (StreamLoc.Text != "")
                {
                    if (!StreamLoc.Text.Contains("StreamingAssets"))
                    {
                        DialogResult dialogResult = MessageBox.Show("Selected location might not be your streaming assets, would you like to continue?", "Warining", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                    }

                    if (!System.IO.Directory.Exists(StreamLoc.Text))
                    {
                        MessageBox.Show("The selected streamingassets location is not valid. Maybe it isn't an existing location?");
                        return;
                    }

                    this.DialogResult = DialogResult.OK;
                }
            }  
        }
    }
}

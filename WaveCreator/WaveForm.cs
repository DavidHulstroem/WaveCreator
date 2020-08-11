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
    public partial class WaveForm : Form
    {
        public WaveForm()
        {
            InitializeComponent();
        }

        private void WaveForm_Load(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.OK;
        }
    }
}

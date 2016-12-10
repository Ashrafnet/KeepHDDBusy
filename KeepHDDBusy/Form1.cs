using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepHDDBusy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hide();
            if (_Enabled)
            {
                var app_path = Path.Combine(Application.StartupPath, "KeepHDDBusy.txt");
                File.WriteAllText(app_path, "Just to Keep Hard Disk busy and working..");
            }
        }
        bool _Enabled = true;
        private void enabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Enabled = !_Enabled;
            enabledToolStripMenuItem.Checked = _Enabled;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryManager
{
    public partial class Form1 : Form
    {
        PowerStatus power = SystemInformation.PowerStatus;

        public Form1()
        {
            InitializeComponent();
            TrayMenuContext();

            this.ShowInTaskbar = false;

            SystemEvents.PowerModeChanged += new PowerModeChangedEventHandler(SystemEvents_PowerModeChanged);

        }

        void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            label1.Text = ((int)(power.BatteryLifePercent * 100)).ToString();
        }

        private void TrayMenuContext()
        {
            this.notifyIcon1.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.notifyIcon1.ContextMenuStrip.Items.Add("Show", null, this.MenuShow_Click);
            this.notifyIcon1.ContextMenuStrip.Items.Add("Exit", null, this.MenuExit_Click);
        }

        void MenuExit_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        void MenuShow_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GlavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}

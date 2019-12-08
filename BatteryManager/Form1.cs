using BatteryManager.Classes;
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
            switch (Controller.ActiveForm)
            {
                case 1:
                    Controller.form1.Show();
                    break;
                case 2:
                    Controller.form2.Show();
                    break;
                case 3:
                    Controller.form3.Show();
                    break;
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Controller.form2 == null)
            {
                Controller.form2 = new Form2();
            }
            Controller.ActiveForm = 2;
            Controller.form2.Location = this.Location;
            Controller.form2.Show();

            this.Hide();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Controller.form3 == null)
            {
                Controller.form3 = new Form3();
            }
            Controller.ActiveForm = 3;
            Controller.form3.Location = this.Location;
            Controller.form3.Show();

            this.Hide();
        }
    }
}

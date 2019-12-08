using BatteryManager.Classes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private PowerLineStatus lastStatus = SystemInformation.PowerStatus.PowerLineStatus;

        public Form1()
        {
            InitializeComponent();
            TrayMenuContext();

            this.ShowInTaskbar = false;

            SystemEvents.PowerModeChanged += OnPowerModeChanged;

        }

        private void OnPowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            var newStatus = SystemInformation.PowerStatus.PowerLineStatus;

            if (e.Mode == PowerModes.StatusChange && newStatus != lastStatus)
            {

                switch (newStatus)
                {
                    case PowerLineStatus.Online:
                        DisablePowerSaving();

                        lastStatus = newStatus;
                        break;
                    case PowerLineStatus.Offline:
                        EnablePowerSaving();

                        lastStatus = newStatus;
                        break;
                    case PowerLineStatus.Unknown:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void EnablePowerSaving()
        {
            RunCmdCommand("powercfg /s a1841308-3541-4fab-bc81-f71556f20b4a");

        }

        private void DisablePowerSaving()
        {
            RunCmdCommand("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
        }
        
        private void NormalPowerSaving()
        {
            RunCmdCommand("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e");
        }

        private void RunCmdCommand(string command)
        {
            var cmd = new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                }
            };
            cmd.Start();

            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
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

        void Resfresh()
        {

        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            this.notifyIcon1.Text = "Уровень заряда батареи " + ((int)(power.BatteryLifePercent * 100)).ToString() +"%";
        }
    }
}

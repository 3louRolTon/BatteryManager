using BatteryManager.Classes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryManager
{
    public partial class Form1 : Form
    {
        ManagementClass wmi = new ManagementClass("Win32_Battery");
        PowerStatus power = SystemInformation.PowerStatus;
        private PowerLineStatus lastStatus = SystemInformation.PowerStatus.PowerLineStatus;

        System.Management.ObjectQuery query;
        ManagementObjectSearcher searcher;
        ManagementObjectCollection collection;

        public Form1()
        {
            InitializeComponent();
            TrayMenuContext();

            this.ShowInTaskbar = false;

            query = new ObjectQuery("Select * FROM Win32_Battery");
            searcher = new ManagementObjectSearcher(query);

            TextRefresh();

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

        public void TextRefresh()
        {
            collection = searcher.Get();
            foreach (ManagementObject mo in collection)
            {
                foreach (PropertyData property in mo.Properties)
                {
                    switch (property.Name)
                    {
                        case "Availability":
                            switch (Convert.ToInt32(property.Value))
                            {
                                case 1:
                                    AvailabilityBattery.Text = "Other";
                                    break;
                                case 2:
                                    AvailabilityBattery.Text = "Unknown";
                                    break;
                                case 3:
                                    AvailabilityBattery.Text = "Running/Full Power";
                                    break;
                                case 4:
                                    AvailabilityBattery.Text = "Warning";
                                    break;
                                case 5:
                                    AvailabilityBattery.Text = "In Test";
                                    break;
                                case 6:
                                    AvailabilityBattery.Text = "Not Applicable";
                                    break;
                                case 7:
                                    AvailabilityBattery.Text = "Power Off";
                                    break;
                                case 8:
                                    AvailabilityBattery.Text = "Off Line";
                                    break;
                                case 9:
                                    AvailabilityBattery.Text = "Off Duty";
                                    break;
                                case 10:
                                    AvailabilityBattery.Text = "Degraded";
                                    break;
                                case 11:
                                    AvailabilityBattery.Text = "Not Installed";
                                    break;
                                case 12:
                                    AvailabilityBattery.Text = "Install Error";
                                    break;
                                case 13:
                                    AvailabilityBattery.Text = "Power Save - Unknown";
                                    break;
                                case 14:
                                    AvailabilityBattery.Text = "Power Save - Low Power Mode";
                                    break;
                                case 15:
                                    AvailabilityBattery.Text = "Power Save - Standby";
                                    break;
                                case 16:
                                    AvailabilityBattery.Text = "Power Cycle";
                                    break;
                                case 17:
                                    AvailabilityBattery.Text = "Power Save - Warning";
                                    break;
                                case 18:
                                    AvailabilityBattery.Text = "Paused";
                                    break;
                                case 19:
                                    AvailabilityBattery.Text = "Not Ready";
                                    break;
                                case 20:
                                    AvailabilityBattery.Text = "Not Configured";
                                    break;
                                case 21:
                                    AvailabilityBattery.Text = "Quiesced";
                                    break;
                                default:
                                    AvailabilityBattery.Text = "неизвестная ошибка";
                                    break;
                            }
                            break;
                        case "BatteryStatus":
                            switch (Convert.ToInt32(property.Value))
                            {
                                case 1:
                                    BatteryStatus.Text = "разряжается";
                                    break;
                                case 2:
                                    BatteryStatus.Text = "неизвестно";
                                    break;
                                case 3:
                                    BatteryStatus.Text = "полностью заряжена";
                                    break;
                                case 4:
                                    BatteryStatus.Text = "низкий уровень заряда";
                                    break;
                                case 5:
                                    BatteryStatus.Text = "критический уровень заряда";
                                    break;
                                case 6:
                                    BatteryStatus.Text = "заряжается";
                                    break;
                                case 7:
                                    BatteryStatus.Text = "высокий уровень заряда(заряжается)";
                                    break;
                                case 8:
                                    BatteryStatus.Text = "низкий уровень заряда(заряжается)";
                                    break;
                                case 9:
                                    BatteryStatus.Text = "критический уровень заряда(заряжается)";
                                    break;
                                case 10:
                                    BatteryStatus.Text = "неопределено";
                                    break;
                                case 11:
                                    BatteryStatus.Text = "частично заряжено";
                                    break;
                                default:
                                    BatteryStatus.Text = "неизвестная ошибка";
                                    break;
                            }
                            break;
                        case "Description":
                            DescriptionBattery.Text = property.Value.ToString();
                            break;
                        case "Chemistry":
                            switch (Convert.ToInt32(property.Value))
                            {
                                case 1:
                                    ChemistryBattery.Text = "другое";
                                    break;
                                case 2:
                                    ChemistryBattery.Text = "неизвестно";
                                    break;
                                case 3:
                                    ChemistryBattery.Text = "свинцово-кислотная батарея";
                                    break;
                                case 4:
                                    ChemistryBattery.Text = "никель-кадмиевая батарея";
                                    break;
                                case 5:
                                    ChemistryBattery.Text = "никель-металлгидридная батарея";
                                    break;
                                case 6:
                                    ChemistryBattery.Text = "литий-ионная батарея";
                                    break;
                                case 7:
                                    ChemistryBattery.Text = "воздушно-цинковая батарея";
                                    break;
                                case 8:
                                    ChemistryBattery.Text = "литий-Полимерная батарея";
                                    break;
                                default:
                                    ChemistryBattery.Text = "неизвестная ошибка";
                                    break;
                            }
                            break;
                        case "DeviceID":
                            BatteryID.Text = property.Value.ToString();
                            break;
                        case "EstimatedChargeRemaining":
                            ChargeLevel.Text = property.Value.ToString();
                            break;
                        case "EstimatedRunTime":
                            EstimatedRunTime.Text = property.Value.ToString();
                            break;
                        case "Name":
                            NameBattery.Text = property.Value.ToString();
                            break;
                        case "Status":
                            StatusBattery.Text = property.Value.ToString();
                            break;
                    }
                }
            }
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            TextRefresh();
            if(Convert.ToInt32(power.BatteryLifeRemaining) != -1)
                notifyIcon1.Text = (Convert.ToInt32(power.BatteryLifeRemaining)/60).ToString();
            else notifyIcon1.Text = "Заряжается";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            RefreshTimer.Enabled = true;
        }

    }
}

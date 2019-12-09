using BatteryManager.Classes;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            Settings.autoChangePlan = checkBox2.Checked;
            Settings.autoChangeLowLevelPlan = checkBox3.Checked;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ClavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Controller.form1 == null)
            {
                Controller.form1 = new Form1();
            }
            Controller.ActiveForm = 1;
            Controller.form1.Location = this.Location;
            Controller.form1.Show();

            this.Hide();
        }

        //private void TableToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (Controller.form2 == null)
        //    {
        //        Controller.form2 = new Form2();
        //    }
        //    Controller.ActiveForm = 2;
        //    Controller.form2.Location = this.Location;
        //    Controller.form2.Show();

        //    this.Hide();
        //}

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                checkBox3.Enabled = false;
                Settings.autoChangePlan = checkBox2.Checked;
                Settings.autoChangeLowLevelPlan = checkBox3.Checked;
            }
            else
            {
                checkBox3.Enabled = true;
                Settings.autoChangePlan = checkBox2.Checked;
                Settings.autoChangeLowLevelPlan = checkBox3.Checked;
            }
        }

    }
}

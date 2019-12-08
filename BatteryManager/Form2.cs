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
using System.Windows.Forms.DataVisualization.Charting;

namespace BatteryManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GlavToolStripMenuItem_Click(object sender, EventArgs e)
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

namespace BatteryManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ChargeLevelText = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GlavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChargeLevel = new System.Windows.Forms.Label();
            this.BatteryIDText = new System.Windows.Forms.Label();
            this.ChemistryBatteryText = new System.Windows.Forms.Label();
            this.AvailabilityBatteryText = new System.Windows.Forms.Label();
            this.NameBatteryText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BatteryStatusText = new System.Windows.Forms.Label();
            this.StatusBatteryText = new System.Windows.Forms.Label();
            this.ChemistryBattery = new System.Windows.Forms.Label();
            this.NameBattery = new System.Windows.Forms.Label();
            this.BatteryID = new System.Windows.Forms.Label();
            this.EstimatedRunTimeText = new System.Windows.Forms.Label();
            this.DescriptionBattery = new System.Windows.Forms.Label();
            this.BatteryStatus = new System.Windows.Forms.Label();
            this.AvailabilityBattery = new System.Windows.Forms.Label();
            this.StatusBattery = new System.Windows.Forms.Label();
            this.EstimatedRunTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "???";
            this.notifyIcon1.Visible = true;
            // 
            // ChargeLevelText
            // 
            this.ChargeLevelText.AutoSize = true;
            this.ChargeLevelText.Location = new System.Drawing.Point(25, 43);
            this.ChargeLevelText.Name = "ChargeLevelText";
            this.ChargeLevelText.Size = new System.Drawing.Size(114, 17);
            this.ChargeLevelText.TabIndex = 0;
            this.ChargeLevelText.Text = "Уровень заряда";
            // 
            // Exit_button
            // 
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_button.Location = new System.Drawing.Point(757, 0);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(31, 23);
            this.Exit_button.TabIndex = 1;
            this.Exit_button.Text = "X";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GlavToolStripMenuItem,
            this.TableToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GlavToolStripMenuItem
            // 
            this.GlavToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GlavToolStripMenuItem.Name = "GlavToolStripMenuItem";
            this.GlavToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.GlavToolStripMenuItem.Text = "Главное";
            // 
            // TableToolStripMenuItem
            // 
            this.TableToolStripMenuItem.Name = "TableToolStripMenuItem";
            this.TableToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.TableToolStripMenuItem.Text = "Таблица";
            this.TableToolStripMenuItem.Click += new System.EventHandler(this.TableToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.AboutToolStripMenuItem.Text = "О программе";
            // 
            // ChargeLevel
            // 
            this.ChargeLevel.AutoSize = true;
            this.ChargeLevel.Location = new System.Drawing.Point(147, 43);
            this.ChargeLevel.Name = "ChargeLevel";
            this.ChargeLevel.Size = new System.Drawing.Size(32, 17);
            this.ChargeLevel.TabIndex = 3;
            this.ChargeLevel.Text = "???";
            // 
            // BatteryIDText
            // 
            this.BatteryIDText.AutoSize = true;
            this.BatteryIDText.Location = new System.Drawing.Point(426, 69);
            this.BatteryIDText.Name = "BatteryIDText";
            this.BatteryIDText.Size = new System.Drawing.Size(80, 17);
            this.BatteryIDText.TabIndex = 4;
            this.BatteryIDText.Text = "ID батареи";
            // 
            // ChemistryBatteryText
            // 
            this.ChemistryBatteryText.AutoSize = true;
            this.ChemistryBatteryText.Location = new System.Drawing.Point(426, 97);
            this.ChemistryBatteryText.Name = "ChemistryBatteryText";
            this.ChemistryBatteryText.Size = new System.Drawing.Size(92, 17);
            this.ChemistryBatteryText.TabIndex = 5;
            this.ChemistryBatteryText.Text = "Тип батареи";
            // 
            // AvailabilityBatteryText
            // 
            this.AvailabilityBatteryText.AutoSize = true;
            this.AvailabilityBatteryText.Location = new System.Drawing.Point(25, 97);
            this.AvailabilityBatteryText.Name = "AvailabilityBatteryText";
            this.AvailabilityBatteryText.Size = new System.Drawing.Size(152, 17);
            this.AvailabilityBatteryText.TabIndex = 6;
            this.AvailabilityBatteryText.Text = "Доступность батареи";
            // 
            // NameBatteryText
            // 
            this.NameBatteryText.AutoSize = true;
            this.NameBatteryText.Location = new System.Drawing.Point(426, 43);
            this.NameBatteryText.Name = "NameBatteryText";
            this.NameBatteryText.Size = new System.Drawing.Size(131, 17);
            this.NameBatteryText.TabIndex = 7;
            this.NameBatteryText.Text = "Название батареи";
            // 
            // label6
            // 
            this.label6.AccessibleDescription = "DescriptionBatteryText";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Спецификация батареи";
            // 
            // BatteryStatusText
            // 
            this.BatteryStatusText.AutoSize = true;
            this.BatteryStatusText.Location = new System.Drawing.Point(25, 69);
            this.BatteryStatusText.Name = "BatteryStatusText";
            this.BatteryStatusText.Size = new System.Drawing.Size(112, 17);
            this.BatteryStatusText.TabIndex = 9;
            this.BatteryStatusText.Text = "Статут батареи";
            // 
            // StatusBatteryText
            // 
            this.StatusBatteryText.AutoSize = true;
            this.StatusBatteryText.Location = new System.Drawing.Point(27, 124);
            this.StatusBatteryText.Name = "StatusBatteryText";
            this.StatusBatteryText.Size = new System.Drawing.Size(112, 17);
            this.StatusBatteryText.TabIndex = 10;
            this.StatusBatteryText.Text = "Статус батареи";
            // 
            // ChemistryBattery
            // 
            this.ChemistryBattery.AutoSize = true;
            this.ChemistryBattery.Location = new System.Drawing.Point(525, 97);
            this.ChemistryBattery.Name = "ChemistryBattery";
            this.ChemistryBattery.Size = new System.Drawing.Size(32, 17);
            this.ChemistryBattery.TabIndex = 11;
            this.ChemistryBattery.Text = "???";
            // 
            // NameBattery
            // 
            this.NameBattery.AutoSize = true;
            this.NameBattery.Location = new System.Drawing.Point(563, 43);
            this.NameBattery.Name = "NameBattery";
            this.NameBattery.Size = new System.Drawing.Size(32, 17);
            this.NameBattery.TabIndex = 12;
            this.NameBattery.Text = "???";
            // 
            // BatteryID
            // 
            this.BatteryID.AutoSize = true;
            this.BatteryID.Location = new System.Drawing.Point(512, 69);
            this.BatteryID.Name = "BatteryID";
            this.BatteryID.Size = new System.Drawing.Size(32, 17);
            this.BatteryID.TabIndex = 13;
            this.BatteryID.Text = "???";
            // 
            // EstimatedRunTimeText
            // 
            this.EstimatedRunTimeText.AutoSize = true;
            this.EstimatedRunTimeText.Location = new System.Drawing.Point(27, 151);
            this.EstimatedRunTimeText.Name = "EstimatedRunTimeText";
            this.EstimatedRunTimeText.Size = new System.Drawing.Size(241, 17);
            this.EstimatedRunTimeText.TabIndex = 14;
            this.EstimatedRunTimeText.Text = "Ожидаемое время работы батареи";
            // 
            // DescriptionBattery
            // 
            this.DescriptionBattery.AutoSize = true;
            this.DescriptionBattery.Location = new System.Drawing.Point(598, 124);
            this.DescriptionBattery.Name = "DescriptionBattery";
            this.DescriptionBattery.Size = new System.Drawing.Size(32, 17);
            this.DescriptionBattery.TabIndex = 15;
            this.DescriptionBattery.Text = "???";
            // 
            // BatteryStatus
            // 
            this.BatteryStatus.AutoSize = true;
            this.BatteryStatus.Location = new System.Drawing.Point(143, 69);
            this.BatteryStatus.Name = "BatteryStatus";
            this.BatteryStatus.Size = new System.Drawing.Size(32, 17);
            this.BatteryStatus.TabIndex = 16;
            this.BatteryStatus.Text = "???";
            // 
            // AvailabilityBattery
            // 
            this.AvailabilityBattery.AutoSize = true;
            this.AvailabilityBattery.Location = new System.Drawing.Point(183, 97);
            this.AvailabilityBattery.Name = "AvailabilityBattery";
            this.AvailabilityBattery.Size = new System.Drawing.Size(32, 17);
            this.AvailabilityBattery.TabIndex = 17;
            this.AvailabilityBattery.Text = "???";
            // 
            // StatusBattery
            // 
            this.StatusBattery.AutoSize = true;
            this.StatusBattery.Location = new System.Drawing.Point(145, 124);
            this.StatusBattery.Name = "StatusBattery";
            this.StatusBattery.Size = new System.Drawing.Size(32, 17);
            this.StatusBattery.TabIndex = 18;
            this.StatusBattery.Text = "???";
            // 
            // EstimatedRunTime
            // 
            this.EstimatedRunTime.AutoSize = true;
            this.EstimatedRunTime.Location = new System.Drawing.Point(274, 151);
            this.EstimatedRunTime.Name = "EstimatedRunTime";
            this.EstimatedRunTime.Size = new System.Drawing.Size(32, 17);
            this.EstimatedRunTime.TabIndex = 19;
            this.EstimatedRunTime.Text = "???";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.EstimatedRunTime);
            this.Controls.Add(this.StatusBattery);
            this.Controls.Add(this.AvailabilityBattery);
            this.Controls.Add(this.BatteryStatus);
            this.Controls.Add(this.DescriptionBattery);
            this.Controls.Add(this.EstimatedRunTimeText);
            this.Controls.Add(this.BatteryID);
            this.Controls.Add(this.NameBattery);
            this.Controls.Add(this.ChemistryBattery);
            this.Controls.Add(this.StatusBatteryText);
            this.Controls.Add(this.BatteryStatusText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameBatteryText);
            this.Controls.Add(this.AvailabilityBatteryText);
            this.Controls.Add(this.ChemistryBatteryText);
            this.Controls.Add(this.BatteryIDText);
            this.Controls.Add(this.ChargeLevel);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.ChargeLevelText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battery Manager";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label ChargeLevelText;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GlavToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Label ChargeLevel;
        private System.Windows.Forms.Label BatteryIDText;
        private System.Windows.Forms.Label ChemistryBatteryText;
        private System.Windows.Forms.Label AvailabilityBatteryText;
        private System.Windows.Forms.Label NameBatteryText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label BatteryStatusText;
        private System.Windows.Forms.Label StatusBatteryText;
        private System.Windows.Forms.Label ChemistryBattery;
        private System.Windows.Forms.Label NameBattery;
        private System.Windows.Forms.Label BatteryID;
        private System.Windows.Forms.Label EstimatedRunTimeText;
        private System.Windows.Forms.Label DescriptionBattery;
        private System.Windows.Forms.Label BatteryStatus;
        private System.Windows.Forms.Label AvailabilityBattery;
        private System.Windows.Forms.Label StatusBattery;
        private System.Windows.Forms.Label EstimatedRunTime;
    }
}


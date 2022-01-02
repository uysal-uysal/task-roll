namespace taskroll
{
    partial class Utilities
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.progressBarBattery = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelBatteryName = new System.Windows.Forms.Label();
            this.labelBatteryStatus = new System.Windows.Forms.Label();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.labelDiskFormat = new System.Windows.Forms.Label();
            this.labelDiskName = new System.Windows.Forms.Label();
            this.labelDiskAvailable = new System.Windows.Forms.Label();
            this.labelDiskTotal = new System.Windows.Forms.Label();
            this.labelDiskWrite = new System.Windows.Forms.Label();
            this.labelDiskRead = new System.Windows.Forms.Label();
            this.comboBoxDisk = new System.Windows.Forms.ComboBox();
            this.panelBattery = new System.Windows.Forms.Panel();
            this.panelDisk = new System.Windows.Forms.Panel();
            this.timerConnection = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.yesConnection = new System.Windows.Forms.Button();
            this.noConnection = new System.Windows.Forms.Button();
            this.buttonBrightnessIcon = new System.Windows.Forms.Button();
            this.buttonTurnOff = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.buttonInc = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.buttonMute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.panelBattery.SuspendLayout();
            this.panelDisk.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(320, 420);
            this.trackBarBrightness.Maximum = 100;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(360, 45);
            this.trackBarBrightness.TabIndex = 13;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // progressBarBattery
            // 
            this.progressBarBattery.Location = new System.Drawing.Point(12, 50);
            this.progressBarBattery.Name = "progressBarBattery";
            this.progressBarBattery.Size = new System.Drawing.Size(350, 25);
            this.progressBarBattery.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarBattery.TabIndex = 14;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelBatteryName
            // 
            this.labelBatteryName.AutoSize = true;
            this.labelBatteryName.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBatteryName.Location = new System.Drawing.Point(12, 102);
            this.labelBatteryName.Name = "labelBatteryName";
            this.labelBatteryName.Size = new System.Drawing.Size(93, 16);
            this.labelBatteryName.TabIndex = 15;
            this.labelBatteryName.Text = "Battery Name :";
            // 
            // labelBatteryStatus
            // 
            this.labelBatteryStatus.AutoSize = true;
            this.labelBatteryStatus.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBatteryStatus.Location = new System.Drawing.Point(12, 162);
            this.labelBatteryStatus.Name = "labelBatteryStatus";
            this.labelBatteryStatus.Size = new System.Drawing.Size(93, 16);
            this.labelBatteryStatus.TabIndex = 15;
            this.labelBatteryStatus.Text = "Battery Status :";
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemaining.Location = new System.Drawing.Point(12, 132);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(119, 16);
            this.labelRemaining.TabIndex = 16;
            this.labelRemaining.Text = "Remaining Battery :";
            // 
            // labelDiskFormat
            // 
            this.labelDiskFormat.AutoSize = true;
            this.labelDiskFormat.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiskFormat.Location = new System.Drawing.Point(47, 110);
            this.labelDiskFormat.Name = "labelDiskFormat";
            this.labelDiskFormat.Size = new System.Drawing.Size(83, 16);
            this.labelDiskFormat.TabIndex = 17;
            this.labelDiskFormat.Text = "Disk Format :";
            // 
            // labelDiskName
            // 
            this.labelDiskName.AutoSize = true;
            this.labelDiskName.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiskName.Location = new System.Drawing.Point(47, 145);
            this.labelDiskName.Name = "labelDiskName";
            this.labelDiskName.Size = new System.Drawing.Size(77, 16);
            this.labelDiskName.TabIndex = 18;
            this.labelDiskName.Text = "Disk Name :";
            // 
            // labelDiskAvailable
            // 
            this.labelDiskAvailable.AutoSize = true;
            this.labelDiskAvailable.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiskAvailable.Location = new System.Drawing.Point(47, 180);
            this.labelDiskAvailable.Name = "labelDiskAvailable";
            this.labelDiskAvailable.Size = new System.Drawing.Size(105, 16);
            this.labelDiskAvailable.TabIndex = 19;
            this.labelDiskAvailable.Text = "Available Space :";
            // 
            // labelDiskTotal
            // 
            this.labelDiskTotal.AutoSize = true;
            this.labelDiskTotal.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiskTotal.Location = new System.Drawing.Point(47, 215);
            this.labelDiskTotal.Name = "labelDiskTotal";
            this.labelDiskTotal.Size = new System.Drawing.Size(82, 16);
            this.labelDiskTotal.TabIndex = 20;
            this.labelDiskTotal.Text = "Total Space :";
            // 
            // labelDiskWrite
            // 
            this.labelDiskWrite.AutoSize = true;
            this.labelDiskWrite.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiskWrite.Location = new System.Drawing.Point(47, 250);
            this.labelDiskWrite.Name = "labelDiskWrite";
            this.labelDiskWrite.Size = new System.Drawing.Size(103, 16);
            this.labelDiskWrite.TabIndex = 21;
            this.labelDiskWrite.Text = "Write Bytes/sec :";
            // 
            // labelDiskRead
            // 
            this.labelDiskRead.AutoSize = true;
            this.labelDiskRead.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiskRead.Location = new System.Drawing.Point(47, 285);
            this.labelDiskRead.Name = "labelDiskRead";
            this.labelDiskRead.Size = new System.Drawing.Size(102, 16);
            this.labelDiskRead.TabIndex = 21;
            this.labelDiskRead.Text = "Read Bytes/sec :";
            // 
            // comboBoxDisk
            // 
            this.comboBoxDisk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisk.FormattingEnabled = true;
            this.comboBoxDisk.Location = new System.Drawing.Point(47, 50);
            this.comboBoxDisk.Name = "comboBoxDisk";
            this.comboBoxDisk.Size = new System.Drawing.Size(102, 22);
            this.comboBoxDisk.TabIndex = 22;
            // 
            // panelBattery
            // 
            this.panelBattery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBattery.Controls.Add(this.progressBarBattery);
            this.panelBattery.Controls.Add(this.labelBatteryName);
            this.panelBattery.Controls.Add(this.labelBatteryStatus);
            this.panelBattery.Controls.Add(this.labelRemaining);
            this.panelBattery.Location = new System.Drawing.Point(50, 35);
            this.panelBattery.Name = "panelBattery";
            this.panelBattery.Size = new System.Drawing.Size(380, 345);
            this.panelBattery.TabIndex = 24;
            // 
            // panelDisk
            // 
            this.panelDisk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDisk.Controls.Add(this.comboBoxDisk);
            this.panelDisk.Controls.Add(this.labelDiskFormat);
            this.panelDisk.Controls.Add(this.labelDiskName);
            this.panelDisk.Controls.Add(this.labelDiskRead);
            this.panelDisk.Controls.Add(this.labelDiskAvailable);
            this.panelDisk.Controls.Add(this.labelDiskWrite);
            this.panelDisk.Controls.Add(this.labelDiskTotal);
            this.panelDisk.Location = new System.Drawing.Point(530, 35);
            this.panelDisk.Name = "panelDisk";
            this.panelDisk.Size = new System.Drawing.Size(380, 345);
            this.panelDisk.TabIndex = 25;
            // 
            // timerConnection
            // 
            this.timerConnection.Interval = 1000;
            this.timerConnection.Tick += new System.EventHandler(this.timerConnection_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 26;
            // 
            // yesConnection
            // 
            this.yesConnection.BackgroundImage = global::taskroll.Properties.Resources.yesconnection;
            this.yesConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yesConnection.FlatAppearance.BorderSize = 0;
            this.yesConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesConnection.Location = new System.Drawing.Point(728, 427);
            this.yesConnection.Name = "yesConnection";
            this.yesConnection.Size = new System.Drawing.Size(35, 30);
            this.yesConnection.TabIndex = 28;
            this.yesConnection.UseVisualStyleBackColor = true;
            this.yesConnection.Click += new System.EventHandler(this.yesConnection_Click);
            // 
            // noConnection
            // 
            this.noConnection.BackgroundImage = global::taskroll.Properties.Resources.noconnection;
            this.noConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noConnection.FlatAppearance.BorderSize = 0;
            this.noConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noConnection.Location = new System.Drawing.Point(686, 427);
            this.noConnection.Name = "noConnection";
            this.noConnection.Size = new System.Drawing.Size(35, 30);
            this.noConnection.TabIndex = 27;
            this.noConnection.UseVisualStyleBackColor = true;
            // 
            // buttonBrightnessIcon
            // 
            this.buttonBrightnessIcon.BackgroundImage = global::taskroll.Properties.Resources.brightness;
            this.buttonBrightnessIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBrightnessIcon.Enabled = false;
            this.buttonBrightnessIcon.FlatAppearance.BorderSize = 0;
            this.buttonBrightnessIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrightnessIcon.Location = new System.Drawing.Point(284, 420);
            this.buttonBrightnessIcon.Name = "buttonBrightnessIcon";
            this.buttonBrightnessIcon.Size = new System.Drawing.Size(30, 25);
            this.buttonBrightnessIcon.TabIndex = 23;
            this.buttonBrightnessIcon.UseVisualStyleBackColor = true;
            // 
            // buttonTurnOff
            // 
            this.buttonTurnOff.BackColor = System.Drawing.Color.Transparent;
            this.buttonTurnOff.BackgroundImage = global::taskroll.Properties.Resources.powericon;
            this.buttonTurnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTurnOff.FlatAppearance.BorderSize = 0;
            this.buttonTurnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTurnOff.Location = new System.Drawing.Point(900, 430);
            this.buttonTurnOff.Name = "buttonTurnOff";
            this.buttonTurnOff.Size = new System.Drawing.Size(32, 27);
            this.buttonTurnOff.TabIndex = 12;
            this.buttonTurnOff.UseVisualStyleBackColor = false;
            this.buttonTurnOff.Click += new System.EventHandler(this.buttonTurnOff_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Transparent;
            this.buttonRestart.BackgroundImage = global::taskroll.Properties.Resources.restarticon;
            this.buttonRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Location = new System.Drawing.Point(845, 430);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(25, 27);
            this.buttonRestart.TabIndex = 11;
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonSleep
            // 
            this.buttonSleep.BackColor = System.Drawing.Color.Transparent;
            this.buttonSleep.BackgroundImage = global::taskroll.Properties.Resources.sleepmodeicon;
            this.buttonSleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSleep.FlatAppearance.BorderSize = 0;
            this.buttonSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSleep.Location = new System.Drawing.Point(785, 430);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(25, 27);
            this.buttonSleep.TabIndex = 10;
            this.buttonSleep.UseVisualStyleBackColor = false;
            this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            // 
            // buttonInc
            // 
            this.buttonInc.BackColor = System.Drawing.Color.Transparent;
            this.buttonInc.BackgroundImage = global::taskroll.Properties.Resources.increasevolumeicon;
            this.buttonInc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInc.FlatAppearance.BorderSize = 0;
            this.buttonInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInc.Location = new System.Drawing.Point(165, 430);
            this.buttonInc.Name = "buttonInc";
            this.buttonInc.Size = new System.Drawing.Size(25, 27);
            this.buttonInc.TabIndex = 9;
            this.buttonInc.UseVisualStyleBackColor = false;
            this.buttonInc.Click += new System.EventHandler(this.buttonInc_Click);
            // 
            // buttonDec
            // 
            this.buttonDec.BackColor = System.Drawing.Color.Transparent;
            this.buttonDec.BackgroundImage = global::taskroll.Properties.Resources.decreasevolumeicon;
            this.buttonDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDec.FlatAppearance.BorderSize = 0;
            this.buttonDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDec.Location = new System.Drawing.Point(100, 430);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(25, 27);
            this.buttonDec.TabIndex = 8;
            this.buttonDec.UseVisualStyleBackColor = false;
            this.buttonDec.Click += new System.EventHandler(this.buttonDec_Click);
            // 
            // buttonMute
            // 
            this.buttonMute.BackColor = System.Drawing.Color.Transparent;
            this.buttonMute.BackgroundImage = global::taskroll.Properties.Resources.muteicon_removebg_preview;
            this.buttonMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMute.FlatAppearance.BorderSize = 0;
            this.buttonMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMute.Location = new System.Drawing.Point(35, 430);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(25, 27);
            this.buttonMute.TabIndex = 7;
            this.buttonMute.UseVisualStyleBackColor = false;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // Utilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 476);
            this.Controls.Add(this.yesConnection);
            this.Controls.Add(this.noConnection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDisk);
            this.Controls.Add(this.panelBattery);
            this.Controls.Add(this.buttonBrightnessIcon);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.buttonTurnOff);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonSleep);
            this.Controls.Add(this.buttonInc);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.buttonMute);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Utilities";
            this.Text = "Utilities";
            this.Load += new System.EventHandler(this.Utilities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.panelBattery.ResumeLayout(false);
            this.panelBattery.PerformLayout();
            this.panelDisk.ResumeLayout(false);
            this.panelDisk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Button buttonTurnOff;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.Button buttonInc;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.ProgressBar progressBarBattery;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelBatteryName;
        private System.Windows.Forms.Label labelBatteryStatus;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.Label labelDiskFormat;
        private System.Windows.Forms.Label labelDiskName;
        private System.Windows.Forms.Label labelDiskAvailable;
        private System.Windows.Forms.Label labelDiskTotal;
        private System.Windows.Forms.Label labelDiskWrite;
        private System.Windows.Forms.Label labelDiskRead;
        private System.Windows.Forms.ComboBox comboBoxDisk;
        private System.Windows.Forms.Button buttonBrightnessIcon;
        private System.Windows.Forms.Panel panelBattery;
        private System.Windows.Forms.Panel panelDisk;
        private System.Windows.Forms.Timer timerConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button noConnection;
        private System.Windows.Forms.Button yesConnection;
    }
}
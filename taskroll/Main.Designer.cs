namespace taskroll
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripMenuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuProcesses = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuCpu = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuRam = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBoxHeader = new System.Windows.Forms.PictureBox();
            this.pictureBoxBar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuMain,
            this.stripMenuProcesses,
            this.stripMenuCpu,
            this.stripMenuRam});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // stripMenuMain
            // 
            this.stripMenuMain.Name = "stripMenuMain";
            this.stripMenuMain.Size = new System.Drawing.Size(46, 20);
            this.stripMenuMain.Text = "Main";
            this.stripMenuMain.Click += new System.EventHandler(this.stripMenuMain_Click);
            // 
            // stripMenuProcesses
            // 
            this.stripMenuProcesses.Name = "stripMenuProcesses";
            this.stripMenuProcesses.Size = new System.Drawing.Size(70, 20);
            this.stripMenuProcesses.Text = "Processes";
            this.stripMenuProcesses.Click += new System.EventHandler(this.stripMenuProcesses_Click);
            // 
            // stripMenuCpu
            // 
            this.stripMenuCpu.Name = "stripMenuCpu";
            this.stripMenuCpu.Size = new System.Drawing.Size(79, 20);
            this.stripMenuCpu.Text = "Cpu Details";
            this.stripMenuCpu.Click += new System.EventHandler(this.stripMenuCpu_Click);
            // 
            // stripMenuRam
            // 
            this.stripMenuRam.Name = "stripMenuRam";
            this.stripMenuRam.Size = new System.Drawing.Size(81, 20);
            this.stripMenuRam.Text = "Ram Details";
            this.stripMenuRam.Click += new System.EventHandler(this.stripMenuRam_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(20, 84);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(960, 481);
            this.mainPanel.TabIndex = 2;
            // 
            // pictureBoxHeader
            // 
            this.pictureBoxHeader.Image = global::taskroll.Properties.Resources.taskroll1;
            this.pictureBoxHeader.Location = new System.Drawing.Point(75, 11);
            this.pictureBoxHeader.Name = "pictureBoxHeader";
            this.pictureBoxHeader.Size = new System.Drawing.Size(825, 37);
            this.pictureBoxHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeader.TabIndex = 7;
            this.pictureBoxHeader.TabStop = false;
            // 
            // pictureBoxBar
            // 
            this.pictureBoxBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBar.Image = global::taskroll.Properties.Resources.taskroll_bar1;
            this.pictureBoxBar.Location = new System.Drawing.Point(150, 11);
            this.pictureBoxBar.Name = "pictureBoxBar";
            this.pictureBoxBar.Size = new System.Drawing.Size(700, 46);
            this.pictureBoxBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBar.TabIndex = 6;
            this.pictureBoxBar.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 585);
            this.Controls.Add(this.pictureBoxHeader);
            this.Controls.Add(this.pictureBoxBar);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Main";
            this.Resizable = false;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripMenuMain;
        private System.Windows.Forms.ToolStripMenuItem stripMenuProcesses;
        private System.Windows.Forms.ToolStripMenuItem stripMenuCpu;
        private System.Windows.Forms.ToolStripMenuItem stripMenuRam;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pictureBoxBar;
        private System.Windows.Forms.PictureBox pictureBoxHeader;
    }
}
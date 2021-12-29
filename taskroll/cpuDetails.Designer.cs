namespace taskroll
{
    partial class cpuDetails
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelCpu = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelSystem = new System.Windows.Forms.Label();
            this.labelCpuId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCores = new System.Windows.Forms.Label();
            this.labelLogicalProcessors = new System.Windows.Forms.Label();
            this.labelCurrentClock = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.chartCpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.chartCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCpu
            // 
            this.labelCpu.AutoSize = true;
            this.labelCpu.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpu.Location = new System.Drawing.Point(15, 59);
            this.labelCpu.Name = "labelCpu";
            this.labelCpu.Size = new System.Drawing.Size(78, 16);
            this.labelCpu.TabIndex = 0;
            this.labelCpu.Text = "Cpu Usage :";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelSystem
            // 
            this.labelSystem.AutoSize = true;
            this.labelSystem.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystem.Location = new System.Drawing.Point(15, 105);
            this.labelSystem.Name = "labelSystem";
            this.labelSystem.Size = new System.Drawing.Size(90, 16);
            this.labelSystem.TabIndex = 1;
            this.labelSystem.Text = "SystemName :";
            // 
            // labelCpuId
            // 
            this.labelCpuId.AutoSize = true;
            this.labelCpuId.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpuId.Location = new System.Drawing.Point(15, 150);
            this.labelCpuId.Name = "labelCpuId";
            this.labelCpuId.Size = new System.Drawing.Size(83, 16);
            this.labelCpuId.TabIndex = 2;
            this.labelCpuId.Text = "ProcessorId :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(15, 195);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 16);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name :";
            // 
            // labelCores
            // 
            this.labelCores.AutoSize = true;
            this.labelCores.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCores.Location = new System.Drawing.Point(15, 240);
            this.labelCores.Name = "labelCores";
            this.labelCores.Size = new System.Drawing.Size(110, 16);
            this.labelCores.TabIndex = 4;
            this.labelCores.Text = "NumberOfCores :";
            // 
            // labelLogicalProcessors
            // 
            this.labelLogicalProcessors.AutoSize = true;
            this.labelLogicalProcessors.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogicalProcessors.Location = new System.Drawing.Point(15, 285);
            this.labelLogicalProcessors.Name = "labelLogicalProcessors";
            this.labelLogicalProcessors.Size = new System.Drawing.Size(181, 16);
            this.labelLogicalProcessors.TabIndex = 5;
            this.labelLogicalProcessors.Text = "NumberOfLogicalProcessors :";
            // 
            // labelCurrentClock
            // 
            this.labelCurrentClock.AutoSize = true;
            this.labelCurrentClock.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentClock.Location = new System.Drawing.Point(15, 375);
            this.labelCurrentClock.Name = "labelCurrentClock";
            this.labelCurrentClock.Size = new System.Drawing.Size(82, 16);
            this.labelCurrentClock.TabIndex = 6;
            this.labelCurrentClock.Text = "BaseSpeed  :";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManufacturer.Location = new System.Drawing.Point(15, 330);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(92, 16);
            this.labelManufacturer.TabIndex = 8;
            this.labelManufacturer.Text = "Manufacturer :";
            // 
            // chartCpu
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCpu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCpu.Legends.Add(legend2);
            this.chartCpu.Location = new System.Drawing.Point(387, 105);
            this.chartCpu.Name = "chartCpu";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.LightSeaGreen;
            series2.Legend = "Legend1";
            series2.Name = "Cpu";
            this.chartCpu.Series.Add(series2);
            this.chartCpu.Size = new System.Drawing.Size(545, 300);
            this.chartCpu.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(387, 59);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(545, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // cpuDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 442);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chartCpu);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.labelCurrentClock);
            this.Controls.Add(this.labelLogicalProcessors);
            this.Controls.Add(this.labelCores);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCpuId);
            this.Controls.Add(this.labelSystem);
            this.Controls.Add(this.labelCpu);
            this.Name = "cpuDetails";
            this.Text = "cpuDetails";
            this.Load += new System.EventHandler(this.cpuDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCpu;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelSystem;
        private System.Windows.Forms.Label labelCpuId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCores;
        private System.Windows.Forms.Label labelLogicalProcessors;
        private System.Windows.Forms.Label labelCurrentClock;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCpu;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
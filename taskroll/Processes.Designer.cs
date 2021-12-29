namespace taskroll
{
    partial class Processes
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
            this.listProcess = new System.Windows.Forms.ListBox();
            this.btnGetProcess = new System.Windows.Forms.Button();
            this.btnEndProcess = new System.Windows.Forms.Button();
            this.btnProperties = new System.Windows.Forms.Button();
            this.labelActiveProcesses = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chartInterrupts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelInterrupts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartInterrupts)).BeginInit();
            this.SuspendLayout();
            // 
            // listProcess
            // 
            this.listProcess.FormattingEnabled = true;
            this.listProcess.Location = new System.Drawing.Point(10, 66);
            this.listProcess.Name = "listProcess";
            this.listProcess.Size = new System.Drawing.Size(305, 355);
            this.listProcess.Sorted = true;
            this.listProcess.TabIndex = 0;
            // 
            // btnGetProcess
            // 
            this.btnGetProcess.Location = new System.Drawing.Point(321, 138);
            this.btnGetProcess.Name = "btnGetProcess";
            this.btnGetProcess.Size = new System.Drawing.Size(105, 35);
            this.btnGetProcess.TabIndex = 1;
            this.btnGetProcess.Text = "Get Process";
            this.btnGetProcess.UseVisualStyleBackColor = true;
            this.btnGetProcess.Click += new System.EventHandler(this.btnGetProcess_Click);
            // 
            // btnEndProcess
            // 
            this.btnEndProcess.Location = new System.Drawing.Point(321, 238);
            this.btnEndProcess.Name = "btnEndProcess";
            this.btnEndProcess.Size = new System.Drawing.Size(105, 35);
            this.btnEndProcess.TabIndex = 2;
            this.btnEndProcess.Text = "End Process";
            this.btnEndProcess.UseVisualStyleBackColor = true;
            this.btnEndProcess.Click += new System.EventHandler(this.btnEndProcess_Click);
            // 
            // btnProperties
            // 
            this.btnProperties.Location = new System.Drawing.Point(321, 338);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(105, 35);
            this.btnProperties.TabIndex = 3;
            this.btnProperties.Text = "Properties";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // labelActiveProcesses
            // 
            this.labelActiveProcesses.AutoSize = true;
            this.labelActiveProcesses.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveProcesses.Location = new System.Drawing.Point(439, 41);
            this.labelActiveProcesses.Name = "labelActiveProcesses";
            this.labelActiveProcesses.Size = new System.Drawing.Size(103, 16);
            this.labelActiveProcesses.TabIndex = 4;
            this.labelActiveProcesses.Text = "Active Processes";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chartInterrupts
            // 
            chartArea2.Name = "ChartArea1";
            this.chartInterrupts.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartInterrupts.Legends.Add(legend2);
            this.chartInterrupts.Location = new System.Drawing.Point(434, 66);
            this.chartInterrupts.Name = "chartInterrupts";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.Tomato;
            series2.Legend = "Legend1";
            series2.Name = "Interrupts";
            this.chartInterrupts.Series.Add(series2);
            this.chartInterrupts.Size = new System.Drawing.Size(498, 355);
            this.chartInterrupts.TabIndex = 5;
            this.chartInterrupts.Text = "chartInterrupts";
            // 
            // labelInterrupts
            // 
            this.labelInterrupts.AutoSize = true;
            this.labelInterrupts.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInterrupts.Location = new System.Drawing.Point(439, 17);
            this.labelInterrupts.Name = "labelInterrupts";
            this.labelInterrupts.Size = new System.Drawing.Size(70, 16);
            this.labelInterrupts.TabIndex = 6;
            this.labelInterrupts.Text = "Interrputs :";
            // 
            // Processes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 442);
            this.Controls.Add(this.labelInterrupts);
            this.Controls.Add(this.chartInterrupts);
            this.Controls.Add(this.labelActiveProcesses);
            this.Controls.Add(this.btnProperties);
            this.Controls.Add(this.btnEndProcess);
            this.Controls.Add(this.btnGetProcess);
            this.Controls.Add(this.listProcess);
            this.Name = "Processes";
            this.Text = "Processes";
            this.Load += new System.EventHandler(this.Processes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartInterrupts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProcess;
        private System.Windows.Forms.Button btnGetProcess;
        private System.Windows.Forms.Button btnEndProcess;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Label labelActiveProcesses;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInterrupts;
        private System.Windows.Forms.Label labelInterrupts;
    }
}
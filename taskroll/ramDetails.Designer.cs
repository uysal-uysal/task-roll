namespace taskroll
{
    partial class ramDetails
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
            this.labelUsing = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ramProgress = new System.Windows.Forms.ProgressBar();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.chartRam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.labelTag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartRam)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsing
            // 
            this.labelUsing.AutoSize = true;
            this.labelUsing.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsing.Location = new System.Drawing.Point(24, 60);
            this.labelUsing.Name = "labelUsing";
            this.labelUsing.Size = new System.Drawing.Size(81, 16);
            this.labelUsing.TabIndex = 0;
            this.labelUsing.Text = "Ram Usage :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ramProgress
            // 
            this.ramProgress.Location = new System.Drawing.Point(330, 55);
            this.ramProgress.Name = "ramProgress";
            this.ramProgress.Size = new System.Drawing.Size(603, 23);
            this.ramProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ramProgress.TabIndex = 1;
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacity.Location = new System.Drawing.Point(24, 170);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(63, 16);
            this.labelCapacity.TabIndex = 2;
            this.labelCapacity.Text = "Capacity :";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailable.Location = new System.Drawing.Point(24, 220);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(59, 16);
            this.labelAvailable.TabIndex = 3;
            this.labelAvailable.Text = "Available";
            // 
            // chartRam
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRam.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRam.Legends.Add(legend2);
            this.chartRam.Location = new System.Drawing.Point(330, 84);
            this.chartRam.Name = "chartRam";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.GreenYellow;
            series2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series2.Legend = "Legend1";
            series2.Name = "Ram";
            series2.YValuesPerPoint = 4;
            this.chartRam.Series.Add(series2);
            this.chartRam.Size = new System.Drawing.Size(603, 318);
            this.chartRam.TabIndex = 4;
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManufacturer.Location = new System.Drawing.Point(24, 270);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(92, 16);
            this.labelManufacturer.TabIndex = 5;
            this.labelManufacturer.Text = "Manufacturer :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(24, 120);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 16);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name :";
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialNumber.Location = new System.Drawing.Point(24, 320);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(98, 16);
            this.labelSerialNumber.TabIndex = 8;
            this.labelSerialNumber.Text = "Serial Number :";
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.Location = new System.Drawing.Point(24, 370);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(36, 16);
            this.labelTag.TabIndex = 9;
            this.labelTag.Text = "Tag :";
            // 
            // ramDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 442);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.labelSerialNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.chartRam);
            this.Controls.Add(this.labelAvailable);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.ramProgress);
            this.Controls.Add(this.labelUsing);
            this.Name = "ramDetails";
            this.Text = "ramDetails";
            ((System.ComponentModel.ISupportInitialize)(this.chartRam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsing;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar ramProgress;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRam;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.Label labelTag;
    }
}
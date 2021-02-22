namespace CustomerFeedback
{
    partial class ChartReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFeedback = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblFeedbackChart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFeedback
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFeedback.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFeedback.Legends.Add(legend1);
            this.chartFeedback.Location = new System.Drawing.Point(50, 116);
            this.chartFeedback.Name = "chartFeedback";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Excellent";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Good";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Average";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Dissatisfied";
            this.chartFeedback.Series.Add(series1);
            this.chartFeedback.Series.Add(series2);
            this.chartFeedback.Series.Add(series3);
            this.chartFeedback.Series.Add(series4);
            this.chartFeedback.Size = new System.Drawing.Size(970, 347);
            this.chartFeedback.TabIndex = 0;
            this.chartFeedback.Text = "chart1";
            // 
            // lblFeedbackChart
            // 
            this.lblFeedbackChart.AutoSize = true;
            this.lblFeedbackChart.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackChart.Location = new System.Drawing.Point(251, 32);
            this.lblFeedbackChart.Name = "lblFeedbackChart";
            this.lblFeedbackChart.Size = new System.Drawing.Size(242, 32);
            this.lblFeedbackChart.TabIndex = 1;
            this.lblFeedbackChart.Text = "Feedback Chart";
            // 
            // ChartReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 516);
            this.Controls.Add(this.lblFeedbackChart);
            this.Controls.Add(this.chartFeedback);
            this.Name = "ChartReport";
            this.Text = "ChartReport";
            this.Load += new System.EventHandler(this.ChartReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFeedback;
        private System.Windows.Forms.Label lblFeedbackChart;
    }
}
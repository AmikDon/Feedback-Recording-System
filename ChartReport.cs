using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerFeedback.Class;
using System.IO;

namespace CustomerFeedback
{
    public partial class ChartReport : Form
    {
        public ChartReport()
        {
            InitializeComponent();
        }

        /*method that trigerrs when form is load
        first values from file is stored in an array
        then instance of class FeedbackChartData is made
        then using a for loop corresponding value is added to the chart*/
        private void ChartReport_Load(object sender, EventArgs e)
        {
            string[,] values = Values();
            FeedbackChartData cdata = new FeedbackChartData();
            for(int row = 1; row < 6; row++)
            {
                cdata.Criteria = values[row, 0];
                cdata.Excellent = Convert.ToInt32(values[row, 1]);
                cdata.Good = Convert.ToInt32(values[row, 2]);
                cdata.Average = Convert.ToInt32(values[row, 3]);
                cdata.Dissatisfied = Convert.ToInt32(values[row, 4]);

                chartFeedback.Series["Excellent"].Points.AddXY(cdata.Criteria, cdata.Excellent);
                chartFeedback.Series["Good"].Points.AddXY(cdata.Criteria, cdata.Good);
                chartFeedback.Series["Average"].Points.AddXY(cdata.Criteria, cdata.Average);
                chartFeedback.Series["Dissatisfied"].Points.AddXY(cdata.Criteria, cdata.Dissatisfied);
            }
            
            
        }

        //stores and returns values from file in an array
        private string[,] Values()
        {
            string filename = Constants.ChartReport;
            string[,] values = new string[6, 5];
            using (StreamReader chart = new StreamReader(filename))
            {
                string lines = "";
                int row = 0;
                while (lines != null)
                {
                    lines = chart.ReadLine();
                    if (lines != null)
                    {
                        string[] splitValues = lines.Split(',');
                        for (int col = 0; col < 5; col++)
                        {
                            values[row, col] = splitValues[col];
                        }
                        row += 1;
                    }
                }
                return values;
            }
        }
       
    }
}

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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        /*//method that triggers when the report form is load
        first number of rows is calculated by reading the feedbackreport file to declare the array
        then values is stored in an array
        then corresponding values is loaded on the datagridview using databinding source*/
        private void Report_Load(object sender, EventArgs e)
        {
            string filename = Constants.FeedbackReportPath;
            int roww = Row();
            using (StreamReader cObj = new StreamReader(filename))
            {
                string lines = "";
                int row = 0;
                string[,] values = new string[roww - 1, 9];
                while (lines != null)
                {
                    lines = cObj.ReadLine();
                    if (lines != null)
                    {
                        string[] splitValues = lines.Split(',');
                        for (int col = 0; col < 9; col++)
                        {
                            values[row, col] = splitValues[col];
                        }
                        row += 1;
                    }
                }

                //loading data in datagridview using databindingsource
                for (int i = 1; i < row; i++)
                {
                    feedbackDataBindingSource.Add(new FeedbackData()
                    {
                        CustomerName = values[i, 0],
                        ContactNo = values[i, 1],
                        Email = values[i, 2],
                        FoodQuality = values[i, 3],
                        StaffFriendliness = values[i, 4],
                        Cleanliness = values[i, 5],
                        OrderAccuracy = values[i, 6],
                        RestaurantAmbiance = values[i, 7],
                        Time = values[i, 8]

                    });
                }
                int totalRow = roww - 2;
                lblTotalFeedback.Text = totalRow.ToString();

            }      
        }

        //returns number of rows from report file
        private int Row()
        {
            string filename = Constants.FeedbackReportPath;
            using (StreamReader cObj = new StreamReader(filename))
            {
                string liness = "";
                int roww = 0;               
                //to get number of rows from report
                while (liness != null)
                {
                    liness = cObj.ReadLine();
                    roww += 1;
                }
                return roww;
            }
        }

        //method that triggers when the close button is clicked
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

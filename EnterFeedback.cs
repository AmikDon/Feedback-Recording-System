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
    public partial class EnterFeedback : Form
    {
        public EnterFeedback()
        {
            InitializeComponent();
        }

        
        //method that triggers when submit button is clicked
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            writeFeedbackReport();
            writeChartReport();
            clear();
        }

        /*method to write on chartreport file
        first the values from chart report file is stored in an array
        then corresponding criteria rating values is increased by 1 and changed in the array
        then the updated values in the array is written on the file*/
        private void writeChartReport()
        {
            string[,] values = Values(); 
            string[] rates = { "Excellent", "Good", "Average", "Dissatisfied" };

            //checking and storing selected criteria ratings accordingly in the array
            for (int i = 0; i < rates.Length; i++)
            {
                int y = 0;
                if (cmbFoodQuality.Text.Trim() == rates[i])
                {
                    int x = Convert.ToInt32(values[y + 1, i + 1]);
                    values[y + 1, i + 1] = Convert.ToString(x + 1);
                }
                if (cmbStaffFriendliness.Text.Trim() == rates[i])
                {
                    int x = Convert.ToInt32(values[y + 2, i + 1]);
                    values[y + 2, i + 1] = Convert.ToString(x + 1);
                }
                if (cmbCleanliness.Text.Trim() == rates[i])
                {
                    int x = Convert.ToInt32(values[y + 3, i + 1]);
                    values[y + 3, i + 1] = Convert.ToString(x + 1);
                }
                if (cmbOrderAccuracy.Text.Trim() == rates[i])
                {
                    int x = Convert.ToInt32(values[y + 4, i + 1]);
                    values[y + 4, i + 1] = Convert.ToString(x + 1);
                }
                if (cmbRestaurantAmbiance.Text.Trim() == rates[i])
                {
                    int x = Convert.ToInt32(values[y + 5, i + 1]);
                    values[y + 5, i + 1] = Convert.ToString(x + 1);
                }
            }

            //writing the new updated array in the file
            string filename = Constants.ChartReport;
            using(StreamWriter write = new StreamWriter(filename))
            {
                for(int i = 0; i < 6; i++)
                {
                    write.WriteLine(values[i,0]
                        + "," + values[i, 1]
                        + "," + values[i, 2]
                        + "," + values[i, 3]
                        + "," + values[i, 4]);
                }
            }
            
        }


        //method that stores and returns values from chartreport file in an array
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


        /*method to write on feedbackreport file
        first checks if the ratings are chossen or not
        then corresponding values are appended on feedbackreport file*/
        private void writeFeedbackReport()//writes in CustomerFeedbackReport.csv file
        {
            string filename = Constants.FeedbackReportPath;
            using (StreamWriter writeFB = new StreamWriter(filename, true))
            {
                if (cmbFoodQuality.Text.Trim() == "Select"
                    || cmbStaffFriendliness.Text.Trim() == "Select"
                    || cmbCleanliness.Text.Trim() == "Select"
                    || cmbOrderAccuracy.Text.Trim() == "Select"
                    || cmbRestaurantAmbiance.Text.Trim() == "Select")
                {
                    MessageBox.Show("Plese rate all criterias..", "Information");
                }
                else
                {
                    writeFB.WriteLine(txtName.Text.Trim() + ","
                    + txtContact.Text.Trim() + ","
                    + txtEmail.Text.Trim() + ","
                    + cmbFoodQuality.Text.Trim() + ","
                    + cmbStaffFriendliness.Text.Trim() + ","
                    + cmbCleanliness.Text.Trim() + ","
                    + cmbOrderAccuracy.Text.Trim() + ","
                    + cmbRestaurantAmbiance.Text.Trim() + ","
                    + DateTime.Now.ToString("d/M/yyyy H:m:ss "));
                    MessageBox.Show("Your feedback has been submitted", "Information");
                }
            }
        }

        //method that triggers when clear button is clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();


        }

        //method to clear all the text fields and comboboxes
        private void clear()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            cmbFoodQuality.Text = "Select";
            cmbStaffFriendliness.Text = "Select";
            cmbCleanliness.Text = "Select";
            cmbOrderAccuracy.Text = "Select";
            cmbRestaurantAmbiance.Text = "Select";
        }

        
    }
}

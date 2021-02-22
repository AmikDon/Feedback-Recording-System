using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFeedback.Class
{

    //For feedbackreport data
    public class FeedbackData
    {
        public string CustomerName { get; set; }

        public string ContactNo { get; set; }

        public string Email { get; set; }

        public string FoodQuality { get; set; }

        public string StaffFriendliness { get; set; }

        public string Cleanliness { get; set; }

        public string OrderAccuracy { get; set; }

        public string RestaurantAmbiance { get; set; }

        public string Time { get; set; }

    }

    //for chart data
    public class FeedbackChartData 
    {
        public string Criteria { get; set; }

        public int Excellent { get; set; }

        public int Good { get; set; }

        public int Average { get; set; }

        public int Dissatisfied { get; set; }
    }

    
}

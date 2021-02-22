using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomerFeedback.Class
{
    class Constants
    {
        public static string FeedbackReportPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Data\CustomerFeedbackReport.csv";
        public static string CriteriaPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Data\Criteria.txt";
        public static string ChartReport = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Data\ChartReport.csv";

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using CustomerFeedback.Class;

namespace CustomerFeedback
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            checkUser();
                
        }

        private void checkUser()
        {
            if (User.Role.ToLower() == "admin")
            {
                addCriteriaToolStripMenuItem.Visible = true;
            }
            else
            {
                addCriteriaToolStripMenuItem.Visible = false;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCriteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCriteria addCriteria = new AddCriteria();
            addCriteria.ShowDialog();
            
            
        }

        private void enterFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterFeedback feedback = new EnterFeedback();
            feedback.ShowDialog();
            
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
            
        }

        private void generateFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartReport chart = new ChartReport();
            chart.ShowDialog();
            
        }
    }
}

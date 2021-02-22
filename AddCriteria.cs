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
    public partial class AddCriteria : Form
    {
        public AddCriteria()
        {
            InitializeComponent();
        }

        //method that loads when the addcriteria form is opened
        private void AddCriteria_Load(object sender, EventArgs e)
        {
            getCriteria();
            
        }

        //method to get all the criterias from txt file and displaying in the listbox
        private void getCriteria()
        {
            string filename = Constants.CriteriaPath;
            using (StreamReader cObj = new StreamReader(filename))
            {
                string lines;
                while ((lines = cObj.ReadLine()) != null)
                {
                    listBoxExistingCriteria.Items.Add(lines);
                }
            }
        }

        //method that triggers when add button is clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNewCriteria.Text == "")
            {
                MessageBox.Show("Enter the required field","Error");
            }
            else
            {
                string filename = Constants.CriteriaPath;
                using (StreamWriter cObj = new StreamWriter(filename, true))
                {
                    cObj.WriteLine(txtNewCriteria.Text);
                }
                listBoxExistingCriteria.Items.Clear();
                getCriteria();
                txtNewCriteria.Clear();
                MessageBox.Show("New Criteria added", "Information");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterFeedback feedback = new EnterFeedback();
            feedback.ShowDialog();
            this.Hide();
        }

        
    }
}

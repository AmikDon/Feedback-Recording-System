namespace CustomerFeedback
{
    partial class Report
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCustomerFeedback = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblfeedbacksub = new System.Windows.Forms.Label();
            this.lblTotalFeedback = new System.Windows.Forms.Label();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodQualityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffFriendlinessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleanlinessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAccuracyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantAmbianceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.foodQualityDataGridViewTextBoxColumn,
            this.staffFriendlinessDataGridViewTextBoxColumn,
            this.cleanlinessDataGridViewTextBoxColumn,
            this.orderAccuracyDataGridViewTextBoxColumn,
            this.restaurantAmbianceDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.feedbackDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1554, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblCustomerFeedback
            // 
            this.lblCustomerFeedback.AutoSize = true;
            this.lblCustomerFeedback.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFeedback.Location = new System.Drawing.Point(484, 28);
            this.lblCustomerFeedback.Name = "lblCustomerFeedback";
            this.lblCustomerFeedback.Size = new System.Drawing.Size(406, 32);
            this.lblCustomerFeedback.TabIndex = 1;
            this.lblCustomerFeedback.Text = "Customer Feedback Report";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(509, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblfeedbacksub
            // 
            this.lblfeedbacksub.AutoSize = true;
            this.lblfeedbacksub.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeedbacksub.Location = new System.Drawing.Point(45, 355);
            this.lblfeedbacksub.Name = "lblfeedbacksub";
            this.lblfeedbacksub.Size = new System.Drawing.Size(254, 22);
            this.lblfeedbacksub.TabIndex = 3;
            this.lblfeedbacksub.Text = "Total feedback submitted :";
            // 
            // lblTotalFeedback
            // 
            this.lblTotalFeedback.AutoSize = true;
            this.lblTotalFeedback.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeedback.Location = new System.Drawing.Point(320, 355);
            this.lblTotalFeedback.Name = "lblTotalFeedback";
            this.lblTotalFeedback.Size = new System.Drawing.Size(0, 22);
            this.lblTotalFeedback.TabIndex = 4;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodQualityDataGridViewTextBoxColumn
            // 
            this.foodQualityDataGridViewTextBoxColumn.DataPropertyName = "FoodQuality";
            this.foodQualityDataGridViewTextBoxColumn.HeaderText = "FoodQuality";
            this.foodQualityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodQualityDataGridViewTextBoxColumn.Name = "foodQualityDataGridViewTextBoxColumn";
            this.foodQualityDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffFriendlinessDataGridViewTextBoxColumn
            // 
            this.staffFriendlinessDataGridViewTextBoxColumn.DataPropertyName = "StaffFriendliness";
            this.staffFriendlinessDataGridViewTextBoxColumn.HeaderText = "StaffFriendliness";
            this.staffFriendlinessDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffFriendlinessDataGridViewTextBoxColumn.Name = "staffFriendlinessDataGridViewTextBoxColumn";
            this.staffFriendlinessDataGridViewTextBoxColumn.Width = 125;
            // 
            // cleanlinessDataGridViewTextBoxColumn
            // 
            this.cleanlinessDataGridViewTextBoxColumn.DataPropertyName = "Cleanliness";
            this.cleanlinessDataGridViewTextBoxColumn.HeaderText = "Cleanliness";
            this.cleanlinessDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cleanlinessDataGridViewTextBoxColumn.Name = "cleanlinessDataGridViewTextBoxColumn";
            this.cleanlinessDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderAccuracyDataGridViewTextBoxColumn
            // 
            this.orderAccuracyDataGridViewTextBoxColumn.DataPropertyName = "OrderAccuracy";
            this.orderAccuracyDataGridViewTextBoxColumn.HeaderText = "OrderAccuracy";
            this.orderAccuracyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderAccuracyDataGridViewTextBoxColumn.Name = "orderAccuracyDataGridViewTextBoxColumn";
            this.orderAccuracyDataGridViewTextBoxColumn.Width = 125;
            // 
            // restaurantAmbianceDataGridViewTextBoxColumn
            // 
            this.restaurantAmbianceDataGridViewTextBoxColumn.DataPropertyName = "RestaurantAmbiance";
            this.restaurantAmbianceDataGridViewTextBoxColumn.HeaderText = "RestaurantAmbiance";
            this.restaurantAmbianceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.restaurantAmbianceDataGridViewTextBoxColumn.Name = "restaurantAmbianceDataGridViewTextBoxColumn";
            this.restaurantAmbianceDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // feedbackDataBindingSource
            // 
            this.feedbackDataBindingSource.DataSource = typeof(CustomerFeedback.Class.FeedbackData);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 450);
            this.Controls.Add(this.lblTotalFeedback);
            this.Controls.Add(this.lblfeedbacksub);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCustomerFeedback);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCustomerFeedback;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblfeedbacksub;
        private System.Windows.Forms.Label lblTotalFeedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodQualityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffFriendlinessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleanlinessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAccuracyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantAmbianceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource feedbackDataBindingSource;
    }
}
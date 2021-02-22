namespace CustomerFeedback
{
    partial class AddCriteria
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
            this.lblAddCriteria = new System.Windows.Forms.Label();
            this.lblNewCriteria = new System.Windows.Forms.Label();
            this.txtNewCriteria = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblExistingCriteria = new System.Windows.Forms.Label();
            this.listBoxExistingCriteria = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblAddCriteria
            // 
            this.lblAddCriteria.AutoSize = true;
            this.lblAddCriteria.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCriteria.Location = new System.Drawing.Point(432, 50);
            this.lblAddCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddCriteria.Name = "lblAddCriteria";
            this.lblAddCriteria.Size = new System.Drawing.Size(195, 32);
            this.lblAddCriteria.TabIndex = 0;
            this.lblAddCriteria.Text = "Add Criteria";
            // 
            // lblNewCriteria
            // 
            this.lblNewCriteria.Location = new System.Drawing.Point(84, 153);
            this.lblNewCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewCriteria.Name = "lblNewCriteria";
            this.lblNewCriteria.Size = new System.Drawing.Size(217, 36);
            this.lblNewCriteria.TabIndex = 1;
            this.lblNewCriteria.Text = "Enter new Criteria :";
            // 
            // txtNewCriteria
            // 
            this.txtNewCriteria.Location = new System.Drawing.Point(332, 153);
            this.txtNewCriteria.Name = "txtNewCriteria";
            this.txtNewCriteria.Size = new System.Drawing.Size(254, 31);
            this.txtNewCriteria.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(203, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblExistingCriteria
            // 
            this.lblExistingCriteria.AutoSize = true;
            this.lblExistingCriteria.Location = new System.Drawing.Point(839, 109);
            this.lblExistingCriteria.Name = "lblExistingCriteria";
            this.lblExistingCriteria.Size = new System.Drawing.Size(161, 22);
            this.lblExistingCriteria.TabIndex = 4;
            this.lblExistingCriteria.Text = "Existing Criteria";
            // 
            // listBoxExistingCriteria
            // 
            this.listBoxExistingCriteria.FormattingEnabled = true;
            this.listBoxExistingCriteria.ItemHeight = 22;
            this.listBoxExistingCriteria.Location = new System.Drawing.Point(756, 153);
            this.listBoxExistingCriteria.Name = "listBoxExistingCriteria";
            this.listBoxExistingCriteria.Size = new System.Drawing.Size(345, 290);
            this.listBoxExistingCriteria.TabIndex = 6;
            // 
            // AddCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 619);
            this.Controls.Add(this.listBoxExistingCriteria);
            this.Controls.Add(this.lblExistingCriteria);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNewCriteria);
            this.Controls.Add(this.lblNewCriteria);
            this.Controls.Add(this.lblAddCriteria);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCriteria";
            this.Text = "AddCriteria";
            this.Load += new System.EventHandler(this.AddCriteria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCriteria;
        private System.Windows.Forms.Label lblNewCriteria;
        private System.Windows.Forms.TextBox txtNewCriteria;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblExistingCriteria;
        private System.Windows.Forms.ListBox listBoxExistingCriteria;
    }
}
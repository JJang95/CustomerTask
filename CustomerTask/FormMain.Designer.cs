namespace CustomerTask
{
    partial class FormMain
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
            this.labelCustomer = new System.Windows.Forms.Label();
            this.listCustomer = new System.Windows.Forms.ListBox();
            this.listTask = new System.Windows.Forms.ListBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.textCustomerNameTwo = new System.Windows.Forms.TextBox();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(15, 92);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(51, 13);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "Customer";
            // 
            // listCustomer
            // 
            this.listCustomer.FormattingEnabled = true;
            this.listCustomer.Location = new System.Drawing.Point(15, 109);
            this.listCustomer.Name = "listCustomer";
            this.listCustomer.Size = new System.Drawing.Size(120, 173);
            this.listCustomer.TabIndex = 1;
            // 
            // listTask
            // 
            this.listTask.FormattingEnabled = true;
            this.listTask.Location = new System.Drawing.Point(141, 109);
            this.listTask.Name = "listTask";
            this.listTask.Size = new System.Drawing.Size(120, 173);
            this.listTask.TabIndex = 3;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(141, 92);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(81, 13);
            this.labelTask.TabIndex = 2;
            this.labelTask.Text = " Customer Task";
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(48, 50);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(87, 23);
            this.buttonAddCustomer.TabIndex = 4;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(15, 24);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(120, 20);
            this.textCustomerName.TabIndex = 5;
            // 
            // textCustomerNameTwo
            // 
            this.textCustomerNameTwo.Location = new System.Drawing.Point(144, 24);
            this.textCustomerNameTwo.Name = "textCustomerNameTwo";
            this.textCustomerNameTwo.Size = new System.Drawing.Size(120, 20);
            this.textCustomerNameTwo.TabIndex = 7;
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(169, 50);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(95, 23);
            this.buttonDeleteCustomer.TabIndex = 6;
            this.buttonDeleteCustomer.Text = "Delete Customer";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(299, 398);
            this.Controls.Add(this.textCustomerNameTwo);
            this.Controls.Add(this.buttonDeleteCustomer);
            this.Controls.Add(this.textCustomerName);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.listTask);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.listCustomer);
            this.Controls.Add(this.labelCustomer);
            this.Name = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.ListBox listCustomer;
        private System.Windows.Forms.ListBox listTask;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.TextBox textCustomerNameTwo;
        private System.Windows.Forms.Button buttonDeleteCustomer;
    }
}


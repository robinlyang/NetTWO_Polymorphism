namespace NetTWO_Polymorphism
{
    partial class PayrollForm
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
            this.hoursLbl = new System.Windows.Forms.Label();
            this.hoursTxtBox = new System.Windows.Forms.TextBox();
            this.payRateLbl = new System.Windows.Forms.Label();
            this.payRateTxtBox = new System.Windows.Forms.TextBox();
            this.salesLbl = new System.Windows.Forms.Label();
            this.salesTxtBox = new System.Windows.Forms.TextBox();
            this.hourlyPersonLbl = new System.Windows.Forms.Label();
            this.hourlyPersonTxtBox = new System.Windows.Forms.TextBox();
            this.comPersonLbl = new System.Windows.Forms.Label();
            this.comPersonTextBox = new System.Windows.Forms.TextBox();
            this.calcPayrollBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursLbl
            // 
            this.hoursLbl.AutoSize = true;
            this.hoursLbl.Location = new System.Drawing.Point(13, 13);
            this.hoursLbl.Name = "hoursLbl";
            this.hoursLbl.Size = new System.Drawing.Size(50, 17);
            this.hoursLbl.TabIndex = 0;
            this.hoursLbl.Text = "Hours:";
            // 
            // hoursTxtBox
            // 
            this.hoursTxtBox.Location = new System.Drawing.Point(89, 8);
            this.hoursTxtBox.Name = "hoursTxtBox";
            this.hoursTxtBox.Size = new System.Drawing.Size(72, 22);
            this.hoursTxtBox.TabIndex = 1;
            this.hoursTxtBox.Text = "47";
            // 
            // payRateLbl
            // 
            this.payRateLbl.AutoSize = true;
            this.payRateLbl.Location = new System.Drawing.Point(12, 49);
            this.payRateLbl.Name = "payRateLbl";
            this.payRateLbl.Size = new System.Drawing.Size(70, 17);
            this.payRateLbl.TabIndex = 2;
            this.payRateLbl.Text = "Pay Rate:";
            // 
            // payRateTxtBox
            // 
            this.payRateTxtBox.Location = new System.Drawing.Point(88, 46);
            this.payRateTxtBox.Name = "payRateTxtBox";
            this.payRateTxtBox.Size = new System.Drawing.Size(72, 22);
            this.payRateTxtBox.TabIndex = 3;
            this.payRateTxtBox.Text = "8";
            // 
            // salesLbl
            // 
            this.salesLbl.AutoSize = true;
            this.salesLbl.Location = new System.Drawing.Point(15, 89);
            this.salesLbl.Name = "salesLbl";
            this.salesLbl.Size = new System.Drawing.Size(47, 17);
            this.salesLbl.TabIndex = 4;
            this.salesLbl.Text = "Sales:";
            // 
            // salesTxtBox
            // 
            this.salesTxtBox.Location = new System.Drawing.Point(88, 86);
            this.salesTxtBox.Name = "salesTxtBox";
            this.salesTxtBox.Size = new System.Drawing.Size(72, 22);
            this.salesTxtBox.TabIndex = 5;
            this.salesTxtBox.Text = "5000";
            // 
            // hourlyPersonLbl
            // 
            this.hourlyPersonLbl.AutoSize = true;
            this.hourlyPersonLbl.Location = new System.Drawing.Point(188, 11);
            this.hourlyPersonLbl.Name = "hourlyPersonLbl";
            this.hourlyPersonLbl.Size = new System.Drawing.Size(102, 17);
            this.hourlyPersonLbl.TabIndex = 6;
            this.hourlyPersonLbl.Text = "Hourly Person:";
            // 
            // hourlyPersonTxtBox
            // 
            this.hourlyPersonTxtBox.Location = new System.Drawing.Point(342, 10);
            this.hourlyPersonTxtBox.Name = "hourlyPersonTxtBox";
            this.hourlyPersonTxtBox.Size = new System.Drawing.Size(116, 22);
            this.hourlyPersonTxtBox.TabIndex = 7;
            // 
            // comPersonLbl
            // 
            this.comPersonLbl.AutoSize = true;
            this.comPersonLbl.Location = new System.Drawing.Point(188, 49);
            this.comPersonLbl.Name = "comPersonLbl";
            this.comPersonLbl.Size = new System.Drawing.Size(140, 17);
            this.comPersonLbl.TabIndex = 8;
            this.comPersonLbl.Text = "Commission Person: ";
            // 
            // comPersonTextBox
            // 
            this.comPersonTextBox.Location = new System.Drawing.Point(342, 46);
            this.comPersonTextBox.Name = "comPersonTextBox";
            this.comPersonTextBox.Size = new System.Drawing.Size(116, 22);
            this.comPersonTextBox.TabIndex = 9;
            // 
            // calcPayrollBtn
            // 
            this.calcPayrollBtn.Location = new System.Drawing.Point(191, 74);
            this.calcPayrollBtn.Name = "calcPayrollBtn";
            this.calcPayrollBtn.Size = new System.Drawing.Size(267, 35);
            this.calcPayrollBtn.TabIndex = 10;
            this.calcPayrollBtn.Text = "Calculate Payrol";
            this.calcPayrollBtn.UseVisualStyleBackColor = true;
            this.calcPayrollBtn.Click += new System.EventHandler(this.calcPayrollBtn_Click);
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 130);
            this.Controls.Add(this.calcPayrollBtn);
            this.Controls.Add(this.comPersonTextBox);
            this.Controls.Add(this.comPersonLbl);
            this.Controls.Add(this.hourlyPersonTxtBox);
            this.Controls.Add(this.hourlyPersonLbl);
            this.Controls.Add(this.salesTxtBox);
            this.Controls.Add(this.salesLbl);
            this.Controls.Add(this.payRateTxtBox);
            this.Controls.Add(this.payRateLbl);
            this.Controls.Add(this.hoursTxtBox);
            this.Controls.Add(this.hoursLbl);
            this.Name = "PayrollForm";
            this.Text = "Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursLbl;
        private System.Windows.Forms.TextBox hoursTxtBox;
        private System.Windows.Forms.Label payRateLbl;
        private System.Windows.Forms.TextBox payRateTxtBox;
        private System.Windows.Forms.Label salesLbl;
        private System.Windows.Forms.TextBox salesTxtBox;
        private System.Windows.Forms.Label hourlyPersonLbl;
        private System.Windows.Forms.TextBox hourlyPersonTxtBox;
        private System.Windows.Forms.Label comPersonLbl;
        private System.Windows.Forms.TextBox comPersonTextBox;
        private System.Windows.Forms.Button calcPayrollBtn;
    }
}


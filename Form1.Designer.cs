namespace NorthwindCustomerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnCount = new System.Windows.Forms.Button();
            this.btnNames = new System.Windows.Forms.Button();
            this.btnLastNames = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // btnCount
            this.btnCount.Location = new System.Drawing.Point(36, 48);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(144, 23);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "Get Customer Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);

            // btnNames
            this.btnNames.Location = new System.Drawing.Point(36, 109);
            this.btnNames.Name = "btnNames";
            this.btnNames.Size = new System.Drawing.Size(144, 23);
            this.btnNames.TabIndex = 1;
            this.btnNames.Text = "Get Customer Names";
            this.btnNames.UseVisualStyleBackColor = true;
            this.btnNames.Click += new System.EventHandler(this.btnNames_Click);

            // btnLastNames
            this.btnLastNames.Location = new System.Drawing.Point(35, 169);
            this.btnLastNames.Name = "btnLastNames";
            this.btnLastNames.Size = new System.Drawing.Size(145, 23);
            this.btnLastNames.TabIndex = 2;
            this.btnLastNames.Text = "Get Last Names";
            this.btnLastNames.UseVisualStyleBackColor = true;
            this.btnLastNames.Click += new System.EventHandler(this.btnLastNames_Click);

            // lblCount
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(33, 226);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(100, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Count appears here";

            // lstCustomers
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(35, 283);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(200, 95);
            this.lstCustomers.TabIndex = 4;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnLastNames);
            this.Controls.Add(this.btnNames);
            this.Controls.Add(this.btnCount);
            this.Name = "Form1";
            this.Text = "Northwind Customer App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnNames;
        private System.Windows.Forms.Button btnLastNames;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ListBox lstCustomers;
    }
}
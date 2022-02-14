
namespace CsharpMidterm
{
    partial class Form1
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
            this.BtnProcessPay = new System.Windows.Forms.Button();
            this.btnProcessTotal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtDed = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.txtTotGross = new System.Windows.Forms.TextBox();
            this.txtTotDed = new System.Windows.Forms.TextBox();
            this.txtTotNet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnProcessPay
            // 
            this.BtnProcessPay.Location = new System.Drawing.Point(119, 154);
            this.BtnProcessPay.Name = "BtnProcessPay";
            this.BtnProcessPay.Size = new System.Drawing.Size(75, 36);
            this.BtnProcessPay.TabIndex = 0;
            this.BtnProcessPay.Text = "Process Paycheck";
            this.BtnProcessPay.UseVisualStyleBackColor = true;
            this.BtnProcessPay.Click += new System.EventHandler(this.BtnProcessPay_Click);
            // 
            // btnProcessTotal
            // 
            this.btnProcessTotal.Location = new System.Drawing.Point(223, 154);
            this.btnProcessTotal.Name = "btnProcessTotal";
            this.btnProcessTotal.Size = new System.Drawing.Size(75, 36);
            this.btnProcessTotal.TabIndex = 1;
            this.btnProcessTotal.Text = "Process Totals";
            this.btnProcessTotal.UseVisualStyleBackColor = true;
            this.btnProcessTotal.Click += new System.EventHandler(this.btnProcessTotal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(332, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(436, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(119, 68);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 5;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(119, 110);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 6;
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(130, 254);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(75, 20);
            this.txtGross.TabIndex = 7;
            // 
            // txtDed
            // 
            this.txtDed.Location = new System.Drawing.Point(267, 256);
            this.txtDed.Name = "txtDed";
            this.txtDed.Size = new System.Drawing.Size(74, 20);
            this.txtDed.TabIndex = 8;
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(410, 256);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(75, 20);
            this.txtNet.TabIndex = 9;
            // 
            // txtTotGross
            // 
            this.txtTotGross.Location = new System.Drawing.Point(130, 337);
            this.txtTotGross.Name = "txtTotGross";
            this.txtTotGross.Size = new System.Drawing.Size(75, 20);
            this.txtTotGross.TabIndex = 10;
            // 
            // txtTotDed
            // 
            this.txtTotDed.Location = new System.Drawing.Point(267, 337);
            this.txtTotDed.Name = "txtTotDed";
            this.txtTotDed.Size = new System.Drawing.Size(74, 20);
            this.txtTotDed.TabIndex = 11;
            // 
            // txtTotNet
            // 
            this.txtTotNet.Location = new System.Drawing.Point(410, 337);
            this.txtTotNet.Name = "txtTotNet";
            this.txtTotNet.Size = new System.Drawing.Size(75, 20);
            this.txtTotNet.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hours Worked";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rate of Pay";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(44, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(557, 2);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(44, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(557, 2);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Gross Wages - Deductions = Net Wages";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(339, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total Gross Wages - Total Deducitons = Total Net Pay (All Employees)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotNet);
            this.Controls.Add(this.txtTotDed);
            this.Controls.Add(this.txtTotGross);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.txtDed);
            this.Controls.Add(this.txtGross);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcessTotal);
            this.Controls.Add(this.BtnProcessPay);
            this.Name = "Form1";
            this.Text = "Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProcessPay;
        private System.Windows.Forms.Button btnProcessTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox txtDed;
        private System.Windows.Forms.TextBox txtNet;
        private System.Windows.Forms.TextBox txtTotGross;
        private System.Windows.Forms.TextBox txtTotDed;
        private System.Windows.Forms.TextBox txtTotNet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


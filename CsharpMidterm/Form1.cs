using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpMidterm
{
    //Andrew Rausch Midterm
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double TotGross;
        Double TotDed;
        Double TotNet;

        private void Pay(Double Num1, Double Num2)
        {
            Double TotalPay= 0;
            Double Ded= 0;
            Double NetPay=0;

            if (Num1 > 40)
            { TotalPay = (40 * Num2) + ((Num1 - 40) * (Num2 * 1.5)); }
            else if (Num1 <= 40)
            { TotalPay = Num1 * Num2; }

            if (TotalPay > 200)
            { Ded = (TotalPay * 0.15); }
            else if (TotalPay < 200)
            { Ded = 0; }

            NetPay = TotalPay - Ded;
            txtDed.Text = Ded.ToString("c");
            txtGross.Text = TotalPay.ToString("c");
            txtNet.Text = NetPay.ToString("c");

            TotDed += Ded;
            TotGross += TotalPay;
            TotNet += NetPay;

        }

        private void BtnProcessPay_Click(object sender, EventArgs e)
        {
            Pay(Convert.ToDouble(txtHours.Text), Convert.ToDouble(txtRate.Text));

            txtName.Clear();
            txtHours.Clear();
            txtRate.Clear();
            txtName.Focus();

        }

        private void btnProcessTotal_Click(object sender, EventArgs e)
        {
            txtDed.Clear();
            txtGross.Clear();
            txtNet.Clear();

            txtTotDed.Text = TotDed.ToString("c");
            txtTotGross.Text = TotGross.ToString("c");
            txtTotNet.Text = TotNet.ToString("c");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtHours.Clear();
            txtRate.Clear();
            txtGross.Clear();
            txtDed.Clear();
            txtNet.Clear();
            txtTotGross.Clear();
            txtTotDed.Clear();
            txtTotNet.Clear();

            txtName.Focus();
            TotDed = 0;
            TotGross = 0;
            TotNet = 0;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

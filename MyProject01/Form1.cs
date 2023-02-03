using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string text=txtBoxAmnt.Text;
            double amount = Convert.ToDouble(text);

            string rateText = txtRate.Text;
            double rate= Convert.ToDouble(rateText);


            if (amount < 0 && rate < 0)
            {
                lblInput.Text = "Both Amount and Rate Input is Invalid";
                return;
            }
            else if (amount < 0)
            {
                lblInput.Text = "Your Amount Input is Invalid";
                return;
            }
            else if (rate < 0)
            {
                lblInput.Text = "Your Rate Input is Invalid";
                return;
            }

            //result.ToString("0.00")

            double result;
            result = amount * rate;

            //txtResult.Text = Convert.ToString(result);       
            //lblInput.Text= "Your Converted Amount is: " + Convert.ToString(result) + "/-";

            txtResult.Text = result.ToString("F2");
            lblInput.Text = "Your Converted Amount from USD is: " + result.ToString("F2") + "/-";

            

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void txtBoxAmnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIndex.SelectedIndex == 0) //BDT
            {
                txtRate.Text = "104.92";
            }
            else if (cmbIndex.SelectedIndex == 1) //CAD
            {
                txtRate.Text = "1.33";
            }
            else if (cmbIndex.SelectedIndex == 2) //GBP
            {
                txtRate.Text = "0.81";
            }
            else if (cmbIndex.SelectedIndex == 3) //INR
            {
                txtRate.Text = "81.81";
            }
            else if (cmbIndex.SelectedIndex == 4) //EUR
            {
                txtRate.Text = "0.91";
            }
            else if (cmbIndex.SelectedIndex == 5) //AUD
            {
                txtRate.Text = "1.40";
            }
        }
    }
}

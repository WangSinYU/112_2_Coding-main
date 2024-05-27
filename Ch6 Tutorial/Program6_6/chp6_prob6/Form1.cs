using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chp6_prob6
{
    public partial class Form1 : Form
    {
        const decimal stayPerDay = 5550.00m;
        public Form1()
        {
            InitializeComponent();
        }

        private decimal CaleStayCharges(int day)
        {
            return stayPerDay * day;
        }

        private decimal CaleMiseCharges(decimal foodBill, decimal spaBill, decimal carRental, decimal medicalBill)
        {
            return (foodBill + spaBill + carRental + medicalBill);
        }
       
        private decimal CaleTotalCharges(decimal stayBill, decimal miscellaneous)
        {
            return (stayBill + miscellaneous);
        }
        
        private bool IsInputValid(ref int days, ref decimal fb, ref decimal sb,
                                  ref decimal cb, ref decimal mb)
        {
            if (int.TryParse(textBox1.Text, out days) && decimal.TryParse(textBox2.Text,out fb) &&
                decimal.TryParse(textBox3.Text, out sb) && decimal.TryParse(textBox4.Text, out cb) &&
                decimal.TryParse(textBox5.Text, out mb))
            {
                return true;
            }
            else
            {
                MessageBox.Show("資料格式錯誤");
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int days = 0;
            decimal fb = 0m, sb = 0m, cb = 0m, mb = 0m;
            decimal stayCharge, miscCharge;
            decimal totalCharge;

            if (IsInputValid(ref days, ref fb, ref sb, ref cb, ref mb))
            {
                stayCharge = CaleStayCharges(days); //計算住宿費
                miscCharge = CaleMiseCharges(fb, sb, cb, mb); //計算其他費用
                totalCharge = CaleTotalCharges(stayCharge, miscCharge); //計算總花費
                MessageBox.Show("Total Bill : " + totalCharge.ToString("c"));
            }
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

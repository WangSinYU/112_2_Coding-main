using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System. Windows.Forms;

namespace Account_Simulator
{
    class BankAccount
    {
        private decimal balance;

        public BankAccount (decimal startingBalance) //建構子
        {
            balance = startingBalance;
        }
        public decimal Balance  //屬性
        {
            get { return balance; }
        }

        public void Deposit (decimal amount)
        {
            if (amount > 0m )
            {
                balance += amount;
            }
            else
            {
                MessageBox.Show("存款金額錯誤");
            }
        }
        public void Withdraw (decimal amount)
        {
            if(amount > 0m && amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                MessageBox.Show("存款金額額滿");
            }
        }
    }
}

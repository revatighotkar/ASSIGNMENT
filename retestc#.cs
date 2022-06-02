using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Retest
{

    public class LoanProcess
    {
        private const int YEARS_COUNT = 3;
        private const double INTEREST_RATE = 13;



        public LoanProcess(int loadNo, string customerName, int loanAmount, int accountBalance)
        {
            Load_No = loadNo;
            CustomerName = customerName;
            LoanAmount = loanAmount;
            AccountBalance = accountBalance;
        }



        public int Load_No { get; set; }



        public string CustomerName { get; set; }



        public int LoanAmount { get; set; }



        public double EMI_Amount { get; set; }



        public int AccountBalance { get; set; }



        public void Calculate_EMI()
        {
            // reducing-balance method A = P * (r*(r+1)^n)/((1+r)^n - 1)
            // where P = principal borrowed(load amount)
            // r = periodic interest (annual interest rate / 1200)
            // n = total number of payment (number of month)



            var periodicInterestRate = INTEREST_RATE / 1200; // periodic interest rate
            var monthCount = YEARS_COUNT * 12; // common month count



            EMI_Amount = LoanAmount * (
            (periodicInterestRate * Math.Pow((1 + periodicInterestRate), monthCount))
            / (Math.Pow((1 + periodicInterestRate), monthCount) - 1));
        }



        public void CheckBalance()
        {
            if (AccountBalance < EMI_Amount)
            {
                throw new Exception("Not Sufficient Balance to repay Loan");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalculation
{
    public class CreditCard 
    {

        public string Name { get; set; }
        public int Balance { get; set; }
        public double Rate { get; set; }

        public CreditCard(string name, int balance, double rate)
        {
            Name = name;
            Balance = balance;
            Rate = rate;
        }
    }
}

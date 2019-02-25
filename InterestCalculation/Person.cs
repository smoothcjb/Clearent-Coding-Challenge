using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalculation
{
    public class Person
    {
        public List<Wallet> _wallets;
        public string Name { get; set; }
        public List<Wallet> Wallets { get; set; }

        public Person() { }
        public Person(string name, Wallet wallet)

        {
            List<Wallet> Wallets = new List<Wallet>
            {

            wallet
           

            };

            Name = name;
            _wallets = Wallets;

        }
        public Person(string name, Wallet wallet1, Wallet wallet2)

        {
            List<Wallet> Wallets = new List<Wallet>
            {

            wallet1,
            wallet2

            };

            Name = name;
            _wallets = Wallets;
            
        }

    }
    
}

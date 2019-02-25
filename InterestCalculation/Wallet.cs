using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalculation
{
    public class Wallet
    {
        public List<CreditCard> _creditCards;
        public List<CreditCard> CreditCards { get; set; }
            

        public Wallet() { }
        public Wallet(List<CreditCard> creditCards)
        {
            List<CreditCard> CreditCards = new List<CreditCard>();
            foreach(var card in creditCards)
            {
                CreditCards.Add(card);
            }
             
          _creditCards = CreditCards;
        }
    }
}
    


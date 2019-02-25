using System;
using System.Collections.Generic;
using System.Text;

	

	

namespace InterestCalculation
{
    public class TestData
    {
        public static Visa visa = new Visa("Visa", 100, .10);
        public static MC mc = new MC("MC", 100, .05);
        public static Discover discover = new Discover("Discover", 100, .01);


        public static List<CreditCard> cardList1 = new List<CreditCard>() { visa, mc, discover };
        public static List<CreditCard> cardList2 = new List<CreditCard>() { visa, discover };
        public static List<CreditCard> cardList3 = new List<CreditCard>() { mc};
        public static List<CreditCard> cardList4 = new List<CreditCard>() { visa, mc };

        




    }
}
